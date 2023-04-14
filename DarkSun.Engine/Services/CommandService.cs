﻿using System.Diagnostics;
using System.Reflection;
using DarkSun.Api.Attributes.Services;
using DarkSun.Api.Engine.Attributes.Commands;
using DarkSun.Api.Engine.Interfaces.Commands;
using DarkSun.Api.Engine.Interfaces.Services;
using DarkSun.Api.Engine.Types.Commands;
using DarkSun.Api.Utils;
using DarkSun.Engine.Services.Base;
using Microsoft.Extensions.Logging;

namespace DarkSun.Engine.Services
{
    [DarkSunEngineService(nameof(CommandService), 13)]
    public class CommandService : BaseService<ICommandService>, ICommandService
    {
        private readonly Dictionary<CommandActionType, ICommandActionExecutor> _actionExecutors = new();
        private readonly HashSet<ICommandAction> _playersActionsQueue = new();
        private readonly HashSet<ICommandAction> _npcsActionsQueue = new();
        private readonly IServiceProvider _container;
        private readonly SemaphoreSlim _actionListLock = new(1);
        public CommandService(ILogger<ICommandService> logger, IServiceProvider container) : base(logger)
        {
            _container = container;
        }

        protected override ValueTask<bool> StartAsync()
        {
            PrepareSchedulerExecutors();
            Engine.SchedulerService.OnTick += SchedulerServiceOnOnTickAsync;
            return base.StartAsync();
        }

        private void PrepareSchedulerExecutors()
        {
            AssemblyUtils.GetAttribute<CommandActionAttribute>().ForEach(s =>
            {
                var attr = s.GetCustomAttribute<CommandActionAttribute>()!;
                Logger.LogInformation("Adding {Type} from {ActionType}", s.Name, attr.Type);
                var executor = _container.GetService(s);
                _actionExecutors.Add(attr.Type, (ICommandActionExecutor)executor!);
            });
        }

        public void EnqueuePlayerAction<ActionEntity>(ActionEntity entity) where ActionEntity : ICommandAction
        {

            _actionListLock.Wait();
            _playersActionsQueue.Add(entity);
            _actionListLock.Release();
        }

        public void EnqueueNpcAction<ActionEntity>(ActionEntity entity) where ActionEntity : ICommandAction
        {
            _actionListLock.Wait();
            _npcsActionsQueue.Add(entity);
            _actionListLock.Release();
        }

        private async Task SchedulerServiceOnOnTickAsync(double deltaTime)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            await _actionListLock.WaitAsync();

            var actionsToRemove = new List<ICommandAction>();
            foreach (var action in _playersActionsQueue)
            {
                action.Tick -= stopWatch.ElapsedMilliseconds;

                if (action.Tick <= 0)
                {
                    await ProcessPlayerActionAsync(action);
                    actionsToRemove.Add(action);
                }
            }
            actionsToRemove.ForEach(k => _playersActionsQueue.Remove(k));


            foreach (var action in _npcsActionsQueue)
            {
                action.Tick -= stopWatch.ElapsedMilliseconds;
                if (action.Tick <= 0)
                {
                    // await ProcessPlayerAction(action);
                }
            }

            _actionListLock.Release();
        }

        private async Task ProcessPlayerActionAsync(ICommandAction action)
        {
            try
            {
                if (_actionExecutors.TryGetValue(action.Type, out var executor))
                {
                    await executor.ProcessAsync(action);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("Error during executing action: {Type}: {Ex}", action.Type, ex);
            }
        }
    }
}

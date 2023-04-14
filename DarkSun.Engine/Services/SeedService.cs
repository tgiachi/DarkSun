﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DarkSun.Api.Attributes.Services;
using DarkSun.Api.Data.Config;
using DarkSun.Api.Engine.Attributes.Seed;
using DarkSun.Api.Engine.Interfaces.Services;
using DarkSun.Api.Engine.Serialization.Seeds;
using DarkSun.Api.Engine.Serialization;
using DarkSun.Api.Utils;
using DarkSun.Api.World.Types.GameObjects;
using DarkSun.Api.World.Types.Tiles;
using DarkSun.Api.World.Types.Utils;
using DarkSun.Database.Entities.Base;
using DarkSun.Database.Entities.Item;
using DarkSun.Database.Entities.Objects;
using DarkSun.Database.Entities.Races;
using DarkSun.Engine.Services.Base;
using Microsoft.Extensions.Logging;

namespace DarkSun.Engine.Services
{
    [DarkSunEngineService(nameof(SeedService), 8)]
    public class SeedService : BaseService<SeedService>, ISeedService
    {
        private readonly HashSet<RaceEntity> _racesSeed = new();
        private readonly HashSet<GameObjectEntity> _gameObjectSeed = new();
        private readonly HashSet<ItemEntity> _itemsSeed = new();

        private readonly DirectoriesConfig _directoriesConfig;

        public SeedService(ILogger<SeedService> logger, DirectoriesConfig directoriesConfig) : base(logger)
        {
            _directoriesConfig = directoriesConfig;
        }

        protected override async ValueTask<bool> StartAsync()
        {
            await CheckSeedTemplatesAsync();
            await CheckSeedDirectoriesAsync();
            await LoadCsvSeedsAsync();
            return true;
        }

        private async Task LoadCsvSeedsAsync()
        {
            Logger.LogInformation("Loading seeds");
            await LoadSeedAsync<WorldObjectSeedEntity>();
            await LoadSeedAsync<RaceObjectSeedEntity>();
            await LoadSeedAsync<ItemObjectSeedEntity>();
            await LoadSeedAsync<ItemDropObjectSeedEntity>();
        }

        private async Task CheckSeedTemplatesAsync()
        {
            Logger.LogInformation("Checking Seed Templates");
            await CheckSeedTemplateAsync<ItemDropObjectSeedEntity>();
            await CheckSeedTemplateAsync<ItemObjectSeedEntity>();
            await CheckSeedTemplateAsync<WorldObjectSeedEntity>();
            await CheckSeedTemplateAsync<RaceObjectSeedEntity>();
        }

        private Task CheckSeedDirectoriesAsync()
        {
            var attributes = AssemblyUtils.GetAttribute<SeedObjectAttribute>();
            foreach (var dir in attributes.Select(type =>
                             type.GetCustomAttribute<SeedObjectAttribute>()!)
                         .Select(attr => Path.Join(_directoriesConfig[DirectoryNameType.Seeds], attr.TemplateDirectory))
                         .Where(dir => !Directory.Exists(dir)))
            {
                Directory.CreateDirectory(dir);
            }

            return Task.CompletedTask;
        }

        private Task LoadSeedAsync<TEntity>() where TEntity : class, new()
        {
            var attribute = typeof(TEntity).GetCustomAttribute<SeedObjectAttribute>();
            var directory = Path.Join(_directoriesConfig[DirectoryNameType.Seeds], attribute!.TemplateDirectory);
            var files = Directory.GetFiles(directory, "*.csv");

            Logger.LogInformation("Found {Files} for {Type} seed", files.Length, attribute.TemplateDirectory);

            return Task.CompletedTask;
        }

        private async Task CheckSeedTemplateAsync<TEntity>() where TEntity : class, new()
        {
            Logger.LogInformation("Checking Seed Template for type: {Type}", typeof(TEntity).Name);
            var fileName = Path.Join(_directoriesConfig[DirectoryNameType.SeedTemplates],
                $"{typeof(TEntity).Name.Replace("Entity", "").ToUnderscoreCase()}.csv");
            if (!File.Exists(fileName))
            {
                await SeedCsvParser.Instance.WriteHeaderToFileAsync(fileName, Enumerable.Empty<TEntity>());
            }
        }

        public void AddRaceToSeed(string race, string description, short tileId, BaseStatEntity stat)
        {
            Logger.LogInformation("Adding Race {Race} to seed", race);
            _racesSeed.Add(new RaceEntity()
            {
                Name = race,
                Description = description,
                Dexterity = stat.Dexterity,
                Intelligence = stat.Intelligence,
                Luck = stat.Luck,
                Strength = stat.Strength,
                TileId = tileId.ParseTileType()
            });
        }

        public void AddGameObjectToSeed(string name, string description, TileType tileType,
            GameObjectType gameObjectType)
        {
            _gameObjectSeed.Add(new GameObjectEntity()
            {
                Name = name, Description = description, TileId = tileType, Type = gameObjectType
            });
        }
    }
}

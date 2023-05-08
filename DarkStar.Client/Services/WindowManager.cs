﻿using System;
using System.Reflection;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Threading;
using DarkStar.Client.Attributes;
using DarkStar.Client.Controls;
using DarkStar.Client.ViewModels;

using Microsoft.Extensions.Logging;

namespace DarkStar.Client.Services;

public class WindowManager
{
    private readonly ILogger _logger;

    private readonly IServiceProvider _serviceProvider;
    private PageViewControl _pageViewControl;

    public WindowManager(ILogger<WindowManager> logger, IServiceProvider serviceProvider)
    {
        _logger = logger;
        _serviceProvider = serviceProvider;
    }

    public void InitializePageView(PageViewControl pageViewControl) => _pageViewControl = pageViewControl;


    public async Task NavigateToPage<T>() where T : PageViewModelBase
    {
        await Dispatcher.UIThread.InvokeAsync(
            async () =>
            {
                try
                {
                    var pageViewAttribute = typeof(T).GetCustomAttribute<PageViewAttribute>();
                    if (pageViewAttribute == null)
                    {
                        _logger.LogError("PageViewAttribute not found for {Name}", typeof(T).Name);
                        throw new Exception($"PageViewAttribute not found for {typeof(T).Name}");
                    }

                    var pageView = _serviceProvider.GetService(pageViewAttribute.View) as UserControl;
                    var pageViewModel = _serviceProvider.GetService(typeof(T)) as PageViewModelBase;

                    pageView.DataContext = pageViewModel;

                    if (_pageViewControl.ControlProperty.Content is UserControl
                        {
                            DataContext: PageViewModelBase pageViewModelBase
                        })
                    {
                        await pageViewModelBase.OnClose();
                    }

                    _pageViewControl.ControlProperty.Content = pageView;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        );
    }
}

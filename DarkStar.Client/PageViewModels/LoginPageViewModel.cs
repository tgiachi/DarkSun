﻿using System;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Threading.Tasks;
using Avalonia.Threading;
using DarkStar.Client.Attributes;
using DarkStar.Client.PageViews;
using DarkStar.Client.Services;
using DarkStar.Client.ViewModels;
using DarkStar.Network.Data;
using DarkStar.Network.Interfaces;
using DarkStar.Network.Protocol.Interfaces.Messages;
using DarkStar.Network.Protocol.Messages.Accounts;
using DarkStar.Network.Protocol.Messages.Server;
using DarkStar.Network.Protocol.Messages.TileSet;
using DarkStar.Network.Protocol.Types;
using ReactiveUI;

namespace DarkStar.Client.PageViewModels;

[PageView(typeof(LoginPageView))]
public class LoginPageViewModel : PageViewModelBase, INetworkClientMessageListener
{
    private readonly ServiceContext _serviceContext;
    public ObservableCollection<string> Servers { get; set; }

    public string SelectedServer { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public string ErrorConnection { get; set; }
    public string ServerName { get; set; }
    public string ServerVersion { get; set; }

    private bool _serverResponse;
    private bool _serverVersion;

    public ReactiveCommand<Unit, Task> LoginCommand { get; set; }

    public LoginPageViewModel(ServiceContext serviceContext)
    {
        ServerName = "No connection";
        _serviceContext = serviceContext;
        _serviceContext.NetworkClient.OnClientConnected += NetworkClientOnOnClientConnected;
        _serviceContext.NetworkClient.RegisterMessageListener(DarkStarMessageType.ServerVersionResponse, this);
        _serviceContext.NetworkClient.RegisterMessageListener(DarkStarMessageType.ServerNameResponse, this);
        _serviceContext.NetworkClient.RegisterMessageListener(DarkStarMessageType.TileSetListResponse, this);
        _serviceContext.NetworkClient.RegisterMessageListener(DarkStarMessageType.AccountLoginResponse, this);

        Servers = new ObservableCollection<string> { "http://localhost:5000/" };

        Username = "";
        Password = "";

        LoginCommand = ReactiveCommand.Create(
            async () =>
            {
                var parsedUri = new Uri(SelectedServer);
                _serviceContext.ServerUrl = parsedUri.ToString();
                await _serviceContext.NetworkClient.ConnectAsync(
                    new DarkStarNetworkClientConfig
                    {
                        Address = $"http://localhost",
                        Port = 5000
                    }
                );
            }
        );
    }

    private async Task NetworkClientOnOnClientConnected()
    {
        await _serviceContext.NetworkClient.SendMessageAsync(new AccountLoginRequestMessage(Username, Password));
    }

    public override Task OnClose()
    {
        _serviceContext.NetworkClient.UnregisterMessageListener(DarkStarMessageType.ServerVersionResponse, this);
        _serviceContext.NetworkClient.OnClientConnected -= NetworkClientOnOnClientConnected;
        return Task.CompletedTask;
    }

    public Task OnMessageReceivedAsync(DarkStarMessageType messageType, IDarkStarNetworkMessage message)
    {
        return Dispatcher.UIThread.InvokeAsync(
            async () =>
            {
                if (messageType == DarkStarMessageType.ServerVersionResponse)
                {
                    var serverVersionResponse = (ServerVersionResponseMessage)message;
                    ServerVersion =
                        $"v {serverVersionResponse.Major}.{serverVersionResponse.Minor}.{serverVersionResponse.Build}";

                    _serverVersion = true;
                }

                if (messageType == DarkStarMessageType.ServerNameResponse)
                {
                    var serverNameResponse = (ServerNameResponseMessage)message;
                    ServerName = serverNameResponse.ServerName;
                    _serverResponse = true;
                }

                if (messageType == DarkStarMessageType.TileSetListResponse)
                {
                    var tileSetList = (TileSetListResponseMessage)message;
                    foreach (var tileSet in tileSetList.TileSets)
                    {
                    }
                }

                if (messageType == DarkStarMessageType.AccountLoginResponse)
                {
                    var accountLoginResponse = (AccountLoginResponseMessage)message;
                    if (!accountLoginResponse.Success)
                    {
                        ErrorConnection = "Invalid username or password!";
                    }
                }

                if (_serverResponse && _serverVersion)
                {
                    await _serviceContext.NetworkClient.SendMessageAsync(new TileSetListRequestMessage());
                }
            }
        );
    }
}

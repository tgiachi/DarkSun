﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkStar.Network.Interfaces;
using DarkStar.Network.Protocol.Interfaces.Messages;
using DarkStar.Network.Protocol.Types;

namespace DarkStar.Network.Server.Interfaces;

public interface IDarkSunNetworkServer
{
    delegate Task MessageReceivedDelegate(Guid sessionId, DarkStarMessageType messageType,
        IDarkStarNetworkMessage message);

    delegate Task<List<IDarkStarNetworkMessage>> ClientConnectedMessages(Guid sessionId);

    delegate Task ClientDisconnectedDelegate(Guid sessionId);

    event MessageReceivedDelegate OnMessageReceived;
    event ClientConnectedMessages OnClientConnected;
    event ClientDisconnectedDelegate OnClientDisconnected;

    Task StartAsync();
    Task StopAsync();
    Task SendMessageAsync(Guid sessionId, IDarkStarNetworkMessage message);
    Task SendMessageAsync(Guid sessionId, List<IDarkStarNetworkMessage> message);
    Task BroadcastMessageAsync(IDarkStarNetworkMessage message);
    Task DispatchMessageReceivedAsync(Guid sessionId, DarkStarMessageType messageType, IDarkStarNetworkMessage message);
    void RegisterMessageListener(DarkStarMessageType messageType, INetworkServerMessageListener serverMessageListener);
}

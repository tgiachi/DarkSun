﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkSun.Network.Attributes;
using DarkSun.Network.Protocol.Interfaces.Messages;
using DarkSun.Network.Protocol.Types;
using ProtoBuf;


namespace DarkSun.Network.Protocol.Live;

[ProtoContract]
[NetworkMessage(DarkSunMessageType.Pong)]
public class PongMessageResponse : IDarkSunNetworkMessage
{
    [ProtoMember(1)]
    public long TimeStamp { get; set; }
}

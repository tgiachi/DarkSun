using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkStar.Network.Attributes;
using DarkStar.Network.Protocol.Interfaces.Messages;
using DarkStar.Network.Protocol.Types;
using ProtoBuf;

namespace DarkStar.Network.Protocol.Messages.TileSet;

[NetworkMessage(DarkStarMessageType.TileSetDownloadRequest)]
[ProtoContract]
public class TileSetDownloadRequestMessage : IDarkStarNetworkMessage
{
    [ProtoMember(1)] public string TileName { get; set; } = null!;


    public TileSetDownloadRequestMessage(string tileName) => TileName = tileName;

    public TileSetDownloadRequestMessage()
    {
    }
}

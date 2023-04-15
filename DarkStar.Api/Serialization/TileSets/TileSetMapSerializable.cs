﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkStar.Api.Serialization.Converters;
using DarkStar.Api.World.Types.Tiles;
using TinyCsv.Attributes;

namespace DarkStar.Api.Serialization.TileSets
{
    [HasHeaderRecord(true)]
    [Delimiter(";")]
    public class TileSetMapSerializable
    {
        [Column]
        public int Id { get; set; }

        [Column(converter: typeof(TileTypeConverter))]
        public TileType Type { get; set; }

        [Column]
        public bool IsBlocked { get; set; }
    }
}
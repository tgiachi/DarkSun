﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkStar.Api.Engine.Map.Entities.Base;
using DarkStar.Api.World.Types.Map;
using GoRogue;
using GoRogue.GameFramework;
using SadRogue.Primitives;

namespace DarkStar.Api.Engine.Map.Entities
{
    public class NpcGameObject : BaseGameObject
    {
        public NpcGameObject(Point position) : base(position, (int)MapLayer.Creatures, false, false)
        {
        }
    }
}
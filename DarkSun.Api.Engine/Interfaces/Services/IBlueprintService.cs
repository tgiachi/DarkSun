﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkSun.Api.Engine.Interfaces.Services.Base;
using DarkSun.Database.Entities.Base;

namespace DarkSun.Api.Engine.Interfaces.Services;

public interface IBlueprintService : IDarkSunEngineService
{

    void AddRaceToSeed(string race, string description, short tileId, BaseStatEntity stat);

}

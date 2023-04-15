﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkStar.Api.Engine.Data.Sessions;

public class PlayerSession
{
    public Guid AccountId { get; set; }
    public Guid SessionId { get; set; }
    public Guid PlayerId { get; set; }
    public bool IsLogged { get; set; }
    public DateTime LastPingDateTime { get; set; }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DarkSun.Network.Protocol.Types;

public enum DarkSunMessageType
{
    Ping,
    Pong,
    ServerVersionResponse
}

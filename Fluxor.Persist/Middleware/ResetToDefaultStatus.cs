﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluxor.Persist.Middleware
{
    public enum ResetToDefaultStatus
    {
        IDLE,
        INITIALIZING,
        FAILED,
        SUCCEEDED
    }
}

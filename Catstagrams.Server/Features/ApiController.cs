﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catstagrams.Server.Features
{
    [ApiController]
    [Route("[controller]")]
    public abstract class ApiController:ControllerBase
    {

    }
}

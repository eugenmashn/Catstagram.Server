﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catstagrams.Server.Features.Cats
{
    public interface ICatService
    {
        public  Task<int> Create(string imageUrl, string description, string userId);
    }
}

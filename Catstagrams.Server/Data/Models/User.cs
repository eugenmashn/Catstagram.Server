
using Catstagrams.Server.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;

namespace Catstagrams.Server.Data.Models
{
    public class User:IdentityUser
    {
        public IEnumerable<Cat> Cats { get; } = new HashSet<Cat>();
    }
}

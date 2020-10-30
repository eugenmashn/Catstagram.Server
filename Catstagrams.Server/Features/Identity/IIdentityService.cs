using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catstagrams.Server.Features.Identity
{
    public interface IIdentityService
    {
         string GenerateJwtToken(string userId, string userName, string secret);
    }
}


using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Catstagrams.Server.Data
{
    public class CatstagramDbContext : IdentityDbContext
    {
        public CatstagramDbContext(DbContextOptions<CatstagramDbContext> options)
            : base(options)
        {
        }
    }
}

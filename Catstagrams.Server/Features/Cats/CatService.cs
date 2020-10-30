using Catstagrams.Server.Data;
using Catstagrams.Server.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catstagrams.Server.Features.Cats
{
    public class CatService : ICatService
    {
        private CatstagramDbContext data;

        public CatService(CatstagramDbContext data)=> this.data = data;
        

        public async Task<int> Create( string imageUrl, string description, string userId)
        {
            var cat = new Cat
            {
                Description = description,
                ImageUrl = imageUrl,
                UserId = userId
            };

            this.data.Add(cat);
            await this.data.SaveChangesAsync();
            return cat.Id;
        }
    }
}

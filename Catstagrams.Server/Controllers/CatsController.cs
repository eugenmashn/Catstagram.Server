using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Catstagrams.Server.Data;
using Catstagrams.Server.Data.Models;
using Catstagrams.Server.Infrastructure;
using Catstagrams.Server.Models.Cats;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Catstagrams.Server.Controllers
{
    public class CatsController : ApiController
    {
        private CatstagramDbContext data;
        
        public CatsController (CatstagramDbContext data)
        {
            this.data = data; 
        }
        
        [Authorize]
        [HttpPost]
        public async Task<ActionResult> Create(CreateCatRequestModel model) 
        {
            var userId = this.User.GetId();

            var cat = new Cat
            {
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                UserId = userId
            };

            this.data.Add(cat);
            await this.data.SaveChangesAsync();

            return Created(nameof(this.Created), cat.Id);
        }
    }
}

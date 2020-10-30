using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Catstagrams.Server.Data;
using Catstagrams.Server.Data.Models;
using Catstagrams.Server.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Catstagrams.Server.Features.Cats
{
    public class CatsController : ApiController
    {
        private readonly ICatService catService;

        public CatsController( ICatService catService = null) => this.catService = catService;
        

        [Authorize]
        [HttpPost]
        public async Task<ActionResult> Create(CreateCatRequestModel model) 
        {
            var userId = this.User.GetId();

            var id = await this.catService.Create(
                model.ImageUrl, 
                model.Description, 
                userId);

            return Created(nameof(this.Created), id);
        }
    }
}

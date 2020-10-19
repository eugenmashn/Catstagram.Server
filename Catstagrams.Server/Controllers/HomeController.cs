
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Catstagrams.Server.Controllers
{
    
    public class HomeController : ApiController
    {
        [Authorize]
        public ActionResult Get()
        {
            return this.Ok("Working");
        }
        
    }
}

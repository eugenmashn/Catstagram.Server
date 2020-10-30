using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Catstagrams.Server.Data.Validation.Cat;
namespace Catstagrams.Server.Features.Cats
{
    public class CreateCatRequestModel
    {
        
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }

    }
}

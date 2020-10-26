using Catstagrams.Server.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using static Catstagrams.Server.Data.Validation.Cat;
namespace Catstagrams.Server.Data.Models
{
    public class Cat
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string UserId { get; set; }

        public User User { get; set; }
    }
}

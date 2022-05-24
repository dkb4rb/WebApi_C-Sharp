using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace API.Models { 


    public class Ownerr
    {
        [Key]
        public int idOwner { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Photo { get; set; }
        [Required]
        public DateTime Birthday { get; set; }

        public List<Property> properties { get; set }
    }
}

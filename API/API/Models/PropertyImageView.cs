using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models {

    public class PropertyImageView {

        [Required]
        public IFormFile FileUrl { get; set; }
    }

}
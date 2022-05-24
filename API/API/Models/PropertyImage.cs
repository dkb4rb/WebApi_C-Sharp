using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class PropertyImage
    {
        [Key]
        public int idPropertyImage { get; set; }
        [Required]
        public string FilesUrl { get; set; }
        [ForeignKey("idProperty")]
        public int idProperty { get; set; }
    }
}

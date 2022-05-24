using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Property
    {
        [Key]
        public int idProperty { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public Decimal Price { get; set; }
        [Required]
        public Boolean CodeInterval { get; set; }
        [Required]
        public DateTime Yearr { get; set; }
        [ForeignKey("idOwner")]
        public int idOwner { get; set; }
    }

}

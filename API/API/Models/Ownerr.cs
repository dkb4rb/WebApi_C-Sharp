using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace API.Models {


    public partial class Ownerr
    {
        public Ownerr() {
            properties = new HashSet<Property>();
         }

        [Key]
        public int idOwner { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Photo { get; set; }

        public DateTime Birthday { get; set; }

        public virtual ICollection<Property> properties{ get; set; }
    }

    public partial class OwnerrItem
    {
        [Key]
        public int idOwner { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Photo { get; set; }

        public DateTime Birthday { get; set; }

     
    }

}

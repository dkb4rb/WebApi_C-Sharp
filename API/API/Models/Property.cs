using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public partial class Property
    {
        public Property()
        {

        }

        [Key]
        public int idProperty { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public Decimal Price { get; set; }

        public Boolean CodeInterval { get; set; }

        public DateTime Yearr { get; set; }

        public int? idOwner { get; set; }
        public virtual Ownerr Owner { get; set; }
    }
    public partial class PropertyItem
    {
        [Key]
        public int idProperty { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public Decimal Price { get; set; }

        public Boolean CodeInterval { get; set; }

        public DateTime Yearr { get; set; }
      
        public int? idOwner { get; set; }
    }
}

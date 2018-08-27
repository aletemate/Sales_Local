

namespace Sales_Local.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }
        [Required]
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime PublishOn { get; set; }

        public override string ToString()
        {
            return this.Description;
        }
    }
}

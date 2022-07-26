using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

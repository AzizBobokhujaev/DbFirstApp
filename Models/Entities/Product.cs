using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Product
    {
        public Product()
        {
            Offers = new HashSet<Offer>();
            ProductImages = new HashSet<ProductImage>();
            ProductVideos = new HashSet<ProductVideo>();
        }

        public ulong Id { get; set; }
        public ulong CategoryId { get; set; }
        public string Number { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string Status { get; set; } = null!;
        public string? Label { get; set; }
        public ulong BrandId { get; set; }
        public ulong? ThirdCategoryId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual Brand Brand { get; set; } = null!;
        public virtual ICollection<Offer> Offers { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductVideo> ProductVideos { get; set; }
    }
}

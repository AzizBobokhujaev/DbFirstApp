using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class ProductImage
    {
        public ulong Id { get; set; }
        public ulong ProductId { get; set; }
        public string LgPath { get; set; } = null!;
        public string? MdPath { get; set; }
        public string? SmPath { get; set; }
        public int Order { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Product Product { get; set; } = null!;
    }
}

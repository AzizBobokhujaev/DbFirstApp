using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Offer
    {
        public ulong Id { get; set; }
        public ulong ProductId { get; set; }
        public ulong PartnerId { get; set; }
        public ulong Quantity { get; set; }
        public ulong Price { get; set; }
        public ulong OldPrice { get; set; }
        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public bool IsVisible { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Partner Partner { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class ProductVideo
    {
        public ulong Id { get; set; }
        public ulong ProductId { get; set; }
        public string LinkToVideoRu { get; set; } = null!;
        public string LinkToVideoUz { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Product Product { get; set; } = null!;
    }
}

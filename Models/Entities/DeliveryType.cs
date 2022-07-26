using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class DeliveryType
    {
        public ulong Id { get; set; }
        public string Type { get; set; } = null!;
        public string TypeUz { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

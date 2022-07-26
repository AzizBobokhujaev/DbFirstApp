using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class PaymentMethod
    {
        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

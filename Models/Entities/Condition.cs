using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Condition
    {
        public ulong Id { get; set; }
        public ulong PartnerId { get; set; }
        public ulong? MerchantConditionId { get; set; }
        public ulong? EventId { get; set; }
        public int Duration { get; set; }
        public int Commission { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int Prepayment { get; set; }

        public virtual Event? Event { get; set; }
        public virtual Partner Partner { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class DeliveryCondition
    {
        public ulong Id { get; set; }
        public ulong CourierId { get; set; }
        public ulong DeliveryTypeId { get; set; }
        public string DeadlineIssue { get; set; } = null!;
        public ulong Price { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

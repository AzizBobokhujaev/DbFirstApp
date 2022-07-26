using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Eventable
    {
        public ulong Id { get; set; }
        public ulong EventId { get; set; }
        public string EventableType { get; set; } = null!;
        public ulong EventableId { get; set; }
        public int? Order { get; set; }
        public ulong? LabelId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Event Event { get; set; } = null!;
        public virtual Label? Label { get; set; }
    }
}

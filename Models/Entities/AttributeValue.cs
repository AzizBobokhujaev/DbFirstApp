using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class AttributeValue
    {
        public ulong Id { get; set; }
        public ulong AttributeId { get; set; }
        public string Value { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Attributes Attributes { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Attributes
    {
        public ulong Id { get; set; }
        public ulong AttributeGroupId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual AttributeGroup AttributeGroup { get; set; } = null!;
        public virtual ICollection<AttributeValue> AttributeValues { get; set; }
    }
}

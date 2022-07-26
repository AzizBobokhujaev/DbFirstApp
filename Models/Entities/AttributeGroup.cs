using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class AttributeGroup
    {
        public AttributeGroup()
        {
            Attributes = new HashSet<Attributes>();
        }

        public ulong Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Attributes> Attributes { get; set; }
    }
}

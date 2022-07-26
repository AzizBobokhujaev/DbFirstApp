using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class CategoryAttribute
    {
        public ulong AttributeId { get; set; }
        public ulong CategoryId { get; set; }

        public virtual Attributes Attributes { get; set; } = null!;
        public virtual Category Category { get; set; } = null!;
    }
}

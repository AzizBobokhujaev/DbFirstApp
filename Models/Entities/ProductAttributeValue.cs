using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class ProductAttributeValue
    {
        public ulong AttributeValueId { get; set; }
        public ulong ProductId { get; set; }

        public virtual AttributeValue AttributeValue { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}

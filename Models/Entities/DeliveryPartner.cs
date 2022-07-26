using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class DeliveryPartner
    {
        public long DeliveryConditionId { get; set; }
        public long PartnerId { get; set; }
    }
}

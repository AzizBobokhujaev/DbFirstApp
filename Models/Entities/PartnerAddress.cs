using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class PartnerAddress
    {
        public PartnerAddress()
        {
            PartnerPhones = new HashSet<PartnerPhone>();
        }

        public ulong Id { get; set; }
        public ulong PartnerId { get; set; }
        public string Location { get; set; } = null!;
        public string LocationUz { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Partner Partner { get; set; } = null!;
        public virtual ICollection<PartnerPhone> PartnerPhones { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class PartnerPhone
    {
        public ulong Id { get; set; }
        public ulong PartnerId { get; set; }
        public ulong? PartnerAddressId { get; set; }
        public string Number { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Partner Partner { get; set; } = null!;
        public virtual PartnerAddress? PartnerAddress { get; set; }
    }
}

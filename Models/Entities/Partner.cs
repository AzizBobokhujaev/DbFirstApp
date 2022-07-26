using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Partner
    {
        public Partner()
        {
            Conditions = new HashSet<Condition>();
            PartnerAddresses = new HashSet<PartnerAddress>();
            PartnerDeliveries = new HashSet<PartnerDelivery>();
            PartnerPhones = new HashSet<PartnerPhone>();
        }

        public ulong Id { get; set; }
        public ulong CompanyId { get; set; }
        public string Name { get; set; } = null!;
        public string? Slug { get; set; }
        public string? LogoPath { get; set; }
        public string? Token { get; set; }
        public string? Information { get; set; }
        public string? InformationUz { get; set; }
        public long DeliveryAmount { get; set; }
        public bool IsActive { get; set; }
        public bool IsRecommended { get; set; }
        public bool? HasDelivery { get; set; }
        public bool? HasCredit { get; set; }
        public bool? CashSales { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Condition> Conditions { get; set; }
        public virtual ICollection<PartnerAddress> PartnerAddresses { get; set; }
        public virtual ICollection<PartnerDelivery> PartnerDeliveries { get; set; }
        public virtual ICollection<PartnerPhone> PartnerPhones { get; set; }
    }
}

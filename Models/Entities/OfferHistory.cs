using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class OfferHistory
    {
        public ulong Id { get; set; }
        public string OfferPath { get; set; } = null!;
        public string OfferTitle { get; set; } = null!;
        public string LanguageCode { get; set; } = null!;
        public string OfferDate { get; set; } = null!;
        public string? OfferNumber { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}

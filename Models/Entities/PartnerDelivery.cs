using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class PartnerDelivery
    {
        public ulong Id { get; set; }
        public ulong PartnerId { get; set; }
        public long Amount { get; set; }
        public string? Note { get; set; }
        public string? NoteUz { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Partner Partner { get; set; } = null!;
    }
}

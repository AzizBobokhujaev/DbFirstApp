using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class PartnerUserAccess
    {
        public long UserId { get; set; }
        public string FullName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public ulong PartnerId { get; set; }

        public virtual Partner Partner { get; set; } = null!;
    }
}

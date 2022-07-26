using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Certificate
    {
        public ulong Id { get; set; }
        public string CertificatePath { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

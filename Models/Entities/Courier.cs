using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Courier
    {
        public ulong Id { get; set; }
        public string CompanyName { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Merchant
    {
        public ulong Id { get; set; }
        public string Token { get; set; } = null!;
        public string? FullProperties { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

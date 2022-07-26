using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Charter
    {
        public ulong Id { get; set; }
        public string CharterPath { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

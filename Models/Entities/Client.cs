using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Client
    {
        public ulong Id { get; set; }
        public string? Name { get; set; }
        public string Phone { get; set; } = null!;
        public string? RememberToken { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

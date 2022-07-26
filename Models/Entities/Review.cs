using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Review
    {
        public ulong Id { get; set; }
        public string Phone { get; set; } = null!;
        public sbyte Rate { get; set; }
        public string Content { get; set; } = null!;
        public bool? IsVisible { get; set; }
        public string? ReviewableType { get; set; }
        public ulong? ReviewableId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

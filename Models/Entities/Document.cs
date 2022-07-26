using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Document
    {
        public ulong Id { get; set; }
        public string Path { get; set; } = null!;
        public string Title { get; set; } = null!;
        public DateTime Date { get; set; }
        public int? Number { get; set; }
        public bool IsActive { get; set; }
        public string Type { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

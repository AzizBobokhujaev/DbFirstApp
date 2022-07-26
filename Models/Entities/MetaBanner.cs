using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class MetaBanner
    {
        public ulong Id { get; set; }
        public string DesktopImageRu { get; set; } = null!;
        public string DesktopImageUz { get; set; } = null!;
        public string MobileImageRu { get; set; } = null!;
        public string MobileImageUz { get; set; } = null!;
        public string? LinkRu { get; set; }
        public string? LinkUz { get; set; }
        public string LinkableSlug { get; set; } = null!;
        public string LinkableType { get; set; } = null!;
        public int? Order { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

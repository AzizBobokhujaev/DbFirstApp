using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Carousel
    {
        public ulong Id { get; set; }
        public string DesktopImage { get; set; } = null!;
        public string? DesktopImageUz { get; set; }
        public string? MobileImage { get; set; }
        public string? MobileImageUz { get; set; }
        public int Order { get; set; }
        public bool IsVisible { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? Link { get; set; }
        public string? LinkableType { get; set; }
        public string? LinkableSlug { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Event
    {
        public Event()
        {
            Conditions = new HashSet<Condition>();
            Eventables = new HashSet<Eventable>();
        }

        public ulong Id { get; set; }
        public string Title { get; set; } = null!;
        public string? TitleUz { get; set; }
        public string Slug { get; set; } = null!;
        public string? Label { get; set; }
        public string? LabelUz { get; set; }
        public string? Description { get; set; }
        public string? DescriptionUz { get; set; }
        public string? Banner { get; set; }
        public string? BannerUz { get; set; }
        public string? MobileBanner { get; set; }
        public string? MobileBannerUz { get; set; }
        public string? PromoBanner { get; set; }
        public string? PromoBannerUz { get; set; }
        public string Status { get; set; } = null!;
        public int? Order { get; set; }
        public bool IsPromotional { get; set; }
        public DateTime? StartsAt { get; set; }
        public DateTime? EndsAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Condition> Conditions { get; set; }
        public virtual ICollection<Eventable> Eventables { get; set; }
    }
}

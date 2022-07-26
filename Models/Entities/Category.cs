using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Category
    {
        public ulong Id { get; set; }
        public ulong ParentId { get; set; }
        public string? Ikpu { get; set; }
        public string Name { get; set; } = null!;
        public string? NameUz { get; set; }
        public string Slug { get; set; } = null!;
        public string? DescriptionRu { get; set; }
        public string? DescriptionUz { get; set; }
        public string? MetaTitleRu { get; set; }
        public string? MetaTitleUz { get; set; }
        public bool IsActive { get; set; }
        public bool IsPopular { get; set; }
        public uint PopularOrder { get; set; }
        public uint Order { get; set; }
        public string? Icon { get; set; }
        public string? Image { get; set; }
        public uint? SearchPriority { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ulong? OldId { get; set; }
        public ulong? OldParentId { get; set; }
        public string? Label { get; set; }
        public string? MetaDescriptionRu { get; set; }
        public string? MetaDescriptionUz { get; set; }
    }
}

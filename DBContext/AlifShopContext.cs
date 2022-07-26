using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DbFirstApp.Models.Entities;

namespace DbFirstApp.DBContext
{
    public partial class AlifShopContext : DbContext
    {
        public AlifShopContext()
        {
        }

        public AlifShopContext(DbContextOptions<AlifShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attributes> Attributes { get; set; } = null!;
        public virtual DbSet<AttributeGroup> AttributeGroups { get; set; } = null!;
        public virtual DbSet<AttributeValue> AttributeValues { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<Cache> Caches { get; set; } = null!;
        public virtual DbSet<CacheLock> CacheLocks { get; set; } = null!;
        public virtual DbSet<Carousel> Carousels { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<CategoryAttribute> CategoryAttributes { get; set; } = null!;
        public virtual DbSet<Certificate> Certificates { get; set; } = null!;
        public virtual DbSet<Charter> Charters { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Condition> Conditions { get; set; } = null!;
        public virtual DbSet<CoreSetting> CoreSettings { get; set; } = null!;
        public virtual DbSet<Courier> Couriers { get; set; } = null!;
        public virtual DbSet<DeliveryCondition> DeliveryConditions { get; set; } = null!;
        public virtual DbSet<DeliveryPartner> DeliveryPartners { get; set; } = null!;
        public virtual DbSet<DeliveryType> DeliveryTypes { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<Eventable> Eventables { get; set; } = null!;
        public virtual DbSet<FailedJob> FailedJobs { get; set; } = null!;
        public virtual DbSet<Label> Labels { get; set; } = null!;
        public virtual DbSet<Merchant> Merchants { get; set; } = null!;
        public virtual DbSet<MetaBanner> MetaBanners { get; set; } = null!;
        public virtual DbSet<Migration> Migrations { get; set; } = null!;
        public virtual DbSet<Offer> Offers { get; set; } = null!;
        public virtual DbSet<OfferHistory> OfferHistories { get; set; } = null!;
        public virtual DbSet<Partner> Partners { get; set; } = null!;
        public virtual DbSet<PartnerAddress> PartnerAddresses { get; set; } = null!;
        public virtual DbSet<PartnerDelivery> PartnerDeliveries { get; set; } = null!;
        public virtual DbSet<PartnerPhone> PartnerPhones { get; set; } = null!;
        public virtual DbSet<PartnerUserAccess> PartnerUserAccesses { get; set; } = null!;
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductAttributeValue> ProductAttributeValues { get; set; } = null!;
        public virtual DbSet<ProductImage> ProductImages { get; set; } = null!;
        public virtual DbSet<ProductVideo> ProductVideos { get; set; } = null!;
        public virtual DbSet<Review> Reviews { get; set; } = null!;
        public virtual DbSet<TimeLogger> TimeLoggers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;uid=root;database=db_alifshop", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.24-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Attributes>(entity =>
            {
                entity.ToTable("attributes");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.AttributeGroupId, "attributes_attribute_group_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AttributeGroupId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("attribute_group_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.AttributeGroup)
                    .WithMany(p => p.Attributes)
                    .HasForeignKey(d => d.AttributeGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("attributes_attribute_group_id_foreign");
            });

            modelBuilder.Entity<AttributeGroup>(entity =>
            {
                entity.ToTable("attribute_groups");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<AttributeValue>(entity =>
            {
                entity.ToTable("attribute_values");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.AttributeId, "attribute_values_attribute_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AttributeId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("attribute_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("value");

                entity.HasOne(d => d.Attributes)
                    .WithMany(p => p.AttributeValues)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("attribute_values_attribute_id_foreign");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("brands");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Name, "brands_name_unique")
                    .IsUnique();

                entity.HasIndex(e => e.Slug, "brands_slug_index")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Slug).HasColumnName("slug");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Cache>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PRIMARY");

                entity.ToTable("cache");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Expiration)
                    .HasColumnType("int(11)")
                    .HasColumnName("expiration");

                entity.Property(e => e.Value)
                    .HasColumnType("mediumtext")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<CacheLock>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PRIMARY");

                entity.ToTable("cache_locks");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Key).HasColumnName("key");

                entity.Property(e => e.Expiration)
                    .HasColumnType("int(11)")
                    .HasColumnName("expiration");

                entity.Property(e => e.Owner)
                    .HasMaxLength(255)
                    .HasColumnName("owner");
            });

            modelBuilder.Entity<Carousel>(entity =>
            {
                entity.ToTable("carousels");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DesktopImage)
                    .HasColumnType("text")
                    .HasColumnName("desktop_image");

                entity.Property(e => e.DesktopImageUz)
                    .HasColumnType("text")
                    .HasColumnName("desktop_image_uz");

                entity.Property(e => e.IsVisible).HasColumnName("is_visible");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .HasColumnName("link");

                entity.Property(e => e.LinkableSlug)
                    .HasMaxLength(255)
                    .HasColumnName("linkable_slug");

                entity.Property(e => e.LinkableType)
                    .HasMaxLength(255)
                    .HasColumnName("linkable_type");

                entity.Property(e => e.MobileImage)
                    .HasColumnType("text")
                    .HasColumnName("mobile_image");

                entity.Property(e => e.MobileImageUz)
                    .HasColumnType("text")
                    .HasColumnName("mobile_image_uz");

                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Label, "temp_categories_label_index");

                entity.HasIndex(e => e.OldId, "temp_categories_old_id_index");

                entity.HasIndex(e => e.ParentId, "temp_categories_parent_id_index");

                entity.HasIndex(e => e.Slug, "temp_categories_slug_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DescriptionRu)
                    .HasColumnType("text")
                    .HasColumnName("description_ru");

                entity.Property(e => e.DescriptionUz)
                    .HasColumnType("text")
                    .HasColumnName("description_uz");

                entity.Property(e => e.Icon)
                    .HasMaxLength(255)
                    .HasColumnName("icon");

                entity.Property(e => e.Ikpu)
                    .HasMaxLength(255)
                    .HasColumnName("ikpu");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsPopular).HasColumnName("is_popular");

                entity.Property(e => e.Label).HasColumnName("label");

                entity.Property(e => e.MetaDescriptionRu)
                    .HasColumnType("text")
                    .HasColumnName("meta_description_ru");

                entity.Property(e => e.MetaDescriptionUz)
                    .HasColumnType("text")
                    .HasColumnName("meta_description_uz");

                entity.Property(e => e.MetaTitleRu)
                    .HasMaxLength(255)
                    .HasColumnName("meta_title_ru");

                entity.Property(e => e.MetaTitleUz)
                    .HasMaxLength(255)
                    .HasColumnName("meta_title_uz");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.NameUz)
                    .HasMaxLength(255)
                    .HasColumnName("name_uz");

                entity.Property(e => e.OldId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("old_id");

                entity.Property(e => e.OldParentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("old_parent_id");

                entity.Property(e => e.Order)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("order");

                entity.Property(e => e.ParentId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("parent_id");

                entity.Property(e => e.PopularOrder)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("popular_order");

                entity.Property(e => e.SearchPriority)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("search_priority");

                entity.Property(e => e.Slug).HasColumnName("slug");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<CategoryAttribute>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("category_attribute");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.AttributeId, "category_attribute_attribute_id_foreign");

                entity.HasIndex(e => e.CategoryId, "category_attribute_category_id_foreign");

                entity.Property(e => e.AttributeId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("attribute_id");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("category_id");

                entity.HasOne(d => d.Attributes)
                    .WithMany()
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("category_attribute_attribute_id_foreign");

                entity.HasOne(d => d.Category)
                    .WithMany()
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("category_attribute_category_id_foreign");
            });

            modelBuilder.Entity<Certificate>(entity =>
            {
                entity.ToTable("certificates");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CertificatePath)
                    .HasMaxLength(255)
                    .HasColumnName("certificate_path");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Charter>(entity =>
            {
                entity.ToTable("charters");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CharterPath)
                    .HasMaxLength(255)
                    .HasColumnName("charter_path");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("clients");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Phone, "clients_phone_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.RememberToken)
                    .HasMaxLength(255)
                    .HasColumnName("remember_token");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Condition>(entity =>
            {
                entity.ToTable("conditions");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.EventId, "conditions_event_id_foreign");

                entity.HasIndex(e => e.MerchantConditionId, "conditions_merchant_condition_id_index");

                entity.HasIndex(e => e.PartnerId, "conditions_partner_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Commission)
                    .HasColumnType("int(11)")
                    .HasColumnName("commission");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Duration)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration");

                entity.Property(e => e.EventId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("event_id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.MerchantConditionId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("merchant_condition_id");

                entity.Property(e => e.PartnerId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("partner_id");

                entity.Property(e => e.Prepayment)
                    .HasColumnType("int(11)")
                    .HasColumnName("prepayment");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Conditions)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("conditions_event_id_foreign");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.Conditions)
                    .HasForeignKey(d => d.PartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("conditions_partner_id_foreign");
            });

            modelBuilder.Entity<CoreSetting>(entity =>
            {
                entity.ToTable("core_settings");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.MaxApplicationSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("max_application_sum");

                entity.Property(e => e.MinApplicationSum)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("min_application_sum");

                entity.Property(e => e.MinPriceShow)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("min_price_show");

                entity.Property(e => e.OfferFilePath)
                    .HasMaxLength(255)
                    .HasColumnName("offer_file_path");
            });

            modelBuilder.Entity<Courier>(entity =>
            {
                entity.ToTable("couriers");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .HasColumnName("company_name");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<DeliveryCondition>(entity =>
            {
                entity.ToTable("delivery_conditions");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CourierId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("courier_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeadlineIssue)
                    .HasMaxLength(255)
                    .HasColumnName("deadline_issue");

                entity.Property(e => e.DeliveryTypeId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("delivery_type_id");

                entity.Property(e => e.Price)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("price");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<DeliveryPartner>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("delivery_partner");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.DeliveryConditionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("delivery_condition_id");

                entity.Property(e => e.PartnerId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("partner_id");
            });

            modelBuilder.Entity<DeliveryType>(entity =>
            {
                entity.ToTable("delivery_types");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.TypeUz)
                    .HasMaxLength(255)
                    .HasColumnName("type_uz");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("documents");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Path, "documents_path_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("date")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Number)
                    .HasColumnType("int(11)")
                    .HasColumnName("number");

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("events");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Order, "events_order_index");

                entity.HasIndex(e => e.Slug, "events_slug_index")
                    .IsUnique();

                entity.HasIndex(e => e.Status, "events_status_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Banner)
                    .HasColumnType("text")
                    .HasColumnName("banner");

                entity.Property(e => e.BannerUz)
                    .HasColumnType("text")
                    .HasColumnName("banner_uz");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.DescriptionUz)
                    .HasColumnType("text")
                    .HasColumnName("description_uz");

                entity.Property(e => e.EndsAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("ends_at");

                entity.Property(e => e.IsPromotional).HasColumnName("is_promotional");

                entity.Property(e => e.Label)
                    .HasMaxLength(255)
                    .HasColumnName("label");

                entity.Property(e => e.LabelUz)
                    .HasMaxLength(255)
                    .HasColumnName("label_uz");

                entity.Property(e => e.MobileBanner)
                    .HasMaxLength(255)
                    .HasColumnName("mobile_banner");

                entity.Property(e => e.MobileBannerUz)
                    .HasMaxLength(255)
                    .HasColumnName("mobile_banner_uz");

                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.PromoBanner)
                    .HasMaxLength(255)
                    .HasColumnName("promo_banner");

                entity.Property(e => e.PromoBannerUz)
                    .HasMaxLength(255)
                    .HasColumnName("promo_banner_uz");

                entity.Property(e => e.Slug).HasColumnName("slug");

                entity.Property(e => e.StartsAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("starts_at");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'pending'");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.TitleUz)
                    .HasMaxLength(255)
                    .HasColumnName("title_uz");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Eventable>(entity =>
            {
                entity.ToTable("eventables");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.EventId, "eventables_event_id_foreign");

                entity.HasIndex(e => e.EventableId, "eventables_eventable_id_index");

                entity.HasIndex(e => e.EventableType, "eventables_eventable_type_index");

                entity.HasIndex(e => e.LabelId, "eventables_label_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.EventId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("event_id");

                entity.Property(e => e.EventableId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("eventable_id");

                entity.Property(e => e.EventableType).HasColumnName("eventable_type");

                entity.Property(e => e.LabelId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("label_id");

                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Eventables)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("eventables_event_id_foreign");

                entity.HasOne(d => d.Label)
                    .WithMany(p => p.Eventables)
                    .HasForeignKey(d => d.LabelId)
                    .HasConstraintName("eventables_label_id_foreign");
            });

            modelBuilder.Entity<FailedJob>(entity =>
            {
                entity.ToTable("failed_jobs");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Uuid, "failed_jobs_uuid_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Connection)
                    .HasColumnType("text")
                    .HasColumnName("connection");

                entity.Property(e => e.Exception).HasColumnName("exception");

                entity.Property(e => e.FailedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("failed_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Payload).HasColumnName("payload");

                entity.Property(e => e.Queue)
                    .HasColumnType("text")
                    .HasColumnName("queue");

                entity.Property(e => e.Uuid).HasColumnName("uuid");
            });

            modelBuilder.Entity<Label>(entity =>
            {
                entity.ToTable("labels");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.TextRu)
                    .HasMaxLength(255)
                    .HasColumnName("text_ru");

                entity.Property(e => e.TextUz)
                    .HasMaxLength(255)
                    .HasColumnName("text_uz");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Merchant>(entity =>
            {
                entity.ToTable("merchants");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Token, "merchants_token_unique")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.FullProperties)
                    .HasColumnType("json")
                    .HasColumnName("full_properties");

                entity.Property(e => e.Token).HasColumnName("token");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<MetaBanner>(entity =>
            {
                entity.ToTable("meta_banners");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DesktopImageRu)
                    .HasMaxLength(255)
                    .HasColumnName("desktop_image_ru");

                entity.Property(e => e.DesktopImageUz)
                    .HasMaxLength(255)
                    .HasColumnName("desktop_image_uz");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.LinkRu)
                    .HasMaxLength(255)
                    .HasColumnName("link_ru");

                entity.Property(e => e.LinkUz)
                    .HasMaxLength(255)
                    .HasColumnName("link_uz");

                entity.Property(e => e.LinkableSlug)
                    .HasMaxLength(255)
                    .HasColumnName("linkable_slug");

                entity.Property(e => e.LinkableType)
                    .HasMaxLength(255)
                    .HasColumnName("linkable_type");

                entity.Property(e => e.MobileImageRu)
                    .HasMaxLength(255)
                    .HasColumnName("mobile_image_ru");

                entity.Property(e => e.MobileImageUz)
                    .HasMaxLength(255)
                    .HasColumnName("mobile_image_uz");

                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Migration>(entity =>
            {
                entity.ToTable("migrations");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Batch)
                    .HasColumnType("int(11)")
                    .HasColumnName("batch");

                entity.Property(e => e.Migration1)
                    .HasMaxLength(255)
                    .HasColumnName("migration");
            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.ToTable("offers");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.PartnerId, "offers_partner_id_index");

                entity.HasIndex(e => e.ProductId, "offers_product_id_foreign");

                entity.HasIndex(e => e.Slug, "offers_slug_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.IsVisible).HasColumnName("is_visible");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.OldPrice)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("old_price");

                entity.Property(e => e.PartnerId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("partner_id");

                entity.Property(e => e.Price)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("price");

                entity.Property(e => e.ProductId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("product_id");

                entity.Property(e => e.Quantity)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("quantity");

                entity.Property(e => e.Slug).HasColumnName("slug");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("offers_product_id_foreign");
            });

            modelBuilder.Entity<OfferHistory>(entity =>
            {
                entity.ToTable("offer_histories");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(255)
                    .HasColumnName("language_code")
                    .HasDefaultValueSql("'ru'");

                entity.Property(e => e.OfferDate)
                    .HasMaxLength(255)
                    .HasColumnName("offer_date");

                entity.Property(e => e.OfferNumber)
                    .HasMaxLength(255)
                    .HasColumnName("offer_number");

                entity.Property(e => e.OfferPath)
                    .HasMaxLength(255)
                    .HasColumnName("offer_path");

                entity.Property(e => e.OfferTitle)
                    .HasMaxLength(255)
                    .HasColumnName("offer_title");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.ToTable("partners");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.CompanyId, "partners_company_id_index");

                entity.HasIndex(e => e.Slug, "partners_slug_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CashSales)
                    .IsRequired()
                    .HasColumnName("cash_sales")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CompanyId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("company_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeliveryAmount)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("delivery_amount");

                entity.Property(e => e.HasCredit)
                    .IsRequired()
                    .HasColumnName("has_credit")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.HasDelivery)
                    .IsRequired()
                    .HasColumnName("has_delivery")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Information)
                    .HasColumnType("mediumtext")
                    .HasColumnName("information");

                entity.Property(e => e.InformationUz)
                    .HasColumnType("mediumtext")
                    .HasColumnName("information_uz");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsRecommended).HasColumnName("is_recommended");

                entity.Property(e => e.LogoPath)
                    .HasMaxLength(255)
                    .HasColumnName("logo_path");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Slug).HasColumnName("slug");

                entity.Property(e => e.Token)
                    .HasMaxLength(255)
                    .HasColumnName("token");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<PartnerAddress>(entity =>
            {
                entity.ToTable("partner_addresses");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.PartnerId, "partner_addresses_partner_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .HasColumnName("location");

                entity.Property(e => e.LocationUz)
                    .HasMaxLength(255)
                    .HasColumnName("location_uz");

                entity.Property(e => e.PartnerId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("partner_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.PartnerAddresses)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("partner_addresses_partner_id_foreign");
            });

            modelBuilder.Entity<PartnerDelivery>(entity =>
            {
                entity.ToTable("partner_deliveries");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.IsActive, "partner_deliveries_is_active_index");

                entity.HasIndex(e => e.PartnerId, "partner_deliveries_partner_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("amount");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("is_active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .HasColumnName("note");

                entity.Property(e => e.NoteUz)
                    .HasMaxLength(255)
                    .HasColumnName("note_uz");

                entity.Property(e => e.PartnerId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("partner_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.PartnerDeliveries)
                    .HasForeignKey(d => d.PartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("partner_deliveries_partner_id_foreign");
            });

            modelBuilder.Entity<PartnerPhone>(entity =>
            {
                entity.ToTable("partner_phones");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.PartnerAddressId, "partner_phones_partner_address_id_foreign");

                entity.HasIndex(e => e.PartnerId, "partner_phones_partner_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.Number)
                    .HasMaxLength(255)
                    .HasColumnName("number");

                entity.Property(e => e.PartnerAddressId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("partner_address_id");

                entity.Property(e => e.PartnerId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("partner_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.PartnerAddress)
                    .WithMany(p => p.PartnerPhones)
                    .HasForeignKey(d => d.PartnerAddressId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("partner_phones_partner_address_id_foreign");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.PartnerPhones)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("partner_phones_partner_id_foreign");
            });

            modelBuilder.Entity<PartnerUserAccess>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("partner_user_access");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.PartnerId, "partner_user_access_partner_id_foreign");

                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .HasColumnName("full_name");

                entity.Property(e => e.PartnerId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("partner_id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.UserId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("user_id");

                entity.HasOne(d => d.Partner)
                    .WithMany()
                    .HasForeignKey(d => d.PartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("partner_user_access_partner_id_foreign");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.ToTable("payment_methods");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.BrandId, "products_brand_id_foreign");

                entity.HasIndex(e => e.Status, "products_status_index");

                entity.HasIndex(e => e.ThirdCategoryId, "products_third_category_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BrandId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("brand_id");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("category_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("deleted_at");

                entity.Property(e => e.Description)
                    .HasColumnType("json")
                    .HasColumnName("description");

                entity.Property(e => e.Label)
                    .HasMaxLength(255)
                    .HasColumnName("label");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Number)
                    .HasMaxLength(255)
                    .HasColumnName("number");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.ThirdCategoryId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("third_category_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("products_brand_id_foreign");
            });

            modelBuilder.Entity<ProductAttributeValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("product_attribute_value");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.AttributeValueId, "product_attribute_value_attribute_value_id_foreign");

                entity.HasIndex(e => e.ProductId, "product_attribute_value_product_id_foreign");

                entity.Property(e => e.AttributeValueId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("attribute_value_id");

                entity.Property(e => e.ProductId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("product_id");

                entity.HasOne(d => d.AttributeValue)
                    .WithMany()
                    .HasForeignKey(d => d.AttributeValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_attribute_value_attribute_value_id_foreign");

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_attribute_value_product_id_foreign");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.ToTable("product_images");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Order, "product_images_order_index");

                entity.HasIndex(e => e.ProductId, "product_images_product_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.LgPath)
                    .HasMaxLength(255)
                    .HasColumnName("lg_path");

                entity.Property(e => e.MdPath)
                    .HasMaxLength(255)
                    .HasColumnName("md_path");

                entity.Property(e => e.Order)
                    .HasColumnType("int(11)")
                    .HasColumnName("order");

                entity.Property(e => e.ProductId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("product_id");

                entity.Property(e => e.SmPath)
                    .HasMaxLength(255)
                    .HasColumnName("sm_path");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("product_images_product_id_foreign");
            });

            modelBuilder.Entity<ProductVideo>(entity =>
            {
                entity.ToTable("product_videos");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.ProductId, "product_videos_product_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.LinkToVideoRu)
                    .HasMaxLength(255)
                    .HasColumnName("link_to_video_ru");

                entity.Property(e => e.LinkToVideoUz)
                    .HasMaxLength(255)
                    .HasColumnName("link_to_video_uz");

                entity.Property(e => e.ProductId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("product_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVideos)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("product_videos_product_id_foreign");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("reviews");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.ReviewableType, e.ReviewableId }, "reviews_reviewable_type_reviewable_id_index");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_at");

                entity.Property(e => e.IsVisible)
                    .IsRequired()
                    .HasColumnName("is_visible")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.Rate)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("rate");

                entity.Property(e => e.ReviewableId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("reviewable_id");

                entity.Property(e => e.ReviewableType).HasColumnName("reviewable_type");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("updated_at");
            });

            modelBuilder.Entity<TimeLogger>(entity =>
            {
                entity.ToTable("time_loggers");

                entity.UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Duration)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

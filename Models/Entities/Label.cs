using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class Label
    {
        public Label()
        {
            Eventables = new HashSet<Eventable>();
        }

        public ulong Id { get; set; }
        public string? TextRu { get; set; }
        public string TextUz { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Eventable> Eventables { get; set; }
    }
}

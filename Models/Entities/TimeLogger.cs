using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class TimeLogger
    {
        public ulong Id { get; set; }
        public string Title { get; set; } = null!;
        public int Duration { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

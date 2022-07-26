using System;
using System.Collections.Generic;

namespace DbFirstApp.Models.Entities
{
    public partial class CoreSetting
    {
        public ulong Id { get; set; }
        public long MinApplicationSum { get; set; }
        public long MaxApplicationSum { get; set; }
        public long MinPriceShow { get; set; }
        public string? OfferFilePath { get; set; }
    }
}

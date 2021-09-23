using System;
using System.Collections.Generic;

#nullable disable

namespace Altaliza.Data.Models
{
    public partial class EfmigrationsHistory
    {
        public string MigrationId { get; set; }
        public string ProductVersion { get; set; }
    }
}

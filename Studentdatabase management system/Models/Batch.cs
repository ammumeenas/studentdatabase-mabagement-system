using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studentdatabase_management_system.Models
{
    public class Batch
    {
        public string Name { get; set; }
        public int BatchId { get; set; }
        public string Announcement { get; set; }
        public DateTime ClassSchedule { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Studentdatabase_management_system.ViewModels
{
    public class AddBatchViewModel
    {
        [Required]
        public string Name { get; set; }
        public int BatchId { get; set; }
        [Required]
        public string Announcement { get; set; }
        [Required]
        public DateTime ClassSchedule { get; set; }



        public AddBatchViewModel()
        {

        }


    }
}

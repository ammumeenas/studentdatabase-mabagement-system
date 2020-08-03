using Studentdatabase_management_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studentdatabase_management_system.ViewModels
{
    public class AddBatchDetailViewModel
    {

        public int Id { get; set; }
        public string BatchName { get; set; }
        public string Announcements { get; set; }
        public DateTime ClassSchedule { get; set; }


public AddBatchDetailViewModel(Batch batch)
        {
            Id = batch.BatchId;
            BatchName = batch.Name;
            Announcements = batch.Announcement;
            ClassSchedule = batch.ClassSchedule;
        }
    }
}

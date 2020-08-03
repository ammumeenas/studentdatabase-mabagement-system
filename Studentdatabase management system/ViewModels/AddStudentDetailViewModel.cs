using Studentdatabase_management_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studentdatabase_management_system.ViewModels
{
    public class AddStudentDetailViewModel
    {



        public string Name { get; set; }

        public int Id { get; set; }
        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public Batch batch { get; set; }
        public DateTime ClassSchedule { get; set; }
        public string Announcement { get; set; }


        public AddStudentDetailViewModel(Student student)
        {
            Id = student.Id;
            Name = student.Name;
            BatchName = student.Batch.Name;
            BatchId = student.BatchId;
            ClassSchedule = student.Batch.ClassSchedule;
            Announcement = student.Batch.Announcement;


        }
    }
}
    




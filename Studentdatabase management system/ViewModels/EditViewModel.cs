using Microsoft.AspNetCore.Mvc.Rendering;
using Studentdatabase_management_system.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Studentdatabase_management_system.ViewModels
{
    public class EditViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int BatchId { get; set; }

        public List<SelectListItem> Batch { get; set; }

        public Batch Selectedbatch { get; set; }

    



        public EditViewModel()
            {

            }
        public EditViewModel(Student student,List<Batch> Batches)
        {
            Batch = new List<SelectListItem>();
            foreach (Batch batch in Batches)
            {
                SelectListItem selectListItem = new SelectListItem()
                {
                    Value = batch.BatchId.ToString(),
                    Text = batch.Name
                };
                Batch.Add(selectListItem);

            }

            Id = student.Id;
            Name = student.Name;
            Selectedbatch = student.Batch;

        }
      

        }
}

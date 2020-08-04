using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Studentdatabase_management_system.Data;
using Studentdatabase_management_system.Models;
using Studentdatabase_management_system.ViewModels;

namespace Studentdatabase_management_system.Controllers
{
    public class BatchController : Controller
    {
        private StudentDbContext context;

        public BatchController (StudentDbContext DbContext)
        {
            context = DbContext;
        }
        [HttpGet]
        public IActionResult AddBatch()
        {
            AddBatchViewModel addbatchviewmodel = new AddBatchViewModel();
            return View(addbatchviewmodel);
        }
        [HttpPost]
        public IActionResult AddBatch(AddBatchViewModel addbatchviewmodel)
        {
            if (ModelState.IsValid)
            {
                Batch batch = new Batch()
                {
                    Name = addbatchviewmodel.Name,
                    Announcement = addbatchviewmodel.Announcement,
                    ClassSchedule = addbatchviewmodel.ClassSchedule
                };
                context.Batches.Add(batch);
                context.SaveChanges();
                return Redirect("/Admin");
            }
            else
            {
                return View("addBatch", addbatchviewmodel);
            }
        }

        public IActionResult BatchDetails(int Id)
        {
             Batch batch = context.Batches.Find(Id);
            AddBatchDetailViewModel addbatchdetailviewmodel = new AddBatchDetailViewModel(batch);
            return View(addbatchdetailviewmodel);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Batch batch = context.Batches.Find(Id);
            EditBatchViewModel editBatchViewModel = new EditBatchViewModel(batch);
            return View(editBatchViewModel);
        }

        [HttpPost]
        public IActionResult Edit(EditBatchViewModel editBatchViewModel)
        {

            if (ModelState.IsValid)
            {
               
                Batch batch = context.Batches.Find(editBatchViewModel.BatchId);
                batch.BatchId = editBatchViewModel.BatchId;
                batch.Name = editBatchViewModel.Name;
                batch.ClassSchedule = editBatchViewModel.ClassSchedule;
                batch.Announcement = editBatchViewModel.Announcement;
                context.Batches.Update(batch);
                context.SaveChanges();
                return Redirect("/Admin");

            }
            else
            {
                return View("Edit", editBatchViewModel);
            }
        }
        public IActionResult Delete(int Id)
        {
            Batch batch = context.Batches.Find(Id);

            context.Batches.Remove(batch);
            context.SaveChanges();
            return Redirect("/Admin");

        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Studentdatabase_management_system.Data;
using Studentdatabase_management_system.Models;
using Studentdatabase_management_system.ViewModels;

namespace Studentdatabase_management_system.Controllers
{
    public class AdminController : Controller
    {
        private StudentDbContext context;
        

            public AdminController(StudentDbContext DbContext)
        {
            context = DbContext;
        }
        public IActionResult Index()
        {
            List<Student> Students = context.Students.Include(j => j.Batch).ToList();
            ViewBag.Students = Students;
            List<Batch> Batches = context.Batches.ToList();
            ViewBag.Batch = Batches;
            return View();
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            List<Batch> Batches = context.Batches.ToList();
            AddStudentViewModel addStudentViewModel = new AddStudentViewModel(Batches);
            return View(addStudentViewModel);
        }
        [HttpPost]
        public IActionResult AddStudent(AddStudentViewModel addStudentViewModel)
        {
            if (ModelState.IsValid)
            {
                Student student = new Student()
                {
                    Name = addStudentViewModel.Name

                };
                Batch selectedbatch = context.Batches.Find(addStudentViewModel.BatchId);
                student.Batch = selectedbatch;
                context.Students.Add(student);
                context.SaveChanges();
                return Redirect("/Admin");

            }
            else
            {
                return View("AddStudent", addStudentViewModel);
            }
        }
public IActionResult StudentDetails(int Id)
        {
            Student student = context.Students.Include(j => j.Batch).Single(j => j.Id==Id);
            AddStudentDetailViewModel addstudentdetailviewmodel = new AddStudentDetailViewModel(student);
            return View(addstudentdetailviewmodel);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            Student student=context.Students.Include(j => j.Batch).Single(j => j.Id == Id);
            List<Batch> Batches = context.Batches.ToList();
            EditViewModel editViewModel = new EditViewModel(student,Batches);
            return View(editViewModel);
        }

        [HttpPost]
        public IActionResult Edit(EditViewModel editViewModel)
        {
            if (ModelState.IsValid)
            {
                Student student=context.Students.Include(j => j.Batch).Single(j => j.Id == editViewModel.Id);
                Batch batch = context.Batches.Find(editViewModel.BatchId);
                student.Id = editViewModel.Id;
                student.Name = editViewModel.Name;
                student.BatchId = editViewModel.BatchId;
                student.Batch = editViewModel.Selectedbatch;
                context.Students.Update(student);
                context.SaveChanges();
                return Redirect("/Admin");

            }
            else
            {
                return View("Edit", editViewModel);
            }
        }

        public IActionResult Delete(int Id)
        {
            Student student = context.Students.Find(Id);

            context.Students.Remove(student);
            context.SaveChanges();
            return Redirect("/Admin");

        }

    }
}

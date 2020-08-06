using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Studentdatabase_management_system.Data;
using Microsoft.EntityFrameworkCore;
using Studentdatabase_management_system.Models;
using Studentdatabase_management_system.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Studentdatabase_management_system.Controllers
{
    public class DetailsController : Controller
    {

        private StudentDbContext context;


        public DetailsController(StudentDbContext DbContext)
        {
            context = DbContext;
        }
        [Authorize(Roles = "Admin")]
        [Authorize(Roles = "User")]
        public IActionResult StudentDetails(int Id)
        {
            Student student = context.Students.Include(j => j.Batch).Single(j => j.Id == Id);
            AddStudentDetailViewModel addstudentdetailviewmodel = new AddStudentDetailViewModel(student);
            return View(addstudentdetailviewmodel);

        }
    }
}


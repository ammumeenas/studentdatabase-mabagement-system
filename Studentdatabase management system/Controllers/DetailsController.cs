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
       
        public IActionResult StudentDetails()
       {
            List<Student> Students = context.Students.Include(j => j.Batch).ToList();
            ViewBag.Students = Students;
            return View();

        }
    }
}


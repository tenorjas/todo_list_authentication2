using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testAuth.Data;
using testAuth.Models;

namespace testAuth.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context; 

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.TodoModel.ToList());
        }

        [HttpPost]
        public IActionResult Index(string NewItem)
        {
            var currentToDo = new TodoModel{
                TaskName = NewItem
            };
            _context.Add(currentToDo);
            _context.SaveChanges();

            return View(_context.TodoModel.ToList());
        }

        [HttpPost]
        public IActionResult IsComplete(string ID)
        {
            var finished = _context.TodoModel.FirstOrDefault(m => m.UserId == ID);
            finished.Complete();
            _context.SaveChanges();
            return Redirect("Index");
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

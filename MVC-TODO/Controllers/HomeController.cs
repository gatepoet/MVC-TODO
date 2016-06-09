using MVC_TODO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TODO.Controllers
{
    public class HomeController : Controller
    {
        private TodoContext db = new TodoContext();

        public ActionResult Index()
        {
            var vm = new TodoListViewModel
            {
                TodoItems = db.TodoItems.ToList(),
                NewItem = new TodoItem()
            };
            return View(vm);
        }

        public ActionResult AddItem(TodoItem viewModel)
        {
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CollectTrash.Models;

namespace CollectTrash.Controllers
{
    public class EmployeeController : Controller
    {
        
        ApplicationDbContext db;

        public EmployeeController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Employee
        public ActionResult Index()
        {
            List<Customer> customers = new List<Customer>();
            customers = db.Customer.ToList();
            return View();
        }

       
    }
}

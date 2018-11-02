using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CollectTrash.Models;
using Microsoft.AspNet.Identity;
using System.Data;
using System.Data.Entity;

namespace CollectTrash.Controllers
{
    public class CustomerController : Controller
    {

        ApplicationDbContext db;

        public CustomerController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Customer
        public ActionResult Index()
        {

            List<Customer> customers = new List<Customer>();
            customers = db.Customer.ToList();
            return View();

        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create([Bind(Include ="UserId,FirstName,LastName,Address,PostalCode,EmailAddress,PickUpDate,ExtraPickUpDate")]  Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    db.Customer.Add(customer);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                //return View("Create", customer);
                throw ex;
            }
            finally
            {
               //View("Create", customer);
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int? id)
        {   
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

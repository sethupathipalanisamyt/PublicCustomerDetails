using CoustomerDetails.Models;
using CoustomerDetails.Repository;
using CoustomerDetails.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoustomerDetails.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomers _customers;
        public CustomersController(ICustomers customers)
        {
            _customers = customers;
        }
        // GET: CustomersController1
        public ActionResult List()
        {
            try
            {
                var response = _customers.GetCustomers();
                if (response != null)
                {

                }
                return View("List",response);
            }
            catch
            {
                return View();
            }

           
        }

        // GET: CustomersController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomersController1/Create
        public ActionResult Register()
        {
            return View();
        }

        // POST: CustomersController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerModel customer)
        {
            try
            {
                var response = _customers.RegisterCustomer(customer);
                if (response != null)
                {
                   
                }
                return RedirectToAction(nameof(Register));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController1/Edit/5
        public ActionResult Update(int id)
        {
            return View("List");
        }

        // POST: CustomersController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomersController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

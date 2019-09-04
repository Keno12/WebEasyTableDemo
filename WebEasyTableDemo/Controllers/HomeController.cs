using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEasyTableDemo.Models;

namespace WebEasyTableDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        [HttpGet]
        public JsonResult CustomersData()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    customers.Add(new Customer()
                    {
                        Id = string.Format("C{0}", i),
                        CustomerName = string.Format("Customer{0}", i),
                        Address = string.Format("建国门外大家甲{0}号", i),
                        Email = string.Format("Cus{0}@zhonglun.com", i),
                        HomePage = string.Format("www.home{0}.com", i)
                    });
                }
            }
            catch
            {

            }
            return Json(customers, JsonRequestBehavior.AllowGet);
        }

        public JsonResult PersonsData()
        {
            List<Person> customers = new List<Person>();
            try
            {
                Random r = new Random();
                for (int i = 0; i < 20; i++)
                {
                    customers.Add(new Person()
                    {
                        Id = string.Format("P{0}", i),
                        name = string.Format("Person{0}", i),
                        gender = i % 2 == 0 ? "男" : "女",
                        height = string.Format("{0}", r.Next(200)),
                        address = string.Format("建国门外大家甲{0}号", i),
                        email = string.Format("Person{0}@zhonglun.com", i),
                        tel = string.Format("www.home{0}.com", i)
                    });
                }
            }
            catch
            {

            }
            return Json(customers, JsonRequestBehavior.AllowGet);
        }
    }
}
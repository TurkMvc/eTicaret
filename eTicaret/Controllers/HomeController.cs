using eTicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eTicaret.Controllers
{
    public class HomeController : Controller
    {
        ETICARETDB db = new ETICARETDB();
        // GET: Home
        public ActionResult Index()
        {
            var model = db.Departments.ToList();
            return View();
        }

        public void Doldur()
        {
            using(ETICARETDB db=new ETICARETDB())
            {
                Departments dep1 = new Departments();
                dep1.DeparmentsName = "Books";
                db.Departments.Add(dep1);
                
                Departments dep2 = new Departments();
                dep2.DeparmentsName = "Movies";
                db.Departments.Add(dep2);

                Departments dep3 = new Departments();
                dep3.DeparmentsName = "Electronic";
                db.Departments.Add(dep3);

                Departments dep4 = new Departments();
                dep4.DeparmentsName = "Home";
                db.Departments.Add(dep4);

                Departments dep5 = new Departments();
                dep5.DeparmentsName = "Clothing";
                db.Departments.Add(dep5);

                db.SaveChanges();

            }


        }
    }
}

using MvcAss_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAss_1.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult Index()
        {
            return View(Models.People.DbPeople);
        }

        public ActionResult ListAPeople(int id)
        {
           var people = People.DbPeople.SingleOrDefault(p => p.Id == id);

            if (people != null)
            {
                return PartialView("_ListAPeople", people);
            }
            else
            {
                return new HttpStatusCodeResult(400);
            }
        }

        public ActionResult EditPeople(int id)
        {
            var people = People.DbPeople.SingleOrDefault(p => p.Id == id);

            if (people != null)
            {
                return PartialView("_EditPeople", people);
            }
            else
            {
                return new HttpStatusCodeResult(400);
            }
        }

       


    }
}
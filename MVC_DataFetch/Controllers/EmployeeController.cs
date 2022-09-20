using MVC_DataFetch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DataFetch.Controllers
{
    public class EmployeeController : Controller
    {
        DBEmployeeEntities context = new DBEmployeeEntities();
        public ActionResult GetAllEmployees()
        {
            List<TBLEmployee> employees = context.TBLEmployees.ToList();
            return View("EmployeeGet", employees);
        }

    }
}
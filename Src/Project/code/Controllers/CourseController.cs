using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace code.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult ListCourse()
        {
            var courses = Sitecore.Context.Item.GetChildren().ToArray();
            return View("~/Views/Components/Course.cshtml", courses);
        }
    }
}
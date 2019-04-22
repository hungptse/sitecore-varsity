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
            var courses = Sitecore.Context.Item.Axes.GetDescendants();
            return View("~/Views/Components/Course.cshtml", courses);
        }

        public ActionResult DetailCourse(string ID)
        {
            var courseExisted = Sitecore.Context.Item.Axes.GetDescendants().FirstOrDefault(course => course.ID.ToString().Equals(ID));
            return View("~/Views/Components/CourseDetail.cshtml", courseExisted);
        }
    }
}
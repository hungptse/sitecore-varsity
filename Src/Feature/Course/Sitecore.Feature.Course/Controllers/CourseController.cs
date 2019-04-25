using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.Feature.Course.Controllers
{
    public class CourseController : Controller
    {
        public ActionResult ListCourse()
        {
            var courses = Sitecore.Context.Item.Axes.GetDescendants();
            return View("~/Views/Components/Course.cshtml", courses);
        }

        public ActionResult DetailCourse(string Name)
        {
            var courseExisted = Sitecore.Context.Item;
            return View("~/Views/Components/CourseDetail.cshtml", courseExisted);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.Feature.Course.Controllers
{
    public class CourseController : Controller
    {
        public CourseController()
        {

        }

        public ActionResult ListCourse()
        {
            var courses = Context.Item;
            return View("~/Views/Course/CourseListing.cshtml", courses);
        }

        public ActionResult DetailCourse()
        {
            var courseExisted = Context.Item;
            return View("~/Views/Course/CourseDetail.cshtml", courseExisted);
        }
    }
}
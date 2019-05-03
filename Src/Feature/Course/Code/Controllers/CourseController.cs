using Sitecore.Feature.Course.Models;
using Sitecore.Feature.Course.Services;
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
            CourseListingModel model = CourseListingServices.getInstance().GetItemsByPage(1, Context.Item);
            return View("~/Views/Course/CourseListing.cshtml", model);
        }

        public ActionResult DetailCourse()
        {
            var courseExisted = Context.Item;
            return View("~/Views/Course/CourseDetail.cshtml", courseExisted);
        }

        public ActionResult PopularlCourse()
        {
            var courseExisted = Context.Item.Axes.GetDescendants().OrderByDescending(item => item.Fields[Templates.CourseItem.Fields.Price]);
            return View("~/Views/Course/CourseListing.cshtml", courseExisted);
        }
    }
}
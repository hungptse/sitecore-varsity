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
        
        public ActionResult PopularCourse()
        {
            var courseTopPrice = Context.Item.Parent.Axes.GetDescendants().OrderByDescending(item => int.Parse(item[Templates.CourseItem.Fields.Price])).Take(3).ToArray();
            return View("~/Views/Course/_PopularCourse.cshtml", courseTopPrice);
        }
        public ActionResult TagMajor()
        {
            var listMajor = Context.Item.Parent.Axes.GetDescendants().Select(item => item[Templates.CourseItem.Fields.Major]).Distinct().ToArray();
            return View("~/Views/Course/_TagMajor.cshtml", listMajor);
        }

        public ActionResult CourseRelated()
        {
            var major = Context.Item[Templates.CourseItem.Fields.Major];
            var listCourse = Context.Item.Parent.GetChildren().Where(item => item[Templates.CourseItem.Fields.Major].Equals(major)).ToArray();
            return View("~/Views/Course/_CourseRelated.cshtml", listCourse);
        }
    }
}
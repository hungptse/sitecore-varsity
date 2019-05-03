using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Foundation.Extenstion.Helpers;
using Sitecore.Feature.Course.Models;

namespace Sitecore.Feature.Course.Services
{
    public class CourseListingServices
    {
        private static CourseListingServices services;
        public static CourseListingServices getInstance()
        {
            if (services == null)
            {
                services = new CourseListingServices();
            }
            return services;
        }
        public CourseListingModel GetItemsByPage(int page, Item courses, int ItemsCount = 0)
        {
            var ITEM_PER_PAGE = ItemsCount;
            if (RenderingContext.CurrentOrNull != null)
            {
                ITEM_PER_PAGE = RenderingContext.Current.Rendering.GetIntegerParameter("ITEM_PER_PAGE", 3);
            }
            CourseListingModel model = new CourseListingModel();
            model.Courses = new List<Item>(courses.Axes.GetDescendants()).Skip((page - 1) * ITEM_PER_PAGE).Take(ITEM_PER_PAGE).ToArray();
            model.CoursesSize = courses.GetChildren().Count;
            model.PageMax = (model.CoursesSize + ITEM_PER_PAGE - 1) / ITEM_PER_PAGE;
            model.CourseId = courses.ID.ToString();
            model.ItemsCount = ITEM_PER_PAGE;
            return model;
        }
    }
}
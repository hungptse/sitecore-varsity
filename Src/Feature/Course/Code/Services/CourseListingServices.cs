using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        public Item[] GetItemsByPage(int page, Item parent)
        {
            var ITEM_PER_PAGE = 1;
            var paging = new List<Item>(parent.Axes.GetDescendants()).Skip((page - 1) * ITEM_PER_PAGE).Take(ITEM_PER_PAGE);
            return paging.ToArray();
        }
    }
}
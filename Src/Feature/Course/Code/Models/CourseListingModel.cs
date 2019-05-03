using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.Course.Models
{
    public class CourseListingModel
    {
        public Item[] Courses { get; set; }
        public string CourseId { get; set; }
        public int CoursesSize { get; set; }
        public int PageMax { get; set; }
        public int ItemsCount { get; set; }
    }
}
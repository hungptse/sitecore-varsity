using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Sites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Foundation.Extenstion.Services
{
    public class NotFoundItemService
    {
        protected static Item GetItemByShortPath(SiteContext siteContext, string shortPath)
        {
            shortPath = shortPath.StartsWith("/") ? shortPath.Substring(1) : shortPath;
            var fullPath = string.Concat(StringUtil.EnsurePostfix('/', siteContext.StartPath), shortPath);
            return siteContext.Database.GetItem(fullPath);
        }

        public static Item GetItemBySiteProperty(SiteContext siteContext, string propertyKey)
        {
            var property = siteContext.Properties[propertyKey];
            if (string.IsNullOrWhiteSpace(property))
            {
                return null;
            }

            if (ID.IsID(property) || property.StartsWith(Sitecore.Constants.ContentPath))
            {
                return siteContext.Database.GetItem(property);
            }

            return GetItemByShortPath(siteContext, property);
        }

        public static string GetRelativeFilePathBySiteProperty(SiteContext siteContext, string propertyKey)
        {
            var propertyValue = siteContext.Properties[propertyKey];
            if (!string.IsNullOrWhiteSpace(propertyValue))
            {
                var filePath = System.Web.HttpContext.Current.Server.MapPath(propertyValue);
                if (System.IO.File.Exists(filePath))
                {
                    return propertyValue;
                }
            }

            return string.Empty;
        }
    }
}
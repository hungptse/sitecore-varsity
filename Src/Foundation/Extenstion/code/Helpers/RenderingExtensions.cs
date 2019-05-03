using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Foundation.Extenstion.Helpers
{
    public static class RenderingExtensions
    {
        public static int GetIntegerParameter(this Rendering rendering, string parameterName, int defaultValue = 0)
        {
            if (rendering == null)
            {
                throw new ArgumentNullException(nameof(rendering));
            }

            var parameter = rendering.Parameters[parameterName];
            if (string.IsNullOrEmpty(parameter))
            {
                return defaultValue;
            }

            int returnValue;
            return !int.TryParse(parameter, out returnValue) ? defaultValue : returnValue;
        }
    }
}
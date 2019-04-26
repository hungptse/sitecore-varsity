using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Sitecore.Feature.Course.Pipelines
{
    public class RegisterCourseAPI
    {
        public void Process(PipelineArgs args)
        {
            RouteTable.Routes.MapHttpRoute("Sitecore.Feature.Course.API", "api/course/{controller}/{action}/{id}", new
            {
                id = RouteParameter.Optional
            });
        }

    }
}
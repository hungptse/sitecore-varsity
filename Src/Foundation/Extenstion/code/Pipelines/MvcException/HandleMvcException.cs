using Sitecore.Diagnostics;
using Sitecore.Mvc.Pipelines.MvcEvents.Exception;
using System;
using System.Diagnostics;
using Sitecore;

namespace Vhs.HandleErrorProcessors.Pipelines.MvcException
{
    public class HandleMvcException : ExceptionProcessor
    {
        public override void Process(ExceptionArgs args)
        {
            try
            {
                var site = Context.Site;
                if (site == null)
                {
                    return;
                }

                var enableHandleCustomErrors = MainUtil.GetBool(site.Properties[Constants.SiteInfo.Properties.EnableHandleCustomErrors], false);
                if (!enableHandleCustomErrors)
                {
                    return;
                }

                var context = args.ExceptionContext;
                var httpContext = context.HttpContext;
                var exception = context.Exception;
                if (context.ExceptionHandled || httpContext == null || exception == null)
                {
                    return;
                }

                var errorPageUrl = site.Properties[Constants.SiteInfo.Properties.CustomErrorFile];
                if (string.IsNullOrWhiteSpace(errorPageUrl))
                {
                    return;
                }

                httpContext.Server.ClearError();
                httpContext.Response.StatusCode = (int)System.Net.HttpStatusCode.InternalServerError;
                httpContext.Server.Execute(errorPageUrl);
            }
            catch (Exception ex)
            {
                Log.Error($"{this} {typeof(Process)} : {ex.Message}'", ex, this);
                Log.Error($"{this} {typeof(Process)} : {ex.StackTrace}'", ex, this);
            }
        }
    }
}
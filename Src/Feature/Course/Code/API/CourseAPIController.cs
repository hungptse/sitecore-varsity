using Sitecore.Data.Items;
using Sitecore.Feature.Course.Helpers;
using Sitecore.Feature.Course.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
namespace Sitecore.Feature.Course.API
{
    public class CourseAPIController : ApiController
    {
        [HttpPost]
        public IHttpActionResult GetCourseByPage([FromUri] int page, [FromBody] Dictionary<string, string> body)
        {
            if (page == 0 || body == null)
            {
                return BadRequest();
            }
            var ID = body["ID"];
            try
            {
                var checkID = Context.Database.GetItem(new Data.ID(ID));
            }
            catch (System.Exception)
            {

                return BadRequest();
            }
            var courses = Context.Database.GetItem(new Data.ID(ID));
            if (courses == null)
            {
                return BadRequest();
            }
            if (!courses.TemplateID.Equals(Templates.CourseFolder.ID))
            {
                return BadRequest();
            }
            int size = int.Parse(body["size"]);
            var result = new ViewRenderer().RenderPartialViewToString("~/Views/Course/_CoursePartial.cshtml", CourseListingServices.getInstance().GetItemsByPage(page,courses,size).Courses);
            return Ok(new { content = result });
        }
    }
}

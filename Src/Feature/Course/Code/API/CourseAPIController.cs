using Sitecore.Data.Items;
using Sitecore.Feature.Course.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
namespace Sitecore.Feature.Course.API
{
    public class CourseAPIController : ApiController
    {
        private const int ITEM_PER_PAGE = 1;
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
            var paging = new List<Item>(courses.Axes.GetDescendants()).Skip((page - 1) * ITEM_PER_PAGE).Take(ITEM_PER_PAGE);
            var result = new ViewRenderer().RenderPartialViewToString("~/Views/Course/_CoursePartial.cshtml", paging.ToArray());
            //var result = ViewRender.RenderModel("/Views/Course/_CoursePartial.cshtml", courseItems);
            return Ok(new { content = result });
        }
    }
}

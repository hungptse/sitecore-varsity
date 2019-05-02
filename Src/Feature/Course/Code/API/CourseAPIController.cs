using System.Collections.Generic;
using System.Web.Http;
namespace Sitecore.Feature.Course.API
{
    public class CourseAPIController : ApiController
    {
        private const int ITEM_PER_PAGE = 1;
        [System.Web.Http.HttpPost]
        public dynamic GetCourseByPage([FromUri] int page, [FromBody] Dictionary<string, string> body)
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
            ViewRenderer
            var result = ViewRender.RenderModel("/Views/Course/_CoursePartial.cshtml", courseItems);


            return json;
        }
    }
}

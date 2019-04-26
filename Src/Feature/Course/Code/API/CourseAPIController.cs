using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sitecore.Feature.Course.API
{
    public class CourseAPIController : ApiController
    {
        private const int ITEM_PER_PAGE = 2; 
        [HttpPost]
        public IHttpActionResult GetCourseByPage([FromUri] int page, [FromBody] Dictionary <string,string> body)
            {
            if (page == 0 || body == null)
            {
                return BadRequest();
            }
            var ID = body["ID"];
            var courses = Context.Database.GetItem(new Data.ID(ID));
            if (courses == null)
            {
                return BadRequest();
            }
            if (!courses.TemplateID.Equals(Templates.CourseFolder.ID))
            {
                return BadRequest();
            }
            var pageItems = courses.GetChildren().Skip(page * ITEM_PER_PAGE).Take(ITEM_PER_PAGE);
            return Ok(pageItems);
        }
    }
}

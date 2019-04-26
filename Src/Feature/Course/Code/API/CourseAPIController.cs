using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sitecore.Feature.Course.API
{
    public class CourseAPIController : ApiController
    {
        [HttpPost]
        public IHttpActionResult GetCourseByPage([FromUri] int page, [FromBody] Dictionary <string,string> body)
            {
            if (page == 0 || body == null)
            {
                return BadRequest();
            }
            var ID = body["ID"];
            var courses = Context.Database.GetItem(new Data.ID(ID));

            return Ok("Page " + page + " ID: " + courses);
        }
    }
}

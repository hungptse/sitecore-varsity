using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sitecore.Feature.Course.API
{
    [Route("api/course")]
    public class CourseAPIController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetCourseByPage([FromUri] int page)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }




            return BadRequest();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API.Output;
using System.Configuration;

namespace ApiService.Controllers
{
    [RoutePrefix("api/Output")]
    public class OutputController : ApiController
    {
        public IHttpActionResult Post([FromBody] string message)
        {
            var outputterClass = ConfigurationSettings.AppSettings.Get("Outputter");
            var outputterObj = OutputterFactory.GetOutputter(outputterClass);
            outputterObj.Output(message);

            return Ok();
        }
    }
}

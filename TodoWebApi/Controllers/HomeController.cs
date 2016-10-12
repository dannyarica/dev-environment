using System.Web.Http;
using System;

[assembly:CLSCompliantAttribute(true)]
namespace TodoWebApi.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        int miNuevaVariable;
        int miNuevaVariableMarvin;
        public HomeController()
        {
        }

        [HttpGet]
        [Route("{name}")]
        public IHttpActionResult Get(string name)
        {
            return Ok("Hi " + name);
        }

        [HttpGet]
        public IHttpActionResult GetName()
        {
            return Ok("Hi ");
        }

        private string MiNuevoMetodo(string name)
        {
            return "";
        }
    }
}
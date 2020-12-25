using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BZoom.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvisoryController : ControllerBase
    {

        //https://localhost/api/advisory/

        [HttpGet]
        public List<string> Get()
        {
            var dummies = Dummies();
            return dummies;
        }

        private List<string> Dummies()
        {
            var dummies = new List<string>();
            for (var i = 1; i < 1000; i++)
            {
                dummies.Add($"Data {i}");
            }

            return dummies;
        }

        [HttpGet]
        [Route("{id}")]
        public string Get(int id)
        {
            return "Hello World";
        }

        [HttpPost]
        
        public string Add()
        {
            return "Hello World";
        }
        [HttpPost]
        [Route("locality/{id}")]
        public string AddLocality(int id)
        {
            return "Hello World";
        }
        [HttpPatch]
        public string Update()
        {
            return "Hello World";
        }
        [HttpDelete]
        public string Delete()
        {
            return "Hello World";
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class SampleController : ControllerBase
    {
        public List<Details> details = new List<Details>()
        {
            new Details { Name = "Mounika", Age = 21, Number = 1234, Summary = "developer" },
            new Details { Name = "harika", Age = 25, Number = 1234, Summary = "designer" },
            new Details { Name = "harini", Age = 22, Number = 1234, Summary = "trainee" },
            new Details { Name = "dharani", Age = 24, Number = 1234, Summary = "hr" },
            new Details { Name = "sara", Age = 25, Number = 1234, Summary = "engineer" },
        };

        [HttpGet]

        public ActionResult<Details> GetAllDetails( )
        {
            string name = "harika";
            var found = details.FirstOrDefault(x => x.Name == name);
            if (found == null)
            {
                return NotFound();
            }

            return found;
        }

        [HttpGet("{name}")]
        public ActionResult<Details> GetDetails(string name)
        {
            var detail = details.FirstOrDefault(x => x.Name == name);
            if(detail == null)
            {
                return NotFound();
            }
            return detail;
            
        }
    }
}

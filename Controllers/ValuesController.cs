using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {

            return new string[] { "shuba", "metha", "mohan", "mounika", "santhosh", "haridas" };   
        }
        [HttpGet("{id}")]
        public string  Get(int id)
        {

            return "The value is" + id;
        }
    }
}

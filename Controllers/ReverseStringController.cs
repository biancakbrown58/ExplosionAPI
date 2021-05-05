using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseStringController : ControllerBase
    {
        [HttpGet("{str}")]
        public string Solution(string str)
        {
            // var sentence = "this is the string";
            return new string(str.ToArray().Reverse().ToArray());
        }

    }
}

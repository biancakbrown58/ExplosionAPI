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
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{s}")]
        public string Explode(string s)
        {
            var newString = "";
            foreach (var str in s)
            {
                var number = int.Parse(str.ToString());
                for (var i = 0; i < number; i++)
                {
                    newString += str;
                }
            }
            return newString;
        }
    }
}

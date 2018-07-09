using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ci_demo_api.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Please use relevant endpoint");
        }

        // GET api/values
        [HttpGet("multiply/{numA}/{numB}")]
        public async Task<IActionResult> Multiplier(int numA, int numB)
        {
            return Ok($"The result of {numA} * {numB} is " + MathHelper.Multiply(numA, numB));
        }

        [HttpGet("divide/{numA}/{numB}")]
        public async Task<IActionResult> Divider(int numA, int numB)
        {
            return Ok($"The result of {numA} / {numB} is " + MathHelper.Divide(numA, numB));
        }

        [HttpGet("endpoint/{value}")]
        public async Task<IActionResult> Endpoint(string value)
        {
            return Ok($"You passed a value of {value} to the new endpoint");
        }
    }
}

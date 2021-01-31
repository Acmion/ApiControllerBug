using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SomeController : ControllerBase
    {
        [HttpPost]
        public string Post([FromForm] string parameter)
        {
            // Does not work if parameter is an empty string.

            Request.Form.TryGetValue("parameter", out var value);
            var strValue = (string)value;

            return $"parameter type: {parameter.GetType().ToString()}, strValue type: {strValue.GetType().ToString()}";
        }
    }
}

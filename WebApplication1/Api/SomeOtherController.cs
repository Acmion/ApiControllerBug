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
    public class SomeOtherController : ControllerBase
    {
        [HttpPost]
        public string Post([FromForm] string? parameter)
        {
            // Does work if parameter is an empty string, but then it will be interpreted as null.

            Request.Form.TryGetValue("parameter", out var value);
            var strValue = (string)value;

            if (parameter == null) 
            {
                return $"parameter type: null, strValue type: {strValue.GetType().ToString()}";

            }

            return $"parameter type: {parameter.GetType().ToString()}, strValue type: {strValue.GetType().ToString()}";

        }
    }
}

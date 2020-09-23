using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CloudKulture_de.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CloudKulture_de.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class helloapi : ControllerBase
    {
        private readonly IFibonacci fibonacciServices;
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fibonacciServices">Calling Fibonacci services within a controller</param>
        public helloapi(IFibonacci fibonacciServices)
        {
            this.fibonacciServices = fibonacciServices;
        }

        /// <summary>
        /// Calculate fibonacci series
        /// </summary>
        /// <param name="value">integer whose fibonacci is to be calculated</param>
        /// <returns>the respective Fibonacci number of the given value</returns>
        /// <response code="200">Data found</response>
        /// <response code="400">Bad Request</response>
        [HttpGet]
        [Route("fibonacci/{value}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult fibonacci(int value)
        {
            if (!ModelState.IsValid || value <= 0)
            {
                return BadRequest("Value cannot be null or '0'. Please Enter a value > 0.");
            }

            //Calculate Fibonacci Series / Number
            var getFibonacci = fibonacciServices.calculateFibonacci(value);

            //Implement Dictonary to return Value & its calculated Fibonacci as key value pair (kv)
            var kvFibonacci = new Dictionary<int, int>() { { value, getFibonacci } };

            //Serialize Dictonary
            var returningJson = JsonConvert.SerializeObject(kvFibonacci);

            return Ok(returningJson);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharedLibrary.Dto;

namespace AuthServer.API.Controllers
{
    public class BaseController : ControllerBase
    {
        [HttpGet]
        public IActionResult ActionResultInstance<T>(Response<T> response) where T : class
        {
            return new ObjectResult(response) { StatusCode = response.StatusCode };
        }
    }
}

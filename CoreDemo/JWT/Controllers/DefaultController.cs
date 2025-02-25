using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWT.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet("[action]")]
        public IActionResult Login()
        {
            return Created("",new BuildToken().CreateToken());
        }
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Page1()
        {
            return Ok("Sayfa 1 için girişiniz başarılı.");
        }
    }
}
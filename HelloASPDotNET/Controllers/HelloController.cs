﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    public class HelloController : Controller
    {
        //GET: /helloworld/
        [HttpGet]
        [Route("/helloworld/")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            string html = "<h1>" + "Hello World!" + "<h1>";
            return Content(html, "text/html");
        }
        [HttpGet]
        [Route("/helloworld/welcome/{name?}")]
        //GET: /<controller>/welcome
        public IActionResult Welcome(string name="World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}

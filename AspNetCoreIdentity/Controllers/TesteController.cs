using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KissLog;

namespace AspNetCoreIdentity.Controllers
{
    public class TesteController : Controller
    {
        private readonly ILogger _logger;

        public TesteController(ILogger logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.Trace("Acessou a tela de teste!" + Environment.UserName);


            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ctrlspec.Models;
using ctrlspec.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ctrlspec.Controllers
{
    // [Route("[controller]")]
    // public class ApplicationD3Controller : Controller
    // {
    //     private readonly ILogger<ApplicationD3Controller> _logger;

    //     public ApplicationD3Controller(ILogger<ApplicationD3Controller> logger)
    //     {
    //         _logger = logger;
    //     }

    //     public IActionResult Index()
    //     {
    //         return View();
    //     }

    //     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //     public IActionResult Error()
    //     {
    //         return View("Error!");
    //     }
    // }

    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationD3Controller : ControllerBase
    {
        private readonly ApplicationService _applicationService;

        public ApplicationD3Controller(ApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Application>> GetApplications()
        {
            var applications = _applicationService.GetApplications();
            return Ok(applications);
        }
    }
}
using Interfata.library;
using Interfata.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Interfata.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private SerialPortListener _serialPortConnector;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;

        public HomeController(ILogger<HomeController> logger, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _serialPortConnector = new SerialPortListener();
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Authorize(Roles="Master")]
        public IActionResult Send()
        {  
            var roles=roleManager.Roles;
            ViewBag.roles=roles;
            return View("MessageSender");
        }
        [HttpPost]
        [Authorize(Roles ="Master")]
        public async Task<IActionResult> SendAsync([FromForm] string message , [FromForm] string groupId)
        {
            var roles = roleManager.Roles;
            ViewBag.roles = roles;

            try
            {    
               var users=userManager.Users;
                foreach (var user in users)
                {
                   var userRoles = await userManager.GetRolesAsync(user);
                    if(userRoles.Contains(groupId))
                    {
                        _serialPortConnector.Send(user.PhoneNumber + ':' + message);
                      

                    }
                }

                return Ok("sent");
            }
            catch (Exception)
            {
                return BadRequest("failed");
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

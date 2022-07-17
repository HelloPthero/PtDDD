using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PtDDD.Application.Dto;
using PtDDD.Application.ISerivce;
using PtDDD.Domain.IRepositories;
using PtDDD.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PtDDD.Web.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IUserService UserService;  

        public HomeController(ILogger<HomeController> logger, IUserService userService) 
        {
            _logger = logger;
            UserService = userService;
        }

        public IActionResult Index()
        {
            var input = new UserDto
            {
                Name = "Pthero",
                Password = "123"
            };
            var users = UserService.GetUsers();
            var result = UserService.ValidUser(input);
            return View();
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

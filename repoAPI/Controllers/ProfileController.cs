using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace repoAPI.Controllers
{
    [Route("profile")]
    public class ProfileController : Controller
    {
        private readonly IGitHubService _githubService;
        public ProfileController(IGitHubService githubService)
        {
            _githubService = githubService;
        }
        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var user = await _githubService.GetUser("fellipesena");
            return View("Profile", user);
        }
        [HttpGet("{username}")]
        public async Task<IActionResult> GetUser(string username) {
            var user = await _githubService.GetUser(username);
            return View("Profile", user);
        }
    }
}

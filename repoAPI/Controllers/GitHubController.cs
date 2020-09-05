using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using repoAPI.Services;

namespace repoAPI.Controllers
{
    public class GitHubController : Controller
    {
        private readonly IGitHubService _githubService;
        public GitHubController(IGitHubService githubService)
        {
            _githubService = githubService;
        }

        [HttpGet("users/{username}")]
        public async Task<IActionResult> GetUser(string username) {
            Console.WriteLine("Entrou aqui");
            var user = await _githubService.GetUser(username);
            return user != null ? (IActionResult) Ok(user) : NotFound();
        }
    }
}

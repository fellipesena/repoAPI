using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis;

namespace repoAPI.Controllers
{
    [Route("repository")]
    public class RepositoryController : Controller
    {
        private readonly IGitHubService _githubService;
        public RepositoryController(IGitHubService githubService)
        {
            _githubService = githubService;
        }
        [HttpGet("")]
        public async Task<IActionResult> Index([FromQuery] string search)
        {
            if (String.IsNullOrEmpty(search))
            {
                return View("Repository");
            }
            else
            {
                var repositories = await _githubService.GetRepositoriesFromName(search);
                return View("Repository", repositories);
            }
        }
        [HttpGet("{name}")]
        public async Task<IActionResult> GetRepository(string name)
        {
            var repositories = await _githubService.GetRepositoriesFromName(name);
            return View("Repository", repositories);
        }
    }
}
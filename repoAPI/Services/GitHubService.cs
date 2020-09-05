using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using repoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace repoAPI.Services
{
    public class GitHubService : IGitHubService
    {
        private readonly IHttpClientFactory _clientFactory;

        public GitHubService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<User> GetUser(string username)
        {
            var client = _clientFactory.CreateClient("GitHub");

            var response = await client.GetAsync($"users/{username}");

            var result = await response.Content.ReadAsStringAsync();

            User user = JsonConvert.DeserializeObject<User>(result);

            return user;
        }
    }
}

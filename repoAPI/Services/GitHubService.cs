using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using repoAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

            user.Repositories = await GetRepositoriesFromUser(user.Login);

            return user;
        }
        public async Task<Repository> GetRepositoryFromId(string id)
        {
            var client = _clientFactory.CreateClient("GitHub");

            var response = await client.GetAsync($"/repositories/{id}");

            var result = await response.Content.ReadAsStringAsync();

            Repository repository = JsonConvert.DeserializeObject<Repository>(result);

            repository.Contribuitors = await GetContributors(repository.FullName);

            repository.Favourite = true;

            return repository;
        }
        public async Task<List<Repository>> GetRepositoriesFromName(string name)
        {
            var client = _clientFactory.CreateClient("GitHub");

            var response = await client.GetAsync($"search/repositories?q={name}");

            var result = await response.Content.ReadAsStringAsync();

            RepositoryResponse repositoryList = JsonConvert.DeserializeObject<RepositoryResponse>(result);

            List<Repository> repositories = repositoryList.Item;

            string path = Directory.GetCurrentDirectory();

            foreach (var repo in repositories)
            {
                using (StreamReader reader = new StreamReader(path + "/Services/Favourites/favourites.txt"))
                {
                    string id;
                    while ((id = reader.ReadLine()) != null)
                    {
                        if (String.Compare(id, repo.Id) == 0)
                        {
                            repo.Favourite = true;
                        }
                    }
                    reader.Close();
                }
                repo.Contribuitors = await GetContributors(repo.FullName);
            }

            return repositories;
        }
        public async Task<List<Repository>> GetRepositoriesFromUser(string username)
        {
            var client = _clientFactory.CreateClient("GitHub");

            var response = await client.GetAsync($"users/{username}/repos");

            var result = await response.Content.ReadAsStringAsync();

            List<Repository> repositories = JsonConvert.DeserializeObject<List<Repository>>(result);

            string path = Directory.GetCurrentDirectory();

            foreach (var repo in repositories)
            {
                using (StreamReader reader = new StreamReader(path + "/Services/Favourites/favourites.txt"))
                {
                    string id;
                    while ((id = reader.ReadLine()) != null)
                    {
                        if (String.Compare(id, repo.Id) == 0)
                        {
                            repo.Favourite = true;
                        }
                    }
                    reader.Close();
                }
                repo.Contribuitors = await GetContributors(repo.FullName);
            }
            return repositories;
        }
        public async Task<List<Contributor>> GetContributors(string full_name)
        {
            var client = _clientFactory.CreateClient("GitHub");

            var response = await client.GetAsync($"repos/{full_name}/contributors");

            var result = await response.Content.ReadAsStringAsync();

            List<Contributor> contributors = new List<Contributor>();

            if (result.Length > 0)
            {
                contributors = JsonConvert.DeserializeObject<List<Contributor>>(result);
            }
            else
            {
                contributors.Add(new Contributor()
                {
                    Login = "Não há contribuidores!"
                });
            }
            return contributors;
        }
        
    }
}
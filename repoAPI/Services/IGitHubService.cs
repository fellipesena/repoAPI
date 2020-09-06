using repoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repoAPI
{
    public interface IGitHubService
    {
        Task<User> GetUser(string username);
        Task<List<Repository>> GetRepositoriesFromName(string name);
        Task<List<Repository>> GetRepositoriesFromUser(string username);
        Task<Repository> GetRepositoryFromId(string id);
        Task<List<Contributor>> GetContributors(string name);

    }
}
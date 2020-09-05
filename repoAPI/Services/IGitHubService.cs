using repoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repoAPI.Services
{
    public interface IGitHubService
    {
        Task<User> GetUser(string username);
    }
}

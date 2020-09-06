using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repoAPI.Models
{
    public class User
    {
        [JsonProperty("avatar_url")] public string AvatarUrl { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("login")] public string Login { get; set; }
        [JsonProperty("bio")] public string Bio { get; set; }
        [JsonProperty("location")] public string Location { get; set; }
        [JsonProperty("blog")] public string Blog { get; set; }
        public List<Repository> Repositories { get; set; }
    }
}
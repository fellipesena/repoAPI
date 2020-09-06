using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repoAPI.Models
{
    public class RepositoryResponse
    {
        [JsonProperty("items")] public List<Repository> Item { get; set; }
    }
}

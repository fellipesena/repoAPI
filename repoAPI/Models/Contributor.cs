using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repoAPI.Models
{
    public class Contributor
    {
        [JsonProperty("login")] public string Login { get; set; }
    }
}
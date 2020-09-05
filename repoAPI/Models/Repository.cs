﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repoAPI.Models
{
    public class Owner
    {
        [JsonProperty("login")]
        public string Login { get; set; }
    }
    public class Repository
    {
        [JsonProperty("id")] public string Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("full_name")] public string FullName { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("language")] public string Language { get; set; }
        [JsonProperty("updated_at")] public string Lastupdate { get; set; }
        [JsonProperty("owner")] public Owner Owner { get; set; }
        [JsonProperty("avatar_url")] public List<Contributor> Contribuitors { get; set; }
        public bool Favourite { get; set; }
    }
}

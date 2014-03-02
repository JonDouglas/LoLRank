using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class LeagueDto
    {
        [JsonProperty("entries")]
        public List<LeagueItemDto> Entries { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("queue")]
        public string Queue { get; set; }
        [JsonProperty("tier")]
        public string Tier { get; set; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}

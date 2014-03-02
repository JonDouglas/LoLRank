using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class ChampionStatsDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("stats")]
        public List<ChampionStatDto> Stats { get; set; }
    }
}

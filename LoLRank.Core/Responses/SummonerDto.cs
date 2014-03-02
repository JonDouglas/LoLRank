using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class SummonerDto
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }
        [JsonProperty("revisionDateStr")]
        public string RevisionDateStr { get; set; }
        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }
    }
}

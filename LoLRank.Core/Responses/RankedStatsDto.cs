using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class RankedStatsDto
    {
        [JsonProperty("champions")]
        public List<ChampionStatsDto> Champions { get; set; }
        [JsonProperty("modifyDate")]
        public long ModifyDate { get; set; }
        [JsonProperty("modifyDateStr")]
        public string ModifyDateStr { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

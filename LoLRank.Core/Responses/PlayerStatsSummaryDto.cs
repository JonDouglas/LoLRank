using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class PlayerStatsSummaryDto
    {
        [JsonProperty("aggregatedStats")]
        public List<AggregatedStatDto> AggregatedStats { get; set; }
        [JsonProperty("losses")]
        public int Losses { get; set; }
        [JsonProperty("modifyDate")]
        public long ModifyDate { get; set; }
        [JsonProperty("modifyDateStr")]
        public string ModifyDateStr { get; set; }
        [JsonProperty("playerStatSummaryType")]
        public string PlayerStatSummaryType { get; set; }
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}

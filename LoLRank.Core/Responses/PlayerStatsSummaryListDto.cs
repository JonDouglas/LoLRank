using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class PlayerStatsSummaryListDto
    {
        [JsonProperty("playerStatSummaries")]
        public List<PlayerStatsSummaryDto> PlayerStatSummaries { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

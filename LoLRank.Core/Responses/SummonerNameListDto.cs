using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class SummonerNameListDto
    {
        [JsonProperty("summoners")]
        public List<SummonerNameDto> Summoners { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class ChampionListDto
    {
        [JsonProperty("champions")]
        public List<ChampionDto> Champions { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class RecentGamesDto
    {
        [JsonProperty("games")]
        public List<GameDto> Games { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class MasteryPagesDto
    {
        [JsonProperty("pages")]
        public List<MasteryPageDto> Pages { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

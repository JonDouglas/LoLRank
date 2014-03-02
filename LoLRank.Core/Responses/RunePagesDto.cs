using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class RunePagesDto
    {
        [JsonProperty("pages")]
        public List<RunePageDto> Pages { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}

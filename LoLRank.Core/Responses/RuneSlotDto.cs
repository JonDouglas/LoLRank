using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class RuneSlotDto
    {
        [JsonProperty("rune")]
        public RuneDto Rune { get; set; }
        [JsonProperty("runeSlotId")]
        public int RuneSlotId { get; set; }
    }
}

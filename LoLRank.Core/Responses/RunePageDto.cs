using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class RunePageDto
    {
        [JsonProperty("current")]
        public bool Current { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("slots")]
        public List<RuneSlotDto> Slots { get; set; }
    }
}

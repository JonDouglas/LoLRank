using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class MasteryPageDto
    {
        [JsonProperty("current")]
        public bool Current { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("talents")]
        public List<TalentDto> Talents { get; set; }
    }
}

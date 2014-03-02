using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class MiniSeriesDto
    {
        [JsonProperty("losses")]
        public int Losses { get; set; }
        [JsonProperty("progress")]
        public char[] Progress { get; set; }
        [JsonProperty("target")]
        public int Target { get; set; }
        [JsonProperty("timeLeftToPlayMillis")]
        public long TimeLeftToPlayMillis { get; set; }
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}

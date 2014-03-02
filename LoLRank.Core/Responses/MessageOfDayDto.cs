using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class MessageOfDayDto
    {
        [JsonProperty("createDate")]
        public long CreateDate { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("version")]
        public int Version { get; set; }
    }
}

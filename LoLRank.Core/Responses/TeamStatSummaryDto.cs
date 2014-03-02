using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class TeamStatSummaryDto
    {
        [JsonProperty("teamId")]
        public TeamIdDto TeamId { get; set; }
        [JsonProperty("teamStatDetails")]
        public List<TeamStatDetailDto> TeamStatDetails { get; set; }
    }
}

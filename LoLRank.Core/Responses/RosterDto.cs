using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class RosterDto
    {
        [JsonProperty("memberList")]
        public List<TeamMemberInfoDto> MemberList { get; set; }
        [JsonProperty("ownerId")]
        public long OwnerId { get; set; }
    }
}

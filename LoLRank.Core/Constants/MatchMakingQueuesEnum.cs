using Newtonsoft.Json;

namespace LoLRank.Core.Constants
{
    public enum MatchMakingQueuesEnum
    {
        [JsonProperty("queueId")]
        Normal5v5BlindPick = 2,
        [JsonProperty("queueId")]
        RankedSolo5v5 = 4,
        [JsonProperty("queueId")]
        CoopVsAI5v5 = 7,
        [JsonProperty("queueId")]
        Normal3v3 = 8,
        [JsonProperty("queueId")]
        Normal5v5DraftPick = 14,
        [JsonProperty("queueId")]
        Dominion5v5BlindPick = 16,
        [JsonProperty("queueId")]
        Dominion5v5DraftPick = 17,
        [JsonProperty("queueId")]
        DominionCoopVsAI = 25,
        [JsonProperty("queueId")]
        RankedTeam3v3 = 41,
        [JsonProperty("queueId")]
        RankedTeam5v5 = 42,
        [JsonProperty("queueId")]
        TwistedTreelineCoopVsAI = 52,
        [JsonProperty("queueId")]
        ARAM = 65,
        [JsonProperty("queueId")]
        ARAMCoopVsAI = 67
    }
}

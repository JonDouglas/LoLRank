using Newtonsoft.Json;

namespace LoLRank.Core.Constants
{
    public static class GameModesConst
    {
        [JsonProperty("gameMode")] public const string CLASSIC = "CLASSIC";
        [JsonProperty("gameMode")] public const string DOMINION = "ODIN";
        [JsonProperty("gameMode")] public const string ARAM = "ARAM";
        [JsonProperty("gameMode")] public const string TUTORIAL = "TUTORIAL";
    }
}

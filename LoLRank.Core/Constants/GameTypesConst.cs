using Newtonsoft.Json;

namespace LoLRank.Core.Constants
{
    public static class GameTypesConst
    {
        [JsonProperty("gameType")] public const string CUSTOM_GAME = "CUSTOM_GAME";

        [JsonProperty("gameType")] public const string MATCHED_GAME = "MATCHED_GAME";

        [JsonProperty("gameType")] public const string CO_OP_VS_AI_GAME = "CO_OP_VS_AI_GAME";

        [JsonProperty("gameType")] public const string TUTORIAL_GAME = "TUTORIAL_GAME";
    }
}

using Newtonsoft.Json;

namespace LoLRank.Core.Constants
{
    public enum MapNamesEnum
    {
        [JsonProperty("mapId")]
        SummonersRiftSummer = 1,
        [JsonProperty("mapId")]
        SummonersRiftAutumn = 2,
        [JsonProperty("mapId")]
        ProvingGrounds = 3,
        [JsonProperty("mapId")]
        TwistedTreelineOriginal = 4,
        [JsonProperty("mapId")]
        CrystalScar = 8,
        [JsonProperty("mapId")]
        TwistedTreelineCurrent = 10,
        [JsonProperty("mapId")]
        HowlingAbyss = 12
    }
}

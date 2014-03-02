using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class GameDto
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("createDate")]
        public long CreateDate { get; set; }
        [JsonProperty("createDateStr")]
        public string CreateDateStr { get; set; }
        [JsonProperty("fellowPlayers")]
        public List<PlayerDto> FellowPlayers { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("gameType")]
        public string GameType { get; set; }
        [JsonProperty("invalid")]
        public bool Invalid { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("mapId")]
        public int MapId { get; set; }
        [JsonProperty("spell1")]
        public int Spell1 { get; set; }
        [JsonProperty("spell2")]
        public int Spell2 { get; set; }
        [JsonProperty("statistics")]
        public List<RawStatDto> Statistics { get; set; }
        [JsonProperty("subType")]
        public string SubType { get; set; }
        [JsonProperty("teamId")]
        public int TeamId { get; set; }
    }
}

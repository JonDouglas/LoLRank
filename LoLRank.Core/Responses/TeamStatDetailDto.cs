using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace LoLRank.Core.Responses
{
    public class TeamStatDetailDto
    {
        [JsonProperty("averageGamesPlayed")]
        public int AverageGamesPlayed { get; set; }
        [JsonProperty("losses")]
        public int Losses { get; set; }
        [JsonProperty("maxRating")]
        public int MaxRating { get; set; }
        [JsonProperty("rating")]
        public int Rating { get; set; }
        [JsonProperty("seedRating")]
        public int SeedRating { get; set; }
        [JsonProperty("teamId")]
        public TeamIdDto Teamid { get; set; }
        [JsonProperty("teamStatType")]
        public string TeamStatType { get; set; }
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}

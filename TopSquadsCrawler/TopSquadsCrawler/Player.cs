using Newtonsoft.Json;

namespace CrawlerDemo
{
    internal class Player
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("rating")]
        public int Rating { get; internal set; }

        [JsonProperty("position
        public string Position { get; internal set; }
        public string ImageUrl { get; internal set; }
        public string Color { get; set; }
        public string Price { get; set; }
        public string ClubId { get; set; }
        public string ClubName { get; set; }
        public string ClubImg { get; set; }
        public string NationId { get; set; }
        public string NationName { get; set; }
        public string NationImg { get; set; }
        public string LeagueId { get; set; }
        public string LeagueName { get; set; }
        public string LeagueImg { get; set; }
        public int Pace { get; set; }
        public int Shooting { get; set; }
        public int Passing { get; set; }
        public int Dribbling { get; set; }
        public int Defending { get; set; }
        public int Physicality { get; set; }

    }
}
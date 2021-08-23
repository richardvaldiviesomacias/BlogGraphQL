using Newtonsoft.Json;

namespace BlogGraphQL.Models.Data
{
    public class Post
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("views")]
        public long Views { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }
    }
}
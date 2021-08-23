using Newtonsoft.Json;

namespace BlogGraphQL.Models.Data
{
    public class Blog
    {
        [JsonProperty("posts")]
        public Post[] Posts { get; set; }

        [JsonProperty("users")]
        public User[] Users { get; set; }

        [JsonProperty("comments")]
        public Comment[] Comments { get; set; }
    }
}
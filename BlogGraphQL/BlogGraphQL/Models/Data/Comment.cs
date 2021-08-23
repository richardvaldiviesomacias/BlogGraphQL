using Newtonsoft.Json;

namespace BlogGraphQL.Models.Data
{
    public class Comment
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("post_id")]
        public long PostId { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }
    }
}
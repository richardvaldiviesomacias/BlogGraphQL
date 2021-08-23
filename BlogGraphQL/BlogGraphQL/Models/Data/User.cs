using Newtonsoft.Json;

namespace BlogGraphQL.Models.Data
{
    public class User
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
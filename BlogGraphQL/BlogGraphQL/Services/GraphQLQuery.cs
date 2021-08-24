using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace BlogGraphQL.Services
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class GraphQLQuery
    {
        private readonly GraphQLHttpClient client = new("http://localhost:5000", new NewtonsoftJsonSerializer());
        private readonly string query;

        public GraphQLQuery(string query)
        {
            //validate query
            this.query = query;
        }

        public async Task<T> Execute<T>()
        {
            var request = new GraphQLRequest
            {
                Query = query
            };
            var response = await client.SendQueryAsync<T>(request);
            return response.Data;
        }
    }
}
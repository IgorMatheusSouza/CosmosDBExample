using CosmosDBExample.Config;
using Microsoft.Azure.Cosmos;

namespace CosmosDBExemple.Data
{
    public class NoSQLDatabase<T>
    {
        private static readonly string EndpointUri = AppSettings.CosmosDdEndpointUri;
        private static readonly string PrimaryKey = AppSettings.CosmosDdPrimaryKey;
        private readonly string databaseId = "db1";

        public async Task<IEnumerable<T>> GetAllItens(string containerId = "Pessoas")
        {
            CosmosClient cosmosClient = new(EndpointUri, PrimaryKey);

            var sqlQueryText = "SELECT * FROM c";

            Database database = cosmosClient.GetDatabase(databaseId);
            Container container = database.GetContainer(containerId);

            List<T> lista = new();

            QueryDefinition queryDefinition = new(sqlQueryText);

            var iterator = container.GetItemQueryIterator<T>(queryDefinition);

            while (iterator.HasMoreResults)
            {
                FeedResponse<T> result = await iterator.ReadNextAsync();
                foreach (var item in result)
                {
                    lista.Add(item);
                }
            }

            return lista;
        }
    }
}
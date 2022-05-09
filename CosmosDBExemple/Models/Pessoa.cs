using Newtonsoft.Json;

namespace CosmosDBExample.Models
{
    public class Pessoa
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        public string? Nome { get; set; }

        public int Idade { get; set; }

        public string? Nacionalidade { get; set; }
    }
}

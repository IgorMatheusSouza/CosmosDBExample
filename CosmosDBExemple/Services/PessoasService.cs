using CosmosDBExample.Models;
using CosmosDBExemple.Data;

namespace CosmosDBExemple.Services
{
    public class PessoasService : IPessoasService
    {
        private readonly NoSQLDatabase<Pessoa> _noSQLDataBase;

        public string container = "Pessoas";

        public PessoasService()
        {
            _noSQLDataBase = new();
        }

        public async Task<IEnumerable<Pessoa>> GetPessoas() 
        {
            return await _noSQLDataBase.GetAllItens(container);
        }
    }
}

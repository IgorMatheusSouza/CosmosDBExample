using CosmosDBExample.Models;

namespace CosmosDBExemple.Services
{
    public interface IPessoasService
    {
        Task<IEnumerable<Pessoa>> GetPessoas();
    }
}

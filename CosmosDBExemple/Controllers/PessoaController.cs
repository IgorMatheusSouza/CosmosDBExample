using CosmosDBExemple.Services;
using Microsoft.AspNetCore.Mvc;

namespace CosmosDBExemple.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoasService _pessoasService;

        public PessoaController(ILogger<PessoaController> logger, IPessoasService pessoasService)
        {
            _pessoasService = pessoasService;
        }

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            var result = await _pessoasService.GetPessoas();
            return Ok(result);
        }
    }
}
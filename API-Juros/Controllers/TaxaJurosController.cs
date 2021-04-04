using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITaxaJuros.Application.Interfaces.TaxaJuros;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APITaxaJuros.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosAppService _taxaJurosAppService;

        public TaxaJurosController(ITaxaJurosAppService taxaJurosAppService)
        {
            _taxaJurosAppService = taxaJurosAppService;
        }

        /// <summary>Informa o valor do Juros.</summary>
        /// <response code="200">Resultado Sucesso</response>
        /// <response code="404">Resultado não encontrado</response>     
        /// <response code="500">Erro interno</response>
        /// <returns> Retorna o valor de um percentual.</returns>
        [HttpGet]
        [Route("taxajuros")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAsync()
        {
            var retorno = await _taxaJurosAppService.GetTaxaJurosAsync().ConfigureAwait(false);

            return Ok(retorno);
        }
    }
}

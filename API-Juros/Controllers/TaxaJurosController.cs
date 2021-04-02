using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Juros.Application.TaxaJuros;
using API_Juros.Application.TaxaJuros.ViewModel;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API_Juros.Controllers
{
    [ApiController]
    [Route("taxajuros")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosAppService _taxaJurosAppService;

        public TaxaJurosController(ITaxaJurosAppService taxaJurosAppService)
        {
            _taxaJurosAppService = taxaJurosAppService;
        }

        [HttpGet]
        public async Task<TaxaJurosViewModel> Get()
        {
            var retorno = await _taxaJurosAppService.GetTaxaJuros();

            if (retorno == null) NotFound();

            return retorno;
        }
    }
}

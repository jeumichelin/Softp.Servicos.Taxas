using Microsoft.AspNetCore.Mvc;
using Softp.Servicos.Taxas.Infra.CrossCutting.Constants;

namespace Softp.Servicos.Taxas.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaController : ControllerBase
    {
        /// <summary>
        /// Obter a taxa de juros padrão
        /// </summary>
        [HttpGet("/taxaJuros")]
        public double ObterTaxaDeJuros()
        {
            return CTaxaPadrao.Juros;
        }
    }
}

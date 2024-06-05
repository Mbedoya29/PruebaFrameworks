using Prueba.Models;
using Prueba.Services.Quotes;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers.Quotes
{
    [ApiController]
    [Route("api/quote")]
    public class QuoteCreateController : ControllerBase
    {
        private readonly IQuotesRepository _quotesRepository;
        public QuoteCreateController(IQuotesRepository quotesRepository)
        {
            _quotesRepository = quotesRepository;
        }
        [HttpPost]
        public IActionResult CreateQuote([FromBody] Quote quote)
        {
            _quotesRepository.CreateQuote(quote);
            return Ok();
        }
    }
}
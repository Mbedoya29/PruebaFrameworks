using Prueba.Models;
using Prueba.Services.Quotes;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers.Quotes
{
    public class QuoteUpdateController : ControllerBase
    {
        private readonly IQuotesRepository _quotesRepository;
        public QuoteUpdateController(IQuotesRepository quotesRepository)
        {
            _quotesRepository = quotesRepository;
        }
        [HttpPut("api/quote/{Id}")]
        public void UpdateQuote(int Id, [FromBody] Quote quote) => _quotesRepository.UpdateQuote(quote.Id, quote);
    }
}
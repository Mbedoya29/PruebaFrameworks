using Prueba.Models;
using Prueba.Services.Quotes;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers.Quotes
{
     public class QuoteSearchDayController : ControllerBase
    {
        private readonly IQuotesRepository _quotesRepository;
        public QuoteSearchDayController(IQuotesRepository quotesRepository)
        {
            _quotesRepository = quotesRepository;
        }

        [HttpGet]
        [Route("api/{date}/date")]
        public IEnumerable<Quote> SearchQuoteDay(DateTime date) => _quotesRepository.SearchQuoteDay(date);
    }
}
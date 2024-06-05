using Prueba.Models;
using Prueba.Services.Quotes;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers.Quotes
{
    public class QuotesController : ControllerBase
    {
        private readonly IQuotesRepository _quotesRepository;
        public QuotesController(IQuotesRepository quotesRepository)
        {
            _quotesRepository = quotesRepository;
        }
        [HttpGet]
        [Route("api/quotes")]
        public IEnumerable<Quote> GetQuotes()
        {
            return _quotesRepository.GetAll();
        }
        [HttpGet]
        [Route("api/quote/{id}")]
        public Quote GetQuote(int id)
        {
            return _quotesRepository.GetById(id);
        }
    }
}
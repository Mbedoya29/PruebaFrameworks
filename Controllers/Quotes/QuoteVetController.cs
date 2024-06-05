using Prueba.Models;
using Prueba.Services.Quotes;
using Microsoft.AspNetCore.Mvc;

namespace Prueba.Controllers.Quotes
{
     public class QuoteVetController : ControllerBase
    {
        private readonly IQuotesRepository _quotesRepository;
        public QuoteVetController(IQuotesRepository quotesRepository)
        {
            _quotesRepository = quotesRepository;
        }

        [HttpGet]
        [Route("api/quotes/{Id}/vets")]
        public IEnumerable<Quote> QuoteVet(int Id) => _quotesRepository.QuoteVet(Id);
    }
}
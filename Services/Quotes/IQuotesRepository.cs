using Prueba.Models;

namespace Prueba.Services.Quotes
{
    public interface IQuotesRepository
    {
        IEnumerable<Quote> GetAll();
        Quote GetById(int id);
        void CreateQuote (Quote quote);
        void UpdateQuote (int id, Quote quote);
        IEnumerable<Quote> SearchQuoteDay (DateTime date);
        IEnumerable<Quote> QuoteVet (int id);
    }
}
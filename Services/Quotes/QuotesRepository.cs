using Prueba.Models;
using Prueba.Data;

namespace Prueba.Services.Quotes
{
    public class QuotesRepository : IQuotesRepository
    {
        private readonly BaseContext _context;
        public QuotesRepository(BaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Quote> GetAll()
        {
            return _context.Quotes.ToList();
        }
        public Quote GetById(int id)
        {
            return _context.Quotes.Find(id);
        }
        public void CreateQuote(Quote quote)
        {
            _context.Quotes.Add(quote);
            _context.SaveChanges();
        }
        public void UpdateQuote(int id, Quote quote)
        {
            _context.Quotes.Update(quote);
            _context.SaveChanges();
        }
        public IEnumerable<Quote> SearchQuoteDay (DateTime date)
        {
            return _context.Quotes.Where(q => q.Date == date).ToList();
        }
         public IEnumerable<Quote> QuoteVet(int id)
        {
            return _context.Quotes.Where(q => q.VetId == id).ToList();
        }
    }
}
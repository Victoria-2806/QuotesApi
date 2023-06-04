using Microsoft.AspNetCore.Mvc;
using QuotesApi.Clients;
using QuotesApi.Models;

namespace QuotesApi.Controllers
{
    [ApiController]
    [Route("/")]

    public class QuoteControllerFavqs : ControllerBase
    {
        private readonly ILogger<QuoteControllerFavqs> _logger;
        public QuoteControllerFavqs(ILogger<QuoteControllerFavqs> logger)
        {
            _logger = logger;
        }

        [HttpGet("quotes")]
        public async Task<ActionResult<List<QuoteFavqs>>> GetAllQuotes()
        {
            QuotesClientFavqs client = new QuotesClientFavqs();
            var quotes = await client.GetAllQuotes();
            return Ok(quotes);
        }

        [HttpGet("quotes/{authorName}")]
        public async Task<ActionResult<List<QuoteFavqs>>> GetQuotesByAuthor(string authorName)
        {
            QuotesClientFavqs client = new QuotesClientFavqs();
            var quotes = await client.GetQuotesByAuthor(authorName);
            return Ok(quotes);
        }

        [HttpGet("{quoteId}", Name = "quote")]
        public QuoteFavqs QuoteFavqs(string quoteId)
        {
            QuotesClientFavqs client = new QuotesClientFavqs();
            return client.GetQuoteAsync(quoteId).Result;
        }
    }
}
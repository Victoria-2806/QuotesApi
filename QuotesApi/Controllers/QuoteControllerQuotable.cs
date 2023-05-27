using Microsoft.AspNetCore.Mvc;
using QuotesApi.Models;
using TelegramQuotesBot.Client;

namespace QuotesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class QuoteControllerQuotable : ControllerBase
    {
        private readonly ILogger<QuoteControllerQuotable> _logger;
        public QuoteControllerQuotable(ILogger<QuoteControllerQuotable> logger)
        {
            _logger = logger;
        }


        [HttpGet("random")]
        public QuoteQuotable QuoteQuotable()
        {
            QuotesClientQuotable client = new QuotesClientQuotable();
            return client.GetRandomQuoteAsync().Result;
        }

    }
}

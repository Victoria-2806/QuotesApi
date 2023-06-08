using Npgsql;
using QuotesApi.Models;

namespace QuotesApi
{
    public class Database
    {
        NpgsqlConnection con = new NpgsqlConnection(Constants.Connect);
        public async Task InsertQuotesQuotableAsync(QuoteQuotable quoteQuotable)
        {
            var sql = "insert into public.\"QuotesKursova\"(\"Id\", \"Author\", \"Content\")"
                + $"values (@Id, @Author, @Content)";
            NpgsqlCommand comm = new NpgsqlCommand(sql, con);
            comm.Parameters.AddWithValue("Id", quoteQuotable.Id);
            comm.Parameters.AddWithValue("Author", quoteQuotable.Author);
            comm.Parameters.AddWithValue("Content", quoteQuotable.Content);
            await con.OpenAsync();
            await comm.ExecuteNonQueryAsync();
            await con.CloseAsync();
        }

        public async Task InsertQuotesFavqsAsync(QuoteFavqs quoteFavqs)
        {
            var sql = "insert into public.\"QuotesKursova\"(\"Id\", \"Author\", \"Body\")"
                + $"values (@Id, @Author, @Body)";
            NpgsqlCommand comm = new NpgsqlCommand(sql, con);
            comm.Parameters.AddWithValue("Id", quoteFavqs.Id);
            comm.Parameters.AddWithValue("Author", quoteFavqs.Author);
            comm.Parameters.AddWithValue("Body", quoteFavqs.Body);
            await con.OpenAsync();
            await comm.ExecuteNonQueryAsync();
            await con.CloseAsync();
        }


    }
}

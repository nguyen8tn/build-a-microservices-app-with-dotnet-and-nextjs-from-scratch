using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

public class DbInitializer
{

    public static void InitDb(WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        SeedData(scope.ServiceProvider.GetService<AuctionDBContext>());
    }
    private static void SeedData(AuctionDBContext context)
    {
        context.Database.Migrate();
        if (context.Auctions.Any())
        {
            return; // DB has been seeded
        }
        var auctions = new List<Auction>()
        {

        };
        context.Auctions.AddRange(auctions);

    }
}
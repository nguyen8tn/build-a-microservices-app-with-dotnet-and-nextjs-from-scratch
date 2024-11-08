namespace AuctionService.Entities
{
    public class Auction
    {
        public Guid Id { get; set; } // Automatically assign a new Guid for each Auction
        public int ReservePrice { get; set; } = 0; // Default value 0
        public string Seller { get; set; } // Username of the seller (from claim)
        public string? Winner { get; set; } // Username of the winner, nullable until someone wins
        public int? SoldAmount { get; set; } // Nullable Sold Amount until a sale occurs
        public int? CurrentHighBid { get; set; } // Nullable Current High Bid until bids are placed
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Default to current UTC date/time
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; // Default to current UTC date/time, can be updated
        public DateTime AuctionEnd { get; set; } // Set a specific auction end date/time
        public Status Status { get; set; } = Status.Live; // Default to Status.Live
        public Item Item { get; set; } // Item being auctioned (define Item class as needed)

    }
}
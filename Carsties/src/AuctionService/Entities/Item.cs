using AuctionService.Entities;

public class Item
{
    public Guid Id { get; set; } // Automatically assign a new Guid for each Item
    public string Make { get; set; } // Manufacturer of the item
    public string Model { get; set; } // Model of the item
    public int Year { get; set; } // Year of manufacture
    public string Color { get; set; } // Color of the item
    public int Mileage { get; set; } // Mileage of the item
    public string ImageUrl { get; set; } // URL for an image of the item
    public Auction Auction { get; set; } // Related Auction object
    public Guid AuctionId { get; set; } // Foreign key for the Auction ID
}
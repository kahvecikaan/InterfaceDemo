namespace InterfaceDemo.Entities;

public class Player
{
    public string? TcNo { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int BirthYear { get; set; }
    public List<Game> PurchasedGames { get; set; } = new List<Game>();
}
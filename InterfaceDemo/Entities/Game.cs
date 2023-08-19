namespace InterfaceDemo.Entities;

public class Game
{
    public string Title { get; set; }
    public decimal Price { get; set; }
    public Campaign? Campaign { get; set; }
}
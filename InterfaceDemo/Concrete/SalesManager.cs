using InterfaceDemo.Abstract;
using InterfaceDemo.Entities;

namespace InterfaceDemo.Concrete;

public class SalesManager:ISalesService
{
    public void SellGame(Player player, Game game)
    {
        if (game.Campaign != null)
        {
            decimal discountAmount = (game.Price * game.Campaign.Discount) / 100;
            game.Price -= discountAmount;
        }
        player.PurchasedGames.Add(game);
        Console.WriteLine($"{game.Title} sold to {player.FirstName} {player.LastName} for {game.Price}!");
    }
}
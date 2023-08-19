using InterfaceDemo.Abstract;
using InterfaceDemo.Concrete;
using InterfaceDemo.Entities;

namespace InterfaceDemo;

public class Program
{
    public static void Main(string[] args)
    {
        Player player = new Player { TcNo = "12345678901", FirstName = "John", LastName = "Doe", BirthYear = 1990 };
        IVerificationService verificationService = new EGovernmentVerificationService();
        IPlayerService playerService = new PlayerManager(verificationService);
        playerService.Register(player);

        Game game = new Game { Title = "Awesome Game", Price = 100m };
        Campaign campaign = new Campaign { Name = "Summer Sale", Discount = 10 };
        ICampaignService campaignService = new CampaignManager();
        campaignService.AddCampaign(game, campaign);

        ISalesService salesService = new SalesManager();
        salesService.SellGame(player, game);
    }
}
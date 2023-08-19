using InterfaceDemo.Abstract;
using InterfaceDemo.Entities;

namespace InterfaceDemo.Concrete;

public class CampaignManager:ICampaignService
{
    public void AddCampaign(Game game, Campaign campaign)
    {
        game.Campaign = campaign;
        Console.WriteLine($"Campaign {campaign.Name} added to {game.Title}!");
    }

    public void UpdateCampaign(Game game, Campaign campaign)
    {
        game.Campaign = campaign;
        Console.WriteLine($"Campaign for {game.Title} updated to {campaign.Name}!");
    }

    public void DeleteCampaign(Game game)
    {
        game.Campaign = null;
        
    }
}
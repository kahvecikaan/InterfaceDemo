using InterfaceDemo.Entities;

namespace InterfaceDemo.Abstract;

public interface ICampaignService
{
    void AddCampaign(Game game, Campaign campaign);
    void UpdateCampaign(Game game, Campaign campaign);
    void DeleteCampaign(Game game);
}
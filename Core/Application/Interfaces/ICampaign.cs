using Domain.Entities;
using Application.DTO;
namespace Application.Interfaces
{
    public interface ICampaign
    {
        List<Campaign> GetAllCampaigns();
        Campaign GetCampaignById(int id);
            void CreateCampaign(CampaignCreateDTO campaignDTO);
            void UpdateCampaign(int id, CampaignUpdateDTO campaignDTO);

    }
}

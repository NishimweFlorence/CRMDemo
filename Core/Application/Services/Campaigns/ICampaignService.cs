using Domain.Entities;
using Application.DTO;
namespace Application.Services.Campaigns
{
    public interface ICampaignService
    {
         List<Campaign>GetAllCampains();
        Campaign GetCampaignById(int id);

         void CreateCampaign(CampaignCreateDTO campaignDTO);
        void UpdateCampaign(int id, CampaignUpdateDTO campaignDTO);

 
    }
}
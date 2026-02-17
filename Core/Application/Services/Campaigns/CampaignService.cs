using Domain.Entities;
using Application.DTO;
using Application.Interfaces;
namespace Application.Services.Campaigns
{
    public class CampaignService : ICampaignService
    {
        private readonly ICampaign _campaign;
        public CampaignService(ICampaign campaign)
        {
            _campaign = campaign;
        }
        public List<Campaign> GetAllCampains()
        {          
            List<Campaign> campaigns = _campaign.GetAllCampaigns();
            
            return campaigns;
        }  
        public Campaign GetCampaignById(int id)
        {
            return _campaign.GetCampaignById(id);  
    }
       public void CreateCampaign(CampaignCreateDTO campaignDTO)
        {
            _campaign.CreateCampaign(campaignDTO);
        }
        public void UpdateCampaign(int id, CampaignUpdateDTO campaignDTO)
        {
            _campaign.UpdateCampaign(id, campaignDTO);
        }

}}

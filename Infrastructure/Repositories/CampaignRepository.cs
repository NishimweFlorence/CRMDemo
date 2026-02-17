using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
using Application.DTO;


namespace Infrastructure.Repositories
{
    public class CampaignRepository : ICampaign
    {
        private readonly ApplicationDbContext _dBcontext;
        public CampaignRepository(ApplicationDbContext dBcontext)
        {
            _dBcontext = dBcontext;
        }
        public List<Campaign> GetAllCampaigns()
        {
            List<Campaign> campaigns = _dBcontext.Campaigns.ToList();
            return campaigns;
        }
        public Campaign GetCampaignById(int id)
        {
            return _dBcontext.Campaigns.FirstOrDefault(c => c.Id == id);
        }
        public void CreateCampaign(CampaignCreateDTO campaignDTO)
        {
            Campaign campaign = new Campaign
            {
                Name = campaignDTO.Name,
                Description = campaignDTO.Description,
                StartDate = campaignDTO.StartDate,
                EndDate = campaignDTO.EndDate,
                // CreatedAt = DateTime.Now,
                // CreatedById=1 
                
            };
            _dBcontext.Campaigns.Add(campaign);
            _dBcontext.SaveChanges();
        }
        public void UpdateCampaign(int id, CampaignUpdateDTO campaignDTO)
        {
            var campaign = _dBcontext.Campaigns.Find(id);
            if (campaign != null)
            {
                campaign.Name = campaignDTO.Name;
                campaign.Description = campaignDTO.Description;
                campaign.StartDate = campaignDTO.StartDate;
                campaign.EndDate = campaignDTO.EndDate;

                _dBcontext.SaveChanges();
            }
        }
    }
    
}
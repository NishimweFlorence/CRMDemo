using Domain.Entities;
using Application.Interfaces;
using Infrastructure.Data;
using Application.DTO;


namespace Infrastructure.Repositories
{
public class SupportTicketRepository : ISupportTicket
    {
        private readonly ApplicationDbContext _dBcontext;
        public SupportTicketRepository(ApplicationDbContext dBcontext)
        {
        _dBcontext = dBcontext;
        }
        public List<SupportTicket> GetAllSupportTickets()
        {
         List<SupportTicket> supportTickets = _dBcontext.SupportTickets.ToList();
            return supportTickets;
        }
        public SupportTicket GetSupportTicketById(int id)
        {
            return _dBcontext.SupportTickets.FirstOrDefault(c => c.Id == id);
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
        public void UpdateSupportTicket(int id, SupportTicketUpdateDTO supportTicketDTO)
        {
            var supportTicket = _dBcontext.SupportTickets.Find(id);
            if (supportTicket != null)
            {
                supportTicket.category = supportTicketDTO.category;
                supportTicket.status = supportTicketDTO.status;
                supportTicket.Description = supportTicketDTO.Description;

                _dBcontext.SaveChanges();
            }
        }

        public void CreateSupportTicket(SupportTicketCreateDTO SupportTicketDTO)
        {
            throw new NotImplementedException();
        }
    }
    
}
    
using Domain.Entities;  
using Application.DTO;
namespace Application.Interfaces
{
    public interface ISupportTicket
    {
        
         List<SupportTicket> GetAllSupportTickets();
         public SupportTicket GetSupportTicketById(int id);

          void CreateSupportTicket(SupportTicketCreateDTO SupportTicketDTO);
            void UpdateSupportTicket(int id, SupportTicketUpdateDTO supportTicketDTO);

         
    }
}
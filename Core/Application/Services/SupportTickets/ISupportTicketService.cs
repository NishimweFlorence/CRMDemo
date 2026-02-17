
using Domain.Entities;
using Application.Interfaces;
using Application.DTO;

namespace Application.Services.SupportTickets
{
    public interface ISupportTicketService
    {
         List<SupportTicket> GetAllSupportTickets();
        SupportTicket GetSupportTicketById(int id);
        void CreateSupportTicket(SupportTicketCreateDTO supportTicketDTO);
        void UpdateSupportTicket(int id, SupportTicketUpdateDTO supportTicketDTO);
    }
}
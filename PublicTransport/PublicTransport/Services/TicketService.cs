using PublicTransport.Models;
using PublicTransport.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PublicTransport.Services
{
    public class TicketService : BaseService
    {
        public TicketService(IRepositoryWrapper repositoryWrapper)
          : base(repositoryWrapper)
        {
        }
        public List<Ticket> GetTickets()
        {
            return repositoryWrapper.TicketRepository.FindAll().ToList();
        }

        public List<Ticket> GetTicketsByCondition(Expression<Func<Ticket, bool>> expression)
        {
            return repositoryWrapper.TicketRepository.FindByCondition(expression).ToList();
        }

        public void AddTicket(Ticket ticket)
        {
            repositoryWrapper.TicketRepository.Create(ticket);
        }

        public void UpdateTicket(Ticket ticket)
        {
            repositoryWrapper.TicketRepository.Update(ticket);
        }

        public void DeleteTicket(Ticket ticket)
        {
            repositoryWrapper.TicketRepository.Delete(ticket);
        }
    }
}

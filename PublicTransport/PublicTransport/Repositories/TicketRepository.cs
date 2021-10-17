using PublicTransport.Models;

namespace PublicTransport.Repositories
{
    public class TicketRepository : RepositoryBase<Ticket>, ITicketRepository
    {
        public TicketRepository(PublicContext publicContext)
           : base(publicContext)
        {
        }
    }
}

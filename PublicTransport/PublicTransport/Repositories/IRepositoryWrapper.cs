using PublicTransport.Models;
namespace PublicTransport.Repositories
{
    public interface IRepositoryWrapper
    {
        IBusRepository BusRepository { get; }
        ITicketRepository TicketRepository { get; }
        ICardRepository CardRepository { get; }
        IRouteRepository RouteRepository { get; }
        ISubscriptionRepository SubscriptionRepository { get; }
        ITransactionRepository TransactionRepository { get; }
        void Save();
    }
}

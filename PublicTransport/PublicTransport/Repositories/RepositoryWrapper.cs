using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PublicTransport.Models;
namespace PublicTransport.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private PublicContext _publicContext;
        private IBusRepository _busRepository;
        private ICardRepository _cardRepository;
        private ITicketRepository _ticketRepository;
        private IRouteRepository _routeRepository;
        private ISubscriptionRepository _subscriptionRepository;
        private ITransactionRepository _transactionRepository;

        public IBusRepository BusRepository
        {
            get
            {
                if (_busRepository == null)
                {
                    _busRepository = new BusRepository(_publicContext);
                }
                return _busRepository;
            }

        }
        public IRouteRepository RouteRepository
        {
            get
            {
                if (_routeRepository == null)
                {
                    _routeRepository = new RouteRepository(_publicContext);
                }
                return _routeRepository;
            }

        }
        public ICardRepository CardRepository
        {
            get
            {
                if (_cardRepository == null)
                {
                    _cardRepository = new CardRepository(_publicContext);
                }
                return _cardRepository;
            }
        }

        public ITicketRepository TicketRepository
        {
            get
            {
                if (_ticketRepository == null)
                {
                    _ticketRepository = new TicketRepository(_publicContext);
                }
                return _ticketRepository;
            }
        }
        public ISubscriptionRepository SubscriptionRepository
        {
            get
            {
                if (_subscriptionRepository == null)
                {
                    _subscriptionRepository = new SubscriptionRepository(_publicContext);
                }
                return _subscriptionRepository;
            }

        }
        public ITransactionRepository TransactionRepository
        {
            get
            {
                if(_transactionRepository==null)
                {
                    _transactionRepository = new TransactionRepository(_publicContext);
                }
                return _transactionRepository;
            }
        }

        public RepositoryWrapper(PublicContext publicContext)
        {
            _publicContext = publicContext;
        }

        public void Save()
        {
            _publicContext.SaveChanges();
        }
    }
}

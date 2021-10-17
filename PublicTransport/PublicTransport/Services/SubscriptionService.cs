using PublicTransport.Models;
using PublicTransport.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PublicTransport.Services
{
    public class SubscriptionService:BaseService
    {
        public SubscriptionService(IRepositoryWrapper repositoryWrapper)
               : base(repositoryWrapper)
        {
        }

        public List<Subscription> GetSubscriptions()
        {
            return repositoryWrapper.SubscriptionRepository.FindAll().ToList();
        }

        public List<Subscription> GetSubscriptionsByCondition(Expression<Func<Subscription, bool>> expression)
        {
            return repositoryWrapper.SubscriptionRepository.FindByCondition(expression).ToList();
        }

        public void AddSubscription(Subscription subscription )
        {
            repositoryWrapper.SubscriptionRepository.Create(subscription);
        }

        public void UpdateSubscription(Subscription subscription )
        {
            repositoryWrapper.SubscriptionRepository.Update(subscription);
        }

        public void DeleteSubscription(Subscription subscription)
        {
            repositoryWrapper.SubscriptionRepository.Delete(subscription);
        }
    }
}

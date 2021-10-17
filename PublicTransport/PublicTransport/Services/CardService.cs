using PublicTransport.Models;
using PublicTransport.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PublicTransport.Services
{
    public class CardService : BaseService
    {
        public CardService(IRepositoryWrapper repositoryWrapper)
            : base(repositoryWrapper)
        {
        }
        public List<Card> GetCards()
        {
            return repositoryWrapper.CardRepository.FindAll().ToList();
        }

        public List<Card> GetCardsByCondition(Expression<Func<Card, bool>> expression)
        {
            return repositoryWrapper.CardRepository.FindByCondition(expression).ToList();
        }

        public void AddCard(Card card)
        {
            repositoryWrapper.CardRepository.Create(card);
        }

        public void UpdateCard(Card card)
        {
            repositoryWrapper.CardRepository.Update(card);
        }

        public void DeleteCard(Card card)
        {
            repositoryWrapper.CardRepository.Delete(card);
        }
    }
}

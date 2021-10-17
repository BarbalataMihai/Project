using PublicTransport.Models;

namespace PublicTransport.Repositories
{
    public class CardRepository : RepositoryBase<Card>, ICardRepository
    {
        public CardRepository(PublicContext publicContext)
         : base(publicContext)
        {
        }
    }
}

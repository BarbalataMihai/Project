
using PublicTransport.Models;
namespace PublicTransport.Repositories
{
    public class BusRepository : RepositoryBase<Bus>, IBusRepository
    {
        public BusRepository(PublicContext publicContext)
         : base(publicContext)
        {

        }
    }
}

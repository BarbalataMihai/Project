using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PublicTransport.Models;

namespace PublicTransport.Repositories
{
    public class TransactionRepository : RepositoryBase<Transaction_history>, ITransactionRepository
    { public TransactionRepository(PublicContext publicContext)
         : base(publicContext)
        {

        }
    }
}

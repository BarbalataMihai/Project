using PublicTransport.Models;
using PublicTransport.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PublicTransport.Services
{
    public class TransactionService:BaseService
    {
        public TransactionService(IRepositoryWrapper repositoryWrapper)
               : base(repositoryWrapper)
        {
        }

        public List<Transaction_history> GetTransactions()
        {
            return repositoryWrapper.TransactionRepository.FindAll().ToList();
        }

        public List<Transaction_history> GetTransactionsByCondition(Expression<Func<Transaction_history, bool>> expression)
        {
            return repositoryWrapper.TransactionRepository.FindByCondition(expression).ToList();
        }

        public void AddTransaction(Transaction_history transaction_history)
        {
            repositoryWrapper.TransactionRepository.Create(transaction_history);
        }

        public void UpdateTransaction(Transaction_history transaction_history)
        {
            repositoryWrapper.TransactionRepository.Update(transaction_history);
        }

        public void DeleteTransaction(Transaction_history transaction_history)
        {
            repositoryWrapper.TransactionRepository.Delete(transaction_history);
        }
    }
}

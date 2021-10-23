using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Domain.Interfaces
{
    interface ITransactionRepository : IDisposable
    {
        IEnumerable<Transaction> GetTransactions();
        Transaction GetTransaction(int id);
        void Create(Transaction item);
        void Update(Transaction item);
        void Delete(int id);
        void Save();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Domain.Interfaces
{
    public interface ITransactionRepository : IDisposable
    {
        IEnumerable<Domain.Core.Transaction> GetTransactions();
        Domain.Core.Transaction GetTransaction(int id);
        void Create(Domain.Core.Transaction item);
        void Update(Domain.Core.Transaction item);
        void Delete(int id);
        void Save();
    }
}

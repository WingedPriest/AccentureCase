using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IDebitCardTransactionsRepository : IDisposable
    {
        IEnumerable<DebitCardTransactions> GetDebitCardTransactions();
        DebitCardTransactions GetDebitCardTransactions(int id);
        void Create(DebitCardTransactions item);
        void Update(DebitCardTransactions item);
        void Delete(int id);
        void Save();
    }
}

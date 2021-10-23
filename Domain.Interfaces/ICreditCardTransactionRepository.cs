using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    interface ICreditCardTransactionRepository : IDisposable
    {
        IEnumerable<CreditCardTransaction> GetCreditCardTransactions();
        CreditCardTransaction GetCreditCardTransaction(int id);
        void Create(CreditCardTransaction item);
        void Update(CreditCardTransaction item);
        void Delete(int id);
        void Save();
    }
}

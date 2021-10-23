using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface ICreditCardRepository : IDisposable
    {
        IEnumerable<CreditCard> GetCreditCards();
        CreditCard GetCreditCard(int id);
        void Create(CreditCard item);
        void Update(CreditCard item);
        void Delete(int id);
        void Save();
    }
}

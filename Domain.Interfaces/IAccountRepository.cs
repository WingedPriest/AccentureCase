using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IAccountRepository : IDisposable
    {
        IEnumerable<Account> GetAccounts();
        Account GetAccount(int id);
        void Create(Account item);
        void Update(Account item);
        void Delete(int id);
        void Save();
    }
}

using Domain.Core;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data
{
    public class AccountRepository : IAccountRepository
    {
        private DBContextAccenture _db;
        public AccountRepository()
        {
            _db = new DBContextAccenture();
        }
        public void Create(Account item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        private bool _disposed;
        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            this._disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Account GetAccount(int id)
        {
            return _db.Accounts.Find(id);
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _db.Accounts.ToList();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Account item)
        {
            throw new NotImplementedException();
        }
    }
}

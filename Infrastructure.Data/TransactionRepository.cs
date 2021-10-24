using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace Infrastructure.Data
{
    public class TransactionRepository : ITransactionRepository
    {
        private DBContextAccenture _db;
        public TransactionRepository()
        {
            _db = new DBContextAccenture();
        }
        public void Create(Transaction item)
        {
            throw new NotImplementedException();
        }

        public void Create(Domain.Core.Transaction item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Domain.Core.Transaction GetTransaction(int id)
        {
            return _db.Transactions.Find(id);
        }

        public IEnumerable<Domain.Core.Transaction> GetTransactions()
        {
            return _db.Transactions.ToList();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }


        public void Update(Domain.Core.Transaction item)
        {
            throw new NotImplementedException();
        }
    }
}

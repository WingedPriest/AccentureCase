using Domain.Core;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data
{
    public class ClientRepository : IClientRepository
    {
        private DBContextAccenture _db;
        public ClientRepository()
        {
            _db = new DBContextAccenture();
        }
        public void Create(Client item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Client GetClient(int id)
        {
            return _db.Clients.Find(id);
        }

        public IEnumerable<Client> GetClients()
        {
            return _db.Clients.ToList();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Client item)
        {
            _db.Entry(item).State = EntityState.Modified;
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
    }
}

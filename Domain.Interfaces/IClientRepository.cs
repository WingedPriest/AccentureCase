using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IClientRepository : IDisposable
    {
        IEnumerable<Client> GetClients();
        Client GetClient(int id);
        void Create(Client item);
        void Update(Client item);
        void Delete(int id);
        void Save();
    }
}

using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    interface IAddressRepository : IDisposable
    {
        IEnumerable<Address> GetAddresses();
        Address GetAddress(int id);
        void Create(Address item);
        void Update(Address item);
        void Delete(int id);
        void Save();
    }
}

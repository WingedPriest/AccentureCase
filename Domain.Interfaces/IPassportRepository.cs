using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IPassportRepository : IDisposable
    {
        IEnumerable<Passport> GetPassports();
        Passport GetPassport(int id);
        void Create(Passport item);
        void Update(Passport item);
        void Delete(int id);
        void Save();
    }
}

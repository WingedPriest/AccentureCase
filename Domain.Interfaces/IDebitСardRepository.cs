using Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    interface IDebitСardRepository : IDisposable
    {
        IEnumerable<DebitСard> GetDebitСards();
        DebitСard GetDebitСard(int id);
        void Create(DebitСard item);
        void Update(DebitСard item);
        void Delete(int id);
        void Save();
    }
}

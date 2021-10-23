using Domain.Core.BranchEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IBranchStatisticsRepository : IDisposable
    {
        IEnumerable<BranchStatistics> GetBranchStatisticses();
        BranchStatistics GetBranchStatistics(int id);
        void Create(BranchStatistics item);
        void Update(BranchStatistics item);
        void Delete(int id);
        void Save();
    }
}

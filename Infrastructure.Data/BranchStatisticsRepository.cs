using Domain.Core.BranchEntities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data
{
    public class BranchStatisticsRepository : IBranchStatisticsRepository
    {
        private DBContextAccenture _db;
        public BranchStatisticsRepository()
        {
            _db = new DBContextAccenture();
        }
        public void Create(BranchStatistics item)
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

        public IEnumerable<BranchStatistics> GetBranchStatisticses()
        {
            return _db.BranchStatistics.ToList();
        }

        public BranchStatistics GetBranchStatistics(int id)
        {
            return _db.BranchStatistics.Find(id);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(BranchStatistics item)
        {
            throw new NotImplementedException();
        }
    }
}

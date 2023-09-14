using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SongRecordStore.CORE.Interfaces;
using SongRecordStore.CORE.Models;

namespace SongRecordStore.DAL
{
    public class MockRecordRepository : IRecordRepository
    {
        private List<SongRecord> _songRecords;

        public MockRecordRepository()
        {
            _songRecords = new List<SongRecord>();
        }

        public Result<SongRecord> Create(SongRecord songRecord)
        {
            throw new NotImplementedException();
        }

        public Result<List<SongRecord>> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Result Update(SongRecord songRecord)
        {
            throw new NotImplementedException();
        }

        public Result Delete(string name)
        {
            throw new NotImplementedException();
        }
    }
}

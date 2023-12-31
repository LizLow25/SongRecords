﻿using System;
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
            _songRecords.Add(songRecord);
            return new Result<SongRecord> { Data = songRecord, Success = true };
        }

        public Result<List<SongRecord>> ReadAll()
        {
            return new Result<List<SongRecord>> { Data = _songRecords, Success = true };
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

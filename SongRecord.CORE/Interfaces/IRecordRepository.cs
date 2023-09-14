using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SongRecordStore.CORE.Models;

namespace SongRecordStore.CORE.Interfaces
{
    public interface IRecordRepository
    {
        public Result<SongRecord> Create(SongRecord songRecord);
        public Result<List<SongRecord>> ReadAll();
        public Result Update(SongRecord songRecord);
        public Result Delete(string name);
    }
}

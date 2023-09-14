using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SongRecordStore.CORE.Models;

namespace SongRecordStore.CORE.Interfaces
{
    public interface IRecordService
    {
        public Result<SongRecord> Get(string songName);

        public Result<SongRecord> Add(SongRecord songrecord);



    }
}

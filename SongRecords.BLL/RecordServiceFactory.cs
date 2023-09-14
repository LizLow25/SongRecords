using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SongRecordStore.CORE.Enums;
using SongRecordStore.CORE.Interfaces;
using SongRecordStore.DAL;

namespace SongRecordStore.BLL
{
    public class RecordServiceFactory 
    {
        public static IRecordService GetRecordService(ApplicationMode mode)
        {
            switch (mode)
            {
                case ApplicationMode.LIVE:
                    return new RecordService(new FileRecordRepository("./Data.txt"));
                //break;
                case ApplicationMode.TEST:
                    return new RecordService(new MockRecordRepository());
                //break;
                default:
                    throw new NotImplementedException();
            }

        }
    }
}

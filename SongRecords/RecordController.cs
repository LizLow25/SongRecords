using SongRecordStore.CORE.Interfaces;
using SongRecordStore.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongRecordStore
{
    public class RecordController
    {
        private IRecordService _service;
        private ConsoleIO _io;
        public RecordController(ConsoleIO io, IRecordService service)
        {
            this._io = io;
            this._service = service;
        }
        public void Run()
        { 
        }
    }
}

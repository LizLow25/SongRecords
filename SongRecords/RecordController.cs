using SongRecordStore.CORE.Interfaces;
using SongRecordStore.CORE.Models;
using SongRecordStore.UI;
using System;
using System.Collections.Generic;
using System.Data;
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
            bool keepRunning = true;
            while (keepRunning)
            {
                int choice = _io.PromptInt("1. Load a Record\r\n" +
                    "2. View Records By Type of Music\r\n" +
                    "3. View Records By Album\r\n\" +" +
                    "4. Add Record\r\n" +
                    "5. Edit Record\r\n" +
                    "6. Delete Record\r\n" +
                    "7. Quit\r\n", 1, 6);
                switch (choice)
                {
                    case 1:
                        LoadRecord();
                        break;
                    case 2:
                        ViewRecordsByTypeOfMusic();
                        break;
                    case 3:
                        ViewRecordByAlbum();
                        break;
                    case 4:
                        AddRecord();
                        break;
                    case 5:
                        EditRecord();
                        break;
                    case 6:
                        DeleteRecord();
                        break;
                    case 7:
                        //Quit();
                        keepRunning = false;
                        break;
                    default:
                        _io.Display("Contact I.T");
                        break;
                }
            }
        }
        void LoadRecord()
        {
            string songName = _io.Prompt("Please the name of the song: (At least 2 character)");
            Result<SongRecord> result = _service.Get(songName);
            if (result.Success)
            {
                //_io.DisplaySongRecord(result.Data);
            }
            else
            {
                _io.Display(result.Message);
            }
        }
        void ViewRecordsByTypeOfMusic()
        {
            throw new NotImplementedException();
        }

        void ViewRecordByAlbum()
        {
            throw new NotImplementedException();
        }
        void AddRecord()
        {
            SongRecord record = _io.PromptNewSongRecord("===New Song Record====");
            Result<SongRecord> result = _service.Add(record);
            if (result.Success)
            {
                _io.Display("Song Record Saved!");
            }
            else
            {
                _io.Display(result.Message);
            }
        }
        void EditRecord()
        {
            throw new NotImplementedException();
        }

        void DeleteRecord()
        {
            throw new NotImplementedException();
        }
    }
}

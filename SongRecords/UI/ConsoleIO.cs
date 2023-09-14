using SongRecordStore.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SongRecordStore.CORE.Enums;

namespace SongRecordStore.UI
{
    public class ConsoleIO
    {
        public  void Display(string message) {} 
		public string Prompt(string message) { throw new NotImplementedException();  } 
		public int PromptInt(string message, int min, int max) { throw new NotImplementedException(); }
        public  DateTime PromptDateTime(string message) { throw new NotImplementedException(); }
        public decimal PromptDecimal(string message, decimal min, decimal max) { throw new NotImplementedException(); }
        public SongRecord PromptNewSongRecord(string message) { throw new NotImplementedException(); }
        public SongRecord PromptEditSongRecord(SongRecord record) { throw new NotImplementedException(); }
        public  ApplicationMode PromptApplicationMode(string message) 
        {
            return (ApplicationMode)(PromptInt(message, 1, 2) - 1);
        } 
    }
}

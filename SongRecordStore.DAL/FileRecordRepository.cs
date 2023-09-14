using SongRecordStore.CORE.Interfaces;
using SongRecordStore.CORE.Models;
using System.Data;

namespace SongRecordStore.DAL
{
    public class FileRecordRepository : IRecordRepository
    {
        private string _fileName;
        public FileRecordRepository(string fileName)
        {
            _fileName = fileName;
        }
        public Result<SongRecord> Create(SongRecord songRecord)
        {
            throw new NotImplementedException();
        }

        public Result<List<SongRecord>> ReadAll()
        {
            Result<List<SongRecord>> result = new Result<List<SongRecord>>();
            result.Data = new List<SongRecord>();
            // Reading from a file
            //Console.WriteLine("======Read All=======");
            if (!File.Exists(_fileName))
            {
                //Console.WriteLine("======Not Exist=======");
                result.Success = false;
                return result;
            }
            //Console.WriteLine("======File Exist=======");
            using (StreamReader sr = new StreamReader(_fileName))
            {
                string line = sr.ReadLine();
                SongRecord SongRecord;
                while (line != null)
                {
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    SongRecord = SongRecordMapper.MapToObject(line);
                    result.Data.Add(SongRecord);
                    line = sr.ReadLine();
                }
                result.Success = true;
                return result;
            }
        }

        public Result  Update(SongRecord songRecord)
        {
            throw new NotImplementedException();
        }

        public Result Delete(string name)
        {
            throw new NotImplementedException();
        }

    }

    
}
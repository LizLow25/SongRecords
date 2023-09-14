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
            if (!File.Exists(_fileName))
            {
                File.Create(_fileName).Close();
            }

            List<SongRecord> songrecords = new List<SongRecord>();

            using (StreamReader sr = new StreamReader(_fileName))
            {
                string line = sr.ReadLine();

                SongRecord record;

                while (line != null)
                {
                    record = SongRecordMapper.MapToObject(line);

                    songrecords.Add(record);

                    line = sr.ReadLine();
                }
            }

            using (StreamWriter sw = new StreamWriter(_fileName))
            {
                foreach (SongRecord record in songrecords)
                {
                    sw.WriteLine(SongRecordMapper.MapToString(record));
                }
                sw.WriteLine(SongRecordMapper.MapToString(songRecord));
            }

            return new Result<SongRecord> { Data = songRecord, Success = true };
        }

        public Result<List<SongRecord>> ReadAll()
        {
            throw new NotImplementedException();
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
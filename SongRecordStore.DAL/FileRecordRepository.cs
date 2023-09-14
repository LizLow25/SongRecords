using SongRecordStore.CORE.Models;
using System.Data;

namespace SongRecordStore.DAL
{
    public class FileRecordRepository
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
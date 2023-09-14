using SongRecordStore.CORE.Interfaces;
using SongRecordStore.CORE.Models;
using System.Data;

namespace SongRecordStore.BLL
{
    public class RecordService : IRecordService

    {
        private readonly IRecordRepository _repo;

        public RecordService(IRecordRepository repo)
        {
            this.repo = repo;
        }

        public Result<SongRecord> Get(string songName)
        {
            Result<SongRecord> result = new Result<SongRecord>();
            Result<List<SongRecord>> recordResult = _repo.ReadAll();
            if (!recordResult.Success)
            {
                result.Message = recordResult.Message;
                return result;
            }
            foreach (SongRecord record in recordResult.Data)
            {
                if (record.Name == songName)
                {
                    result.Data = record;
                    result.Success = true;
                    return result;
                }
            }
            result.Message = $"No song record found for {songName}";
            return result;
        }
    }
}
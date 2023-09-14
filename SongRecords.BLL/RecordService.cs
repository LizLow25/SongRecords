using SongRecordStore.CORE.Interfaces;
using SongRecordStore.CORE.Models;
using System.Data;

namespace SongRecordStore.BLL
{
    public class RecordService : IRecordService

    {
        private readonly IRecordRepository repo;

        public RecordService(IRecordRepository repo)
        {
            this.repo = repo;
        }

        public Result<SongRecord> Get(string songName)
        {
            Result<SongRecord> result = new Result<SongRecord>();
            Result<List<SongRecord>> recordResult = repo.ReadAll();
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


        public Result<SongRecord> Add(SongRecord songrecord)
        {
            Result<SongRecord> result = new Result<SongRecord>();

            //validation
            if (songrecord.Name.Length < 2)
            {
                result.Message = "Name must be longer than 2 characters";
                result.Success = false;
                return result;
            }
            else if (songrecord.Artist.Length < 2)
            {
                result.Message = "Artist must be longer than 2 characters";
                result.Success = false;
                return result;
            }
            else if (songrecord.Album.Length < 2)
            {
                result.Message = "Album must be longer than 2 characters";
                result.Success = false;
                return result;
            }
            else if (songrecord.TrackNumber < 1 || songrecord.TrackNumber > 50)
            {
                result.Message = "Tracknumber must be between 1 and 50";
                result.Success = false;
                return result;
            }

            result = repo.Create(songrecord);
            return result;
        }

    }
}
using SongRecordStore.CORE.Interfaces;

namespace SongRecordStore.BLL
{
    public class RecordService : IRecordService

    {
        private readonly IRecordRepository repo;

        public RecordService(IRecordRepository repo)
        {
            this.repo = repo;
        }

    }
}
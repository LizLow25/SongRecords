using SongRecordStore.BLL;
using SongRecordStore.CORE.Interfaces;
using SongRecordStore.UI;

namespace SongRecordStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleIO io = new ConsoleIO();
            IRecordService service = RecordServiceFactory.GetRecordService(io.PromptApplicationMode("1.Live, 2.Test"));

            RecordController controller = new RecordController(io, service);

            controller.Run();
        }
    }
}
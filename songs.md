Menu
1. Load a Record
2. View Records By Type of Music
3. Add Record
4. Edit Record
5. Delete Record
6. Quit
Enter Choice:
```
SongRecords.UI
	+ Program
		+ Main(string [] args) : void
	+ RecordController
		- _service : IRecordService
		- _io : ConsoleIO
		+ RecordController(ConsoleIO io, IRecordService service)
		+ Run() : void
	+ ConsoleIO
		+ Display(string message) : void
		+ Prompt(string message) : string
		+ PromptInt(string message, int min, int max) : int
		+ PromptDecimal(string message, decimal min, decimal max) : decimal
		+ PromptNewSongRecord(string message) : SongRecord
		+ PromptEditSongRecord(SongRecord record) : SongRecord
		+ PromptApplicationMode(string message) : ApplicationMode
SongRecords.BLL
	+ RecordServiceFactory
		+* GetRecordService(ApplicationMode mode) : IRecordService // LIVE OR TEST
	+ RecordService : IRecordService
		- _repo : IRecordRepositoy
		+ RecordService(IRecordRepository repo)
SongRecords.DAL
	+ FileRecordRepository : IRecordRepository // use for file-io(csv) data storage
		- _fileName : string
		+ FileRecordRepository(string fileName)
	+ MockRecordRepository : IRecordRepository // use for In-Memory data storage Great for testing
		- _soneRecords : List<SongRecord>
		+ MockRecordRepository()
SongRecords.CORE
	> Models
		+ Result
			+ Success: bool {g/s}
			+ Message : string {g/s}
		+ Result<T> : Result
			+ SongRecord : T {g/s}
		+ SongRecord
			+ Name : string {g/s}
			+ Artist : string {g/s}
			+ Album : string {g/s}
			+ Duration : decimal {g/s}
			+ Year : int {g/s}
			+ TypeOfMusic : string {g/s}

	> Enums
		+ ApplicationMode [Enum LIVE|TEST]
	> Interfaces
		+ IRecordRepository
		//CRUD
			+ Create(SongRecord songRecord) : Result<SongRecord>
			+ ReadAll(): Result<List<SongRecord>>
			+ Update(SongRecord songRecord): Result
			+ Delete(sting name): Result
		+ IRecordService
			+ LoadRange(int startYear, int endYear) : Result<List<SongRecord>>
			+ LoadTypeOfMusic(string typeOfMusic) : Result<List<SongRecord>>
			+ Get(string name) : Result<SongRecord>
			+ Add(SongRecord songRecord): Result<SongRecord> // will do validation
			+ Remove(string name) : Result
			+ Edit(SongRecord songRecord): Result

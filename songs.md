Menu
1. Load a Record
2. View Records By Type of Music
3. View Records By Album
4. Add Record
5. Edit Record
6. Delete Record
7. Quit
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
		+ PromptDateTime(string message) : DateTime
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
			+ TrackNumber : int {g/s}
			+ Duration : decimal {g/s}
			+ ReleaseDate : DateTime {g/s}
			+ TypeOfMusic : MusicType {g/s}
	> Enums
		+ ApplicationMode [Enum LIVE|TEST]
		+ MusicType [Enum CLASSICAL|POP|ROCK|JAZZ|HIPHOP|R&B]
	> Interfaces
		+ IRecordRepository
		//CRUD
			+ Create(SongRecord songRecord) : Result<SongRecord>
			+ ReadAll(): Result<List<SongRecord>>
			+ Update(SongRecord songRecord): Result
			+ Delete(sting name): Result
		+ IRecordService
			+ LoadTypeOfMusic(string typeOfMusic) : Result<List<SongRecord>>
			+ LoadSongsOfAlbum(string album) : Result<List<SongRecord>>
			+ Get(string name) : Result<SongRecord>
			+ Add(SongRecord songRecord): Result<SongRecord>
				//Validation
					//Name : Length >=2
					//Artist : Length >=2
					//Album : : Length >=2
					//TrackNumber : between 1 and 50
					//Duration : between 0 and 100
					//ReleaseDate between 1500 and DateTime.Now
					//TypeOfMusic : MusicType
			+ Remove(string name) : Result
			+ Edit(SongRecord songRecord): Result





JW


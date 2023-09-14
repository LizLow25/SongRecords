using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SongRecordStore.CORE.Enums;
using SongRecordStore.CORE.Models;

namespace SongRecordStore.DAL
{
    public class SongRecordMapper
    {
        public static SongRecord MapToObject(string row)
        {
            string[] fields = row.Split(',');

            SongRecord songRecord = new SongRecord();

            songRecord.Name = fields[0];
            songRecord.Artist = fields[1];
            songRecord.Album = fields[2];
            songRecord.TrackNumber = int.Parse(fields[3]);
            songRecord.Duration = decimal.Parse(fields[4]);
            songRecord.ReleaseDate = DateTime.ParseExact(fields[5], "MMddyyyy", new CultureInfo("en-US"), DateTimeStyles.None);
            songRecord.TypeOfMusic = (MusicType)int.Parse(fields[6]);

            return songRecord;
        }



        public static string MapToString(SongRecord songRecord)
        {
            return $"{songRecord.Name},{songRecord.Artist},{songRecord.Album},{songRecord.TrackNumber},{songRecord.Duration},{songRecord.ReleaseDate.ToString("MMddyyyy")},{songRecord.TypeOfMusic}";
        }    
    }
}

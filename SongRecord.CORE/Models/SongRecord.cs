using SongRecordStore.CORE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongRecordStore.CORE.Models
{
    public class SongRecord
    {
        public SongRecord() { }
        public SongRecord(string name, string artist, string album, int trackNumber, decimal duration, DateTime releaseDate, MusicType typeOfMusic) 
        {
            Name = name;
            Artist = artist;
            Album = album;
            TrackNumber = trackNumber;
            Duration = duration;
            ReleaseDate = releaseDate;
            TypeOfMusic = typeOfMusic;
        }

        public string Name    {get;set;}
		public string Artist    {get;set;}
		public string Album    {get;set;}
		public int TrackNumber    { get;set;}
		public decimal Duration    { get;set;}
		public DateTime ReleaseDate   { get;set;}
		public MusicType TypeOfMusic    { get;set;}	
    }
}

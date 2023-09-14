using SongRecordStore.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SongRecordStore.CORE.Enums;
using System.Data;

namespace SongRecordStore.UI
{
    public class ConsoleIO
    {
        public  void Display(string message)
        {
            Console.WriteLine(message);
        } 
		public string Prompt(string message) {

            Console.WriteLine(message);

            return Console.ReadLine();
        } 
		public int PromptInt(string message, int min, int max)
        {

            int number;

            while (true)
            {
                Console.WriteLine(message);


                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number >= min && number <= max)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter a number between {min} and {max}");
                    }
                }
                else
                {
                    Console.WriteLine("That was not a number!");
                }
            }
        }
        public  DateTime PromptDateTime(string message)
        {
            DateTime dt;

            while (true)
            {
                Console.WriteLine(message);


                if (DateTime.TryParse(Console.ReadLine(), out dt))
                {
                    return dt;
                }
                else
                {
                    Console.WriteLine("That was not a date!");
                }
            }
        }
        public decimal PromptDecimal(string message, decimal min, decimal max)
        {
            decimal number;

            while (true)
            {
                Console.WriteLine(message);


                if (decimal.TryParse(Console.ReadLine(), out number))
                {
                    if (number >= min && number <= max)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter a number between {min} and {max}");
                    }
                }
                else
                {
                    Console.WriteLine("That was not a number!");
                }
            }
        }
        public SongRecord PromptNewSongRecord(string message)
        {
            Console.WriteLine(message);
            SongRecord sr = new SongRecord();

            sr.Name = Prompt("Please enter the name of the song");
            sr.Artist = Prompt("Please enter the name of the artist");
            sr.Album = Prompt("Please enter the name of the album");
            sr.TrackNumber = PromptInt("Please enter the track number", 1, 30);
            sr.Duration = PromptDecimal("Please enter the song duration", 0, 100);
            sr.ReleaseDate = PromptDateTime("Please enter the release date");
            sr.TypeOfMusic = PromptMusicType("Please pick music genre\n1. Classical\n2.Pop\n3.Rock\n4.Jazz\n5.Hiphop\n6.R&B");
            
            return sr;
        }

        public SongRecord PromptEditSongRecord(SongRecord record)
        {
            record.Name = Prompt("Please update the name of the song");
            record.Artist = Prompt("Please update the name of the artist");
            record.Album = Prompt("Please update the name of the album");
            record.TrackNumber = PromptInt("Please update the track number", 1, 30);
            record.Duration = PromptDecimal("Please update the song duration", 0, 100);
            record.ReleaseDate = PromptDateTime("Please update the release date");
            record.TypeOfMusic = PromptMusicType("Please update the music genre\n1. Classical\n2.Pop\n3.Rock\n4.Jazz\n5.Hiphop\n6.R&B");

            return record;
        }

        public MusicType PromptMusicType(string message)
        {
            return (MusicType)(PromptInt(message, 1, 6) - 1);
        }
        public  ApplicationMode PromptApplicationMode(string message) 
        {
            return (ApplicationMode)(PromptInt(message, 1, 2) - 1);
        } 

        public void DisplaySongRecord(SongRecord record)
        {
            Display("=============Song Record================");
            Display($"Name: {record.Name}");
            Display($"Artist: {record.Artist}");
            Display($"Album: {record.Album}");
            Display($"Track Number: {record.TrackNumber}");
            Display($"Duration: {record.Duration.ToString("F2")}");
            Display($"Release Date: {record.ReleaseDate.ToShortDateString()}");
            Display($"Type Of Music: {record.TypeOfMusic.ToString()}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using P04_Radio_Database.Exceptions;

namespace P04_Radio_Database
{
    public class Song
    {
        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;



        public string ArtistName
        {
            get => this.artistName;
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }
                this.artistName = value;
            }
        }

        public string SongName
        {
            get => this.songName;
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongLengthException();
                }

                this.songName = value;
            }
        }

        public int Minutes
        {
            get => this.minutes;
            set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }

                this.minutes = value;
            }
        }

        public int Seconds
        {
            get => this.seconds;
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }

                this.seconds = value;
            }
        }

        public Song(string ArtistName, string SongName, int Minutes, int Seconds)
        {
            this.artistName = ArtistName;
            this.songName = SongName;
            this.minutes = Minutes;
            this.seconds = Seconds;
        }
    }
}

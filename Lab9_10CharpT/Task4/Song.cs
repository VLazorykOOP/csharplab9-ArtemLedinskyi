using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT.Task4
{
    internal class Song
    {
        public string Title { get; set; }   
        public string Artist { get; set; }  
        public double Duration { get; set; }
        public Song(string title, string artist, double duration)
        {

            Title = title;
            Artist = artist;
            Duration = duration;

        }

        public override string ToString()
        {
            return $"{Title} by {Artist},{Duration} mins";
        }
    }
}

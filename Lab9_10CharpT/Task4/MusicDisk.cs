using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT.Task4
{
    internal class MusicDisk
    {
        public string DiskName { get; set; }
        public Hashtable Songs { get;private set; }

        public MusicDisk(string name)
        {

            DiskName = name;
            Songs = new Hashtable();

        }

        public void AddSong(Song song)
        {
            if (!Songs.ContainsKey(song.Title))
            {
                Songs.Add(song.Title, song);
            }
        }
        public void RemoveSong(string title)
        {
            if (Songs.ContainsKey(title))
            {
                Songs.Remove(title);
            }
        }
        public void DisplaySongs()
        {
            Console.WriteLine($"Songs on {DiskName}: ");
            foreach (DictionaryEntry song in Songs)
            {
                Console.WriteLine(song.Value);
            }
        }


    }
}

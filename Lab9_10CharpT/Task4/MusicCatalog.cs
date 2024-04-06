using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT.Task4
{
    internal class MusicCatalog
    {
        private Hashtable Disks {  get; set; }  

        public MusicCatalog()
        {
        Disks = new Hashtable();

        }
        public void AddDisk(MusicDisk disk)
        {

            if(!Disks.ContainsKey(disk.DiskName))
            {
                Disks.Add(disk.DiskName, disk);
            }

        }

        public void RemoveDisk(string name)
        {
            if (Disks.ContainsKey(name))
            {
                Disks.Remove(name);
            }
        }

        public void DisplayCatalog()
        {
            Console.WriteLine("Music Catalog: ");
            foreach(DictionaryEntry disk in Disks)
            {
                ((MusicDisk)disk.Value).DisplaySongs();
            }
        }


        public void FindSongsByArtist(string artist)
        {
            Console.WriteLine($"Song by {artist}: ");
            foreach(DictionaryEntry diskEntry in Disks)
            {
                MusicDisk disk= (MusicDisk)diskEntry.Value;
                foreach(DictionaryEntry songEntry in disk.Songs)
                {
                    Song song = (Song)songEntry.Value;
                    if (song.Artist.ToLower() == artist.ToLower())
                    {
                        Console.WriteLine (song);
                    }
                }
            }
        }

    }
}

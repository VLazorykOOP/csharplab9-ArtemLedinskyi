using Lab9_10CharpT.Task3;
using Lab9_10CharpT.Task4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                   Task1 task1 = new Task1();
                    Console.WriteLine(task1.task("abc#d##c"));
                    break;  
                case 2:
                    string filePath = "C:\\Users\\Artem\\source\\repos\\csharplab9-ArtemLedinskyi\\Test.txt";
                    StudentProcessor processor = new StudentProcessor();
                    processor.ProccessStudents(filePath);
                    break;

                case 3:
                    string filePath1 = "C:\\Users\\Artem\\source\\repos\\csharplab9-ArtemLedinskyi\\Test.txt";
                    StudentProcessor1 processor1 = new StudentProcessor1();
                    processor1.ProcessStudents1(filePath1);


                    Task3forTask1 task3ForTask1 = new Task3forTask1();
                    Console.WriteLine(task3ForTask1.task("abc#d##c"));
                    break;
                case 4:
                    MusicCatalog catalog = new MusicCatalog();

                    MusicDisk disk1 = new MusicDisk("Greatest Hits");
                    disk1.AddSong(new Song("Song One", "Artist One", 3.5));
                    disk1.AddSong(new Song("Song Two", "Artist Two", 4.0));

                    MusicDisk disk2 = new MusicDisk("Summer Vibes");
                    disk2.AddSong(new Song("Beach Party", "Artist One", 3.8));
                    disk2.AddSong(new Song("Summer Nights", "Artist Three", 4.5));

                    catalog.AddDisk(disk1);
                    catalog.AddDisk(disk2);

                    catalog.DisplayCatalog();

                    Console.WriteLine();
                    catalog.FindSongsByArtist("Artist One");

                    catalog.RemoveDisk("Greatest Hits");

                    Console.WriteLine();
                    catalog.DisplayCatalog();
                    break;
            }
            
            
        }
    }
}
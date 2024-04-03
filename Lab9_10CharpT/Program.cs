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
            }
            
            
        }
    }
}
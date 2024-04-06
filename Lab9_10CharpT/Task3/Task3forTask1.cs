using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT.Task3
{
    internal class Task3forTask1
    {
        public string task(string text)
        {
            ArrayList characters= new ArrayList();

            foreach(char c in text)
            {
                if (c != '#')
                {
                    characters.Add(c);
                }
                else if(characters.Count>0)
                {
                    characters.RemoveAt(characters.Count-1);
                }

            }
            return new string((char[])characters.ToArray(typeof(char)));
        }
    }
}

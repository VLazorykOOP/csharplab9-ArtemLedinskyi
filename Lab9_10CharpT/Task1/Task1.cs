using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    internal class Task1
    {
        public string task(string text)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in text)
            {
                if (c != '#')
                {
                    stack.Push(c);
                }
                else if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }

            return string.Join("", stack.Reverse());
        }
    }
}

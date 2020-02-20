using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = {"FRYU","TGJK","TGKUT" };
            var actions = new List();
            foreach (string str in strings)
            {
                actions.Add(() => { Console.WriteLine(str); });
                foreach (var action in actions)
                    action();
            }
            
         }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInvestigation
{
    internal class GarbageCollectionInvestigation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Garbage Collection Investigation");

            for (int i=0; i<10000; i++)
            {
                Message m = new Message($"M{i}", $"This is message {i}");
                Console.WriteLine(Message.Count);
            }

        }
    }
}

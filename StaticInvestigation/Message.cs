using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInvestigation
{
    internal class Message
    {
        public static int Count = 0;
        public string Title { get; set; }
        public string Text { get; set; }

        public string[] filler = new string[10000];

        public Message(string title, 
                        string text)
        {
            Count++;
            Title = title;
            Text = text;
        }
        ~Message()
        {
            Console.WriteLine($"Destructor called: {Count}");
            Count--;
        }
    }
}

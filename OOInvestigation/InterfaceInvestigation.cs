using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOInvestigation
{
    internal class InterfaceInvestigation
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Interface Investigation");
            //ITeacher t = new Trainer("John", "Jones", "E222");
            //t.Teach();

            //Tutor tut = new Tutor("Karen", "Keane", "CPL");

            //tut.Teach();

            ITeacher[] teachers =
            {
                new Trainer("John", "Jones", "E222"),
                new Tutor("Karen", "Keane", "CPL"),
                new Tutor("Lynn", "Lawrence", "CPL"),
                new Trainer("Mary", "Martin", "E333")
            };

            foreach(ITeacher t in teachers)
            {
                t.Teach();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSDesktop
{
    internal class Request
    {
        public string q { get; set; }
        public string c { get; set; }

        public Request(string q, string c)
        {
            this.q = q;
            this.c = c;
        }

        public void Read()
        {
            Console.WriteLine("Question: " + q);
            Console.WriteLine("Options: " + c);
        }
    }
}

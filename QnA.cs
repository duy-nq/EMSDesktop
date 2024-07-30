using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSDesktop
{
    internal class QnA
    {
        public string Question { get; set; }

        public string[] Choices { get; set; }

        public string Answer { get; set; }

        public QnA(string question, string[] options, string answer)
        {
            Question = question;
            Choices = options;
            Answer = answer;
        }
    }
}

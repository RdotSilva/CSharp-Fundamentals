using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizeText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really long text that we want to summarize.";
            var summary = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);

        }

    }
}

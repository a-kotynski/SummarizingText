using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-tutorial-for-beginners/learn/lecture/2984168#content
namespace SummarizingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really long text.";
            Console.WriteLine(sentence);

            var summary = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);
            
        }
        //method needs to be static, so it's possible to call it from other static methods
        
    }
}
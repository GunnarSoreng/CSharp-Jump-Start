using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Create astringbuilde instance
            var sb = new StringBuilder();

            // append lines
            sb.AppendLine("This is the original first line");
            sb.AppendLine("This is another line");

            // append formatted values
            for (int i = 0; i < 10; i++)
            {
                sb.AppendFormat(
                    "Inserting line with loop index {0,5} on {1,9:d} {2}", i, DateTime.Now, Environment.NewLine);

            }


            Console.WriteLine(sb.ToString());
            Console.ReadLine();

            // replace values
            sb.Replace("index", "counter");

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
            */

            var source = "The quick brown fox jumped over the lazy dog";

            Console.WriteLine("Source : {0}", source);
            var split = source.Split(' ');
            var value = split[1];
            // value = "quick"
            Console.WriteLine("Split ' ' index 1 : {0}", value);

            var pattern = @"\b\w+\b";
            var matches = Regex.Matches(source, pattern);
            value = matches[1].Value;
            // value = "quick"
            Console.WriteLine(@"Regexp Matches (patter: \b\w+\b) : {0}", value);

            pattern = "(The )(.+)( brown)";
            var groups = Regex.Match(source, pattern).Groups;
            // groups[0] = "The quick brown"
            // groups[1] = "The "
            // groups[2] = "quick"
            // groups[3] = " brown"
            Console.WriteLine(@"{4}Match (pattern: {5}): {4}0: **{0}**{4}1: **{1}**{4}2: **{2}**{4}3: **{3}**", groups[0], groups[1], groups[2], groups[3],Environment.NewLine,pattern);




            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adam
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new AdamLib.SuffixTree.SuffixTree<Guid>();
            AdamLib.Collections.AssociativeMemory.AssociativeMemory.Vocabulary = test;
            var memory = new AdamLib.Collections.AssociativeMemory.AssociativeMemory();
            
            var reader =
                new AdamLib.IO.Reader.TextReader(
                    "Car has doors".ToLower());
            
            while(reader.HasTokens())
                test.Add(reader.NextToken());

            Console.WriteLine(test.Count);
            Console.ReadKey();
        }
    }
}

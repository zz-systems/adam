using AdamLib.IO.Reader;
using AdamLib.WikipediaAPI;
using System.Data;

namespace AdamLib.IO.Learning
{
    class WikipediaReader : TextReader
    {
        public WikipediaReader(string Text) : base(Text)
        {
        }
    }
}

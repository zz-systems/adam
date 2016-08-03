using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdamLib.IO.Reader
{
    public class TextReader : IReader
    {
        private string m_Text;
        private Queue<string> m_Tokens;

        public TextReader(string Text)
        {
            m_Text = Text;
            m_Tokens = new Queue<string>();
            Tokenize();
        }
        private void Tokenize()
        {
            foreach(var splitted in m_Text.Split(' '))
                m_Tokens.Enqueue(splitted);
        }
        public string NextToken()
        {
            return m_Tokens.Dequeue();
        }

        public bool HasTokens()
        {
            return m_Tokens.Count > 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdamLib.Collections.AssociativeMemory
{
    public class AssociativeMemory
    {
        private Dictionary<Guid, Element> m_Elements;
        public static SuffixTree.SuffixTree<Guid> Vocabulary;
        public Dictionary<Guid, Element> Elements { get; set; }

        public void Add(string Value) { }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, from element 
                                                        in Elements 
                                                    select element.ToString());
        }
    }
}

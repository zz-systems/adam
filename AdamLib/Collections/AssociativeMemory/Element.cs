using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;

namespace AdamLib.Collections.AssociativeMemory
{
    [DataContract]
    public class Element
    {
        enum Type
        {
            Noun,
            Verb,
            Adjective
        }
        public Guid ID { get; set; }
        private List<Relationship> m_Relations;
        public List<Relationship> Relations { get { return m_Relations; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(AssociativeMemory.Vocabulary[ID] + " ");

            sb.Append(string.Join(", ", from relation in Relations
                              select
                                  string.Format("{0} {1}", relation.Relation.ToString(),
                                                AssociativeMemory.Vocabulary[relation.Other.ID])));
            return sb.ToString();
        }
    }
}

using System;

namespace AdamLib.Collections.AssociativeMemory
{
    public class Relationship
    {
        public enum Type
        {
            Has,
            Is,
            Synonym,
            Antonym,
            Describes
        }
        
        public Type Relation { get; set; }
        public Element Other { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdamLib.SuffixTree
{
    public class Node<T> where T : new()
    {
        private readonly char m_Key;
        private T m_Value;
        private readonly Dictionary<char, Node<T>> m_Children;

        public Node()
        {
            m_Children = new Dictionary<char, Node<T>>();
        }

        public Node(char Key)
            : this()
        {
            m_Key = Key;
        }
        public Node(char Key, T Value)
            : this(Key)
        {
            m_Value = Value;
        }

        public bool HasChildren
        {
            get { return m_Children.Count > 0; }
        }

        public Node<T> this[char ToSearch]
        {
            get { return m_Children[ToSearch]; }
        }

        public bool ContainsKey(char Key)
        {
            return m_Children.ContainsKey(Key);
        }

        public void Add(Node<T> Child)
        {
            m_Children.Add(Child.Key, Child);
        }

        public char Key
        {
            get { return m_Key; }
        }

        public T Value
        {
            get { return m_Value; }
            set { m_Value = value; }
        }

        public List<Node<T>> Children
        {
            get { return m_Children.Values.ToList(); }
        }
    }
}

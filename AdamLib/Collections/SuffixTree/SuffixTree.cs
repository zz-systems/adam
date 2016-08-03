using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdamLib.SuffixTree
{
    public class SuffixTree<T> where T : new()
    {
        private Node<T> m_Root;
        private int m_Count;
        private Dictionary<T, string> m_Strings;

        public SuffixTree()
        {
            m_Root = new Node<T>();
            m_Strings = new Dictionary<T, string>();
            m_Count = 0;
        }

        public T this[string Key]
        {
            get { return GetNode(Key).Value; }
            set { }
        }
        public string this[T Key]
        {
            get { return m_Strings[Key]; }
            set { throw new InvalidOperationException(); }
        }
        private Node<T> GetNode(string Key)
        {
            Node<T> current = m_Root;
            foreach (char ch in Key)
            {
                if (current.HasChildren)
                    current = current[ch];
                else
                    throw new Exception("Element does not exist");
            }
            return current;
        }
        public void Add(string Key)
        {
            Add(Key, new T());
        }
        public void Add(string Key, T Value)
        {
            Node<T> current = m_Root;
            foreach (char ch in Key)
            {
                if (current.HasChildren && current.ContainsKey(ch))
                    current = current[ch];
                else
                {
                    var newNode = new Node<T>(ch);

                    current.Add(newNode);
                    current = newNode;
                }
            }
            current.Value = Value;
            m_Strings.Add(Value, Key);
            m_Count++;
        }

        public bool ContainsKey(string key)
        {
            try
            {
                GetNode(key);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void Clear()
        {
            m_Root = new Node<T>();
            m_Count = 0;
        }

        public int Count
        {
            get { return m_Count; }
        }
    }
}

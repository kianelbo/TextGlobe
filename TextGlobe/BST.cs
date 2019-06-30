using System.Collections.Generic;

namespace TextGlobe
{
    class BST
    {
        private Node root;

        public BST()
        {
            this.root = null;
        }

        public void Insert(string word, string fileAndLine)
        {
            if (exists(word))
                FindNode(word).OccuranceList.Add(fileAndLine);
            else
                addNew(word, fileAndLine);
        }

        public Node FindNode(string word)
        {
            Node current = root;
            while (current != null && current.Key.CompareTo(word) != 0)
            {
                if (current.Key.CompareTo(word) > 0) current = current.Left;
                if (current != null && current.Key.CompareTo(word) < 0) current = current.Right;
            }
            return current;
        }

        private void addNew(string word, string fileAndLine)
        {
            Node newNode = new Node(word);
            newNode.OccuranceList.Add(fileAndLine);
            if (root == null)
            {
                root = newNode;
                return;
            }
            Node current = root;
            Node parent = null;
            while (true)
            {
                parent = current;
                if (word.CompareTo(current.Key) < 0)
                {
                    current = current.Left;
                    if (current == null)
                    {
                        parent.Left = newNode;
                        return;
                    }
                }
                else
                {
                    current = current.Right;
                    if (current == null)
                    {
                        parent.Right = newNode;
                        return;
                    }
                }
            }
        }

        private bool exists(string word)
        {
            Node current = root;
            while (current != null)
            {
                if (current.Key.Equals(word))
                    return true;
                else if (current.Key.CompareTo(word) > 0)
                    current = current.Left;
                else
                    current = current.Right;
            }
            return false;
        }
    }

    class Node
    {
        public string Key;
        public Node Left, Right;
        public HashSet<string> OccuranceList;

        public Node(string key)
        {
            this.Key = key;
            this.Left = null;
            this.Right = null;
            this.OccuranceList = new HashSet<string>();
        }
    }
}

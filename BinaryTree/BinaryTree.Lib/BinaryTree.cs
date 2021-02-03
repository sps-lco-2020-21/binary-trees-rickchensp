using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeEx.Lib
{
    public class BinaryTree
    {
        private TreeNode _root;

        public BinaryTree(int v)
        {
            _root = new TreeNode(v, 0, null);
        }

        public void Insert(int v)
        {
            _root.Insert(v);
        }

        public void InsertRange(List<int> list)
        {
            foreach(int v in list)
            {
                _root.Insert(v);
            }
        }

        public bool IsPresent(int v)
        {
            return _root.IsPreSent(v);
        }
        public int Depth { get { return _root.Depth; } }
        public int Count { get { return _root.Count; } }
        public int Sum { get { return _root.Value + _root.Sum; } }

        public void InOrderOutput()
        {
            _root.InOrderTraversal();
        }

        public override string ToString()
        {
            return "Count = " + Convert.ToString(Count);
        }
    }


    internal class TreeNode
    { 
        private int _value;
        private TreeNode _leftChild, _rightChild, _parent;
        private int _layer;
        public TreeNode(int v, int layer, TreeNode parent)
        {
            _value = v;
            _layer = layer;
            _parent = parent;
            _leftChild = null;
            _rightChild = null;
        }

        public int Value { get { return _value; } }

        internal void Insert(int v)
        {
            if(v < _value)
            {
                if(_leftChild != null)
                    _leftChild.Insert(v);
                else
                    _leftChild = new TreeNode(v, _layer + 1, this);
            }   
            else
            {
                if(_rightChild != null)
                    _rightChild.Insert(v);
                else
                    _rightChild = new TreeNode(v, _layer + 1, this);
            }
        }

        public override string ToString()
        {
            return Convert.ToString(_value);
        }

        internal bool IsPreSent(int v)
        {
            if (v == _value)
                return true;
            if (v >= _value)
                return (_rightChild == null) ? false : _rightChild.IsPreSent(v);
            else
                return (_leftChild == null) ? false : _leftChild.IsPreSent(v);
        }

        internal void InOrderTraversal()
        {
            if (_leftChild != null)
                _leftChild.InOrderTraversal();
            Console.WriteLine(this);
            if (_rightChild != null)
                _rightChild.InOrderTraversal();       
        }

        internal int Sum
        {
            get
            {
                return ((_leftChild == null) ? 0 : _leftChild._value + _leftChild.Sum)
                    + ((_rightChild == null) ? 0 : _rightChild._value + _rightChild.Sum);
            }
        }

        internal int Count
        {
            get
            {
                return 1 + ((_leftChild == null) ? 0 : _leftChild.Count)
                    + ((_rightChild == null) ? 0 : _rightChild.Count);        
            }
        }

        internal int Depth
        {
            get
            {
                if(_leftChild == null & _rightChild == null)
                    return 1;
                int leftDepth = (_leftChild == null) ? 0 : _leftChild.Depth;
                int rightDepth = (_rightChild == null) ? 0 : _rightChild.Depth;
                return 1 + Math.Max(leftDepth, rightDepth);
            }
        }
    }

}

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
        private int _depth;
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

        public int Depth
        {
            get
            {
                return 0;
            }
        }

        public int Sum
        {
            get
            {    
                return _root.Value + _root.Sum;
            }
        }

        public override string ToString()
        {
            return _root.ToString();
        }
    }


    public class TreeNode
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
            {
                if(_rightChild != null)
                    return _rightChild.IsPreSent(v);
                return false;

            }
            else
            {
                if (_leftChild != null)
                    return _leftChild.IsPreSent(v);
                return false;
            }

        }

        internal int Sum
        {
            get
            {
                if(_leftChild == null)
                {
                    if (_rightChild == null)
                        return 0;
                    return _rightChild._value + _rightChild.Sum;
                }
                else if(_rightChild == null)
                    return _leftChild._value + _leftChild.Sum;
                else
                    return _leftChild._value + _rightChild._value + _leftChild.Sum + _rightChild.Sum;
            }
        }
    }

}

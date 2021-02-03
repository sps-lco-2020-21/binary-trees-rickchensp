using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTreeEx.Lib;

namespace BinaryTreeEx.App
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree1 = new BinaryTree(5);
            tree1.InsertRange(new List<int> { 4, 6, 3, 18, 1, 25, 12 });
            tree1.InOrderOutput();
            int depth = tree1.Depth;
            BinaryTree tree2 = new BinaryTree(7);
            tree2.InsertRange(new List<int> { 4, 6, 3, 18, 1, 25, 12, 2, 9 , 75, 64, 24, 10 , 108, 209});
            tree2.InOrderOutput();
            int depth2 = tree2.Depth;
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryTreeEx.Lib;

namespace BinaryTreeEx.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInsert()
        {
            BinaryTree tree1 = new BinaryTree(5);
            tree1.Insert(3);
            tree1.Insert(6);
        }

        [TestMethod]
        public void TestIsPresent()
        {
            BinaryTree tree1 = new BinaryTree(5);
            tree1.InsertRange(new List<int> { 4, 6, 9, 7 });
            Assert.AreEqual(true, tree1.IsPresent(4));
            Assert.AreEqual(true, tree1.IsPresent(6));
            Assert.AreEqual(true, tree1.IsPresent(9));
            Assert.AreEqual(true, tree1.IsPresent(7));
        }

        [TestMethod]

        public void TestSum()
        {
            BinaryTree tree1 = new BinaryTree(5);
            tree1.InsertRange(new List<int> { 4, 6, 3, 18, 1, 25, 12});
            Assert.AreEqual(74, tree1.Sum);
        }

        
    }
}

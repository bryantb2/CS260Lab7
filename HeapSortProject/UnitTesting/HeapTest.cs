using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HeapSortProject;

namespace UnitTesting
{
    public class HeapifySort
    {
        HeapSortProject.HeapifySort heapObj;
        HeapSortProject.HeapifySort heapObj2;
        HeapSortProject.HeapifySort heapObj3;

        [SetUp]
        public void Setup()
        {
            heapObj = new HeapSortProject.HeapifySort();
            heapObj2 = new HeapSortProject.HeapifySort(25);
            heapObj3 = new HeapSortProject.HeapifySort();
        }

        [Test]
        public void BasicTest()
        {
            bool test = false;
            Assert.AreEqual(false, test);
        }

        [Test]
        public void ConstructorTest()
        {
            //default and defined constructor tests
            int heapOneSize = heapObj.Size;
            int heapTwoSize = heapObj2.Size;
            Assert.AreEqual(16, heapOneSize);
            Assert.AreEqual(25, heapTwoSize);
            try
            {
                heapObj3 = new HeapSortProject.HeapifySort(5);
                Assert.Fail("the constructor did not throw an arguement exception");
            }
            catch (ArgumentException)
            {
                Assert.Pass("The constructor threw an exception!");
            }
        }

        [Test]
        public void InsertTest()
        {
            //insert 3 values
            heapObj.Insert(20);
            heapObj.Insert(10);
            heapObj.Insert(40);
            heapObj.Insert(15);
            heapObj.Insert(0);
            heapObj.Insert(90);
            heapObj.Insert(1750);
            heapObj.Insert(50);
            heapObj.Insert(30);
        }

        [Test]
        public void InsertDoublingTest()
        {
            /*fill heap, then insert another 
            value that will force it to double*/
            int originalSize = heapObj.Size;
            for (int i = 0; i < originalSize; i++)
            {
                heapObj.Insert(i);
            }
            Assert.AreEqual((originalSize * 2), heapObj.Size);
        }
    }
}

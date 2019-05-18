using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HeapSortProject;

namespace UnitTesting
{
    public class HeapTest
    {
        int[] array1;
        int[] array2;

        [SetUp]
        public void Setup()
        {
            array1 = new int[] { 10, 900, 3, 7, 8, 50, 80, 36 };
            array2 = new int[] { 100, 300, 35, 17, 19, 20, 800, 77 };
        }

        [Test]
        public void BasicTest()
        {
            bool test = false;
            Assert.AreEqual(false, test);
        }

        [Test]
        public void HeapifyTest()
        {
            HeapifySort.TrickleDown(ref array1);
            HeapifySort.TrickleDown(ref array2);
            Assert.AreEqual(900,array1[0]);
            //Assert.AreEqual(array1[0], 800);
        }
    }
}

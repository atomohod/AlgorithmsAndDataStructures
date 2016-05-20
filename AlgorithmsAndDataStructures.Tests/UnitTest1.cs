using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsAndDataStructures.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BinaryTreeBuilding()
        {
            //arrange

            BinaryTreeBuilder builder = new BinaryTreeBuilder();
            var array = new[] { 8,1,4,9,9,6,3,8,1 };
            
            //act

            var result = builder.Build(array);

            //assert

            Assert.AreEqual(result.Value, 8);

            Assert.AreEqual(result.Left.Value, 1);

            Assert.AreEqual(result.Right.Value, 9);

            Assert.AreEqual(result.Left.Right.Value, 4);

            Assert.AreEqual(result.Left.Right.Left.Value, 3);

            Assert.AreEqual(result.Left.Right.Left.Left.Value, 1);

            Assert.AreEqual(result.Left.Right.Right.Value, 6);

            Assert.AreEqual(result.Right.Value, 9);

            Assert.AreEqual(result.Right.Right.Value, 9);

            Assert.AreEqual(result.Right.Left.Value, 8);
        }

        [TestMethod]
        public void BubbleSort()
        {
            //arrange
            var t1 = new[] { 3, 8, 6, 4 };
            var t2 = new[] { 2, 8, 4, 6, 9, 9, 9, 0, 5, 3, 7, 4, 0, 1, 2, 2, 6, 2 };
            var t3 = new[] { 1, 3, 4, 6, 7, 8, 9 };
            var t4 = new[] { 9, 7, 7, 6, 5, 4, 3, 1 };
            //act

            BubbleSort bs = new BubbleSort();
            bs.Sort(t1);
            bs.Sort(t2);
            bs.Sort(t3);
            bs.Sort(t4);

            //assert
            Assert.IsTrue(IsGrowing(t1));
            Assert.IsTrue(IsGrowing(t2));
            Assert.IsTrue(IsGrowing(t3));
            Assert.IsTrue(IsGrowing(t4));

            Assert.IsTrue(AreEqual(t1, new[] {3, 4, 6, 8}));
            Assert.IsTrue(AreEqual(t2, new[] {0, 0, 1, 2, 2, 2, 2, 3, 4, 4, 5, 6, 6, 7, 8, 9, 9, 9}));
        }

        private bool IsGrowing(int[] t)
        {
            for (int i = 1; i < t.Length; i++)
            {
                if (t[i] < t[i - 1])
                    return false;
            }

            return true;
        }

        private bool AreEqual(int[] a, int[] b)
        {
            if (a.Length != b.Length)
                return false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }

            return true;
        }
    }
}

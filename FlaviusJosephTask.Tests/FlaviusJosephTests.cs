using NUnit.Framework;
using FlaviusJosephTask;
using System;

namespace FlaviusJosephTask.Tests
{
    public class FlaviusJosephTests
    {
        [TestCase(5, 2, new int[] { 2, 4, 1, 5, 3 })]
        [TestCase(5, 3, new int[] { 3, 1, 5, 2, 4 })]
        [TestCase(5, 4, new int[] { 4, 3, 5, 2, 1 })]
        [TestCase(5, 5, new int[] { 5, 1, 3, 4, 2 })]
        [TestCase(7, 2, new int[] { 2, 4, 6, 1, 5, 3, 7 })]
        [TestCase(7, 3, new int[] { 3, 6, 2, 7, 5, 1, 4 })]
        [TestCase(7, 5, new int[] { 5, 3, 2, 4, 7, 1, 6 })]
        [TestCase(10, 2, new int[] { 2, 4, 6, 8, 10, 3, 7, 1, 9, 5 })]
        [TestCase(10, 3, new int[] { 3, 6, 9, 2, 7, 1, 8, 5, 10, 4 })]
        [TestCase(10, 5, new int[] { 5, 10, 6, 2, 9, 8, 1, 4, 7, 3 })]
        public void GetFlaviousJosephTests(int wariors, int k, int[] expected)
        {
            Assert.AreEqual(FlaviousJoseph.GetAlives(wariors, k), expected);
        }

        [TestCase(-123)]
        [TestCase(-1)]
        [TestCase(0)]
        public void GetFlaviousJoseph_KIsLessThan1_ArgumentException(int k)
        {
            Assert.Throws<ArgumentException>(() => FlaviousJoseph.GetAlives(6, -2));
        }
    }
}
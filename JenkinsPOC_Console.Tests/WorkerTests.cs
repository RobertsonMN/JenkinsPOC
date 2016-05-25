using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsPOC_Console.Tests
{
    [TestClass]
    public class WorkerTests
    {
        [TestMethod]
        public void IsPalindrome_EmptyString_ReturnsFalse()
        {
            var worker = new Worker();
            Assert.IsFalse(worker.IsPalindrome(""));
        }

        [TestMethod]
        public void IsPalindrome()
        {
            var worker = new Worker();
            Assert.IsTrue(worker.IsPalindrome("racecar"));
        }

        [TestMethod]
        public void IsNotPalindrome()
        {
            var worker = new Worker();
            Assert.IsFalse(worker.IsPalindrome("jupiter"));
        }


        [TestMethod]
        public void IsPalindrome_Trim()
        {
            var worker = new Worker();
            Assert.IsTrue(worker.IsPalindrome("mom     "));
        }
    }
}

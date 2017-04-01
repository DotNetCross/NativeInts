using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetCross.NativeInts.Tests
{
    [TestClass]
    public class UIntPtrTest
    {
        private const string NotAvailable = "This feature not available for UIntPtr";

        [TestMethod]
        public void operator_Addition_IntPtr()
        {
            Assert.Inconclusive(NotAvailable);
            //var ip = new UIntPtr(1);
            //Assert.AreEqual(ip + new UIntPtr(1), new UIntPtr(2));
            //Assert.AreEqual(new UIntPtr(1) + ip, new UIntPtr(2));
        }
        [TestMethod]
        public void operator_Addition_int()
        {
            var ip = new UIntPtr(1);
            Assert.AreEqual(ip + 1, new UIntPtr(2));
            // Below not available
            //Assert.AreEqual(1 + ip, new UIntPtr(2));
        }
        [TestMethod]
        public void operator_Addition_uint()
        {
            Assert.Inconclusive(NotAvailable);
            //var ip = new UIntPtr(1);
            //Assert.AreEqual(ip + 1u, new UIntPtr(2));
            //Assert.AreEqual(1u + ip, new UIntPtr(2));
        }

        [TestMethod]
        public void operator_Subtraction_UIntPtr()
        {
            Assert.Inconclusive(NotAvailable);
            //var ip = new UIntPtr(1);
            //Assert.AreEqual(ip - new UIntPtr(1), new UIntPtr(0));
            //Assert.AreEqual(new UIntPtr(1) - ip, new UIntPtr(0));
        }
        [TestMethod]
        public void operator_Subtraction_int()
        {
            var ip = new UIntPtr(1);
            Assert.AreEqual(ip - 1, new UIntPtr(0));
            // Below not available
            //Assert.AreEqual(1 - ip, new UIntPtr(0));
        }
        [TestMethod]
        public void operator_Subtraction_uint()
        {
            Assert.Inconclusive(NotAvailable);
            //var ip = new UIntPtr(1);
            //Assert.AreEqual(ip - 1u, new UIntPtr(0));
            //Assert.AreEqual(1u - ip, new UIntPtr(0));
        }

        [TestMethod]
        public void operator_AdditionAssignment()
        {
            var ip = new UIntPtr(7);
            ip += 1;
            Assert.AreEqual(ip, new UIntPtr(8));
        }
        [TestMethod]
        public void operator_SubtractionAssignment()
        {
            var ip = new UIntPtr(7);
            ip -= 1;
            Assert.AreEqual(ip, new UIntPtr(6));
        }
    }
}

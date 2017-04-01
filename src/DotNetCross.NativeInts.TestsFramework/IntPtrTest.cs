using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetCross.NativeInts.Tests
{
    [TestClass]
    public class IntPtrTest
    {
        private const string NotAvailable = "This feature not available for IntPtr";

        [TestMethod]
        public void Zero()
        {
            Assert.AreEqual(IntPtr.Zero, IntPtr.Zero);
        }

        [TestMethod]
        public void ctor_IntPtr_0()
        {
            IntPtr ip = new IntPtr(0);
            Assert.AreEqual(ip, IntPtr.Zero);
        }
        [TestMethod]
        public void ctor_IntPtr_1()
        {
            IntPtr ip = new IntPtr(1);
            Assert.AreEqual(ip, new IntPtr(1));
        }

        [TestMethod]
        public void ctor_int_0()
        {
            IntPtr ip = new IntPtr(0);
            Assert.AreEqual(ip, new IntPtr(0));
        }
        [TestMethod]
        public void ctor_int_1()
        {
            IntPtr ip = new IntPtr(1);
            Assert.AreEqual(ip, new IntPtr(1));
        }

        [TestMethod]
        public void implicit_conversion_from_int()
        {
            Assert.Inconclusive(NotAvailable);
            //IntPtr ip = 42;
            //Assert.AreEqual(ip, new IntPtr(42));
        }
        [TestMethod]
        public void explicit_conversion_from_long()
        {
            IntPtr ip = (IntPtr)42L;
            Assert.AreEqual(ip, new IntPtr(42L));
        }
        
        [TestMethod]
        public void operator_Increment()
        {
            Assert.Inconclusive(NotAvailable);
            //var ip = IntPtr.Zero;
            //++ip;
            //Assert.AreEqual(ip, new IntPtr(1));
        }
        [TestMethod]
        public void operator_Decrement()
        {
            Assert.Inconclusive(NotAvailable);
            //var ip = IntPtr.Zero;
            //--ip;
            //Assert.AreEqual(ip, new IntPtr(1));
        }
        [TestMethod]
        public void operator_UnaryPlus()
        {
            Assert.Inconclusive(NotAvailable);
            //var ip = new IntPtr(1);
            //Assert.AreEqual(+ip, new IntPtr(1));
        }
        [TestMethod]
        public void operator_UnaryNegate()
        {
            Assert.Inconclusive(NotAvailable);
            //var ip = new IntPtr(1);
            //Assert.AreEqual(-ip, new IntPtr(-1));
        }

        [TestMethod]
        public void operator_OnesComplement()
        {
            Assert.Inconclusive(NotAvailable);
            //Assert.AreEqual(~new IntPtr(1), new IntPtr(-2));
            //Assert.AreEqual(~new IntPtr(0), new IntPtr(-1));
            //Assert.AreEqual(~new IntPtr(-1), new IntPtr(0));
        }

        [TestMethod]
        public void operator_Addition_IntPtr()
        {
            Assert.Inconclusive(NotAvailable);
            //var ip = new IntPtr(1);
            //Assert.AreEqual(ip + new IntPtr(1), new IntPtr(2));
            //Assert.AreEqual(new IntPtr(1) + ip, new IntPtr(2));
        }
        [TestMethod]
        public void operator_Addition_int()
        {
            var ip = new IntPtr(1);
            Assert.AreEqual(ip + 1, new IntPtr(2));
            // Below not available
            //Assert.AreEqual(1 + ip, new IntPtr(2));
        }
        [TestMethod]
        public void operator_Addition_uint()
        {
            Assert.Inconclusive(NotAvailable);
            //var ip = new IntPtr(1);
            //Assert.AreEqual(ip + 1u, new IntPtr(2));
            //Assert.AreEqual(1u + ip, new IntPtr(2));
        }

        [TestMethod]
        public void operator_Subtraction_IntPtr()
        {
            Assert.Inconclusive(NotAvailable);
            //var ip = new IntPtr(1);
            //Assert.AreEqual(ip - new IntPtr(1), new IntPtr(0));
            //Assert.AreEqual(new IntPtr(1) - ip, new IntPtr(0));
        }
        [TestMethod]
        public void operator_Subtraction_int()
        {
            var ip = new IntPtr(1);
            Assert.AreEqual(ip - 1, new IntPtr(0));
            // Below not available
            //Assert.AreEqual(1 - ip, new IntPtr(0));
        }
        [TestMethod]
        public void operator_Subtraction_uint()
        {
            Assert.Inconclusive(NotAvailable);
            //var ip = new IntPtr(1);
            //Assert.AreEqual(ip - 1u, new IntPtr(0));
            //Assert.AreEqual(1u - ip, new IntPtr(0));
        }

        [TestMethod]
        public void operator_Multiply_IntPtr()
        {
            Assert.Inconclusive(NotAvailable);
            //var ip = new IntPtr(7);
            //Assert.AreEqual(ip * new IntPtr(2), new IntPtr(14));
        }
        [TestMethod]
        public void operator_Multiply_int()
        {
            Assert.Inconclusive(NotAvailable);
            //var ip = new IntPtr(7);
            //Assert.AreEqual(ip * 2, new IntPtr(14));
        }

        [TestMethod]
        public void operator_Division_IntPtr()
        {
            Assert.Inconclusive(NotAvailable);
            //var ip = new IntPtr(7);
            //Assert.AreEqual(ip / new IntPtr(2), new IntPtr(3));
        }
        [TestMethod]
        public void operator_Division_int()
        {
            Assert.Inconclusive(NotAvailable);
            //var ip = new IntPtr(7);
            //Assert.AreEqual(ip / 2, new IntPtr(3));
        }

        [TestMethod]
        public void operator_AdditionAssignment()
        {
            var ip = new IntPtr(7);
            ip += 1;
            Assert.AreEqual(ip, new IntPtr(8));
        }
        [TestMethod]
        public void operator_SubtractionAssignment()
        {
            var ip = new IntPtr(7);
            ip -= 1;
            Assert.AreEqual(ip, new IntPtr(6));
        }
    }
}

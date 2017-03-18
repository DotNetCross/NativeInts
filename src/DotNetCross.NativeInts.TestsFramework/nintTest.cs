using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetCross.NativeInts.TestsFramework
{
    [TestClass]
    public class nintTest
    {
        [TestMethod]
        public unsafe void TraceSize()
        {
            Trace.WriteLine($"Sizeof {nameof(nint)}:{sizeof(nint)}");
            //Assert.AreEqual(8, sizeof(nint));
        }

        [TestMethod]
        public void Zero()
        {
            Assert.AreEqual(nint.Zero.Value, IntPtr.Zero);
        }

        [TestMethod]
        public void ctor_IntPtr_0()
        {
            nint ni = new nint(IntPtr.Zero);
            Assert.AreEqual(ni.Value, IntPtr.Zero);
        }
        [TestMethod]
        public void ctor_IntPtr_1()
        {
            nint ni = new nint(new IntPtr(1));
            Assert.AreEqual(ni.Value, new IntPtr(1));
        }

        [TestMethod]
        public void ctor_int_0()
        {
            nint ni = new nint(0);
            Assert.AreEqual(ni.Value, new IntPtr(0));
        }
        [TestMethod]
        public void ctor_int_1()
        {
            nint ni = new nint(1);
            Assert.AreEqual(ni.Value, new IntPtr(1));
        }

        [TestMethod]
        public void implicit_conversion_from_IntPtr()
        {
            nint ni = new IntPtr(42);
            Assert.AreEqual(ni.Value, new IntPtr(42));
        }
        [TestMethod]
        public void implicit_conversion_from_int()
        {
            nint ni = 42;
            Assert.AreEqual(ni.Value, new IntPtr(42));
        }
        [TestMethod]
        public void explicit_conversion_from_long()
        {
            nint ni = (nint)42L;
            Assert.AreEqual(ni.Value, new IntPtr(42L));
        }

        [TestMethod]
        public void implicit_conversion_to_IntPtr()
        {
            IntPtr ip = new nint(42);
            Assert.AreEqual(ip, new IntPtr(42));
        }
        [TestMethod]
        public void implicit_conversion_to_long()
        {
            long l = new nint(42);
            Assert.AreEqual(l, 42L);
        }
        [TestMethod]
        public void explicit_conversion_to_int()
        {
            int i = (int)new nint(42);
            Assert.AreEqual(i, 42);
        }

        [TestMethod]
        public void explicit_conversion_to_byte_via_int()
        {
            Assert.AreEqual((byte)new nint(0), (byte)0);
            Assert.AreEqual((byte)new nint(42), (byte)42);
            Assert.AreEqual((byte)new nint(255), byte.MaxValue);
            Assert.AreEqual((byte)new nint(256), (byte)0);
        }

        [TestMethod]
        public void operator_Increment_Pre()
        {
            var ni = nint.Zero;
            ++ni;
            Assert.AreEqual(ni, new nint(1));
        }
        [TestMethod]
        public void operator_Increment_Post()
        {
            var ni = nint.Zero;
            ni++;
            Assert.AreEqual(ni, new nint(1));
        }

        [TestMethod]
        public void operator_Decrement_Pre()
        {
            var ni = nint.Zero;
            --ni;
            Assert.AreEqual(ni, new nint(-1));
        }
        [TestMethod]
        public void operator_Decrement_Post()
        {
            var ni = nint.Zero;
            ni--;
            Assert.AreEqual(ni, new nint(-1));
        }

        [TestMethod]
        public void operator_UnaryPlus()
        {
            var ni = new nint(1);
            Assert.AreEqual(+ni, new nint(1));
        }
        [TestMethod]
        public void operator_UnaryNegate()
        {
            var ni = new nint(1);
            Assert.AreEqual(-ni, new nint(-1));
        }

        [TestMethod]
        public void operator_OnesComplement()
        {
            Assert.AreEqual(~new nint(1), new nint(-2));
            Assert.AreEqual(~new nint(0), new nint(-1));
            Assert.AreEqual(~new nint(-1), new nint(0));
        }

        [TestMethod]
        public void operator_Addition_nint()
        {
            var ni = new nint(1);
            Assert.AreEqual(ni + new nint(1), new nint(2));
            Assert.AreEqual(new nint(1) + ni, new nint(2));
        }
        [TestMethod]
        public void operator_Addition_IntPtr()
        {
            var ni = new nint(1);
            Assert.AreEqual(ni + new IntPtr(1), new nint(2));
            Assert.AreEqual(new IntPtr(1) + ni, new nint(2));
        }
        [TestMethod]
        public void operator_Addition_int()
        {
            var ni = new nint(1);
            Assert.AreEqual(ni + 1, new nint(2));
            Assert.AreEqual(1 + ni, new nint(2));
        }
        //[TestMethod]
        //public void operator_Addition_uint()
        //{
        //    //var ni = new nint(1);
        //    //Assert.AreEqual(ni + 1u, new nint(2));
        //    //Assert.AreEqual(1u + ni, new nint(2));
        //}
    }
}

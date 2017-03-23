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
            Console.WriteLine($"Sizeof {nameof(nint)}:{sizeof(nint)}");
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

        [TestMethod]
        public void operator_Subtraction_nint()
        {
            var ni = new nint(1);
            Assert.AreEqual(ni - new nint(1), new nint(0));
            Assert.AreEqual(new nint(1) - ni, new nint(0));
        }
        [TestMethod]
        public void operator_Subtraction_IntPtr()
        {
            var ni = new nint(1);
            Assert.AreEqual(ni - new IntPtr(1), new nint(0));
            Assert.AreEqual(new IntPtr(1) - ni, new nint(0));
        }
        [TestMethod]
        public void operator_Subtraction_int()
        {
            var ni = new nint(1);
            Assert.AreEqual(ni - 1, new nint(0));
            Assert.AreEqual(1 - ni, new nint(0));
        }

        [TestMethod]
        public void operator_Multiply_nint()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni * new nint(2), new nint(14));
        }
        [TestMethod]
        public void operator_Multiply_IntPtr()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni * new IntPtr(2), new nint(14));
        }
        [TestMethod]
        public void operator_Multiply_int()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni * 2, new nint(14));
        }

        [TestMethod]
        public void operator_Division_nint()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni / new nint(2), new nint(3));
        }
        [TestMethod]
        public void operator_Division_IntPtr()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni / new IntPtr(2), new nint(3));
        }
        [TestMethod]
        public void operator_Division_int()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni / 2, new nint(3));
        }

        [TestMethod]
        public void operator_Modulus_nint()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni % new nint(4), new nint(3));
        }
        [TestMethod]
        public void operator_Modulus_IntPtr()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni % new IntPtr(4), new nint(3));
        }
        [TestMethod]
        public void operator_Modulus_int()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni % 4, new nint(3));
        }

        [TestMethod]
        public void operator_ExclusiveOr_nint()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni ^ new nint(4), new nint(3));

        }
        [TestMethod]
        public void operator_ExclusiveOr_IntPtr()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni ^ new IntPtr(4), new nint(3));
        }
        [TestMethod]
        public void operator_ExclusiveOr_int()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni ^ 4, new nint(3));
        }

        [TestMethod]
        public void operator_BitwiseAnd_nint()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni & new nint(12), new nint(4));
        }
        [TestMethod]
        public void operator_BitwiseAnd_IntPtr()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni & new IntPtr(12), new nint(4));
        }
        [TestMethod]
        public void operator_BitwiseAnd_int()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni & 12, new nint(4));
        }

        [TestMethod]
        public void operator_BitwiseOr_nint()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni | new nint(8), new nint(15));
        }
        [TestMethod]
        public void operator_BitwiseOr_IntPtr()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni | new IntPtr(8), new nint(15));
        }
        [TestMethod]
        public void operator_BitwiseOr_int()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni | 8, new nint(15));
        }

        [TestMethod]
        public void operator_LeftShift_nint()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni << new nint(2), new nint(28));
        }
        [TestMethod]
        public void operator_LeftShift_IntPtr()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni << new IntPtr(2), new nint(28));
        }
        [TestMethod]
        public void operator_LeftShift_int()
        {
            var ni = new nint(7);
            Assert.AreEqual(ni << 2, new nint(28));
        }

        [TestMethod]
        public void operator_RightShift_nint()
        {
            var ni = new nint(28);
            Assert.AreEqual(ni >> new nint(2), new nint(7));
        }
        [TestMethod]
        public void operator_RightShift_IntPtr()
        {
            var ni = new nint(28);
            Assert.AreEqual(ni >> new IntPtr(2), new nint(7));
        }
        [TestMethod]
        public void operator_RightShift_int()
        {
            var ni = new nint(28);
            Assert.AreEqual(ni >> 2, new nint(7));
        }

        [TestMethod]
        public void operator_Equality_nint()
        {
            Assert.IsTrue(nint.Zero == new nint(0));
            Assert.IsTrue(new nint(-1) == new nint(-1));
            Assert.IsTrue(new nint(0) == new nint(0));
            Assert.IsTrue(new nint(1) == new nint(1));
            Assert.IsTrue(new nint(int.MaxValue) == new nint(int.MaxValue));
            Assert.IsTrue((nint)(long.MaxValue) == (nint)(long.MaxValue));

            Assert.IsFalse(new nint(-2) == new nint(-1));
            Assert.IsFalse(new nint(-1) == new nint(-2));
            Assert.IsFalse(new nint(-1) == new nint(0));
            Assert.IsFalse(new nint(0) == new nint(-1));
            Assert.IsFalse(new nint(0) == new nint(1));
            Assert.IsFalse(new nint(1) == new nint(0));
            Assert.IsFalse(new nint(1) == new nint(2));
            Assert.IsFalse(new nint(2) == new nint(1));
        }
        [TestMethod]
        public unsafe void operator_Equality_int()
        {
            Assert.IsTrue(nint.Zero == 0);
            Assert.IsTrue(new nint(-1) == -1);
            Assert.IsTrue(new nint(0) == 0);
            Assert.IsTrue(new nint(1) == 1);
            Assert.IsTrue(new nint(int.MaxValue) == int.MaxValue);
            Assert.AreEqual(sizeof(int) == sizeof(IntPtr), (nint)(long.MaxValue) == (unchecked((int)long.MaxValue)));
            Assert.IsFalse(new nint(-2) == -1);
            Assert.IsFalse(new nint(-1) == -2);
            Assert.IsFalse(new nint(-1) == 0);
            Assert.IsFalse(new nint(0) == -1);
            Assert.IsFalse(new nint(0) == 1);
            Assert.IsFalse(new nint(1) == 0);
            Assert.IsFalse(new nint(1) == 2);
            Assert.IsFalse(new nint(2) == 1);

            Assert.IsTrue(0 == nint.Zero);
            Assert.IsTrue(-1 == new nint(-1));
            Assert.IsTrue(0 == new nint(0));
            Assert.IsTrue(1 == new nint(1));
            Assert.IsTrue(int.MaxValue == new nint(int.MaxValue));
            Assert.AreEqual(sizeof(int) == sizeof(IntPtr), (unchecked((int)long.MaxValue) == (nint)(long.MaxValue)));
            Assert.IsFalse(-2 == new nint(-1));
            Assert.IsFalse(-1 == new nint(-2));
            Assert.IsFalse(-1 == new nint(0));
            Assert.IsFalse(0 == new nint(-1));
            Assert.IsFalse(0 == new nint(1));
            Assert.IsFalse(1 == new nint(0));
            Assert.IsFalse(1 == new nint(2));
            Assert.IsFalse(2 == new nint(1));
        }
        [TestMethod]
        public unsafe void operator_Equality_long()
        {
            Assert.IsTrue(nint.Zero == 0L);
            Assert.IsTrue(new nint(-1) == -1L);
            Assert.IsTrue(new nint(0) == 0L);
            Assert.IsTrue(new nint(1) == 1L);
            Assert.AreEqual(sizeof(int) != sizeof(IntPtr), (nint)(long.MaxValue) == long.MaxValue);
            Assert.IsFalse(new nint(-2) == -1L);
            Assert.IsFalse(new nint(-1) == -2L);
            Assert.IsFalse(new nint(-1) == 0L);
            Assert.IsFalse(new nint(0) == -1L);
            Assert.IsFalse(new nint(0) == 1L);
            Assert.IsFalse(new nint(1) == 0L);
            Assert.IsFalse(new nint(1) == 2L);
            Assert.IsFalse(new nint(2) == 1L);

            Assert.IsTrue(0L == nint.Zero);
            Assert.IsTrue(-1L == new nint(-1));
            Assert.IsTrue(0L == new nint(0));
            Assert.IsTrue(1L == new nint(1));
            Assert.AreEqual(sizeof(int) != sizeof(IntPtr), long.MaxValue == (nint)(long.MaxValue));
            Assert.IsFalse(-2L == new nint(-1));
            Assert.IsFalse(-1L == new nint(-2));
            Assert.IsFalse(-1L == new nint(0));
            Assert.IsFalse(0L == new nint(-1));
            Assert.IsFalse(0L == new nint(1));
            Assert.IsFalse(1L == new nint(0));
            Assert.IsFalse(1L == new nint(2));
            Assert.IsFalse(2L == new nint(1));
        }
        [TestMethod]
        public unsafe void operator_Equality_IntPtr()
        {
            Assert.IsTrue(nint.Zero == IntPtr.Zero);
            Assert.IsTrue(new nint(-1) == new IntPtr(-1));
            Assert.IsTrue(new nint(0) == new IntPtr(0));
            Assert.IsTrue(new nint(1) == new IntPtr(1));
            Assert.IsTrue(new nint(int.MaxValue) == new IntPtr(int.MaxValue));
            if (sizeof(long) == sizeof(IntPtr))
            {
                // long -> IntPtr overflows if 32-bit, nint doesn't
                Assert.IsTrue((nint)(long.MaxValue) == new IntPtr(long.MaxValue));
            }
            Assert.IsFalse(new nint(-2) == new IntPtr(-1));
            Assert.IsFalse(new nint(-1) == new IntPtr(-2));
            Assert.IsFalse(new nint(-1) == new IntPtr(0));
            Assert.IsFalse(new nint(0) == new IntPtr(-1));
            Assert.IsFalse(new nint(0) == new IntPtr(1));
            Assert.IsFalse(new nint(1) == new IntPtr(0));
            Assert.IsFalse(new nint(1) == new IntPtr(2));
            Assert.IsFalse(new nint(2) == new IntPtr(1));

            Assert.IsTrue(IntPtr.Zero == nint.Zero);
            Assert.IsTrue(new IntPtr(-1) == new nint(-1));
            Assert.IsTrue(new IntPtr(0) == new nint(0));
            Assert.IsTrue(new IntPtr(1) == new nint(1));
            Assert.IsTrue(new IntPtr(int.MaxValue) == new nint(int.MaxValue));
            if (sizeof(long) == sizeof(IntPtr))
            {
                // long -> IntPtr overflows if 32-bit, nint doesn't
                Assert.IsTrue(new IntPtr(long.MaxValue) == (nint)(long.MaxValue));
            }
            Assert.IsFalse(new IntPtr(-2) == new nint(-1));
            Assert.IsFalse(new IntPtr(-1) == new nint(-2));
            Assert.IsFalse(new IntPtr(-1) == new nint(0));
            Assert.IsFalse(new IntPtr(0) == new nint(-1));
            Assert.IsFalse(new IntPtr(0) == new nint(1));
            Assert.IsFalse(new IntPtr(1) == new nint(0));
            Assert.IsFalse(new IntPtr(1) == new nint(2));
            Assert.IsFalse(new IntPtr(2) == new nint(1));
        }

        [TestMethod]
        public void operator_Inequality_nint()
        {
            Assert.IsFalse(nint.Zero != new nint(0));
            Assert.IsFalse(new nint(-1) != new nint(-1));
            Assert.IsFalse(new nint(0) != new nint(0));
            Assert.IsFalse(new nint(1) != new nint(1));
            Assert.IsFalse(new nint(int.MaxValue) != new nint(int.MaxValue));
            Assert.IsFalse((nint)(long.MaxValue) != (nint)(long.MaxValue));

            Assert.IsTrue(new nint(-2) != new nint(-1));
            Assert.IsTrue(new nint(-1) != new nint(-2));
            Assert.IsTrue(new nint(-1) != new nint(0));
            Assert.IsTrue(new nint(0) != new nint(-1));
            Assert.IsTrue(new nint(0) != new nint(1));
            Assert.IsTrue(new nint(1) != new nint(0));
            Assert.IsTrue(new nint(1) != new nint(2));
            Assert.IsTrue(new nint(2) != new nint(1));
        }
        [TestMethod]
        public unsafe void operator_Inequality_int()
        {
            Assert.IsFalse(nint.Zero != 0);
            Assert.IsFalse(new nint(-1) != -1);
            Assert.IsFalse(new nint(0) != 0);
            Assert.IsFalse(new nint(1) != 1);
            Assert.IsFalse(new nint(int.MaxValue) != int.MaxValue);
            Assert.AreEqual(sizeof(int) != sizeof(IntPtr), (nint)(long.MaxValue) != (unchecked((int)long.MaxValue)));
            Assert.IsTrue(new nint(-2) != -1);
            Assert.IsTrue(new nint(-1) != -2);
            Assert.IsTrue(new nint(-1) != 0);
            Assert.IsTrue(new nint(0) != -1);
            Assert.IsTrue(new nint(0) != 1);
            Assert.IsTrue(new nint(1) != 0);
            Assert.IsTrue(new nint(1) != 2);
            Assert.IsTrue(new nint(2) != 1);

            Assert.IsFalse(0 != nint.Zero);
            Assert.IsFalse(-1 != new nint(-1));
            Assert.IsFalse(0 != new nint(0));
            Assert.IsFalse(1 != new nint(1));
            Assert.IsFalse(int.MaxValue != new nint(int.MaxValue));
            Assert.AreEqual(sizeof(int) != sizeof(IntPtr), (unchecked((int)long.MaxValue) != (nint)(long.MaxValue)));
            Assert.IsTrue(-2 != new nint(-1));
            Assert.IsTrue(-1 != new nint(-2));
            Assert.IsTrue(-1 != new nint(0));
            Assert.IsTrue(0 != new nint(-1));
            Assert.IsTrue(0 != new nint(1));
            Assert.IsTrue(1 != new nint(0));
            Assert.IsTrue(1 != new nint(2));
            Assert.IsTrue(2 != new nint(1));
        }
        [TestMethod]
        public unsafe void operator_Inequality_long()
        {
            Assert.IsFalse(nint.Zero != 0L);
            Assert.IsFalse(new nint(-1) != -1L);
            Assert.IsFalse(new nint(0) != 0L);
            Assert.IsFalse(new nint(1) != 1L);
            Assert.AreEqual(sizeof(int) == sizeof(IntPtr), (nint)(long.MaxValue) != long.MaxValue);
            Assert.IsTrue(new nint(-2) != -1L);
            Assert.IsTrue(new nint(-1) != -2L);
            Assert.IsTrue(new nint(-1) != 0L);
            Assert.IsTrue(new nint(0) != -1L);
            Assert.IsTrue(new nint(0) != 1L);
            Assert.IsTrue(new nint(1) != 0L);
            Assert.IsTrue(new nint(1) != 2L);
            Assert.IsTrue(new nint(2) != 1L);

            Assert.IsFalse(0L != nint.Zero);
            Assert.IsFalse(-1L != new nint(-1));
            Assert.IsFalse(0L != new nint(0));
            Assert.IsFalse(1L != new nint(1));
            Assert.AreEqual(sizeof(int) == sizeof(IntPtr), long.MaxValue != (nint)(long.MaxValue));
            Assert.IsTrue(-2L != new nint(-1));
            Assert.IsTrue(-1L != new nint(-2));
            Assert.IsTrue(-1L != new nint(0));
            Assert.IsTrue(0L != new nint(-1));
            Assert.IsTrue(0L != new nint(1));
            Assert.IsTrue(1L != new nint(0));
            Assert.IsTrue(1L != new nint(2));
            Assert.IsTrue(2L != new nint(1));
        }
        [TestMethod]
        public unsafe void operator_Inequality_IntPtr()
        {
            Assert.IsFalse(nint.Zero != IntPtr.Zero);
            Assert.IsFalse(new nint(-1) != new IntPtr(-1));
            Assert.IsFalse(new nint(0) != new IntPtr(0));
            Assert.IsFalse(new nint(1) != new IntPtr(1));
            Assert.IsFalse(new nint(int.MaxValue) != new IntPtr(int.MaxValue));
            if (sizeof(long) == sizeof(IntPtr))
            {
                // long -> IntPtr overflows if 32-bit, nint doesn't
                Assert.IsFalse((nint)(long.MaxValue) != new IntPtr(long.MaxValue));
            }
            Assert.IsTrue(new nint(-2) != new IntPtr(-1));
            Assert.IsTrue(new nint(-1) != new IntPtr(-2));
            Assert.IsTrue(new nint(-1) != new IntPtr(0));
            Assert.IsTrue(new nint(0) != new IntPtr(-1));
            Assert.IsTrue(new nint(0) != new IntPtr(1));
            Assert.IsTrue(new nint(1) != new IntPtr(0));
            Assert.IsTrue(new nint(1) != new IntPtr(2));
            Assert.IsTrue(new nint(2) != new IntPtr(1));

            Assert.IsFalse(IntPtr.Zero != nint.Zero);
            Assert.IsFalse(new IntPtr(-1) != new nint(-1));
            Assert.IsFalse(new IntPtr(0) != new nint(0));
            Assert.IsFalse(new IntPtr(1) != new nint(1));
            Assert.IsFalse(new IntPtr(int.MaxValue) != new nint(int.MaxValue));
            if (sizeof(long) == sizeof(IntPtr))
            {
                // long -> IntPtr overflows if 32-bit, nint doesn't
                Assert.IsFalse(new IntPtr(long.MaxValue) != (nint)(long.MaxValue));
            }
            Assert.IsTrue(new IntPtr(-2) != new nint(-1));
            Assert.IsTrue(new IntPtr(-1) != new nint(-2));
            Assert.IsTrue(new IntPtr(-1) != new nint(0));
            Assert.IsTrue(new IntPtr(0) != new nint(-1));
            Assert.IsTrue(new IntPtr(0) != new nint(1));
            Assert.IsTrue(new IntPtr(1) != new nint(0));
            Assert.IsTrue(new IntPtr(1) != new nint(2));
            Assert.IsTrue(new IntPtr(2) != new nint(1));
        }
    }
}

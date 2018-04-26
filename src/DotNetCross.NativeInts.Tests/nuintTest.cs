using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetCross.NativeInts.TestsFramework
{
    [TestClass]
    public class nuintTest
    {
        [TestMethod]
        public unsafe void TraceSize()
        {
            Trace.WriteLine($"Sizeof {nameof(nuint)}:{sizeof(nuint)}");
            Console.WriteLine($"Sizeof {nameof(nuint)}:{sizeof(nuint)}");
            //Assert.AreEqual(8, sizeof(nuint));
        }

        [TestMethod]
        public void Zero()
        {
            Assert.AreEqual(nuint.Zero.Value, UIntPtr.Zero);
        }

        [TestMethod]
        public void ctor_UIntPtr_0()
        {
            nuint ni = new nuint(UIntPtr.Zero);
            Assert.AreEqual(ni.Value, UIntPtr.Zero);
        }
        [TestMethod]
        public void ctor_UIntPtr_1()
        {
            nuint ni = new nuint(new UIntPtr(1));
            Assert.AreEqual(ni.Value, new UIntPtr(1));
        }

        [TestMethod]
        public void ctor_int_0()
        {
            nuint ni = new nuint(0);
            Assert.AreEqual(ni.Value, new UIntPtr(0));
        }
        [TestMethod]
        public void ctor_int_1()
        {
            nuint ni = new nuint(1);
            Assert.AreEqual(ni.Value, new UIntPtr(1));
        }

        [TestMethod]
        public void implicit_conversion_from_UIntPtr()
        {
            nuint ni = new UIntPtr(42);
            Assert.AreEqual(ni.Value, new UIntPtr(42));
        }
        [TestMethod]
        public void implicit_conversion_from_int()
        {
            nuint ni = 42;
            Assert.AreEqual(ni.Value, new UIntPtr(42));
        }
        [TestMethod]
        public void explicit_conversion_from_long()
        {
            nuint ni = (nuint)42L;
            Assert.AreEqual(ni.Value, new UIntPtr(42L));
        }

        [TestMethod]
        public void implicit_conversion_to_UIntPtr()
        {
            UIntPtr ip = new nuint(42);
            Assert.AreEqual(ip, new UIntPtr(42));
        }
        [TestMethod]
        public void implicit_conversion_to_ulong()
        {
            ulong l = new nuint(42U);
            Assert.AreEqual(l, 42UL);
        }
        [TestMethod]
        public void explicit_conversion_to_uint()
        {
            uint i = (uint)new nuint(42u);
            Assert.AreEqual(i, 42u);
        }

        [TestMethod]
        public void explicit_conversion_to_byte_via_int()
        {
            Assert.AreEqual((byte)new nuint(0), (byte)0);
            Assert.AreEqual((byte)new nuint(42), (byte)42);
            Assert.AreEqual((byte)new nuint(255), byte.MaxValue);
            Assert.AreEqual((byte)new nuint(256), (byte)0);
        }

        [TestMethod]
        public void operator_Increment_Pre()
        {
            var ni = nuint.Zero;
            ++ni;
            Assert.AreEqual(ni, new nuint(1));
        }
        [TestMethod]
        public void operator_Increment_Post()
        {
            var ni = nuint.Zero;
            ni++;
            Assert.AreEqual(ni, new nuint(1));
        }

        [TestMethod]
        public void operator_Decrement_Pre()
        {
            var ni = nuint.Zero + 1;
            --ni;
            Assert.AreEqual(ni, new nuint(0));
        }
        [TestMethod]
        public void operator_Decrement_Post()
        {
            var ni = nuint.Zero + 1;
            ni--;
            Assert.AreEqual(ni, new nuint(0));
        }

        [TestMethod]
        public void operator_UnaryPlus()
        {
            var ni = new nuint(1);
            Assert.AreEqual(+ni, new nuint(1));
        }
        // NOTE: Not available
        //[TestMethod]
        //public void operator_UnaryNegate()
        //{
        //    var ni = new nuint(1);
        //    Assert.AreEqual(-ni, new nuint(-1));
        //}

        [TestMethod]
        public void operator_OnesComplement()
        {
            Assert.AreEqual(~new nuint(1), new nuint(unchecked((uint)-2)));
            Assert.AreEqual(~new nuint(0), new nuint(unchecked((uint)-1)));
            Assert.AreEqual(~new nuint(unchecked((uint)-1)), new nuint(0));
        }

        [TestMethod]
        public void operator_Addition_nuint()
        {
            var ni = new nuint(1);
            Assert.AreEqual(ni + new nuint(1), new nuint(2));
            Assert.AreEqual(new nuint(1) + ni, new nuint(2));
        }
        [TestMethod]
        public void operator_Addition_UIntPtr()
        {
            var ni = new nuint(1);
            Assert.AreEqual(ni + new UIntPtr(1), new nuint(2));
            Assert.AreEqual(new UIntPtr(1) + ni, new nuint(2));
        }
        [TestMethod]
        public void operator_Addition_int()
        {
            var ni = new nuint(1);
            Assert.AreEqual(ni + 1, new nuint(2));
            Assert.AreEqual(1 + ni, new nuint(2));
        }

        [TestMethod]
        public void operator_Subtraction_nuint()
        {
            var ni = new nuint(1);
            Assert.AreEqual(ni - new nuint(1), new nuint(0));
            Assert.AreEqual(new nuint(1) - ni, new nuint(0));
        }
        [TestMethod]
        public void operator_Subtraction_UIntPtr()
        {
            var ni = new nuint(1);
            Assert.AreEqual(ni - new UIntPtr(1), new nuint(0));
            Assert.AreEqual(new UIntPtr(1) - ni, new nuint(0));
        }
        [TestMethod]
        public void operator_Subtraction_int()
        {
            var ni = new nuint(1);
            Assert.AreEqual(ni - 1, new nuint(0));
            Assert.AreEqual(1 - ni, new nuint(0));
        }

        [TestMethod]
        public void operator_Multiply_nuint()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni * new nuint(2), new nuint(14));
        }
        [TestMethod]
        public void operator_Multiply_UIntPtr()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni * new UIntPtr(2), new nuint(14));
        }
        [TestMethod]
        public void operator_Multiply_int()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni * 2, new nuint(14));
        }

        [TestMethod]
        public void operator_Division_nuint()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni / new nuint(2), new nuint(3));
        }
        [TestMethod]
        public void operator_Division_UIntPtr()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni / new UIntPtr(2), new nuint(3));
        }
        [TestMethod]
        public void operator_Division_int()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni / 2, new nuint(3));
        }

        [TestMethod]
        public void operator_Modulus_nuint()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni % new nuint(4), new nuint(3));
        }
        [TestMethod]
        public void operator_Modulus_UIntPtr()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni % new UIntPtr(4), new nuint(3));
        }
        [TestMethod]
        public void operator_Modulus_int()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni % 4, new nuint(3));
        }

        [TestMethod]
        public void operator_ExclusiveOr_nuint()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni ^ new nuint(4), new nuint(3));

        }
        [TestMethod]
        public void operator_ExclusiveOr_UIntPtr()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni ^ new UIntPtr(4), new nuint(3));
        }
        [TestMethod]
        public void operator_ExclusiveOr_int()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni ^ 4, new nuint(3));
        }

        [TestMethod]
        public void operator_BitwiseAnd_nuint()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni & new nuint(12), new nuint(4));
        }
        [TestMethod]
        public void operator_BitwiseAnd_UIntPtr()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni & new UIntPtr(12), new nuint(4));
        }
        [TestMethod]
        public void operator_BitwiseAnd_int()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni & 12, new nuint(4));
        }

        [TestMethod]
        public void operator_BitwiseOr_nuint()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni | new nuint(8), new nuint(15));
        }
        [TestMethod]
        public void operator_BitwiseOr_UIntPtr()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni | new UIntPtr(8), new nuint(15));
        }
        [TestMethod]
        public void operator_BitwiseOr_int()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni | 8, new nuint(15));
        }

        [TestMethod]
        public void operator_LeftShift_nuint()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni << new nuint(2), new nuint(28));
        }
        [TestMethod]
        public void operator_LeftShift_UIntPtr()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni << new UIntPtr(2), new nuint(28));
        }
        [TestMethod]
        public void operator_LeftShift_int()
        {
            var ni = new nuint(7);
            Assert.AreEqual(ni << 2, new nuint(28));
        }

        [TestMethod]
        public void operator_RightShift_nuint()
        {
            var ni = new nuint(28);
            Assert.AreEqual(ni >> new nuint(2), new nuint(7));
        }
        [TestMethod]
        public void operator_RightShift_UIntPtr()
        {
            var ni = new nuint(28);
            Assert.AreEqual(ni >> new UIntPtr(2), new nuint(7));
        }
        [TestMethod]
        public void operator_RightShift_int()
        {
            var ni = new nuint(28);
            Assert.AreEqual(ni >> 2, new nuint(7));
        }

        [TestMethod]
        public void operator_Equality_nuint()
        {
            Assert.IsTrue(nuint.Zero == new nuint(0));
            Assert.IsTrue(new nuint(0) == new nuint(0));
            Assert.IsTrue(new nuint(1) == new nuint(1));
            Assert.IsTrue(new nuint(uint.MaxValue) == new nuint(uint.MaxValue));
            Assert.IsTrue((nuint)(ulong.MaxValue) == (nuint)(ulong.MaxValue));

            Assert.IsFalse(new nuint(0) == new nuint(1));
            Assert.IsFalse(new nuint(1) == new nuint(0));
            Assert.IsFalse(new nuint(1) == new nuint(2));
            Assert.IsFalse(new nuint(2) == new nuint(1));
            Assert.IsFalse(new nuint(uint.MaxValue - 1) == new nuint(uint.MaxValue));
            Assert.IsFalse(new nuint(uint.MaxValue) == new nuint(uint.MaxValue - 1));
        }
        [TestMethod]
        public unsafe void operator_Equality_uint()
        {
            Assert.IsTrue(nuint.Zero == 0u);
            Assert.IsTrue(new nuint(0) == 0u);
            Assert.IsTrue(new nuint(1) == 1u);
            Assert.IsTrue(new nuint(uint.MaxValue) == uint.MaxValue);
            Assert.AreEqual(sizeof(nuint) == sizeof(uint), (nuint)(ulong.MaxValue) == (unchecked((uint)ulong.MaxValue)));
            Assert.IsFalse(new nuint(0) == 1u);
            Assert.IsFalse(new nuint(1) == 0u);
            Assert.IsFalse(new nuint(1) == 2u);
            Assert.IsFalse(new nuint(2) == 1u);

            Assert.IsTrue(0u == nuint.Zero);
            Assert.IsTrue(0u == new nuint(0));
            Assert.IsTrue(1u == new nuint(1));
            Assert.IsTrue(uint.MaxValue == new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(nuint) == sizeof(uint), (unchecked((uint)ulong.MaxValue) == (nuint)(ulong.MaxValue)));
            Assert.IsFalse(0 == new nuint(1));
            Assert.IsFalse(1 == new nuint(0));
            Assert.IsFalse(1 == new nuint(2));
            Assert.IsFalse(2 == new nuint(1));
        }
        [TestMethod]
        public unsafe void operator_Equality_ulong()
        {
            Assert.IsTrue(nuint.Zero == 0UL);
            Assert.IsTrue(new nuint(0) == 0UL);
            Assert.IsTrue(new nuint(1) == 1UL);
            Assert.AreEqual(sizeof(uint) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) == ulong.MaxValue);
            Assert.IsFalse(new nuint(0) == 1UL);
            Assert.IsFalse(new nuint(1) == 0UL);
            Assert.IsFalse(new nuint(1) == 2UL);
            Assert.IsFalse(new nuint(2) == 1UL);

            Assert.IsTrue(0UL == nuint.Zero);
            Assert.IsTrue(0UL == new nuint(0));
            Assert.IsTrue(1UL == new nuint(1));
            Assert.AreEqual(sizeof(uint) != sizeof(UIntPtr), ulong.MaxValue == (nuint)(ulong.MaxValue));
            Assert.IsFalse(0UL == new nuint(1));
            Assert.IsFalse(1UL == new nuint(0));
            Assert.IsFalse(1UL == new nuint(2));
            Assert.IsFalse(2UL == new nuint(1));
        }
        [TestMethod]
        public unsafe void operator_Equality_UIntPtr()
        {
            Assert.IsTrue(nuint.Zero == UIntPtr.Zero);
            Assert.IsTrue(new nuint(0) == new UIntPtr(0));
            Assert.IsTrue(new nuint(1) == new UIntPtr(1));
            Assert.IsTrue(new nuint(uint.MaxValue) == new UIntPtr(uint.MaxValue));
            if (sizeof(ulong) == sizeof(UIntPtr))
            {
                // ulong -> UIntPtr overflows if 32-bit, nuint doesn't
                Assert.IsTrue((nuint)(ulong.MaxValue) == new UIntPtr(ulong.MaxValue));
            }
            Assert.IsFalse(new nuint(0) == new UIntPtr(1));
            Assert.IsFalse(new nuint(1) == new UIntPtr(0));
            Assert.IsFalse(new nuint(1) == new UIntPtr(2));
            Assert.IsFalse(new nuint(2) == new UIntPtr(1));

            Assert.IsTrue(UIntPtr.Zero == nuint.Zero);
            Assert.IsTrue(new UIntPtr(0) == new nuint(0));
            Assert.IsTrue(new UIntPtr(1) == new nuint(1));
            Assert.IsTrue(new UIntPtr(uint.MaxValue) == new nuint(uint.MaxValue));
            if (sizeof(ulong) == sizeof(UIntPtr))
            {
                // ulong -> UIntPtr overflows if 32-bit, nuint doesn't
                Assert.IsTrue(new UIntPtr(ulong.MaxValue) == (nuint)(ulong.MaxValue));
            }
            Assert.IsFalse(new UIntPtr(0) == new nuint(1));
            Assert.IsFalse(new UIntPtr(1) == new nuint(0));
            Assert.IsFalse(new UIntPtr(1) == new nuint(2));
            Assert.IsFalse(new UIntPtr(2) == new nuint(1));
        }

        [TestMethod]
        public void operator_Inequality_nuint()
        {
            Assert.IsFalse(nuint.Zero != new nuint(0));
            Assert.IsFalse(new nuint(0) != new nuint(0));
            Assert.IsFalse(new nuint(1) != new nuint(1));
            Assert.IsFalse(new nuint(uint.MaxValue) != new nuint(uint.MaxValue));
            Assert.IsFalse((nuint)(ulong.MaxValue) != (nuint)(ulong.MaxValue));

            Assert.IsTrue(new nuint(0) != new nuint(1));
            Assert.IsTrue(new nuint(1) != new nuint(0));
            Assert.IsTrue(new nuint(1) != new nuint(2));
            Assert.IsTrue(new nuint(2) != new nuint(1));
        }
        [TestMethod]
        public unsafe void operator_Inequality_uint()
        {
            Assert.IsFalse(nuint.Zero != 0u);
            Assert.IsFalse(new nuint(0) != 0u);
            Assert.IsFalse(new nuint(1) != 1u);
            Assert.IsFalse(new nuint(uint.MaxValue) != uint.MaxValue);
            Assert.AreEqual(sizeof(uint) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) != (unchecked((uint)ulong.MaxValue)));
            Assert.IsTrue(new nuint(0) != 1u);
            Assert.IsTrue(new nuint(1) != 0u);
            Assert.IsTrue(new nuint(1) != 2u);
            Assert.IsTrue(new nuint(2) != 1u);

            Assert.IsFalse(0u != nuint.Zero);
            Assert.IsFalse(0u != new nuint(0));
            Assert.IsFalse(1u != new nuint(1));
            Assert.IsFalse(uint.MaxValue != new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(uint) != sizeof(UIntPtr), (unchecked((uint)ulong.MaxValue) != (nuint)(ulong.MaxValue)));
            Assert.IsTrue(0u != new nuint(1));
            Assert.IsTrue(1u != new nuint(0));
            Assert.IsTrue(1u != new nuint(2));
            Assert.IsTrue(2u != new nuint(1));
        }
        [TestMethod]
        public unsafe void operator_Inequality_ulong()
        {
            Assert.IsFalse(nuint.Zero != 0UL);
            Assert.IsFalse(new nuint(0) != 0UL);
            Assert.IsFalse(new nuint(1) != 1UL);
            Assert.AreEqual(sizeof(uint) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) != ulong.MaxValue);
            Assert.IsTrue(new nuint(0) != 1UL);
            Assert.IsTrue(new nuint(1) != 0UL);
            Assert.IsTrue(new nuint(1) != 2UL);
            Assert.IsTrue(new nuint(2) != 1UL);

            Assert.IsFalse(0UL != nuint.Zero);
            Assert.IsFalse(0UL != new nuint(0));
            Assert.IsFalse(1UL != new nuint(1));
            Assert.AreEqual(sizeof(uint) == sizeof(UIntPtr), ulong.MaxValue != (nuint)(ulong.MaxValue));
            Assert.IsTrue(0UL != new nuint(1));
            Assert.IsTrue(1UL != new nuint(0));
            Assert.IsTrue(1UL != new nuint(2));
            Assert.IsTrue(2UL != new nuint(1));
        }
        [TestMethod]
        public unsafe void operator_Inequality_UIntPtr()
        {
            Assert.IsFalse(nuint.Zero != UIntPtr.Zero);
            Assert.IsFalse(new nuint(0) != new UIntPtr(0));
            Assert.IsFalse(new nuint(1) != new UIntPtr(1));
            Assert.IsFalse(new nuint(uint.MaxValue) != new UIntPtr(uint.MaxValue));
            if (sizeof(ulong) == sizeof(UIntPtr))
            {
                // ulong -> UIntPtr overflows if 32-bit, nuint doesn't
                Assert.IsFalse((nuint)(ulong.MaxValue) != new UIntPtr(ulong.MaxValue));
            }
            Assert.IsTrue(new nuint(0) != new UIntPtr(1));
            Assert.IsTrue(new nuint(1) != new UIntPtr(0));
            Assert.IsTrue(new nuint(1) != new UIntPtr(2));
            Assert.IsTrue(new nuint(2) != new UIntPtr(1));

            Assert.IsFalse(UIntPtr.Zero != nuint.Zero);
            Assert.IsFalse(new UIntPtr(0) != new nuint(0));
            Assert.IsFalse(new UIntPtr(1) != new nuint(1));
            Assert.IsFalse(new UIntPtr(uint.MaxValue) != new nuint(uint.MaxValue));
            if (sizeof(ulong) == sizeof(UIntPtr))
            {
                // ulong -> UIntPtr overflows if 32-bit, nuint doesn't
                Assert.IsFalse(new UIntPtr(ulong.MaxValue) != (nuint)(ulong.MaxValue));
            }
            Assert.IsTrue(new UIntPtr(0) != new nuint(1));
            Assert.IsTrue(new UIntPtr(1) != new nuint(0));
            Assert.IsTrue(new UIntPtr(1) != new nuint(2));
            Assert.IsTrue(new UIntPtr(2) != new nuint(1));
        }


        [TestMethod]
        public void operator_GreaterThan_nuint()
        {
            Assert.IsFalse(nuint.Zero > new nuint(0));
            Assert.IsFalse(new nuint(0) > new nuint(0));
            Assert.IsFalse(new nuint(1) > new nuint(1));
            Assert.IsFalse(new nuint(uint.MaxValue) > new nuint(uint.MaxValue));
            Assert.IsFalse((nuint)(ulong.MaxValue) > (nuint)(ulong.MaxValue));

            Assert.IsFalse(new nuint(0) > new nuint(1));
            Assert.IsFalse(new nuint(1) > new nuint(2));
            Assert.IsFalse((nuint)(uint.MaxValue - 1) > (nuint)(uint.MaxValue));

            Assert.IsTrue(new nuint(1) > new nuint(0));
            Assert.IsTrue(new nuint(2) > new nuint(1));
            Assert.IsTrue((nuint)(uint.MaxValue) > (nuint)(uint.MaxValue - 1));
        }
        [TestMethod]
        public unsafe void operator_GreaterThan_uint()
        {
            // nuint left, uint right
            Assert.IsFalse(nuint.Zero > 0u);
            Assert.IsFalse(new nuint(0) > 0u);
            Assert.IsFalse(new nuint(1) > 1u);
            Assert.IsFalse(new nuint(uint.MaxValue) > uint.MaxValue);

            Assert.IsFalse(new nuint(0) > 1u);
            Assert.IsFalse(new nuint(1) > 2u);
            Assert.IsFalse((nuint)(uint.MaxValue - 1) > uint.MaxValue);

            Assert.IsTrue(new nuint(1) > 0u);
            Assert.IsTrue(new nuint(2) > 1u);
            Assert.IsTrue((nuint)(uint.MaxValue) > uint.MaxValue - 1);

            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) > uint.MaxValue);
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) > uint.MaxValue);

            // uint left, nuint right
            Assert.IsFalse(0u > new nuint(0));
            Assert.IsFalse(0u > new nuint(0));
            Assert.IsFalse(1u > new nuint(1));
            Assert.IsFalse(uint.MaxValue > new nuint(uint.MaxValue));

            Assert.IsFalse(0u > new nuint(1));
            Assert.IsFalse(1u > new nuint(2));
            Assert.IsFalse((uint.MaxValue - 1) > new nuint(uint.MaxValue));

            Assert.IsTrue(1u > new nuint(0));
            Assert.IsTrue(2u > new nuint(1));
            Assert.IsTrue(uint.MaxValue > new nuint(uint.MaxValue - 1));

            Assert.AreEqual(false, uint.MaxValue > (nuint)(ulong.MaxValue));
        }
        [TestMethod]
        public unsafe void operator_GreaterThan_ulong()
        {
            // nuint left, ulong right
            Assert.IsFalse(nuint.Zero > 0UL);
            Assert.IsFalse(new nuint(0) > 0UL);
            Assert.IsFalse(new nuint(1) > 1UL);
            Assert.IsFalse(new nuint(uint.MaxValue) > (ulong)uint.MaxValue);
            Assert.IsFalse((nuint)(ulong.MaxValue) > ulong.MaxValue);

            Assert.IsFalse(new nuint(0) > 1UL);
            Assert.IsFalse(new nuint(1) > 2UL);
            Assert.IsFalse((nuint)(uint.MaxValue - 1) > (ulong)uint.MaxValue);
            Assert.IsFalse((nuint)(ulong.MaxValue - 1) > ulong.MaxValue);

            Assert.IsTrue(new nuint(1) > 0UL);
            Assert.IsTrue(new nuint(2) > 1UL);
            Assert.IsTrue((nuint)(uint.MaxValue) > (ulong)(uint.MaxValue - 1));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) > (ulong.MaxValue - 1));

            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) > (ulong)uint.MaxValue);
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) > (ulong)uint.MaxValue);

            // ulong left, nuint right
            Assert.IsFalse(0UL > new nuint(0));
            Assert.IsFalse(0UL > new nuint(0));
            Assert.IsFalse(1UL > new nuint(1));
            Assert.IsFalse((ulong)uint.MaxValue > new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), ulong.MaxValue > (nuint)(ulong.MaxValue));

            Assert.IsFalse(0UL > new nuint(1));
            Assert.IsFalse(1UL > new nuint(2));
            Assert.IsFalse((ulong)(uint.MaxValue - 1) > new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (ulong.MaxValue - 1) > new nuint(uint.MaxValue));

            Assert.IsTrue(1UL > new nuint(0));
            Assert.IsTrue(2UL > new nuint(1));
            Assert.IsTrue((ulong)uint.MaxValue > new nuint(uint.MaxValue - 1));
            Assert.IsTrue(ulong.MaxValue > (nuint)(ulong.MaxValue - 1));

            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (ulong)uint.MaxValue > (nuint)(ulong.MaxValue));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (ulong)uint.MaxValue > (nuint)(ulong.MaxValue));
        }
        [TestMethod]
        public unsafe void operator_GreaterThan_UIntPtr()
        {
            // nuint left, UIntPtr right
            Assert.IsFalse(nuint.Zero > new UIntPtr(0L));
            Assert.IsFalse(new nuint(0) > new UIntPtr(0));
            Assert.IsFalse(new nuint(1) > new UIntPtr(1));
            Assert.IsFalse(new nuint(uint.MaxValue) > new UIntPtr((ulong)uint.MaxValue));
            if (sizeof(ulong) == sizeof(UIntPtr))
            {
                Assert.IsFalse((nuint)(ulong.MaxValue) > new UIntPtr(ulong.MaxValue));
            }

            Assert.IsFalse(new nuint(0) > new UIntPtr(1));
            Assert.IsFalse(new nuint(1) > new UIntPtr(2));
            Assert.IsFalse((nuint)(uint.MaxValue - 1) > new UIntPtr((ulong)uint.MaxValue));
            if (sizeof(ulong) == sizeof(UIntPtr))
            {
                Assert.IsFalse((nuint)(ulong.MaxValue - 1) > new UIntPtr(ulong.MaxValue));
            }

            Assert.IsTrue(new nuint(1) > new UIntPtr(0));
            Assert.IsTrue(new nuint(2) > new UIntPtr(1));
            Assert.IsTrue((nuint)(uint.MaxValue) > new UIntPtr((ulong)(uint.MaxValue - 1)));
            if (sizeof(ulong) == sizeof(UIntPtr))
            {
                Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) > new UIntPtr((ulong.MaxValue - 1)));
            }

            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) > new UIntPtr((ulong)uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) > new UIntPtr((ulong)uint.MaxValue));

            // UIntPtr left, nuint right
            Assert.IsFalse(new UIntPtr(0) > new nuint(0));
            Assert.IsFalse(new UIntPtr(1) > new nuint(1));
            Assert.IsFalse((ulong)uint.MaxValue > new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), ulong.MaxValue > (nuint)(ulong.MaxValue));

            Assert.IsFalse(new UIntPtr(0) > new nuint(1));
            Assert.IsFalse(new UIntPtr(1) > new nuint(2));
            Assert.IsFalse((ulong)(uint.MaxValue - 1) > new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (ulong.MaxValue - 1) > new nuint(uint.MaxValue));

            Assert.IsTrue(new UIntPtr(1) > new nuint(0));
            Assert.IsTrue(new UIntPtr(2) > new nuint(1));
            Assert.IsTrue((ulong)uint.MaxValue > new nuint(uint.MaxValue - 1));
            Assert.IsTrue(ulong.MaxValue > (nuint)(ulong.MaxValue - 1));

            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (ulong)uint.MaxValue > (nuint)(ulong.MaxValue));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (ulong)uint.MaxValue > (nuint)(ulong.MaxValue));
        }


        [TestMethod]
        public void operator_GreaterThanOrEqual_nuint()
        {
            Assert.IsTrue(nuint.Zero >= new nuint(0));
            Assert.IsTrue(new nuint(0) >= new nuint(0));
            Assert.IsTrue(new nuint(1) >= new nuint(1));
            Assert.IsTrue(new nuint(uint.MaxValue) >= new nuint(uint.MaxValue));
            Assert.IsTrue((nuint)(ulong.MaxValue) >= (nuint)(ulong.MaxValue));

            Assert.IsFalse(new nuint(0) >= new nuint(1));
            Assert.IsFalse(new nuint(1) >= new nuint(2));
            Assert.IsFalse((nuint)(uint.MaxValue - 1) >= (nuint)(uint.MaxValue));

            Assert.IsTrue(new nuint(1) >= new nuint(0));
            Assert.IsTrue(new nuint(2) >= new nuint(1));
            Assert.IsTrue((nuint)(uint.MaxValue) >= (nuint)(uint.MaxValue - 1));
        }
        [TestMethod]
        public unsafe void operator_GreaterThanOrEqual_int()
        {
            // nuint left, uint right
            Assert.IsTrue(nuint.Zero >= 0);
            Assert.IsTrue(new nuint(0) >= 0);
            Assert.IsTrue(new nuint(1) >= 1);
            Assert.IsTrue(new nuint(uint.MaxValue) >= uint.MaxValue);

            Assert.IsFalse(new nuint(0) >= 1);
            Assert.IsFalse(new nuint(1) >= 2);
            Assert.IsFalse((nuint)(uint.MaxValue - 1) >= uint.MaxValue);

            Assert.IsTrue(new nuint(1) >= 0);
            Assert.IsTrue(new nuint(2) >= 1);
            Assert.IsTrue((nuint)(uint.MaxValue) >= uint.MaxValue - 1);

            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) >= uint.MaxValue);
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) >= uint.MaxValue);

            // uint left, nuint right
            Assert.IsTrue(0 >= new nuint(0));
            Assert.IsTrue(0 >= new nuint(0));
            Assert.IsTrue(1 >= new nuint(1));
            Assert.IsTrue(uint.MaxValue >= new nuint(uint.MaxValue));

            Assert.IsFalse(0 >= new nuint(1));
            Assert.IsFalse(1 >= new nuint(2));
            Assert.IsFalse((uint.MaxValue - 1) >= new nuint(uint.MaxValue));

            Assert.IsTrue(1 >= new nuint(0));
            Assert.IsTrue(2 >= new nuint(1));
            Assert.IsTrue(uint.MaxValue >= new nuint(uint.MaxValue - 1));

            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), uint.MaxValue >= (nuint)(ulong.MaxValue));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), uint.MaxValue >= (nuint)(ulong.MaxValue));
        }
        [TestMethod]
        public unsafe void operator_GreaterThanOrEqual_long()
        {
            // nuint left, ulong right
            Assert.IsTrue(nuint.Zero >= 0L);
            Assert.IsTrue(new nuint(0) >= 0L);
            Assert.IsTrue(new nuint(1) >= 1L);
            Assert.IsTrue(new nuint(uint.MaxValue) >= (ulong)uint.MaxValue);
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) >= ulong.MaxValue);

            Assert.IsFalse(new nuint(0) >= 1L);
            Assert.IsFalse(new nuint(1) >= 2L);
            Assert.IsFalse((nuint)(uint.MaxValue - 1) >= (ulong)uint.MaxValue);
            Assert.IsFalse((nuint)(ulong.MaxValue - 1) >= ulong.MaxValue);

            Assert.IsTrue(new nuint(1) >= 0L);
            Assert.IsTrue(new nuint(2) >= 1L);
            Assert.IsTrue((nuint)(uint.MaxValue) >= (ulong)(uint.MaxValue - 1));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) >= (ulong.MaxValue - 1));

            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) >= (ulong)uint.MaxValue);
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) >= (ulong)uint.MaxValue);

            // ulong left, nuint right
            Assert.IsTrue(0L >= new nuint(0));
            Assert.IsTrue(0L >= new nuint(0));
            Assert.IsTrue(1L >= new nuint(1));
            Assert.IsTrue((ulong)uint.MaxValue >= new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), ulong.MaxValue >= (nuint)(ulong.MaxValue));

            Assert.IsFalse(0L >= new nuint(1));
            Assert.IsFalse(1L >= new nuint(2));
            Assert.IsFalse((ulong)(uint.MaxValue - 1) >= new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (ulong.MaxValue - 1) >= new nuint(uint.MaxValue));

            Assert.IsTrue(1L >= new nuint(0));
            Assert.IsTrue(2L >= new nuint(1));
            Assert.IsTrue((ulong)uint.MaxValue >= new nuint(uint.MaxValue - 1));
            Assert.IsTrue(ulong.MaxValue >= (nuint)(ulong.MaxValue - 1));

            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (ulong)uint.MaxValue >= (nuint)(ulong.MaxValue));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (ulong)uint.MaxValue >= (nuint)(ulong.MaxValue));
        }
        [TestMethod]
        public unsafe void operator_GreaterThanOrEqual_UIntPtr()
        {
            // nuint left, UIntPtr right
            Assert.IsTrue(nuint.Zero >= new UIntPtr(0L));
            Assert.IsTrue(new nuint(0) >= new UIntPtr(0));
            Assert.IsTrue(new nuint(1) >= new UIntPtr(1));
            Assert.IsTrue(new nuint(uint.MaxValue) >= new UIntPtr((ulong)uint.MaxValue));
            if (sizeof(ulong) == sizeof(UIntPtr))
            {
                Assert.IsFalse((nuint)(ulong.MaxValue) >= new UIntPtr(ulong.MaxValue));
            }

            Assert.IsFalse(new nuint(0) >= new UIntPtr(1));
            Assert.IsFalse(new nuint(1) >= new UIntPtr(2));
            Assert.IsFalse((nuint)(uint.MaxValue - 1) >= new UIntPtr((ulong)uint.MaxValue));
            if (sizeof(ulong) == sizeof(UIntPtr))
            {
                Assert.IsFalse((nuint)(ulong.MaxValue - 1) >= new UIntPtr(ulong.MaxValue));
            }

            Assert.IsTrue(new nuint(1) >= new UIntPtr(0));
            Assert.IsTrue(new nuint(2) >= new UIntPtr(1));
            Assert.IsTrue((nuint)(uint.MaxValue) >= new UIntPtr((ulong)(uint.MaxValue - 1)));
            if (sizeof(ulong) == sizeof(UIntPtr))
            {
                Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) >= new UIntPtr((ulong.MaxValue - 1)));
            }

            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) >= new UIntPtr((ulong)uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) >= new UIntPtr((ulong)uint.MaxValue));

            // UIntPtr left, nuint right
            Assert.IsTrue(new UIntPtr(0) >= new nuint(0));
            Assert.IsTrue(new UIntPtr(1) >= new nuint(1));
            Assert.IsTrue((ulong)uint.MaxValue >= new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), ulong.MaxValue >= (nuint)(ulong.MaxValue));

            Assert.IsFalse(new UIntPtr(0) >= new nuint(1));
            Assert.IsFalse(new UIntPtr(1) >= new nuint(2));
            Assert.IsFalse((ulong)(uint.MaxValue - 1) >= new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (ulong.MaxValue - 1) >= new nuint(uint.MaxValue));

            Assert.IsTrue(new UIntPtr(1) >= new nuint(0));
            Assert.IsTrue(new UIntPtr(2) >= new nuint(1));
            Assert.IsTrue((ulong)uint.MaxValue >= new nuint(uint.MaxValue - 1));
            Assert.IsTrue(ulong.MaxValue >= (nuint)(ulong.MaxValue - 1));

            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (ulong)uint.MaxValue >= (nuint)(ulong.MaxValue));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (ulong)uint.MaxValue >= (nuint)(ulong.MaxValue));
        }


        [TestMethod]
        public void operator_LessThan_nuint()
        {
            Assert.IsFalse(nuint.Zero < new nuint(0));
            Assert.IsFalse(new nuint(0) < new nuint(0));
            Assert.IsFalse(new nuint(1) < new nuint(1));
            Assert.IsFalse(new nuint(uint.MaxValue) < new nuint(uint.MaxValue));
            Assert.IsFalse((nuint)(ulong.MaxValue) < (nuint)(ulong.MaxValue));

            Assert.IsTrue(new nuint(0) < new nuint(1));
            Assert.IsTrue(new nuint(1) < new nuint(2));
            Assert.IsTrue((nuint)(uint.MaxValue - 1) < (nuint)(uint.MaxValue));

            Assert.IsFalse(new nuint(1) < new nuint(0));
            Assert.IsFalse(new nuint(2) < new nuint(1));
            Assert.IsFalse((nuint)(uint.MaxValue) < (nuint)(uint.MaxValue - 1));
        }
        [TestMethod]
        public unsafe void operator_LessThan_int()
        {
            // nuint left, uint right
            Assert.IsFalse(nuint.Zero < 0);
            Assert.IsFalse(new nuint(0) < 0);
            Assert.IsFalse(new nuint(1) < 1);
            Assert.IsFalse(new nuint(uint.MaxValue) < uint.MaxValue);

            Assert.IsTrue(new nuint(0) < 1);
            Assert.IsTrue(new nuint(1) < 2);
            Assert.IsTrue((nuint)(uint.MaxValue - 1) < uint.MaxValue);

            Assert.IsFalse(new nuint(1) < 0);
            Assert.IsFalse(new nuint(2) < 1);
            Assert.IsFalse((nuint)(uint.MaxValue) < uint.MaxValue - 1);

            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) < uint.MaxValue);
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) < uint.MaxValue);

            // uint left, nuint right
            Assert.IsFalse(0 < new nuint(0));
            Assert.IsFalse(1 < new nuint(1));
            Assert.IsFalse(uint.MaxValue < new nuint(uint.MaxValue));

            Assert.IsTrue(0 < new nuint(1));
            Assert.IsTrue(1 < new nuint(2));
            Assert.IsTrue((uint.MaxValue - 1) < new nuint(uint.MaxValue));

            Assert.IsFalse(1 < new nuint(0));
            Assert.IsFalse(2 < new nuint(1));
            Assert.IsFalse(uint.MaxValue < new nuint(uint.MaxValue - 1));

            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), uint.MaxValue < (nuint)(ulong.MaxValue));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), uint.MaxValue < (nuint)(ulong.MaxValue));
        }
        [TestMethod]
        public unsafe void operator_LessThan_long()
        {
            // nuint left, ulong right
            Assert.IsFalse(nuint.Zero < 0L);
            Assert.IsFalse(new nuint(0) < 0L);
            Assert.IsFalse(new nuint(1) < 1L);
            Assert.IsFalse(new nuint(uint.MaxValue) < (ulong)uint.MaxValue);
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) < ulong.MaxValue);

            Assert.IsTrue(new nuint(0) < 1L);
            Assert.IsTrue(new nuint(1) < 2L);
            Assert.IsTrue((nuint)(uint.MaxValue - 1) < (ulong)uint.MaxValue);
            Assert.IsTrue((nuint)(ulong.MaxValue - 1) < ulong.MaxValue);

            Assert.IsFalse(new nuint(1) < 0L);
            Assert.IsFalse(new nuint(2) < 1L);
            Assert.IsFalse((nuint)(uint.MaxValue) < (ulong)(uint.MaxValue - 1));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) < (ulong.MaxValue - 1));

            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) < (ulong)uint.MaxValue);
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) < (ulong)uint.MaxValue);

            // ulong left, nuint right
            Assert.IsFalse(0L < new nuint(0));
            Assert.IsFalse(1L < new nuint(1));
            Assert.IsFalse((ulong)uint.MaxValue < new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), ulong.MaxValue < (nuint)(ulong.MaxValue));

            Assert.IsTrue(0L < new nuint(1));
            Assert.IsTrue(1L < new nuint(2));
            Assert.IsTrue((ulong)(uint.MaxValue - 1) < new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (ulong.MaxValue - 1) < new nuint(uint.MaxValue));

            Assert.IsFalse(1L < new nuint(0));
            Assert.IsFalse(2L < new nuint(1));
            Assert.IsFalse((ulong)uint.MaxValue < new nuint(uint.MaxValue - 1));
            Assert.IsFalse(ulong.MaxValue < (nuint)(ulong.MaxValue - 1));

            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (ulong)uint.MaxValue < (nuint)(ulong.MaxValue));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (ulong)uint.MaxValue < (nuint)(ulong.MaxValue));
        }
        [TestMethod]
        public unsafe void operator_LessThan_UIntPtr()
        {
            // nuint left, UIntPtr right
            Assert.IsFalse(nuint.Zero < new UIntPtr(0));
            Assert.IsFalse(new nuint(0) < new UIntPtr(0));
            Assert.IsFalse(new nuint(1) < new UIntPtr(1));
            Assert.IsFalse(new nuint(uint.MaxValue) < new UIntPtr((ulong)uint.MaxValue));
            if (sizeof(ulong) == sizeof(UIntPtr))
            {
                Assert.IsTrue((nuint)(ulong.MaxValue) < new UIntPtr(ulong.MaxValue));
            }

            Assert.IsTrue(new nuint(0) < new UIntPtr(1));
            Assert.IsTrue(new nuint(1) < new UIntPtr(2));
            Assert.IsTrue((nuint)(uint.MaxValue - 1) < new UIntPtr((ulong)uint.MaxValue));
            if (sizeof(ulong) == sizeof(UIntPtr))
            {
                Assert.IsTrue((nuint)(ulong.MaxValue - 1) < new UIntPtr(ulong.MaxValue));
            }

            Assert.IsFalse(new nuint(1) < new UIntPtr(0));
            Assert.IsFalse(new nuint(2) < new UIntPtr(1));
            Assert.IsFalse((nuint)(uint.MaxValue) < new UIntPtr((ulong)(uint.MaxValue - 1)));
            if (sizeof(ulong) == sizeof(UIntPtr))
            {
                Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) < new UIntPtr((ulong.MaxValue - 1)));
            }

            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) < new UIntPtr((ulong)uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) < new UIntPtr((ulong)uint.MaxValue));

            // UIntPtr left, nuint right
            Assert.IsFalse(new UIntPtr(0) < new nuint(0));
            Assert.IsFalse(new UIntPtr(1) < new nuint(1));
            Assert.IsFalse((ulong)uint.MaxValue < new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), ulong.MaxValue < (nuint)(ulong.MaxValue));

            Assert.IsTrue(new UIntPtr(0) < new nuint(1));
            Assert.IsTrue(new UIntPtr(1) < new nuint(2));
            Assert.IsTrue((ulong)(uint.MaxValue - 1) < new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (ulong.MaxValue - 1) < new nuint(uint.MaxValue));

            Assert.IsFalse(new UIntPtr(1) < new nuint(0));
            Assert.IsFalse(new UIntPtr(2) < new nuint(1));
            Assert.IsFalse((ulong)uint.MaxValue < new nuint(uint.MaxValue - 1));
            Assert.IsFalse(ulong.MaxValue < (nuint)(ulong.MaxValue - 1));

            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (ulong)uint.MaxValue < (nuint)(ulong.MaxValue));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (ulong)uint.MaxValue < (nuint)(ulong.MaxValue));
        }


        [TestMethod]
        public void operator_LessThanOrEqual_nuint()
        {
            Assert.IsTrue(nuint.Zero <= new nuint(0));
            Assert.IsTrue(new nuint(0) <= new nuint(0));
            Assert.IsTrue(new nuint(1) <= new nuint(1));
            Assert.IsTrue(new nuint(uint.MaxValue) <= new nuint(uint.MaxValue));
            Assert.IsTrue((nuint)(ulong.MaxValue) <= (nuint)(ulong.MaxValue));

            Assert.IsTrue(new nuint(0) <= new nuint(1));
            Assert.IsTrue(new nuint(1) <= new nuint(2));
            Assert.IsTrue((nuint)(uint.MaxValue - 1) <= (nuint)(uint.MaxValue));

            Assert.IsFalse(new nuint(1) <= new nuint(0));
            Assert.IsFalse(new nuint(2) <= new nuint(1));
            Assert.IsFalse((nuint)(uint.MaxValue) <= (nuint)(uint.MaxValue - 1));
        }
        [TestMethod]
        public unsafe void operator_LessThanOrEqual_int()
        {
            // nuint left, uint right
            Assert.IsTrue(nuint.Zero <= 0);
            Assert.IsTrue(new nuint(0) <= 0);
            Assert.IsTrue(new nuint(1) <= 1);
            Assert.IsTrue(new nuint(uint.MaxValue) <= uint.MaxValue);

            Assert.IsTrue(new nuint(0) <= 1);
            Assert.IsTrue(new nuint(1) <= 2);
            Assert.IsTrue((nuint)(uint.MaxValue - 1) <= uint.MaxValue);

            Assert.IsFalse(new nuint(1) <= 0);
            Assert.IsFalse(new nuint(2) <= 1);
            Assert.IsFalse((nuint)(uint.MaxValue) <= uint.MaxValue - 1);

            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) <= uint.MaxValue);
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) <= uint.MaxValue);

            // uint left, nuint right
            Assert.IsTrue(0 <= new nuint(0));
            Assert.IsTrue(1 <= new nuint(1));
            Assert.IsTrue(uint.MaxValue <= new nuint(uint.MaxValue));

            Assert.IsTrue(0 <= new nuint(1));
            Assert.IsTrue(1 <= new nuint(2));
            Assert.IsTrue((uint.MaxValue - 1) <= new nuint(uint.MaxValue));

            Assert.IsFalse(1 <= new nuint(0));
            Assert.IsFalse(2 <= new nuint(1));
            Assert.IsFalse(uint.MaxValue <= new nuint(uint.MaxValue - 1));

            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), uint.MaxValue <= (nuint)(ulong.MaxValue));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), uint.MaxValue <= (nuint)(ulong.MaxValue));
        }
        [TestMethod]
        public unsafe void operator_LessThanOrEqual_long()
        {
            // nuint left, ulong right
            Assert.IsTrue(nuint.Zero <= 0L);
            Assert.IsTrue(new nuint(0) <= 0L);
            Assert.IsTrue(new nuint(1) <= 1L);
            Assert.IsTrue(new nuint(uint.MaxValue) <= (ulong)uint.MaxValue);
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) <= ulong.MaxValue);

            Assert.IsTrue(new nuint(0) <= 1L);
            Assert.IsTrue(new nuint(1) <= 2L);
            Assert.IsTrue((nuint)(uint.MaxValue - 1) <= (ulong)uint.MaxValue);
            Assert.IsTrue((nuint)(ulong.MaxValue - 1) <= ulong.MaxValue);

            Assert.IsFalse(new nuint(1) <= 0L);
            Assert.IsFalse(new nuint(2) <= 1L);
            Assert.IsFalse((nuint)(uint.MaxValue) <= (ulong)(uint.MaxValue - 1));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) <= (ulong.MaxValue - 1));

            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) <= (ulong)uint.MaxValue);
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) <= (ulong)uint.MaxValue);

            // ulong left, nuint right
            Assert.IsTrue(0L <= new nuint(0));
            Assert.IsTrue(1L <= new nuint(1));
            Assert.IsTrue((ulong)uint.MaxValue <= new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), ulong.MaxValue <= (nuint)(ulong.MaxValue));

            Assert.IsTrue(0L <= new nuint(1));
            Assert.IsTrue(1L <= new nuint(2));
            Assert.IsTrue((ulong)(uint.MaxValue - 1) <= new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (ulong.MaxValue - 1) <= new nuint(uint.MaxValue));

            Assert.IsFalse(1L <= new nuint(0));
            Assert.IsFalse(2L <= new nuint(1));
            Assert.IsFalse((ulong)uint.MaxValue <= new nuint(uint.MaxValue - 1));
            Assert.IsFalse(ulong.MaxValue <= (nuint)(ulong.MaxValue - 1));

            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (ulong)uint.MaxValue <= (nuint)(ulong.MaxValue));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (ulong)uint.MaxValue <= (nuint)(ulong.MaxValue));
        }
        [TestMethod]
        public unsafe void operator_LessThanOrEqual_UIntPtr()
        {
            // nuint left, UIntPtr right
            Assert.IsTrue(nuint.Zero <= new UIntPtr(0));
            Assert.IsTrue(new nuint(0) <= new UIntPtr(0));
            Assert.IsTrue(new nuint(1) <= new UIntPtr(1));
            Assert.IsTrue(new nuint(uint.MaxValue) <= new UIntPtr((ulong)uint.MaxValue));
            if (sizeof(ulong) == sizeof(UIntPtr))
            {
                Assert.IsTrue((nuint)(ulong.MaxValue) <= new UIntPtr(ulong.MaxValue));
            }

            Assert.IsTrue(new nuint(0) <= new UIntPtr(1));
            Assert.IsTrue(new nuint(1) <= new UIntPtr(2));
            Assert.IsTrue((nuint)(uint.MaxValue - 1) <= new UIntPtr((ulong)uint.MaxValue));
            if (sizeof(ulong) == sizeof(UIntPtr))
            {
                Assert.IsTrue((nuint)(ulong.MaxValue - 1) <= new UIntPtr(ulong.MaxValue));
            }

            Assert.IsFalse(new nuint(1) <= new UIntPtr(0));
            Assert.IsFalse(new nuint(2) <= new UIntPtr(1));
            Assert.IsFalse((nuint)(uint.MaxValue) <= new UIntPtr((ulong)(uint.MaxValue - 1)));
            if (sizeof(ulong) == sizeof(UIntPtr))
            {
                Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (nuint)(ulong.MaxValue) <= new UIntPtr((ulong.MaxValue - 1)));
            }

            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) <= new UIntPtr((ulong)uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) != sizeof(UIntPtr), (nuint)(ulong.MaxValue) <= new UIntPtr((ulong)uint.MaxValue));

            // UIntPtr left, nuint right
            Assert.IsTrue(new UIntPtr(0) <= new nuint(0));
            Assert.IsTrue(new UIntPtr(1) <= new nuint(1));
            Assert.IsTrue((ulong)uint.MaxValue <= new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), ulong.MaxValue <= (nuint)(ulong.MaxValue));

            Assert.IsTrue(new UIntPtr(0) <= new nuint(1));
            Assert.IsTrue(new UIntPtr(1) <= new nuint(2));
            Assert.IsTrue((ulong)(uint.MaxValue - 1) <= new nuint(uint.MaxValue));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (ulong.MaxValue - 1) <= new nuint(uint.MaxValue));

            Assert.IsFalse(new UIntPtr(1) <= new nuint(0));
            Assert.IsFalse(new UIntPtr(2) <= new nuint(1));
            Assert.IsFalse((ulong)uint.MaxValue <= new nuint(uint.MaxValue - 1));
            Assert.IsFalse(ulong.MaxValue <= (nuint)(ulong.MaxValue - 1));

            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (ulong)uint.MaxValue <= (nuint)(ulong.MaxValue));
            Assert.AreEqual(sizeof(ulong) == sizeof(UIntPtr), (ulong)uint.MaxValue <= (nuint)(ulong.MaxValue));
        }

        [TestMethod]
        public void Equals_nuint()
        {
            Assert.IsTrue(nuint.Zero.Equals(new nuint(0)));
            Assert.IsTrue(new nuint(0).Equals(new nuint(0)));
            Assert.IsTrue(new nuint(1).Equals(new nuint(1)));
            Assert.IsTrue(new nuint(uint.MaxValue).Equals(new nuint(uint.MaxValue)));
            Assert.IsTrue(((nuint)(ulong.MaxValue)).Equals((nuint)(ulong.MaxValue)));

            Assert.IsFalse(new nuint(0).Equals(new nuint(1)));
            Assert.IsFalse(new nuint(1).Equals(new nuint(0)));
            Assert.IsFalse(new nuint(1).Equals(new nuint(2)));
            Assert.IsFalse(new nuint(2).Equals(new nuint(1)));
        }

        [TestMethod]
        public void CompareTo_nuint()
        {
            Assert.AreEqual(0, nuint.Zero.CompareTo(new nuint(0)));
            Assert.AreEqual(0, new nuint(0).CompareTo(new nuint(0)));
            Assert.AreEqual(0, new nuint(1).CompareTo(new nuint(1)));
            Assert.AreEqual(0, new nuint(uint.MaxValue).CompareTo(new nuint(uint.MaxValue)));
            Assert.AreEqual(0, ((nuint)(ulong.MaxValue)).CompareTo((nuint)(ulong.MaxValue)));

            Assert.AreEqual(-1,new nuint(0).CompareTo(new nuint(1)));
            Assert.AreEqual(-1,new nuint(1).CompareTo(new nuint(2)));

            Assert.AreEqual(1, new nuint(1).CompareTo(new nuint(0)));
            Assert.AreEqual(1,new nuint(2).CompareTo(new nuint(1)));
        }

        [TestMethod]
        public void Equals_object_nuint()
        {
            Assert.IsTrue(nuint.Zero.Equals((object)new nuint(0)));
            Assert.IsTrue(new nuint(0).Equals((object)new nuint(0)));
            Assert.IsTrue(new nuint(1).Equals((object)new nuint(1)));
            Assert.IsTrue(new nuint(uint.MaxValue).Equals((object)new nuint(uint.MaxValue)));
            Assert.IsTrue(((nuint)(ulong.MaxValue)).Equals((object)(nuint)(ulong.MaxValue)));

            Assert.IsFalse(new nuint(0).Equals((object)new nuint(1)));
            Assert.IsFalse(new nuint(1).Equals((object)new nuint(0)));
            Assert.IsFalse(new nuint(1).Equals((object)new nuint(2)));
            Assert.IsFalse(new nuint(2).Equals((object)new nuint(1)));
            Assert.IsFalse(new nuint(2).Equals((object)new nuint(1)));

            Assert.IsFalse(new nuint(0).Equals((object)null));
            Assert.IsFalse(new nuint(0).Equals((object)""));
            Assert.IsFalse(new nuint(0).Equals((object)"test"));
        }

        [TestMethod]
        public void GetHashCode_nuint()
        {
            Assert.AreEqual(0, new nuint(0).GetHashCode());
            Assert.AreEqual(1, new nuint(1).GetHashCode());
            Assert.AreEqual(2, new nuint(2).GetHashCode());
            Assert.AreEqual(3, new nuint(3).GetHashCode());
            Assert.AreEqual(4, new nuint(4).GetHashCode());
            Assert.AreEqual(5, new nuint(5).GetHashCode());

            Assert.AreEqual(int.MaxValue, ((UIntPtr)ulong.MaxValue).GetHashCode());
            Assert.AreEqual(int.MaxValue, ((nuint)ulong.MaxValue).GetHashCode());
            Assert.AreEqual(0, ((UIntPtr)ulong.MinValue).GetHashCode());
            Assert.AreEqual(0, ((nuint)ulong.MinValue).GetHashCode());
        }
    }
}

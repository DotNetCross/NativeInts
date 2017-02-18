using System;
using Xunit;

namespace DotNetCross.NativeInts.Tests
{
    public class nintTest
    {
        [Fact]
        public void nintTest_Zero()
        {
            Assert.Equal(nint.Zero.Value, IntPtr.Zero);
        }

        [Fact]
        public void nintTest_ctor_IntPtr_0()
        {
            nint ni = new nint(IntPtr.Zero);
            Assert.Equal(ni.Value, IntPtr.Zero);
        }
        [Fact]
        public void nintTest_ctor_IntPtr_1()
        {
            nint ni = new nint(new IntPtr(1));
            Assert.Equal(ni.Value, new IntPtr(1));
        }

        [Fact]
        public void nintTest_ctor_int_0()
        {
            nint ni = new nint(0);
            Assert.Equal(ni.Value, new IntPtr(0));
        }
        [Fact]
        public void nintTest_ctor_int_1()
        {
            nint ni = new nint(1);
            Assert.Equal(ni.Value, new IntPtr(1));
        }

        [Fact]
        public void nintTest_implicit_conversion_from_IntPtr()
        {
            nint ni = new IntPtr(42);
            Assert.Equal(ni.Value, new IntPtr(42));
        }
        [Fact]
        public void nintTest_implicit_conversion_from_int()
        {
            nint ni = 42;
            Assert.Equal(ni.Value, new IntPtr(42));
        }
        [Fact]
        public void nintTest_explicit_conversion_from_long()
        {
            nint ni = (nint)42L;
            Assert.Equal(ni.Value, new IntPtr(42L));
        }

        [Fact]
        public void nintTest_operator_Increment_Pre()
        {
            var ni = nint.Zero;
            ++ni;
            Assert.Equal(ni, new nint(1));
        }
        [Fact]
        public void nintTest_operator_Increment_Post()
        {
            var ni = nint.Zero;
            ni++;
            Assert.Equal(ni, new nint(1));
        }
    }
}

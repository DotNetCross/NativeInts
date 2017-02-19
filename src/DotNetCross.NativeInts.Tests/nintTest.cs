using System;
using Xunit;

namespace DotNetCross.NativeInts.Tests
{
    public class nintTest
    {
        [Fact]
        public void Zero()
        {
            Assert.Equal(nint.Zero.Value, IntPtr.Zero);
        }

        [Fact]
        public void ctor_IntPtr_0()
        {
            nint ni = new nint(IntPtr.Zero);
            Assert.Equal(ni.Value, IntPtr.Zero);
        }
        [Fact]
        public void ctor_IntPtr_1()
        {
            nint ni = new nint(new IntPtr(1));
            Assert.Equal(ni.Value, new IntPtr(1));
        }

        [Fact]
        public void ctor_int_0()
        {
            nint ni = new nint(0);
            Assert.Equal(ni.Value, new IntPtr(0));
        }
        [Fact]
        public void ctor_int_1()
        {
            nint ni = new nint(1);
            Assert.Equal(ni.Value, new IntPtr(1));
        }

        [Fact]
        public void implicit_conversion_from_IntPtr()
        {
            nint ni = new IntPtr(42);
            Assert.Equal(ni.Value, new IntPtr(42));
        }
        [Fact]
        public void implicit_conversion_from_int()
        {
            nint ni = 42;
            Assert.Equal(ni.Value, new IntPtr(42));
        }
        [Fact]
        public void explicit_conversion_from_long()
        {
            nint ni = (nint)42L;
            Assert.Equal(ni.Value, new IntPtr(42L));
        }

        [Fact]
        public void implicit_conversion_to_IntPtr()
        {
            IntPtr ip = new nint(42);
            Assert.Equal(ip, new IntPtr(42));
        }
        [Fact]
        public void implicit_conversion_to_long()
        {
            long l = new nint(42);
            Assert.Equal(l, 42L);
        }
        [Fact]
        public void explicit_conversion_to_int()
        {
            int i = (int)new nint(42);
            Assert.Equal(i, 42);
        }

        [Fact]
        public void operator_Increment_Pre()
        {
            var ni = nint.Zero;
            ++ni;
            Assert.Equal(ni, new nint(1));
        }
        [Fact]
        public void operator_Increment_Post()
        {
            var ni = nint.Zero;
            ni++;
            Assert.Equal(ni, new nint(1));
        }

        [Fact]
        public void operator_Decrement_Pre()
        {
            var ni = nint.Zero;
            --ni;
            Assert.Equal(ni, new nint(-1));
        }
        [Fact]
        public void operator_Decrement_Post()
        {
            var ni = nint.Zero;
            ni--;
            Assert.Equal(ni, new nint(-1));
        }

        [Fact]
        public void operator_UnaryPlus()
        {
            var ni = new nint(1);
            Assert.Equal(+ni, new nint(1));
        }
        [Fact]
        public void operator_UnaryNegate()
        {
            var ni = new nint(1);
            Assert.Equal(-ni, new nint(-1));
        }
    }
}

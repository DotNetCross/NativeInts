using System;
using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace DotNetCross.NativeInts.Tests
{
    public class nintTest
    {
        private const string NotAvailable = "This feature not available for nint";

        private readonly ITestOutputHelper _output;

        public nintTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public unsafe void TraceSize()
        {
            _output.WriteLine($"Sizeof {nameof(nint)}:{sizeof(nint)}");
        }

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
        public void explicit_conversion_to_byte_via_int()
        {
            Assert.Equal((byte)new nint(0), (byte)0);
            Assert.Equal((byte)new nint(42), (byte)42);
            Assert.Equal((byte)new nint(255), byte.MaxValue);
            Assert.Equal((byte)new nint(256), (byte)0);
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

        [Fact]
        public void operator_OnesComplement()
        {
            Assert.Equal(~new nint(1), new nint(-2));
            Assert.Equal(~new nint(0), new nint(-1));
            Assert.Equal(~new nint(-1), new nint(0));
        }

        [Fact]
        public void operator_Addition_nint()
        {
            var ni = new nint(1);
            Assert.Equal(ni + new nint(1), new nint(2));
            Assert.Equal(new nint(1) + ni, new nint(2));
        }
        [Fact]
        public void operator_Addition_IntPtr()
        {
            var ni = new nint(1);
            Assert.Equal(ni + new IntPtr(1), new nint(2));
            Assert.Equal(new IntPtr(1) + ni, new nint(2));
        }
        [Fact]
        public void operator_Addition_int()
        {
            var ni = new nint(1);
            Assert.Equal(ni + 1, new nint(2));
            Assert.Equal(1 + ni, new nint(2));
        }

        [Fact]
        public void operator_Subtraction_nint()
        {
            var ni = new nint(1);
            Assert.Equal(ni - new nint(1), new nint(0));
            Assert.Equal(new nint(1) - ni, new nint(0));
        }
        [Fact]
        public void operator_Subtraction_IntPtr()
        {
            var ni = new nint(1);
            Assert.Equal(ni - new IntPtr(1), new nint(0));
            Assert.Equal(new IntPtr(1) - ni, new nint(0));
        }
        [Fact]
        public void operator_Subtraction_int()
        {
            var ni = new nint(1);
            Assert.Equal(ni - 1, new nint(0));
            Assert.Equal(1 - ni, new nint(0));
        }

        [Fact]
        public void operator_Multiply_nint()
        {
            var ni = new nint(7);
            Assert.Equal(ni * new nint(2), new nint(14));
        }
        [Fact]
        public void operator_Multiply_IntPtr()
        {
            var ni = new nint(7);
            Assert.Equal(ni * new IntPtr(2), new nint(14));
        }
        [Fact]
        public void operator_Multiply_int()
        {
            var ni = new nint(7);
            Assert.Equal(ni * 2, new nint(14));
        }

        [Fact]
        public void operator_Division_nint()
        {
            var ni = new nint(7);
            Assert.Equal(ni / new nint(2), new nint(3));
        }
        [Fact]
        public void operator_Division_IntPtr()
        {
            var ni = new nint(7);
            Assert.Equal(ni / new IntPtr(2), new nint(3));
        }
        [Fact]
        public void operator_Division_int()
        {
            var ni = new nint(7);
            Assert.Equal(ni / 2, new nint(3));
        }
    }
}

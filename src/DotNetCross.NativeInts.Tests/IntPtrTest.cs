using System;
using Xunit;

namespace DotNetCross.NativeInts.Tests
{
    public class IntPtrTest
    {
        private const string NotAvailable = "This feature not available for IntPtr";

        [Fact]
        public void Zero()
        {
            Assert.Equal(IntPtr.Zero, IntPtr.Zero);
        }

        [Fact]
        public void ctor_IntPtr_0()
        {
            IntPtr ip = new IntPtr(0);
            Assert.Equal(ip, IntPtr.Zero);
        }
        [Fact]
        public void ctor_IntPtr_1()
        {
            IntPtr ip = new IntPtr(1);
            Assert.Equal(ip, new IntPtr(1));
        }

        [Fact]
        public void ctor_int_0()
        {
            IntPtr ip = new IntPtr(0);
            Assert.Equal(ip, new IntPtr(0));
        }
        [Fact]
        public void ctor_int_1()
        {
            IntPtr ip = new IntPtr(1);
            Assert.Equal(ip, new IntPtr(1));
        }

        [Fact(Skip = NotAvailable)]
        public void implicit_conversion_from_int()
        {
            //IntPtr ip = 42;
            //Assert.Equal(ip, new IntPtr(42));
        }
        [Fact]
        public void explicit_conversion_from_long()
        {
            IntPtr ip = (IntPtr)42L;
            Assert.Equal(ip, new IntPtr(42L));
        }
        
        [Fact(Skip = NotAvailable)]
        public void operator_Increment()
        {
            //var ip = IntPtr.Zero;
            //++ip;
            //Assert.Equal(ip, new IntPtr(1));
        }
        [Fact(Skip = NotAvailable)]
        public void operator_Decrement()
        {
            //var ip = IntPtr.Zero;
            //--ip;
            //Assert.Equal(ip, new IntPtr(1));
        }
        [Fact(Skip = NotAvailable)]
        public void operator_UnaryPlus()
        {
            //var ip = new IntPtr(1);
            //Assert.Equal(+ip, new IntPtr(1));
        }
        [Fact(Skip = NotAvailable)]
        public void operator_UnaryNegate()
        {
            //var ip = new IntPtr(1);
            //Assert.Equal(-ip, new IntPtr(-1));
        }

        [Fact(Skip = NotAvailable)]
        public void operator_OnesComplement()
        {
            //Assert.Equal(~new IntPtr(1), new IntPtr(-2));
            //Assert.Equal(~new IntPtr(0), new IntPtr(-1));
            //Assert.Equal(~new IntPtr(-1), new IntPtr(0));
        }

        [Fact(Skip = NotAvailable)]
        public void operator_Addition_IntPtr()
        {
            //var ip = new IntPtr(1);
            //Assert.Equal(ip + new IntPtr(1), new IntPtr(2));
            //Assert.Equal(new IntPtr(1) + ip, new IntPtr(2));
        }
        [Fact]
        public void operator_Addition_int()
        {
            var ip = new IntPtr(1);
            Assert.Equal(ip + 1, new IntPtr(2));
            // Below not available
            //Assert.Equal(1 + ip, new IntPtr(2));
        }
        [Fact(Skip = NotAvailable)]
        public void operator_Addition_uint()
        {
            //var ip = new IntPtr(1);
            //Assert.Equal(ip + 1u, new IntPtr(2));
            //Assert.Equal(1u + ip, new IntPtr(2));
        }

        [Fact(Skip = NotAvailable)]
        public void operator_Subtraction_IntPtr()
        {
            //var ip = new IntPtr(1);
            //Assert.Equal(ip - new IntPtr(1), new IntPtr(0));
            //Assert.Equal(new IntPtr(1) - ip, new IntPtr(0));
        }
        [Fact]
        public void operator_Subtraction_int()
        {
            var ip = new IntPtr(1);
            Assert.Equal(ip - 1, new IntPtr(0));
            // Below not available
            //Assert.Equal(1 - ip, new IntPtr(0));
        }
        [Fact(Skip = NotAvailable)]
        public void operator_Subtraction_uint()
        {
            //var ip = new IntPtr(1);
            //Assert.Equal(ip - 1u, new IntPtr(0));
            //Assert.Equal(1u - ip, new IntPtr(0));
        }

        [Fact(Skip = NotAvailable)]
        public void operator_Multiply_IntPtr()
        {
            //var ip = new IntPtr(7);
            //Assert.Equal(ip * new IntPtr(2), new IntPtr(14));
        }
        [Fact(Skip = NotAvailable)]
        public void operator_Multiply_int()
        {
            //var ip = new IntPtr(7);
            //Assert.Equal(ip * 2, new IntPtr(14));
        }

        [Fact(Skip = NotAvailable)]
        public void operator_Division_IntPtr()
        {
            //var ip = new IntPtr(7);
            //Assert.Equal(ip / new IntPtr(2), new IntPtr(3));
        }
        [Fact(Skip = NotAvailable)]
        public void operator_Division_int()
        {
            //var ip = new IntPtr(7);
            //Assert.Equal(ip / 2, new IntPtr(3));
        }
    }
}

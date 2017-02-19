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
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DotNetCross.NativeInts.Tests
{
    public class UIntPtrTest
    {
        private const string NotAvailable = "This feature not available for UIntPtr";

        [Fact(Skip = NotAvailable)]
        public void operator_Addition_IntPtr()
        {
            //var ip = new UIntPtr(1);
            //Assert.Equal(ip + new UIntPtr(1), new UIntPtr(2));
            //Assert.Equal(new UIntPtr(1) + ip, new UIntPtr(2));
        }
        [Fact]
        public void operator_Addition_int()
        {
            var ip = new UIntPtr(1);
            Assert.Equal(ip + 1, new UIntPtr(2));
            // Below not available
            //Assert.Equal(1 + ip, new UIntPtr(2));
        }
        [Fact(Skip = NotAvailable)]
        public void operator_Addition_uint()
        {
            //var ip = new UIntPtr(1);
            //Assert.Equal(ip + 1u, new UIntPtr(2));
            //Assert.Equal(1u + ip, new UIntPtr(2));
        }

        [Fact(Skip = NotAvailable)]
        public void operator_Subtraction_UIntPtr()
        {
            //var ip = new UIntPtr(1);
            //Assert.Equal(ip - new UIntPtr(1), new UIntPtr(0));
            //Assert.Equal(new UIntPtr(1) - ip, new UIntPtr(0));
        }
        [Fact]
        public void operator_Subtraction_int()
        {
            var ip = new UIntPtr(1);
            Assert.Equal(ip - 1, new UIntPtr(0));
            // Below not available
            //Assert.Equal(1 - ip, new UIntPtr(0));
        }
        [Fact(Skip = NotAvailable)]
        public void operator_Subtraction_uint()
        {
            //var ip = new UIntPtr(1);
            //Assert.Equal(ip - 1u, new UIntPtr(0));
            //Assert.Equal(1u - ip, new UIntPtr(0));
        }

        [Fact]
        public void operator_AdditionAssignment()
        {
            var ip = new UIntPtr(7);
            ip += 1;
            Assert.Equal(ip, new UIntPtr(8));
        }
        [Fact]
        public void operator_SubtractionAssignment()
        {
            var ip = new UIntPtr(7);
            ip -= 1;
            Assert.Equal(ip, new UIntPtr(6));
        }
    }
}

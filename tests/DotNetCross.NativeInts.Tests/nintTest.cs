using System;
using Xunit;

namespace DotNetCross.NativeInts.Tests
{
    public class nintTest
    {
        [Fact]
        public void nintTest_ctor_()
        {
            nint ni = new nint(IntPtr.Zero);
        }
    }
}

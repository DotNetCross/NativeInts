using System;

namespace DotNetCross.NativeInts
{
    public struct nint
    {
        private static readonly bool Is32Bit = CheckIs32Bit();
        private static unsafe bool CheckIs32Bit()
        {
            return sizeof(IntPtr) == sizeof(int);
        }

        public IntPtr Value;

        public nint(IntPtr value)
        {
            Value = value;
        }
        public nint(int value)
        {
            Value = new IntPtr(value);
        }
        // Add or not? Rather be sure this is only done via explicit cast
        private nint(long value)
        {
            Value = new IntPtr(value);
        }

        // To nint
        public static implicit operator nint(IntPtr value) => new nint(value);
        public static implicit operator nint(int value) => new nint(value);
        public static explicit operator nint(long value) => new nint(value);
        // From nint
        public static implicit operator IntPtr(nint value) => value.Value;
        public static implicit operator long(nint value) => (long)value.Value;
        public static explicit operator int(nint value) => (int)value.Value;

        //
        // Unary
        //
        public static nint operator ++(nint value) => new nint(value.Value + 1);
        public static nint operator --(nint value) => new nint(value.Value - 1);

        public static nint operator +(nint value) => value;
        public static nint operator -(nint value)
        {
            return Is32Bit ? new nint(-(int)value.Value)
                           : new nint(-(long)value.Value);
        }

        public unsafe static nint operator ~(nint value)
        {
            return Is32Bit ? new nint(~(int)value.Value)
                           : new nint(~(long)value.Value);
        }

        //
        // Binary
        //
        public unsafe static nint operator +(nint l, nint r)
        {
            return Is32Bit ? new nint((int)l.Value + (int)r.Value)
                           : new nint((long)l.Value + (long)r.Value);
        }
        public unsafe static nint operator +(nint l, int r)
        {
            return l.Value + r;
        }
        public unsafe static nint operator +(int l, nint r)
        {
            return r.Value + l;
        }

        public unsafe static nint operator -(nint l, nint r)
        {
            return Is32Bit ? new nint((int)l.Value - (int)r.Value)
                           : new nint((long)l.Value - (long)r.Value);
        }
        public unsafe static nint operator -(nint l, int r)
        {
            return l.Value - r;
        }
        public unsafe static nint operator -(int l, nint r)
        {
            return r.Value - l;
        }

        public unsafe static nint operator *(nint l, nint r)
        {
            return Is32Bit ? new nint((int)l.Value * (int)r.Value)
                           : new nint((long)l.Value * (long)r.Value);
        }
        public unsafe static nint operator *(nint l, int r)
        {
            return Is32Bit ? new nint((int)l.Value * r)
                           : new nint((long)l.Value * r);
        }

        public unsafe static nint operator /(nint l, nint r)
        {
            return Is32Bit ? new nint((int)l.Value / (int)r.Value)
                           : new nint((long)l.Value / (long)r.Value);
        }
        public unsafe static nint operator /(nint l, int r)
        {
            return Is32Bit ? new nint((int)l.Value / r)
                           : new nint((long)l.Value / r);
        }

        public unsafe static nint operator %(nint l, nint r)
        {
            return Is32Bit ? new nint((int)l.Value % (int)r.Value)
                           : new nint((long)l.Value % (long)r.Value);
        }
        public unsafe static nint operator %(nint l, int r)
        {
            return Is32Bit ? new nint((int)l.Value % r)
                           : new nint((long)l.Value % r);
        }

        public unsafe static nint operator &(nint l, nint r)
        {
            return Is32Bit ? new nint((int)l.Value & (int)r.Value)
                           : new nint((long)l.Value & (long)r.Value);
        }


    }
}

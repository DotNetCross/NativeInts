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

        public unsafe static nint operator ^(nint l, nint r)
        {
            return Is32Bit ? new nint((int)l.Value ^ (int)r.Value)
                           : new nint((long)l.Value ^ (long)r.Value);
        }
        public unsafe static nint operator ^(nint l, int r)
        {
            return Is32Bit ? new nint((int)l.Value ^ r)
                           : new nint((long)l.Value ^ (long)r);
        }

        public unsafe static nint operator &(nint l, nint r)
        {
            return Is32Bit ? new nint((int)l.Value & (int)r.Value)
                           : new nint((long)l.Value & (long)r.Value);
        }
        public unsafe static nint operator &(nint l, int r)
        {
            return Is32Bit ? new nint((int)l.Value & r)
                           : new nint((long)l.Value & (long)r);
        }

        public unsafe static nint operator |(nint l, nint r)
        {
            return Is32Bit ? new nint((int)l.Value | (int)r.Value)
                           : new nint((long)l.Value | (long)r.Value);
        }
        public unsafe static nint operator |(nint l, int r)
        {
            return Is32Bit ? new nint((int)l.Value | r)
                           : new nint((long)l.Value | (long)r);
        }

        // <<(nint l, nint r) overload not allowed in C#

        public unsafe static nint operator <<(nint l, int r)
        {
            return Is32Bit ? new nint((int)l.Value << r)
                           : new nint((long)l.Value << r);
        }

        // >>(nint l, nint r) overload not allowed in C#

        public unsafe static nint operator >>(nint l, int r)
        {
            return Is32Bit ? new nint((int)l.Value >> r)
                           : new nint((long)l.Value >> r);
        }

        public unsafe static bool operator ==(nint l, nint r)
        {
            return l.Value == r.Value;
        }
        public unsafe static bool operator ==(nint l, int r)
        {
            return Is32Bit ? (int)l.Value == r
                           : (long)l.Value == r;
        }
        public unsafe static bool operator ==(int l, nint r)
        {
            return Is32Bit ? l == (int)r.Value
                           : l == (long)r.Value;
        }
        public unsafe static bool operator ==(nint l, long r)
        {
            return Is32Bit ? (int)l.Value == r
                           : (long)l.Value == r;
        }
        public unsafe static bool operator ==(long l, nint r)
        {
            return Is32Bit ? l == (int)r.Value
                           : l == (long)r.Value;
        }
        public unsafe static bool operator ==(nint l, IntPtr r)
        {
            return l.Value == r;
        }
        public unsafe static bool operator ==(IntPtr l, nint r)
        {
            return l == r.Value;
        }

        public unsafe static bool operator !=(nint l, nint r)
        {
            return l.Value != r.Value;
        }
        public unsafe static bool operator !=(nint l, int r)
        {
            return Is32Bit ? (int)l.Value != r
                           : (long)l.Value != r;
        }
        public unsafe static bool operator !=(int l, nint r)
        {
            return Is32Bit ? l != (int)r.Value
                           : l != (long)r.Value;
        }
        public unsafe static bool operator !=(nint l, long r)
        {
            return Is32Bit ? (int)l.Value != r
                           : (long)l.Value != r;
        }
        public unsafe static bool operator !=(long l, nint r)
        {
            return Is32Bit ? l != (int)r.Value
                           : l != (long)r.Value;
        }
        public unsafe static bool operator !=(nint l, IntPtr r)
        {
            return l.Value != r;
        }
        public unsafe static bool operator !=(IntPtr l, nint r)
        {
            return l != r.Value;
        }

        public unsafe static bool operator >(nint l, nint r)
        {
            return Is32Bit ? (int)l.Value > (int)r.Value
                           : (long)l.Value > (long)r.Value;
        }
        public unsafe static bool operator >(nint l, int r)
        {
            return Is32Bit ? (int)l.Value > r
                           : (long)l.Value > r;
        }
        public unsafe static bool operator >(int l, nint r)
        {
            return Is32Bit ? l > (int)r.Value
                           : l > (long)r.Value;
        }
        public unsafe static bool operator >(nint l, long r)
        {
            return Is32Bit ? (int)l.Value > r
                           : (long)l.Value > r;
        }
        public unsafe static bool operator >(long l, nint r)
        {
            return Is32Bit ? l > (int)r.Value
                           : l > (long)r.Value;
        }
        public unsafe static bool operator >(nint l, IntPtr r)
        {
            return Is32Bit ? (int)l.Value > (int)r
                           : (long)l.Value > (long)r;
        }
        public unsafe static bool operator >(IntPtr l, nint r)
        {
            return Is32Bit ? (int)l > (int)r.Value
                           : (long)l > (long)r.Value;
        }

        public unsafe static bool operator <(nint l, nint r)
        {
            return Is32Bit ? (int)l.Value < (int)r.Value
                           : (long)l.Value < (long)r.Value;
        }
        public unsafe static bool operator <(nint l, int r)
        {
            return Is32Bit ? (int)l.Value < r
                           : (long)l.Value < r;
        }
        public unsafe static bool operator <(int l, nint r)
        {
            return Is32Bit ? l < (int)r.Value
                           : l < (long)r.Value;
        }
        public unsafe static bool operator <(nint l, long r)
        {
            return Is32Bit ? (int)l.Value < r
                           : (long)l.Value < r;
        }
        public unsafe static bool operator <(long l, nint r)
        {
            return Is32Bit ? l < (int)r.Value
                           : l < (long)r.Value;
        }
        public unsafe static bool operator <(nint l, IntPtr r)
        {
            return Is32Bit ? (int)l.Value < (int)r
                           : (long)l.Value < (long)r;
        }
        public unsafe static bool operator <(IntPtr l, nint r)
        {
            return Is32Bit ? (int)l < (int)r.Value
                           : (long)l < (long)r.Value;
        }

        public unsafe static bool operator >=(nint l, nint r)
        {
            return Is32Bit ? (int)l.Value >= (int)r.Value
                           : (long)l.Value >= (long)r.Value;
        }
        public unsafe static bool operator >=(nint l, int r)
        {
            return Is32Bit ? (int)l.Value >= r
                           : (long)l.Value >= r;
        }
        public unsafe static bool operator >=(int l, nint r)
        {
            return Is32Bit ? l >= (int)r.Value
                           : l >= (long)r.Value;
        }
        public unsafe static bool operator >=(nint l, long r)
        {
            return Is32Bit ? (int)l.Value >= r
                           : (long)l.Value >= r;
        }
        public unsafe static bool operator >=(long l, nint r)
        {
            return Is32Bit ? l >= (int)r.Value
                           : l >= (long)r.Value;
        }
        public unsafe static bool operator >=(nint l, IntPtr r)
        {
            return Is32Bit ? (int)l.Value >= (int)r
                           : (long)l.Value >= (long)r;
        }
        public unsafe static bool operator >=(IntPtr l, nint r)
        {
            return Is32Bit ? (int)l >= (int)r.Value
                           : (long)l >= (long)r.Value;
        }

        public unsafe static bool operator <=(nint l, nint r)
        {
            return Is32Bit ? (int)l.Value <= (int)r.Value
                           : (long)l.Value <= (long)r.Value;
        }
        public unsafe static bool operator <=(nint l, int r)
        {
            return Is32Bit ? (int)l.Value <= r
                           : (long)l.Value <= r;
        }
        public unsafe static bool operator <=(int l, nint r)
        {
            return Is32Bit ? l <= (int)r.Value
                           : l <= (long)r.Value;
        }
        public unsafe static bool operator <=(nint l, long r)
        {
            return Is32Bit ? (int)l.Value <= r
                           : (long)l.Value <= r;
        }
        public unsafe static bool operator <=(long l, nint r)
        {
            return Is32Bit ? l <= (int)r.Value
                           : l <= (long)r.Value;
        }
        public unsafe static bool operator <=(nint l, IntPtr r)
        {
            return Is32Bit ? (int)l.Value <= (int)r
                           : (long)l.Value <= (long)r;
        }
        public unsafe static bool operator <=(IntPtr l, nint r)
        {
            return Is32Bit ? (int)l <= (int)r.Value
                           : (long)l <= (long)r.Value;
        }

        public override bool Equals(object obj)
        {
            if (obj is nint)
            {
                return (Value == ((nint)obj).Value);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}

using System;

namespace DotNetCross.NativeInts
{
    public struct nuint
    {
        public UIntPtr Value;

        public nuint(UIntPtr value)
        {
            Value = value;
        }
        public nuint(uint value)
        {
            Value = new UIntPtr(value);
        }
        // Add or not? Rather be sure this is only done via explicit cast
        private nuint(ulong value)
        {
            Value = new UIntPtr(value);
        }

        // To nuint
        public static implicit operator nuint(UIntPtr value) => new nuint(value);
        public static implicit operator nuint(uint value) => new nuint(value);
        public static explicit operator nuint(ulong value) => new nuint(value);
        // From nuint
        public static implicit operator UIntPtr(nuint value) => value.Value;
        public static implicit operator ulong(nuint value) => (ulong)value.Value;
        public static explicit operator uint(nuint value) => (uint)value.Value;

        //
        // Unary
        //
        public static nuint operator ++(nuint value) => new nuint(value.Value + 1);
        public static nuint operator --(nuint value) => new nuint(value.Value - 1);

        public static nuint operator +(nuint value) => value;
        //public static nuint operator -(nuint value)
        //{
        //    return Is32Bit ? new nuint(-(uint)value.Value)
        //                   : new nuint(-(ulong)value.Value);
        //}

        public unsafe static nuint operator ~(nuint value)
        {
            return Is32Bit ? new nuint(~(uint)value.Value)
                           : new nuint(~(ulong)value.Value);
        }

        //
        // Binary
        //
        public unsafe static nuint operator +(nuint l, nuint r)
        {
            return Is32Bit ? new nuint((uint)l.Value + (uint)r.Value)
                           : new nuint((ulong)l.Value + (ulong)r.Value);
        }
        // UIntPtr does not support add/subtract uint
        public unsafe static nuint operator +(nuint l, uint r)
        {
            return Is32Bit ? new nuint((uint)l.Value + r)
                           : new nuint((ulong)l.Value + r);
        }
        public unsafe static nuint operator +(uint l, nuint r)
        {
            return Is32Bit ? new nuint(l + (uint)r.Value)
                           : new nuint(l + (ulong)r.Value);
        }
        // UIntPtr supports add/subtract int
        public unsafe static nuint operator +(nuint l, int r)
        {
            return l.Value + r;
        }
        public unsafe static nuint operator +(int l, nuint r)
        {
            return r.Value + l;
        }

        public unsafe static nuint operator -(nuint l, nuint r)
        {
            return Is32Bit ? new nuint((uint)l.Value - (uint)r.Value)
                           : new nuint((ulong)l.Value - (ulong)r.Value);
        }
        // UIntPtr does not support add/subtract uint
        public unsafe static nuint operator -(nuint l, uint r)
        {
            return Is32Bit ? new nuint((uint)l.Value - r)
                           : new nuint((ulong)l.Value - r);
        }
        public unsafe static nuint operator -(uint l, nuint r)
        {
            return Is32Bit ? new nuint(l - (uint)r.Value)
                           : new nuint(l - (ulong)r.Value);
        }
        // UIntPtr supports add/subtract int
        public unsafe static nuint operator -(nuint l, int r)
        {
            return l.Value - r;
        }
        public unsafe static nuint operator -(int l, nuint r)
        {
            return r.Value - l;
        }

        public unsafe static nuint operator *(nuint l, nuint r)
        {
            return Is32Bit ? new nuint((uint)l.Value * (uint)r.Value)
                           : new nuint((ulong)l.Value * (ulong)r.Value);
        }
        public unsafe static nuint operator *(nuint l, uint r)
        {
            return Is32Bit ? new nuint((uint)l.Value * r)
                           : new nuint((ulong)l.Value * r);
        }

        public unsafe static nuint operator /(nuint l, nuint r)
        {
            return Is32Bit ? new nuint((uint)l.Value / (uint)r.Value)
                           : new nuint((ulong)l.Value / (ulong)r.Value);
        }
        public unsafe static nuint operator /(nuint l, uint r)
        {
            return Is32Bit ? new nuint((uint)l.Value / r)
                           : new nuint((ulong)l.Value / r);
        }

        public unsafe static nuint operator %(nuint l, nuint r)
        {
            return Is32Bit ? new nuint((uint)l.Value % (uint)r.Value)
                           : new nuint((ulong)l.Value % (ulong)r.Value);
        }
        public unsafe static nuint operator %(nuint l, uint r)
        {
            return Is32Bit ? new nuint((uint)l.Value % r)
                           : new nuint((ulong)l.Value % r);
        }

        public unsafe static nuint operator ^(nuint l, nuint r)
        {
            return Is32Bit ? new nuint((uint)l.Value ^ (uint)r.Value)
                           : new nuint((ulong)l.Value ^ (ulong)r.Value);
        }
        public unsafe static nuint operator ^(nuint l, uint r)
        {
            return Is32Bit ? new nuint((uint)l.Value ^ r)
                           : new nuint((ulong)l.Value ^ (ulong)r);
        }

        public unsafe static nuint operator &(nuint l, nuint r)
        {
            return Is32Bit ? new nuint((uint)l.Value & (uint)r.Value)
                           : new nuint((ulong)l.Value & (ulong)r.Value);
        }
        public unsafe static nuint operator &(nuint l, uint r)
        {
            return Is32Bit ? new nuint((uint)l.Value & r)
                           : new nuint((ulong)l.Value & (ulong)r);
        }

        public unsafe static nuint operator |(nuint l, nuint r)
        {
            return Is32Bit ? new nuint((uint)l.Value | (uint)r.Value)
                           : new nuint((ulong)l.Value | (ulong)r.Value);
        }
        public unsafe static nuint operator |(nuint l, uint r)
        {
            return Is32Bit ? new nuint((uint)l.Value | r)
                           : new nuint((ulong)l.Value | (ulong)r);
        }

        // <<(nuint l, nuint r) overload not allowed in C#

        public unsafe static nuint operator <<(nuint l, int r)
        {
            return Is32Bit ? new nuint((uint)l.Value << r)
                           : new nuint((ulong)l.Value << r);
        }

        // >>(nuint l, nuint r) overload not allowed in C#

        public unsafe static nuint operator >>(nuint l, int r)
        {
            return Is32Bit ? new nuint((uint)l.Value >> r)
                           : new nuint((ulong)l.Value >> r);
        }

        public unsafe static bool operator ==(nuint l, nuint r)
        {
            return l.Value == r.Value;
        }
        public unsafe static bool operator ==(nuint l, uint r)
        {
            return Is32Bit ? (uint)l.Value == r
                           : (ulong)l.Value == r;
        }
        public unsafe static bool operator ==(uint l, nuint r)
        {
            return Is32Bit ? l == (uint)r.Value
                           : l == (ulong)r.Value;
        }
        public unsafe static bool operator ==(nuint l, ulong r)
        {
            return Is32Bit ? (uint)l.Value == r
                           : (ulong)l.Value == r;
        }
        public unsafe static bool operator ==(ulong l, nuint r)
        {
            return Is32Bit ? l == (uint)r.Value
                           : l == (ulong)r.Value;
        }
        public unsafe static bool operator ==(nuint l, UIntPtr r)
        {
            return l.Value == r;
        }
        public unsafe static bool operator ==(UIntPtr l, nuint r)
        {
            return l == r.Value;
        }

        public unsafe static bool operator !=(nuint l, nuint r)
        {
            return l.Value != r.Value;
        }
        public unsafe static bool operator !=(nuint l, uint r)
        {
            return Is32Bit ? (uint)l.Value != r
                           : (ulong)l.Value != r;
        }
        public unsafe static bool operator !=(uint l, nuint r)
        {
            return Is32Bit ? l != (uint)r.Value
                           : l != (ulong)r.Value;
        }
        public unsafe static bool operator !=(nuint l, ulong r)
        {
            return Is32Bit ? (uint)l.Value != r
                           : (ulong)l.Value != r;
        }
        public unsafe static bool operator !=(ulong l, nuint r)
        {
            return Is32Bit ? l != (uint)r.Value
                           : l != (ulong)r.Value;
        }
        public unsafe static bool operator !=(nuint l, UIntPtr r)
        {
            return l.Value != r;
        }
        public unsafe static bool operator !=(UIntPtr l, nuint r)
        {
            return l != r.Value;
        }

        public unsafe static bool operator >(nuint l, nuint r)
        {
            return Is32Bit ? (uint)l.Value > (uint)r.Value
                           : (ulong)l.Value > (ulong)r.Value;
        }
        public unsafe static bool operator >(nuint l, uint r)
        {
            return Is32Bit ? (uint)l.Value > r
                           : (ulong)l.Value > r;
        }
        public unsafe static bool operator >(uint l, nuint r)
        {
            return Is32Bit ? l > (uint)r.Value
                           : l > (ulong)r.Value;
        }
        public unsafe static bool operator >(nuint l, ulong r)
        {
            return Is32Bit ? (uint)l.Value > r
                           : (ulong)l.Value > r;
        }
        public unsafe static bool operator >(ulong l, nuint r)
        {
            return Is32Bit ? l > (uint)r.Value
                           : l > (ulong)r.Value;
        }
        public unsafe static bool operator >(nuint l, UIntPtr r)
        {
            return Is32Bit ? (uint)l.Value > (uint)r
                           : (ulong)l.Value > (ulong)r;
        }
        public unsafe static bool operator >(UIntPtr l, nuint r)
        {
            return Is32Bit ? (uint)l > (uint)r.Value
                           : (ulong)l > (ulong)r.Value;
        }

        public unsafe static bool operator <(nuint l, nuint r)
        {
            return Is32Bit ? (uint)l.Value < (uint)r.Value
                           : (ulong)l.Value < (ulong)r.Value;
        }
        public unsafe static bool operator <(nuint l, uint r)
        {
            return Is32Bit ? (uint)l.Value < r
                           : (ulong)l.Value < r;
        }
        public unsafe static bool operator <(uint l, nuint r)
        {
            return Is32Bit ? l < (uint)r.Value
                           : l < (ulong)r.Value;
        }
        public unsafe static bool operator <(nuint l, ulong r)
        {
            return Is32Bit ? (uint)l.Value < r
                           : (ulong)l.Value < r;
        }
        public unsafe static bool operator <(ulong l, nuint r)
        {
            return Is32Bit ? l < (uint)r.Value
                           : l < (ulong)r.Value;
        }
        public unsafe static bool operator <(nuint l, UIntPtr r)
        {
            return Is32Bit ? (uint)l.Value < (uint)r
                           : (ulong)l.Value < (ulong)r;
        }
        public unsafe static bool operator <(UIntPtr l, nuint r)
        {
            return Is32Bit ? (uint)l < (uint)r.Value
                           : (ulong)l < (ulong)r.Value;
        }

        public unsafe static bool operator >=(nuint l, nuint r)
        {
            return Is32Bit ? (uint)l.Value >= (uint)r.Value
                           : (ulong)l.Value >= (ulong)r.Value;
        }
        public unsafe static bool operator >=(nuint l, uint r)
        {
            return Is32Bit ? (uint)l.Value >= r
                           : (ulong)l.Value >= r;
        }
        public unsafe static bool operator >=(uint l, nuint r)
        {
            return Is32Bit ? l >= (uint)r.Value
                           : l >= (ulong)r.Value;
        }
        public unsafe static bool operator >=(nuint l, ulong r)
        {
            return Is32Bit ? (uint)l.Value >= r
                           : (ulong)l.Value >= r;
        }
        public unsafe static bool operator >=(ulong l, nuint r)
        {
            return Is32Bit ? l >= (uint)r.Value
                           : l >= (ulong)r.Value;
        }
        public unsafe static bool operator >=(nuint l, UIntPtr r)
        {
            return Is32Bit ? (uint)l.Value >= (uint)r
                           : (ulong)l.Value >= (ulong)r;
        }
        public unsafe static bool operator >=(UIntPtr l, nuint r)
        {
            return Is32Bit ? (uint)l >= (uint)r.Value
                           : (ulong)l >= (ulong)r.Value;
        }

        public unsafe static bool operator <=(nuint l, nuint r)
        {
            return Is32Bit ? (uint)l.Value <= (uint)r.Value
                           : (ulong)l.Value <= (ulong)r.Value;
        }
        public unsafe static bool operator <=(nuint l, uint r)
        {
            return Is32Bit ? (uint)l.Value <= r
                           : (ulong)l.Value <= r;
        }
        public unsafe static bool operator <=(uint l, nuint r)
        {
            return Is32Bit ? l <= (uint)r.Value
                           : l <= (ulong)r.Value;
        }
        public unsafe static bool operator <=(nuint l, ulong r)
        {
            return Is32Bit ? (uint)l.Value <= r
                           : (ulong)l.Value <= r;
        }
        public unsafe static bool operator <=(ulong l, nuint r)
        {
            return Is32Bit ? l <= (uint)r.Value
                           : l <= (ulong)r.Value;
        }
        public unsafe static bool operator <=(nuint l, UIntPtr r)
        {
            return Is32Bit ? (uint)l.Value <= (uint)r
                           : (ulong)l.Value <= (ulong)r;
        }
        public unsafe static bool operator <=(UIntPtr l, nuint r)
        {
            return Is32Bit ? (uint)l <= (uint)r.Value
                           : (ulong)l <= (ulong)r.Value;
        }

        // <<= cannot be overloaded directly in C#

        // >>= cannot be overloaded directly in C#

        public override bool Equals(object obj)
        {
            if (obj is nuint)
            {
                return (Value == ((nuint)obj).Value);
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

        private static readonly bool Is32Bit = CheckIs32Bit();
        private static unsafe bool CheckIs32Bit()
        {
            return sizeof(UIntPtr) == sizeof(uint);
        }
    }
}

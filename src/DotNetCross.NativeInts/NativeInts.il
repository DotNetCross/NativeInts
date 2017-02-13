.assembly extern mscorlib {}
// Metadata version: v4.0.30319
// .assembly extern System.Runtime
// {
//   .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
//   .ver 4:0:0:0
// }
.assembly 'DotNetCross.NativeInts' {}

// Disassemble IntPtr in System for inspiration

.class public sequential ansi sealed serializable beforefieldinit nint extends [mscorlib]System.ValueType
// implements System.Runtime.Serialization.ISerializable
{
    .field private native int m_value // .custom instance void System.Security.SecurityCriticalAttribute::.ctor() = ( 01 00 00 00 )    
    
    .field public static initonly valuetype nint Zero

    .method public hidebysig specialname rtspecialname instance void .ctor (native int 'value') cil managed 
    {
        ldarg.0
        stfld native int nint::m_value
        ret
    }
    .method public hidebysig specialname rtspecialname instance void .ctor (int32 'value') cil managed 
    {
        ldarg.0
        conv.i
        stfld native int nint::m_value
        ret
    }
    //
    // ECMA I.10.3 Operator overloading
    //
    // Conversions
    //
    // op_Implicit
    // op_Explicit
    .method public hidebysig specialname static valuetype nint op_Implicit (native int 'value') cil managed 
    {
        ldarg.0
        newobj instance void nint::.ctor(native int)
        ret
    }
    .method public hidebysig specialname static valuetype nint op_Implicit (int32 'value') cil managed 
    {
        ldarg.0
        newobj instance void nint::.ctor(int32)
        ret
    }

    .method public hidebysig specialname static valuetype nint op_Explicit (int64 'value') cil managed 
    {
        ldarg.0
        conv.i // Should we throw on overflow, if native int is 32-bit?
        newobj instance void nint::.ctor(native int)
        ret
    }

    .method public hidebysig specialname static native int op_Implicit (valuetype nint 'value') cil managed 
    {
        ldarga.s 'value'
        ldfld native int nint::m_value
        ret
    }
    .method public hidebysig specialname static int64 op_Implicit (valuetype nint 'value') cil managed 
    {
        ldarga.s 'value'
        ldfld native int nint::m_value
        conv.i8
        ret
    }
    .method public hidebysig specialname static int32 op_Explicit (valuetype nint 'value') cil managed 
    {
        ldarga.s 'value'
        ldfld native int nint::m_value
        conv.i4 // Should we throw on overflow, if native int is 64-bit?
        ret
    }

    // .method public hidebysig specialname static native int op_Explicit (
    //         void* 'value'
    //     ) cil managed 
    // {
    //     .custom instance void System.Security.SecurityCriticalAttribute::.ctor() = (
    //         01 00 00 00
    //     )
    //     .custom instance void System.CLSCompliantAttribute::.ctor(bool) = (
    //         01 00 00 00 00
    //     )
    //     .custom instance void System.Runtime.ConstrainedExecution.ReliabilityContractAttribute::.ctor(valuetype System.Runtime.ConstrainedExecution.Consistency,  valuetype System.Runtime.ConstrainedExecution.Cer) = (
    //         01 00 02 00 00 00 01 00 00 00 00 00
    //     )
    //     .custom instance void System.Runtime.Versioning.NonVersionableAttribute::.ctor() = (
    //         01 00 00 00
    //     )
    //     IL_0000: ldarg.0
    //     IL_0001: newobj instance void System.IntPtr::.ctor(void*)
    //     IL_0006: ret
    // }

    // .method public hidebysig specialname static void* op_Explicit (
    //         native int 'value'
    //     ) cil managed 
    // {
    //     .custom instance void System.Security.SecuritySafeCriticalAttribute::.ctor() = (
    //         01 00 00 00
    //     )
    //     .custom instance void System.CLSCompliantAttribute::.ctor(bool) = (
    //         01 00 00 00 00
    //     )
    //     .custom instance void System.Runtime.Versioning.NonVersionableAttribute::.ctor() = (
    //         01 00 00 00
    //     )
    //     IL_0000: ldarga.s 'value'
    //     IL_0002: ldfld void* System.IntPtr::m_value
    //     IL_0007: ret
    // }

    // .method public hidebysig specialname static int32 op_Explicit (
    //         native int 'value'
    //     ) cil managed 
    // {
    //     .custom instance void System.Security.SecuritySafeCriticalAttribute::.ctor() = (
    //         01 00 00 00
    //     )
    //     .custom instance void System.Runtime.Versioning.NonVersionableAttribute::.ctor() = (
    //         01 00 00 00
    //     )
    //     .locals init (
    //         [0] int64 V_0
    //     )

    //     IL_0000: ldarga.s 'value'
    //     IL_0002: ldfld void* System.IntPtr::m_value
    //     IL_0007: conv.u8
    //     IL_0008: stloc.0
    //     IL_0009: ldloc.0
    //     IL_000a: conv.ovf.i4
    //     IL_000b: ret
    // }

    // .method public hidebysig specialname static int64 op_Explicit (
    //         native int 'value'
    //     ) cil managed     

    //
    // Unary
    //
    // op_Decrement Similar to -- (1)
    // op_Increment Similar to ++ (1)
    // op_UnaryNegation - (unary)
    // © Ecma International 2012 61
    // op_UnaryPlus + (unary)
    // op_LogicalNot !
    // op_True Not defined (2)
    // op_False Not defined (2)
    // op_AddressOf & (unary)
    // op_OnesComplement ~
    // op_PointerDereference * (unary)
    // (1) From a pure C++ point of view, the way one must write these functions for the CLI differs in
    // one very important aspect. In C++, these methods must increment or decrement their operand
    // directly, whereas, in CLI, they must not; instead, they simply return the value of their operand
    // +/- 1, as appropriate, without modifying their operand. The operand must be incremented or
    // decremented by the compiler that generates the code for the ++/-- operator, separate from the call
    // to these methods.
    // (2) The op_True and op_False operators do not exist in C++. They are provided to support tristate
    // Boolean types, such as those used in database languages. 

    // 
    // Binary
    // 
    // op_Addition + (binary)
    // op_Subtraction - (binary)
    // op_Multiply * (binary)
    // op_Division /
    // op_Modulus %
    // op_ExclusiveOr ^
    // op_BitwiseAnd & (binary)
    // op_BitwiseOr |
    // op_LogicalAnd &&
    // op_LogicalOr ||
    // op_Assign Not defined (= is not the same)
    // op_LeftShift <<
    // op_RightShift >>
    // op_SignedRightShift Not defined
    // op_UnsignedRightShift Not defined
    // op_Equality ==
    // op_GreaterThan >
    // op_LessThan <
    // op_Inequality !=
    // op_GreaterThanOrEqual >=
    // op_LessThanOrEqual <=
    // op_UnsignedRightShiftAssignment Not defined
    // op_MemberSelection ->
    // op_RightShiftAssignment >>=
    // op_MultiplicationAssignment *=
    // op_PointerToMemberSelection ->*
    // op_SubtractionAssignment -=
    // op_ExclusiveOrAssignment ^=
    // op_LeftShiftAssignment <<=
    // op_ModulusAssignment %=
    // op_AdditionAssignment +=
    // op_BitwiseAndAssignment &=
    // op_BitwiseOrAssignment |=
    // op_Comma ,
    // op_DivisionAssignment /=

}
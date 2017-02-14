//.assembly extern mscorlib {}
// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 4:0:0:0
}
.assembly DotNetCross.NativeInts
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 19 44 6F 74 4E 65 74 43 72 6F 73 73 2E 4D   // ...DotNetCross.M
                                                                                                    65 6D 6F 72 79 2E 55 6E 73 61 66 65 00 00 )       // emory.Unsafe..
  .custom instance void [System.Runtime]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 3E 55 6E 73 61 66 65 20 6D 65 74 68 6F 64   // ..>Unsafe method
                                                                                                          73 20 66 6F 72 20 77 6F 72 6B 69 6E 67 20 77 69   // s for working wi
                                                                                                          74 68 20 70 6F 69 6E 74 65 72 73 20 61 6E 64 20   // th pointers and 
                                                                                                          75 6E 6D 61 6E 61 67 65 64 20 6D 65 6D 6F 72 79   // unmanaged memory
                                                                                                          2E 00 00 )                                        // ...
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 0B 44 6F 74 4E 65 74 43 72 6F 73 73 00 00 ) // ...DotNetCross..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 19 44 6F 74 4E 65 74 43 72 6F 73 73 2E 4D   // ...DotNetCross.M
                                                                                                      65 6D 6F 72 79 2E 55 6E 73 61 66 65 00 00 )       // emory.Unsafe..
  .custom instance void [System.Runtime]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 1D 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                        44 6F 74 4E 65 74 43 72 6F 73 73 20 32 30 31 36   // DotNetCross 2016
                                                                                                        00 00 ) 
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 30 2E 32 2E 32 2E 30 00 00 )             // ...0.2.3.0..

  .hash algorithm 0x00008004
  .ver 0:1:0:0
}
.module DotNetCross.NativeInts.dll
// MVID: {B87A9616-91DD-4DC6-A4FC-3217D05362CD}
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x011E0000

// Disassemble IntPtr in System for inspiration

.class public sequential ansi sealed serializable beforefieldinit DotNetCross.NativeInts.nint extends [System.Runtime]System.ValueType
// implements System.Runtime.Serialization.ISerializable
{
    .field private native int m_value // .custom instance void System.Security.SecurityCriticalAttribute::.ctor() = ( 01 00 00 00 )    
    
    .field public static initonly valuetype DotNetCross.NativeInts.nint Zero

    .method public hidebysig specialname rtspecialname instance void .ctor (native int 'value') cil managed 
    {
        ldarg.0
        stfld native int DotNetCross.NativeInts.nint::m_value
        ret
    }
    .method public hidebysig specialname rtspecialname instance void .ctor (int32 'value') cil managed 
    {
        ldarg.0
        conv.i
        stfld native int DotNetCross.NativeInts.nint::m_value
        ret
    }
    //
    // ECMA I.10.3 Operator overloading
    //
    // Conversions
    //
    // op_Implicit
    // op_Explicit
    .method public hidebysig specialname static valuetype DotNetCross.NativeInts.nint op_Implicit (native int 'value') cil managed 
    {
        ldarg.0
        newobj instance void DotNetCross.NativeInts.nint::.ctor(native int)
        ret
    }
    .method public hidebysig specialname static valuetype DotNetCross.NativeInts.nint op_Implicit (int32 'value') cil managed 
    {
        ldarg.0
        newobj instance void DotNetCross.NativeInts.nint::.ctor(int32)
        ret
    }

    .method public hidebysig specialname static valuetype DotNetCross.NativeInts.nint op_Explicit (int64 'value') cil managed 
    {
        ldarg.0
        conv.i // Should we throw on overflow, if native int is 32-bit?
        newobj instance void DotNetCross.NativeInts.nint::.ctor(native int)
        ret
    }

    .method public hidebysig specialname static native int op_Implicit (valuetype DotNetCross.NativeInts.nint 'value') cil managed 
    {
        ldarga.s 'value'
        ldfld native int DotNetCross.NativeInts.nint::m_value
        ret
    }
    .method public hidebysig specialname static int64 op_Implicit (valuetype DotNetCross.NativeInts.nint 'value') cil managed 
    {
        ldarga.s 'value'
        ldfld native int DotNetCross.NativeInts.nint::m_value
        conv.i8
        ret
    }
    .method public hidebysig specialname static int32 op_Explicit (valuetype DotNetCross.NativeInts.nint 'value') cil managed 
    {
        ldarga.s 'value'
        ldfld native int DotNetCross.NativeInts.nint::m_value
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
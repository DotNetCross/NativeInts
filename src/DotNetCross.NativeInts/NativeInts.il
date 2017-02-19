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

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 19 2E 4E 45 54 53 74 61 6E 64 61 72 64 2C   // ....NETStandard,
                                                                                                              56 65 72 73 69 6F 6E 3D 76 31 2E 30 01 00 54 0E   // Version=v1.0..T.
                                                                                                              14 46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61   // .FrameworkDispla
                                                                                                              79 4E 61 6D 65 00 )                               // yName.
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 07 6E 69 65 74 72 61 73 00 00 )             // ...nietras..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 07 52 65 6C 65 61 73 65 00 00 )             // ...Release..
  .custom instance void [System.Runtime]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 30 43 6F 70 79 72 69 67 68 74 20 32 30 31   // ..0Copyright 201
                                                                                                        37 20 28 63 29 20 6E 69 65 74 72 61 73 2E 20 41   // 7 (c) nietras. A
                                                                                                        6C 6C 20 72 69 67 68 74 73 20 72 65 73 65 72 76   // ll rights reserv
                                                                                                        65 64 2E 00 00 )                                  // ed...
  .custom instance void [System.Runtime]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 73 53 74 72 61 69 67 68 74 66 6F 72 77 61   // ..sStraightforwa
                                                                                                          72 64 20 27 6E 69 6E 74 27 20 61 6E 64 20 27 6E   // rd 'nint' and 'n
                                                                                                          75 69 6E 74 27 20 6E 61 74 69 76 65 20 69 6E 74   // uint' native int
                                                                                                          65 67 65 72 73 2C 20 77 72 69 74 74 65 6E 20 69   // egers, written i
                                                                                                          6E 20 49 4C 2C 20 70 72 6F 62 61 62 6C 79 20 73   // n IL, probably s
                                                                                                          65 63 6F 6E 64 20 62 65 73 74 20 74 6F 20 70 72   // econd best to pr
                                                                                                          6F 70 65 72 20 63 6F 6D 70 69 6C 65 72 20 73 75   // oper compiler su
                                                                                                          70 70 6F 72 74 2E 00 00 )                         // pport...
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 30 2E 31 2E 30 2E 30 00 00 )             // ...0.1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 30 2E 31 2E 30 00 00 )                   // ...0.1.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 16 44 6F 74 4E 65 74 43 72 6F 73 73 2E 4E   // ...DotNetCross.N
                                                                                                      61 74 69 76 65 49 6E 74 73 00 00 )                // ativeInts..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 16 44 6F 74 4E 65 74 43 72 6F 73 73 2E 4E   // ...DotNetCross.N
                                                                                                    61 74 69 76 65 49 6E 74 73 00 00 )                // ativeInts..
  .hash algorithm 0x00008004
  .ver 0:1:0:0
}
.module DotNetCross.NativeInts.dll
// MVID: {1B5B4432-7D73-4CB5-9BB8-2EE910AE36E3}
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x01090000


// Disassemble IntPtr in System for inspiration

.class public sequential ansi sealed serializable beforefieldinit DotNetCross.NativeInts.nint extends [System.Runtime]System.ValueType
// implements System.Runtime.Serialization.ISerializable
{
    .field public  native int Value // .custom instance void System.Security.SecurityCriticalAttribute::.ctor() = ( 01 00 00 00 )    
    
    .field public static initonly valuetype DotNetCross.NativeInts.nint Zero

    .method public hidebysig specialname rtspecialname instance void .ctor (native int 'value') cil managed 
    {
        ldarg.0 // this
        ldarg.1 // value
        stfld native int DotNetCross.NativeInts.nint::Value
        ret
    }
    .method public hidebysig specialname rtspecialname instance void .ctor (int32 'value') cil managed 
    {
        ldarg.0 // this
        ldarg.1 // value
        conv.i
        stfld native int DotNetCross.NativeInts.nint::Value
        ret
    }

    // TODO: Add int64 ctor as IntPtr has...

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
        ldfld native int DotNetCross.NativeInts.nint::Value
        ret
    }
    .method public hidebysig specialname static int64 op_Implicit (valuetype DotNetCross.NativeInts.nint 'value') cil managed 
    {
        ldarga.s 'value'
        ldfld native int DotNetCross.NativeInts.nint::Value
        conv.i8
        ret
    }
    .method public hidebysig specialname static int32 op_Explicit (valuetype DotNetCross.NativeInts.nint 'value') cil managed 
    {
        ldarga.s 'value'
        ldfld native int DotNetCross.NativeInts.nint::Value
        conv.i4 // Should we throw on overflow, if native int is 64-bit?
        ret
    }

    //
    // Unary
    //
    // op_Decrement Similar to -- (1)
    // op_Increment Similar to ++ (1)
    // op_UnaryNegation - (unary)
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

    .method public hidebysig specialname static 
            valuetype DotNetCross.NativeInts.nint 
            op_Increment(valuetype DotNetCross.NativeInts.nint 'value') cil managed
    {
        .maxstack  3
        ldarg.0
        ldfld      native int DotNetCross.NativeInts.nint::Value
        ldc.i4.1
        add
        newobj     instance void DotNetCross.NativeInts.nint::.ctor(native int)
        ret
    } // end of method nint::op_Increment

    .method public hidebysig specialname static 
            valuetype DotNetCross.NativeInts.nint 
            op_Decrement(valuetype DotNetCross.NativeInts.nint 'value') cil managed
    {
        .maxstack  3
        ldarg.0
        ldfld      native int DotNetCross.NativeInts.nint::Value
        ldc.i4.1
        sub
        newobj     instance void DotNetCross.NativeInts.nint::.ctor(native int)
        ret
    } // end of method nint::op_Decrement

    .method public hidebysig specialname static 
            valuetype DotNetCross.NativeInts.nint 
            op_UnaryPlus(valuetype DotNetCross.NativeInts.nint 'value') cil managed
    {
        .maxstack  1
        ldarg.0
        ret
    } // end of method nint::op_UnaryPlus

    .method public hidebysig specialname static 
            valuetype DotNetCross.NativeInts.nint 
            op_UnaryNegation(valuetype DotNetCross.NativeInts.nint 'value') cil managed
    {
        .maxstack  1
        ldarg.0
        ldfld      native int DotNetCross.NativeInts.nint::Value
        neg
        ret
    } // end of method nint::op_UnaryNegation

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
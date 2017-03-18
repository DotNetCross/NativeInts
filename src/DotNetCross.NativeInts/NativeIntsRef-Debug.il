
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.6.1055.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



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
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 19 2E 4E 45 54 53 74 61 6E 64 61 72 64 2C   // ....NETStandard,
                                                                                                              56 65 72 73 69 6F 6E 3D 76 31 2E 30 01 00 54 0E   // Version=v1.0..T.
                                                                                                              14 46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61   // .FrameworkDispla
                                                                                                              79 4E 61 6D 65 00 )                               // yName.
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 07 6E 69 65 74 72 61 73 00 00 )             // ...nietras..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
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
// MVID: {E7615CA1-9C6C-4671-B644-F5322B327DD5}
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x01290000


// =============== CLASS MEMBERS DECLARATION ===================

.class public sequential ansi sealed beforefieldinit DotNetCross.NativeInts.nint
       extends [System.Runtime]System.ValueType
{
  .field private static initonly bool Is32Bit
  .field public native int Value
  .method private hidebysig static bool  CheckIs32Bit() cil managed
  {
    // Code size       15 (0xf)
    .maxstack  2
    .locals init (bool V_0)
    IL_0000:  nop
    IL_0001:  sizeof     [System.Runtime]System.IntPtr
    IL_0007:  ldc.i4.4
    IL_0008:  ceq
    IL_000a:  stloc.0
    IL_000b:  br.s       IL_000d

    IL_000d:  ldloc.0
    IL_000e:  ret
  } // end of method nint::CheckIs32Bit

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(native int 'value') cil managed
  {
    // Code size       9 (0x9)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldarg.1
    IL_0003:  stfld      native int DotNetCross.NativeInts.nint::Value
    IL_0008:  ret
  } // end of method nint::.ctor

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 'value') cil managed
  {
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldarg.1
    IL_0003:  newobj     instance void [System.Runtime]System.IntPtr::.ctor(int32)
    IL_0008:  stfld      native int DotNetCross.NativeInts.nint::Value
    IL_000d:  ret
  } // end of method nint::.ctor

  .method private hidebysig specialname rtspecialname 
          instance void  .ctor(int64 'value') cil managed
  {
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldarg.1
    IL_0003:  newobj     instance void [System.Runtime]System.IntPtr::.ctor(int64)
    IL_0008:  stfld      native int DotNetCross.NativeInts.nint::Value
    IL_000d:  ret
  } // end of method nint::.ctor

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Implicit(native int 'value') cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(native int)
    IL_0006:  ret
  } // end of method nint::op_Implicit

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Implicit(int32 'value') cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_0006:  ret
  } // end of method nint::op_Implicit

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Explicit(int64 'value') cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_0006:  ret
  } // end of method nint::op_Explicit

  .method public hidebysig specialname static 
          native int  op_Implicit(valuetype DotNetCross.NativeInts.nint 'value') cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0006:  ret
  } // end of method nint::op_Implicit

  .method public hidebysig specialname static 
          int64  op_Implicit(valuetype DotNetCross.NativeInts.nint 'value') cil managed
  {
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0006:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_000b:  ret
  } // end of method nint::op_Implicit

  .method public hidebysig specialname static 
          int32  op_Explicit(valuetype DotNetCross.NativeInts.nint 'value') cil managed
  {
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0006:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_000b:  ret
  } // end of method nint::op_Explicit

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Increment(valuetype DotNetCross.NativeInts.nint 'value') cil managed
  {
    // Code size       18 (0x12)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0006:  ldc.i4.1
    IL_0007:  call       native int [System.Runtime]System.IntPtr::op_Addition(native int,
                                                                               int32)
    IL_000c:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(native int)
    IL_0011:  ret
  } // end of method nint::op_Increment

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Decrement(valuetype DotNetCross.NativeInts.nint 'value') cil managed
  {
    // Code size       18 (0x12)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0006:  ldc.i4.1
    IL_0007:  call       native int [System.Runtime]System.IntPtr::op_Subtraction(native int,
                                                                                  int32)
    IL_000c:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(native int)
    IL_0011:  ret
  } // end of method nint::op_Decrement

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_UnaryPlus(valuetype DotNetCross.NativeInts.nint 'value') cil managed
  {
    // Code size       2 (0x2)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ret
  } // end of method nint::op_UnaryPlus

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_UnaryNegation(valuetype DotNetCross.NativeInts.nint 'value') cil managed
  {
    // Code size       49 (0x31)
    .maxstack  1
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_0006:  brtrue.s   IL_001b

    IL_0008:  ldarg.0
    IL_0009:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_000e:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0013:  neg
    IL_0014:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_0019:  br.s       IL_002c

    IL_001b:  ldarg.0
    IL_001c:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0021:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0026:  neg
    IL_0027:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_002c:  stloc.0
    IL_002d:  br.s       IL_002f

    IL_002f:  ldloc.0
    IL_0030:  ret
  } // end of method nint::op_UnaryNegation

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_OnesComplement(valuetype DotNetCross.NativeInts.nint 'value') cil managed
  {
    // Code size       49 (0x31)
    .maxstack  1
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_0006:  brtrue.s   IL_001b

    IL_0008:  ldarg.0
    IL_0009:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_000e:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0013:  not
    IL_0014:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_0019:  br.s       IL_002c

    IL_001b:  ldarg.0
    IL_001c:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0021:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0026:  not
    IL_0027:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_002c:  stloc.0
    IL_002d:  br.s       IL_002f

    IL_002f:  ldloc.0
    IL_0030:  ret
  } // end of method nint::op_OnesComplement

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Addition(valuetype DotNetCross.NativeInts.nint l,
                      valuetype DotNetCross.NativeInts.nint r) cil managed
  {
    // Code size       71 (0x47)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_0006:  brtrue.s   IL_0026

    IL_0008:  ldarg.0
    IL_0009:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_000e:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0013:  ldarg.1
    IL_0014:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0019:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_001e:  add
    IL_001f:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_0024:  br.s       IL_0042

    IL_0026:  ldarg.0
    IL_0027:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_002c:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0031:  ldarg.1
    IL_0032:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0037:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_003c:  add
    IL_003d:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_0042:  stloc.0
    IL_0043:  br.s       IL_0045

    IL_0045:  ldloc.0
    IL_0046:  ret
  } // end of method nint::op_Addition

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Addition(valuetype DotNetCross.NativeInts.nint l,
                      int32 r) cil managed
  {
    // Code size       23 (0x17)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0007:  ldarg.1
    IL_0008:  call       native int [System.Runtime]System.IntPtr::op_Addition(native int,
                                                                               int32)
    IL_000d:  call       valuetype DotNetCross.NativeInts.nint DotNetCross.NativeInts.nint::op_Implicit(native int)
    IL_0012:  stloc.0
    IL_0013:  br.s       IL_0015

    IL_0015:  ldloc.0
    IL_0016:  ret
  } // end of method nint::op_Addition

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Addition(int32 l,
                      valuetype DotNetCross.NativeInts.nint r) cil managed
  {
    // Code size       23 (0x17)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0007:  ldarg.0
    IL_0008:  call       native int [System.Runtime]System.IntPtr::op_Addition(native int,
                                                                               int32)
    IL_000d:  call       valuetype DotNetCross.NativeInts.nint DotNetCross.NativeInts.nint::op_Implicit(native int)
    IL_0012:  stloc.0
    IL_0013:  br.s       IL_0015

    IL_0015:  ldloc.0
    IL_0016:  ret
  } // end of method nint::op_Addition

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Subtraction(valuetype DotNetCross.NativeInts.nint l,
                         valuetype DotNetCross.NativeInts.nint r) cil managed
  {
    // Code size       71 (0x47)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_0006:  brtrue.s   IL_0026

    IL_0008:  ldarg.0
    IL_0009:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_000e:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0013:  ldarg.1
    IL_0014:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0019:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_001e:  sub
    IL_001f:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_0024:  br.s       IL_0042

    IL_0026:  ldarg.0
    IL_0027:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_002c:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0031:  ldarg.1
    IL_0032:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0037:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_003c:  sub
    IL_003d:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_0042:  stloc.0
    IL_0043:  br.s       IL_0045

    IL_0045:  ldloc.0
    IL_0046:  ret
  } // end of method nint::op_Subtraction

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Subtraction(valuetype DotNetCross.NativeInts.nint l,
                         int32 r) cil managed
  {
    // Code size       23 (0x17)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0007:  ldarg.1
    IL_0008:  call       native int [System.Runtime]System.IntPtr::op_Subtraction(native int,
                                                                                  int32)
    IL_000d:  call       valuetype DotNetCross.NativeInts.nint DotNetCross.NativeInts.nint::op_Implicit(native int)
    IL_0012:  stloc.0
    IL_0013:  br.s       IL_0015

    IL_0015:  ldloc.0
    IL_0016:  ret
  } // end of method nint::op_Subtraction

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Subtraction(int32 l,
                         valuetype DotNetCross.NativeInts.nint r) cil managed
  {
    // Code size       23 (0x17)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0007:  ldarg.0
    IL_0008:  call       native int [System.Runtime]System.IntPtr::op_Subtraction(native int,
                                                                                  int32)
    IL_000d:  call       valuetype DotNetCross.NativeInts.nint DotNetCross.NativeInts.nint::op_Implicit(native int)
    IL_0012:  stloc.0
    IL_0013:  br.s       IL_0015

    IL_0015:  ldloc.0
    IL_0016:  ret
  } // end of method nint::op_Subtraction

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Multiply(valuetype DotNetCross.NativeInts.nint l,
                      valuetype DotNetCross.NativeInts.nint r) cil managed
  {
    // Code size       71 (0x47)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_0006:  brtrue.s   IL_0026

    IL_0008:  ldarg.0
    IL_0009:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_000e:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0013:  ldarg.1
    IL_0014:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0019:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_001e:  mul
    IL_001f:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_0024:  br.s       IL_0042

    IL_0026:  ldarg.0
    IL_0027:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_002c:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0031:  ldarg.1
    IL_0032:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0037:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_003c:  mul
    IL_003d:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_0042:  stloc.0
    IL_0043:  br.s       IL_0045

    IL_0045:  ldloc.0
    IL_0046:  ret
  } // end of method nint::op_Multiply

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Multiply(valuetype DotNetCross.NativeInts.nint l,
                      int32 r) cil managed
  {
    // Code size       52 (0x34)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_0006:  brtrue.s   IL_001d

    IL_0008:  ldarg.0
    IL_0009:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_000e:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0013:  ldarg.1
    IL_0014:  conv.i8
    IL_0015:  mul
    IL_0016:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_001b:  br.s       IL_002f

    IL_001d:  ldarg.0
    IL_001e:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0023:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0028:  ldarg.1
    IL_0029:  mul
    IL_002a:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_002f:  stloc.0
    IL_0030:  br.s       IL_0032

    IL_0032:  ldloc.0
    IL_0033:  ret
  } // end of method nint::op_Multiply

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Division(valuetype DotNetCross.NativeInts.nint l,
                      valuetype DotNetCross.NativeInts.nint r) cil managed
  {
    // Code size       71 (0x47)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_0006:  brtrue.s   IL_0026

    IL_0008:  ldarg.0
    IL_0009:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_000e:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0013:  ldarg.1
    IL_0014:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0019:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_001e:  div
    IL_001f:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_0024:  br.s       IL_0042

    IL_0026:  ldarg.0
    IL_0027:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_002c:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0031:  ldarg.1
    IL_0032:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0037:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_003c:  div
    IL_003d:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_0042:  stloc.0
    IL_0043:  br.s       IL_0045

    IL_0045:  ldloc.0
    IL_0046:  ret
  } // end of method nint::op_Division

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Division(valuetype DotNetCross.NativeInts.nint l,
                      int32 r) cil managed
  {
    // Code size       52 (0x34)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_0006:  brtrue.s   IL_001d

    IL_0008:  ldarg.0
    IL_0009:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_000e:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0013:  ldarg.1
    IL_0014:  conv.i8
    IL_0015:  div
    IL_0016:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_001b:  br.s       IL_002f

    IL_001d:  ldarg.0
    IL_001e:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0023:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0028:  ldarg.1
    IL_0029:  div
    IL_002a:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_002f:  stloc.0
    IL_0030:  br.s       IL_0032

    IL_0032:  ldloc.0
    IL_0033:  ret
  } // end of method nint::op_Division

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Modulus(valuetype DotNetCross.NativeInts.nint l,
                     valuetype DotNetCross.NativeInts.nint r) cil managed
  {
    // Code size       71 (0x47)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_0006:  brtrue.s   IL_0026

    IL_0008:  ldarg.0
    IL_0009:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_000e:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0013:  ldarg.1
    IL_0014:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0019:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_001e:  rem
    IL_001f:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_0024:  br.s       IL_0042

    IL_0026:  ldarg.0
    IL_0027:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_002c:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0031:  ldarg.1
    IL_0032:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0037:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_003c:  rem
    IL_003d:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_0042:  stloc.0
    IL_0043:  br.s       IL_0045

    IL_0045:  ldloc.0
    IL_0046:  ret
  } // end of method nint::op_Modulus

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_Modulus(valuetype DotNetCross.NativeInts.nint l,
                     int32 r) cil managed
  {
    // Code size       52 (0x34)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_0006:  brtrue.s   IL_001d

    IL_0008:  ldarg.0
    IL_0009:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_000e:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0013:  ldarg.1
    IL_0014:  conv.i8
    IL_0015:  rem
    IL_0016:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_001b:  br.s       IL_002f

    IL_001d:  ldarg.0
    IL_001e:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0023:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0028:  ldarg.1
    IL_0029:  rem
    IL_002a:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_002f:  stloc.0
    IL_0030:  br.s       IL_0032

    IL_0032:  ldloc.0
    IL_0033:  ret
  } // end of method nint::op_Modulus

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_ExclusiveOr(valuetype DotNetCross.NativeInts.nint l,
                         valuetype DotNetCross.NativeInts.nint r) cil managed
  {
    // Code size       71 (0x47)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_0006:  brtrue.s   IL_0026

    IL_0008:  ldarg.0
    IL_0009:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_000e:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0013:  ldarg.1
    IL_0014:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0019:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_001e:  xor
    IL_001f:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_0024:  br.s       IL_0042

    IL_0026:  ldarg.0
    IL_0027:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_002c:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0031:  ldarg.1
    IL_0032:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0037:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_003c:  xor
    IL_003d:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_0042:  stloc.0
    IL_0043:  br.s       IL_0045

    IL_0045:  ldloc.0
    IL_0046:  ret
  } // end of method nint::op_ExclusiveOr

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_ExclusiveOr(valuetype DotNetCross.NativeInts.nint l,
                         int32 r) cil managed
  {
    // Code size       52 (0x34)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_0006:  brtrue.s   IL_001d

    IL_0008:  ldarg.0
    IL_0009:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_000e:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0013:  ldarg.1
    IL_0014:  conv.i8
    IL_0015:  xor
    IL_0016:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_001b:  br.s       IL_002f

    IL_001d:  ldarg.0
    IL_001e:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0023:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0028:  ldarg.1
    IL_0029:  xor
    IL_002a:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_002f:  stloc.0
    IL_0030:  br.s       IL_0032

    IL_0032:  ldloc.0
    IL_0033:  ret
  } // end of method nint::op_ExclusiveOr

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_BitwiseAnd(valuetype DotNetCross.NativeInts.nint l,
                        valuetype DotNetCross.NativeInts.nint r) cil managed
  {
    // Code size       71 (0x47)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_0006:  brtrue.s   IL_0026

    IL_0008:  ldarg.0
    IL_0009:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_000e:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0013:  ldarg.1
    IL_0014:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0019:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_001e:  and
    IL_001f:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_0024:  br.s       IL_0042

    IL_0026:  ldarg.0
    IL_0027:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_002c:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0031:  ldarg.1
    IL_0032:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0037:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_003c:  and
    IL_003d:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_0042:  stloc.0
    IL_0043:  br.s       IL_0045

    IL_0045:  ldloc.0
    IL_0046:  ret
  } // end of method nint::op_BitwiseAnd

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_BitwiseAnd(valuetype DotNetCross.NativeInts.nint l,
                        int32 r) cil managed
  {
    // Code size       52 (0x34)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_0006:  brtrue.s   IL_001d

    IL_0008:  ldarg.0
    IL_0009:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_000e:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0013:  ldarg.1
    IL_0014:  conv.i8
    IL_0015:  and
    IL_0016:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_001b:  br.s       IL_002f

    IL_001d:  ldarg.0
    IL_001e:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0023:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0028:  ldarg.1
    IL_0029:  and
    IL_002a:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_002f:  stloc.0
    IL_0030:  br.s       IL_0032

    IL_0032:  ldloc.0
    IL_0033:  ret
  } // end of method nint::op_BitwiseAnd

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_BitwiseOr(valuetype DotNetCross.NativeInts.nint l,
                       valuetype DotNetCross.NativeInts.nint r) cil managed
  {
    // Code size       71 (0x47)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_0006:  brtrue.s   IL_0026

    IL_0008:  ldarg.0
    IL_0009:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_000e:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0013:  ldarg.1
    IL_0014:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0019:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_001e:  or
    IL_001f:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_0024:  br.s       IL_0042

    IL_0026:  ldarg.0
    IL_0027:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_002c:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0031:  ldarg.1
    IL_0032:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0037:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_003c:  or
    IL_003d:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_0042:  stloc.0
    IL_0043:  br.s       IL_0045

    IL_0045:  ldloc.0
    IL_0046:  ret
  } // end of method nint::op_BitwiseOr

  .method public hidebysig specialname static 
          valuetype DotNetCross.NativeInts.nint 
          op_BitwiseOr(valuetype DotNetCross.NativeInts.nint l,
                       int32 r) cil managed
  {
    // Code size       52 (0x34)
    .maxstack  2
    .locals init (valuetype DotNetCross.NativeInts.nint V_0)
    IL_0000:  nop
    IL_0001:  ldsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_0006:  brtrue.s   IL_001d

    IL_0008:  ldarg.0
    IL_0009:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_000e:  call       int64 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0013:  ldarg.1
    IL_0014:  conv.i8
    IL_0015:  or
    IL_0016:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int64)
    IL_001b:  br.s       IL_002f

    IL_001d:  ldarg.0
    IL_001e:  ldfld      native int DotNetCross.NativeInts.nint::Value
    IL_0023:  call       int32 [System.Runtime]System.IntPtr::op_Explicit(native int)
    IL_0028:  ldarg.1
    IL_0029:  or
    IL_002a:  newobj     instance void DotNetCross.NativeInts.nint::.ctor(int32)
    IL_002f:  stloc.0
    IL_0030:  br.s       IL_0032

    IL_0032:  ldloc.0
    IL_0033:  ret
  } // end of method nint::op_BitwiseOr

  .method private hidebysig specialname rtspecialname static 
          void  .cctor() cil managed
  {
    // Code size       11 (0xb)
    .maxstack  8
    IL_0000:  call       bool DotNetCross.NativeInts.nint::CheckIs32Bit()
    IL_0005:  stsfld     bool DotNetCross.NativeInts.nint::Is32Bit
    IL_000a:  ret
  } // end of method nint::.cctor

} // end of class DotNetCross.NativeInts.nint

.class public sequential ansi sealed beforefieldinit DotNetCross.NativeInts.nuint
       extends [System.Runtime]System.ValueType
{
  .field public native uint Value
} // end of class DotNetCross.NativeInts.nuint


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file .\src\DotNetCross.NativeInts\NativeIntsRef-Debug.res

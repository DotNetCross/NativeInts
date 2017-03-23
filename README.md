# NativeInts
Straightforward `nint` and `nuint` native integers, written in IL, probably second best to proper compiler support.
Fully functional.

## Comparing `IntPtr`/`UIntPtr` vs `nint`/`nuint`
Based on:
 * **I.10.3 Operator overloading** section from the ECMA 
 * [Operator Overloads](https://msdn.microsoft.com/en-us/library/ms229032.aspx)
 * [Overloadable Operators (C# Programming Guide)](https://msdn.microsoft.com/en-us/library/8edha89s.aspx)

### Conversions
Besides supporting implicit conversion for:

 * `IntPtr` to/from `nint`
 * `UIntPtr` to/from `nuint`

The following conversions are supported compared to available conversions for `IntPtr`/`UIntPtr`:

|**Name**               |**From** |`IntPtr` C# | `UIntPtr` C# | `nint` C# | `nuint` C# |
|--|--|--|--|--|--|
|op_Implicit            |`int`   |N/A         |N/A           |Yes        |N/A         |
|op_Implicit            |`uint`  |N/A         |N/A           |N/A        |Yes         |
|op_Explicit            |`long`  |N/A         |N/A           |Yes        |N/A         |
|op_Explicit            |`ulong` |N/A         |N/A           |N/A        |Yes         |

|**Name**               |**To**   |`IntPtr` C# | `UIntPtr` C# | `nint` C# | `nuint` C# |
|--|--|--|--|--|--|
|op_Implicit            |`long`  |N/A         |N/A           |Yes        |N/A         |
|op_Implicit            |`ulong` |N/A         |N/A           |N/A        |Yes         |
|op_Explicit            |`int`   |N/A         |N/A           |Yes        |N/A         |
|op_Explicit            |`uint`  |N/A         |N/A           |N/A        |Yes         |


### Unary Operators
|**Name**               |**C++ Operator Symbol** |`IntPtr` C# | `UIntPtr` C# | `nint` C# | `nuint` C# |
|--|--|--|--|--|--|
|op_Decrement           |  --<sup>1</sup>        | N/A         | N/A           | Yes        | Yes        |
|op_Increment           |  ++<sup>1</sup>        | N/A         | N/A           | Yes        | Yes        |
|op_UnaryNegation       |  - (unary)             | N/A         | N/A           | Yes        | Yes        |
|op_UnaryPlus           |  + (unary)             | N/A         | N/A           | Yes        | Yes        |
|op_LogicalNot          |  !                     | N/A         | N/A           | N/A        | N/A        | 
|op_True                |  ND<sup>2</sup>        | N/A         | N/A           | N/A        | N/A        | 
|op_False               |  ND<sup>2</sup>        | N/A         | N/A           | N/A        | N/A        | 
|op_AddressOf           |  & (unary)             | N/A         | N/A           | N/A        | N/A        | 
|op_OnesComplement      |  ~                     | N/A         | N/A           | Yes        | Yes        |
|op_PointerDereference  |  * (unary)             | N/A         | N/A           | N/A        | N/A        | 

<sup>1</sup> From a pure C++ point of view, the way one must write these functions for the CLI differs in
one very important aspect. In C++, these methods must increment or decrement their operand
directly, whereas, in CLI, they must not; instead, they simply return the value of their operand
+/- 1, as appropriate, without modifying their operand. The operand must be incremented or
decremented by the compiler that generates the code for the ++/-- operator, separate from the call
to these methods.

<sup>2</sup> The op_True and op_False operators do not exist in C++. They are provided to support tristate
Boolean types, such as those used in database languages. 

### Binary Operators
The table below shows the types that can be used together with the type in header for a given binary operator.
By default this is for the type on either left or right side of expression (binary operator).
However, for some cases an operator might only be available for a type at a specific side of the expression,
with `(R)` meaning "right only".

|**Name**						|**C++ Operator Symbol**  |`IntPtr` C#   | `UIntPtr` C#   | `nint` C#                | `nuint` C#       |
|-------------------|-------------------------|--------------|----------------|--------------------------|------------------|
|op_Addition					| +                       |`int (R)`	  |`int (R)`       |`nint`, `IntPtr`, `int` |`nuint`, `UIntPtr`, `uint`  |
|op_Subtraction				    | - 					  |`int (R)`	  |`int (R)`       |`nint`, `IntPtr`, `int` |`nuint`, `UIntPtr`, `uint`  |
|op_Multiply					| \* 					  |N/A      	  |N/A               |`nint`, `IntPtr`, `int (R)` |`nuint`, `UIntPtr`, `uint (R)` |
|op_Division 					| /						  |N/A      	  |N/A               |`nint`, `IntPtr`, `int (R)` |`nuint`, `UIntPtr`, `uint (R)` |
|op_Modulus 					| %						  |N/A      	  |N/A               |`nint`, `IntPtr`, `int (R)` |`nuint`, `UIntPtr`, `uint (R)` |
|op_ExclusiveOr 				| ^						  |N/A      	  |N/A               |`nint`, `IntPtr`, `int (R)` |`nuint`, `UIntPtr`, `uint (R)` |
|op_BitwiseAnd 					| & 					  |N/A      	  |N/A               |`nint`, `IntPtr`, `int (R)` |`nuint`, `UIntPtr`, `uint (R)` |
|op_BitwiseOr 					| \|					  |N/A      	  |N/A               |`nint`, `IntPtr`, `int (R)` |`nuint`, `UIntPtr`, `uint (R)` |
|op_LogicalAnd 					| &&					  |N/A            |N/A               |N/A                            |N/A                                | 
|op_LogicalOr  					| \|\|					  |N/A            |N/A               |N/A                            |N/A                                | 
|op_Assign  					| N/D (= is not the same) |N/A            |N/A               |N/A                            |N/A                                | 
|op_LeftShift  					| <<					  |N/A      	  |N/A               |`nint`, `IntPtr`, `int (R)` |`nuint`, `UIntPtr`, `uint (R)` |
|op_RightShift  				| >>					  |N/A      	  |N/A               |`nint`, `IntPtr`, `int (R)` |`nuint`, `UIntPtr`, `uint (R)` |
|op_SignedRightShift  			| N/D					  |N/A            |N/A               |N/A                            |N/A                               | 
|op_UnsignedRightShift			| N/D					  |N/A            |N/A               |N/A                            |N/A                                | 
|op_Equality  					| ==					  |`IntPtr`	  |`UIntPtr`        |`nint`, `IntPtr`, `int`, `long` |`nuint`, `UIntPtr`, `uint`, `ulong`  |
|op_GreaterThan  				| >						  |`IntPtr`	  |`UIntPtr`        |`nint`, `IntPtr`, `int`, `long` |`nuint`, `UIntPtr`, `uint`, `ulong`  |
|op_LessThan  					| <						  |`IntPtr`	  |`UIntPtr`        |`nint`, `IntPtr`, `int`, `long` |`nuint`, `UIntPtr`, `uint`, `ulong`  |
|op_Inequality  				| !=					  |`IntPtr`	  |`UIntPtr`        |`nint`, `IntPtr`, `int`, `long` |`nuint`, `UIntPtr`, `uint`, `ulong`  |
|op_GreaterThanOrEqual			| >=					  |`IntPtr`	  |`UIntPtr`        |`nint`, `IntPtr`, `int`, `long` |`nuint`, `UIntPtr`, `uint`, `ulong`  |
|op_LessThanOrEqual  			| \<=					  |`IntPtr`	  |`UIntPtr`        |`nint`, `IntPtr`, `int`, `long` |`nuint`, `UIntPtr`, `uint`, `ulong`  |
|op_UnsignedRightShiftAssignment| Not defined			  |N/A            |N/A               |N/A                            |N/A                                | 
|op_MemberSelection  			| ->					  |N/A (N/O C#)	  |N/A (N/O C#)	     |N/A (N/O C#)	     |N/A (N/O C#)	     |
|op_RightShiftAssignment  		| >>=					  |N/A (N/O C#)	  |N/A (N/O C#)	     |`nint`, `IntPtr`, `int` |`nuint`, `UIntPtr`, `uint` TODO |
|op_MultiplicationAssignment  	| \*=					  |N/A (N/O C#)	  |N/A (N/O C#)	     |`nint`, `IntPtr`, `int` |`nuint`, `UIntPtr`, `uint` TODO |
|op_PointerToMemberSelection  	| ->\*					  |N/A (N/O C#)	  |N/A (N/O C#)	     |N/A (N/O C#)	     |N/A (N/O C#)	     |
|op_SubtractionAssignment  		| -=					  |`int`    	  |`int`            |`nint`, `IntPtr`, `int` |`nuint`, `UIntPtr`, `uint` TODO |
|op_ExclusiveOrAssignment  		| ^=					  |N/A (N/O C#)	  |N/A (N/O C#)	     |`nint`, `IntPtr`, `int` |`nuint`, `UIntPtr`, `uint` TODO |
|op_LeftShiftAssignment  		| <<=					  |N/A (N/O C#)	  |N/A (N/O C#)	     |`nint`, `IntPtr`, `int` |`nuint`, `UIntPtr`, `uint` TODO |
|op_ModulusAssignment  			| %=					  |N/A (N/O C#)	  |N/A (N/O C#)	     |`nint`, `IntPtr`, `int` |`nuint`, `UIntPtr`, `uint` TODO |
|op_AdditionAssignment  		| +=					  |`int`    	  |`int`            |`nint`, `IntPtr`, `int` |`nuint`, `UIntPtr`, `uint` TODO |
|op_BitwiseAndAssignment  		| &=					  |N/A (N/O C#)	  |N/A (N/O C#)	     |`nint`, `IntPtr`, `int` |`nuint`, `UIntPtr`, `uint` TODO |
|op_BitwiseOrAssignment  		| \|=					  |N/A (N/O C#)	  |N/A (N/O C#)	     |`nint`, `IntPtr`, `int` |`nuint`, `UIntPtr`, `uint` TODO |
|op_Comma  						| ,						  |N/A (N/O C#)	  |N/A (N/O C#)	     |N/A (N/O C#)	     |N/A (N/O C#)	     |
|op_DivisionAssignment  		| /=					  |N/A (N/O C#)	  |N/A (N/O C#)	     |`nint`, `IntPtr`, `int` |`nuint`, `UIntPtr`, `uint` TODO |

 * `N/A` = Not Available
 * `N/O` = Not Overloadable, but for assignment operators usably available via binary static operator e.g. `+=` is available via `+`.

### Object Methods
The following methods have the same or forward to the equivalent `IntPtr`/`UIntPtr` implementation.

```csharp
public override bool Equals(object obj)
public override int GetHashCode()
public override string ToString()
```

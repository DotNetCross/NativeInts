# NativeInts
Straightforward `nint` and `nuint` native integers, written in IL, probably second best to proper compiler support.
Fully functional.

## Comparing `IntPtr`/`UIntPtr` vs `nint`/`nuint`
Based on "I.10.3 Operator overloading" section from the ECMA.

### Conversions
    //

|**Name**               |**From** |`IntPtr` C# | `UIntPtr` C# | `nint` C# | `nuint` C# |
|--|--|--|--|--|--|
|op_Implicit            |         |
|op_Exlicit             |         |

|**Name**               |**To**   |`IntPtr` C# | `UIntPtr` C# | `nint` C# | `nuint` C# |
|--|--|--|--|--|--|
|op_Implicit            |         |
|op_Exlicit             |         |


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
with `(R)` meaning "right only", `(L)` meaning "left only".

|**Name**						|**C++ Operator Symbol**  |`IntPtr` C#   | `UIntPtr` C#   | `nint` C#      | `nuint` C#       |
|--|--|--|--|--|--|--|--|
|op_Addition					| +                       |`int (R)`	  |`uint (R)`      |`nint`, `IntPtr`, `int` |`nuint`, `UIntPtr`, `uint`  |
|op_Subtraction				    | - 					  |`int (R)`	  |`uint (R)`      |`nint`, `IntPtr`, `int` |`nuint`, `UIntPtr`, `uint`  |
|op_Multiply					| * 					  |N/A      	  |N/A               |`nint`, `IntPtr`, `int (R)` |`nuint`, `UIntPtr`, `uint (R)` |
|op_Division 					| /						  |N/A      	  |N/A               |`nint`, `IntPtr`, `int (R)` |`nuint`, `UIntPtr`, `uint (R)` |
|op_Modulus 					| %						  |N/A      	  |N/A               |`nint`, `IntPtr`, `int (R)` |`nuint`, `UIntPtr`, `uint (R)` |
|op_ExclusiveOr 				| ^						  |N/A      	  |N/A               |`nint`, `IntPtr`, `int (R)` |`nuint`, `UIntPtr`, `uint (R)` |
|op_BitwiseAnd 					| & 					  |N/A      	  |N/A               |`nint`, `IntPtr`, `int (R)` |`nuint`, `UIntPtr`, `uint (R)` |
|op_BitwiseOr 					| |						  |N/A      	  |N/A               |`nint`, `IntPtr`, `int (R)` |`nuint`, `UIntPtr`, `uint (R)` |
|op_LogicalAnd 					| &&					  |
|op_LogicalOr  					| ||					  |
|op_Assign  					| N/D (= is not the same) |
|op_LeftShift  					| <<					  |
|op_RightShift  				| >>					  |
|op_SignedRightShift  			| N/D					  |
|op_UnsignedRightShift			| N/D					  |
|op_Equality  					| ==					  |
|op_GreaterThan  				| >						  |
|op_LessThan  					| <						  |
|op_Inequality  				| !=					  |
|op_GreaterThanOrEqual			| >=					  |
|op_LessThanOrEqual  			| <=					  |
|op_UnsignedRightShiftAssignment| Not defined			  |
|op_MemberSelection  			| ->					  |
|op_RightShiftAssignment  		| >>=					  |
|op_MultiplicationAssignment  	| \*=					  |
|op_PointerToMemberSelection  	| ->\*					  |
|op_SubtractionAssignment  		| -=					  |
|op_ExclusiveOrAssignment  		| ^=					  |
|op_LeftShiftAssignment  		| <<=					  |
|op_ModulusAssignment  			| %=					  |
|op_AdditionAssignment  		| +=					  |
|op_BitwiseAndAssignment  		| &=					  |
|op_BitwiseOrAssignment  		| |=					  |
|op_Comma  						| ,						  |
|op_DivisionAssignment  		| /=					  |

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


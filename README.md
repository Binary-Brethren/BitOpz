** README IS WORK IN PROGRESS **

# BitOpz - Bit Manipulation Extension Library for Unmanaged Types in C#

## Overview

**BitOpz** is a C# library providing a comprehensive set of extension methods for bit manipulation on unsigned unmanaged types (e.g., `byte`, `ushort`, `uint`, `ulong`). This library is designed for developers who work with low-level file parsing or require precise control over bitwise operations on data fields up to 64-bits in size. With BitOpz, you can perform advanced bit manipulations and parsing techniques through straightforward extension methods.

## Features

#### Signed functions treat unsigned values as signed only during the operation and return the modified result in its original unsigned form.
- **Shift Operations**: Shift bits left or right, with support for both unsigned and signed interpretations.
- **Roll Operations**: Roll bits left or right, with support for both unsigned and signed interpretations.
- **Endian Flip Operations**: Flip the endianness of bytes as required for parsing multi-byte-fields.

## Example Usage

Here's how you can use the BitOpz extensions on various unsigned types for common bitwise operations:

#### Unsigned Shift Operations

```
byte value = 0b10010001
byte shiftedLeft = value.ShiftLeft(2);   // Result: 0b01000100
byte shiftedRight = value.ShiftRight(2); // Result: 0b00100100
```

#### Signed Shift Operations

```
byte value = 0b10010001
byte signedShiftedLeft = value.SignShiftLeft(2);   // Result: 0b11000100
byte signedShiftedRight = value.SignShiftRight(2); // Result: 0b10000100
```

#### Unsigned Roll Operations

```
byte value = 0b10010001
byte rolledLeft = value.RollLeft(2);   // Result: 0b01000110
byte rolledRight = value.RollRight(2); // Result: 0b01100100
```

#### Signed Roll Operations

```
byte value = 0b10010001
byte signedRolledLeft = value.SignRollLeft(2);   // Result: 0b11000100
byte signedRolledRight = value.SignRollRight(2); // Result: 0b10100100
```

#### Endian Flip Operations

```
ushort value = 0xC0DE;
ushort endianFlipped = value.FlipEndian(); // Result: 0xDEC0
```

In each example, the method returns the modified value in its unsigned form, maintaining compatibility with unsigned data while allowing signed interpretations where needed.

#### Casting Unsigned Returns
```
ushort value = 0xC0DED00D;
short signedCastValue = (short)value.ShiftLeft(2);
```

## Installation

To add **BitOpz** to your project, simply install the package from NuGet.

```
dotnet add package Binary-Brethren/BitOpz
```

### Installing via NuGet Package Manager

1. Open your project in Visual Studio.
2. Right-click on the solution in the Solution Explorer and select **Manage NuGet Packages**.
3. In the NuGet Package Manager, search for **Binary-Brethren/BitOpz**.
4. Select the package and click **Install** to add it to your project.

You can also visit [NuGet.org](https://www.nuget.org/packages/Binary-Brethren.BitOpz) for additional details and instructions.

Once installed, the BitOpz extension methods will be ready for immediate use across all supported unsigned types. This will allow you to leverage powerful bit manipulation capabilities, enhancing your manual parsing and low-level file operations.

## Documentation

** THIS SECTION IS WORK IN PROGRESS **

### Shift Operations

- **`ShiftLeft`** and **`ShiftRight`**: Standard bit-shift methods for left and right shifting.
- **`SignShiftLeft`** and **`SignShiftRight`**: Treats unsigned values as signed only for the operation, applying a mask to ensure the returned value remains within unsigned bounds.

### Roll Operations

- **`RollLeft`** and **`RollRight`**: Performs a bitwise roll (rotate) left or right, moving the overflow bits around to the opposite side.
- **`SignRollLeft`** and **`SignRollRight`**: Performs the roll as if the unsigned value were signed, maintaining sign-bit integrity.

### Endian Flip Operations

- **`FlipEndian`**: Changes the endianness of the value, swapping byte order for compatibility with different hardware architectures or file formats.

## License

This project is licensed under the [MIT License](LICENSE), so feel free to use and modify the code as needed for your projects.

---

BitOpz simplifies bit manipulation, bringing essential operations to your fingertips while handling unsigned types as efficiently as possible. Happy parsing!



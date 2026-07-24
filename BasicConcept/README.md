# Day 1 – Introduction to .NET & C#

> Date: 22 July 2026

---

# What is .NET?

.NET is a **free, open-source, cross-platform development platform** developed by Microsoft for building different types of applications.

It provides:

* CLR (Common Language Runtime)
* Base Class Libraries (BCL)
* SDK (Software Development Kit)
* Compilers
* Tools for development

Using .NET, developers can build:

* Console Applications
* Desktop Applications
* Web Applications
* Mobile Applications
* Cloud Applications
* APIs
* Games
* AI Applications

---

# Why is .NET Used?

.NET simplifies software development by providing:

* Ready-made libraries
* Automatic memory management
* High performance
* Security
* Cross-platform support
* Easy deployment
* Large developer community

---

# Where is .NET Used?

## Web Development

* ASP.NET Core
* E-commerce websites
* Banking portals
* Hospital Management Systems

## Desktop Applications

* Windows Forms
* WPF

Examples:

* Calculator
* Paint
* Visual Studio

## Backend APIs

REST APIs for:

* Mobile applications
* Web applications
* Microservices

## Mobile Development

Using .NET MAUI

* Android
* iOS

## Cloud Development

Azure Cloud

## Game Development

Unity Game Engine uses C#.

Popular games include:

* Among Us
* Cuphead
* Pokémon Go

---

# .NET Framework vs Modern .NET

| .NET Framework        | Modern .NET             |
| --------------------- | ----------------------- |
| Windows only          | Cross-platform          |
| Older technology      | Modern platform         |
| Limited updates       | Actively developed      |
| Version 4.8 is latest | .NET 8, .NET 9, .NET 10 |

---

# .NET Architecture

```
Application

↓

C# Source Code

↓

C# Compiler

↓

IL (Intermediate Language)

↓

CLR (Common Language Runtime)

↓

Machine Code

↓

Operating System
```

---

# Components of .NET

## CLR (Common Language Runtime)

Responsible for:

* Program execution
* Garbage Collection
* Memory Management
* Exception Handling
* Security
* Thread Management

Equivalent to JVM in Java.

---

## CTS (Common Type System)

Provides common data types across all .NET languages.

Example:

```
C#
int

VB.NET
Integer

F#
int
```

All become the same internally.

---

## CLS (Common Language Specification)

Defines rules that every .NET language follows to ensure interoperability.

---

## BCL (Base Class Library)

Provides thousands of pre-built classes.

Examples:

* Console
* File
* Math
* String
* DateTime
* List
* Dictionary

---

# What is Visual Studio?

Visual Studio is Microsoft's Integrated Development Environment (IDE).

It includes:

* Code Editor
* Compiler
* Debugger
* IntelliSense
* Git Integration
* Package Manager
* Project Explorer

---

# Visual Studio vs VS Code

| Visual Studio                     | VS Code                            |
| --------------------------------- | ---------------------------------- |
| Complete IDE                      | Lightweight Code Editor            |
| Built for .NET                    | Supports many languages            |
| Includes compiler and debugger    | Requires extensions                |
| Better for enterprise development | Better for lightweight development |
| Larger installation               | Small installation                 |

---

# What is an IDE?

IDE stands for **Integrated Development Environment**.

It combines:

* Source Code Editor
* Compiler
* Debugger
* Terminal
* Build Tools
* Project Management

Examples:

* Visual Studio
* IntelliJ IDEA
* Android Studio
* PyCharm

---

# What is C#?

C# (pronounced **C Sharp**) is an object-oriented programming language developed by Microsoft.

Designed specifically for the .NET platform.

Features:

* Object-Oriented
* Strongly Typed
* Modern
* Secure
* High Performance

---

# Why is C# Used with .NET?

.NET provides libraries and runtime.

C# uses these libraries to build applications.

Example:

```csharp
Console.WriteLine("Hello World");
```

`Console` belongs to the .NET Base Class Library.

---

# Creating a Console Application

Using the .NET CLI:

```bash
dotnet new console
```

Run the application:

```bash
dotnet run
```

---

# First C# Program

```csharp
using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}
```

---

# Understanding the Program Structure

## using System;

Imports the `System` namespace.

Equivalent in Java:

```java
import java.util.*;
```

---

## namespace

Groups related classes.

Equivalent to Java packages.

---

## class

Blueprint for creating objects.

---

## internal

Access modifier.

Accessible only within the same project (assembly).

Unlike Java, C# has the `internal` access modifier.

---

## static

Belongs to the class rather than an object.

`Main()` must be static because it executes before any object is created.

---

## void

Indicates that the method does not return any value.

---

## Main()

Entry point of every C# console application.

Program execution starts here.

---

# Console.Write() vs Console.WriteLine()

## Console.Write()

Prints output without moving to the next line.

```csharp
Console.Write("Hello ");
Console.Write("World");
```

Output:

```
Hello World
```

---

## Console.WriteLine()

Prints output and moves the cursor to the next line.

```csharp
Console.WriteLine("Hello");
Console.WriteLine("World");
```

Output:

```
Hello
World
```

---

# Keywords

## using

Imports namespaces.

---

## namespace

Organizes related classes.

---

## public

Accessible from anywhere.

---

## private

Accessible only within the class.

---

## internal

Accessible only within the same assembly/project.

---

# Solution vs Project vs Namespace vs Java Package

## C#

```
Solution
    ↓
Projects
    ↓
Namespaces
    ↓
Classes
```

## Java

```
Project
    ↓
Packages
    ↓
Classes
```

---

# Variables

Declaration

```csharp
int age;
```

Initialization

```csharp
age = 20;
```

Declaration + Initialization

```csharp
int age = 20;
```

---

# Data Types

| Data Type | Size                   | Description                               |
| --------- | ---------------------- | ----------------------------------------- |
| bool      | 1 byte (logical value) | true or false                             |
| byte      | 1 byte                 | 0 to 255                                  |
| sbyte     | 1 byte                 | -128 to 127                               |
| short     | 2 bytes                | Small integers                            |
| ushort    | 2 bytes                | Unsigned short                            |
| int       | 4 bytes                | Most commonly used integer                |
| uint      | 4 bytes                | Unsigned integer                          |
| long      | 8 bytes                | Large integer                             |
| ulong     | 8 bytes                | Unsigned long                             |
| float     | 4 bytes                | Single precision                          |
| double    | 8 bytes                | Double precision                          |
| decimal   | 16 bytes               | High precision for financial calculations |
| char      | 2 bytes                | Unicode character                         |
| string    | Reference Type         | Sequence of characters                    |

---

# Input and Output

Input

```csharp
string name = Console.ReadLine();
```

Integer Input

```csharp
int age = int.Parse(Console.ReadLine());
```

Double Input

```csharp
double salary = double.Parse(Console.ReadLine());
```

Output

```csharp
Console.WriteLine(name);
```

---

# Type Casting

## Implicit Casting

Smaller type → Larger type

```csharp
int a = 10;
double b = a;
```

No data loss.

---

## Explicit Casting

Larger type → Smaller type

```csharp
double d = 10.75;
int a = (int)d;
```

Output:

```
10
```

Fractional part is discarded.

---

## Double to Float

```csharp
double d = 25.78;
float f = (float)d;
```

Explicit cast required because `double` has higher precision than `float`.

---

# Operators

## Arithmetic

```
+
-
*
/
%
```

---

## Relational

```
==
!=
<
>
<=
>=
```

---

## Logical

```
&&
||
!
```

---

## Assignment

```
=
+=
-=
*=
/=
%=
```

---

## Increment / Decrement

```
++
--
```

---

## Bitwise

```
&
|
^
~
<<
>>
```

---

## Ternary Operator

```csharp
string result = age >= 18 ? "Adult" : "Minor";
```

---

# Operator Precedence

Highest to Lowest

1. `()`
2. Unary (`++`, `--`, `!`)
3. `*`, `/`, `%`
4. `+`, `-`
5. Relational Operators
6. Equality Operators
7. Logical AND (`&&`)
8. Logical OR (`||`)
9. Assignment (`=`)

---

# Conditional Statements

## if

```csharp
if (age >= 18)
{
    Console.WriteLine("Eligible");
}
```

---

## if-else

```csharp
if (marks >= 40)
{
    Console.WriteLine("Pass");
}
else
{
    Console.WriteLine("Fail");
}
```

---

## else-if

```csharp
if (marks >= 90)
{
    Console.WriteLine("Grade A");
}
else if (marks >= 75)
{
    Console.WriteLine("Grade B");
}
else
{
    Console.WriteLine("Grade C");
}
```

---

# Loops

## for Loop

Used when the number of iterations is known.

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

---

## while Loop

Executes while the condition remains true.

```csharp
int i = 1;

while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
```

---

## do-while Loop

Executes at least once.

```csharp
int i = 1;

do
{
    Console.WriteLine(i);
    i++;
}
while (i <= 5);
```

---

## foreach Loop

Used for iterating through arrays and collections.

```csharp
int[] numbers = {1, 2, 3};

foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

---

# Mandatory Main Function

Every C# console application starts execution from:

```csharp
static void Main(string[] args)
{
    // Program starts here
}
```

---

# C# vs Java

| Feature                    | C#            | Java                       |
| -------------------------- | ------------- | -------------------------- |
| Runtime                    | CLR           | JVM                        |
| Language Developer         | Microsoft     | Sun Microsystems (Oracle)  |
| Primary IDE                | Visual Studio | IntelliJ IDEA / Eclipse    |
| Package System             | Namespace     | Package                    |
| Access Modifier `internal` | Yes           | No                         |
| Properties (`get`/`set`)   | Built-in      | Uses getter/setter methods |
| Cross-platform             | Yes (.NET)    | Yes (JVM)                  |

---

# Summary

Today I learned:

* Introduction to .NET
* Why .NET is used
* Applications of .NET
* .NET Framework vs Modern .NET
* CLR, CTS, CLS and BCL
* Visual Studio and VS Code
* IDE
* C# basics
* .NET architecture
* Console applications
* Structure of the first C# program
* `Console.Write()` vs `Console.WriteLine()`
* Keywords: `using`, `namespace`, `public`, `internal`
* Solution, Project and Namespace
* Variables and data types
* Input and output
* Type casting
* Operators
* Operator precedence
* Conditional statements
* Loops
* `Main()` method
* C# vs Java

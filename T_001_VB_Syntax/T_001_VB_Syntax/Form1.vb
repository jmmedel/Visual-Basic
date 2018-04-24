



'Visual Basic .NET (VB.NET) Is an Object-oriented computer programming language implemented On the .NET Framework. Although it Is an evolution Of classic Visual Basic language, it Is Not backwards-compatible With VB6, And any code written In the old version does Not compile under VB.NET.

'Like all other .NET languages, VB.NET has complete support for object-oriented concepts. Everything in VB.NET Is an object, including all of the primitive types (Short, Integer, Long, String, Boolean, etc.) And user-defined types, events, And even assemblies. All objects inherits from the base class Object.

'VB.NET Is implemented by Microsofts .NET framework. Therefore, it has full access To all the libraries In the .Net Framework. Its also possible To run VB.NET programs On Mono, the open-source alternative To .NET, Not only under Windows, but even Linux Or Mac OSX.

'The following reasons make VB.Net a widely used professional language

'Modern, general purpose.

'Object oriented.

'Component oriented.

'Easy to learn.

'Structured language.

'It produces efficient programs.

'It can be compiled On a variety Of computer platforms.

'Part of .Net Framework.

'Strong Programming Features VB.Net
'VB.Net has numerous strong programming features that make it endearing to multitude of programmers worldwide. Let us mention some of these features

'Boolean Conditions

'Automatic Garbage Collection

'Standard Library

'Assembly Versioning

'Properties And Events

'Delegates And Events Management

'Easy-to-use Generics

'Indexers

'Conditional Compilation

'Simple Multithreading

'In this chapter, we will discuss the tools available for creating VB.Net applications.

'We have already mentioned that VB.Net Is part Of .Net framework And used For writing .Net applications. Therefore before discussing the available tools For running a VB.Net program, Let us understand how VB.Net relates To the .Net framework.

'The.Net Framework
'The.Net framework Is a revolutionary platform that helps you to write the following types of applications:

'Windows applications

'Web applications

'Web services

'The.Net framework applications are multi-platform applications. The framework has been designed in such a way that it can be used from any of the following languages: Visual Basic, C#, C++, Jscript, And COBOL, etc.

'All these languages can access the framework As well As communicate With Each other.

'The.Net framework consists of an enormous library of codes used by the client languages Like VB.Net. These languages use object-oriented methodology.

'Following are some Of the components Of the .Net framework:

'Common Language Runtime (CLR)

'The.Net Framework Class Library

'Common Language Specification

'Common Type System

'Metadata And Assemblies

'Windows Forms

'ASP.Net And ASP.Net AJAX

'ADO.Net

'Windows Workflow Foundation (WF)

'Windows Presentation Foundation

'Windows Communication Foundation (WCF)

'LINQ

'For the jobs each of these components perform, please see ASP.Net - Introduction, And for details of each component, please consult Microsoft's documentation.

'Integrated Development Environment (IDE) For VB.Net
'Microsoft provides the following development tools For VB.Net programming:

'Visual Studio 2010 (VS)

'Visual Basic 2010 Express (VBE)

'Visual Web Developer

'The last two are free. Using these tools, you can write all kinds Of VB.Net programs from simple command-line applications To more complex applications. Visual Basic Express And Visual Web Developer Express edition are trimmed down versions Of Visual Studio And has the same look And feel. They retain most features Of Visual Studio. In this tutorial, we have used Visual Basic 2010 Express And Visual Web Developer (For the web programming chapter).

'You can download it from here. It gets automatically installed In your machine. Please note that you need an active internet connection For installing the express edition.

'Writing VB.Net Programs On Linux Or Mac OS
'Although the.NET Framework runs On the Windows operating system, there are some alternative versions that work On other operating systems. Mono Is an open-source version Of the .NET Framework which includes a Visual Basic compiler And runs On several operating systems, including various flavors Of Linux And Mac OS. The most recent version Is VB 2012.

'The stated purpose Of Mono Is Not only To be able To run Microsoft .NET applications cross-platform, but also To bring better development tools To Linux developers. Mono can be run On many operating systems including Android, BSD, iOS, Linux, OS X, Windows, Solaris And UNIX.


'Before we study basic building blocks Of the VB.Net programming language, Let us look a bare minimum VB.Net program Structure so that we can take it As a reference In upcoming chapters.

'VB.Net Hello World Example
'A VB.Net program basically consists Of the following parts

'Namespace declaration

'A Class or Module

'One Or more procedures

'Variables

'The Main procedure

'Statements & Expressions

'Comments

'Let us look at a simple code that would print the words "Hello World"

'Imports System
'        Module Module1
'            'This program will display Hello World 
'            Sub Main()
'                Console.WriteLine("Hello World")
'                Console.ReadKey()
'            End Sub
'        End Module
'When the above code Is compiled And executed, it produces the following result:

'Hello, World!
'Let us look various parts of the above program:

'The first line Of the program Imports System Is used To include the System Namespace In the program.

'The next line has a Module declaration, the module Module1. VB.Net Is completely object oriented, so every program must contain a module of a class that contains the data And procedures that your program uses.

'Classes Or Modules generally would contain more than one procedure. Procedures contain the executable code, Or in other words, they define the behavior of the class. A procedure could be any of the following

'Function

'Sub

'Operator

'Get

'Set

'AddHandler

'RemoveHandler

'RaiseEvent

'The next line( 'This program) will be ignored by the compiler and it has been put to add additional comments in the program.

'The next line defines the Main procedure, which Is the entry point for all VB.Net programs. The Main procedure states what the module Or class will do when executed.

'The Main procedure specifies its behavior with the statement

'Console.WriteLine("Hello World")

'            WriteLine Is a method of the Console class defined in the System namespace. This statement causes the message "Hello, World!" to be displayed on the screen.
'The last line Console.ReadKey() Is for the VS.NET Users. This will prevent the screen from running And closing quickly when the program Is launched from Visual Studio .NET.

'Compile & Execute VB.Net Program
'If you Then are Using Visual Studio.Net IDE, take the following steps

'Start Visual Studio.

'On the menu bar, choose File, New, Project.

'Choose Visual Basic from templates

'Choose Console Application.

'Specify a name And location For your project Using the Browse button, And then choose the OK button.

'The New project appears in Solution Explorer.

'Write code in the Code Editor.

'Click the Run button Or the F5 key to run the project. A Command Prompt window appears that contains the line Hello World.

'You can compile a VB.Net program by using the command line instead of the Visual Studio IDE

'Open a text editor And add the above mentioned code.

'Save the file as helloworld.vb

'Open the command prompt tool And go to the directory where you saved the file.

'Type vbc helloworld.vb And press enter to compile your code.

'If there Then are no errors In your code the command prompt will take you To the Next line And would generate helloworld.exe executable file.

'Next, type helloworld to execute your program.

'You will be able to see "Hello World" printed on the screen.




Imports System
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Hello world")
    End Sub
End Class

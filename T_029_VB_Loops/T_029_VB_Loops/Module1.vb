
'VB.Net -Loops

'There may be a situation When you need To execute a block Of code several number Of times. In general, statements are executed sequentially: The first statement In a Function Is executed first, followed by the second, And so On.

'Programming languages provide various control structures that allow For more complicated execution paths.

'A loop statement allows us to execute a statement Or group of statements multiple times And following Is the general form of a loop statement in most of the programming languages
'    VB.Net provides following types of loops to handle looping requirements. Click the following links to check their details.

'Loop Type	Description
'Do Loop

'It repeats the enclosed block Of statements While a Boolean condition Is True Or until the condition becomes True. It could be terminated at any time With the Exit Do statement.
'For ...Next

'It repeats a group Of statements a specified number Of times And a Loop index counts the number Of Loop iterations As the Loop executes.
'For Each ...Next

'It repeats a group Of statements For Each element In a collection. This Loop Is used For accessing And manipulating all elements In an array Or a VB.Net collection.
'While ... End While

'It executes a series Of statements As Long As a given condition Is True.
'With ... End With

'It Is Not exactly a looping construct. It executes a series of statements that repeatedly refer to a single object Or structure.
'Nested loops

'You can use one Or more loops inside any another While, For Or Do Loop.
'Loop Control Statements
'Loop control statements change execution from its normal sequence. When execution leaves a scope, all automatic objects that were created in that scope are destroyed.

'VB.Net provides the following control statements. Click the following links to check their details.

'Control Statement	Description
'Exit statement

'Terminates the Loop Or Select Case statement And transfers execution To the statement immediately following the Loop Or Select Case.
'Continue Do statement

'Causes the Loop To skip the remainder Of its body And immediately retest its condition prior To reiterating.
'GoTo statement

'Transfers control To the labeled statement. Though it Is Not advised To use GoTo statement In your program.

Module Module1

    Sub Main()

    End Sub

End Module

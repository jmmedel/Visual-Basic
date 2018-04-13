''' <summary>
''' Represents a human being
''' </summary>
''' <remarks>
''' <list type="number">
''' <item><term>Action one</term></item>
''' <item><description>Instantiate the class</description></item>
''' <item><description>Populate its properties</description></item>
''' <item><description>Eventually retrieve the full name</description></item>
''' </list>
''' </remarks>
Public Class Person

    ''' <summary>
    ''' Contains the person's first name
    ''' </summary>
    ''' <value>Person's first name</value>
    ''' <returns>String</returns>
    ''' <remarks>Use the <see cref="LastName"/>
    ''' property for the person's last name</remarks>
    Public Overridable Property FirstName As String

    ''' <summary>
    ''' Contains the person's last name
    ''' </summary>
    ''' <value>Person's last name</value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Overridable Property LastName As String


    ''' <include file="ExternalDoc.xml" path="Help/Property[@name='Age']"/>
    Public Overridable Property Age As Integer

    ''' <summary>
    ''' Gets the complete person's name
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks>This method concatenates <c>LastName</c> and 
    ''' <c>FirstName</c> properties
    ''' <para>
    ''' <example>This example shows how you can invoke
    ''' the <c>GetFullName</c> method
    ''' <code>
    ''' Dim result As String = Person1.GetFullName()
    ''' </code>
    ''' </example>
    ''' </para>
    ''' </remarks>
    ''' <exception cref="NullReferenceException">
    ''' The exception is thrown when properties are Nothing
    ''' </exception>
    ''' <permission cref="System.Security.Permissions.UIPermission"/>
    Public Overridable Function GetFullName() As String
        Dim fn As New Text.StringBuilder
        fn.Append(Me.FirstName)
        fn.Append(" ")
        fn.Append(Me.LastName)
        Return fn.ToString
    End Function

    ''' <summary>
    ''' Gets the complete person's name
    ''' </summary>
    ''' <param name="Title"></param>
    ''' <exception cref="ArgumentNullException">
    ''' The exception that is thrown when <paramref name="Title"/> is Nothing
    ''' </exception>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Overridable Function GetFullName(ByVal Title As String) As String

        If String.IsNullOrEmpty(Title) = True Then Throw New ArgumentNullException

        Dim fn As New Text.StringBuilder
        fn.Append(Title)
        fn.Append(" ")
        fn.Append(Me.FirstName)
        fn.Append(" ")
        fn.Append(Me.LastName)
        Return fn.ToString
    End Function


End Class

''' <summary>
''' A test class
''' </summary>
''' <typeparam name="T">
''' A type parameter that must implement IEnumerable
''' </typeparam>
''' <remarks></remarks>
Public Class TestGenerics(Of T As IEnumerable)

End Class
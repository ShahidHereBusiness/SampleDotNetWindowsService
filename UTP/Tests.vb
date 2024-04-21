Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class Tests

    <TestMethod()> Public Sub TestCase()
        Console.WriteLine(SOA.MakeDeminish.LogEvent("Hello Windows Event Viewer Log"))
    End Sub

End Class
Imports System.Diagnostics
Imports System.Linq.Expressions
Imports SOAV

Public Class MakeDeminish
    Public Shared Property Source As String = "TimeTriggerApi"
    Public Shared Property LogName As String = "TemporalApp"
    Public Shared Property CountDown As Double = 60000D
    Public Shared Function LogEvent(ByVal str As String) As Boolean
        Try
            If Not SOAV.Validation.ErrorFormat(str) Then
                Using lev As New LogEventViewer(Source, LogName)
                    If Not lev.MarkEventLog(str, Source) Then
                        Throw New Exception("EventViewer Log Failed")
                    End If
                End Using

                Return True
            End If
        Catch ex As Exception
            SOAV.LogManager.FileSystemLog("\DevLogs\", "DotNetSystemTimerService:LogEvent:Exception", $"Input:{str},Exception:{ex}")
        Finally
            SOAV.LogManager.FileSystemLog("\DevLogs\", "DotNetSystemTimerService:LogEvent", $"Input:{str}")
        End Try
        Return False
    End Function
End Class
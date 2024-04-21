Public Class TemporalService
#Region "System.Timers.Timer"
    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
        SOA.MakeDeminish.LogEvent("The event was OnStart.")
        SetTimer()
    End Sub
    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
        timerSOA.Enabled = False
        SOA.MakeDeminish.LogEvent("The event was OnStop.")
    End Sub
    Private Sub TimerSOA_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles timerSOA.Elapsed
        timerSOA.Enabled = False
        SOA.MakeDeminish.LogEvent($"The Elapsed event was raised at {DateTime.Now.ToString("yyyy-MM-dd::HH:mm:ss:fff")}")
        timerSOA.Enabled = True
    End Sub
#End Region
    Private Sub SetTimer()
        timerSOA.Interval = SOA.MakeDeminish.CountDown
        timerSOA.AutoReset = True
        timerSOA.Enabled = True
    End Sub
    Protected Overrides Sub Finalize()
        GC.Collect()
    End Sub
End Class

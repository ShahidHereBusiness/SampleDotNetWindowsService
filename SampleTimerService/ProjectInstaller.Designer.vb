<System.ComponentModel.RunInstaller(True)> Partial Class ProjectInstaller
    Inherits System.Configuration.Install.Installer

    'Installer overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SampleServiceProcessInstaller = New System.ServiceProcess.ServiceProcessInstaller()
        Me.SampleServiceInstaller = New System.ServiceProcess.ServiceInstaller()
        '
        'SampleServiceProcessInstaller
        '
        Me.SampleServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalService
        Me.SampleServiceProcessInstaller.Password = Nothing
        Me.SampleServiceProcessInstaller.Username = Nothing
        '
        'SampleServiceInstaller
        '
        Me.SampleServiceInstaller.Description = "Sample Temporal Dot Net VB Window Service"
        Me.SampleServiceInstaller.DisplayName = "Sample Temporal SOA"
        Me.SampleServiceInstaller.ServiceName = "SampleSOA"
        '
        'ProjectInstaller
        '
        Me.Installers.AddRange(New System.Configuration.Install.Installer() {Me.SampleServiceProcessInstaller, Me.SampleServiceInstaller})

    End Sub

    Friend WithEvents SampleServiceProcessInstaller As ServiceProcess.ServiceProcessInstaller
    Friend WithEvents SampleServiceInstaller As ServiceProcess.ServiceInstaller
End Class

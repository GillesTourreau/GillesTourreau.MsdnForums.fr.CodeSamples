Imports System.Threading

Public Class Form1
    Private _Logger As Logger
    Private _Protocol As Protocol

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Logger = New Logger(Me.RTB_Logs)
        _Protocol = New Protocol(_Logger)
    End Sub
End Class

Public Class Logger
    Private _Target As RichTextBox

    Sub New(Target As RichTextBox)
        Me._Target = Target
    End Sub

    Public Sub WriteLog(ByVal Text As String)
        _Target.Invoke(Sub() _Target.AppendText(Text))
    End Sub
End Class

Public Class Protocol
    Private _Thread As Thread
    Private _Logger As Logger

    Public Sub New(ByVal Logger As Logger)
        _Logger = Logger
        _Thread = New Thread(AddressOf SubThread)
        _Thread.Start()
    End Sub

    Private Sub SubThread()
        While True
            _Logger.WriteLog("Test")
        End While
    End Sub
End Class
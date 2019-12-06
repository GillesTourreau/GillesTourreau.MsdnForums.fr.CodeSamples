Imports System.Runtime.InteropServices

Public Class Form1
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function FindWindow( _
         ByVal lpClassName As String, _
         ByVal lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function GetWindow( _
         ByVal hWnd As IntPtr, _
         ByVal uCmd As UInteger) As IntPtr
    End Function

    Private Enum GetWindowCmd As UInteger
        GW_CHILD = 5
    End Enum

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function ShowWindow( _
         ByVal hwnd As IntPtr, _
         ByVal nCmdShow As Int32) As Boolean
    End Function

    Private Enum SW As Int32
        Hide = 0
        ShowNoActivate = 4
        Max = 11
    End Enum

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function IsWindowVisible(ByVal hwnd As IntPtr) As Boolean
    End Function

    Private Sub Toggle()
        Dim hWnd As IntPtr = FindWindow("ProgMan", Nothing)
        hWnd = GetWindow(hWnd, GetWindowCmd.GW_CHILD)

        If IsWindowVisible(hWnd) Then
            ShowWindow(hWnd, SW.Hide)
        Else
            ShowWindow(hWnd, 5)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Toggle()
    End Sub
End Class

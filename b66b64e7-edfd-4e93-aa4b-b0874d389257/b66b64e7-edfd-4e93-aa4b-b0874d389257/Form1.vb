Imports System.IO

Public Class Form1

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub PopulateTreeView()
        Dim rootNode As TreeNode

        Dim info As New DirectoryInfo("C:\")


        If info.Exists Then

            rootNode = New TreeNode(info.Name)
            rootNode.Tag = info
            GetDirectories(info.GetDirectories(), rootNode)
            TreeView1.Nodes.Add(rootNode)
        End If

    End Sub

    Private Sub GetDirectories(ByVal subDirs() As DirectoryInfo, ByVal nodeToAddTo As TreeNode)

        Dim aNode As TreeNode
        Dim subSubDirs() As DirectoryInfo
        Dim subDir As DirectoryInfo
        For Each subDir In subDirs

            ' Si le répertoire est un répertoire système, l'ignorer
            If (subDir.Attributes And FileAttributes.System) = FileAttributes.System Then
                Continue For
            End If

            ' Si le répertoire est un répertoire caché, l'ignorer
            If (subDir.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                Continue For
            End If

            aNode = New TreeNode(subDir.Name, 0, 0)
            aNode.Tag = subDir
            aNode.ImageKey = "folder"
            Try
                subSubDirs = subDir.GetDirectories()
            Catch e As UnauthorizedAccessException
                subSubDirs = Nothing
            End Try
            If Not subSubDirs Is Nothing Then
                If subSubDirs.Length <> 0 Then
                    GetDirectories(subSubDirs, aNode)
                End If
            End If
            nodeToAddTo.Nodes.Add(aNode)
        Next subDir

    End Sub

    Public Sub New()
        InitializeComponent()
        PopulateTreeView()

    End Sub 'New

    Private Sub treeView1_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick

        Dim newSelected As TreeNode = e.Node
        ListView1.Items.Clear()
        Dim nodeDirInfo As DirectoryInfo = CType(newSelected.Tag, DirectoryInfo)
        Dim subItems() As ListViewItem.ListViewSubItem
        Dim item As ListViewItem = Nothing

        Dim dir As DirectoryInfo
        For Each dir In nodeDirInfo.GetDirectories()
            item = New ListViewItem(dir.Name, 0)
            subItems = New ListViewItem.ListViewSubItem() {New ListViewItem.ListViewSubItem(item, "Directory"), New ListViewItem.ListViewSubItem(item, _
                dir.LastAccessTime.ToShortDateString())}

            item.SubItems.AddRange(subItems)
            ListView1.Items.Add(item)
        Next dir
        Dim file As FileInfo
        For Each file In nodeDirInfo.GetFiles()
            item = New ListViewItem(file.Name, 1)
            subItems = New ListViewItem.ListViewSubItem() {New ListViewItem.ListViewSubItem(item, "File"), New ListViewItem.ListViewSubItem(item, _
                file.LastAccessTime.ToShortDateString())}

            item.SubItems.AddRange(subItems)
            ListView1.Items.Add(item)
        Next file

        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

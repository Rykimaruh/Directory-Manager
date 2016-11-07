'*************************************
'*  FoldZ- Easy Directory Management  *
'*   Date: 8/30/2016                 *
'*   Author: Jonathan Nunez          *
'*************************************
'''...<details>This program basically lets users add multiple folders simply by writing their respective names. Users can 
''' users can choose location to save folders in. Aside from that, users can delete folders as well by writing their names regardless.</details>

Imports System.IO
Public Class Form1
    Dim i As Integer
    Dim count As Integer
    Dim names() As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowNewFolderButton = False
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NamingFolders()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = ""
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim About As New About.Form1
        Try
            About.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub AbToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbToolStripMenuItem.Click
        Delete_Directories.ShowDialog()
    End Sub

End Class

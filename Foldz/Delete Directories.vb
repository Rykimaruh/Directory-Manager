Public Class Delete_Directories
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
        DeleteFolders()
    End Sub

    Private Sub Delete_Directories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
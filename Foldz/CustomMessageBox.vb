Public Class CustomMessageBox
    Dim path As String = Form1.TextBox1.Text
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("explorer.exe", "/n," & IO.Path.GetFullPath(path))
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
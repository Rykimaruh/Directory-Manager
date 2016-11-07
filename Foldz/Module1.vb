Imports System.IO
Module Module1
    Dim i As Integer
    Dim foldernames() As String
    Dim folder, folderpropercasing As String
    Dim path As String = Form1.TextBox1.Text

    Public Sub NamingFolders()
        'makes a split in the string of textbox where there are commas
        folder = Trim(Form1.TextBox2.Text.Replace(" ", ""))
        folderpropercasing = StrConv(folder, VbStrConv.ProperCase)
        foldernames = folderpropercasing.Split(",")
        If Form1.TextBox2.Text = "" Or Form1.TextBox1.Text = "" Then
            Form1.Label3.Text = "No empty directory accepted!"
        Else
            For i = 0 To UBound(foldernames)
                If Directory.Exists(path + "\" & foldernames(i)) Then
                    'System.IO.File.Exists(path + "\" & foldernames(i))
                    'MessageBox.Show("One or more directories exist already")
                    CustomMessageBox.ShowDialog()
                    Exit For
                Else
                    Try
                        Directory.CreateDirectory(path + "\" & foldernames(i))
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            Next
            Process.Start("explorer.exe", "/n," & IO.Path.GetFullPath(path))
            Form1.Label3.Text = ""
        End If
        'from position 0 to the last, loop thru
    End Sub
    Public Sub DeleteFolders()
        'makes a split in the string of textbox where there are commas
        folder = Trim(Form1.TextBox2.Text.Replace(" ", ""))
        folderpropercasing = StrConv(folder, VbStrConv.ProperCase)
        foldernames = folderpropercasing.Split(",")

        If Delete_Directories.TextBox2.Text = "" Or Delete_Directories.TextBox1.Text = "" Then
            Delete_Directories.Label3.Text = "No empty directory accepted!"
        Else
            For i = 0 To UBound(foldernames)
                Try
                    If MessageBox.Show("Are you sure you want to delete?", "Delete Directories", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        Directory.Delete(path + "\" & foldernames(i)) 'keeps throwing error exception
                        Exit For
                    Else
                        MessageBox.Show("No directories exist to delete")
                    End If
                Catch e As InvalidExpressionException
                    MessageBox.Show(e.Message)
                End Try
            Next
            Delete_Directories.Label3.Text = ""
            Process.Start("explorer.exe", "/n," & IO.Path.GetFullPath(path))
        End If
        'from position 0 to the last, loop thru
    End Sub
End Module


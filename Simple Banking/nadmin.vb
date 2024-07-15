Imports MySql.Data.MySqlClient
Public Class nadmin
    Public cmd As New MySqlCommand
    Private Sub nadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Main.Enabled = True
        Main.BringToFront()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        If txt1.Text <> "" And txt2.Text <> "" Then
            cmd = New MySqlCommand("insert into manager values('" & txt1.Text & "','" & txt2.Text & "')")
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            MsgBox("Successfuly Save.", vbInformation)
            clear()
            Main.Enabled = True
            Main.BringToFront()
            Me.Dispose()
        Else
            MsgBox("Pls Fill up all the fields.")
        End If
        conn.Close()
    End Sub
    Sub clear()
        txt1.Clear()
        txt2.Clear()
    End Sub
End Class
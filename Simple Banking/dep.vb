Imports MySql.Data.MySqlClient
Public Class dep
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private Sub dep_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        If txt3.Text = "" Then
            MsgBox("Pls fill the Deposit Amount!", vbInformation)
        Else
            Dim bal, a, b As New Double
            a = txt3.Text
            b = txtbal.Text
            bal = a + b
            cmd = New MySqlCommand("update acc_bal set balance = " & bal & " where acc_number = '" & txt2.Text & "'", conn)
            cmd.ExecuteNonQuery()

            cmd = New MySqlCommand("Insert into deposit values ( '" & txt2.Text & "','" & txt1.Text & "','" & txtbal.Text & "','" & txt3.Text & "','" & bal & "','" & TextBox1.Text & "','" & TextBox2.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Successfuly Deposit.", vbInformation)
            clear()
            Main.useracc()
            Main.Enabled = True
            Main.BringToFront()
            Me.Dispose()
        End If
        conn.Close()
    End Sub

    Sub clear()
        txt3.Clear()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Dispose()
        Main.Enabled = True
        Main.BringToFront()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = Date.Today
        TextBox2.Text = TimeOfDay
    End Sub
End Class
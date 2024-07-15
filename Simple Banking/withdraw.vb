Imports MySql.Data.MySqlClient
Public Class withdraw
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private Sub withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Dispose()
        Main.Enabled = True
        Main.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        If txt3.Text = "" Then
            MsgBox("Pls input Amount to withdraw!", vbInformation)
        Else
            Dim bal2, amount As Double
            bal2 = txtbal.Text
            amount = txt3.Text

            If bal2 >= amount Then
                Dim bal, a, b As Double
                a = txt3.Text
                b = txtbal.Text
                bal = b - a
                cmd = New MySqlCommand("update acc_bal set balance = " & bal & " where acc_number = '" & txt2.Text & "'", conn)
                cmd.ExecuteNonQuery()

                cmd = New MySqlCommand("Insert into withdraw values ( '" & txt2.Text & "','" & txt1.Text & "','" & txtbal.Text & "','" & txt3.Text & "','" & bal & "','" & TextBox1.Text & "','" & TextBox2.Text & "')", conn)
                cmd.ExecuteNonQuery()
                MsgBox("success in withdrawal", vbInformation)
                Main.useracc()
                Main.Enabled = True
                Main.BringToFront()
                clear()
                Me.Dispose()
            Else
                MsgBox("You don't have enough balance!", vbInformation)
            End If
        End If
        conn.Close()
    End Sub

    Sub clear()
        txt3.Clear()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = Date.Today
        TextBox2.Text = TimeOfDay
    End Sub
End Class
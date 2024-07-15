Imports MySql.Data.MySqlClient
Public Class pbill
    Public cmd As New MySqlCommand
    Public no As Double
    Public name1 As String = ""
    Private Sub pbill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Dispose()
        Main.Enabled = True
        Main.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        If ComboBox1.Text = "" And TextBox2.Text = "" And TextBox1.Text = "" And TextBox3.Text = "" Then
            MsgBox("Pls Fill All the Fields before you Pay!", vbInformation)
        Else
            Dim bal2, amount As Double
            bal2 = txtbal.Text
            amount = TextBox3.Text

            If bal2 >= amount Then
                Dim bal, a, b As New Double
                a = TextBox3.Text
                b = txtbal.Text
                bal = b - a

                cmd = New MySqlCommand("update acc_bal set balance = " & bal & " where acc_number = '" & no & "'")
                cmd.Connection = conn
                cmd.ExecuteNonQuery()

                cmd = New MySqlCommand("Insert into pay_bill values('" & no & "','" & Name & "','" & ComboBox1.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & txtbal.Text & "','" & TextBox3.Text & "','" & bal & "','" & txtime.Text & "','" & txtdate.Text & "')")
                cmd.Connection = conn
                cmd.ExecuteNonQuery()
                MsgBox("Successfuly in Pay.", vbInformation)
                clear()
                Main.useracc()
                Main.Enabled = True
                Main.BringToFront()
                Me.Dispose()
            Else
                MsgBox("You don't have enough balance!", vbInformation)
            End If
        End If
        conn.Close()
    End Sub

    Sub clear()
        ComboBox1.SelectedIndex = -1
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtdate.Text = Date.Today
        txtime.Text = TimeOfDay
    End Sub

    Private Sub UguToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
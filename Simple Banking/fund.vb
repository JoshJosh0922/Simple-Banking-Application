Imports MySql.Data.MySqlClient
Public Class fund
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public gamer As Boolean = False
    Public name1 As String = ""
    Public balance, bal1, bal2, a, b, c, d As New Double
    Private Sub fund_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Dispose()
        Main.Enabled = True
        Main.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        Dim bal2, amount As Double
        bal2 = txtbal.Text
        amount = TextBox3.Text

        If bal2 >= amount Then
            b = txtbal.Text
            a = TextBox3.Text
            bal1 = b - a

            d = TextBox3.Text
            bal2 = c + d

            cmd = New MySqlCommand("update acc_bal set balance = " & bal2 & " where acc_number = '" & TextBox2.Text & "'")
            cmd.Connection = conn
            cmd.ExecuteNonQuery()

            cmd = New MySqlCommand("update acc_bal set balance = " & bal1 & " where acc_number = '" & TextBox1.Text & "'")
            cmd.Connection = conn
            cmd.ExecuteNonQuery()

            cmd = New MySqlCommand("insert into trancefer_fund values('" & TextBox1.Text & "','" & name1 & "','" & TextBox2.Text & "','" & txtbal.Text & "','" & TextBox3.Text & "','" & bal1 & "','" & txtdate.Text & "','" & txtime.Text & "')")
            cmd.Connection = conn
            cmd.ExecuteNonQuery()
            MsgBox("Successfuly in Transfer.", vbInformation)
            Main.useracc()
            clear()
            Main.Enabled = True
            Main.BringToFront()
        ElseIf TextBox3.Text = "" Then
            MsgBox("Pls input Amount to Pay!")
        Else
            
            MsgBox("You don't have enough balance!", vbInformation)
        End If
        conn.Close()
    End Sub

    Sub clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        If TextBox1.Text <> "" Then
            cmd = New MySqlCommand("Select * from acc_bal where acc_number = '" & TextBox2.Text & "'")
            cmd.Connection = conn
            dr = cmd.ExecuteReader
            While dr.Read()
                c = dr(2)
                gamer = True
            End While

            conn.Close()
        End If
        conn.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtdate.Text = Date.Today
        txtime.Text = TimeOfDay
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = "" Then
            MsgBox("Pls Fill the Amout to continue in Transaction.", vbInformation)
        ElseIf gamer = False Then
            MsgBox("Account Number not Found.", vbInformation)
        End If
    End Sub
End Class
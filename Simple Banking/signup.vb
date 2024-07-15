Imports MySql.Data.MySqlClient
Public Class signup
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public max, max2 As String

    Private Sub signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccId()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Main.Enabled = True
        Main.BringToFront()
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt3.UseSystemPasswordChar = False
        Else
            txt3.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txt1_Enter(sender As Object, e As EventArgs) Handles txt1.Enter
        If txt1.Text = "Name" Then
            txt1.Text = ""
        End If
    End Sub

    Private Sub txt1_Leave(sender As Object, e As EventArgs) Handles txt1.Leave
        If txt1.Text = "" Then
            txt1.Text = "Name"
        End If
    End Sub

    Private Sub txt3_Enter(sender As Object, e As EventArgs) Handles txt3.Enter
        If txt3.Text = "Password" Then
            txt3.Text = ""
            txt3.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txt3_Leave(sender As Object, e As EventArgs) Handles txt3.Leave
        If txt3.Text <> "" Then
            CheckBox1.Enabled = True
        End If
        If txt3.Text = "" Then
            txt3.UseSystemPasswordChar = False
            txt3.Text = "Password"
            If txt3.Text = "Password" Then
                CheckBox1.Enabled = False
            End If
        End If
    End Sub

    Private Sub txt4_Enter(sender As Object, e As EventArgs) Handles txt4.Enter
        If txt4.Text = "Deposit" Then
            txt4.Text = ""
        End If
    End Sub

    Private Sub txt4_Leave(sender As Object, e As EventArgs) Handles txt4.Leave
        If txt4.Text = "" Then
            txt4.Text = "Deposit"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        If txt1.Text = "Name" And txt3.Text = "Password" And txt4.Text = "Deposit" Then
            MsgBox("Pls Fill all the Fields before you Sign Up", vbCritical)
        Else
                AccId()
                conn.Open()
                cmd = New MySqlCommand
                'Dim res As Integer
                With cmd
                    .Connection = conn
                    .CommandText = "insert user values('" & txt1.Text & "','" & txt2.Text & "','" & txt3.Text & "')"
                    .ExecuteNonQuery()
                    .CommandText = "insert acc_bal values('" & txt1.Text & "','" & txt2.Text & "','" & txt4.Text & "')"
                    .ExecuteNonQuery()
                    .CommandText = "update acc_num set number = '" & max & "'"
                    .ExecuteNonQuery()
                    MsgBox("Successfuly Sign Up!", vbInformation, "Simple Banking")
                Me.Dispose()
                clear()
                Main.Enabled = True
                Main.BringToFront()
                End With
                conn.Close()
        End If
        'Catch ex As Exception
        '    MsgBox(ex)
        'End Try
    End Sub

    Sub clear()
        txt1.Clear()
        txt3.Clear()
        txt4.Clear()
    End Sub

    Sub AccId()
        conn.Open()
        Dim cmd As New MySqlCommand("Select Number from acc_num", conn)
        Dim dr As MySqlDataReader = cmd.ExecuteReader
        dr.Read()
        txt2.Text = Format(dr(0) + 1, "00000#")
        max = dr(0) + 1
        conn.Close()
        CheckBox1.Enabled = False
    End Sub
End Class
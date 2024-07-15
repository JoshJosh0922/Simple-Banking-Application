Imports MySql.Data.MySqlClient
Public Class cpin
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public pass As Boolean
    Public username As Boolean = False
    Public name1 As String

    Private Sub cpin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accuser()
    End Sub

    Sub accuser()
        conn.Open()
        cmd = New MySqlCommand("select * from user where acc_number ='" & name1 & "'")
        cmd.Connection = conn
        dr = cmd.ExecuteReader

        While dr.Read
            username = True
        End While

        conn.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Main.Enabled = True
        Main.useracc()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        Dim pass1, pass2 As String
        pass1 = TextBox2.Text
        pass2 = TextBox3.Text

        conn.Open()
        If TextBox2.Text = "" And TextBox3.Text = "" Then
            MsgBox("Pls Fill up all the fields before you change password!", vbInformation)
        Else
            If pass1 = pass2 Then
                If username = True Then
                    cmd = New MySqlCommand("update user set password = '" & TextBox2.Text & "'where acc_number ='" & name1 & "'", conn)
                Else
                    cmd = New MySqlCommand("update manager set password = '" & TextBox2.Text & "'where password = '" & TextBox1.Text & "'", conn)
                    'cmd.ExecuteNonQuery()
                End If
                cmd.ExecuteNonQuery()
                MsgBox("Successful Update " & cmd.CommandText)
                pass = False
                Main.Enabled = True
                Me.Dispose()
            Else
                MsgBox("New Password Not Match.", vbInformation)
            End If
        End If

            conn.Clone()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        If TextBox1.Text <> "" Then
            cmd.Connection = conn
            conn.Open()
            If username = False Then
                cmd.CommandText = "Select * from manager where password = '" & TextBox1.Text & "'"
                dr = cmd.ExecuteReader
                While dr.Read
                    pass = True
                End While
            Else
                cmd.CommandText = "Select * from user where password = '" & TextBox1.Text & "'"
                dr = cmd.ExecuteReader()
                While dr.Read
                    pass = True
                End While
            End If
            conn.Close()
        Else
            pass = False
        End If
    End Sub


    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            MsgBox("Fill up the First Field", vbInformation)
        ElseIf pass = False Then
            MsgBox("Password does not match!", vbInformation)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.UseSystemPasswordChar = False
            TextBox2.UseSystemPasswordChar = False
            TextBox3.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
            TextBox2.UseSystemPasswordChar = True
            TextBox3.UseSystemPasswordChar = True
        End If
    End Sub
End Class
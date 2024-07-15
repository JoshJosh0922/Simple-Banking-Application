Imports MySql.Data.MySqlClient
Public Class Form1
    Public cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim gamer As Boolean = False
    Dim gamer2 As Boolean = False
    Public data, data2 As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        signup.Show()
    End Sub

    Private Sub txt1_Enter(sender As Object, e As EventArgs) Handles txt1.Enter
        If txt1.Text = "Account Number" Then
            txt1.Text = ""
        End If
    End Sub

    Private Sub txt1_Leave(sender As Object, e As EventArgs) Handles txt1.Leave
        If txt1.Text = "" Then
            txt1.Text = "Account Number"
        End If
    End Sub

    Private Sub txt2_Enter(sender As Object, e As EventArgs) Handles txt2.Enter
        If txt2.Text = "Password" Then
            txt2.Text = ""
            txt2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txt2_Leave(sender As Object, e As EventArgs) Handles txt2.Leave
        If txt2.Text = "" Then
            txt2.Text = "Password"
            txt2.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open() 
        data = "select * from user where acc_number = '" & txt1.Text & "' and password = '" & txt2.Text & "'"
        read(data)
        If gamer = False Then
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            data2 = "Select * from manager where username = '" & txt1.Text & "'and password = '" & txt2.Text & "'"
            read(data2)
            gamer2 = True
        End If

        If gamer = True Then
            If gamer2 = False Then
                MsgBox("Successfuly Log in.", vbInformation)
                Main.txt1.Text = txt1.Text
            Else
                Main.txt2.Text = txt1.Text
            End If

            Main.Show()
            Me.Dispose()
        Else
            MsgBox("Access Denied", vbCritical)
        End If
        conn.Close()
    End Sub

    Public Function read(ByVal data As String)
        cmd.CommandText = data
        cmd.Connection = conn
        dr = cmd.ExecuteReader
        While dr.Read
            gamer = True
        End While
        
        conn.Close()
        Return gamer
    End Function

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub
End Class

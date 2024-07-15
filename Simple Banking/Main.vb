Imports MySql.Data.MySqlClient
Public Class Main
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Dim gamer As Boolean = False
    Dim gamer2 As Boolean = False
    Dim gamer3 As Boolean = False
    Dim data, data2 As String
    Public max2 As String

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customer()

    End Sub

    Sub customer()
        conn.Open()
        data = "select * from user where acc_number = '" & txt1.Text & "'"
        read(data)
        If gamer = False Then
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            gamer = True
            data = "Select * from manager where username = '" & txt2.Text & "'"
            read(data)
            gamer = False
        End If

        If gamer = True Then
            useracc()
            visuser()
            'MsgBox("Mabuhay")
        Else
            'MsgBox("admin")
            visaddmin()
        End If
        conn.Close()
    End Sub

    Public Function read(ByVal data As String)
        cmd.CommandText = data
        cmd.Connection = conn
        dr = cmd.ExecuteReader
        If gamer = True Then
            While dr.Read
                gamer2 = True
                gamer = False
            End While
        Else
            While dr.Read
                gamer = True
            End While
        End If

        conn.Close()
        Return gamer
    End Function

    Sub useracc()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        data2 = "Select Name from user where acc_number = '" & txt1.Text & "'"
        result(data2)
        With dt.Rows(0)
            txt2.Text = .Item("Name")
        End With
        If gamer3 = True Then
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            conn.Open()
            data2 = "Select balance from acc_bal where acc_number = '" & txt1.Text & "'"
            result(data2)
            With dt.Rows(0)
                txt3.Text = .Item("balance")
            End With
        End If
        
        'If txt Then
        conn.Close()
    End Sub

    Public Function result(ByVal data2 As String)
        max2 = 0
        Try
            cmd = New MySqlCommand
            da = New MySqlDataAdapter

            dt = New DataTable

            With cmd
                .Connection = conn
                .CommandText = data2
                gamer3 = True
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            max2 = dt.Rows.Count
            conn.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try
        Return max2
    End Function

    Sub visaddmin()
        Label6.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label3.Visible = False
        Label1.Visible = False
        Label7.Visible = False
        'Label10.Visible = False
        txt1.Visible = False
        txt3.Visible = False

        Label11.Location = New Point(601, 155)
        Label12.Location = New Point(601, 215)
        Label13.Location = New Point(601, 268)
        Label4.Location = New Point(27, 445)
        Label10.Location = New Point(601, 315)

        txtdt.Location = New Point(31, 467)
    End Sub

    Sub visuser()
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
    End Sub


    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        dep.txt1.Text = txt2.Text
        dep.txt2.Text = txt1.Text
        dep.txtbal.Text = txt3.Text
        Me.Enabled = False
        dep.Show()
        dep.BringToFront()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        withdraw.txt1.Text = txt2.Text
        withdraw.txt2.Text = txt1.Text
        withdraw.txtbal.Text = txt3.Text
        Me.Enabled = False
        withdraw.Show()
        withdraw.BringToFront()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        pbill.no = txt1.Text
        pbill.name1 = txt2.Text
        pbill.txtbal.Text = txt3.Text
        Me.Enabled = False
        pbill.Show()
        pbill.BringToFront()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Enabled = False
        fund.name1 = txt2.Text
        fund.TextBox1.Text = txt1.Text
        fund.txtbal.Text = txt3.Text
        fund.Show()
        fund.BringToFront()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.Enabled = False
        cpin.name1 = txt1.Text
        cpin.BringToFront()
        cpin.Show()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Me.Enabled = False
        signup.BringToFront()
        signup.Show()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Enabled = False
        nadmin.BringToFront()
        nadmin.Show()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        If MsgBox("Are you sure you want to log-out?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
            Form1.Show()
        End If

        'DialogResult dr = MessageBox.Show("Are you sure you want to log out?", "Clinic System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        '   If (dr == DialogResult.Yes) Then
        '                {
        '        this.Close();
        '    }
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtdt.Text = Date.Today
        txtime.Text = TimeOfDay
    End Sub
End Class
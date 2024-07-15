<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pbill
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pbill))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.txtime = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(82, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pay Bills"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(185, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Billing Type"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Ordinary Bill", "Money Bill", "Financial Bill", "Special Bil"})
        Me.ComboBox1.Location = New System.Drawing.Point(188, 161)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(196, 26)
        Me.ComboBox1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(175, 211)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 50)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(185, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Company Name"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(188, 211)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 18)
        Me.TextBox1.TabIndex = 5
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(175, 267)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(218, 50)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(185, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Subscriber Number/Account"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.Location = New System.Drawing.Point(188, 267)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(196, 18)
        Me.TextBox2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(185, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Amount"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(175, 323)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(218, 50)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.Location = New System.Drawing.Point(188, 323)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(196, 18)
        Me.TextBox3.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(188, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Proceed"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(262, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Cancel"
        '
        'txtdate
        '
        Me.txtdate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdate.Enabled = False
        Me.txtdate.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtdate.Location = New System.Drawing.Point(561, 399)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(100, 18)
        Me.txtdate.TabIndex = 10
        '
        'txtime
        '
        Me.txtime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtime.Enabled = False
        Me.txtime.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtime.Location = New System.Drawing.Point(667, 399)
        Me.txtime.Name = "txtime"
        Me.txtime.Size = New System.Drawing.Size(100, 18)
        Me.txtime.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(558, 378)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(664, 379)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Time"
        '
        'txtbal
        '
        Me.txtbal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbal.Enabled = False
        Me.txtbal.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtbal.Location = New System.Drawing.Point(642, 340)
        Me.txtbal.Name = "txtbal"
        Me.txtbal.Size = New System.Drawing.Size(100, 18)
        Me.txtbal.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(578, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 18)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Balance:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'pbill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(783, 459)
        Me.Controls.Add(Me.txtbal)
        Me.Controls.Add(Me.txtime)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pbill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pbill"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents txtime As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtbal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Shutdown = New System.Windows.Forms.Button()
        Me.Restart = New System.Windows.Forms.Button()
        Me.ExitBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Shutdown
        '
        Me.Shutdown.Location = New System.Drawing.Point(383, 181)
        Me.Shutdown.Name = "Shutdown"
        Me.Shutdown.Size = New System.Drawing.Size(125, 30)
        Me.Shutdown.TabIndex = 0
        Me.Shutdown.Text = "Shutdown Now"
        Me.Shutdown.UseVisualStyleBackColor = True
        '
        'Restart
        '
        Me.Restart.Location = New System.Drawing.Point(514, 182)
        Me.Restart.Name = "Restart"
        Me.Restart.Size = New System.Drawing.Size(126, 30)
        Me.Restart.TabIndex = 1
        Me.Restart.Text = "Restart Now"
        Me.Restart.UseVisualStyleBackColor = True
        '
        'ExitBTN
        '
        Me.ExitBTN.BackColor = System.Drawing.SystemColors.Menu
        Me.ExitBTN.Location = New System.Drawing.Point(646, 181)
        Me.ExitBTN.Name = "ExitBTN"
        Me.ExitBTN.Size = New System.Drawing.Size(90, 30)
        Me.ExitBTN.TabIndex = 3
        Me.ExitBTN.Text = "Exit"
        Me.ExitBTN.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Timer "
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(12, 189)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 22)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "00/00/0000 00:00:00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 34)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(121, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 30)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(233, 114)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 30)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(480, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Target "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Second"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(11, 71)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 16
        Me.TextBox3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Minute"
        '
        'Timer3
        '
        Me.Timer3.Interval = 60000
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(351, 114)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 30)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Cancel Target"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"pilih", "Shutdown 1 minute", "Shutdown 5 minute", "Shutdown 10 minute", "Shutdown 30 minute", "Shutdown 60 minute", "Shutdown 90 minute", "Shutdown 120 minute"})
        Me.ComboBox1.Location = New System.Drawing.Point(483, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(253, 24)
        Me.ComboBox1.TabIndex = 23
        Me.ComboBox1.Text = "Pilih"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(230, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Tidak ada Target"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(230, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Target"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(483, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 17)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Atau"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Pilih", "Shutdown", "Restart"})
        Me.ComboBox2.Location = New System.Drawing.Point(483, 83)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 28
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(610, 83)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(70, 22)
        Me.TextBox4.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(686, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Minute"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(748, 224)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitBTN)
        Me.Controls.Add(Me.Restart)
        Me.Controls.Add(Me.Shutdown)
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Shutdown Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Shutdown As Button
    Friend WithEvents Restart As Button
    Friend WithEvents ExitBTN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
End Class

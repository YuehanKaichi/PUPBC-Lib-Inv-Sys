﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.logPanel = New System.Windows.Forms.Panel()
        Me.extbtn = New System.Windows.Forms.Button()
        Me.rmBox = New System.Windows.Forms.CheckBox()
        Me.btnRound = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pwText = New PUPBC_Lib_Inv_Sys.Round_Text_Box()
        Me.unText = New PUPBC_Lib_Inv_Sys.Round_Text_Box()
        Me.logPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logPanel
        '
        Me.logPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.logPanel.Controls.Add(Me.extbtn)
        Me.logPanel.Controls.Add(Me.rmBox)
        Me.logPanel.Controls.Add(Me.btnRound)
        Me.logPanel.Controls.Add(Me.Label3)
        Me.logPanel.Controls.Add(Me.Label2)
        Me.logPanel.Controls.Add(Me.pwText)
        Me.logPanel.Controls.Add(Me.unText)
        Me.logPanel.Controls.Add(Me.Label1)
        Me.logPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.logPanel.Location = New System.Drawing.Point(490, 0)
        Me.logPanel.Name = "logPanel"
        Me.logPanel.Size = New System.Drawing.Size(359, 491)
        Me.logPanel.TabIndex = 0
        '
        'extbtn
        '
        Me.extbtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.extbtn.Location = New System.Drawing.Point(69, 359)
        Me.extbtn.Name = "extbtn"
        Me.extbtn.Size = New System.Drawing.Size(209, 28)
        Me.extbtn.TabIndex = 5
        Me.extbtn.Text = "Exit"
        Me.extbtn.UseVisualStyleBackColor = True
        '
        'rmBox
        '
        Me.rmBox.AutoSize = True
        Me.rmBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.rmBox.ForeColor = System.Drawing.Color.White
        Me.rmBox.Location = New System.Drawing.Point(69, 302)
        Me.rmBox.Name = "rmBox"
        Me.rmBox.Size = New System.Drawing.Size(118, 20)
        Me.rmBox.TabIndex = 3
        Me.rmBox.Text = "Remember me"
        Me.rmBox.UseVisualStyleBackColor = True
        '
        'btnRound
        '
        Me.btnRound.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.btnRound.ForeColor = System.Drawing.Color.Black
        Me.btnRound.Location = New System.Drawing.Point(69, 322)
        Me.btnRound.Name = "btnRound"
        Me.btnRound.Size = New System.Drawing.Size(209, 26)
        Me.btnRound.TabIndex = 4
        Me.btnRound.Text = "Login"
        Me.btnRound.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(66, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(66, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(491, 491)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pwText
        '
        Me.pwText.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.pwText.Location = New System.Drawing.Point(69, 273)
        Me.pwText.Name = "pwText"
        Me.pwText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwText.Size = New System.Drawing.Size(209, 23)
        Me.pwText.TabIndex = 2
        '
        'unText
        '
        Me.unText.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.unText.Location = New System.Drawing.Point(69, 192)
        Me.unText.Name = "unText"
        Me.unText.Size = New System.Drawing.Size(209, 23)
        Me.unText.TabIndex = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.logPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.logPanel.ResumeLayout(False)
        Me.logPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents logPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents unText As Round_Text_Box
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pwText As Round_Text_Box
    Friend WithEvents btnRound As Button
    Friend WithEvents rmBox As CheckBox
    Friend WithEvents extbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

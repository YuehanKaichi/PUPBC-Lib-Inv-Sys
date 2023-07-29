<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class borrowButtonFunc
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.sID = New System.Windows.Forms.TextBox()
        Me.sName = New System.Windows.Forms.TextBox()
        Me.cnYeartxt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(23, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(26, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course and Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(26, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Button1.Location = New System.Drawing.Point(170, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Button2.Location = New System.Drawing.Point(27, 210)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'sID
        '
        Me.sID.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.sID.Location = New System.Drawing.Point(54, 88)
        Me.sID.Name = "sID"
        Me.sID.Size = New System.Drawing.Size(176, 23)
        Me.sID.TabIndex = 1
        '
        'sName
        '
        Me.sName.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.sName.Location = New System.Drawing.Point(54, 133)
        Me.sName.Name = "sName"
        Me.sName.Size = New System.Drawing.Size(176, 23)
        Me.sName.TabIndex = 2
        '
        'cnYeartxt
        '
        Me.cnYeartxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.cnYeartxt.Location = New System.Drawing.Point(54, 178)
        Me.cnYeartxt.Name = "cnYeartxt"
        Me.cnYeartxt.Size = New System.Drawing.Size(176, 23)
        Me.cnYeartxt.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 59)
        Me.Panel1.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(255, 59)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Borrow Book"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'borrowButtonFunc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cnYeartxt)
        Me.Controls.Add(Me.sName)
        Me.Controls.Add(Me.sID)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "borrowButtonFunc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automated Library Inventory System - Borrow Book"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents sID As TextBox
    Friend WithEvents sName As TextBox
    Friend WithEvents cnYeartxt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
End Class

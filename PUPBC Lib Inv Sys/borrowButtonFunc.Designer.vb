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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.sID = New System.Windows.Forms.TextBox()
        Me.sName = New System.Windows.Forms.TextBox()
        Me.cnYeartxt = New System.Windows.Forms.TextBox()
        Me.bID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course and Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Book ID"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(198, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(55, 260)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'sID
        '
        Me.sID.Location = New System.Drawing.Point(133, 75)
        Me.sID.Name = "sID"
        Me.sID.Size = New System.Drawing.Size(176, 20)
        Me.sID.TabIndex = 10
        '
        'sName
        '
        Me.sName.Location = New System.Drawing.Point(133, 109)
        Me.sName.Name = "sName"
        Me.sName.Size = New System.Drawing.Size(176, 20)
        Me.sName.TabIndex = 11
        '
        'cnYeartxt
        '
        Me.cnYeartxt.Location = New System.Drawing.Point(133, 144)
        Me.cnYeartxt.Name = "cnYeartxt"
        Me.cnYeartxt.Size = New System.Drawing.Size(176, 20)
        Me.cnYeartxt.TabIndex = 12
        '
        'bID
        '
        Me.bID.Location = New System.Drawing.Point(133, 178)
        Me.bID.Name = "bID"
        Me.bID.Size = New System.Drawing.Size(176, 20)
        Me.bID.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(321, 59)
        Me.Panel1.TabIndex = 14
        '
        'borrowButtonFunc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 299)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bID)
        Me.Controls.Add(Me.cnYeartxt)
        Me.Controls.Add(Me.sName)
        Me.Controls.Add(Me.sID)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "borrowButtonFunc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "borrowButtonFunc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents sID As TextBox
    Friend WithEvents sName As TextBox
    Friend WithEvents cnYeartxt As TextBox
    Friend WithEvents bID As TextBox
    Friend WithEvents Panel1 As Panel
End Class

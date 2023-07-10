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
        Me.Round_Text_Box1 = New PUPBC_Lib_Inv_Sys.Round_Text_Box()
        Me.Round_Text_Box2 = New PUPBC_Lib_Inv_Sys.Round_Text_Box()
        Me.Round_Text_Box3 = New PUPBC_Lib_Inv_Sys.Round_Text_Box()
        Me.Round_Text_Box4 = New PUPBC_Lib_Inv_Sys.Round_Text_Box()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course and Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Book Title"
        '
        'Round_Text_Box1
        '
        Me.Round_Text_Box1.Location = New System.Drawing.Point(136, 44)
        Me.Round_Text_Box1.Name = "Round_Text_Box1"
        Me.Round_Text_Box1.Size = New System.Drawing.Size(173, 20)
        Me.Round_Text_Box1.TabIndex = 4
        '
        'Round_Text_Box2
        '
        Me.Round_Text_Box2.Location = New System.Drawing.Point(136, 78)
        Me.Round_Text_Box2.Name = "Round_Text_Box2"
        Me.Round_Text_Box2.Size = New System.Drawing.Size(173, 20)
        Me.Round_Text_Box2.TabIndex = 5
        '
        'Round_Text_Box3
        '
        Me.Round_Text_Box3.Location = New System.Drawing.Point(136, 113)
        Me.Round_Text_Box3.Name = "Round_Text_Box3"
        Me.Round_Text_Box3.Size = New System.Drawing.Size(173, 20)
        Me.Round_Text_Box3.TabIndex = 6
        '
        'Round_Text_Box4
        '
        Me.Round_Text_Box4.Location = New System.Drawing.Point(136, 147)
        Me.Round_Text_Box4.Name = "Round_Text_Box4"
        Me.Round_Text_Box4.Size = New System.Drawing.Size(173, 20)
        Me.Round_Text_Box4.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 316)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Confirm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(42, 316)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'borrowButtonFunc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 372)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Round_Text_Box4)
        Me.Controls.Add(Me.Round_Text_Box3)
        Me.Controls.Add(Me.Round_Text_Box2)
        Me.Controls.Add(Me.Round_Text_Box1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "borrowButtonFunc"
        Me.Text = "borrowButtonFunc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Round_Text_Box1 As Round_Text_Box
    Friend WithEvents Round_Text_Box2 As Round_Text_Box
    Friend WithEvents Round_Text_Box3 As Round_Text_Box
    Friend WithEvents Round_Text_Box4 As Round_Text_Box
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class

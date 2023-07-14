<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class returnButtonFunc
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
        Me.idBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.conButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'idBox
        '
        Me.idBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.idBox.Location = New System.Drawing.Point(56, 75)
        Me.idBox.Name = "idBox"
        Me.idBox.Size = New System.Drawing.Size(221, 23)
        Me.idBox.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(53, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Book ID"
        '
        'conButton
        '
        Me.conButton.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.conButton.Location = New System.Drawing.Point(202, 127)
        Me.conButton.Name = "conButton"
        Me.conButton.Size = New System.Drawing.Size(75, 23)
        Me.conButton.TabIndex = 34
        Me.conButton.Text = "Confirm"
        Me.conButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Button1.Location = New System.Drawing.Point(56, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 42)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Delete Books"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'returnButtonFunc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 203)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.idBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.conButton)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "returnButtonFunc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "returnButtonFunc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents idBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents conButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class

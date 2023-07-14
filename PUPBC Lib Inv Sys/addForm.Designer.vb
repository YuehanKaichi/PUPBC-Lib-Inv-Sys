<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addForm
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
        Me.tBox = New System.Windows.Forms.TextBox()
        Me.aBox = New System.Windows.Forms.TextBox()
        Me.qBox = New System.Windows.Forms.TextBox()
        Me.nBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dpBox = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.idBox = New System.Windows.Forms.TextBox()
        Me.mccBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Books"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tBox
        '
        Me.tBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.tBox.Location = New System.Drawing.Point(36, 120)
        Me.tBox.Name = "tBox"
        Me.tBox.Size = New System.Drawing.Size(221, 23)
        Me.tBox.TabIndex = 1
        '
        'aBox
        '
        Me.aBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.aBox.Location = New System.Drawing.Point(36, 162)
        Me.aBox.Name = "aBox"
        Me.aBox.Size = New System.Drawing.Size(221, 23)
        Me.aBox.TabIndex = 2
        '
        'qBox
        '
        Me.qBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.qBox.Location = New System.Drawing.Point(36, 247)
        Me.qBox.Name = "qBox"
        Me.qBox.Size = New System.Drawing.Size(221, 23)
        Me.qBox.TabIndex = 4
        '
        'nBox
        '
        Me.nBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.nBox.Location = New System.Drawing.Point(36, 288)
        Me.nBox.Name = "nBox"
        Me.nBox.Size = New System.Drawing.Size(221, 23)
        Me.nBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Button1.Location = New System.Drawing.Point(36, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Button2.Location = New System.Drawing.Point(182, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(33, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(33, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(33, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Date Published"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(33, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(33, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Note (Optional)"
        '
        'dpBox
        '
        Me.dpBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.dpBox.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpBox.Location = New System.Drawing.Point(36, 206)
        Me.dpBox.Name = "dpBox"
        Me.dpBox.Size = New System.Drawing.Size(221, 23)
        Me.dpBox.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(33, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Book Classification"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'idBox
        '
        Me.idBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.idBox.Location = New System.Drawing.Point(182, 76)
        Me.idBox.Name = "idBox"
        Me.idBox.Size = New System.Drawing.Size(75, 23)
        Me.idBox.TabIndex = 17
        '
        'mccBox
        '
        Me.mccBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mccBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.mccBox.FormattingEnabled = True
        Me.mccBox.Items.AddRange(New Object() {"A - General Works", "B - Religion and Philosophy", "C - Auxiliary Science to History", "D - History of the Old World", "E - U.S History", "F - History of the American", "G - Geography and Anthropology", "H - Special Sciences", "J - Political Sciences", "K - Law", "L - Education", "M - Music", "N - Fine Art", "P - Language and Literature", "Q - Math and Science", "R - Medicine", "S - Agriculture", "T - Engineering and Techonology", "U - Military Science", "V - Naval Science", "Z - Library Science"})
        Me.mccBox.Location = New System.Drawing.Point(36, 76)
        Me.mccBox.Name = "mccBox"
        Me.mccBox.Size = New System.Drawing.Size(139, 24)
        Me.mccBox.TabIndex = 18
        '
        'addForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 363)
        Me.ControlBox = False
        Me.Controls.Add(Me.mccBox)
        Me.Controls.Add(Me.idBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dpBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nBox)
        Me.Controls.Add(Me.qBox)
        Me.Controls.Add(Me.aBox)
        Me.Controls.Add(Me.tBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tBox As TextBox
    Friend WithEvents aBox As TextBox
    Friend WithEvents qBox As TextBox
    Friend WithEvents nBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dpBox As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents idBox As TextBox
    Friend WithEvents mccBox As ComboBox
End Class

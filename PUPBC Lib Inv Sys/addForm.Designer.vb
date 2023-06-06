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
        Me.mcBox = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Books"
        '
        'tBox
        '
        Me.tBox.Location = New System.Drawing.Point(36, 166)
        Me.tBox.Name = "tBox"
        Me.tBox.Size = New System.Drawing.Size(221, 20)
        Me.tBox.TabIndex = 1
        '
        'aBox
        '
        Me.aBox.Location = New System.Drawing.Point(36, 208)
        Me.aBox.Name = "aBox"
        Me.aBox.Size = New System.Drawing.Size(221, 20)
        Me.aBox.TabIndex = 2
        '
        'qBox
        '
        Me.qBox.Location = New System.Drawing.Point(36, 293)
        Me.qBox.Name = "qBox"
        Me.qBox.Size = New System.Drawing.Size(221, 20)
        Me.qBox.TabIndex = 4
        '
        'nBox
        '
        Me.nBox.Location = New System.Drawing.Point(36, 334)
        Me.nBox.Name = "nBox"
        Me.nBox.Size = New System.Drawing.Size(221, 20)
        Me.nBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Button1.Location = New System.Drawing.Point(36, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Button2.Location = New System.Drawing.Point(182, 374)
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
        Me.Label2.Location = New System.Drawing.Point(33, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(33, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(33, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Date Published"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(33, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(33, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Note (Optional)"
        '
        'dpBox
        '
        Me.dpBox.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpBox.Location = New System.Drawing.Point(36, 252)
        Me.dpBox.Name = "dpBox"
        Me.dpBox.Size = New System.Drawing.Size(221, 20)
        Me.dpBox.TabIndex = 13
        '
        'mcBox
        '
        Me.mcBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mcBox.FormattingEnabled = True
        Me.mcBox.Items.AddRange(New Object() {"", "T", "B"})
        Me.mcBox.Location = New System.Drawing.Point(36, 76)
        Me.mcBox.Name = "mcBox"
        Me.mcBox.Size = New System.Drawing.Size(221, 21)
        Me.mcBox.TabIndex = 14
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(36, 123)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(221, 21)
        Me.ComboBox2.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(33, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Main Class"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(33, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Sub Class"
        '
        'addForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 405)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.mcBox)
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
    Friend WithEvents mcBox As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class

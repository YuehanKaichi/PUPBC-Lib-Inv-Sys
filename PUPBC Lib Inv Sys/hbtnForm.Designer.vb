<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hbtnForm
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
        Me.dt1 = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.numBooks = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ccbox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dt1
        '
        Me.dt1.AllowUserToAddRows = False
        Me.dt1.AllowUserToDeleteRows = False
        Me.dt1.AllowUserToOrderColumns = True
        Me.dt1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dt1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dt1.BackgroundColor = System.Drawing.Color.White
        Me.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt1.GridColor = System.Drawing.Color.White
        Me.dt1.Location = New System.Drawing.Point(-1, 104)
        Me.dt1.Name = "dt1"
        Me.dt1.ReadOnly = True
        Me.dt1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dt1.Size = New System.Drawing.Size(907, 439)
        Me.dt1.TabIndex = 1
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.Location = New System.Drawing.Point(817, 46)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 26)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Add Book"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'numBooks
        '
        Me.numBooks.AutoSize = True
        Me.numBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numBooks.Location = New System.Drawing.Point(42, 23)
        Me.numBooks.Name = "numBooks"
        Me.numBooks.Size = New System.Drawing.Size(21, 24)
        Me.numBooks.TabIndex = 4
        Me.numBooks.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(817, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(714, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(714, 75)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(69, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Search"
        '
        'ccbox
        '
        Me.ccbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ccbox.FormattingEnabled = True
        Me.ccbox.Items.AddRange(New Object() {"All", "A - General Works", "B - Religion and Philosophy", "C - Auxiliary Science to History", "D - History of the Old World", "E - U.S History", "F - History of the American", "G - Geography and Anthropology", "H - Special Sciences", "J - Political Sciences", "K - Law", "L - Education", "M - Music", "N - Fine Art", "P - Language and Literature", "Q - Math and Science", "R - Medicine", "S - Agriculture", "T - Engineering and Techonology", "U - Military Science", "V - Naval Science", "Z - Library Science"})
        Me.ccbox.Location = New System.Drawing.Point(69, 78)
        Me.ccbox.Name = "ccbox"
        Me.ccbox.Size = New System.Drawing.Size(207, 21)
        Me.ccbox.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Class"
        '
        'hbtnForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 544)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ccbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.numBooks)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.dt1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "hbtnForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "hbtnForm"
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dt1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents numBooks As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ccbox As ComboBox
    Friend WithEvents Label2 As Label
End Class

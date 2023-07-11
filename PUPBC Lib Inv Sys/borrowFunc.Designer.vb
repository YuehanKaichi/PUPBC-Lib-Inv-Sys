<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Borrow
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
        Me.dt1 = New System.Windows.Forms.DataGridView()
        Me.borBut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.returnBut = New System.Windows.Forms.Button()
        Me.statusBox = New System.Windows.Forms.ComboBox()
        Me.refreshButton = New System.Windows.Forms.Button()
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
        Me.dt1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dt1.Enabled = False
        Me.dt1.GridColor = System.Drawing.Color.White
        Me.dt1.Location = New System.Drawing.Point(0, 105)
        Me.dt1.Name = "dt1"
        Me.dt1.ReadOnly = True
        Me.dt1.Size = New System.Drawing.Size(904, 439)
        Me.dt1.TabIndex = 0
        '
        'borBut
        '
        Me.borBut.Location = New System.Drawing.Point(817, 39)
        Me.borBut.Name = "borBut"
        Me.borBut.Size = New System.Drawing.Size(75, 23)
        Me.borBut.TabIndex = 1
        Me.borBut.Text = "Borrow"
        Me.borBut.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(82, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(210, 20)
        Me.TextBox1.TabIndex = 3
        '
        'returnBut
        '
        Me.returnBut.Location = New System.Drawing.Point(736, 72)
        Me.returnBut.Name = "returnBut"
        Me.returnBut.Size = New System.Drawing.Size(75, 23)
        Me.returnBut.TabIndex = 4
        Me.returnBut.Text = "Return"
        Me.returnBut.UseVisualStyleBackColor = True
        '
        'statusBox
        '
        Me.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statusBox.FormattingEnabled = True
        Me.statusBox.Items.AddRange(New Object() {"Before due", "Past due", "All"})
        Me.statusBox.Location = New System.Drawing.Point(106, 74)
        Me.statusBox.Name = "statusBox"
        Me.statusBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.statusBox.Size = New System.Drawing.Size(100, 21)
        Me.statusBox.TabIndex = 5
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(817, 72)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(75, 23)
        Me.refreshButton.TabIndex = 6
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'Borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 544)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.statusBox)
        Me.Controls.Add(Me.returnBut)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.borBut)
        Me.Controls.Add(Me.dt1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Borrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.dt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dt1 As DataGridView
    Friend WithEvents borBut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents returnBut As Button
    Friend WithEvents statusBox As ComboBox
    Friend WithEvents refreshButton As Button
End Class

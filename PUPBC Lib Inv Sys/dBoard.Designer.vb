<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dBoard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.home = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.hpanel = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bAuthor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bPub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bQuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.hpanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.home)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 589)
        Me.Panel1.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.Location = New System.Drawing.Point(4, 66)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(54, 48)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Home"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.Location = New System.Drawing.Point(4, 120)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(54, 48)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Home"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Location = New System.Drawing.Point(4, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 48)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Home"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Location = New System.Drawing.Point(4, 499)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 48)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.home.FlatAppearance.BorderSize = 0
        Me.home.Location = New System.Drawing.Point(4, 12)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(54, 48)
        Me.home.TabIndex = 1
        Me.home.Text = "Home"
        Me.home.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(902, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 38)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Logout"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'hpanel
        '
        Me.hpanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.hpanel.Controls.Add(Me.Button7)
        Me.hpanel.Controls.Add(Me.DataGridView1)
        Me.hpanel.Controls.Add(Me.Button6)
        Me.hpanel.Location = New System.Drawing.Point(153, 98)
        Me.hpanel.Name = "hpanel"
        Me.hpanel.Size = New System.Drawing.Size(921, 491)
        Me.hpanel.TabIndex = 6
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightGreen
        Me.Button6.Location = New System.Drawing.Point(838, 14)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 34)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Add Book"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bName, Me.bAuthor, Me.bPub, Me.bQuan, Me.bNote})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(915, 411)
        Me.DataGridView1.TabIndex = 0
        '
        'bName
        '
        Me.bName.HeaderText = "Book Title"
        Me.bName.Name = "bName"
        Me.bName.ReadOnly = True
        '
        'bAuthor
        '
        Me.bAuthor.HeaderText = "Author"
        Me.bAuthor.Name = "bAuthor"
        Me.bAuthor.ReadOnly = True
        '
        'bPub
        '
        Me.bPub.HeaderText = "Published Date"
        Me.bPub.Name = "bPub"
        Me.bPub.ReadOnly = True
        '
        'bQuan
        '
        Me.bQuan.HeaderText = "Quantity"
        Me.bQuan.Name = "bQuan"
        Me.bQuan.ReadOnly = True
        '
        'bNote
        '
        Me.bNote.HeaderText = "Note"
        Me.bNote.Name = "bNote"
        Me.bNote.ReadOnly = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(723, 20)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'dBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 589)
        Me.Controls.Add(Me.hpanel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dBoard"
        Me.Panel1.ResumeLayout(False)
        Me.hpanel.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents home As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents hpanel As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bName As DataGridViewTextBoxColumn
    Friend WithEvents bAuthor As DataGridViewTextBoxColumn
    Friend WithEvents bPub As DataGridViewTextBoxColumn
    Friend WithEvents bQuan As DataGridViewTextBoxColumn
    Friend WithEvents bNote As DataGridViewTextBoxColumn
End Class

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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bb = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.imageBox = New PUPBC_Lib_Inv_Sys.roundPictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ab = New System.Windows.Forms.Button()
        Me.hbtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1073, 41)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(168, 41)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 100)
        Me.Panel6.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(370, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Library Inventory System"
        '
        'Button4
        '
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(43, 498)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 38)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Logout"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.bb)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.imageBox)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ab)
        Me.Panel2.Controls.Add(Me.hbtn)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(165, 548)
        Me.Panel2.TabIndex = 7
        '
        'bb
        '
        Me.bb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bb.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.bb.Location = New System.Drawing.Point(0, 233)
        Me.bb.Name = "bb"
        Me.bb.Size = New System.Drawing.Size(165, 38)
        Me.bb.TabIndex = 13
        Me.bb.Text = "Borrow"
        Me.bb.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(3, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imageBox
        '
        Me.imageBox.Image = CType(resources.GetObject("imageBox.Image"), System.Drawing.Image)
        Me.imageBox.Location = New System.Drawing.Point(19, 20)
        Me.imageBox.Name = "imageBox"
        Me.imageBox.Size = New System.Drawing.Size(125, 114)
        Me.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageBox.TabIndex = 11
        Me.imageBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(3, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ab
        '
        Me.ab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ab.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.ab.Location = New System.Drawing.Point(0, 270)
        Me.ab.Name = "ab"
        Me.ab.Size = New System.Drawing.Size(165, 38)
        Me.ab.TabIndex = 10
        Me.ab.Text = "Profile"
        Me.ab.UseVisualStyleBackColor = True
        '
        'hbtn
        '
        Me.hbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hbtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.hbtn.Location = New System.Drawing.Point(0, 196)
        Me.hbtn.Name = "hbtn"
        Me.hbtn.Size = New System.Drawing.Size(165, 38)
        Me.hbtn.TabIndex = 9
        Me.hbtn.Text = "Home"
        Me.hbtn.UseVisualStyleBackColor = True
        '
        'dBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1073, 589)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "dBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dBoard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents hbtn As Button
    Friend WithEvents ab As Button
    Friend WithEvents imageBox As roundPictureBox
    Friend WithEvents bb As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class

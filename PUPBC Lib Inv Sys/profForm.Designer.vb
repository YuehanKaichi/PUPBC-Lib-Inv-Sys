<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(profForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fnameBox = New System.Windows.Forms.TextBox()
        Me.usnBox = New System.Windows.Forms.TextBox()
        Me.emailBox = New System.Windows.Forms.TextBox()
        Me.edtbtn = New System.Windows.Forms.Button()
        Me.cpwbtn = New System.Windows.Forms.Button()
        Me.imageBox = New PUPBC_Lib_Inv_Sys.roundPictureBox()
        Me.mnamebox = New System.Windows.Forms.TextBox()
        Me.lnamebox = New System.Windows.Forms.TextBox()
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Profile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(102, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(102, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(535, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Username"
        '
        'fnameBox
        '
        Me.fnameBox.Enabled = False
        Me.fnameBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.fnameBox.Location = New System.Drawing.Point(105, 291)
        Me.fnameBox.Name = "fnameBox"
        Me.fnameBox.Size = New System.Drawing.Size(122, 23)
        Me.fnameBox.TabIndex = 5
        '
        'usnBox
        '
        Me.usnBox.Enabled = False
        Me.usnBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.usnBox.Location = New System.Drawing.Point(538, 291)
        Me.usnBox.Name = "usnBox"
        Me.usnBox.Size = New System.Drawing.Size(257, 23)
        Me.usnBox.TabIndex = 6
        '
        'emailBox
        '
        Me.emailBox.Enabled = False
        Me.emailBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.emailBox.Location = New System.Drawing.Point(105, 362)
        Me.emailBox.Name = "emailBox"
        Me.emailBox.Size = New System.Drawing.Size(263, 23)
        Me.emailBox.TabIndex = 7
        '
        'edtbtn
        '
        Me.edtbtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.edtbtn.Location = New System.Drawing.Point(708, 481)
        Me.edtbtn.Name = "edtbtn"
        Me.edtbtn.Size = New System.Drawing.Size(87, 28)
        Me.edtbtn.TabIndex = 8
        Me.edtbtn.Text = "Edit Profile"
        Me.edtbtn.UseVisualStyleBackColor = True
        '
        'cpwbtn
        '
        Me.cpwbtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.cpwbtn.Location = New System.Drawing.Point(105, 481)
        Me.cpwbtn.Name = "cpwbtn"
        Me.cpwbtn.Size = New System.Drawing.Size(140, 28)
        Me.cpwbtn.TabIndex = 9
        Me.cpwbtn.Text = "Change Password"
        Me.cpwbtn.UseVisualStyleBackColor = True
        Me.cpwbtn.Visible = False
        '
        'imageBox
        '
        Me.imageBox.Image = CType(resources.GetObject("imageBox.Image"), System.Drawing.Image)
        Me.imageBox.Location = New System.Drawing.Point(102, 71)
        Me.imageBox.Name = "imageBox"
        Me.imageBox.Size = New System.Drawing.Size(125, 114)
        Me.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageBox.TabIndex = 0
        Me.imageBox.TabStop = False
        '
        'mnamebox
        '
        Me.mnamebox.Enabled = False
        Me.mnamebox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.mnamebox.Location = New System.Drawing.Point(233, 291)
        Me.mnamebox.Name = "mnamebox"
        Me.mnamebox.Size = New System.Drawing.Size(81, 23)
        Me.mnamebox.TabIndex = 10
        '
        'lnamebox
        '
        Me.lnamebox.Enabled = False
        Me.lnamebox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.lnamebox.Location = New System.Drawing.Point(320, 291)
        Me.lnamebox.Name = "lnamebox"
        Me.lnamebox.Size = New System.Drawing.Size(139, 23)
        Me.lnamebox.TabIndex = 11
        '
        'profForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 544)
        Me.Controls.Add(Me.lnamebox)
        Me.Controls.Add(Me.mnamebox)
        Me.Controls.Add(Me.cpwbtn)
        Me.Controls.Add(Me.edtbtn)
        Me.Controls.Add(Me.emailBox)
        Me.Controls.Add(Me.usnBox)
        Me.Controls.Add(Me.fnameBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imageBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "profForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "profForm"
        CType(Me.imageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imageBox As roundPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fnameBox As TextBox
    Friend WithEvents usnBox As TextBox
    Friend WithEvents emailBox As TextBox
    Friend WithEvents edtbtn As Button
    Friend WithEvents cpwbtn As Button
    Friend WithEvents mnamebox As TextBox
    Friend WithEvents lnamebox As TextBox
End Class

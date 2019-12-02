<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Page_1
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Wizard_Title_Text_Sub = New System.Windows.Forms.Label()
        Me.Wizard_Title_Text = New System.Windows.Forms.Label()
        Me.next_btn = New System.Windows.Forms.Button()
        Me.Cancel_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AllUsers_Rad = New System.Windows.Forms.RadioButton()
        Me.JustMe_Rad = New System.Windows.Forms.RadioButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(-1, 61)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(626, 339)
        Me.RichTextBox1.TabIndex = 23
        Me.RichTextBox1.Text = "Please select a user type. All Users will install in ""Program Files (x86)"" folder" &
    " by default."
        '
        'Wizard_Title_Text_Sub
        '
        Me.Wizard_Title_Text_Sub.AutoSize = True
        Me.Wizard_Title_Text_Sub.BackColor = System.Drawing.Color.White
        Me.Wizard_Title_Text_Sub.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard_Title_Text_Sub.Location = New System.Drawing.Point(42, 22)
        Me.Wizard_Title_Text_Sub.Name = "Wizard_Title_Text_Sub"
        Me.Wizard_Title_Text_Sub.Size = New System.Drawing.Size(124, 13)
        Me.Wizard_Title_Text_Sub.TabIndex = 20
        Me.Wizard_Title_Text_Sub.Text = "Please Select User Type"
        '
        'Wizard_Title_Text
        '
        Me.Wizard_Title_Text.AutoSize = True
        Me.Wizard_Title_Text.BackColor = System.Drawing.Color.White
        Me.Wizard_Title_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard_Title_Text.Location = New System.Drawing.Point(12, 9)
        Me.Wizard_Title_Text.Name = "Wizard_Title_Text"
        Me.Wizard_Title_Text.Size = New System.Drawing.Size(105, 13)
        Me.Wizard_Title_Text.TabIndex = 19
        Me.Wizard_Title_Text.Text = "User Type Select"
        '
        'next_btn
        '
        Me.next_btn.Location = New System.Drawing.Point(456, 406)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(75, 23)
        Me.next_btn.TabIndex = 17
        Me.next_btn.Text = "Next >"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'Cancel_btn
        '
        Me.Cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_btn.Location = New System.Drawing.Point(537, 406)
        Me.Cancel_btn.Name = "Cancel_btn"
        Me.Cancel_btn.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_btn.TabIndex = 16
        Me.Cancel_btn.Text = "Cancel"
        Me.Cancel_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 396)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "TheCrafters001"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(-40, 390)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(769, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "_________________________________________________________________________________" &
    "______________________________________________"
        '
        'AllUsers_Rad
        '
        Me.AllUsers_Rad.AutoSize = True
        Me.AllUsers_Rad.Location = New System.Drawing.Point(12, 87)
        Me.AllUsers_Rad.Name = "AllUsers_Rad"
        Me.AllUsers_Rad.Size = New System.Drawing.Size(66, 17)
        Me.AllUsers_Rad.TabIndex = 24
        Me.AllUsers_Rad.Text = "All Users"
        Me.AllUsers_Rad.UseVisualStyleBackColor = True
        '
        'JustMe_Rad
        '
        Me.JustMe_Rad.AutoSize = True
        Me.JustMe_Rad.Checked = True
        Me.JustMe_Rad.Location = New System.Drawing.Point(12, 110)
        Me.JustMe_Rad.Name = "JustMe_Rad"
        Me.JustMe_Rad.Size = New System.Drawing.Size(143, 17)
        Me.JustMe_Rad.TabIndex = 25
        Me.JustMe_Rad.TabStop = True
        Me.JustMe_Rad.Text = "Just Me (Recommended)"
        Me.JustMe_Rad.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.Setup.My.Resources.Resources.Flash_Two_Logo
        Me.PictureBox3.Location = New System.Drawing.Point(570, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(628, 55)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Page_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.JustMe_Rad)
        Me.Controls.Add(Me.AllUsers_Rad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Wizard_Title_Text_Sub)
        Me.Controls.Add(Me.Wizard_Title_Text)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.Cancel_btn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Page_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Type Select"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Wizard_Title_Text_Sub As Label
    Friend WithEvents Wizard_Title_Text As Label
    Friend WithEvents next_btn As Button
    Friend WithEvents Cancel_btn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AllUsers_Rad As RadioButton
    Friend WithEvents JustMe_Rad As RadioButton
End Class

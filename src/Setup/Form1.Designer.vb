<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Cancel_btn = New System.Windows.Forms.Button()
        Me.next_btn = New System.Windows.Forms.Button()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.Wizard_Title_Text = New System.Windows.Forms.Label()
        Me.Wizard_Title_Text_Sub = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Page_Title = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(-40, 390)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(769, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "_________________________________________________________________________________" &
    "______________________________________________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 396)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TheCrafters001"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Setup.My.Resources.Resources.Install_Side
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 402)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(227, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(400, 55)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Cancel_btn
        '
        Me.Cancel_btn.Location = New System.Drawing.Point(537, 406)
        Me.Cancel_btn.Name = "Cancel_btn"
        Me.Cancel_btn.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_btn.TabIndex = 4
        Me.Cancel_btn.Text = "Cancel"
        Me.Cancel_btn.UseVisualStyleBackColor = True
        '
        'next_btn
        '
        Me.next_btn.Location = New System.Drawing.Point(456, 406)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(75, 23)
        Me.next_btn.TabIndex = 5
        Me.next_btn.Text = "Next >"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'back_btn
        '
        Me.back_btn.Location = New System.Drawing.Point(375, 406)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(75, 23)
        Me.back_btn.TabIndex = 6
        Me.back_btn.Text = "< Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'Wizard_Title_Text
        '
        Me.Wizard_Title_Text.AutoSize = True
        Me.Wizard_Title_Text.BackColor = System.Drawing.Color.White
        Me.Wizard_Title_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard_Title_Text.Location = New System.Drawing.Point(234, 9)
        Me.Wizard_Title_Text.Name = "Wizard_Title_Text"
        Me.Wizard_Title_Text.Size = New System.Drawing.Size(92, 13)
        Me.Wizard_Title_Text.TabIndex = 7
        Me.Wizard_Title_Text.Text = "Welcome Page"
        '
        'Wizard_Title_Text_Sub
        '
        Me.Wizard_Title_Text_Sub.AutoSize = True
        Me.Wizard_Title_Text_Sub.BackColor = System.Drawing.Color.White
        Me.Wizard_Title_Text_Sub.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard_Title_Text_Sub.Location = New System.Drawing.Point(259, 22)
        Me.Wizard_Title_Text_Sub.Name = "Wizard_Title_Text_Sub"
        Me.Wizard_Title_Text_Sub.Size = New System.Drawing.Size(80, 13)
        Me.Wizard_Title_Text_Sub.TabIndex = 8
        Me.Wizard_Title_Text_Sub.Text = "Welcome Page"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Image = Global.Setup.My.Resources.Resources.Flash_Two_Logo
        Me.PictureBox3.Location = New System.Drawing.Point(570, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'Page_Title
        '
        Me.Page_Title.AutoSize = True
        Me.Page_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Page_Title.Location = New System.Drawing.Point(234, 58)
        Me.Page_Title.Name = "Page_Title"
        Me.Page_Title.Size = New System.Drawing.Size(373, 25)
        Me.Page_Title.TabIndex = 10
        Me.Page_Title.Text = "Welcome to the Flash Player 2 Setup!"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(234, 86)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(391, 314)
        Me.RichTextBox1.TabIndex = 11
        Me.RichTextBox1.Text = ""
        '
        'Form1
        '
        Me.AcceptButton = Me.next_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_btn
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Page_Title)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Wizard_Title_Text_Sub)
        Me.Controls.Add(Me.Wizard_Title_Text)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.Cancel_btn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Cancel_btn As Button
    Friend WithEvents next_btn As Button
    Friend WithEvents back_btn As Button
    Friend WithEvents Wizard_Title_Text As Label
    Friend WithEvents Wizard_Title_Text_Sub As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Page_Title As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class

Imports System
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Media_Player
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
        Me.VlcControl1 = New Vlc.DotNet.Forms.VlcControl()
        CType(Me.VlcControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VlcControl1
        '
        Me.VlcControl1.BackColor = System.Drawing.Color.Black
        Me.VlcControl1.Location = New System.Drawing.Point(273, 157)
        Me.VlcControl1.Name = "VlcControl1"
        Me.VlcControl1.Size = New System.Drawing.Size(275, 113)
        Me.VlcControl1.Spu = -1
        Me.VlcControl1.TabIndex = 0
        Me.VlcControl1.Text = "VlcControl1"
        Me.VlcControl1.VlcLibDirectory = Nothing
        Me.VlcControl1.VlcMediaplayerOptions = Nothing

        '
        'Media_Player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.VlcControl1)
        Me.Name = "Media_Player"
        Me.Text = "Media_Player"
        CType(Me.VlcControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VlcControl1 As Vlc.DotNet.Forms.VlcControl
End Class

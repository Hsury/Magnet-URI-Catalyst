<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AboutPictureBox = New System.Windows.Forms.PictureBox()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.DeveloperLabel = New System.Windows.Forms.Label()
        CType(Me.AboutPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AboutPictureBox
        '
        Me.AboutPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutPictureBox.Image = Global.Magnet_URI_Catalyst.My.Resources.Resources.About
        Me.AboutPictureBox.Location = New System.Drawing.Point(10, 5)
        Me.AboutPictureBox.Name = "AboutPictureBox"
        Me.AboutPictureBox.Size = New System.Drawing.Size(220, 44)
        Me.AboutPictureBox.TabIndex = 0
        Me.AboutPictureBox.TabStop = False
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(6, 55)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(112, 19)
        Me.VersionLabel.TabIndex = 1
        Me.VersionLabel.Text = "版本：20160622"
        '
        'DeveloperLabel
        '
        Me.DeveloperLabel.AutoSize = True
        Me.DeveloperLabel.Location = New System.Drawing.Point(123, 55)
        Me.DeveloperLabel.Name = "DeveloperLabel"
        Me.DeveloperLabel.Size = New System.Drawing.Size(112, 19)
        Me.DeveloperLabel.TabIndex = 2
        Me.DeveloperLabel.Text = "开发者：Kagamiz"
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 76)
        Me.Controls.Add(Me.DeveloperLabel)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.AboutPictureBox)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "关于"
        Me.TopMost = True
        CType(Me.AboutPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AboutPictureBox As PictureBox
    Friend WithEvents VersionLabel As Label
    Friend WithEvents DeveloperLabel As Label
End Class

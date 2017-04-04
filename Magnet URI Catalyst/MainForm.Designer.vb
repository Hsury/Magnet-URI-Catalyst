<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.MainMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ApplicationName1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicationName2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.About = New System.Windows.Forms.ToolStripMenuItem()
        Me.Quit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmptyMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpacityController1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpacityController2 = New System.Windows.Forms.Timer(Me.components)
        Me.RollingController1 = New System.Windows.Forms.Timer(Me.components)
        Me.RollingController2 = New System.Windows.Forms.Timer(Me.components)
        Me.RollingPictureBox = New System.Windows.Forms.PictureBox()
        Me.MainMenu.SuspendLayout()
        CType(Me.RollingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OutputTextBox
        '
        Me.OutputTextBox.ContextMenuStrip = Me.MainMenu
        Me.OutputTextBox.Location = New System.Drawing.Point(0, 0)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.Size = New System.Drawing.Size(470, 25)
        Me.OutputTextBox.TabIndex = 0
        Me.OutputTextBox.Text = "magnet:?xt=urn:btih:"
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationName1, Me.ApplicationName2, Me.MenuSeparator, Me.ViewHistory, Me.About, Me.Quit})
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.ShowImageMargin = False
        Me.MainMenu.Size = New System.Drawing.Size(171, 120)
        '
        'ApplicationName1
        '
        Me.ApplicationName1.Enabled = False
        Me.ApplicationName1.Name = "ApplicationName1"
        Me.ApplicationName1.Size = New System.Drawing.Size(170, 22)
        Me.ApplicationName1.Text = "磁力链接催化剂"
        '
        'ApplicationName2
        '
        Me.ApplicationName2.Enabled = False
        Me.ApplicationName2.Name = "ApplicationName2"
        Me.ApplicationName2.Size = New System.Drawing.Size(170, 22)
        Me.ApplicationName2.Text = "Magnet URI Catalyst"
        '
        'MenuSeparator
        '
        Me.MenuSeparator.Name = "MenuSeparator"
        Me.MenuSeparator.Size = New System.Drawing.Size(167, 6)
        '
        'ViewHistory
        '
        Me.ViewHistory.Name = "ViewHistory"
        Me.ViewHistory.Size = New System.Drawing.Size(170, 22)
        Me.ViewHistory.Text = "查看历史反应"
        '
        'About
        '
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(170, 22)
        Me.About.Text = "关于"
        '
        'Quit
        '
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(170, 22)
        Me.Quit.Text = "退出"
        '
        'EmptyMenu
        '
        Me.EmptyMenu.Name = "EmptyMenu"
        Me.EmptyMenu.Size = New System.Drawing.Size(61, 4)
        '
        'OpacityController1
        '
        Me.OpacityController1.Interval = 1
        '
        'OpacityController2
        '
        Me.OpacityController2.Interval = 1
        '
        'RollingController1
        '
        Me.RollingController1.Interval = 1
        '
        'RollingController2
        '
        Me.RollingController2.Interval = 1
        '
        'RollingPictureBox
        '
        Me.RollingPictureBox.Location = New System.Drawing.Point(-100, 25)
        Me.RollingPictureBox.Name = "RollingPictureBox"
        Me.RollingPictureBox.Size = New System.Drawing.Size(100, 2)
        Me.RollingPictureBox.TabIndex = 2
        Me.RollingPictureBox.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(470, 25)
        Me.Controls.Add(Me.RollingPictureBox)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Magnet URI Catalyst"
        Me.TopMost = True
        Me.MainMenu.ResumeLayout(False)
        CType(Me.RollingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents EmptyMenu As ContextMenuStrip
    Friend WithEvents MainMenu As ContextMenuStrip
    Friend WithEvents OpacityController1 As Timer
    Friend WithEvents OpacityController2 As Timer
    Friend WithEvents RollingController1 As Timer
    Friend WithEvents RollingController2 As Timer
    Friend WithEvents RollingPictureBox As PictureBox
    Friend WithEvents ApplicationName1 As ToolStripMenuItem
    Friend WithEvents ApplicationName2 As ToolStripMenuItem
    Friend WithEvents MenuSeparator As ToolStripSeparator
    Friend WithEvents ViewHistory As ToolStripMenuItem
    Friend WithEvents About As ToolStripMenuItem
    Friend WithEvents Quit As ToolStripMenuItem
End Class

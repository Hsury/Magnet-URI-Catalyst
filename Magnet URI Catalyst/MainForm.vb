Public Class MainForm
    Dim Content As String
    Dim isSHA1 As Boolean
    Dim Switch1 As Boolean
    Dim Switch2 As Boolean
    Dim x1 As Integer
    Dim y1 As Integer
    Dim x2 As Integer
    Dim y2 As Integer

    Public Declare Auto Function RegisterHotKey Lib "user32.dll" Alias "RegisterHotKey" (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Boolean
    Public Declare Auto Function UnRegisterHotKey Lib "user32.dll" Alias "UnregisterHotKey" (ByVal hwnd As IntPtr, ByVal id As Integer) As Boolean

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = 786 Then
            UnRegisterHotKey(Handle, 0)
            SendKeys.Send("^c")
            RegisterHotKey(Handle, 0, 2, Keys.C)
            Me.Activate()
            OutputTextBox.SelectionLength = 0
            OpacityController2.Enabled = False
            OpacityController1.Enabled = True
            RollingController2.Enabled = False
            RollingPictureBox.Left = -100
            RollingPictureBox.Image = My.Resources.Blue
            RollingController1.Enabled = True
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub Analyse()
        isSHA1 = True
        If Clipboard.ContainsText(TextDataFormat.Text) = True Then
            Content = Clipboard.GetText(TextDataFormat.Text)
            If Len(Content) = 40 Then
                For i = 1 To Len(Content)
                    Select Case Asc(UCase(Mid(Content, i, 1)))
                        Case 48 To 57
                        Case 65 To 70
                        Case Else
                            isSHA1 = False
                    End Select
                Next i
            Else
                isSHA1 = False
            End If
        Else
            isSHA1 = False
        End If
        If isSHA1 = True Then
            OutputTextBox.Text = "magnet:?xt=urn:btih:" & Content
            Clipboard.SetText(OutputTextBox.Text, TextDataFormat.Text)
            IO.File.AppendAllText("MagnetURIHistory.txt", Format(Now, "yyyy年M月d日 HH:mm:ss ") & OutputTextBox.Text & vbCrLf)
            RollingPictureBox.Image = My.Resources.Green
        Else
            RollingPictureBox.Image = My.Resources.Red
        End If
        RollingController2.Enabled = True
    End Sub

    Private Sub MainForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        AboutForm.Close()
        My.Settings.LocationX = Me.Left
        My.Settings.LocationY = Me.Top
        UnRegisterHotKey(Handle, 0)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RegisterHotKey(Handle, 0, 2, Keys.C)
        Me.Height = 25
        If My.Settings.LocationX <> -1 Or My.Settings.LocationY <> -1 Then
            Me.Left = My.Settings.LocationX
            Me.Top = My.Settings.LocationY
        Else
            Me.Left = My.Computer.Screen.Bounds.Width - 525
            Me.Top = My.Computer.Screen.Bounds.Height - 125
        End If
        Switch1 = True
        Switch2 = False
        OpacityController1.Enabled = True
    End Sub

    Private Sub OutputTextBox_MouseClick(sender As Object, e As MouseEventArgs) Handles OutputTextBox.MouseClick
        OutputTextBox.SelectAll()
        If OutputTextBox.Text <> "magnet:?xt=urn:btih:" Then Clipboard.SetText(OutputTextBox.Text, TextDataFormat.Text)
    End Sub

    Private Sub OutputTextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles OutputTextBox.MouseDown
        OpacityController2.Enabled = False
        OpacityController1.Enabled = True
        If e.Button = MouseButtons.Right Then
            x1 = e.X
            y1 = e.Y
        End If
    End Sub

    Private Sub OutputTextBox_MouseEnter(sender As Object, e As EventArgs) Handles OutputTextBox.MouseEnter
        OpacityController2.Enabled = False
        OpacityController1.Enabled = True
    End Sub

    Private Sub OutputTextBox_MouseLeave(sender As Object, e As EventArgs) Handles OutputTextBox.MouseLeave
        OpacityController1.Enabled = False
        OpacityController2.Enabled = True
    End Sub

    Private Sub OutputTextBox_MouseMove(sender As Object, e As MouseEventArgs) Handles OutputTextBox.MouseMove
        OpacityController2.Enabled = False
        OpacityController1.Enabled = True
        If e.Button = MouseButtons.Right Then
            x2 = e.X
            y2 = e.Y
            Me.Left = Me.Left + (x2 - x1)
            Me.Top = Me.Top + (y2 - y1)
            OutputTextBox.ContextMenuStrip = EmptyMenu
        End If
    End Sub

    Private Sub OutputTextBox_MouseUp(sender As Object, e As MouseEventArgs) Handles OutputTextBox.MouseUp
        OpacityController2.Enabled = False
        OpacityController1.Enabled = True
        OutputTextBox.ContextMenuStrip = MainMenu
    End Sub

    Private Sub OpacityController1_Tick(sender As Object, e As EventArgs) Handles OpacityController1.Tick
        If (Switch1 = True And Me.Opacity < 0.3) Or (Switch1 = False And Me.Opacity < 0.8) Then
            Me.Opacity = Me.Opacity + 0.05
        Else
            OpacityController1.Enabled = False
            Switch1 = False
        End If
    End Sub

    Private Sub OpacityController2_Tick(sender As Object, e As EventArgs) Handles OpacityController2.Tick
        If (Switch2 = False And Me.Opacity > 0.3) Or (Switch2 = True And Me.Opacity > 0.05) Then
            Me.Opacity = Me.Opacity - 0.05
        Else
            OpacityController2.Enabled = False
            OutputTextBox.SelectionLength = 0
            If Switch2 = True Then Me.Close()
        End If
    End Sub

    Private Sub RollingController1_Tick(sender As Object, e As EventArgs) Handles RollingController1.Tick
        If RollingPictureBox.Left < 500 Then
            If Me.Height < 27 Then Me.Height = Me.Height + 1
            RollingPictureBox.Left = RollingPictureBox.Left + 10
        Else
            RollingController1.Enabled = False
            Analyse()
        End If
    End Sub

    Private Sub RollingController2_Tick(sender As Object, e As EventArgs) Handles RollingController2.Tick
        If Me.Height > 25 Then
            If RollingPictureBox.Left < -80 Then Me.Height = Me.Height - 1
            RollingPictureBox.Left = RollingPictureBox.Left - 10
        Else
            RollingController2.Enabled = False
            OpacityController1.Enabled = False
            OpacityController2.Enabled = True
        End If
    End Sub

    Private Sub ViewHistory_Click(sender As Object, e As EventArgs) Handles ViewHistory.Click
        Shell("notepad.exe MagnetURIHistory.txt", vbNormalFocus)
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        AboutForm.Show()
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Switch2 = True
        OpacityController1.Enabled = False
        OpacityController2.Enabled = True
    End Sub

End Class

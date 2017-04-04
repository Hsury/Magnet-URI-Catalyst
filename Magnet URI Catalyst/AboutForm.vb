Public Class AboutForm
    Private Sub AboutPictureBox_Click(sender As Object, e As EventArgs) Handles AboutPictureBox.Click
        Shell("explorer.exe http://www.kagamiz.com/magnet-uri-catalyst/", vbNormalFocus)
    End Sub
End Class
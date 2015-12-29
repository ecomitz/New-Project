Public Class Form1
    Private Sub StartGameButton_Click(sender As Object, e As EventArgs) Handles StartGameButton.Click
        Story.Show()
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.punch, AudioPlayMode.Background)
    End Sub
End Class

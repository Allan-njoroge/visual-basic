Public Class Main
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAbout.Click

    End Sub

    ' Add Movies Button
    Private Sub btnAddMovies_Click(sender As Object, e As EventArgs) Handles btnAddMovies.Click
        Me.Hide()
        AddMovie.Show()
    End Sub

    ' View Movies Button
    Private Sub btnViewMovies_Click(sender As Object, e As EventArgs) Handles btnViewMovies.Click
        Me.Hide()
        ViewMovies.Show()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Me.Hide()
        Settings.Show()
    End Sub
End Class
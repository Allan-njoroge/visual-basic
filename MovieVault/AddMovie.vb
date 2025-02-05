Public Class AddMovie
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strTxtTitle As String
        Dim strTxtGenre As String
        Dim StrReleaseYear As String

        strTxtTitle = txtTitle.Text
        strTxtGenre = txtGenre.Text
        StrReleaseYear = txtReleaseYear.Text

        MessageBox.Show(strTxtTitle & " has been added successfully")

        txtTitle.Text = ""
        txtGenre.Text = ""
        txtReleaseYear.Text = ""

    End Sub
End Class
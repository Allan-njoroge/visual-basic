Public Class Settings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDark.Click
        DarkForm(Main, Me, AddMovie, ViewMovies, Form1, About)

        DarkLabel(Form1.txtCatchPhrase)
        DarkLabel(AddMovie.lblPageTitle, AddMovie.lblTitle, AddMovie.lblGenre, AddMovie.lblReleaseYear)
        DarkLabel(ViewMovies.Label1, ViewMovies.Label2, ViewMovies.Label3, ViewMovies.Label4, ViewMovies.Label5, ViewMovies.Label6, ViewMovies.Label7, ViewMovies.Label8, ViewMovies.Label9, ViewMovies.Label10, ViewMovies.Label11, ViewMovies.Label12, ViewMovies.Label13)
        DarkLabel(About.Label2, About.Label3, About.Label4)
        DarkLabel(lblChangeTheme)

        DarkButton(btnBack, Form1.btnGetStarted, AddMovie.btnBack, AddMovie.Button1, Main.btnBack, Main.btnAbout, Main.btnAddMovies, Main.btnViewMovies, Main.btnSettings, ViewMovies.btnBack, About.btnBack, btnDark, btnLight)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLight.Click
        LightForm(Me, Main, AddMovie, ViewMovies, Form1, About)

        LightLabel(Form1.txtCatchPhrase)
        LightLabel(AddMovie.lblPageTitle, AddMovie.lblTitle, AddMovie.lblGenre, AddMovie.lblReleaseYear)
        LightLabel(ViewMovies.Label1, ViewMovies.Label2, ViewMovies.Label3, ViewMovies.Label4, ViewMovies.Label5, ViewMovies.Label6, ViewMovies.Label7, ViewMovies.Label8, ViewMovies.Label9, ViewMovies.Label10, ViewMovies.Label11, ViewMovies.Label12, ViewMovies.Label13)
        LightLabel(About.Label2, About.Label3, About.Label4)
        LightLabel(lblChangeTheme)

        LightButton(btnBack, Form1.btnGetStarted, AddMovie.btnBack, AddMovie.Button1, Main.btnBack, Main.btnAbout, Main.btnAddMovies, Main.btnViewMovies, Main.btnSettings, ViewMovies.btnBack, About.btnBack, btnDark, btnLight)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Main.Show()
    End Sub


    ' ===== Theme Change Functions =====
    ' Dark theme function for form bg color
    Private Sub DarkForm(ParamArray forms() As Form)
        For Each form As Form In forms
            form.BackColor = Color.Black
        Next
    End Sub

    ' Light theme function for form bg color
    Private Sub LightForm(ParamArray forms() As Form)
        For Each form As Form In forms
            form.BackColor = Color.White
        Next
    End Sub

    ' Dark theme from labels
    Private Sub DarkLabel(ParamArray labels() As Label)
        For Each label As Label In labels
            label.ForeColor = Color.White
        Next
    End Sub

    ' Light the for labels
    Private Sub LightLabel(ParamArray labels() As Label)
        For Each label As Label In labels
            label.ForeColor = Color.Black
        Next
    End Sub

    ' Dark theme for buttons
    Private Sub DarkButton(ParamArray buttons() As Button)
        For Each button As Button In buttons
            button.BackColor = Color.Black
            button.ForeColor = Color.White
        Next
    End Sub

    ' Light theme for buttons
    Private Sub LightButton(ParamArray buttons() As Button)
        For Each button As Button In buttons
            button.BackColor = Color.White
            button.ForeColor = Color.Black
        Next
    End Sub

End Class
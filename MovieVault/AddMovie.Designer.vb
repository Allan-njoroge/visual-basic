<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMovie
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
        Panel1 = New Panel()
        btnBack = New Button()
        lblPageTitle = New Label()
        Label2 = New Label()
        txtTitle = New TextBox()
        txtGenre = New TextBox()
        txtReleaseYear = New TextBox()
        lblTitle = New Label()
        lblGenre = New Label()
        lblReleaseYear = New Label()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Blue
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(lblPageTitle)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 77)
        Panel1.TabIndex = 7
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(-9, -15)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(128, 106)
        btnBack.TabIndex = 7
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.AutoSize = True
        lblPageTitle.BackColor = Color.Transparent
        lblPageTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPageTitle.ForeColor = Color.White
        lblPageTitle.Location = New Point(281, 20)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(263, 45)
        lblPageTitle.TabIndex = 1
        lblPageTitle.Text = "Add New Movie"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(306, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(238, 25)
        Label2.TabIndex = 8
        Label2.Text = "Add the details of the movie"
        ' 
        ' txtTitle
        ' 
        txtTitle.BorderStyle = BorderStyle.FixedSingle
        txtTitle.Location = New Point(172, 170)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(513, 31)
        txtTitle.TabIndex = 9
        ' 
        ' txtGenre
        ' 
        txtGenre.BorderStyle = BorderStyle.FixedSingle
        txtGenre.Location = New Point(172, 226)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(513, 31)
        txtGenre.TabIndex = 10
        ' 
        ' txtReleaseYear
        ' 
        txtReleaseYear.BorderStyle = BorderStyle.FixedSingle
        txtReleaseYear.Location = New Point(172, 283)
        txtReleaseYear.Name = "txtReleaseYear"
        txtReleaseYear.Size = New Size(513, 31)
        txtReleaseYear.TabIndex = 11
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(95, 173)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(44, 25)
        lblTitle.TabIndex = 12
        lblTitle.Text = "Title"
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(81, 232)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(58, 25)
        lblGenre.TabIndex = 13
        lblGenre.Text = "Genre"
        ' 
        ' lblReleaseYear
        ' 
        lblReleaseYear.AutoSize = True
        lblReleaseYear.Location = New Point(32, 289)
        lblReleaseYear.Name = "lblReleaseYear"
        lblReleaseYear.Size = New Size(107, 25)
        lblReleaseYear.TabIndex = 14
        lblReleaseYear.Text = "Release Year"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Blue
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.White
        Button1.Location = New Point(172, 358)
        Button1.Name = "Button1"
        Button1.Size = New Size(513, 42)
        Button1.TabIndex = 15
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' AddMovie
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(lblReleaseYear)
        Controls.Add(lblGenre)
        Controls.Add(lblTitle)
        Controls.Add(txtReleaseYear)
        Controls.Add(txtGenre)
        Controls.Add(txtTitle)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "AddMovie"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddMovie"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtReleaseYear As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblReleaseYear As Label
    Friend WithEvents Button1 As Button
End Class

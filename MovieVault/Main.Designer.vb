<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Label1 = New Label()
        btnAddMovies = New Button()
        btnViewMovies = New Button()
        btnAbout = New Button()
        btnSettings = New Button()
        Panel1 = New Panel()
        Button5 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(305, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 45)
        Label1.TabIndex = 1
        Label1.Text = "Main Menu"
        ' 
        ' btnAddMovies
        ' 
        btnAddMovies.Location = New Point(91, 134)
        btnAddMovies.Name = "btnAddMovies"
        btnAddMovies.Size = New Size(649, 58)
        btnAddMovies.TabIndex = 2
        btnAddMovies.Text = "Add Movies"
        btnAddMovies.UseVisualStyleBackColor = True
        ' 
        ' btnViewMovies
        ' 
        btnViewMovies.Location = New Point(91, 211)
        btnViewMovies.Name = "btnViewMovies"
        btnViewMovies.Size = New Size(649, 58)
        btnViewMovies.TabIndex = 3
        btnViewMovies.Text = "View Movies"
        btnViewMovies.UseVisualStyleBackColor = True
        ' 
        ' btnAbout
        ' 
        btnAbout.Location = New Point(91, 295)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(649, 58)
        btnAbout.TabIndex = 4
        btnAbout.Text = "About"
        btnAbout.UseVisualStyleBackColor = True
        ' 
        ' btnSettings
        ' 
        btnSettings.Location = New Point(91, 369)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(649, 58)
        btnSettings.TabIndex = 5
        btnSettings.Text = "Settings"
        btnSettings.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Blue
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 77)
        Panel1.TabIndex = 6
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(-9, -15)
        Button5.Name = "Button5"
        Button5.Size = New Size(128, 106)
        Button5.TabIndex = 7
        Button5.Text = "Back"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 584)
        Controls.Add(Panel1)
        Controls.Add(btnSettings)
        Controls.Add(btnAbout)
        Controls.Add(btnViewMovies)
        Controls.Add(btnAddMovies)
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddMovies As Button
    Friend WithEvents btnViewMovies As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
End Class

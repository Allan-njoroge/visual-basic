<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
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
        Panel1.Size = New Size(975, 77)
        Panel1.TabIndex = 8
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
        lblPageTitle.Location = New Point(449, 10)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(114, 45)
        lblPageTitle.TabIndex = 1
        lblPageTitle.Text = "About"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(267, 223)
        Label1.Name = "Label1"
        Label1.Size = New Size(378, 45)
        Label1.TabIndex = 9
        Label1.Text = "Welcome to MovieVault"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(323, 336)
        Label2.Name = "Label2"
        Label2.Size = New Size(502, 25)
        Label2.TabIndex = 10
        Label2.Text = "- Add new movies with details like title, genre and release year"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(323, 373)
        Label3.Name = "Label3"
        Label3.Size = New Size(332, 25)
        Label3.TabIndex = 11
        Label3.Text = "- View, edit, or delete movies in your list."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(267, 437)
        Label4.Name = "Label4"
        Label4.Size = New Size(320, 25)
        Label4.TabIndex = 12
        Label4.Text = "Enjoy managing your movie collection!"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ActiveBorder
        Label5.Location = New Point(267, 288)
        Label5.Name = "Label5"
        Label5.Size = New Size(207, 32)
        Label5.TabIndex = 13
        Label5.Text = "What You Can Do"
        ' 
        ' About
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(975, 732)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "About"
        Text = "About"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class

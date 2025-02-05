<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Label1 = New Label()
        lblChangeTheme = New Label()
        btnDark = New Button()
        btnLight = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Blue
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(908, 77)
        Panel1.TabIndex = 9
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(381, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 45)
        Label1.TabIndex = 1
        Label1.Text = "Settings"
        ' 
        ' lblChangeTheme
        ' 
        lblChangeTheme.AutoSize = True
        lblChangeTheme.BackColor = Color.Transparent
        lblChangeTheme.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblChangeTheme.Location = New Point(24, 119)
        lblChangeTheme.Name = "lblChangeTheme"
        lblChangeTheme.Size = New Size(168, 30)
        lblChangeTheme.TabIndex = 10
        lblChangeTheme.Text = "Change Theme:"
        ' 
        ' btnDark
        ' 
        btnDark.Location = New Point(216, 109)
        btnDark.Name = "btnDark"
        btnDark.Size = New Size(121, 53)
        btnDark.TabIndex = 11
        btnDark.Text = "Dark"
        btnDark.UseVisualStyleBackColor = True
        ' 
        ' btnLight
        ' 
        btnLight.Location = New Point(352, 109)
        btnLight.Name = "btnLight"
        btnLight.Size = New Size(119, 53)
        btnLight.TabIndex = 12
        btnLight.Text = "Light"
        btnLight.UseVisualStyleBackColor = True
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        ClientSize = New Size(908, 742)
        Controls.Add(btnLight)
        Controls.Add(btnDark)
        Controls.Add(lblChangeTheme)
        Controls.Add(Panel1)
        Name = "Settings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Settingsvb"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblChangeTheme As Label
    Friend WithEvents btnDark As Button
    Friend WithEvents btnLight As Button
End Class

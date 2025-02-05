<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtCatchPhrase = New Label()
        btnGetStarted = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(263, 143)
        Label1.Name = "Label1"
        Label1.Size = New Size(382, 45)
        Label1.TabIndex = 0
        Label1.Text = "Welcome To MovieVault"
        ' 
        ' txtCatchPhrase
        ' 
        txtCatchPhrase.AutoSize = True
        txtCatchPhrase.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCatchPhrase.Location = New Point(232, 211)
        txtCatchPhrase.Name = "txtCatchPhrase"
        txtCatchPhrase.Size = New Size(436, 28)
        txtCatchPhrase.TabIndex = 1
        txtCatchPhrase.Text = "Your movies, securely stored and easily managed"
        ' 
        ' btnGetStarted
        ' 
        btnGetStarted.FlatStyle = FlatStyle.Flat
        btnGetStarted.Location = New Point(313, 282)
        btnGetStarted.Name = "btnGetStarted"
        btnGetStarted.Size = New Size(235, 53)
        btnGetStarted.TabIndex = 2
        btnGetStarted.Text = "Get Started"
        btnGetStarted.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(913, 538)
        Controls.Add(btnGetStarted)
        Controls.Add(txtCatchPhrase)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCatchPhrase As Label
    Friend WithEvents btnGetStarted As Button

End Class

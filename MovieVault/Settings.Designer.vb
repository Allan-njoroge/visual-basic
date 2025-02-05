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
        Dim ListViewItem1 As ListViewItem = New ListViewItem("")
        Dim ListViewItem2 As ListViewItem = New ListViewItem("")
        Dim ListViewItem3 As ListViewItem = New ListViewItem("")
        Dim ListViewItem4 As ListViewItem = New ListViewItem("")
        Dim ListViewItem5 As ListViewItem = New ListViewItem("")
        Dim ListViewItem6 As ListViewItem = New ListViewItem("")
        Dim ListViewItem7 As ListViewItem = New ListViewItem("")
        Panel1 = New Panel()
        Button5 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        ListView1 = New ListView()
        Title = New ColumnHeader()
        Genre = New ColumnHeader()
        ReleaseYear = New ColumnHeader()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Blue
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(908, 77)
        Panel1.TabIndex = 9
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(24, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 30)
        Label2.TabIndex = 10
        Label2.Text = "Change Theme:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(216, 109)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 53)
        Button1.TabIndex = 11
        Button1.Text = "Dark"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(352, 109)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 53)
        Button2.TabIndex = 12
        Button2.Text = "Light"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {Title, Genre, ReleaseYear})
        ListView1.Items.AddRange(New ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7})
        ListView1.Location = New Point(12, 384)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(872, 304)
        ListView1.TabIndex = 13
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        ClientSize = New Size(908, 742)
        Controls.Add(ListView1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
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
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Title As ColumnHeader
    Friend WithEvents Genre As ColumnHeader
    Friend WithEvents ReleaseYear As ColumnHeader
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btnlog = New System.Windows.Forms.Button()
        Me.Txtboxuser = New System.Windows.Forms.TextBox()
        Me.Txtboxpass = New System.Windows.Forms.TextBox()
        Me.Lblusername = New System.Windows.Forms.Label()
        Me.Lblpass = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(666, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Form2ToolStripMenuItem, Me.Form3ToolStripMenuItem})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'Form2ToolStripMenuItem
        '
        Me.Form2ToolStripMenuItem.Name = "Form2ToolStripMenuItem"
        Me.Form2ToolStripMenuItem.Size = New System.Drawing.Size(130, 26)
        Me.Form2ToolStripMenuItem.Text = "Form 2"
        '
        'Form3ToolStripMenuItem
        '
        Me.Form3ToolStripMenuItem.Name = "Form3ToolStripMenuItem"
        Me.Form3ToolStripMenuItem.Size = New System.Drawing.Size(130, 26)
        Me.Form3ToolStripMenuItem.Text = "Form 3"
        '
        'Btnlog
        '
        Me.Btnlog.Location = New System.Drawing.Point(253, 287)
        Me.Btnlog.Name = "Btnlog"
        Me.Btnlog.Size = New System.Drawing.Size(108, 68)
        Me.Btnlog.TabIndex = 3
        Me.Btnlog.Text = "Log In"
        Me.Btnlog.UseVisualStyleBackColor = True
        '
        'Txtboxuser
        '
        Me.Txtboxuser.Location = New System.Drawing.Point(218, 112)
        Me.Txtboxuser.Name = "Txtboxuser"
        Me.Txtboxuser.Size = New System.Drawing.Size(183, 22)
        Me.Txtboxuser.TabIndex = 5
        '
        'Txtboxpass
        '
        Me.Txtboxpass.Location = New System.Drawing.Point(218, 193)
        Me.Txtboxpass.Name = "Txtboxpass"
        Me.Txtboxpass.Size = New System.Drawing.Size(183, 22)
        Me.Txtboxpass.TabIndex = 6
        '
        'Lblusername
        '
        Me.Lblusername.AutoSize = True
        Me.Lblusername.Location = New System.Drawing.Point(84, 112)
        Me.Lblusername.Name = "Lblusername"
        Me.Lblusername.Size = New System.Drawing.Size(73, 17)
        Me.Lblusername.TabIndex = 7
        Me.Lblusername.Text = "Username"
        '
        'Lblpass
        '
        Me.Lblpass.AutoSize = True
        Me.Lblpass.Location = New System.Drawing.Point(84, 193)
        Me.Lblpass.Name = "Lblpass"
        Me.Lblpass.Size = New System.Drawing.Size(69, 17)
        Me.Lblpass.TabIndex = 8
        Me.Lblpass.Text = "Password"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 457)
        Me.Controls.Add(Me.Lblpass)
        Me.Controls.Add(Me.Lblusername)
        Me.Controls.Add(Me.Txtboxpass)
        Me.Controls.Add(Me.Txtboxuser)
        Me.Controls.Add(Me.Btnlog)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Form2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Form3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btnlog As Button
    Friend WithEvents Txtboxuser As TextBox
    Friend WithEvents Txtboxpass As TextBox
    Friend WithEvents Lblusername As Label
    Friend WithEvents Lblpass As Label
End Class

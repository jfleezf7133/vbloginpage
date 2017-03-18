Public Class Form1
    Dim f2 As New Form2
    Dim f3 As New Form3
    Private Sub Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form2ToolStripMenuItem.Click
        f2.MdiParent = Me
        f2.Dock = DockStyle.Fill

        f2.Show()
        f3.Hide()
    End Sub
    Private Sub Form3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form3ToolStripMenuItem.Click

        f3.mdiparent = Me
        f3.Dock = DockStyle.Fill

        f3.Show()
        f2.hide()
    End Sub

    Private Sub Btnlog_Click(sender As Object, e As EventArgs) Handles Btnlog.Click
        Dim lbluser As Char
        Dim lblpass As Integer

        lbluser = Txtboxuser.Text
        lblpass = Txtboxpass.Text
        MsgBox("Welcome")



    End Sub
End Class

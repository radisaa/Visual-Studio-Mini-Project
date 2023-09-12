Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        EtNama.Text = ""
        EtNPM.Text = ""
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Dim f2 As New Form2(Me)
        Me.Hide()
        f2.Show()
    End Sub
End Class

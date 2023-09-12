Public Class Form2


    Dim uts, uas, praktikum, nilaiakhir As Double

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        uts = CDbl(EtNilaiUTS.Text)
        uas = CDbl(EtNilaiUAS.Text)
        praktikum = CDbl(EtNilaiPraktikum.Text)
        nilaiakhir = (0.3 * uts) + (0.3 * uas) + (0.4 * praktikum)
        EtTampilNilai.Text = nilaiakhir

    End Sub
End Class
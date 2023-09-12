Public Class Form2

    Dim uts, uas, praktikum, nilaiakhir As Double
    Dim f1 As Form1

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        EtNilaiUTS.Text = "0"
        EtNilaiUAS.Text = "0"
        EtNilaiPraktikum.Text = "0"
        EtTampilNilai.Text = "0"
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
        f1.EtNama.Text = ""
        f1.EtNPM.Text = ""
        f1.Show()
    End Sub

    Public Sub New(ByVal frm1 As Form1)
        InitializeComponent()
        f1 = frm1
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        TextNama.Text = f1.EtNama.Text
        TextNPM.Text = f1.EtNPM.Text

        EtNilaiUTS.Text = "0"
        EtNilaiUAS.Text = "0"
        EtNilaiPraktikum.Text = "0"
        EtTampilNilai.Text = "0"

    End Sub

    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        uts = CDbl(EtNilaiUTS.Text)
        uas = CDbl(EtNilaiUAS.Text)
        praktikum = CDbl(EtNilaiPraktikum.Text)
        nilaiakhir = (0.3 * uts) + (0.3 * uas) + (0.4 * praktikum)
        EtTampilNilai.Text = nilaiakhir

    End Sub
End Class
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.EtTampilNilai = New System.Windows.Forms.TextBox()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.label6 = New System.Windows.Forms.Label()
        Me.EtNilaiPraktikum = New System.Windows.Forms.TextBox()
        Me.EtNilaiUAS = New System.Windows.Forms.TextBox()
        Me.EtNilaiUTS = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.TextNama = New System.Windows.Forms.Label()
        Me.TextNPM = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'EtTampilNilai
        '
        Me.EtTampilNilai.Font = New System.Drawing.Font("Montserrat", 71.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtTampilNilai.Location = New System.Drawing.Point(32, 290)
        Me.EtTampilNilai.Multiline = True
        Me.EtTampilNilai.Name = "EtTampilNilai"
        Me.EtTampilNilai.Size = New System.Drawing.Size(357, 125)
        Me.EtTampilNilai.TabIndex = 51
        Me.EtTampilNilai.Text = "0"
        Me.EtTampilNilai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnHitung
        '
        Me.BtnHitung.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnHitung.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHitung.Location = New System.Drawing.Point(32, 246)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(357, 35)
        Me.BtnHitung.TabIndex = 50
        Me.BtnHitung.Text = "Hitung Nilai Akhir"
        Me.BtnHitung.UseVisualStyleBackColor = False
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(32, 202)
        Me.label6.Name = "label6"
        Me.label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label6.Size = New System.Drawing.Size(357, 32)
        Me.label6.TabIndex = 49
        Me.label6.Text = "Rumus Nilai Akhir: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0.3*Nilai UTS)+(0.3*Nilai UAS)+(0.4*Nilai Praktikum) " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'EtNilaiPraktikum
        '
        Me.EtNilaiPraktikum.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtNilaiPraktikum.Location = New System.Drawing.Point(165, 152)
        Me.EtNilaiPraktikum.Name = "EtNilaiPraktikum"
        Me.EtNilaiPraktikum.Size = New System.Drawing.Size(100, 21)
        Me.EtNilaiPraktikum.TabIndex = 48
        Me.EtNilaiPraktikum.Text = "0"
        Me.EtNilaiPraktikum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'EtNilaiUAS
        '
        Me.EtNilaiUAS.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtNilaiUAS.Location = New System.Drawing.Point(165, 116)
        Me.EtNilaiUAS.Name = "EtNilaiUAS"
        Me.EtNilaiUAS.Size = New System.Drawing.Size(100, 21)
        Me.EtNilaiUAS.TabIndex = 47
        Me.EtNilaiUAS.Text = "0"
        Me.EtNilaiUAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'EtNilaiUTS
        '
        Me.EtNilaiUTS.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtNilaiUTS.Location = New System.Drawing.Point(165, 83)
        Me.EtNilaiUTS.Name = "EtNilaiUTS"
        Me.EtNilaiUTS.Size = New System.Drawing.Size(100, 21)
        Me.EtNilaiUTS.TabIndex = 46
        Me.EtNilaiUTS.Text = "0"
        Me.EtNilaiUTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(28, 153)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(111, 16)
        Me.label5.TabIndex = 43
        Me.label5.Text = "Nilai Praktikum"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(29, 120)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(70, 16)
        Me.label4.TabIndex = 42
        Me.label4.Text = "Nilai UAS"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(29, 87)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(68, 16)
        Me.label3.TabIndex = 41
        Me.label3.Text = "Nilai UTS"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(29, 49)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 16)
        Me.label2.TabIndex = 40
        Me.label2.Text = "NPM"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(29, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 16)
        Me.label1.TabIndex = 39
        Me.label1.Text = "Nama"
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnBack.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBack.Location = New System.Drawing.Point(32, 433)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(80, 36)
        Me.BtnBack.TabIndex = 52
        Me.BtnBack.Text = "BACK"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.BtnReset.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnReset.Location = New System.Drawing.Point(301, 433)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(87, 36)
        Me.BtnReset.TabIndex = 53
        Me.BtnReset.Text = "RESET"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'TextNama
        '
        Me.TextNama.AutoSize = True
        Me.TextNama.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNama.Location = New System.Drawing.Point(165, 16)
        Me.TextNama.Name = "TextNama"
        Me.TextNama.Size = New System.Drawing.Size(13, 15)
        Me.TextNama.TabIndex = 54
        Me.TextNama.Text = "-"
        '
        'TextNPM
        '
        Me.TextNPM.AutoSize = True
        Me.TextNPM.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNPM.Location = New System.Drawing.Point(165, 49)
        Me.TextNPM.Name = "TextNPM"
        Me.TextNPM.Size = New System.Drawing.Size(13, 15)
        Me.TextNPM.TabIndex = 55
        Me.TextNPM.Text = "-"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 481)
        Me.Controls.Add(Me.TextNPM)
        Me.Controls.Add(Me.TextNama)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.EtTampilNilai)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.EtNilaiPraktikum)
        Me.Controls.Add(Me.EtNilaiUAS)
        Me.Controls.Add(Me.EtNilaiUTS)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents EtTampilNilai As TextBox
    Private WithEvents BtnHitung As Button
    Private WithEvents label6 As Label
    Private WithEvents EtNilaiPraktikum As TextBox
    Private WithEvents EtNilaiUAS As TextBox
    Private WithEvents EtNilaiUTS As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents TextNama As Label
    Friend WithEvents TextNPM As Label
End Class

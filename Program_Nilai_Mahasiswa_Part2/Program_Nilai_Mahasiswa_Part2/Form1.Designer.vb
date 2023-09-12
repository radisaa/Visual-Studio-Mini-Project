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
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EtNama = New System.Windows.Forms.TextBox()
        Me.EtNPM = New System.Windows.Forms.TextBox()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Montserrat", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(61, 95)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(310, 39)
        Me.label1.TabIndex = 5
        Me.label1.Text = "PENILAIAN AKHIR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "NAMA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "NPM"
        '
        'EtNama
        '
        Me.EtNama.Location = New System.Drawing.Point(136, 206)
        Me.EtNama.Name = "EtNama"
        Me.EtNama.Size = New System.Drawing.Size(216, 20)
        Me.EtNama.TabIndex = 8
        '
        'EtNPM
        '
        Me.EtNPM.Location = New System.Drawing.Point(136, 257)
        Me.EtNPM.Name = "EtNPM"
        Me.EtNPM.Size = New System.Drawing.Size(216, 20)
        Me.EtNPM.TabIndex = 9
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnNext.Location = New System.Drawing.Point(148, 321)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(113, 49)
        Me.BtnNext.TabIndex = 10
        Me.BtnNext.Text = "NEXT"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 480)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.EtNPM)
        Me.Controls.Add(Me.EtNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnNext As Button
    Public WithEvents EtNama As TextBox
    Public WithEvents EtNPM As TextBox
End Class

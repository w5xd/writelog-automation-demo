<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.KeyboardLabel = New System.Windows.Forms.Label()
        Me.TransmitLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'KeyboardLabel
        '
        Me.KeyboardLabel.AutoSize = True
        Me.KeyboardLabel.Location = New System.Drawing.Point(37, 22)
        Me.KeyboardLabel.Name = "KeyboardLabel"
        Me.KeyboardLabel.Size = New System.Drawing.Size(24, 13)
        Me.KeyboardLabel.TabIndex = 0
        Me.KeyboardLabel.Text = "test"
        '
        'TransmitLabel
        '
        Me.TransmitLabel.AutoSize = True
        Me.TransmitLabel.Location = New System.Drawing.Point(37, 62)
        Me.TransmitLabel.Name = "TransmitLabel"
        Me.TransmitLabel.Size = New System.Drawing.Size(43, 13)
        Me.TransmitLabel.TabIndex = 1
        Me.TransmitLabel.Text = "transmit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 110)
        Me.Controls.Add(Me.TransmitLabel)
        Me.Controls.Add(Me.KeyboardLabel)
        Me.Name = "MainForm"
        Me.Text = "WriteLog Automation Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KeyboardLabel As System.Windows.Forms.Label
    Friend WithEvents TransmitLabel As System.Windows.Forms.Label

End Class

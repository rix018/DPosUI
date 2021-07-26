<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lapagan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DposUIGroupbox1 = New DPosUI.dposUIGroupbox()
        Me.SuspendLayout()
        '
        'DposUIGroupbox1
        '
        Me.DposUIGroupbox1.BorderColor = System.Drawing.Color.Black
        Me.DposUIGroupbox1.BorderThickness = 2
        Me.DposUIGroupbox1.Location = New System.Drawing.Point(109, 62)
        Me.DposUIGroupbox1.Name = "DposUIGroupbox1"
        Me.DposUIGroupbox1.Size = New System.Drawing.Size(200, 100)
        Me.DposUIGroupbox1.TabIndex = 0
        Me.DposUIGroupbox1.TabStop = False
        Me.DposUIGroupbox1.Text = "asdasdasd"
        '
        'Lapagan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(636, 450)
        Me.Controls.Add(Me.DposUIGroupbox1)
        Me.Name = "Lapagan"
        Me.Text = "Lapagan"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DposUIGroupbox1 As dposUIGroupbox
End Class

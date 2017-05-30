<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Found
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSearchWord = New System.Windows.Forms.Label()
        Me.flowPnlFound = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Here are the words associated with:"
        '
        'lblSearchWord
        '
        Me.lblSearchWord.AutoSize = True
        Me.lblSearchWord.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchWord.ForeColor = System.Drawing.Color.Red
        Me.lblSearchWord.Location = New System.Drawing.Point(38, 55)
        Me.lblSearchWord.Name = "lblSearchWord"
        Me.lblSearchWord.Size = New System.Drawing.Size(0, 33)
        Me.lblSearchWord.TabIndex = 1
        '
        'flowPnlFound
        '
        Me.flowPnlFound.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.flowPnlFound.Location = New System.Drawing.Point(12, 105)
        Me.flowPnlFound.Name = "flowPnlFound"
        Me.flowPnlFound.Size = New System.Drawing.Size(388, 235)
        Me.flowPnlFound.TabIndex = 2
        '
        'Found
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(412, 352)
        Me.Controls.Add(Me.flowPnlFound)
        Me.Controls.Add(Me.lblSearchWord)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Found"
        Me.Text = "Found"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSearchWord As System.Windows.Forms.Label
    Friend WithEvents flowPnlFound As System.Windows.Forms.FlowLayoutPanel
End Class

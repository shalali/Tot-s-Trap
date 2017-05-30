<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display
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
        Me.lblWord = New System.Windows.Forms.Label()
        Me.FlowPnlKeywords = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picDisplay = New System.Windows.Forms.PictureBox()
        Me.lblDefinition = New System.Windows.Forms.TextBox()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord.ForeColor = System.Drawing.Color.Red
        Me.lblWord.Location = New System.Drawing.Point(14, 28)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(78, 33)
        Me.lblWord.TabIndex = 0
        Me.lblWord.Text = "Label1"
        '
        'FlowPnlKeywords
        '
        Me.FlowPnlKeywords.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowPnlKeywords.ForeColor = System.Drawing.Color.Red
        Me.FlowPnlKeywords.Location = New System.Drawing.Point(242, 28)
        Me.FlowPnlKeywords.Name = "FlowPnlKeywords"
        Me.FlowPnlKeywords.Size = New System.Drawing.Size(170, 322)
        Me.FlowPnlKeywords.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Word"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(17, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Definition"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(239, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Keywords"
        '
        'picDisplay
        '
        Me.picDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDisplay.Location = New System.Drawing.Point(20, 192)
        Me.picDisplay.Name = "picDisplay"
        Me.picDisplay.Size = New System.Drawing.Size(193, 158)
        Me.picDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDisplay.TabIndex = 7
        Me.picDisplay.TabStop = False
        '
        'lblDefinition
        '
        Me.lblDefinition.BackColor = System.Drawing.Color.White
        Me.lblDefinition.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblDefinition.Enabled = False
        Me.lblDefinition.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefinition.ForeColor = System.Drawing.Color.Red
        Me.lblDefinition.Location = New System.Drawing.Point(12, 91)
        Me.lblDefinition.Multiline = True
        Me.lblDefinition.Name = "lblDefinition"
        Me.lblDefinition.Size = New System.Drawing.Size(212, 95)
        Me.lblDefinition.TabIndex = 8
        '
        'Display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(412, 352)
        Me.Controls.Add(Me.lblDefinition)
        Me.Controls.Add(Me.picDisplay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowPnlKeywords)
        Me.Controls.Add(Me.lblWord)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Display"
        Me.Text = "Display"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Silver
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWord As System.Windows.Forms.Label
    Friend WithEvents FlowPnlKeywords As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picDisplay As System.Windows.Forms.PictureBox
    Friend WithEvents lblDefinition As System.Windows.Forms.TextBox
End Class

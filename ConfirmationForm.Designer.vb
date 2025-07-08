<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfirmationForm))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pbSuccessIcon = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnBackHome = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbSuccessIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(3, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 48)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'pbSuccessIcon
        '
        Me.pbSuccessIcon.Image = CType(resources.GetObject("pbSuccessIcon.Image"), System.Drawing.Image)
        Me.pbSuccessIcon.Location = New System.Drawing.Point(18, 151)
        Me.pbSuccessIcon.Name = "pbSuccessIcon"
        Me.pbSuccessIcon.Size = New System.Drawing.Size(378, 115)
        Me.pbSuccessIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSuccessIcon.TabIndex = 4
        Me.pbSuccessIcon.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(18, 279)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(378, 50)
        Me.lblHeader.TabIndex = 5
        Me.lblHeader.Text = "Payment successful!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBackHome
        '
        Me.btnBackHome.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBackHome.FlatAppearance.BorderSize = 0
        Me.btnBackHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackHome.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackHome.ForeColor = System.Drawing.Color.Black
        Me.btnBackHome.Location = New System.Drawing.Point(24, 636)
        Me.btnBackHome.Name = "btnBackHome"
        Me.btnBackHome.Size = New System.Drawing.Size(378, 60)
        Me.btnBackHome.TabIndex = 7
        Me.btnBackHome.Text = "Back To Home"
        Me.btnBackHome.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 373)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 63)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Your subscription has been activated." & Global.Microsoft.VisualBasic.ChrW(10) & "Thank you for your trust and support!" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ConfirmationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(414, 736)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBackHome)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.pbSuccessIcon)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConfirmationForm"
        Me.Text = "ConfirmationForm"
        CType(Me.pbSuccessIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents pbSuccessIcon As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnBackHome As Button
    Friend WithEvents Label1 As Label
End Class

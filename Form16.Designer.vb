<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form16
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form16))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.btnBackHome = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbSuccessIcon = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbSuccessIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblHeader.Location = New System.Drawing.Point(3, 10)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(372, 70)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Thank you! Your order is confirmed."
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProduct
        '
        Me.lblProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.ForeColor = System.Drawing.Color.White
        Me.lblProduct.Location = New System.Drawing.Point(7, 50)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(145, 23)
        Me.lblProduct.TabIndex = 2
        Me.lblProduct.Text = "Product Name:"
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
        Me.btnBackHome.TabIndex = 6
        Me.btnBackHome.Text = "Back To Home"
        Me.btnBackHome.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblOrderID)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.lblQuantity)
        Me.Panel1.Controls.Add(Me.lblProduct)
        Me.Panel1.Location = New System.Drawing.Point(24, 216)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 404)
        Me.Panel1.TabIndex = 7
        '
        'lblOrderID
        '
        Me.lblOrderID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblOrderID.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderID.ForeColor = System.Drawing.Color.White
        Me.lblOrderID.Location = New System.Drawing.Point(7, 230)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(100, 23)
        Me.lblOrderID.TabIndex = 5
        Me.lblOrderID.Text = "Order ID:"
        '
        'lblTotal
        '
        Me.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(7, 170)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total:"
        '
        'lblQuantity
        '
        Me.lblQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.White
        Me.lblQuantity.Location = New System.Drawing.Point(7, 110)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(100, 23)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "Quantity:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblHeader)
        Me.Panel2.Location = New System.Drawing.Point(24, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(378, 92)
        Me.Panel2.TabIndex = 8
        '
        'pbSuccessIcon
        '
        Me.pbSuccessIcon.Image = CType(resources.GetObject("pbSuccessIcon.Image"), System.Drawing.Image)
        Me.pbSuccessIcon.Location = New System.Drawing.Point(24, 110)
        Me.pbSuccessIcon.Name = "pbSuccessIcon"
        Me.pbSuccessIcon.Size = New System.Drawing.Size(378, 100)
        Me.pbSuccessIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSuccessIcon.TabIndex = 1
        Me.pbSuccessIcon.TabStop = False
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(414, 736)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBackHome)
        Me.Controls.Add(Me.pbSuccessIcon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form16"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.pbSuccessIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents pbSuccessIcon As PictureBox
    Friend WithEvents lblProduct As Label
    Friend WithEvents btnBackHome As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblOrderID As Label
    Friend WithEvents Panel2 As Panel
End Class

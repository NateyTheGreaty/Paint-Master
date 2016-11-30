<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaxiFare
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaxiFare))
        Me.picTaxi = New System.Windows.Forms.PictureBox()
        Me.lblTaxi = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblMilesTraveled = New System.Windows.Forms.Label()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.lblTotalFare = New System.Windows.Forms.Label()
        Me.lblCostLabel = New System.Windows.Forms.Label()
        Me.btnFee = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picTaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTaxi
        '
        Me.picTaxi.Image = CType(resources.GetObject("picTaxi.Image"), System.Drawing.Image)
        Me.picTaxi.Location = New System.Drawing.Point(3, 12)
        Me.picTaxi.Name = "picTaxi"
        Me.picTaxi.Size = New System.Drawing.Size(136, 148)
        Me.picTaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTaxi.TabIndex = 0
        Me.picTaxi.TabStop = False
        '
        'lblTaxi
        '
        Me.lblTaxi.AutoSize = True
        Me.lblTaxi.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxi.Location = New System.Drawing.Point(154, 22)
        Me.lblTaxi.Name = "lblTaxi"
        Me.lblTaxi.Size = New System.Drawing.Size(144, 34)
        Me.lblTaxi.TabIndex = 1
        Me.lblTaxi.Text = "Taxi fare"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(145, 96)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(153, 14)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Only $2.25 plus milegae"
        '
        'lblMilesTraveled
        '
        Me.lblMilesTraveled.AutoSize = True
        Me.lblMilesTraveled.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilesTraveled.Location = New System.Drawing.Point(15, 193)
        Me.lblMilesTraveled.Name = "lblMilesTraveled"
        Me.lblMilesTraveled.Size = New System.Drawing.Size(124, 19)
        Me.lblMilesTraveled.TabIndex = 3
        Me.lblMilesTraveled.Text = "Miles traveled"
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(160, 191)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(28, 20)
        Me.txtMiles.TabIndex = 4
        '
        'lblTotalFare
        '
        Me.lblTotalFare.AutoSize = True
        Me.lblTotalFare.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFare.Location = New System.Drawing.Point(15, 237)
        Me.lblTotalFare.Name = "lblTotalFare"
        Me.lblTotalFare.Size = New System.Drawing.Size(90, 19)
        Me.lblTotalFare.TabIndex = 5
        Me.lblTotalFare.Text = "Total fare"
        '
        'lblCostLabel
        '
        Me.lblCostLabel.AutoSize = True
        Me.lblCostLabel.Location = New System.Drawing.Point(160, 242)
        Me.lblCostLabel.Name = "lblCostLabel"
        Me.lblCostLabel.Size = New System.Drawing.Size(0, 13)
        Me.lblCostLabel.TabIndex = 6
        '
        'btnFee
        '
        Me.btnFee.Location = New System.Drawing.Point(19, 283)
        Me.btnFee.Name = "btnFee"
        Me.btnFee.Size = New System.Drawing.Size(75, 23)
        Me.btnFee.TabIndex = 7
        Me.btnFee.Text = "Display fee"
        Me.btnFee.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(132, 283)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(247, 283)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'TaxiFare
        '
        Me.AcceptButton = Me.btnFee
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(334, 318)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFee)
        Me.Controls.Add(Me.lblCostLabel)
        Me.Controls.Add(Me.lblTotalFare)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.lblMilesTraveled)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblTaxi)
        Me.Controls.Add(Me.picTaxi)
        Me.Name = "TaxiFare"
        Me.Text = "TaxiFare"
        CType(Me.picTaxi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picTaxi As System.Windows.Forms.PictureBox
    Friend WithEvents lblTaxi As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblMilesTraveled As System.Windows.Forms.Label
    Friend WithEvents txtMiles As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalFare As System.Windows.Forms.Label
    Friend WithEvents lblCostLabel As System.Windows.Forms.Label
    Friend WithEvents btnFee As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class

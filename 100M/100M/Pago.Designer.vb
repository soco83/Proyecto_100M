<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pago
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pago))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn10 = New System.Windows.Forms.Button()
        Me.Btn20 = New System.Windows.Forms.Button()
        Me.Btn50 = New System.Windows.Forms.Button()
        Me.Btn100 = New System.Windows.Forms.Button()
        Me.Btn_01 = New System.Windows.Forms.Button()
        Me.Btn_02 = New System.Windows.Forms.Button()
        Me.Btn_05 = New System.Windows.Forms.Button()
        Me.Btn_10 = New System.Windows.Forms.Button()
        Me.Btn_20 = New System.Windows.Forms.Button()
        Me.Btn_50 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Lb1 = New System.Windows.Forms.Label()
        Me.Lb2 = New System.Windows.Forms.Label()
        Me.Lb3 = New System.Windows.Forms.Label()
        Me.LbImporte = New System.Windows.Forms.Label()
        Me.LbADevolver = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxBHaPagado = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn10)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn20)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn50)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn100)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_01)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_02)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_05)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_10)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_20)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_50)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(416, 235)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(177, 290)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Btn5
        '
        Me.Btn5.Location = New System.Drawing.Point(3, 3)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(82, 35)
        Me.Btn5.TabIndex = 0
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = True
        '
        'Btn10
        '
        Me.Btn10.Location = New System.Drawing.Point(91, 3)
        Me.Btn10.Name = "Btn10"
        Me.Btn10.Size = New System.Drawing.Size(82, 35)
        Me.Btn10.TabIndex = 1
        Me.Btn10.Text = "10"
        Me.Btn10.UseVisualStyleBackColor = True
        '
        'Btn20
        '
        Me.Btn20.Location = New System.Drawing.Point(3, 44)
        Me.Btn20.Name = "Btn20"
        Me.Btn20.Size = New System.Drawing.Size(82, 35)
        Me.Btn20.TabIndex = 2
        Me.Btn20.Text = "20"
        Me.Btn20.UseVisualStyleBackColor = True
        '
        'Btn50
        '
        Me.Btn50.Location = New System.Drawing.Point(91, 44)
        Me.Btn50.Name = "Btn50"
        Me.Btn50.Size = New System.Drawing.Size(82, 35)
        Me.Btn50.TabIndex = 3
        Me.Btn50.Text = "50"
        Me.Btn50.UseVisualStyleBackColor = True
        '
        'Btn100
        '
        Me.Btn100.Location = New System.Drawing.Point(3, 85)
        Me.Btn100.Name = "Btn100"
        Me.Btn100.Size = New System.Drawing.Size(82, 35)
        Me.Btn100.TabIndex = 4
        Me.Btn100.Text = "100"
        Me.Btn100.UseVisualStyleBackColor = True
        '
        'Btn_01
        '
        Me.Btn_01.Location = New System.Drawing.Point(91, 85)
        Me.Btn_01.Name = "Btn_01"
        Me.Btn_01.Size = New System.Drawing.Size(82, 35)
        Me.Btn_01.TabIndex = 5
        Me.Btn_01.Text = "0.01"
        Me.Btn_01.UseVisualStyleBackColor = True
        '
        'Btn_02
        '
        Me.Btn_02.Location = New System.Drawing.Point(3, 126)
        Me.Btn_02.Name = "Btn_02"
        Me.Btn_02.Size = New System.Drawing.Size(82, 35)
        Me.Btn_02.TabIndex = 6
        Me.Btn_02.Text = "0.02"
        Me.Btn_02.UseVisualStyleBackColor = True
        '
        'Btn_05
        '
        Me.Btn_05.Location = New System.Drawing.Point(91, 126)
        Me.Btn_05.Name = "Btn_05"
        Me.Btn_05.Size = New System.Drawing.Size(82, 35)
        Me.Btn_05.TabIndex = 7
        Me.Btn_05.Text = "0.05"
        Me.Btn_05.UseVisualStyleBackColor = True
        '
        'Btn_10
        '
        Me.Btn_10.Location = New System.Drawing.Point(3, 167)
        Me.Btn_10.Name = "Btn_10"
        Me.Btn_10.Size = New System.Drawing.Size(82, 35)
        Me.Btn_10.TabIndex = 8
        Me.Btn_10.Text = "0.10"
        Me.Btn_10.UseVisualStyleBackColor = True
        '
        'Btn_20
        '
        Me.Btn_20.Location = New System.Drawing.Point(91, 167)
        Me.Btn_20.Name = "Btn_20"
        Me.Btn_20.Size = New System.Drawing.Size(82, 35)
        Me.Btn_20.TabIndex = 9
        Me.Btn_20.Text = "0.20"
        Me.Btn_20.UseVisualStyleBackColor = True
        '
        'Btn_50
        '
        Me.Btn_50.Location = New System.Drawing.Point(3, 208)
        Me.Btn_50.Name = "Btn_50"
        Me.Btn_50.Size = New System.Drawing.Size(82, 35)
        Me.Btn_50.TabIndex = 10
        Me.Btn_50.Text = "0.50"
        Me.Btn_50.UseVisualStyleBackColor = True
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(91, 208)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(82, 35)
        Me.Btn1.TabIndex = 11
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(3, 249)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(82, 35)
        Me.Btn2.TabIndex = 12
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Lb1
        '
        Me.Lb1.AutoSize = True
        Me.Lb1.Location = New System.Drawing.Point(12, 9)
        Me.Lb1.Name = "Lb1"
        Me.Lb1.Size = New System.Drawing.Size(86, 26)
        Me.Lb1.TabIndex = 1
        Me.Lb1.Text = "Importe"
        '
        'Lb2
        '
        Me.Lb2.AutoSize = True
        Me.Lb2.Location = New System.Drawing.Point(12, 50)
        Me.Lb2.Name = "Lb2"
        Me.Lb2.Size = New System.Drawing.Size(118, 26)
        Me.Lb2.TabIndex = 2
        Me.Lb2.Text = "Ha pagado"
        '
        'Lb3
        '
        Me.Lb3.AutoSize = True
        Me.Lb3.Location = New System.Drawing.Point(12, 91)
        Me.Lb3.Name = "Lb3"
        Me.Lb3.Size = New System.Drawing.Size(115, 26)
        Me.Lb3.TabIndex = 3
        Me.Lb3.Text = "A devolver"
        '
        'LbImporte
        '
        Me.LbImporte.AutoSize = True
        Me.LbImporte.Location = New System.Drawing.Point(158, 9)
        Me.LbImporte.Name = "LbImporte"
        Me.LbImporte.Size = New System.Drawing.Size(77, 26)
        Me.LbImporte.TabIndex = 4
        Me.LbImporte.Text = "Label1"
        '
        'LbADevolver
        '
        Me.LbADevolver.AutoSize = True
        Me.LbADevolver.Location = New System.Drawing.Point(158, 91)
        Me.LbADevolver.Name = "LbADevolver"
        Me.LbADevolver.Size = New System.Drawing.Size(0, 26)
        Me.LbADevolver.TabIndex = 6
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(66, 133)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(130, 57)
        Me.BtnAceptar.TabIndex = 7
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxBHaPagado
        '
        Me.TxBHaPagado.Location = New System.Drawing.Point(157, 47)
        Me.TxBHaPagado.Name = "TxBHaPagado"
        Me.TxBHaPagado.Size = New System.Drawing.Size(100, 32)
        Me.TxBHaPagado.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 251)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 204)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxBHaPagado)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LbADevolver)
        Me.Controls.Add(Me.LbImporte)
        Me.Controls.Add(Me.Lb3)
        Me.Controls.Add(Me.Lb2)
        Me.Controls.Add(Me.Lb1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "Pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn10 As Button
    Friend WithEvents Btn20 As Button
    Friend WithEvents Btn50 As Button
    Friend WithEvents Btn100 As Button
    Friend WithEvents Btn_01 As Button
    Friend WithEvents Btn_02 As Button
    Friend WithEvents Btn_05 As Button
    Friend WithEvents Btn_10 As Button
    Friend WithEvents Btn_20 As Button
    Friend WithEvents Btn_50 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Lb1 As Label
    Friend WithEvents Lb2 As Label
    Friend WithEvents Lb3 As Label
    Friend WithEvents LbImporte As Label
    Friend WithEvents LbADevolver As Label
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxBHaPagado As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista_Users_Prods
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lista_Users_Prods))
        Me.LbTitulo = New System.Windows.Forms.Label()
        Me.LBVista = New System.Windows.Forms.ListBox()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LbTitulo
        '
        Me.LbTitulo.AutoSize = True
        Me.LbTitulo.Location = New System.Drawing.Point(7, 9)
        Me.LbTitulo.Name = "LbTitulo"
        Me.LbTitulo.Size = New System.Drawing.Size(94, 26)
        Me.LbTitulo.TabIndex = 0
        Me.LbTitulo.Text = "Lista de "
        '
        'LBVista
        '
        Me.LBVista.FormattingEnabled = True
        Me.LBVista.ItemHeight = 26
        Me.LBVista.Location = New System.Drawing.Point(12, 53)
        Me.LBVista.Name = "LBVista"
        Me.LBVista.Size = New System.Drawing.Size(390, 342)
        Me.LBVista.TabIndex = 1
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(12, 401)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(184, 71)
        Me.BtnEditar.TabIndex = 2
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(218, 401)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(184, 71)
        Me.BtnBorrar.TabIndex = 3
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(248, 9)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(154, 38)
        Me.BtnVolver.TabIndex = 4
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'Lista_Users_Prods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.LBVista)
        Me.Controls.Add(Me.LbTitulo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "Lista_Users_Prods"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de los productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbTitulo As Label
    Friend WithEvents LBVista As ListBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnVolver As Button
End Class

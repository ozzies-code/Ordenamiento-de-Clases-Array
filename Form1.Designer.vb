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
        Me.btnllenar = New System.Windows.Forms.Button()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.btnRevertir = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnllenar
        '
        Me.btnllenar.BackColor = System.Drawing.Color.Maroon
        Me.btnllenar.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnllenar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnllenar.Location = New System.Drawing.Point(25, 283)
        Me.btnllenar.Name = "btnllenar"
        Me.btnllenar.Size = New System.Drawing.Size(102, 54)
        Me.btnllenar.TabIndex = 6
        Me.btnllenar.Text = "llenar"
        Me.btnllenar.UseVisualStyleBackColor = False
        '
        'txtOrder
        '
        Me.txtOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrder.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrder.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtOrder.Location = New System.Drawing.Point(25, 12)
        Me.txtOrder.Multiline = True
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOrder.Size = New System.Drawing.Size(336, 265)
        Me.txtOrder.TabIndex = 5
        '
        'btnOrdenar
        '
        Me.btnOrdenar.BackColor = System.Drawing.Color.Maroon
        Me.btnOrdenar.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOrdenar.Location = New System.Drawing.Point(133, 283)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(102, 54)
        Me.btnOrdenar.TabIndex = 7
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = False
        '
        'btnRevertir
        '
        Me.btnRevertir.BackColor = System.Drawing.Color.Maroon
        Me.btnRevertir.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRevertir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRevertir.Location = New System.Drawing.Point(241, 283)
        Me.btnRevertir.Name = "btnRevertir"
        Me.btnRevertir.Size = New System.Drawing.Size(102, 54)
        Me.btnRevertir.TabIndex = 8
        Me.btnRevertir.Text = "Revertir"
        Me.btnRevertir.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(110, 352)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(149, 23)
        Me.ProgressBar1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(22, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Progreso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(265, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 18)
        Me.Label2.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(376, 386)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnRevertir)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.btnllenar)
        Me.Controls.Add(Me.txtOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = "Ordenamiento de Clases Array"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnllenar As Button
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents btnOrdenar As Button
    Friend WithEvents btnRevertir As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

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
        Me.Btconvert = New System.Windows.Forms.Button
        Me.ListMedidas = New System.Windows.Forms.ListBox
        Me.Numinicio = New System.Windows.Forms.NumericUpDown
        Me.Numfim = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.Numinicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Numfim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btconvert
        '
        Me.Btconvert.Location = New System.Drawing.Point(12, 80)
        Me.Btconvert.Name = "Btconvert"
        Me.Btconvert.Size = New System.Drawing.Size(220, 31)
        Me.Btconvert.TabIndex = 0
        Me.Btconvert.Text = "Converter"
        Me.Btconvert.UseVisualStyleBackColor = True
        '
        'ListMedidas
        '
        Me.ListMedidas.FormattingEnabled = True
        Me.ListMedidas.Location = New System.Drawing.Point(12, 126)
        Me.ListMedidas.Name = "ListMedidas"
        Me.ListMedidas.Size = New System.Drawing.Size(220, 95)
        Me.ListMedidas.TabIndex = 2
        '
        'Numinicio
        '
        Me.Numinicio.Location = New System.Drawing.Point(12, 40)
        Me.Numinicio.Name = "Numinicio"
        Me.Numinicio.Size = New System.Drawing.Size(104, 20)
        Me.Numinicio.TabIndex = 3
        '
        'Numfim
        '
        Me.Numfim.Location = New System.Drawing.Point(128, 40)
        Me.Numfim.Name = "Numfim"
        Me.Numfim.Size = New System.Drawing.Size(104, 20)
        Me.Numfim.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Fim"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(245, 243)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Numfim)
        Me.Controls.Add(Me.Numinicio)
        Me.Controls.Add(Me.ListMedidas)
        Me.Controls.Add(Me.Btconvert)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Conversor De polegadas"
        CType(Me.Numinicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Numfim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btconvert As System.Windows.Forms.Button
    Friend WithEvents ListMedidas As System.Windows.Forms.ListBox
    Friend WithEvents Numinicio As System.Windows.Forms.NumericUpDown
    Friend WithEvents Numfim As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class

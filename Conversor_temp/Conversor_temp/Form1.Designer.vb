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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cf = New System.Windows.Forms.RadioButton
        Me.fc = New System.Windows.Forms.RadioButton
        Me.ck = New System.Windows.Forms.RadioButton
        Me.kc = New System.Windows.Forms.RadioButton
        Me.Bt_calcular = New System.Windows.Forms.Button
        Me.Bt_sair = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Insira um valor :"
        '
        'cf
        '
        Me.cf.AutoSize = True
        Me.cf.Location = New System.Drawing.Point(15, 72)
        Me.cf.Name = "cf"
        Me.cf.Size = New System.Drawing.Size(123, 17)
        Me.cf.TabIndex = 2
        Me.cf.TabStop = True
        Me.cf.Text = "Celsius -> Fahrenheit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.cf.UseVisualStyleBackColor = True
        '
        'fc
        '
        Me.fc.AutoSize = True
        Me.fc.Location = New System.Drawing.Point(165, 72)
        Me.fc.Name = "fc"
        Me.fc.Size = New System.Drawing.Size(123, 17)
        Me.fc.TabIndex = 3
        Me.fc.TabStop = True
        Me.fc.Text = "Fahrenheit -> Celsius"
        Me.fc.UseVisualStyleBackColor = True
        '
        'ck
        '
        Me.ck.AutoSize = True
        Me.ck.Location = New System.Drawing.Point(15, 95)
        Me.ck.Name = "ck"
        Me.ck.Size = New System.Drawing.Size(102, 17)
        Me.ck.TabIndex = 4
        Me.ck.TabStop = True
        Me.ck.Text = "Celsius -> Kelvin"
        Me.ck.UseVisualStyleBackColor = True
        '
        'kc
        '
        Me.kc.AutoSize = True
        Me.kc.Location = New System.Drawing.Point(165, 95)
        Me.kc.Name = "kc"
        Me.kc.Size = New System.Drawing.Size(102, 17)
        Me.kc.TabIndex = 5
        Me.kc.TabStop = True
        Me.kc.Text = "Kelvin -> Celsius"
        Me.kc.UseVisualStyleBackColor = True
        '
        'Bt_calcular
        '
        Me.Bt_calcular.Font = New System.Drawing.Font("Lucida Console", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_calcular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bt_calcular.Location = New System.Drawing.Point(106, 148)
        Me.Bt_calcular.Name = "Bt_calcular"
        Me.Bt_calcular.Size = New System.Drawing.Size(86, 23)
        Me.Bt_calcular.TabIndex = 6
        Me.Bt_calcular.Text = "Calcular"
        Me.Bt_calcular.UseVisualStyleBackColor = True
        '
        'Bt_sair
        '
        Me.Bt_sair.Location = New System.Drawing.Point(261, 148)
        Me.Bt_sair.Name = "Bt_sair"
        Me.Bt_sair.Size = New System.Drawing.Size(39, 23)
        Me.Bt_sair.TabIndex = 7
        Me.Bt_sair.Text = "Sair"
        Me.Bt_sair.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(312, 183)
        Me.Controls.Add(Me.Bt_sair)
        Me.Controls.Add(Me.Bt_calcular)
        Me.Controls.Add(Me.kc)
        Me.Controls.Add(Me.ck)
        Me.Controls.Add(Me.fc)
        Me.Controls.Add(Me.cf)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Conversor de temperatura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cf As System.Windows.Forms.RadioButton
    Friend WithEvents fc As System.Windows.Forms.RadioButton
    Friend WithEvents ck As System.Windows.Forms.RadioButton
    Friend WithEvents kc As System.Windows.Forms.RadioButton
    Friend WithEvents Bt_calcular As System.Windows.Forms.Button
    Friend WithEvents Bt_sair As System.Windows.Forms.Button

End Class

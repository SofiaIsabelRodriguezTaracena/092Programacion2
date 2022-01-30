<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tazucar = New System.Windows.Forms.TextBox()
        Me.tfrijol = New System.Windows.Forms.TextBox()
        Me.tarroz = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LR6 = New System.Windows.Forms.Label()
        Me.LR5 = New System.Windows.Forms.Label()
        Me.LR3 = New System.Windows.Forms.Label()
        Me.LR2 = New System.Windows.Forms.Label()
        Me.LR1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Buttonaceptar = New System.Windows.Forms.Button()
        Me.Opciones = New System.Windows.Forms.GroupBox()
        Me.Buttonsalir = New System.Windows.Forms.Button()
        Me.Buttonlimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Opciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightPink
        Me.GroupBox1.Controls.Add(Me.tazucar)
        Me.GroupBox1.Controls.Add(Me.tfrijol)
        Me.GroupBox1.Controls.Add(Me.tarroz)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de ingreso"
        '
        'tazucar
        '
        Me.tazucar.Location = New System.Drawing.Point(120, 111)
        Me.tazucar.Name = "tazucar"
        Me.tazucar.Size = New System.Drawing.Size(100, 20)
        Me.tazucar.TabIndex = 5
        Me.tazucar.Text = "0"
        '
        'tfrijol
        '
        Me.tfrijol.Location = New System.Drawing.Point(120, 69)
        Me.tfrijol.Name = "tfrijol"
        Me.tfrijol.Size = New System.Drawing.Size(100, 20)
        Me.tfrijol.TabIndex = 4
        Me.tfrijol.Text = "0"
        '
        'tarroz
        '
        Me.tarroz.Location = New System.Drawing.Point(120, 24)
        Me.tarroz.Name = "tarroz"
        Me.tarroz.Size = New System.Drawing.Size(100, 20)
        Me.tarroz.TabIndex = 3
        Me.tarroz.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Libras de azúcar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Libras de frijol"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Libras de arroz"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Pago antes del IVA"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DeepPink
        Me.GroupBox2.Controls.Add(Me.LR6)
        Me.GroupBox2.Controls.Add(Me.LR5)
        Me.GroupBox2.Controls.Add(Me.LR3)
        Me.GroupBox2.Controls.Add(Me.LR2)
        Me.GroupBox2.Controls.Add(Me.LR1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(527, 212)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados "
        '
        'LR6
        '
        Me.LR6.AutoSize = True
        Me.LR6.Location = New System.Drawing.Point(299, 89)
        Me.LR6.Name = "LR6"
        Me.LR6.Size = New System.Drawing.Size(22, 13)
        Me.LR6.TabIndex = 12
        Me.LR6.Text = "0.0"
        '
        'LR5
        '
        Me.LR5.AutoSize = True
        Me.LR5.Location = New System.Drawing.Point(143, 141)
        Me.LR5.Name = "LR5"
        Me.LR5.Size = New System.Drawing.Size(22, 13)
        Me.LR5.TabIndex = 11
        Me.LR5.Text = "0.0"
        '
        'LR3
        '
        Me.LR3.AutoSize = True
        Me.LR3.Location = New System.Drawing.Point(143, 103)
        Me.LR3.Name = "LR3"
        Me.LR3.Size = New System.Drawing.Size(22, 13)
        Me.LR3.TabIndex = 9
        Me.LR3.Text = "0.0"
        '
        'LR2
        '
        Me.LR2.AutoSize = True
        Me.LR2.Location = New System.Drawing.Point(143, 66)
        Me.LR2.Name = "LR2"
        Me.LR2.Size = New System.Drawing.Size(22, 13)
        Me.LR2.TabIndex = 8
        Me.LR2.Text = "0.0"
        '
        'LR1
        '
        Me.LR1.AutoSize = True
        Me.LR1.Location = New System.Drawing.Point(143, 27)
        Me.LR1.Name = "LR1"
        Me.LR1.Size = New System.Drawing.Size(22, 13)
        Me.LR1.TabIndex = 7
        Me.LR1.Text = "0.0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(225, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "El pago Final"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "El descuento "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "El pago con el IVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "El valor del IVA"
        '
        'Buttonaceptar
        '
        Me.Buttonaceptar.Location = New System.Drawing.Point(62, 19)
        Me.Buttonaceptar.Name = "Buttonaceptar"
        Me.Buttonaceptar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonaceptar.TabIndex = 3
        Me.Buttonaceptar.Text = "Aceptar"
        Me.Buttonaceptar.UseVisualStyleBackColor = True
        '
        'Opciones
        '
        Me.Opciones.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Opciones.Controls.Add(Me.Buttonsalir)
        Me.Opciones.Controls.Add(Me.Buttonlimpiar)
        Me.Opciones.Controls.Add(Me.Buttonaceptar)
        Me.Opciones.Location = New System.Drawing.Point(339, 21)
        Me.Opciones.Name = "Opciones"
        Me.Opciones.Size = New System.Drawing.Size(200, 144)
        Me.Opciones.TabIndex = 4
        Me.Opciones.TabStop = False
        Me.Opciones.Text = "Opciones"
        '
        'Buttonsalir
        '
        Me.Buttonsalir.Location = New System.Drawing.Point(62, 99)
        Me.Buttonsalir.Name = "Buttonsalir"
        Me.Buttonsalir.Size = New System.Drawing.Size(75, 23)
        Me.Buttonsalir.TabIndex = 5
        Me.Buttonsalir.Text = "Salir"
        Me.Buttonsalir.UseVisualStyleBackColor = True
        '
        'Buttonlimpiar
        '
        Me.Buttonlimpiar.Location = New System.Drawing.Point(62, 60)
        Me.Buttonlimpiar.Name = "Buttonlimpiar"
        Me.Buttonlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.Buttonlimpiar.TabIndex = 4
        Me.Buttonlimpiar.Text = "Limpiar"
        Me.Buttonlimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Opciones)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Opciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tazucar As TextBox
    Friend WithEvents tfrijol As TextBox
    Friend WithEvents tarroz As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LR1 As Label
    Friend WithEvents LR6 As Label
    Friend WithEvents LR5 As Label
    Friend WithEvents LR3 As Label
    Friend WithEvents LR2 As Label
    Friend WithEvents Buttonaceptar As Button
    Friend WithEvents Opciones As GroupBox
    Friend WithEvents Buttonsalir As Button
    Friend WithEvents Buttonlimpiar As Button
End Class

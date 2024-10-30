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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tx_cliente = New System.Windows.Forms.TextBox()
        Me.tx_Telefono = New System.Windows.Forms.TextBox()
        Me.tx_correo = New System.Windows.Forms.TextBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_reiniciar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tx_idcliente = New System.Windows.Forms.TextBox()
        Me.btn_vista = New System.Windows.Forms.Button()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telefono: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correo:"
        '
        'tx_cliente
        '
        Me.tx_cliente.Location = New System.Drawing.Point(180, 53)
        Me.tx_cliente.Name = "tx_cliente"
        Me.tx_cliente.Size = New System.Drawing.Size(100, 20)
        Me.tx_cliente.TabIndex = 3
        '
        'tx_Telefono
        '
        Me.tx_Telefono.Location = New System.Drawing.Point(180, 165)
        Me.tx_Telefono.Name = "tx_Telefono"
        Me.tx_Telefono.Size = New System.Drawing.Size(100, 20)
        Me.tx_Telefono.TabIndex = 4
        '
        'tx_correo
        '
        Me.tx_correo.Location = New System.Drawing.Point(180, 213)
        Me.tx_correo.Name = "tx_correo"
        Me.tx_correo.Size = New System.Drawing.Size(100, 20)
        Me.tx_correo.TabIndex = 5
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(92, 296)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 6
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_reiniciar
        '
        Me.btn_reiniciar.Location = New System.Drawing.Point(233, 295)
        Me.btn_reiniciar.Name = "btn_reiniciar"
        Me.btn_reiniciar.Size = New System.Drawing.Size(75, 23)
        Me.btn_reiniciar.TabIndex = 7
        Me.btn_reiniciar.Text = "Reiniciar"
        Me.btn_reiniciar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(357, 295)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 8
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'DG1
        '
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG1.Location = New System.Drawing.Point(357, 53)
        Me.DG1.Name = "DG1"
        Me.DG1.Size = New System.Drawing.Size(431, 191)
        Me.DG1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "IDCliente:"
        '
        'tx_idcliente
        '
        Me.tx_idcliente.Location = New System.Drawing.Point(180, 103)
        Me.tx_idcliente.Name = "tx_idcliente"
        Me.tx_idcliente.Size = New System.Drawing.Size(100, 20)
        Me.tx_idcliente.TabIndex = 11
        '
        'btn_vista
        '
        Me.btn_vista.Location = New System.Drawing.Point(512, 295)
        Me.btn_vista.Name = "btn_vista"
        Me.btn_vista.Size = New System.Drawing.Size(75, 23)
        Me.btn_vista.TabIndex = 12
        Me.btn_vista.Text = "Vista Previa"
        Me.btn_vista.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_vista)
        Me.Controls.Add(Me.tx_idcliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DG1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_reiniciar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.tx_correo)
        Me.Controls.Add(Me.tx_Telefono)
        Me.Controls.Add(Me.tx_cliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tx_cliente As TextBox
    Friend WithEvents tx_Telefono As TextBox
    Friend WithEvents tx_correo As TextBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_reiniciar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents DG1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents tx_idcliente As TextBox
    Friend WithEvents btn_vista As Button
End Class

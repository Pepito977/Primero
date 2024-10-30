<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificacionesToolStripMenuItem, Me.BuscadorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.VentasToolStripMenuItem})
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem1, Me.ProductosToolStripMenuItem1, Me.VentasToolStripMenuItem1})
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.BajaToolStripMenuItem.Text = "Baja"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'ProductosToolStripMenuItem1
        '
        Me.ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1"
        Me.ProductosToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ProductosToolStripMenuItem1.Text = "Productos"
        '
        'ModificacionesToolStripMenuItem
        '
        Me.ModificacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem2, Me.ProductosToolStripMenuItem2, Me.VentasToolStripMenuItem2})
        Me.ModificacionesToolStripMenuItem.Name = "ModificacionesToolStripMenuItem"
        Me.ModificacionesToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.ModificacionesToolStripMenuItem.Text = "Modificaciones"
        '
        'ClientesToolStripMenuItem2
        '
        Me.ClientesToolStripMenuItem2.Name = "ClientesToolStripMenuItem2"
        Me.ClientesToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem2.Text = "Clientes"
        '
        'ProductosToolStripMenuItem2
        '
        Me.ProductosToolStripMenuItem2.Name = "ProductosToolStripMenuItem2"
        Me.ProductosToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ProductosToolStripMenuItem2.Text = "Productos"
        '
        'BuscadorToolStripMenuItem
        '
        Me.BuscadorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem3, Me.ProductosToolStripMenuItem3, Me.VentasToolStripMenuItem3})
        Me.BuscadorToolStripMenuItem.Name = "BuscadorToolStripMenuItem"
        Me.BuscadorToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.BuscadorToolStripMenuItem.Text = "Buscador"
        '
        'ClientesToolStripMenuItem3
        '
        Me.ClientesToolStripMenuItem3.Name = "ClientesToolStripMenuItem3"
        Me.ClientesToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem3.Text = "Clientes"
        '
        'ProductosToolStripMenuItem3
        '
        Me.ProductosToolStripMenuItem3.Name = "ProductosToolStripMenuItem3"
        Me.ProductosToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ProductosToolStripMenuItem3.Text = "Productos"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.VentasToolStripMenuItem1.Text = "Ventas"
        '
        'VentasToolStripMenuItem3
        '
        Me.VentasToolStripMenuItem3.Name = "VentasToolStripMenuItem3"
        Me.VentasToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.VentasToolStripMenuItem3.Text = "Ventas"
        '
        'VentasToolStripMenuItem2
        '
        Me.VentasToolStripMenuItem2.Name = "VentasToolStripMenuItem2"
        Me.VentasToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.VentasToolStripMenuItem2.Text = "Ventas"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ModificacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents BuscadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem2 As ToolStripMenuItem
End Class

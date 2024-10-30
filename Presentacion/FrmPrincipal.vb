Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarMenuPrincipal()
    End Sub

    Private Sub ConfigurarMenuPrincipal()
        ' Configuración del menú principal
        Dim menuStrip As New MenuStrip()

        ' Menú Gestión
        Dim menuGestion As New ToolStripMenuItem("Gestión")
        menuGestion.DropDownItems.Add("Clientes", Nothing, AddressOf MostrarFormClientes)
        menuGestion.DropDownItems.Add("Productos", Nothing, AddressOf MostrarFormProductos)
        menuGestion.DropDownItems.Add("Ventas", Nothing, AddressOf MostrarFormVentas)

        ' Menú Reportes
        Dim menuReportes As New ToolStripMenuItem("Reportes")
        menuReportes.DropDownItems.Add("Reporte de Ventas", Nothing, AddressOf MostrarReporteVentas)
        menuReportes.DropDownItems.Add("Reporte de Productos", Nothing, AddressOf MostrarReporteProductos)

        menuStrip.Items.Add(menuGestion)
        menuStrip.Items.Add(menuReportes)

        Me.MainMenuStrip = menuStrip
        Me.Controls.Add(menuStrip)
    End Sub

    Private Sub MostrarFormClientes()
        Dim frmClientes As New FrmClientes()
        frmClientes.ShowDialog()
    End Sub

    ' ... Métodos similares para otros formularios
End Class
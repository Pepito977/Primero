Public Class FrmVentas
    Private ventaDAO As New VentaDAO()
    Private productoDAO As New ProductoDAO()
    Private clienteDAO As New ClienteDAO()

    Private ventaActual As Venta
    Private itemsVenta As New List(Of ItemVenta)

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarControles()
        IniciarNuevaVenta()
    End Sub

    Private Sub ConfigurarControles()
        ' Sección datos del cliente
        txtClienteDNI.MaxLength = 8

        ' DataGridView para items de venta
        dgvItems.AutoGenerateColumns = False
        dgvItems.Columns.Add("Codigo", "Código")
        dgvItems.Columns.Add("Descripcion", "Descripción")
        dgvItems.Columns.Add("Cantidad", "Cantidad")
        dgvItems.Columns.Add("PrecioUnitario", "Precio Unit.")
        dgvItems.Columns.Add("Subtotal", "Subtotal")

        ' Totales
        lblSubtotal.Text = "0.00"
        lblIGV.Text = "0.00"
        lblTotal.Text = "0.00"
    End Sub

    Private Sub IniciarNuevaVenta()
        ventaActual = New Venta()
        itemsVenta.Clear()
        dgvItems.DataSource = Nothing
        LimpiarTotales()
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Try
            Dim cliente = clienteDAO.BuscarPorDNI(txtClienteDNI.Text)
            If cliente IsNot Nothing Then
                ventaActual.Cliente = cliente
                txtClienteNombre.Text = cliente.Nombre
            Else
                MessageBox.Show("Cliente no encontrado")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar cliente: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarItem_Click(sender As Object, e As EventArgs) Handles btnAgregarItem.Click
        If ValidarItem() Then
            Dim item As New ItemVenta()
            item.Producto = productoActual
            item.Cantidad = Convert.ToDecimal(txtCantidad.Text)
            item.PrecioUnitario = productoActual.Precio

            itemsVenta.Add(item)
            ActualizarGrillaItems()
            CalcularTotales()
        End If
    End Sub

    Private Sub CalcularTotales()
        Dim subtotal As Decimal = itemsVenta.Sum(Function(i) i.Cantidad * i.PrecioUnitario)
        Dim igv As Decimal = subtotal * 0.18D
        Dim total As Decimal = subtotal + igv

        lblSubtotal.Text = subtotal.ToString("N2")
        lblIGV.Text = igv.ToString("N2")
        lblTotal.Text = total.ToString("N2")
    End Sub
End Class
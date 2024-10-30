Public Class FrmProductos
    Private productoDAO As New ProductoDAO()
    Private productoActual As Producto = Nothing

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarControles()
        CargarDatosProductos()
    End Sub

    Private Sub ConfigurarControles()
        ' DataGridView para lista de productos
        dgvProductos.AutoGenerateColumns = False
        dgvProductos.Columns.Add("Codigo", "Código")
        dgvProductos.Columns.Add("Nombre", "Nombre")
        dgvProductos.Columns.Add("Precio", "Precio")
        dgvProductos.Columns.Add("Stock", "Stock")

        ' Controles de búsqueda
        txtBusqueda.Width = 200
        cmbFiltro.Items.AddRange({"Código", "Nombre"})
        cmbFiltro.SelectedIndex = 0

        ' Validaciones
        txtPrecio.KeyPress += AddressOf SoloNumeros_KeyPress
        txtStock.KeyPress += AddressOf SoloNumeros_KeyPress
    End Sub

    Private Sub SoloNumeros_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim filtro As String = cmbFiltro.SelectedItem.ToString()
            Dim valor As String = txtBusqueda.Text.Trim()

            If String.IsNullOrEmpty(valor) Then
                CargarDatosProductos()
                Return
            End If

            Dim productos = productoDAO.Buscar(filtro, valor)
            dgvProductos.DataSource = productos
        Catch ex As Exception
            MessageBox.Show("Error al buscar productos: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidarDatos() Then
            Try
                Dim producto As New Producto()
                producto.Codigo = txtCodigo.Text
                producto.Nombre = txtNombre.Text
                producto.Descripcion = txtDescripcion.Text
                producto.Precio = Convert.ToDecimal(txtPrecio.Text)
                producto.Stock = Convert.ToInt32(txtStock.Text)

                If productoActual Is Nothing Then
                    productoDAO.Insertar(producto)
                    MessageBox.Show("Producto guardado exitosamente")
                Else
                    producto.IdProducto = productoActual.IdProducto
                    productoDAO.Actualizar(producto)
                    MessageBox.Show("Producto actualizado exitosamente")
                End If

                LimpiarFormulario()
                CargarDatosProductos()
            Catch ex As Exception
                MessageBox.Show("Error al guardar el producto: " & ex.Message)
            End Try
        End If
    End Sub
End Class
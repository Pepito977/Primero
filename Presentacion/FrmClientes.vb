Public Class FrmClientes
    Private clienteDAO As New ClienteDAO()
    Private clienteActual As Cliente = Nothing
    Private dgvClientes As Object
    Private txtBusqueda As Object
    Private cmbFiltro As Object
    Private btnNuevo As Object

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarControles()
        CargarDatosClientes()
    End Sub

    Private Sub ConfigurarControles()
        ' DataGridView para lista de clientes
        dgvClientes.AutoGenerateColumns = False
        dgvClientes.Columns.Add("DNI", "DNI")
        dgvClientes.Columns.Add("Nombre", "Nombre")
        dgvClientes.Columns.Add("Telefono", "Teléfono")
        dgvClientes.Columns.Add("Correo", "Correo")

        ' Controles de búsqueda
        Dim grpBusqueda As New GroupBox()
        grpBusqueda.Text = "Búsqueda"

        txtBusqueda.Width = 200
        cmbFiltro.Items.AddRange({"DNI", "Nombre"})
        cmbFiltro.SelectedIndex = 0

        ' Botones de acción
        btnNuevo.Text = "Nuevo"
        btnGuardar.Text = "Guardar"
        btnEliminar.Text = "Eliminar"
        btnLimpiar.Text = "Limpiar"
    End Sub

    Private Sub CargarDatosClientes()
        Try
            dgvClientes.DataSource = clienteDAO.ObtenerTodos()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los clientes: " & ex.Message)
        End Try
    End Sub
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidarDatos() Then
            Try
                Dim cliente As New Cliente()
                cliente.DNI = txtDNI.Text
                cliente.Nombre = txtNombre.Text
                cliente.Telefono = txtTelefono.Text
                cliente.Correo = txtCorreo.Text

                If clienteActual Is Nothing Then
                    clienteDAO.Insertar(cliente)
                    MessageBox.Show("Cliente guardado exitosamente")
                Else
                    cliente.IdCliente = clienteActual.IdCliente
                    clienteDAO.Actualizar(cliente)
                    MessageBox.Show("Cliente actualizado exitosamente")
                End If

                LimpiarFormulario()
                CargarDatosClientes()
            Catch ex As Exception
                MessageBox.Show("Error al guardar el cliente: " & ex.Message)
            End Try
        End If
    End Sub

    Private Function ValidarDatos() As Boolean
        If String.IsNullOrEmpty(txtDNI.Text) Then
            MessageBox.Show("El DNI es obligatorio")
            Return False
        End If

        If String.IsNullOrEmpty(txtNombre.Text) Then
            MessageBox.Show("El nombre es obligatorio")
            Return False
        End If

        Return True
    End Function
End Class
Imports System.Data.SqlClient

Public Class ProductoDAO
    Public Function Insertar(producto As Producto) As Boolean
        Using conn As SqlConnection = Conexion.ObtenerConexion()
            Dim cmd As New SqlCommand("INSERT INTO Productos (Codigo, Nombre, Descripcion, Precio, Stock) " &
                                    "VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @Stock)", conn)

            cmd.Parameters.AddWithValue("@Codigo", producto.Codigo)
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre)
            cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion)
            cmd.Parameters.AddWithValue("@Precio", producto.Precio)
            cmd.Parameters.AddWithValue("@Stock", producto.Stock)

            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function

    Public Function Actualizar(producto As Producto) As Boolean
        Using conn As SqlConnection = Conexion.ObtenerConexion()
            Dim cmd As New SqlCommand("UPDATE Productos SET Codigo = @Codigo, Nombre = @Nombre, " &
                                    "Descripcion = @Descripcion, Precio = @Precio, Stock = @Stock " &
                                    "WHERE IdProducto = @IdProducto", conn)

            cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto)
            cmd.Parameters.AddWithValue("@Codigo", producto.Codigo)
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre)
            cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion)
            cmd.Parameters.AddWithValue("@Precio", producto.Precio)
            cmd.Parameters.AddWithValue("@Stock", producto.Stock)

            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function

    Public Function Eliminar(idProducto As Integer) As Boolean
        Using conn As SqlConnection = Conexion.ObtenerConexion()
            Dim cmd As New SqlCommand("DELETE FROM Productos WHERE IdProducto = @IdProducto", conn)
            cmd.Parameters.AddWithValue("@IdProducto", idProducto)
            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function

    Public Function BuscarPorCodigo(codigo As String) As Producto
        Using conn As SqlConnection = Conexion.ObtenerConexion()
            Dim cmd As New SqlCommand("SELECT * FROM Productos WHERE Codigo = @Codigo", conn)
            cmd.Parameters.AddWithValue("@Codigo", codigo)

            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                Return CrearProductoDesdeReader(reader)
            End If
        End Using
        Return Nothing
    End Function

    Private Function CrearProductoDesdeReader(reader As SqlDataReader) As Producto
        Dim producto As New Producto()
        producto.IdProducto = Convert.ToInt32(reader("IdProducto"))
        producto.Codigo = reader("Codigo").ToString()
        producto.Nombre = reader("Nombre").ToString()
        producto.Descripcion = reader("Descripcion").ToString()
        producto.Precio = Convert.ToDecimal(reader("Precio"))
        producto.Stock = Convert.ToInt32(reader("Stock"))
        Return producto
    End Function
End Class
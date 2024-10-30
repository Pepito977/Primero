Imports System.Data.SqlClient

Public Class VentaDAO
    Public Function Insertar(venta As Venta) As Integer
        Using conn As SqlConnection = Conexion.ObtenerConexion()
            Using transaction As SqlTransaction = conn.BeginTransaction()
                Try
                    ' Insertar cabecera de venta
                    Dim cmdVenta As New SqlCommand("INSERT INTO Ventas (Fecha, IdCliente, Subtotal, IGV, Total) " &
                                                 "VALUES (@Fecha, @IdCliente, @Subtotal, @IGV, @Total); " &
                                                 "SELECT SCOPE_IDENTITY()", conn, transaction)

                    cmdVenta.Parameters.AddWithValue("@Fecha", venta.Fecha)
                    cmdVenta.Parameters.AddWithValue("@IdCliente", venta.Cliente.IdCliente)
                    cmdVenta.Parameters.AddWithValue("@Subtotal", venta.Subtotal)
                    cmdVenta.Parameters.AddWithValue("@IGV", venta.IGV)
                    cmdVenta.Parameters.AddWithValue("@Total", venta.Total)

                    Dim idVenta As Integer = Convert.ToInt32(cmdVenta.ExecuteScalar())

                    ' Insertar detalles de venta
                    For Each item In venta.Items
                        Dim cmdDetalle As New SqlCommand("INSERT INTO VentaDetalles (IdVenta, IdProducto, " &
                                                       "Cantidad, PrecioUnitario, Subtotal) VALUES " &
                                                       "(@IdVenta, @IdProducto, @Cantidad, @PrecioUnitario, @Subtotal)",
                                                       conn, transaction)

                        cmdDetalle.Parameters.AddWithValue("@IdVenta", idVenta)
                        cmdDetalle.Parameters.AddWithValue("@IdProducto", item.Producto.IdProducto)
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", item.Cantidad)
                        cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", item.PrecioUnitario)
                        cmdDetalle.Parameters.AddWithValue("@Subtotal", item.Subtotal)

                        cmdDetalle.ExecuteNonQuery()

                        ' Actualizar stock
                        ActualizarStock(item.Producto.IdProducto, item.Cantidad, conn, transaction)
                    Next

                    transaction.Commit()
                    Return idVenta

                Catch ex As Exception
                    transaction.Rollback()
                    Throw New Exception("Error al guardar la venta: " & ex.Message)
                End Try
            End Using
        End Using
    End Function

    Private Sub ActualizarStock(idProducto As Integer, cantidad As Decimal,
                              conn As SqlConnection, transaction As SqlTransaction)
        Dim cmd As New SqlCommand("UPDATE Productos SET Stock = Stock - @Cantidad " &
                                "WHERE IdProducto = @IdProducto", conn, transaction)

        cmd.Parameters.AddWithValue("@IdProducto", idProducto)
        cmd.Parameters.AddWithValue("@Cantidad", cantidad)
        cmd.ExecuteNonQuery()
    End Sub
End Class
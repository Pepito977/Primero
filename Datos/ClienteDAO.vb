Imports System.Data.SqlClient

Public Class ClienteDAO
    Public Function Insertar(cliente As Cliente) As Boolean
        Using conn As SqlConnection = Conexion.ObtenerConexion()
            Dim cmd As New SqlCommand("INSERT INTO Clientes (DNI, Nombre, Telefono, Correo) VALUES (@DNI, @Nombre, @Telefono, @Correo)", conn)

            cmd.Parameters.AddWithValue("@DNI", cliente.DNI)
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre)
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono)
            cmd.Parameters.AddWithValue("@Correo", cliente.Correo)

            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function

    Public Function ObtenerTodos() As List(Of Cliente)
        Dim clientes As New List(Of Cliente)
        Using conn As SqlConnection = Conexion.ObtenerConexion()
            Dim cmd As New SqlCommand("SELECT * FROM Clientes", conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim cliente As New Cliente()
                cliente.IdCliente = Convert.ToInt32(reader("IdCliente"))
                cliente.DNI = reader("DNI").ToString()
                cliente.Nombre = reader("Nombre").ToString()
                cliente.Telefono = reader("Telefono").ToString()
                cliente.Correo = reader("Correo").ToString()
                clientes.Add(cliente)
            End While
        End Using
        Return clientes
    End Function
End Class
Imports System.Configuration
Imports System.Data.SqlClient

Public Class Conexion
    Private Shared _cadenaConexion As String = ConfigurationManager.ConnectionStrings("ConexionDB").ConnectionString
    Public Shared Property ConfigurationManager As Object

    Public Shared Function ObtenerConexion() As SqlConnection
        Dim conexion As New SqlConnection(_cadenaConexion)
        Try
            conexion.Open()
            Return conexion
        Catch ex As Exception
            Throw New Exception("Error al conectar con la base de datos: " & ex.Message)
        End Try
    End Function
End Class
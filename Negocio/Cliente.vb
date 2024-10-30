Public Class Cliente
    Public Property IdCliente As Integer
    Public Property DNI As String
    Public Property Nombre As String
    Public Property Telefono As String
    Public Property Correo As String

    Public Sub New()
    End Sub

    Public Sub New(dni As String, nombre As String, telefono As String, correo As String)
        Me.DNI = dni
        Me.Nombre = nombre
        Me.Telefono = telefono
        Me.Correo = correo
    End Sub

    Public Function ValidarDatos() As Boolean
        If String.IsNullOrEmpty(DNI) OrElse String.IsNullOrEmpty(Nombre) Then
            Return False
        End If
        Return True
    End Function
End Class
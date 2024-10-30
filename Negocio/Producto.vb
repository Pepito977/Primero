Public Class Producto
    Public Property IdProducto As Integer
    Public Property Codigo As String
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Precio As Decimal
    Public Property Stock As Integer

    Public Sub New()
    End Sub

    Public Sub New(codigo As String, nombre As String, precio As Decimal)
        Me.Codigo = codigo
        Me.Nombre = nombre
        Me.Precio = precio
    End Sub

    Public Function ValidarDatos() As Boolean
        If String.IsNullOrEmpty(Codigo) OrElse String.IsNullOrEmpty(Nombre) OrElse Precio <= 0 Then
            Return False
        End If
        Return True
    End Function
End Class
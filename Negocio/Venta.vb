Public Class Venta
    Public Property IdVenta As Integer
    Public Property Fecha As DateTime
    Public Property Cliente As Cliente
    Public Property Items As List(Of ItemVenta)
    Public Property Subtotal As Decimal
    Public Property IGV As Decimal
    Public Property Total As Decimal

    Public Sub New()
        Fecha = DateTime.Now
        Items = New List(Of ItemVenta)
    End Sub

    Public Sub CalcularTotales()
        Subtotal = Items.Sum(Function(i) i.Subtotal)
        IGV = Subtotal * 0.18D
        Total = Subtotal + IGV
    End Sub
End Class

Public Class ItemVenta
    Public Property IdItem As Integer
    Public Property Producto As Producto
    Public Property Cantidad As Decimal
    Public Property PrecioUnitario As Decimal

    Public ReadOnly Property Subtotal As Decimal
        Get
            Return Cantidad * PrecioUnitario
        End Get
    End Property

    Friend Function Producto() As Object
        Throw New NotImplementedException()
    End Function

    Friend Function Cantidad() As Decimal
        Throw New NotImplementedException()
    End Function

    Friend Function Subtotal() As Integer
        Throw New NotImplementedException()
    End Function
End Class
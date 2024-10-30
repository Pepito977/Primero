Public Class ItemVenta
    ' Propiedades principales
    Public Property IdItemVenta As Integer
    Public Property IdVenta As Integer
    Public Property Producto As Producto
    Public Property Cantidad As Decimal
    Public Property PrecioUnitario As Decimal
    Public Property Descuento As Decimal
    Public Property Estado As Boolean

    ' Propiedades calculadas
    Public ReadOnly Property Subtotal As Decimal
        Get
            Return (Cantidad * PrecioUnitario) - Descuento
        End Get
    End Property

    Public ReadOnly Property SubtotalSinDescuento As Decimal
        Get
            Return Cantidad * PrecioUnitario
        End Get
    End Property

    ' Constructor vacío
    Public Sub New()
        Estado = True
        Descuento = 0
    End Sub

    ' Constructor con parámetros básicos
    Public Sub New(producto As Producto, cantidad As Decimal, precioUnitario As Decimal)
        Me.Producto = producto
        Me.Cantidad = cantidad
        Me.PrecioUnitario = precioUnitario
        Me.Estado = True
        Me.Descuento = 0
    End Sub

    ' Constructor completo
    Public Sub New(producto As Producto, cantidad As Decimal, precioUnitario As Decimal, descuento As Decimal)
        Me.Producto = producto
        Me.Cantidad = cantidad
        Me.PrecioUnitario = precioUnitario
        Me.Descuento = descuento
        Me.Estado = True
    End Sub

    ' Métodos de validación
    Public Function ValidarItem() As Boolean
        If Producto Is Nothing Then
            Throw New Exception("El producto es requerido")
        End If

        If Cantidad <= 0 Then
            Throw New Exception("La cantidad debe ser mayor a 0")
        End If

        If PrecioUnitario <= 0 Then
            Throw New Exception("El precio unitario debe ser mayor a 0")
        End If

        If Descuento < 0 Then
            Throw New Exception("El descuento no puede ser negativo")
        End If

        If Descuento > SubtotalSinDescuento Then
            Throw New Exception("El descuento no puede ser mayor al subtotal")
        End If

        Return True
    End Function

    ' Métodos para modificar el item
    Public Sub AplicarDescuento(montoDescuento As Decimal)
        If montoDescuento < 0 Then
            Throw New Exception("El descuento no puede ser negativo")
        End If

        If montoDescuento > SubtotalSinDescuento Then
            Throw New Exception("El descuento no puede ser mayor al subtotal")
        End If

        Me.Descuento = montoDescuento
    End Sub

    Public Sub ModificarCantidad(nuevaCantidad As Decimal)
        If nuevaCantidad <= 0 Then
            Throw New Exception("La cantidad debe ser mayor a 0")
        End If

        ' Verificar si hay suficiente stock
        If Producto IsNot Nothing AndAlso nuevaCantidad > Producto.Stock Then
            Throw New Exception("No hay suficiente stock disponible")
        End If

        Me.Cantidad = nuevaCantidad
    End Sub

    Public Sub ActualizarPrecioUnitario(nuevoPrecio As Decimal)
        If nuevoPrecio <= 0 Then
            Throw New Exception("El precio unitario debe ser mayor a 0")
        End If

        Me.PrecioUnitario = nuevoPrecio
    End Sub

    ' Método para clonar el item
    Public Function Clonar() As ItemVenta
        Return New ItemVenta With {
            .IdItemVenta = Me.IdItemVenta,
            .IdVenta = Me.IdVenta,
            .Producto = Me.Producto,
            .Cantidad = Me.Cantidad,
            .PrecioUnitario = Me.PrecioUnitario,
            .Descuento = Me.Descuento,
            .Estado = Me.Estado
        }
    End Function

    ' Método para convertir a string (útil para debugging)
    Public Overrides Function ToString() As String
        Return String.Format(
            "Producto: {0}, Cantidad: {1}, Precio: {2}, Subtotal: {3}, Descuento: {4}",
            If(Producto IsNot Nothing, Producto.Nombre, "Sin producto"),
            Cantidad,
            PrecioUnitario,
            Subtotal,
            Descuento
        )
    End Function
End Class
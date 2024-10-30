Public Class FrmReportes
    Private ventaDAO As New VentaDAO()

    Private Sub FrmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarControles()
    End Sub

    Private Sub ConfigurarControles()
        ' Configurar fechas
        dtpFechaDesde.Value = DateTime.Now.AddDays(-30)
        dtpFechaHasta.Value = DateTime.Now

        ' Configurar tipo de reporte
        cmbTipoReporte.Items.AddRange({"Ventas por Cliente", "Productos Vendidos"})
        cmbTipoReporte.SelectedIndex = 0

        ' Configurar grilla
        ConfigurarGrillaSegunReporte()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try
            Select Case cmbTipoReporte.SelectedIndex
                Case 0 ' Ventas por Cliente
                    GenerarReporteVentas()
                Case 1 ' Productos Vendidos
                    GenerarReporteProductos()
            End Select
        Catch ex As Exception
            MessageBox.Show("Error al generar reporte: " & ex.Message)
        End Try
    End Sub

    Private Sub GenerarReporteVentas()
        Dim fechaDesde As DateTime = dtpFechaDesde.Value.Date
        Dim fechaHasta As DateTime = dtpFechaHasta.Value.Date.AddDays(1).AddSeconds(-1)

        Dim ventas = ventaDAO.ObtenerVentasPorFecha(fechaDesde, fechaHasta)
        dgvReporte.DataSource = ventas
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        If dgvReporte.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para exportar")
            Return
        End If

        Try
            ExportarAExcel()
        Catch ex As Exception
            MessageBox.Show("Error al exportar: " & ex.Message)
        End Try
    End Sub

    Private Sub ExportarAExcel()
        ' Implementar exportación a Excel
        ' Usar Microsoft.Office.Interop.Excel o alguna librería de terceros
    End Sub
End Class
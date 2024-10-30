Imports System.Data.SqlClient.SqlConnection
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class Form1
    Dim conClientes As String
    Dim conn As New SqlConnection
    Dim cmd As New SqlCommand()
    Dim dtClientes As New DataTable
    Dim sql As String
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet()
    Dim cmbl As New SqlCommandBuilder

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer = 0
        Me.Text = "DataGrid1"
        DG1.RowHeadersWidth = 20
        DG1.AllowUserToAddRows = False
        DG1.ColumnCount = 4
        DG1.Columns.Item(0).HeaderText = "Id Cliente"
        DG1.Columns.Item(0).Name = "nid"
        DG1.Columns.Item(0).Width = 30
        DG1.Columns.Item(1).HeaderText = "Dni"
        DG1.Columns.Item(1).Name = "ndni"
        DG1.Columns.Item(1).Width = 60
        DG1.Columns.Item(2).HeaderText = "Nombre"
        DG1.Columns.Item(2).Name = "nnombre"
        DG1.Columns.Item(2).Width = 220
        DG1.Columns.Item(3).HeaderText = "Telefono"
        DG1.Columns.Item(3).Width = 248
        DG1.Columns.Item(3).Name = "ntelefono"
        DG1.Columns.Item(4).HeaderText = "Correo"
        DG1.Columns.Item(4).Width = 248
        DG1.Columns.Item(4).Name = "ncorreo"
        DG1.Columns.Item(4).SortMode = True
        Me.ActiveControl = tx_cliente
        btn_guardar.Enabled = False

        Dim conClientes As String = 'Server=localhost;Uid=sa;Pwd=sasa;MultipleActiveResultSets=True;Timeout=120;Database = pruebademo;'


        Dim Sql As String = "SELECT * FROM Clientes"
        Dim conn As New SqlClient.SqlConnection()
        Dim cmd As New SqlClient.SqlCommand()
        Dim da As New SqlClient.SqlDataAdapter()
        Dim ds As New DataSet()
        Dim dtClientes As New DataTable()

        Try
            conn = New SqlClient.SqlConnection(conClientes)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = Sql
            da = New SqlClient.SqlDataAdapter(cmd)
            da.Fill(ds)
            dtClientes = ds.Tables(0)
            DG1.DataSource = dtClientes
            ds.Tables(0).TableName = "dtClientes"
        Catch ex As Exception
            MsgBox("Error de conexión: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Me.Text = "Alta Clientes"
        tx_Telefono.MaxLength = 15 ' Ajusta según el formato que necesites
        tx_correo.MaxLength = 50 ' Ajusta según el formato que necesites
        tx_cliente.MaxLength = 50 ' Ajusta según el formato que necesites
        tx_idcliente.MaxLength = 50
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim res, xfila As Integer
        If tx_cliente.Text = "" Or tx_idcliente.Text = "" Or tx_Telefono.Text = "" Or tx_correo.Text = "" Then
            MsgBox("Faltan ingresar datos", 16, "mensaje")
            Exit Sub
        End If
        If Len(tx_idcliente.Text) <> 8 Then
            MsgBox("El numero de DNI debe tener 8 digitos!")
            Exit Sub
        End If
        If DG1.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DG1.Rows
                If Not Fila Is Nothing Then
                    If Fila.Cells("ndni").Value = tx_idcliente.Text Then
                        MsgBox("Dni registrado" & Chr(13) & "Corrija el error...")
                        Exit Sub
                    End If
                End If
            Next
        End If
        res = MsgBox("Confirma?", 4, "Mensaje")
        If res = 6 Then
            xfila = DG1.Rows.Count
            DG1.Rows.Add(xfila + 1, tx_idcliente.Text, tx_cliente.Text, tx_Telefono.Text, tx_correo)
            tx_idcliente.Text = ""
            tx_cliente.Text = ""
            tx_Telefono.Text = ""
            tx_correo.Text = ""
            Me.ActiveControl = tx_idcliente
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_reiniciar.Click
        borrar()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        conn.Close()
        Me.Close()

    End Sub
    Function validar() As Boolean
        If tx_cliente.Text = "" Or tx_Telefono.Text = "" Or tx_correo.Text = "" Then
            Return True
        End If
        Return False
    End Function
    Function grabarTabla() As Boolean
        If ds Is Nothing OrElse ds.Tables.Count = 0 Then
            MsgBox("No hay tablas en el DataSet.")
            Return False
        End If

        Dim dt As DataTable = ds.Tables(0)
        Dim f As Integer = dt.Rows.Count()

        For Each row As DataRow In dt.Rows
            If row.Item("ColumnName1").ToString() = tx_cliente.Text Then
                MsgBox("Usuario registrado, ingrese otro.")
                Return False
            End If
        Next

        Dim newRow As DataRow = dt.NewRow()
        newRow("ColumnName1") = tx_cliente.Text
        newRow("ColumnName2") = tx_Telefono.Text
        newRow("ColumnName3") = tx_idcliente.Text
        newRow("ColumnName3") = True
        dt.Rows.Add(newRow)

        cmbl = New SqlClient.SqlCommandBuilder(da)
        da.Update(ds, "dtusuarios")
        Return True
    End Function
    Sub borrar()
        tx_cliente.Text = ""
        tx_Telefono.Text = ""
        tx_correo.Text = ""
    End Sub

    Private Sub tx_cliente_Validating(sender As Object, e As CancelEventArgs) Handles tx_cliente.Validating
        tx_cliente.Text = tx_cliente.Text.ToUpper

    End Sub

    Private Sub tx_correo_Validating(sender As Object, e As CancelEventArgs) Handles tx_correo.Validating
        If String.IsNullOrWhiteSpace(tx_correo.Text) OrElse Not tx_correo.Text.Contains("@") Then
            MsgBox("Por favor, ingrese un correo electrónico válido.")
            e.Cancel = True ' Evita que el foco cambie
        End If
    End Sub

    Private Sub tx_Telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tx_Telefono.KeyPress
        ' Permitir solo números y teclas de control
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Evita que el carácter no deseado se ingrese
        End If
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG1.CellContentClick

    End Sub

    Private Sub btn_vista_Click(sender As Object, e As EventArgs) Handles btn_vista.Click
        Me.PrintPreviewDialog1.Document = PrintDocument1
        Me.PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Function PrintDocument1() As Object
        Throw New NotImplementedException()
    End Function

    Private Function PrintPreviewDialog1() As Object
        Throw New NotImplementedException()
    End Function
End Class
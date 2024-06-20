Public Class ELIMINARCLIENTE
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TXTNOMBRE.BackColor = Drawing.Color.DarkGray
        Me.TXTCORREO.BackColor = Drawing.Color.DarkGray
        Me.TXTDIRECCION.BackColor = Drawing.Color.DarkGray
        Me.TXTTELEFONO.BackColor = Drawing.Color.DarkGray

        Me.TXTTIPO.BackColor = Drawing.Color.DarkGray
        Me.TXTCODIGO.BackColor = Drawing.Color.DarkGray
    End Sub

    Protected Sub BTNACTUALIZAR_Click(sender As Object, e As ImageClickEventArgs) Handles BTNELIMINAR.Click
        Dim SI As Byte
        SI = MsgBox("REALMENTE ESTAS SEGURO DE ELIMINAR", MsgBoxStyle.YesNo, "ADVERTENCIA")
        If SI = vbYes Then
            Me.SqlDataSource1.Delete()
            INHABILITAR()
            LIMPIAR()
        Else
            INHABILITAR()
            LIMPIAR()
        End If

    End Sub
    Private Sub HABILITAR()

        Me.BTNELIMINAR.Enabled = True
        Me.BTNCANCELAR.Enabled = True

    End Sub
    Private Sub LIMPIAR()
        Me.TXTNOMBRE.Text = ""
        Me.TXTCORREO.Text = ""
        Me.TXTDIRECCION.Text = ""
        Me.TXTTELEFONO.Text = ""

        Me.TXTTIPO.Text = ""
        Me.TXTCODIGO.Text = ""
    End Sub
    Private Sub INHABILITAR()

        Me.BTNELIMINAR.Enabled = False
        Me.BTNCANCELAR.Enabled = False

    End Sub
    Protected Sub BTNVALIDAR_Click(sender As Object, e As EventArgs) Handles BTNVALIDAR.Click
        Dim DATOS As New GridView
        DATOS.DataSource = Me.SqlDataSource1
        DATOS.DataBind()

        If DATOS.Rows.Count > 0 Then

            Me.TXTNOMBRE.Text = DATOS.Rows(0).Cells(1).Text
            Me.TXTTIPO.Text = DATOS.Rows(0).Cells(2).Text
            Me.TXTTELEFONO.Text = DATOS.Rows(0).Cells(3).Text
            Me.TXTDIRECCION.Text = DATOS.Rows(0).Cells(4).Text
            Me.TXTCORREO.Text = DATOS.Rows(0).Cells(5).Text
            HABILITAR()
        Else
            MsgBox("EL CLIENTE NO EXISTE", MsgBoxStyle.Critical, "ERROR")
            INHABILITAR()
            LIMPIAR()
        End If
    End Sub
End Class
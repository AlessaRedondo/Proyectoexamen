Public Class ACTUALIZARHABITACION
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Private Sub HABILITAR()
        Me.TXTNUMERO.ReadOnly = False
        Me.TXTUBICACION.ReadOnly = False
        Me.TXTDETALLE.ReadOnly = False
        Me.TXTPRECIO.ReadOnly = False


        Me.TXTCODIGO.ReadOnly = True
        Me.BTNVALIDAR.Enabled = False

        ''

        Me.BTNACTUALIZAR.Enabled = True
        Me.BTNCANCELAR.Enabled = True

    End Sub
    Private Sub LIMPIAR()
        Me.TXTNUMERO.Text = ""
        Me.TXTUBICACION.Text = ""
        Me.TXTDETALLE.Text = ""
        Me.TXTPRECIO.Text = ""
        Me.TXTCODIGO.Text = ""
    End Sub
    Private Sub INHABILITAR()
        Me.TXTNUMERO.ReadOnly = True
        Me.TXTUBICACION.ReadOnly = True
        Me.TXTDETALLE.ReadOnly = True
        Me.TXTPRECIO.ReadOnly = True
        Me.TXTCODIGO.ReadOnly = False
        Me.BTNVALIDAR.Enabled = True

        ''

        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNCANCELAR.Enabled = False
    End Sub
    Protected Sub BTNVALIDAR_Click(sender As Object, e As EventArgs) Handles BTNVALIDAR.Click
        Dim DATOS As New GridView
        DATOS.DataSource = Me.SqlDataSource1
        DATOS.DataBind()

        If DATOS.Rows.Count > 0 Then
            Me.TXTNUMERO.Text = DATOS.Rows(0).Cells(1).Text
            Me.TXTUBICACION.Text = DATOS.Rows(0).Cells(2).Text
            Me.TXTDETALLE.Text = DATOS.Rows(0).Cells(3).Text
            Me.TXTPRECIO.Text = DATOS.Rows(0).Cells(4).Text
            Me.LTAPAR.Text = DATOS.Rows(0).Cells(5).Text
            Me.LTESTADO.Text = DATOS.Rows(0).Cells(5).Text

            HABILITAR()
        Else
            MsgBox("HABITACION NO EXISTE", MsgBoxStyle.Critical, "ERROR")
            INHABILITAR()
            LIMPIAR()
        End If
    End Sub


    Protected Sub BTNGUARDAR_Click(sender As Object, e As ImageClickEventArgs) Handles BTNACTUALIZAR.Click
        Me.SqlDataSource1.Update()
        MsgBox("HABITACION ACTUALIZADA", MsgBoxStyle.Information, "EXITO")
        INHABILITAR()
        LIMPIAR()

    End Sub

    Protected Sub BTNCANCELAR_Click(sender As Object, e As ImageClickEventArgs) Handles BTNCANCELAR.Click
        INHABILITAR()
        LIMPIAR()
    End Sub
End Class
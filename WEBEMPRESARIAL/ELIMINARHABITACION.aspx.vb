Public Class ELIMINARHABITACION
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Private Sub HABILITAR()


        Me.BTNELIMINAR.Enabled = True
        Me.BTNCANCELAR.Enabled = True

    End Sub
    Private Sub LIMPIAR()
        Me.TXTNUMERO.Text = ""
        Me.TXTUBICACION.Text = ""
        Me.TXTDETALLE.Text = ""
        Me.TXTPRECIO.Text = ""
        Me.LTAPAR.Text = ""
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
            Me.TXTNUMERO.Text = DATOS.Rows(0).Cells(1).Text
            Me.TXTUBICACION.Text = DATOS.Rows(0).Cells(2).Text
            Me.TXTDETALLE.Text = DATOS.Rows(0).Cells(3).Text
            Me.TXTPRECIO.Text = DATOS.Rows(0).Cells(4).Text
            Me.LTAPAR.Text = DATOS.Rows(0).Cells(5).Text

            HABILITAR()
        Else
            MsgBox("HABITACION NO EXISTE", MsgBoxStyle.Critical, "ERROR")
            INHABILITAR()
            LIMPIAR()
        End If
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


    Protected Sub BTNCANCELAR_Click(sender As Object, e As ImageClickEventArgs) Handles BTNCANCELAR.Click
        INHABILITAR()
        LIMPIAR()
    End Sub
End Class
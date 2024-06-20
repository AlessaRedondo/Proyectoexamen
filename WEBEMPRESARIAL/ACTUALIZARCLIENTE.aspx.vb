Public Class ACTUALIZARCLIENTE
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Private Sub LIMPIAR()
        Me.TXTNOMBRE.Text = ""
        Me.TXTDIRECCION.Text = ""
        Me.TXTCORREO.Text = ""
        Me.TXTTELEFONO.Text = ""

        Me.TXTCODIGO.Text = ""

    End Sub
    Private Sub HABILITAR()
        Me.TXTNOMBRE.ReadOnly = False
        Me.TXTDIRECCION.ReadOnly = False
        Me.TXTCORREO.ReadOnly = False
        Me.TXTTELEFONO.ReadOnly = False

        Me.BTNACTUALIZAR.Enabled = True
        Me.BTNCANCELAR.Enabled = True

        Me.TXTCODIGO.ReadOnly = True
        Me.BTNVALIDAR.Enabled = False


    End Sub
    Private Sub INHABILITAR()
        Me.TXTNOMBRE.ReadOnly = True
        Me.TXTDIRECCION.ReadOnly = True
        Me.TXTCORREO.ReadOnly = True
        Me.TXTTELEFONO.ReadOnly = True

        ''

        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNCANCELAR.Enabled = False

        Me.TXTCODIGO.ReadOnly = False
        Me.BTNVALIDAR.Enabled = True

    End Sub
    Protected Sub BTNVALIDAR_Click(sender As Object, e As EventArgs) Handles BTNVALIDAR.Click
        Dim DATOS As New GridView
        DATOS.DataSource = Me.SqlDataSource3
        DATOS.DataBind()

        If DATOS.Rows.Count > 0 Then
            Me.TXTNOMBRE.Text = DATOS.Rows(0).Cells(1).Text
            Me.TXTTIPO.Text = DATOS.Rows(0).Cells(2).Text
            Me.TXTTELEFONO.Text = DATOS.Rows(0).Cells(3).Text
            Me.TXTDIRECCION.Text = DATOS.Rows(0).Cells(4).Text
            Me.TXTCORREO.Text = DATOS.Rows(0).Cells(5).Text



            HABILITAR()
        Else
            MsgBox("CLIENTE NO EXISTE", MsgBoxStyle.Critical, "ERROR")
            INHABILITAR()
            LIMPIAR()
        End If
    End Sub

    Protected Sub BTNACTUALIZAR_Click(sender As Object, e As ImageClickEventArgs) Handles BTNACTUALIZAR.Click
        Me.SqlDataSource3.Update()
        MsgBox("CLIENTE ACTUALIZADO CON EXITO", MsgBoxStyle.Information, "EXITO")
        INHABILITAR()
        LIMPIAR()
    End Sub

    Protected Sub BTNCANCELAR_Click(sender As Object, e As ImageClickEventArgs) Handles BTNCANCELAR.Click
        INHABILITAR()
        LIMPIAR()
    End Sub
End Class
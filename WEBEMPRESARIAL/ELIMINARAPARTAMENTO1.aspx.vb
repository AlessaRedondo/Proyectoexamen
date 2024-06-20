Public Class ELIMINARAPARTAMENTO1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TXTNUMERO.BackColor = Drawing.Color.DarkGray
        Me.TXTPISO.BackColor = Drawing.Color.DarkGray
        Me.TXTPRECIO.BackColor = Drawing.Color.DarkGray
        Me.TXTTIPO.BackColor = Drawing.Color.DarkGray
        Me.LTESTADO.BackColor = Drawing.Color.DarkGray
        Me.TXTCODIGO.BackColor = Drawing.Color.DarkGray
    End Sub
    Private Sub HABILITAR()


        Me.BTNGUARDAR.Enabled = True
        Me.BTNCANCELAR.Enabled = True

    End Sub
    Private Sub LIMPIAR()
        Me.TXTNUMERO.Text = ""
        Me.TXTPISO.Text = ""
        Me.TXTPRECIO.Text = ""
        Me.TXTTIPO.Text = ""
        Me.TXTCODIGO.Text = ""
    End Sub
    Private Sub INHABILITAR()


        Me.BTNGUARDAR.Enabled = False
        Me.BTNCANCELAR.Enabled = False

    End Sub
    Protected Sub BTNVALIDAR_Click(sender As Object, e As EventArgs) Handles BTNVALIDAR.Click
        Dim DATOS As New GridView
        DATOS.DataSource = Me.SqlDataSource1
        DATOS.DataBind()

        If DATOS.Rows.Count > 0 Then
            Me.TXTNUMERO.Text = DATOS.Rows(0).Cells(1).Text
            Me.TXTPISO.Text = DATOS.Rows(0).Cells(2).Text
            Me.TXTPRECIO.Text = DATOS.Rows(0).Cells(3).Text
            Me.LTESTADO.Text = DATOS.Rows(0).Cells(4).Text
            Me.TXTTIPO.Text = DATOS.Rows(0).Cells(5).Text

            HABILITAR()
        Else
            MsgBox("EL APARTAMENTO NO EXISTE", MsgBoxStyle.Critical, "ERROR")
            INHABILITAR()
            LIMPIAR()
        End If
    End Sub

    Protected Sub BTNGUARDAR_Click(sender As Object, e As ImageClickEventArgs) Handles BTNGUARDAR.Click
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
End Class
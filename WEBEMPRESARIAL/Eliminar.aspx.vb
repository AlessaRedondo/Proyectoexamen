Public Class Eliminar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TXTNOMBRE.BackColor = Drawing.Color.DarkGray
        Me.TXTCORREO.BackColor = Drawing.Color.DarkGray
        Me.TXTDIRECCION.BackColor = Drawing.Color.DarkGray
        Me.TXTTELEFONO.BackColor = Drawing.Color.DarkGray
        Me.TXTUSUARIO.BackColor = Drawing.Color.DarkGray
        Me.TXTCONTRA.BackColor = Drawing.Color.DarkGray

    End Sub
    Private Sub LIMPIAR()
        Me.TXTNOMBRE.Text = ""
        Me.TXTDIRECCION.Text = ""
        Me.TXTCORREO.Text = ""
        Me.TXTTELEFONO.Text = ""
        Me.TXTUSUARIO.Text = ""
        Me.TXTCONTRA.Text = ""
        Me.TXTCODIGO.Text = ""

    End Sub
    Private Sub HABILITAR()

        Me.BTNELIMINAR.Enabled = True
        Me.BTNCANCELAR.Enabled = True




    End Sub
    Private Sub INHABILITAR()

        Me.CHEACTIVO.Enabled = False
        Me.TXTCODIGO.ReadOnly = False
        Me.BTNVALIDAR.Enabled = True

    End Sub
    Protected Sub BTNVALIDAR_Click(sender As Object, e As EventArgs) Handles BTNVALIDAR.Click
        Dim DATOS As New GridView
        DATOS.DataSource = Me.SqlDataSource3
        DATOS.DataBind()

        If DATOS.Rows.Count > 0 Then
            Me.TXTNOMBRE.Text = DATOS.Rows(0).Cells(1).Text
            Me.TXTTELEFONO.Text = DATOS.Rows(0).Cells(2).Text
            Me.TXTCORREO.Text = DATOS.Rows(0).Cells(3).Text
            Me.TXTDIRECCION.Text = DATOS.Rows(0).Cells(4).Text
            Me.TXTUSUARIO.Text = DATOS.Rows(0).Cells(5).Text
            Me.TXTCONTRA.Text = DATOS.Rows(0).Cells(6).Text
            Session("CUENTA") = DATOS.Rows(0).Cells(7).Text
            If Session("CUENTA") = "1" Then
                Me.CHEACTIVO.Checked = True
            Else
                Me.CHEACTIVO.Checked = False
            End If
            HABILITAR()
        Else
            MsgBox("EMPLEADO NO EXISTE", MsgBoxStyle.Critical, "ERROR")
            INHABILITAR()
            LIMPIAR()
        End If

    End Sub

    Protected Sub BTNELIMINAR_Click(sender As Object, e As ImageClickEventArgs) Handles BTNELIMINAR.Click
        Dim SI As Byte
        SI = MsgBox("REALMENTE ESTAS SEGURO DE ELIMINAR ", MsgBoxStyle.YesNo, "ADVERTENCIA")
        If SI = vbYes Then
            Me.SqlDataSource3.Delete()
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
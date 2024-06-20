Public Class ACTUALIZAR
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
        Me.TXTNOMBRE.ReadOnly = False
        Me.TXTDIRECCION.ReadOnly = False
        Me.TXTCORREO.ReadOnly = False
        Me.TXTTELEFONO.ReadOnly = False
        Me.TXTUSUARIO.ReadOnly = False
        Me.TXTCONTRA.ReadOnly = False
        ''
        Me.CHEACTIVO.Enabled = True
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
        Me.TXTUSUARIO.ReadOnly = True
        Me.TXTCONTRA.ReadOnly = True
        ''
        Me.CHEACTIVO.Enabled = False
        Me.BTNACTUALIZAR.Enabled = False
        Me.BTNCANCELAR.Enabled = False

        Me.TXTCODIGO.ReadOnly = False
        Me.BTNVALIDAR.Enabled = True

    End Sub
    Protected Sub BTNVALIDAR_Click(sender As Object, e As EventArgs) Handles BTNVALIDAR.Click
        Dim DATOS As New GridView
        DATOS.DataSource = Me.SqlDataSource2
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

    Protected Sub BTNCANCELAR_Click(sender As Object, e As ImageClickEventArgs) Handles BTNCANCELAR.Click
        INHABILITAR()
        LIMPIAR()
    End Sub

    Protected Sub BTNACTUALIZAR_Click(sender As Object, e As ImageClickEventArgs) Handles BTNACTUALIZAR.Click

        If CHEACTIVO.Checked = True Then
            Session("ACTIVA") = "1"
        Else
            Session("ACTIVA ") = "0"

        End If
        Me.SqlDataSource2.Update()
        MsgBox("EMPLEADO ACTUALIZADO CON EXITO", MsgBoxStyle.Information, "EXITO")
        INHABILITAR()
        LIMPIAR()
    End Sub
End Class

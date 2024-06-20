﻿Public Class AGREGARUSUARIO
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BTNVALIDAR_Click(sender As Object, e As EventArgs) Handles BTNVALIDAR.Click
        Dim DATOS As New GridView
        DATOS.DataSource = Me.SqlDataSource1
        DATOS.DataBind()
        If Me.TXTCODIGO.Text = "" Then
            MsgBox("CAMPO REQUERIDO", MsgBoxStyle.Information, "ADVERTENCIA")
            Me.TXTCODIGO.Focus()
        Else
            If DATOS.Rows.Count > 0 Then
                MsgBox(" ESTE EMPLEADO EXISTE", MsgBoxStyle.Critical, " ERROR")
                INHABILITAR()
                LIMPIAR()
            Else
                HABILITAR()
            End If
        End If
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
        Me.BTNGUARDAR.Enabled = True
        Me.BTNCANCELAR.Enabled = True
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
        Me.BTNGUARDAR.Enabled = False
        Me.BTNCANCELAR.Enabled = False

    End Sub

    Protected Sub BTNGUARDAR_Click(sender As Object, e As ImageClickEventArgs) Handles BTNGUARDAR.Click
        If CHEACTIVO.Checked = True Then
            Session("ACTIVO") = "1"
        Else
            Session("ACTIVO ") = "0"

        End If
        Me.SqlDataSource1.Insert()
        MsgBox("EMPLEADO ALMACENADO CON EXITO", MsgBoxStyle.Information, "EXITO")
        INHABILITAR()
        LIMPIAR()
    End Sub

    Protected Sub BTNCANCELAR_Click(sender As Object, e As ImageClickEventArgs) Handles BTNCANCELAR.Click
        INHABILITAR()
        LIMPIAR()
    End Sub
End Class
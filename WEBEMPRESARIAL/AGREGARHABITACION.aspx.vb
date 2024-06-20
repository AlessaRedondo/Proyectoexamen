﻿Public Class AGREGARHABITACION
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Private Sub LIMPIAR()
        Me.TXTNUMERO.Text = ""
        Me.TXTPRECIO.Text = ""
        Me.TXTDETALLE.Text = ""
        Me.TXTUBICACION.Text = ""
        Me.TXTCODIGO.Text = ""

    End Sub
    Private Sub HABILITAR()
        Me.TXTNUMERO.ReadOnly = False
        Me.TXTUBICACION.ReadOnly = False
        Me.TXTPRECIO.ReadOnly = False
        Me.TXTDETALLE.ReadOnly = False
        Me.TXTUBICACION.ReadOnly = False
        ''

        Me.BTNGUARDAR.Enabled = True
        Me.BTNCANCELAR.Enabled = True
    End Sub
    Private Sub INHABILITAR()
        Me.TXTNUMERO.ReadOnly = True
        Me.TXTPRECIO.ReadOnly = True
        Me.TXTDETALLE.ReadOnly = True
        Me.TXTUBICACION.ReadOnly = True


        ''

        Me.BTNGUARDAR.Enabled = False
        Me.BTNCANCELAR.Enabled = False

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
                MsgBox(" LA HABITACION EXISTE", MsgBoxStyle.Critical, " ERROR")
                INHABILITAR()
                LIMPIAR()
            Else
                HABILITAR()
            End If
        End If
    End Sub

    Protected Sub BTNGUARDAR_Click(sender As Object, e As ImageClickEventArgs) Handles BTNGUARDAR.Click
        Me.SqlDataSource1.Insert()
        MsgBox("HABITACION ALMACENADO CON EXITO", MsgBoxStyle.Information, "EXITO")
        INHABILITAR()
        LIMPIAR()
    End Sub

    Protected Sub BTNCANCELAR_Click(sender As Object, e As ImageClickEventArgs) Handles BTNCANCELAR.Click
        INHABILITAR()
        LIMPIAR()
    End Sub
End Class
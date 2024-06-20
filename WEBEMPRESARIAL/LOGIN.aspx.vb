Public Class LOGIN
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub SqlDataSource1_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles SqlDataSource1.Selecting

    End Sub

    Protected Sub IMBLOGIN_Click(sender As Object, e As ImageClickEventArgs) Handles IBMLOGIN.Click
        Dim DATOS As New GridView
        DATOS.DataSource = Me.SqlDataSource1
        DATOS.DataBind()
        If DATOS.Rows.Count > 0 Then
            Session("NOMBRE") = DATOS.Rows(0).Cells(0).Text
            Session("USER") = DATOS.Rows(0).Cells(1).Text
            Session("CONTRASEÑA") = DATOS.Rows(0).Cells(2).Text
            Session("CUENTA") = DATOS.Rows(0).Cells(3).Text
            If Me.TXTCONTRASEÑA.Text = Session("CONTRASEÑA") Then
                If Session("CUENTA") = "1" Then
                    Me.Response.Redirect("\MENUPRINCIPAL.ASPX")
                Else
                    MsgBox("CUENTA INACTIVA , COMUNICATE CON EL ADMIN ", MsgBoxStyle.Critical, "ERROR ")
                End If
            Else
                MsgBox("CONTRASEÑA INCORRECTA", MsgBoxStyle.Critical, " ERROR")
                Me.TXTCONTRASEÑA.Text = ""
                Me.TXTCONTRASEÑA.Focus()
            End If
        Else
            MsgBox("USUARIO INCORRECTO", MsgBoxStyle.Critical, "ERROR")
            Me.TXTCONTRASEÑA.Text = ""
            Me.TXTUSUARIO.Text = ""
            Me.TXTCONTRASEÑA.Focus()
        End If
    End Sub
End Class
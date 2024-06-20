Public Class MENUPRINCIPAL
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.LBLUSUARIO.Text = Session("USER")
        Me.LBLNOMBRE.Text = Session("NOMBRE")
    End Sub

End Class
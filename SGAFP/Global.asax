<%@ Application Language="VB" %>

<script runat="server">

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Código que se ejecuta al iniciarse la aplicación
    End Sub
    
    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Código que se ejecuta durante el cierre de aplicaciones
    End Sub
        
    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Código que se ejecuta al producirse un error no controlado
        Dim ex As Exception = Server.GetLastError().GetBaseException()
        If Not ex.InnerException Is Nothing Then
            If Not ex.InnerException.InnerException Is Nothing Then
                Microsoft.ApplicationBlocks.ExceptionManagement.ExceptionManager.Publish(ex.InnerException.InnerException)
            End If
            Microsoft.ApplicationBlocks.ExceptionManagement.ExceptionManager.Publish(ex.InnerException)
        End If
        'Microsoft.ApplicationBlocks.ExceptionManagement.ExceptionManager.Publish(ex)
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Código que se ejecuta cuando se inicia una nueva sesión
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Código que se ejecuta cuando finaliza una sesión. 
        ' Nota: El evento Session_End se desencadena sólo con el modo sessionstate
        ' se establece como InProc en el archivo Web.config. Si el modo de sesión se establece como StateServer 
        ' o SQLServer, el evento no se genera.
    End Sub
       
Protected Sub Application_PostAuthenticateRequest(ByVal sender As Object, ByVal e As System.EventArgs)
        If Request.IsAuthenticated Then
            SGAFP.EL.configuracion.usuarioActualiza = HttpContext.Current.User.Identity.Name
            PATI.EL.configuracion.usuarioActualiza = HttpContext.Current.User.Identity.Name
        End If
End Sub
</script>
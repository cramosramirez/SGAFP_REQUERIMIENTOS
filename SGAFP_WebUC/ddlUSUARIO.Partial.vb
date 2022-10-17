Imports SQLMembershipProvider.BL
Imports System.Web.Security

Partial Public Class ddlUSUARIO
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por nombre del Perfil .
    ''' </summary>
    ''' <param name="NOMBRE_PERFIL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	30/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPERFIL(ByVal NOMBRE_PERFIL As String)
        Dim miComponente As New cUSUARIO
        Dim Lista As New listaUSUARIO
        Dim _mu As cmembershipProvider

        _mu = CType(Membership.Provider, cmembershipProvider)

        For Each NombreUsuario As String In Roles.GetUsersInRole(NOMBRE_PERFIL)
            Dim eUSUARIO As USUARIO

            eUSUARIO = miComponente.ObtenerUSUARIO(_mu.GetUser(NombreUsuario, False).UserName)
            If Not eUSUARIO Is Nothing Then
                Lista.Add(eUSUARIO)
            End If
        Next

        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE"
        Me.DataValueField = "USUARIO"

        Me.DataBind()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el DropDownList filtrada por los parámetros de la Tabla PROVEEDOR_AF .
    ''' </summary>
    ''' <param name="ROL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorROL(ByVal ROL As String)
        Dim miComponente As New cUSUARIO
        Dim Lista As New listaUSUARIO
        Dim lentidad As New USUARIO

        lentidad.USUARIO = ""
        lentidad.NOMBRE = ""

        Lista = miComponente.ObtenerListaPorRol(ROL)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.Items.Clear()
            Return
        End If

        Lista.Insert(0, lentidad)
        Lista.SortByColum("NOMBRE", ListSortDirection.Ascending)

        Me.DataSource = Lista
        Me.DataTextField = "NOMBRE"
        Me.DataValueField = "USUARIO"



        Me.DataBind()

    End Sub
End Class

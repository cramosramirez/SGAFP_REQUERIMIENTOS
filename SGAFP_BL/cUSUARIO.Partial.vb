Partial Public Class cUSUARIO

    Public Sub New()

    End Sub

    Public Sub New(ByVal aConnectionStringName As String)
        ConnectionStringName = aConnectionStringName
        Me.mDb = New dbUSUARIO(aConnectionStringName)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los criterios proporcionados
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="USUARIOS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	29/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                             ByVal ID_SITIO_CAPACITACION As Decimal, _
                                             ByVal USUARIOS As List(Of String)) As listaUSUARIO
        Try
            Dim mListaUSUARIO As New listaUSUARIO
            mListaUSUARIO = mDb.ObtenerListaPorCriterios(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, USUARIOS)
            Return mListaUSUARIO

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Agrega un cmembershipUser mediante el Proveedor cmembershipProvider
    ''' </summary>
    ''' <param name="NOMBRE"></param>
    ''' <param name="CLAVE"></param>
    ''' <param name="EMAIL"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <param name="ROLES"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	09/11/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function AgregarUSUARIO_cmembershipProvider(ByVal USUARIO As String, _
                                 ByVal NOMBRE As String, _
                                 ByVal CLAVE As String, _
                                 ByVal EMAIL As String, _
                                 ByVal ID_PROVEEDOR_AF As Decimal, _
                                 ByVal ID_SITIO_CAPACITACION As Decimal, _
                                 ByVal ID_PARTICIPANTE As Decimal, _
                                 ByVal ROLES As Object, _
                                 ByVal CORREO_ADICIONAL As String) As Integer

        Dim c As SQLMembershipProvider.BL.cmembershipProvider
        c = CType(System.Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)


        If c.CrearUsuario(USUARIO, NOMBRE, CLAVE, EMAIL, ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_PARTICIPANTE, ROLES, CORREO_ADICIONAL) IsNot Nothing Then
            Return 1
        Else
            Return -1
        End If
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Agrega un cmembershipUser mediante el Proveedor cmembershipProvider y setea Municipio de Usuario tipo Alcaldia
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <param name="NOMBRE"></param>
    ''' <param name="CLAVE"></param>
    ''' <param name="EMAIL"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <param name="ROLES"></param>
    ''' <param name="CORREO_ADICIONAL"></param>
    ''' <param name="DEPARTAMENTO_ALCALDIA"></param>
    ''' <param name="MUNICIPIO_ALCALDIA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	17/11/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function AgregarUSUARIO_cmembershipProvider(ByVal USUARIO As String, _
                                 ByVal NOMBRE As String, _
                                 ByVal CLAVE As String, _
                                 ByVal EMAIL As String, _
                                 ByVal ID_PROVEEDOR_AF As Decimal, _
                                 ByVal ID_SITIO_CAPACITACION As Decimal, _
                                 ByVal ID_PARTICIPANTE As Decimal, _
                                 ByVal ROLES As Object, _
                                 ByVal CORREO_ADICIONAL As String, _
                                 ByVal DEPARTAMENTO_ALCALDIA As String, _
                                 ByVal MUNICIPIO_ALCALDIA As String) As Integer

        Dim liRet As Integer

        liRet = Me.AgregarUSUARIO_cmembershipProvider(USUARIO, NOMBRE, CLAVE, EMAIL, ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_PARTICIPANTE, ROLES, CORREO_ADICIONAL)

        If liRet = 1 Then
            If DEPARTAMENTO_ALCALDIA <> "" Then
                Dim lUsuario As USUARIO = Me.ObtenerUSUARIO(USUARIO)
                If Not lUsuario Is Nothing Then
                    lUsuario.DEPARTAMENTO_ALCALDIA = DEPARTAMENTO_ALCALDIA
                    lUsuario.MUNICIPIO_ALCALDIA = MUNICIPIO_ALCALDIA
                    If Me.ActualizarUSUARIO(lUsuario) < 1 Then

                    End If
                End If
            End If
        End If

        Return liRet

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un cmembershipUser mediante el Proveedor cmembershipProvider
    ''' </summary>
    ''' <param name="NOMBRE"></param>
    ''' <param name="EMAIL"></param>
    ''' <param name="APROBADO"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <param name="ROLES"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	09/11/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ActualizarUSUARIO_cmembershipProvider(ByVal USUARIO As String, _
                                 ByVal NOMBRE As String, _
                                 ByVal EMAIL As String, _
                                 ByVal APROBADO As Boolean, _
                                 ByVal ID_PROVEEDOR_AF As Decimal, _
                                 ByVal ID_SITIO_CAPACITACION As Decimal, _
                                 ByVal ID_PARTICIPANTE As Decimal, _
                                 ByVal ROLES As Object, _
                                 ByVal CORREO_ADICIONAL As String) As Integer

        Dim c As SQLMembershipProvider.BL.cmembershipProvider
        Dim customUsuario As SQLMembershipProvider.BL.cmembershipUser

        c = CType(System.Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)
        customUsuario = c.ObtenerUsuario(USUARIO)

        With customUsuario
            .Nombre = NOMBRE
            .Email = EMAIL
            .IsApproved = APROBADO
            .IdProveedorAF = ID_PROVEEDOR_AF
            .IdSitioCapacitacion = ID_SITIO_CAPACITACION
            .IdParticipante = ID_PARTICIPANTE
        End With

        c.ActualizarUsuario(customUsuario, ROLES, CORREO_ADICIONAL)
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un cmembershipUser mediante el Proveedor cmembershipProvider
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <param name="NOMBRE"></param>
    ''' <param name="EMAIL"></param>
    ''' <param name="APROBADO"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <param name="ROLES"></param>
    ''' <param name="CORREO_ADICIONAL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	17/11/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub ActualizarUSUARIO_cmembershipProvider(ByVal USUARIO As String, _
                                 ByVal NOMBRE As String, _
                                 ByVal EMAIL As String, _
                                 ByVal APROBADO As Boolean, _
                                 ByVal ID_PROVEEDOR_AF As Decimal, _
                                 ByVal ID_SITIO_CAPACITACION As Decimal, _
                                 ByVal ID_PARTICIPANTE As Decimal, _
                                 ByVal ROLES As Object, _
                                 ByVal CORREO_ADICIONAL As String, _
                                 ByVal DEPARTAMENTO_ALCALDIA As String, _
                                 ByVal MUNICIPIO_ALCALDIA As String)

        Dim liRet As Integer

        liRet = Me.ActualizarUSUARIO_cmembershipProvider(USUARIO, NOMBRE, EMAIL, APROBADO, ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_PARTICIPANTE, ROLES, CORREO_ADICIONAL)

        If liRet = 1 Then
            If DEPARTAMENTO_ALCALDIA <> "" Then
                Dim lUsuario As USUARIO = Me.ObtenerUSUARIO(USUARIO)
                If Not lUsuario Is Nothing Then
                    lUsuario.DEPARTAMENTO_ALCALDIA = DEPARTAMENTO_ALCALDIA
                    lUsuario.MUNICIPIO_ALCALDIA = MUNICIPIO_ALCALDIA
                    If Me.ActualizarUSUARIO(lUsuario) < 1 Then

                    End If
                End If
            End If
        End If

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un cmembershipUser mediante el Proveedor cmembershipProvider
    ''' </summary>
    ''' <param name="USUARIO"></param>   
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	09/11/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub EliminarUSUARIO_cmembershipProvider(ByVal USUARIO As String)

        Dim c As SQLMembershipProvider.BL.cmembershipProvider
        Dim customUsuario As SQLMembershipProvider.BL.cmembershipUser

        c = CType(System.Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)
        customUsuario = c.ObtenerUsuario(USUARIO)

        c.EliminarUsuario(USUARIO)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PROVEEDOR_AF y Tipo de Rol .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	15/04/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_AF_Rol(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ROL As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaUSUARIO
        Try
            Dim c As SQLMembershipProvider.BL.cmembershipProvider
            Dim mListaUSUARIO As New listaUSUARIO
            Dim mListaUSUARIOFinal As New listaUSUARIO

            c = CType(System.Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)
            mListaUSUARIO = mDb.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF, asColumnaOrden, asTipoOrden)

            If mListaUSUARIO IsNot Nothing Then
                For Each lEntidad As USUARIO In mListaUSUARIO
                    Try
                        Dim mRolesUsuario As List(Of String)
                        mRolesUsuario = c.ObtenerRoles(lEntidad.USUARIO)

                        If mRolesUsuario IsNot Nothing AndAlso mRolesUsuario.Contains(ROL) Then
                            mListaUSUARIOFinal.Add(lEntidad)
                        End If

                    Catch ex As Exception
                        Return Nothing
                    End Try
                Next

                Return mListaUSUARIOFinal
            Else
                Return Nothing
            End If

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorRol(ByVal ROL As String) As listaUSUARIO
        Try
            Dim c As SQLMembershipProvider.BL.cmembershipProvider
            Dim lUsuario As USUARIO
            Dim mListaUSUARIO As New listaUSUARIO
            Dim sNombreUsuario As String

            c = CType(System.Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)


            Dim lstEmailsRol As List(Of String) = c.ObtenerEmailsPorRol(ROL, True)

            If lstEmailsRol IsNot Nothing AndAlso lstEmailsRol.Count > 0 Then
                For i As Integer = 0 To lstEmailsRol.Count - 1
                    sNombreUsuario = c.GetUserNameByEmail(lstEmailsRol(i))
                    lUsuario = (New cUSUARIO).ObtenerUSUARIO(sNombreUsuario)

                    If lUsuario IsNot Nothing Then
                        mListaUSUARIO.Add(lUsuario)
                    End If
                Next
            End If


            If mListaUSUARIO IsNot Nothing AndAlso mListaUSUARIO.Count > 0 Then
                Return mListaUSUARIO
            Else
                Return Nothing
            End If

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class

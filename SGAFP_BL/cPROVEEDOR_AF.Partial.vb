Partial Class cPROVEEDOR_AF
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por el parámetros técnico
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTecnico(ByVal USUARIO As String, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "PROVEEDOR_AF.NOMBRE_PROVEEDOR", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AF
        Try
            Dim mListaPROVEEDOR_AF As New listaPROVEEDOR_AF
            mListaPROVEEDOR_AF = mDb.ObtenerListaPorTecnico(USUARIO, asColumnaOrden, asTipoOrden)
            If Not mListaPROVEEDOR_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROVEEDOR_AF In mListaPROVEEDOR_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPROVEEDOR_AF
            If Not mListaPROVEEDOR_AF Is Nothing Then
                For Each lEntidad As PROVEEDOR_AF In mListaPROVEEDOR_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROVEEDOR_AF
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorDepartamento_Presencia_Sitio(ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "PROVEEDOR_AF.NOMBRE_PROVEEDOR", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AF
        Try
            Dim mListaPROVEEDOR_AF As New listaPROVEEDOR_AF
            mListaPROVEEDOR_AF = mDb.ObtenerListaPorDepartamento_Presencia_Sitio(CODIGO_REGION, CODIGO_DEPARTAMENTO, asColumnaOrden, asTipoOrden)
            If Not mListaPROVEEDOR_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROVEEDOR_AF In mListaPROVEEDOR_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPROVEEDOR_AF
            If Not mListaPROVEEDOR_AF Is Nothing Then
                For Each lEntidad As PROVEEDOR_AF In mListaPROVEEDOR_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROVEEDOR_AF
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
   Public Function ObtenerListaPorSitio_Capacitacion(ByVal ID_SITIO_CAPACITACION As Decimal, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "PROVEEDOR_AF.NOMBRE_PROVEEDOR", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AF
        Try
            Dim mListaPROVEEDOR_AF As New listaPROVEEDOR_AF
            mListaPROVEEDOR_AF = mDb.ObtenerListaPorSitio_Capacitacion(ID_SITIO_CAPACITACION, asColumnaOrden, asTipoOrden)
            If Not mListaPROVEEDOR_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROVEEDOR_AF In mListaPROVEEDOR_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPROVEEDOR_AF
            If Not mListaPROVEEDOR_AF Is Nothing Then
                For Each lEntidad As PROVEEDOR_AF In mListaPROVEEDOR_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROVEEDOR_AF
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
   Public Function ObtenerListaProveedoresHTP(ByVal ID_EJERCICIO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AF
        Try
            Return mDb.ObtenerListaProveedoresHTP(ID_EJERCICIO, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal NIT As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AF
        Try
            Return mDb.ObtenerListaPorCriterios(NIT, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaProveedoresPorProgramaFormacion(ByVal ID_PROGRAMA_FORMACION As Integer, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AF
        Try
            Return mDb.ObtenerListaProveedoresPorProgramaFormacion(ID_PROGRAMA_FORMACION, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPROVEEDOR_AF(ByVal aEntidad As PROVEEDOR_AF) As Integer
        Try
            Return Me.ActualizarPROVEEDOR_AF(aEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPROVEEDOR_AF(ByVal aEntidad As PROVEEDOR_AF, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim listaProveedor As listaPROVEEDOR_AF

            'Validar que el NIT / DUI no este registrado
            aEntidad.NIT = If(aEntidad.NIT = Nothing, "", Replace(aEntidad.NIT.Trim, "-", ""))
            aEntidad.DUI = If(aEntidad.DUI = Nothing, "", Replace(aEntidad.DUI.Trim, "-", ""))

            If aEntidad.NIT <> "" Then
                Dim lCriterios As New List(Of Criteria)
                Dim lCriterio As New Criteria("NIT", "=", aEntidad.NIT, "")
                Dim lProveedor As New PROVEEDOR_AF

                lProveedor.NIT = aEntidad.NIT
                lCriterios.Add(lCriterio)
                listaProveedor = (New cPROVEEDOR_AF).ObtenerListaPorBusqueda(lProveedor, lCriterios.ToArray)

                If listaProveedor IsNot Nothing AndAlso listaProveedor.Count > 0 Then
                    If aEntidad.ID_PROVEEDOR_AF = 0 Then
                        sError = "Ya existe un Proveedor con el NIT: " + aEntidad.NIT
                        Return -1
                    Else
                        If listaProveedor(0).ID_PROVEEDOR_AF <> aEntidad.ID_PROVEEDOR_AF Then
                            sError = "Ya existe un Proveedor con el NIT: " + aEntidad.NIT
                            Return -1
                        End If
                    End If
                End If
            End If

            If aEntidad.DUI <> "" Then
                Dim lCriterios As New List(Of Criteria)
                Dim lCriterio As New Criteria("DUI", "=", aEntidad.DUI, "")
                Dim lProveedor As New PROVEEDOR_AF

                lProveedor.DUI = aEntidad.DUI
                lCriterios.Add(lCriterio)
                listaProveedor = (New cPROVEEDOR_AF).ObtenerListaPorBusqueda(lProveedor, lCriterios.ToArray)

                If listaProveedor IsNot Nothing AndAlso listaProveedor.Count > 0 Then
                    If aEntidad.ID_PROVEEDOR_AF = 0 Then
                        sError = "Ya existe un Proveedor con el DUI: " + aEntidad.DUI
                        Return -1
                    Else
                        If listaProveedor(0).ID_PROVEEDOR_AF <> aEntidad.ID_PROVEEDOR_AF Then
                            sError = "Ya existe un Proveedor con el DUI: " + aEntidad.NIT
                            Return -1
                        End If
                    End If
                End If
            End If


            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class

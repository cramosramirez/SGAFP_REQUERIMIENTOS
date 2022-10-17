Partial Class cAREA_FORMACION

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por Proveedor y Ejercicio,
    ''' lo cual a su vez incorpora las Areas de Formacion que si tengan Oferta Formativa 
    ''' definida para el Proveedor y Ejercicio enviados de parametro.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	20/04/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorProveedorEjercicio(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_EJERCICIO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaAREA_FORMACION
        Try
            Return mDb.ObtenerListaPorProveedorEjercicio(ID_PROVEEDOR_AF, ID_EJERCICIO, asColumnaOrden, asTipoOrden)
            
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorCODIGO_AREA(ByVal CODIGO_AREA As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaAREA_FORMACION
        Try
            Return mDb.ObtenerListaPorCODIGO_AREA(CODIGO_AREA, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorNOMBRE(ByVal AREA_FORMACION As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaAREA_FORMACION
        Try
            Return mDb.ObtenerListaPorNOMBRE(AREA_FORMACION, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por Proveedor y Ejercicio,
    ''' lo cual a su vez incorpora las Areas de Formacion que si tengan Oferta Formativa 
    ''' definida para el Proveedor y Ejercicio enviados de parametro.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	20/04/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorProveedorSitioEjercicio(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaAREA_FORMACION
        Try
            Dim mListaAREA_FORMACION As New listaAREA_FORMACION
            mListaAREA_FORMACION = mDb.ObtenerListaPorProveedorSitioEjercicio(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_EJERCICIO, asColumnaOrden, asTipoOrden)
            If Not recuperarHijas Then Return mListaAREA_FORMACION
            If Not mListaAREA_FORMACION Is Nothing Then
                For Each lEntidad As AREA_FORMACION In mListaAREA_FORMACION
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaAREA_FORMACION
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por Proveedor y Ejercicio,
    ''' lo cual a su vez incorpora las Areas de Formacion que si tengan Oferta Formativa 
    ''' definida para el Proveedor y Ejercicio enviados de parametro.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/11/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorProveedor(ByVal ID_PROVEEDOR_AF As Decimal, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaAREA_FORMACION
        Try
            Dim mListaAREA_FORMACION As New listaAREA_FORMACION
            mListaAREA_FORMACION = mDb.ObtenerListaPorProveedor(ID_PROVEEDOR_AF, asColumnaOrden, asTipoOrden)
            If Not recuperarHijas Then Return mListaAREA_FORMACION
            If Not mListaAREA_FORMACION Is Nothing Then
                For Each lEntidad As AREA_FORMACION In mListaAREA_FORMACION
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaAREA_FORMACION
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class

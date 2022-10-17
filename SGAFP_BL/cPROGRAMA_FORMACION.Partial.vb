Partial Public Class cPROGRAMA_FORMACION
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades pertenecientes al Programa PATI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPATI() As listaPROGRAMA_FORMACION
        Try
            Dim mListaPROGRAMA_FORMACION As New listaPROGRAMA_FORMACION
            Dim bPrograma As New cPROGRAMA_FORMACION

            mListaPROGRAMA_FORMACION.Add(bPrograma.ObtenerPROGRAMA_FORMACION(Enumeradores.ProgramasFormacion.PATI_BM))
            mListaPROGRAMA_FORMACION.Add(bPrograma.ObtenerPROGRAMA_FORMACION(Enumeradores.ProgramasFormacion.PATI_USAID))
            mListaPROGRAMA_FORMACION.Add(bPrograma.ObtenerPROGRAMA_FORMACION(Enumeradores.ProgramasFormacion.PATI_2))
            Return mListaPROGRAMA_FORMACION

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una cadena que representa los programas a los que se tiene acceso por una Lista de Roles
    ''' </summary>
    ''' <param name="listaRoles"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	17/12/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorROLES(ByVal listaRoles As List(Of String)) As listaPROGRAMA_FORMACION
        Try
            Return mDb.ObtenerListaPorROLES(listaRoles)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try

    End Function

    Public Function ObtenerMontoApoyoParticipantePorPrograma(ByVal ID_PROGRAMA_FORMACION) As Decimal
        Try
            Dim lEntidad As PROGRAMA_FORMACION = Me.ObtenerPROGRAMA_FORMACION(ID_PROGRAMA_FORMACION)
            Dim monto As Decimal = 0

            If lEntidad IsNot Nothing Then
                monto = lEntidad.MONTO_APOYO_PARTI
            End If
            Return monto

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return 0
        End Try

    End Function
End Class

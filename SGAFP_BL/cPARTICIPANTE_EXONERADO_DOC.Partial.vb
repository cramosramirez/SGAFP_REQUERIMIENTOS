Imports SGAFP.EL.Utilerias
Partial Public Class cPARTICIPANTE_EXONERADO_DOC

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' las Columnas de la LLave de la Tabla PARTICIPANTE_EXONERADO_DOC.
    ''' </summary>
    ''' <param name="mPARTICIPANTE_EXONERADO_DOC"></param>
    ''' <param name="duplicadoPorFonetico"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	21/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaParticipantesSemejantes(ByVal mPARTICIPANTE_EXONERADO_DOC As Object, ByRef duplicadoPorFonetico As Integer) As listaPARTICIPANTE_EXONERADO_DOC
        Try
            Dim listaSemejantes As listaPARTICIPANTE_EXONERADO_DOC
            Dim listaObtenida As New listaPARTICIPANTE_EXONERADO_DOC
            Dim lEntidad As PARTICIPANTE_EXONERADO_DOC = TryCast(mPARTICIPANTE_EXONERADO_DOC, PARTICIPANTE_EXONERADO_DOC)

            listaSemejantes = mDb.ObtenerListaParticipantesSemejantes(lEntidad, duplicadoPorFonetico)

            'Agregar a lista las entidades que coinciden en fecha de nacimiento
            For i As Integer = 0 To listaSemejantes.Count - 1
                If listaSemejantes(i).FECHA_NACIMIENTO = lEntidad.FECHA_NACIMIENTO Then
                    listaObtenida.Add(listaSemejantes(i))
                    duplicadoPorFonetico += 1
                End If
            Next

            If listaObtenida.Count = 0 Then
                'Agregar a lista las entidades que coinciden en el año de la fecha de nacimiento
                For i As Integer = 0 To listaSemejantes.Count - 1
                    If listaSemejantes(i).FECHA_NACIMIENTO.Year = lEntidad.FECHA_NACIMIENTO.Year Then
                        listaObtenida.Add(listaSemejantes(i))
                        duplicadoPorFonetico += 1
                    End If
                Next
            End If

            Return listaObtenida

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' las Columnas de la LLave de la Tabla PARTICIPANTE_EXONERADO_DOC.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ESTADO"></param>
    ''' <param name="NOMBRES"></param>
    ''' <param name="APELLIDOS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	21/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ESTADO As Decimal, ByVal FECHA_NACIMIENTO As Object, ByVal NOMBRES As String, ByVal APELLIDOS As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE_EXONERADO_DOC
        Try
            Return mDb.ObtenerListaPorCriterios(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ESTADO, FECHA_NACIMIENTO, NOMBRES, APELLIDOS, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPARTICIPANTE_EXONERADO_DOC(ByVal ID_PARTICIPANTE As Decimal, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal FECHA_NACIMIENTO As DateTime, ByVal GENERO As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal DEPARTAMENTO_NAC As String, ByVal MUNICIPIO_NAC As String, ByVal DIRECCION As String, ByVal TELEFONO As String, ByVal MOVIL As String, ByVal CON_DISCAPACIDAD As Decimal, ByVal EMAIL As String, ByVal ID_NIVEL_ACADEMICO As Decimal, ByVal ID_PAIS As Decimal, ByVal ID_ESTADO_CIVIL As Decimal, ByVal FECHA_INGRESO As DateTime, ByVal USUARIO_EVALUA As String, ByVal FECHA_EVALUA As DateTime, ByVal ESTADO As Decimal, ByVal ID_PARTICIPANTE_EXONERADO As Decimal) As Integer
        Try
            Dim lEntidad As New PARTICIPANTE_EXONERADO_DOC
            lEntidad.ID_PARTICIPANTE_EXONERADO = ID_PARTICIPANTE_EXONERADO
            lEntidad.ID_PARTICIPANTE = ID_PARTICIPANTE
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            lEntidad.NOMBRES = Utilerias.ReemplazarAcentos(NOMBRES.Trim.ToUpper)
            lEntidad.APELLIDOS = Utilerias.ReemplazarAcentos(APELLIDOS.Trim.ToUpper)
            lEntidad.FECHA_NACIMIENTO = FECHA_NACIMIENTO
            lEntidad.GENERO = Utilerias.ReemplazarAcentos(GENERO.Trim.ToUpper)
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.DEPARTAMENTO_NAC = DEPARTAMENTO_NAC
            lEntidad.MUNICIPIO_NAC = MUNICIPIO_NAC
            lEntidad.DIRECCION = Utilerias.ReemplazarAcentos(DIRECCION.Trim.ToUpper)
            lEntidad.TELEFONO = TELEFONO
            lEntidad.MOVIL = MOVIL
            lEntidad.CON_DISCAPACIDAD = CON_DISCAPACIDAD
            lEntidad.EMAIL = Utilerias.ReemplazarAcentos(EMAIL.Trim.ToLower)
            lEntidad.ID_NIVEL_ACADEMICO = ID_NIVEL_ACADEMICO
            lEntidad.ID_PAIS = ID_PAIS
            lEntidad.ID_ESTADO_CIVIL = ID_ESTADO_CIVIL
            lEntidad.FECHA_INGRESO = FECHA_INGRESO
            lEntidad.USUARIO_EVALUA = USUARIO_EVALUA
            lEntidad.FECHA_EVALUA = FECHA_EVALUA
            lEntidad.ESTADO = ESTADO
            Return Me.ActualizarPARTICIPANTE_EXONERADO_DOC(lEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPARTICIPANTE_EXONERADO_DOC(ByVal aEntidad As PARTICIPANTE_EXONERADO_DOC) As Integer
        Try
            Return Me.ActualizarPARTICIPANTE_EXONERADO_DOC(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPARTICIPANTE_EXONERADO_DOC(ByVal aEntidad As PARTICIPANTE_EXONERADO_DOC, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            aEntidad.NOMBRES = Utilerias.ReemplazarAcentos(aEntidad.NOMBRES.Trim.ToUpper)
            aEntidad.APELLIDOS = Utilerias.ReemplazarAcentos(aEntidad.APELLIDOS.Trim.ToUpper)
            aEntidad.DIRECCION = Utilerias.ReemplazarAcentos(aEntidad.DIRECCION.Trim.ToUpper)
            aEntidad.EMAIL = Utilerias.ReemplazarAcentos(aEntidad.EMAIL.Trim.ToLower)
            aEntidad.GENERO = Utilerias.ReemplazarAcentos(aEntidad.GENERO.Trim.ToUpper)
            If aEntidad.ID_PARTICIPANTE_EXONERADO > 0 Then
                Dim lEntidadActual As PARTICIPANTE_EXONERADO_DOC = Me.ObtenerPARTICIPANTE_EXONERADO_DOC(aEntidad.ID_PARTICIPANTE_EXONERADO)
                If lEntidadActual.ESTADO <> aEntidad.ESTADO AndAlso aEntidad.ESTADO = 1 Then
                    'Crear participante
                    Dim eParticipante As New PARTICIPANTE
                    Dim bParticipante As New cPARTICIPANTE
                    With eParticipante
                        .NOMBRES = aEntidad.NOMBRES
                        .APELLIDOS = aEntidad.APELLIDOS
                        .CODIGO_DEPARTAMENTO = aEntidad.CODIGO_DEPARTAMENTO
                        .CODIGO_MUNICIPIO = aEntidad.CODIGO_MUNICIPIO
                        .CON_DISCAPACIDAD = aEntidad.CON_DISCAPACIDAD
                        .DEPARTAMENTO_NAC = aEntidad.DEPARTAMENTO_NAC
                        .MUNICIPIO_NAC = aEntidad.MUNICIPIO_NAC
                        .DIRECCION = aEntidad.DIRECCION
                        .EMAIL = aEntidad.EMAIL
                        .MOVIL = aEntidad.MOVIL
                        .FECHA_NACIMIENTO = aEntidad.FECHA_NACIMIENTO
                        .GENERO = aEntidad.GENERO
                        .ID_ESTADO_CIVIL = aEntidad.ID_ESTADO_CIVIL
                        .ID_NIVEL_ACADEMICO = aEntidad.ID_NIVEL_ACADEMICO
                        .ID_PAIS = aEntidad.ID_PAIS
                        .ID_PARTICIPANTE = 0
                        .TIPO_DOCTO = -1
                    End With
                    If bParticipante.ActualizarPARTICIPANTE(eParticipante, TipoConcurrencia.Pesimistica) = 1 Then
                        aEntidad.ID_PARTICIPANTE = eParticipante.ID_PARTICIPANTE
                    Else
                        Throw New Exception("Error al crear registro en el Catálogo de Participante")
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

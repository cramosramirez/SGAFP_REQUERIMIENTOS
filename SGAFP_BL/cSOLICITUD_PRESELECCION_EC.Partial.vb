Partial Public Class cSOLICITUD_PRESELECCION_EC


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	17/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                              ByVal ID_PROGRAMA_FORMACION As Decimal, _
                                              ByVal NUM_CONTRATO As String, _
                                              ByVal CODIGO As String, _
                                              ByVal NO_GRUPO As Decimal, _
                                              Optional ByVal asColumnaOrden As String = "", _
                                              Optional ByVal asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC
        Try
            Return mDb.ObtenerListaPorCriterios(ID_PROVEEDOR_AF, ID_PROGRAMA_FORMACION, NUM_CONTRATO, CODIGO, NO_GRUPO, asColumnaOrden, asTipoOrden)
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
    ''' 	[GenApp]	09/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_PRESELECCION_EC(ByVal aEntidad As SOLICITUD_PRESELECCION_EC) As Integer
        Try
            Return Me.ActualizarSOLICITUD_PRESELECCION_EC(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	09/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_PRESELECCION_EC(ByVal aEntidad As SOLICITUD_PRESELECCION_EC, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Dim listaParti As listaPARTICIPANTE

            If aEntidad.ID_PARTICIPANTE <= 0 Then
                If aEntidad.DUI IsNot Nothing AndAlso aEntidad.DUI.Trim <> "" Then
                    If Not Utilerias.EsDUI(aEntidad.DUI.Trim) Then
                        Me.sError = "No se puede realizar la inscripcion del Participante porque el Numero de DUI no es valido"
                        Return -11
                    End If
                    listaParti = (New cPARTICIPANTE).ObtenerListaPorDUI(aEntidad.DUI)
                    If listaParti IsNot Nothing AndAlso listaParti.Count > 0 AndAlso listaParti(0).ID_PARTICIPANTE <> aEntidad.ID_PARTICIPANTE Then
                        Me.sError = "Ya existe un participante con el mismo numero de DUI"
                        Return -11
                    End If
                Else
                    Me.sError = "El DUI es obligatorio"
                    Return -11
                End If

                If aEntidad.NIT IsNot Nothing AndAlso aEntidad.NIT.Trim <> "" Then
                    If Not Utilerias.EsNIT(aEntidad.NIT.Trim) Then
                        Me.sError = "No se puede realizar la inscripción del Participante porque el Numero de NIT no es valido"
                        Return -11
                    End If
                    listaParti = (New cPARTICIPANTE).ObtenerListaPorNIT(aEntidad.NIT)
                    If listaParti IsNot Nothing AndAlso listaParti.Count > 0 AndAlso listaParti(0).ID_PARTICIPANTE <> aEntidad.ID_PARTICIPANTE Then
                        Me.sError = "Ya existe un participante con el mismo numero de NIT"
                        Return -11
                    End If
                End If


                '   Registrar el participanye
                Dim lParti As New PARTICIPANTE
                Dim bParti As New cPARTICIPANTE

                With lParti
                    .ID_PARTICIPANTE = 0
                    .NOMBRES = aEntidad.NOMBRES
                    .APELLIDOS = aEntidad.APELLIDOS
                    .GENERO = aEntidad.GENERO
                    .ID_PAIS = aEntidad.ID_PAIS
                    .FECHA_NACIMIENTO = aEntidad.FECHA_NACIMIENTO
                    .DIRECCION = aEntidad.DIRECCION
                    .DUI = aEntidad.DUI
                    .NIT = aEntidad.NIT
                    .ISSS = aEntidad.ISSS
                    .TIPO_DOCTO = -1
                    .NUM_DOCTO = ""
                    .TELEFONO = aEntidad.TELEFONO
                    .MOVIL = aEntidad.MOVIL
                    .EMAIL = aEntidad.EMAIL
                    .ID_ESTADO_CIVIL = aEntidad.ID_ESTADO_CIVIL
                    .PROFESION_OFICIO = aEntidad.PROFESION_OFICIO
                    .OCUPACION_ACTUAL = ""
                    .TITULO_CERTIFICADO_OBTENIDO = aEntidad.TITULO_CERTIFICADO_OBTENIDO
                    .DEPARTAMENTO_NAC = aEntidad.DEPARTAMENTO_NAC
                    .MUNICIPIO_NAC = aEntidad.MUNICIPIO_NAC
                    .CODIGO_DEPARTAMENTO = aEntidad.CODIGO_DEPARTAMENTO
                    .CODIGO_MUNICIPIO = aEntidad.CODIGO_MUNICIPIO
                    .CODIGO_DEPARTAMENTO = aEntidad.CODIGO_DEPARTAMENTO
                    .ID_NIVEL_ACADEMICO = aEntidad.ID_NIVEL_ACADEMICO
                    .OTRA_EDUCACION_FORMAL = aEntidad.OTRA_EDUCACION_FORMAL
                    .CON_DISCAPACIDAD = aEntidad.CON_DISCAPACIDAD
                    .DISC_OTRA = aEntidad.DISC_OTRA
                    .LASTUPDATE = aEntidad.FECHA_CREACION
                    .USERID = aEntidad.USUARIO_CREA

                    bParti.ActualizarPARTICIPANTE(lParti)

                    '   **** ASIGNAR ID_PARTICIPANTE
                    aEntidad.ID_PARTICIPANTE = lParti.ID_PARTICIPANTE
                End With

            End If

            If aEntidad.EDAD < 10 OrElse aEntidad.EDAD > 100 Then
                Me.sError = "La Fecha de Nacimiento " + aEntidad.FECHA_NACIMIENTO.ToShortDateString + " no es valida. Fecha solicitud = " + aEntidad.FECHA_PRESENTACION.ToShortDateString
                Return -13
            End If

            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_PRESELECCION_EC que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SOLIC_PRESELEC"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLICITUD_PRESELECCION_EC(ByVal ID_SOLIC_PRESELEC As Decimal) As Integer
        Try
            mEntidad.ID_SOLIC_PRESELEC = ID_SOLIC_PRESELEC
            Return Me.EliminarSOLICITUD_PRESELECCION_EC(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_PRESELECCION_EC que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLICITUD_PRESELECCION_EC(ByVal aEntidad As SOLICITUD_PRESELECCION_EC, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            'Eliminar datos dependientes
            Dim lDiscas As listaDISCA_SOLIC_PRESELE = (New cDISCA_SOLIC_PRESELE).ObtenerListaPorSOLICITUD_PRESELECCION_EC(aEntidad.ID_SOLIC_PRESELEC)
            Dim bDiscas As New cDISCA_SOLIC_PRESELE
            Dim lSoliCursos As listaSOLIC_PRESELE_CURREC = (New cSOLIC_PRESELE_CURREC).ObtenerListaPorSOLICITUD_PRESELECCION_EC(aEntidad.ID_SOLIC_PRESELEC)
            Dim bSoliCursos As New cSOLIC_PRESELE_CURREC
            Dim lSoliEmpre As listaSOLIC_PRESELE_EMPRE = (New cSOLIC_PRESELE_EMPRE).ObtenerListaPorSOLICITUD_PRESELECCION_EC(aEntidad.ID_SOLIC_PRESELEC)
            Dim bSoliEmpre As New cSOLIC_PRESELE_EMPRE

            For i As Integer = 0 To lDiscas.Count - 1
                bDiscas.EliminarDISCA_SOLIC_PRESELE(lDiscas(i).ID_DISCA_SOLIC)
            Next
            For i As Integer = 0 To lSoliCursos.Count - 1
                bSoliCursos.EliminarSOLIC_PRESELE_CURREC(lSoliCursos(i).ID_PRESELE_CURREC)
            Next
            For i As Integer = 0 To lSoliEmpre.Count - 1
                bSoliEmpre.EliminarSOLIC_PRESELE_EMPRE(lSoliEmpre(i).ID_EMPRESA)
            Next

            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class

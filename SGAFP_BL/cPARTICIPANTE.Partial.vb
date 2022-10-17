Imports System.Web.Security
Imports SGAFP.EL.Utilerias

Partial Class cPARTICIPANTE

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' las Columnas de la LLave de la Tabla PARTICIPANTE_EXONERADO_DOC.
    ''' </summary>
    ''' <param name="mPARTICIPANTE"></param>
    ''' <param name="duplicadoPorFonetico"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	21/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaParticipantesSemejantes(ByVal mPARTICIPANTE As Object, ByRef duplicadoPorFonetico As Integer) As listaPARTICIPANTE
        Try
            Dim listaSemejantes As listaPARTICIPANTE
            Dim listaObtenida As New listaPARTICIPANTE
            Dim lEntidad As PARTICIPANTE = TryCast(mPARTICIPANTE, PARTICIPANTE)

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


    ''' <summary>
    ''' Crear Cuenta de Participante en Tablas de Seguridad, para su proximo acceso al sitio
    ''' </summary>
    ''' <param name="usr"></param>
    ''' <param name="clav"></param>
    ''' <param name="email"></param>
    ''' <param name="quest"></param>
    ''' <param name="Ans"></param>
    ''' <returns></returns>
    Public Function CrearCuenta(ByVal usr As String, ByVal clav As String, ByVal email As String, ByVal quest As String, ByVal Ans As String, Optional ByVal rol As String = "Participante") As Boolean

        Dim createStatus As MembershipCreateStatus
        Me.sError = ""

        Dim usuario As MembershipUser = Membership.CreateUser(usr, clav, email, quest, Ans, True, createStatus)

        Select Case createStatus

            Case MembershipCreateStatus.DuplicateUserName
                Me.sError = "Ya existe un usuario registrado con el codigo de usuario ingresado."

            Case MembershipCreateStatus.DuplicateEmail
                Me.sError = "Ya existe un usuario con el correo electrónico ingresado."


            Case MembershipCreateStatus.InvalidPassword
                Me.sError = "La clave ingresada es inválida. Tiene que ser por lo menos de siete caracteres y que contenga por lo menos un caracter no alfanumérico."


            Case MembershipCreateStatus.InvalidEmail
                Me.sError = "El correo electrónico ingresado es inválido."


            Case MembershipCreateStatus.InvalidAnswer
                Me.sError = "La respuesta de seguridad es inválida."


            Case MembershipCreateStatus.InvalidQuestion
                Me.sError = "La respuesa a la pregunta de seguridad es inválida."


            Case MembershipCreateStatus.InvalidUserName
                Me.sError = "Usuario es inválido"


            Case MembershipCreateStatus.ProviderError
                Me.sError = "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator."


            Case MembershipCreateStatus.UserRejected
                Me.sError = "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator."


            Case Else
                Roles.AddUserToRole(usr, rol)
                Return True

        End Select

        If (Me.sError = "") Then Return True

        Return False
    End Function

    ''' <summary>
    ''' Generacion de cuenta automatica para Participante, utilizado desde el Ingreso de Solicitudes
    ''' </summary>
    ''' <param name="usr"></param>
    ''' <param name="email"></param>
    ''' <returns></returns>
    Public Function GenerarCuenta(ByVal usr As String, ByVal email As String) As Boolean
        Return Me.CrearCuenta(usr, "INICIAL." + DateTime.Now.ToString("ddMMyyyy"), email, "color", "verde")
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
    ''' <returns>
    '''   -1 : Excepcion no controlada
    '''   -2 : No genero bien la cuenta de Usuario
    '''   -3 : DUI ya existe, no se puede agregar un Nuevo Participante o Actualizar con un DUI existente
    '''   -4 : NIT ya existe, no se puede agregar un Nuevo Participante o Actualizar con un NIT existente
    '''   -5 : ISSS ya existe, no se puede agregar un Nuevo Participante o Actualizar con un ISSS existente
    '''   -6 : EMAIL ya existe, no se puede agregar un Nuevo Participante o Actualizar con un EMAIL existente
    ''' </returns>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' 	[ecarias]	17/03/2010	Se agrego logica para creacion de Cuenta de Usuario
    ''' 	[ecarias]	17/03/2010	Se agregaron validaciones de para que noi exista Duplicidad 
    '''                             en DUI, NIT, ISSS y Correo Electronico
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPARTICIPANTE(ByVal aEntidad As PARTICIPANTE, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Try
            Dim esNuevo As Boolean = False
            If aEntidad.ID_PARTICIPANTE = 0 _
                Or aEntidad.ID_PARTICIPANTE = Nothing Then

                Dim listaPart As New listaPARTICIPANTE
                Dim criterios As New List(Of Criteria)

                If aEntidad.DUI <> "" Then
                    criterios.Add(New Criteria("DUI", "=", aEntidad.DUI, ""))

                    listaPart = Me.ObtenerListaPorBusqueda(New PARTICIPANTE, criterios.ToArray())

                    If Not listaPart Is Nothing AndAlso listaPart.Count > 0 Then
                        Me.sError = "No se Puede Agregar el Participante porque ya existe un Participante con el mismo DUI ingresado"
                        Return -1
                    End If
                End If

                If aEntidad.NIT <> "" Then
                    criterios.Clear()
                    criterios.Add(New Criteria("NIT", "=", aEntidad.NIT, ""))

                    listaPart = Me.ObtenerListaPorBusqueda(New PARTICIPANTE, criterios.ToArray())

                    If Not listaPart Is Nothing AndAlso listaPart.Count > 0 Then
                        Me.sError = "No se Puede Agregar el Participante porque ya existe un Participante con el mismo NIT ingresado"
                        Return -2
                    End If
                End If

                If aEntidad.NUM_DOCTO <> "" AndAlso aEntidad.TIPO_DOCTO = 1 Then
                    criterios.Clear()
                    criterios.Add(New Criteria("NUM_DOCTO", "=", aEntidad.NUM_DOCTO, ""))

                    listaPart = Me.ObtenerListaPorBusqueda(New PARTICIPANTE, criterios.ToArray())

                    If Not listaPart Is Nothing AndAlso listaPart.Count > 0 Then
                        Me.sError = "No se Puede Agregar el Participante porque ya existe un Participante con el mismo No de CARNET DE MINORIDAD ingresado"
                        Return -4
                    End If
                End If

                If aEntidad.NUM_DOCTO <> "" AndAlso aEntidad.TIPO_DOCTO = 2 Then
                    criterios.Clear()
                    criterios.Add(New Criteria("NUM_DOCTO", "=", aEntidad.NUM_DOCTO, ""))

                    listaPart = Me.ObtenerListaPorBusqueda(New PARTICIPANTE, criterios.ToArray())

                    If Not listaPart Is Nothing AndAlso listaPart.Count > 0 Then
                        Me.sError = "No se Puede Agregar el Participante porque ya existe un Participante con el mismo No de PASAPORTE ingresado"
                        Return -5
                    End If
                End If

                If aEntidad.NUM_DOCTO <> "" AndAlso aEntidad.TIPO_DOCTO = 3 Then
                    criterios.Clear()
                    criterios.Add(New Criteria("NUM_DOCTO", "=", aEntidad.NUM_DOCTO, ""))

                    listaPart = Me.ObtenerListaPorBusqueda(New PARTICIPANTE, criterios.ToArray())

                    If Not listaPart Is Nothing AndAlso listaPart.Count > 0 Then
                        Me.sError = "No se Puede Agregar el Participante porque ya existe un Participante con el mismo No de DOCUMENTO ingresado"
                        Return -6
                    End If
                End If

                If aEntidad.EMAIL <> "" Then
                    criterios.Clear()
                    criterios.Add(New Criteria("EMAIL", "=", aEntidad.EMAIL, ""))

                    listaPart = Me.ObtenerListaPorBusqueda(New PARTICIPANTE, criterios.ToArray())

                    If Not listaPart Is Nothing AndAlso listaPart.Count > 0 Then
                        Me.sError = "No se Puede Agregar el Participante porque ya existe un Participante con el mismo Correo Electronico ingresado"
                        Return -7
                    End If
                End If
                esNuevo = True
            Else

                Dim listaPart As New listaPARTICIPANTE
                Dim criterios As New List(Of Criteria)

                If aEntidad.DUI <> "" Then
                    criterios.Add(New Criteria("DUI", "=", aEntidad.DUI, ""))

                    listaPart = Me.ObtenerListaPorBusqueda(aEntidad, criterios.ToArray())

                    If Not listaPart Is Nothing AndAlso listaPart.Count > 0 Then
                        If listaPart(0).ID_PARTICIPANTE <> aEntidad.ID_PARTICIPANTE Then
                            Me.sError = "No se Puede Actualizar el Participante porque ya existe otro Participante con el mismo DUI ingresado"
                            Return -8
                        End If
                    End If
                End If

                If aEntidad.NIT <> "" Then
                    criterios.Clear()
                    criterios.Add(New Criteria("NIT", "=", aEntidad.NIT, ""))

                    listaPart = Me.ObtenerListaPorBusqueda(aEntidad, criterios.ToArray())

                    If Not listaPart Is Nothing AndAlso listaPart.Count > 0 Then
                        If listaPart(0).ID_PARTICIPANTE <> aEntidad.ID_PARTICIPANTE Then
                            Me.sError = "No se Puede Actualizar el Participante porque ya existe otro Participante con el mismo NIT ingresado"
                            Return -9
                        End If
                    End If
                End If

                If aEntidad.NUM_DOCTO <> "" AndAlso aEntidad.TIPO_DOCTO = 1 Then
                    criterios.Clear()
                    criterios.Add(New Criteria("NUM_DOCTO", "=", aEntidad.NUM_DOCTO, ""))

                    listaPart = Me.ObtenerListaPorBusqueda(aEntidad, criterios.ToArray())

                    If Not listaPart Is Nothing AndAlso listaPart.Count > 1 Then
                        Me.sError = "No se Puede Agregar el Participante porque ya existe un Participante con el mismo No de CARNET DE MINORIDAD ingresado"
                        Return -4
                    End If
                End If

                If aEntidad.NUM_DOCTO <> "" AndAlso aEntidad.TIPO_DOCTO = 2 Then
                    criterios.Clear()
                    criterios.Add(New Criteria("NUM_DOCTO", "=", aEntidad.NUM_DOCTO, ""))

                    listaPart = Me.ObtenerListaPorBusqueda(aEntidad, criterios.ToArray())

                    If Not listaPart Is Nothing AndAlso listaPart.Count > 1 Then
                        Me.sError = "No se Puede Agregar el Participante porque ya existe un Participante con el mismo No de PASAPORTE ingresado"
                        Return -5
                    End If
                End If

                If aEntidad.NUM_DOCTO <> "" AndAlso aEntidad.TIPO_DOCTO = 3 Then
                    criterios.Clear()
                    criterios.Add(New Criteria("NUM_DOCTO", "=", aEntidad.NUM_DOCTO, ""))

                    listaPart = Me.ObtenerListaPorBusqueda(aEntidad, criterios.ToArray())

                    If Not listaPart Is Nothing AndAlso listaPart.Count > 1 Then
                        Me.sError = "No se Puede Agregar el Participante porque ya existe un Participante con el mismo No de DOCUMENTO ingresado"
                        Return -6
                    End If
                End If

                If aEntidad.EMAIL <> "" Then
                    criterios.Clear()
                    criterios.Add(New Criteria("EMAIL", "=", aEntidad.EMAIL, ""))

                    listaPart = Me.ObtenerListaPorBusqueda(aEntidad, criterios.ToArray())

                    If Not listaPart Is Nothing AndAlso listaPart.Count > 1 Then
                        Me.sError = "No se Puede Actualizar el Participante porque ya existe otro Participante con el mismo Correo Electronico ingresado"
                        Return -11
                    End If
                End If
                End If

                Dim liRet As Integer = mDb.Actualizar(aEntidad, aTipoConcurrencia)
                Return liRet
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
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
    ''' <returns>
    '''   -1 : Excepcion no controlada
    '''   -2 : No genero bien la cuenta de Usuario
    '''   -3 : DUI ya existe, no se puede agregar un Nuevo Participante o Actualizar con un DUI existente
    '''   -4 : NIT ya existe, no se puede agregar un Nuevo Participante o Actualizar con un NIT existente
    '''   -5 : ISSS ya existe, no se puede agregar un Nuevo Participante o Actualizar con un ISSS existente
    '''   -6 : EMAIL ya existe, no se puede agregar un Nuevo Participante o Actualizar con un EMAIL existente
    ''' </returns>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' 	[ecarias]	17/03/2010	Se agrego logica para creacion de Cuenta de Usuario
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPARTICIPANTE(ByVal aEntidad As PARTICIPANTE) As Integer
        Return Me.ActualizarPARTICIPANTE(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve Participantes Repetidos por Nombre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	18/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaRepetidosPorNombres() As listaPARTICIPANTE
        Try
            Return mDb.ObtenerListaRepetidosPorNombres()
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve Participantes Repetidos por DUI.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	18/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaRepetidosPorDUI() As listaPARTICIPANTE
        Try
            Return mDb.ObtenerListaRepetidosPorDUI()
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve Participantes Repetidos por NIT.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	18/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaRepetidosPorNIT() As listaPARTICIPANTE
        Try
            Return mDb.ObtenerListaRepetidosPorNIT()
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function CorregirDatosParticipante(ByVal aParticipante As PARTICIPANTE, ByVal idNuevoParticipante As Decimal) As Integer
        Dim lParticipante As New PARTICIPANTES_REPETIDOS
        lParticipante.ID_PARTICIPANTE = aParticipante.ID_PARTICIPANTE
        lParticipante.ID_PARTICIPANTE_NUEVO = idNuevoParticipante
        lParticipante.NOMBRES = aParticipante.NOMBRES
        lParticipante.APELLIDOS = aParticipante.APELLIDOS
        lParticipante.GENERO = aParticipante.GENERO
        lParticipante.ID_PAIS = aParticipante.ID_PAIS
        lParticipante.FECHA_NACIMIENTO = aParticipante.FECHA_NACIMIENTO
        lParticipante.DIRECCION = aParticipante.DIRECCION
        lParticipante.DUI = aParticipante.DUI
        lParticipante.NIT = aParticipante.NIT
        lParticipante.ISSS = aParticipante.ISSS
        lParticipante.TIPO_DOCTO = aParticipante.TIPO_DOCTO
        lParticipante.NUM_DOCTO = aParticipante.NUM_DOCTO
        lParticipante.TELEFONO = aParticipante.TELEFONO
        lParticipante.MOVIL = aParticipante.MOVIL
        lParticipante.EMAIL = aParticipante.EMAIL
        lParticipante.ID_ESTADO_CIVIL = aParticipante.ID_ESTADO_CIVIL
        lParticipante.PROFESION_OFICIO = aParticipante.PROFESION_OFICIO
        lParticipante.OCUPACION_ACTUAL = aParticipante.OCUPACION_ACTUAL
        lParticipante.TITULO_CERTIFICADO_OBTENIDO = aParticipante.TITULO_CERTIFICADO_OBTENIDO
        lParticipante.DEPARTAMENTO_NAC = aParticipante.DEPARTAMENTO_NAC
        lParticipante.MUNICIPIO_NAC = aParticipante.MUNICIPIO_NAC
        lParticipante.CODIGO_DEPARTAMENTO = aParticipante.CODIGO_DEPARTAMENTO
        lParticipante.CODIGO_MUNICIPIO = aParticipante.CODIGO_MUNICIPIO
        lParticipante.ID_NIVEL_ACADEMICO = aParticipante.ID_NIVEL_ACADEMICO
        lParticipante.OTRA_EDUCACION_FORMAL = aParticipante.OTRA_EDUCACION_FORMAL
        lParticipante.CON_DISCAPACIDAD = aParticipante.CON_DISCAPACIDAD
        lParticipante.DISC_OTRA = aParticipante.DISC_OTRA
        lParticipante.LASTUPDATE = aParticipante.LASTUPDATE
        lParticipante.USERID = aParticipante.USERID
        Return mDb.CorregirDatosParticipante(lParticipante, aParticipante)

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve Participantes por NOMBRES y APELLIDOS.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/01/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorNOMBRES_APELLIDOS(ByVal NOMBRES_APELLIDOS As String, Optional ByVal asColumnaOrden As String = "NOMBRES", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE
        Try
            Return mDb.ObtenerListaPorNOMBRES_APELLIDOS(NOMBRES_APELLIDOS, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve Participantes por NOMBRES y APELLIDOS filtrador por la inscripción del PROVEEDOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	14/06/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorNOMBRES_APELLIDOS_InscritosPorProveedor(ByVal ID_PROVEEDOR_AF As Decimal, ByVal NOMBRES_APELLIDOS As String, Optional ByVal asColumnaOrden As String = "NOMBRES", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE
        Try
            Return mDb.ObtenerListaPorNOMBRES_APELLIDOS_InscritosPorProveedor(ID_PROVEEDOR_AF, NOMBRES_APELLIDOS, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve Participantes por NOMBRES y APELLIDOS filtrador por la inscripción del PROVEEDOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	14/06/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal FECHA_NACIMIENTO As String, ByVal ID_PARTICIPANTE As Int32, ByVal DUI As String, ByVal NIT As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE
        Try
            Return mDb.ObtenerListaPorCriterios(NOMBRES, APELLIDOS, FECHA_NACIMIENTO, ID_PARTICIPANTE, DUI, NIT, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function



    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve Participantes por DUI.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/01/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorDUI(ByVal DUI As String, Optional ByVal asColumnaOrden As String = "NOMBRES", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE
        Try
            Return mDb.ObtenerListaPorDUI(DUI, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve Participantes por NIT.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/01/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorNIT(ByVal NIT As String, Optional ByVal asColumnaOrden As String = "NOMBRES", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE
        Try
            Return mDb.ObtenerListaPorNIT(NIT, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve Participantes Exonerados de Documentos de Identificación.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorExoneradoDocumentos(Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "NOMBRES", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE
        Try
            Dim mListaPARTICIPANTE As New listaPARTICIPANTE
            mListaPARTICIPANTE = mDb.ObtenerListaPorExoneradoDocumentos(asColumnaOrden, asTipoOrden)

            If Not mListaPARTICIPANTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As PARTICIPANTE In mListaPARTICIPANTE
                    Try
                        lEntidad.fkCODIGO_DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(lEntidad.CODIGO_DEPARTAMENTO)
                        lEntidad.fkCODIGO_MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(lEntidad.CODIGO_DEPARTAMENTO, lEntidad.CODIGO_MUNICIPIO)
                        'lEntidad.fk = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(lEntidad.CODIGO_DEPARTAMENTO)
                        'lEntidad.fkCODIGO_MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(lEntidad.CODIGO_DEPARTAMENTO, lEntidad.CODIGO_MUNICIPIO)
                    Catch ex As Exception
                    End Try
                Next
            End If

            Return mListaPARTICIPANTE
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por NOMBRES, APELLIDOS y FECHA_NACIMIENTO.
    ''' </summary>
    ''' <param name="NOMBRES"></param>
    ''' <param name="APELLIDOS"></param>
    ''' <param name="FECHA_NACIMIENTO"></param>
    ''' <param name="asColumnaOrden"></param>
    ''' <param name="asTipoOrden"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	13/05/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorNOMBRES_APELLIDOS_FECHANAC(ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal FECHA_NACIMIENTO As Date, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPARTICIPANTE
        Try
            Return mDb.ObtenerListaPorNOMBRES_APELLIDOS_FECHANAC(NOMBRES, APELLIDOS, FECHA_NACIMIENTO, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class

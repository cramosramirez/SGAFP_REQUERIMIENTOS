Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_DL
''' Class	 : DL.dbSOLICITUD_PRESELECCION_EC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla SOLICITUD_PRESELECCION_EC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/08/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbSOLICITUD_PRESELECCION_EC
    Inherits dbBase

#Region " Metodos Generador "

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
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As SOLICITUD_PRESELECCION_EC
        lEntidad = CType(aEntidad, SOLICITUD_PRESELECCION_EC)

        Dim lID As Decimal
        If lEntidad.ID_SOLIC_PRESELEC =  0 _
            Or lEntidad.ID_SOLIC_PRESELEC = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Decimal)

            If lID = -1 Then Return -1

            lEntidad.ID_SOLIC_PRESELEC = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder


        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryUpdate(aEntidad, args, aTipoConcurrencia))

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder


        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_PRESELECCION_EC que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_PRESELECCION_EC que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Eliminar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryDelete(aEntidad, args, aTipoConcurrencia))

        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Recuperar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        strSQL.Append(Me.QuerySelect(aEntidad, args))

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return 0

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, CType(aEntidad,SOLICITUD_PRESELECCION_EC))
            Else
                Return 0
            End If
        Catch ex As Exception 
            Throw ex
        Finally
            dr.Close()
        End Try

        Return 1

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro, ademas de permitir agregar en la Entidad las Foraneas.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As SOLICITUD_PRESELECCION_EC, Optional ByVal aPARTICIPANTE As Boolean = False, Optional ByVal aESTADO_SOLICITUD As Boolean = False, Optional ByVal aGRUPO_SELECCION As Boolean = False, Optional ByVal aTIPO_SELECC As Boolean = False, Optional ByVal aPAIS As Boolean = False, Optional ByVal aESTADO_CIVIL As Boolean = False, Optional ByVal aDEPARTAMENTO As Boolean = False, Optional ByVal aMUNICIPIO As Boolean = False, Optional ByVal aNIVEL_ACADEMICO As Boolean = False, Optional ByVal aTIEMPO_DEJO_ESTUDIAR As Boolean = False, Optional ByVal aMOTIVO_DEJO_ESTU As Boolean = False, Optional ByVal aINGRESO_MES As Boolean = False, Optional ByVal aTIEMPO_NOTRAB As Boolean = False, Optional ByVal aACTI_ECONOMICA As Boolean = False, Optional ByVal aAREA_EMPRESA As Boolean = False, Optional ByVal aMOTIVO_DEJO_TRAB As Boolean = False, Optional ByVal aREFERENCIA As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        If aPARTICIPANTE Or aESTADO_SOLICITUD Or aGRUPO_SELECCION Or aTIPO_SELECC Or aPAIS Or aESTADO_CIVIL Or aDEPARTAMENTO Or aMUNICIPIO Or aNIVEL_ACADEMICO Or aTIEMPO_DEJO_ESTUDIAR Or aMOTIVO_DEJO_ESTU Or aINGRESO_MES Or aTIEMPO_NOTRAB Or aACTI_ECONOMICA Or aAREA_EMPRESA Or aMOTIVO_DEJO_TRAB Or aREFERENCIA Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(SOLICITUD_PRESELECCION_EC), GetType(OracleParameter), strCampos, strWhere, 0, "SOLICITUD_PRESELECCION_EC")
            strSQL.AppendLine("SELECT " + strCampos)
            If aPARTICIPANTE Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PARTICIPANTE, Nothing, GetType(PARTICIPANTE), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aESTADO_SOLICITUD Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ESTADO_SOLICITUD, Nothing, GetType(ESTADO_SOLICITUD), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aGRUPO_SELECCION Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New GRUPO_SELECCION, Nothing, GetType(GRUPO_SELECCION), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPO_SELECC Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPO_SELECC, Nothing, GetType(TIPO_SELECC), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPAIS Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PAIS, Nothing, GetType(PAIS), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aESTADO_CIVIL Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ESTADO_CIVIL, Nothing, GetType(ESTADO_CIVIL), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aDEPARTAMENTO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New DEPARTAMENTO, Nothing, GetType(DEPARTAMENTO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aMUNICIPIO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New MUNICIPIO, Nothing, GetType(MUNICIPIO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aNIVEL_ACADEMICO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New NIVEL_ACADEMICO, Nothing, GetType(NIVEL_ACADEMICO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIEMPO_DEJO_ESTUDIAR Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIEMPO_DEJO_ESTUDIAR, Nothing, GetType(TIEMPO_DEJO_ESTUDIAR), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aMOTIVO_DEJO_ESTU Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New MOTIVO_DEJO_ESTU, Nothing, GetType(MOTIVO_DEJO_ESTU), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aINGRESO_MES Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New INGRESO_MES, Nothing, GetType(INGRESO_MES), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIEMPO_NOTRAB Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIEMPO_NOTRAB, Nothing, GetType(TIEMPO_NOTRAB), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aACTI_ECONOMICA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ACTI_ECONOMICA, Nothing, GetType(ACTI_ECONOMICA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aAREA_EMPRESA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New AREA_EMPRESA, Nothing, GetType(AREA_EMPRESA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aMOTIVO_DEJO_TRAB Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New MOTIVO_DEJO_TRAB, Nothing, GetType(MOTIVO_DEJO_TRAB), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aREFERENCIA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New REFERENCIA, Nothing, GetType(REFERENCIA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM SOLICITUD_PRESELECCION_EC")
            numTabla = 0
            If aPARTICIPANTE Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PARTICIPANTE T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".NIT = SOLICITUD_PRESELECCION_EC.ID_PARTICIPANTE")
            End If
            If aESTADO_SOLICITUD Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ESTADO_SOLICITUD T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ESTADO_SOLICITUD = SOLICITUD_PRESELECCION_EC.ID_ESTADO_SOLICITUD")
            End If
            If aGRUPO_SELECCION Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN GRUPO_SELECCION T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_GRUPO_SELEC = SOLICITUD_PRESELECCION_EC.ID_GRUPO_SELEC")
            End If
            If aTIPO_SELECC Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_SELECC T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO_SELECC = SOLICITUD_PRESELECCION_EC.ID_TIPO_SELECC")
            End If
            If aPAIS Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PAIS T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PAIS = SOLICITUD_PRESELECCION_EC.ID_PAIS")
            End If
            If aESTADO_CIVIL Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ESTADO_CIVIL T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ESTADO_CIVIL = SOLICITUD_PRESELECCION_EC.ID_ESTADO_CIVIL")
            End If
            If aDEPARTAMENTO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN DEPARTAMENTO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIGO_DEPARTAMENTO = SOLICITUD_PRESELECCION_EC.CODIGO_DEPARTAMENTO")
            End If
            If aMUNICIPIO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN MUNICIPIO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIGO_MUNICIPIO = SOLICITUD_PRESELECCION_EC.CODIGO_MUNICIPIO")
            End If
            If aNIVEL_ACADEMICO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN NIVEL_ACADEMICO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_NIVEL_ACADEMICO = SOLICITUD_PRESELECCION_EC.ID_NIVEL_ACADEMICO")
            End If
            If aTIEMPO_DEJO_ESTUDIAR Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIEMPO_DEJO_ESTUDIAR T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIEMPO_DEJO_ESTUDIAR = SOLICITUD_PRESELECCION_EC.ID_TIEMPO_DEJO_ESTUDIAR")
            End If
            If aMOTIVO_DEJO_ESTU Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN MOTIVO_DEJO_ESTU T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_MOTIVO_DEJO_ESTU = SOLICITUD_PRESELECCION_EC.ID_MOTIVO_DEJO_ESTU")
            End If
            If aINGRESO_MES Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN INGRESO_MES T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_INGRESO_MES = SOLICITUD_PRESELECCION_EC.ID_INGRESO_MES AND T" + numTabla.ToString() + ".ID_INGRESO_MES = SOLICITUD_PRESELECCION_EC.ID_ULT_SALARIO_MES")
            End If
            If aTIEMPO_NOTRAB Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIEMPO_NOTRAB T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIEMPO_NOTRAB = SOLICITUD_PRESELECCION_EC.ID_TIEMPO_NOTRAB")
            End If
            If aACTI_ECONOMICA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ACTI_ECONOMICA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ACTI_ECONOMICA = SOLICITUD_PRESELECCION_EC.ID_ACTI_ECONOMICA")
            End If
            If aAREA_EMPRESA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN AREA_EMPRESA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_AREA_EMPRESA = SOLICITUD_PRESELECCION_EC.ID_AREA_EMPRESA")
            End If
            If aMOTIVO_DEJO_TRAB Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN MOTIVO_DEJO_TRAB T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_MOTIVO_DEJO_TRAB = SOLICITUD_PRESELECCION_EC.ID_MOTIVO_DEJO_TRAB")
            End If
            If aREFERENCIA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN REFERENCIA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_REFERENCIA = SOLICITUD_PRESELECCION_EC.ID_REFERENCIA")
            End If
            strSQL.Append(strWhere)
        Else
            strSQL.Append(Me.QuerySelect(aEntidad, args))
        End If

        Dim dr As IDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        If dr Is Nothing Then Return 0

        Try
            If dr.Read() Then
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aPARTICIPANTE Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPARTICIPANTE(dr, aEntidad.fkID_PARTICIPANTE, "T" + numTabla.ToString())
                End If
                If aESTADO_SOLICITUD Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarESTADO_SOLICITUD(dr, aEntidad.fkID_ESTADO_SOLICITUD, "T" + numTabla.ToString())
                End If
                If aGRUPO_SELECCION Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarGRUPO_SELECCION(dr, aEntidad.fkID_GRUPO_SELEC, "T" + numTabla.ToString())
                End If
                If aTIPO_SELECC Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPO_SELECC(dr, aEntidad.fkID_TIPO_SELECC, "T" + numTabla.ToString())
                End If
                If aPAIS Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPAIS(dr, aEntidad.fkID_PAIS, "T" + numTabla.ToString())
                End If
                If aESTADO_CIVIL Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarESTADO_CIVIL(dr, aEntidad.fkID_ESTADO_CIVIL, "T" + numTabla.ToString())
                End If
                If aDEPARTAMENTO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarDEPARTAMENTO(dr, aEntidad.fkCODIGO_DEPARTAMENTO, "T" + numTabla.ToString())
                End If
                If aMUNICIPIO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarMUNICIPIO(dr, aEntidad.fkCODIGO_MUNICIPIO, "T" + numTabla.ToString())
                End If
                If aNIVEL_ACADEMICO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarNIVEL_ACADEMICO(dr, aEntidad.fkID_NIVEL_ACADEMICO, "T" + numTabla.ToString())
                End If
                If aTIEMPO_DEJO_ESTUDIAR Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIEMPO_DEJO_ESTUDIAR(dr, aEntidad.fkID_TIEMPO_DEJO_ESTUDIAR, "T" + numTabla.ToString())
                End If
                If aMOTIVO_DEJO_ESTU Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarMOTIVO_DEJO_ESTU(dr, aEntidad.fkID_MOTIVO_DEJO_ESTU, "T" + numTabla.ToString())
                End If
                If aINGRESO_MES Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarINGRESO_MES(dr, aEntidad.fkID_INGRESO_MES, "T" + numTabla.ToString())
                End If
                If aTIEMPO_NOTRAB Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIEMPO_NOTRAB(dr, aEntidad.fkID_TIEMPO_NOTRAB, "T" + numTabla.ToString())
                End If
                If aACTI_ECONOMICA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarACTI_ECONOMICA(dr, aEntidad.fkID_ACTI_ECONOMICA, "T" + numTabla.ToString())
                End If
                If aAREA_EMPRESA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarAREA_EMPRESA(dr, aEntidad.fkID_AREA_EMPRESA, "T" + numTabla.ToString())
                End If
                If aMOTIVO_DEJO_TRAB Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarMOTIVO_DEJO_TRAB(dr, aEntidad.fkID_MOTIVO_DEJO_TRAB, "T" + numTabla.ToString())
                End If
                If aREFERENCIA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarREFERENCIA(dr, aEntidad.fkID_REFERENCIA, "T" + numTabla.ToString())
                End If
            Else
                Return 0
            End If
        Catch ex As Exception 
            Throw ex
        Finally
            dr.Close()
        End Try

        Return 1

    End Function

    Public Overrides Function ObtenerID(ByVal aEntidad As entidadBase) As Object

        Dim strSQL As New StringBuilder
        strSQL.AppendLine("SELECT NVL(MAX(ID_SOLIC_PRESELEC),0) + 1 ")
        strSQL.AppendLine(" FROM SOLICITUD_PRESELECCION_EC ")

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString())

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre devuelve todos los registros de la Entidad.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Return ds

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("SOLICITUD_PRESELECCION_EC".ToCharArray())

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables)

        Return 1

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve en el StringBuilder que recibe como parámetro el Query
    ''' de la Tabla de la Clase.
    ''' </summary>
    ''' <param name="strSQL">StringBuilder donde se escribe el Query</param>
    ''' <remarks>
    ''' Obsoleto, se recomienda utilizar los métodos del ancestro para esta operación.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT SOLICITUD_PRESELECCION_EC.ID_SOLIC_PRESELEC, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.FECHA_PRESENTACION, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ID_PARTICIPANTE, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ID_ESTADO_SOLICITUD, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ID_GRUPO_SELEC, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ID_TIPO_SELECC, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.NOMBRES, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.APELLIDOS, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.DUI, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.TIPO_DOCTO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.NUM_DOCTO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.NIT, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ISSS, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ID_PAIS, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.DEPARTAMENTO_NAC, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.MUNICIPIO_NAC, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.FECHA_NACIMIENTO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.GENERO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.EDAD, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.MIEMBROS_GRUPO_FAMILIAR, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ID_ESTADO_CIVIL, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ES_JEFE_HOGAR, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.TIENE_HIJOS, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.NO_DE_HIJOS, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.SE_DEDICA_ALGUNA_PROFESION, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.PROFESION_OFICIO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.DIRECCION, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.CODIGO_DEPARTAMENTO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.CODIGO_MUNICIPIO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.TELEFONO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.MOVIL, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.EMAIL, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.CON_DISCAPACIDAD, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.DISC_OTRA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ID_NIVEL_ACADEMICO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.OTRA_EDUCACION_FORMAL, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.TITULO_CERTIFICADO_OBTENIDO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ESTUDIA_ACTUALMENTE, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ID_TIEMPO_DEJO_ESTUDIAR, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ID_MOTIVO_DEJO_ESTU, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.OTRO_MOTIVO_DEJO_ESTU, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.RECIBIO_CURSO_ANTERIOR, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.BENEF_PROM_EMP_ACT, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.BENEF_OBT_EMPLEO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.BENEF_OBT_ING_EXTRA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.BENEF_CAMB_EMP_X_CURSO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.BENEF_TRAB_CTA_PROPIA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.BENEF_OTRO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.RAZON_NO_BENEFICIO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.OCUACT_TRABAJA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.OCUACT_ESTUDIA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.OCUACT_ESTU_TRAB, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.OCUACT_OFICIO_HOGAR, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.OCUACT_BUSCA_TRAB, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.OCUACT_OTRA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.RECIBE_INGRESOS, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.MANERA_OBT_ING_TRABAJO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.MANERA_OBT_ING_BECA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.MANERA_OBT_ING_AYUDA_FAM, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.MANERA_OBT_ING_REMESA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.MANERA_OBT_ING_OTRO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ID_INGRESO_MES, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ID_TIEMPO_NOTRAB, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ID_ACTI_ECONOMICA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ID_AREA_EMPRESA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ID_MOTIVO_DEJO_TRAB, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.EXPFOR_OBTENER_EMPLEO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.EXPFOR_INGRESOS_EXTRAS, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.EXPFOR_TRABAJAR_CTA_PROPIA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.EXPFOR_OTRO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.MOTIVO_ELIGIO_CARRERA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.NOMBRE_REFERENCIA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ID_REFERENCIA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.DIRECCION_REFERENCIA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.DEPARTAMENTO_REFERENCIA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.MUNICIPIO_REFERENCIA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.TELEFONO_REFERENCIA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.MOVIL_REFERENCIA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.EMAIL_REFERENCIA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.SUGERENCIAS, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.USUARIO_CREA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.FECHA_CREACION, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.USUARIO_ACT, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.FECHA_ACT, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.TIPO_EMPLEO_OTRO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.TRABAJO_ANTERIOR, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.PUESTO_DESEMPENO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ID_ULT_SALARIO_MES, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ES_RECLUTA_INICIAL, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.ES_RECLUTA_EXTRA, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.REQUI_AUTORIZACION, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.OBSERVACION_AURIZACION, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.AUTORIZADO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.MOTIVO_AUTORIZADO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.USUARIO_AUTORIZO, ")
        strSQL.AppendLine(" SOLICITUD_PRESELECCION_EC.FECHA_AITORIZA ")
        strSQL.AppendLine(" FROM SOLICITUD_PRESELECCION_EC ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <param name="DUI"></param>
    ''' <param name="NIT"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal, ByVal DUI As String, ByVal NIT As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE ID_PARTICIPANTE = :ID_PARTICIPANTE ") 
        strSQL.Append(" AND DUI = :DUI ") 
        strSQL.Append(" AND NIT = :NIT ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(2) As OracleParameter
        args(0) = New OracleParameter(":ID_PARTICIPANTE", OracleType.Number)
        args(0).Value = ID_PARTICIPANTE
        args(1) = New OracleParameter(":DUI", OracleType.VarChar)
        args(1).Value = DUI
        args(2) = New OracleParameter(":NIT", OracleType.VarChar)
        args(2).Value = NIT

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_ESTADO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorESTADO_SOLICITUD(ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE ID_ESTADO_SOLICITUD = :ID_ESTADO_SOLICITUD ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ESTADO_SOLICITUD", OracleType.Number)
        args(0).Value = ID_ESTADO_SOLICITUD

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_GRUPO_SELEC"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorGRUPO_SELECCION(ByVal ID_GRUPO_SELEC As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE ID_GRUPO_SELEC = :ID_GRUPO_SELEC ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_GRUPO_SELEC", OracleType.Number)
        args(0).Value = ID_GRUPO_SELEC

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_TIPO_SELECC"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_SELECC(ByVal ID_TIPO_SELECC As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE ID_TIPO_SELECC = :ID_TIPO_SELECC ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_TIPO_SELECC", OracleType.Number)
        args(0).Value = ID_TIPO_SELECC

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_PAIS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPAIS(ByVal ID_PAIS As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE ID_PAIS = :ID_PAIS ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_PAIS", OracleType.Number)
        args(0).Value = ID_PAIS

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_ESTADO_CIVIL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorESTADO_CIVIL(ByVal ID_ESTADO_CIVIL As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE ID_ESTADO_CIVIL = :ID_ESTADO_CIVIL ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ESTADO_CIVIL", OracleType.Number)
        args(0).Value = ID_ESTADO_CIVIL

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
        args(0).Value = CODIGO_DEPARTAMENTO

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ") 
        strSQL.Append(" AND CODIGO_MUNICIPIO = :CODIGO_MUNICIPIO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
        args(0).Value = CODIGO_DEPARTAMENTO
        args(1) = New OracleParameter(":CODIGO_MUNICIPIO", OracleType.VarChar)
        args(1).Value = CODIGO_MUNICIPIO

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_NIVEL_ACADEMICO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorNIVEL_ACADEMICO(ByVal ID_NIVEL_ACADEMICO As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE ID_NIVEL_ACADEMICO = :ID_NIVEL_ACADEMICO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_NIVEL_ACADEMICO", OracleType.Number)
        args(0).Value = ID_NIVEL_ACADEMICO

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_TIEMPO_DEJO_ESTUDIAR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIEMPO_DEJO_ESTUDIAR(ByVal ID_TIEMPO_DEJO_ESTUDIAR As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE ID_TIEMPO_DEJO_ESTUDIAR = :ID_TIEMPO_DEJO_ESTUDIAR ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_TIEMPO_DEJO_ESTUDIAR", OracleType.Number)
        args(0).Value = ID_TIEMPO_DEJO_ESTUDIAR

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_MOTIVO_DEJO_ESTU"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorMOTIVO_DEJO_ESTU(ByVal ID_MOTIVO_DEJO_ESTU As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE ID_MOTIVO_DEJO_ESTU = :ID_MOTIVO_DEJO_ESTU ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_MOTIVO_DEJO_ESTU", OracleType.Number)
        args(0).Value = ID_MOTIVO_DEJO_ESTU

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_INGRESO_MES"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorINGRESO_MES(ByVal ID_INGRESO_MES As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE ID_INGRESO_MES = :ID_INGRESO_MES ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_INGRESO_MES", OracleType.Number)
        args(0).Value = ID_INGRESO_MES

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_TIEMPO_NOTRAB"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIEMPO_NOTRAB(ByVal ID_TIEMPO_NOTRAB As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE ID_TIEMPO_NOTRAB = :ID_TIEMPO_NOTRAB ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_TIEMPO_NOTRAB", OracleType.Number)
        args(0).Value = ID_TIEMPO_NOTRAB

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_ACTI_ECONOMICA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorACTI_ECONOMICA(ByVal ID_ACTI_ECONOMICA As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE ID_ACTI_ECONOMICA = :ID_ACTI_ECONOMICA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ACTI_ECONOMICA", OracleType.Number)
        args(0).Value = ID_ACTI_ECONOMICA

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_AREA_EMPRESA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorAREA_EMPRESA(ByVal ID_AREA_EMPRESA As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE ID_AREA_EMPRESA = :ID_AREA_EMPRESA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_AREA_EMPRESA", OracleType.Number)
        args(0).Value = ID_AREA_EMPRESA

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_MOTIVO_DEJO_TRAB"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorMOTIVO_DEJO_TRAB(ByVal ID_MOTIVO_DEJO_TRAB As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE ID_MOTIVO_DEJO_TRAB = :ID_MOTIVO_DEJO_TRAB ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_MOTIVO_DEJO_TRAB", OracleType.Number)
        args(0).Value = ID_MOTIVO_DEJO_TRAB

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_REFERENCIA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorREFERENCIA(ByVal ID_REFERENCIA As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_PRESELECCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_PRESELECCION_EC))
        strSQL.Append(" WHERE ID_REFERENCIA = :ID_REFERENCIA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_REFERENCIA", OracleType.Number)
        args(0).Value = ID_REFERENCIA

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_PRESELECCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_PRESELECCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, mEntidad)
                lista.Add(mEntidad)
            Loop
        Catch ex As Exception
            Throw ex
        Finally
            dr.Close()
        End Try

        Return lista

    End Function

#End Region

#End Region

End Class

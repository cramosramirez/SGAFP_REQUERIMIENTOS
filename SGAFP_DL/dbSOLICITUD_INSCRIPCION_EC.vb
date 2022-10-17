Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_DL
''' Class	 : DL.dbSOLICITUD_INSCRIPCION_EC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla SOLICITUD_INSCRIPCION_EC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/07/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbSOLICITUD_INSCRIPCION_EC
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
    ''' 	[GenApp]	23/07/2019	Created
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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As SOLICITUD_INSCRIPCION_EC
        lEntidad = CType(aEntidad, SOLICITUD_INSCRIPCION_EC)


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
    ''' 	[GenApp]	23/07/2019	Created
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
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_INSCRIPCION_EC que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_INSCRIPCION_EC que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
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
    ''' 	[GenApp]	23/07/2019	Created
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
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_EC(dr, CType(aEntidad,SOLICITUD_INSCRIPCION_EC))
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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As SOLICITUD_INSCRIPCION_EC, Optional ByVal aSOLICITUD_INSCRIPCION_AF As Boolean = False, Optional ByVal aSOLICITUD_PRESELECCION_EC As Boolean = False, Optional ByVal aACTI_ECONOMICA As Boolean = False, Optional ByVal aAREA_EMPRESA As Boolean = False, Optional ByVal aGRUPO_SELECCION As Boolean = False, Optional ByVal aINGRESO_MES As Boolean = False, Optional ByVal aMOTIVO_DEJO_ESTU As Boolean = False, Optional ByVal aMOTIVO_DEJO_TRAB As Boolean = False, Optional ByVal aTIEMPO_NOTRAB As Boolean = False, Optional ByVal aTIPO_SELECC As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        If aSOLICITUD_INSCRIPCION_AF Or aSOLICITUD_PRESELECCION_EC Or aACTI_ECONOMICA Or aAREA_EMPRESA Or aGRUPO_SELECCION Or aINGRESO_MES Or aMOTIVO_DEJO_ESTU Or aMOTIVO_DEJO_TRAB Or aTIEMPO_NOTRAB Or aTIPO_SELECC Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(SOLICITUD_INSCRIPCION_EC), GetType(OracleParameter), strCampos, strWhere, 0, "SOLICITUD_INSCRIPCION_EC")
            strSQL.AppendLine("SELECT " + strCampos)
            If aSOLICITUD_INSCRIPCION_AF Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New SOLICITUD_INSCRIPCION_AF, Nothing, GetType(SOLICITUD_INSCRIPCION_AF), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aSOLICITUD_PRESELECCION_EC Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New SOLICITUD_PRESELECCION_EC, Nothing, GetType(SOLICITUD_PRESELECCION_EC), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
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
            If aGRUPO_SELECCION Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New GRUPO_SELECCION, Nothing, GetType(GRUPO_SELECCION), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aINGRESO_MES Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New INGRESO_MES, Nothing, GetType(INGRESO_MES), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aMOTIVO_DEJO_ESTU Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New MOTIVO_DEJO_ESTU, Nothing, GetType(MOTIVO_DEJO_ESTU), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aMOTIVO_DEJO_TRAB Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New MOTIVO_DEJO_TRAB, Nothing, GetType(MOTIVO_DEJO_TRAB), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIEMPO_NOTRAB Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIEMPO_NOTRAB, Nothing, GetType(TIEMPO_NOTRAB), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPO_SELECC Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPO_SELECC, Nothing, GetType(TIPO_SELECC), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM SOLICITUD_INSCRIPCION_EC")
            numTabla = 0
            If aSOLICITUD_INSCRIPCION_AF Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SOLICITUD_INSCRIPCION_AF T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_SOLICITUD = SOLICITUD_INSCRIPCION_EC.ID_SOLICITUD")
            End If
            If aSOLICITUD_PRESELECCION_EC Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SOLICITUD_PRESELECCION_EC T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_SOLIC_PRESELEC = SOLICITUD_INSCRIPCION_EC.ID_SOLIC_PRESELEC")
            End If
            If aACTI_ECONOMICA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ACTI_ECONOMICA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ACTI_ECONOMICA = SOLICITUD_INSCRIPCION_EC.ID_ACTI_ECONOMICA")
            End If
            If aAREA_EMPRESA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN AREA_EMPRESA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_AREA_EMPRESA = SOLICITUD_INSCRIPCION_EC.ID_AREA_EMPRESA")
            End If
            If aGRUPO_SELECCION Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN GRUPO_SELECCION T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_GRUPO_SELEC = SOLICITUD_INSCRIPCION_EC.ID_GRUPO_SELEC")
            End If
            If aINGRESO_MES Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN INGRESO_MES T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_INGRESO_MES = SOLICITUD_INSCRIPCION_EC.ID_INGRESO_MES AND T" + numTabla.ToString() + ".ID_INGRESO_MES = SOLICITUD_INSCRIPCION_EC.ID_ULT_SALARIO_MES")
            End If
            If aMOTIVO_DEJO_ESTU Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN MOTIVO_DEJO_ESTU T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_MOTIVO_DEJO_ESTU = SOLICITUD_INSCRIPCION_EC.ID_MOTIVO_DEJO_ESTU")
            End If
            If aMOTIVO_DEJO_TRAB Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN MOTIVO_DEJO_TRAB T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_MOTIVO_DEJO_TRAB = SOLICITUD_INSCRIPCION_EC.ID_MOTIVO_DEJO_TRAB")
            End If
            If aTIEMPO_NOTRAB Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIEMPO_NOTRAB T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIEMPO_NOTRAB = SOLICITUD_INSCRIPCION_EC.ID_TIEMPO_NOTRAB")
            End If
            If aTIPO_SELECC Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_SELECC T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO_SELECC = SOLICITUD_INSCRIPCION_EC.ID_TIPO_SELECC")
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
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_EC(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aSOLICITUD_INSCRIPCION_AF Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF(dr, aEntidad.fkID_SOLICITUD, "T" + numTabla.ToString())
                End If
                If aSOLICITUD_PRESELECCION_EC Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSOLICITUD_PRESELECCION_EC(dr, aEntidad.fkID_SOLIC_PRESELEC, "T" + numTabla.ToString())
                End If
                If aACTI_ECONOMICA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarACTI_ECONOMICA(dr, aEntidad.fkID_ACTI_ECONOMICA, "T" + numTabla.ToString())
                End If
                If aAREA_EMPRESA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarAREA_EMPRESA(dr, aEntidad.fkID_AREA_EMPRESA, "T" + numTabla.ToString())
                End If
                If aGRUPO_SELECCION Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarGRUPO_SELECCION(dr, aEntidad.fkID_GRUPO_SELEC, "T" + numTabla.ToString())
                End If
                If aINGRESO_MES Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarINGRESO_MES(dr, aEntidad.fkID_INGRESO_MES, "T" + numTabla.ToString())
                End If
                If aMOTIVO_DEJO_ESTU Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarMOTIVO_DEJO_ESTU(dr, aEntidad.fkID_MOTIVO_DEJO_ESTU, "T" + numTabla.ToString())
                End If
                If aMOTIVO_DEJO_TRAB Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarMOTIVO_DEJO_TRAB(dr, aEntidad.fkID_MOTIVO_DEJO_TRAB, "T" + numTabla.ToString())
                End If
                If aTIEMPO_NOTRAB Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIEMPO_NOTRAB(dr, aEntidad.fkID_TIEMPO_NOTRAB, "T" + numTabla.ToString())
                End If
                If aTIPO_SELECC Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPO_SELECC(dr, aEntidad.fkID_TIPO_SELECC, "T" + numTabla.ToString())
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

        Return -1

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_EC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(-1) As OracleParameter

        Dim dr As IDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_EC(dr, mEntidad)
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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_EC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(-1) As OracleParameter

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_EC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(-1) As OracleParameter

        Dim tables(0) As String
        tables(0) = New String("SOLICITUD_INSCRIPCION_EC".ToCharArray())

        sql.FillDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), ds, tables, args)

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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT SOLICITUD_INSCRIPCION_EC.ID_SOLICITUD, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.ID_SOLIC_PRESELEC, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.ID_ACTI_ECONOMICA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.ID_AREA_EMPRESA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.ID_GRUPO_SELEC, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.ID_INGRESO_MES, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.ID_MOTIVO_DEJO_ESTU, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.ID_MOTIVO_DEJO_TRAB, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.ID_TIEMPO_NOTRAB, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.ID_TIPO_SELECC, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.ID_ULT_SALARIO_MES, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.MANERA_OBT_ING_BECA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.MOTIVO_ELIGIO_CARRERA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.OCUACT_ESTU_TRAB, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.OTRO_MOTIVO_DEJO_ESTU, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.USUARIO_CREA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.USUARIO_ACT, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.FECHA_ACT, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_EC.FECHA_CREACION ")
        strSQL.AppendLine(" FROM SOLICITUD_INSCRIPCION_EC ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' las Columnas de la LLave de la Tabla SOLICITUD_INSCRIPCION_AF.
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSOLICITUD_INSCRIPCION_AF(ByVal ID_SOLICITUD As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_EC))
        strSQL.Append(" WHERE ID_SOLICITUD = :ID_SOLICITUD ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_SOLICITUD", OracleType.Number)
        args(0).Value = ID_SOLICITUD

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_EC(dr, mEntidad)
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
    ''' las Columnas de la LLave de la Tabla SOLICITUD_PRESELECCION_EC.
    ''' </summary>
    ''' <param name="ID_SOLIC_PRESELEC"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSOLICITUD_PRESELECCION_EC(ByVal ID_SOLIC_PRESELEC As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_EC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_EC(dr, mEntidad)
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
    ''' las Columnas de la LLave de la Tabla ACTI_ECONOMICA.
    ''' </summary>
    ''' <param name="ID_ACTI_ECONOMICA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorACTI_ECONOMICA(ByVal ID_ACTI_ECONOMICA As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_EC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_EC(dr, mEntidad)
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
    ''' las Columnas de la LLave de la Tabla AREA_EMPRESA.
    ''' </summary>
    ''' <param name="ID_AREA_EMPRESA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorAREA_EMPRESA(ByVal ID_AREA_EMPRESA As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_EC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_EC(dr, mEntidad)
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
    ''' las Columnas de la LLave de la Tabla GRUPO_SELECCION.
    ''' </summary>
    ''' <param name="ID_GRUPO_SELEC"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorGRUPO_SELECCION(ByVal ID_GRUPO_SELEC As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_EC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_EC(dr, mEntidad)
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
    ''' las Columnas de la LLave de la Tabla INGRESO_MES.
    ''' </summary>
    ''' <param name="ID_INGRESO_MES"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorINGRESO_MES(ByVal ID_INGRESO_MES As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_EC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_EC(dr, mEntidad)
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
    ''' las Columnas de la LLave de la Tabla MOTIVO_DEJO_ESTU.
    ''' </summary>
    ''' <param name="ID_MOTIVO_DEJO_ESTU"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorMOTIVO_DEJO_ESTU(ByVal ID_MOTIVO_DEJO_ESTU As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_EC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_EC(dr, mEntidad)
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
    ''' las Columnas de la LLave de la Tabla MOTIVO_DEJO_TRAB.
    ''' </summary>
    ''' <param name="ID_MOTIVO_DEJO_TRAB"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorMOTIVO_DEJO_TRAB(ByVal ID_MOTIVO_DEJO_TRAB As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_EC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_EC(dr, mEntidad)
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
    ''' las Columnas de la LLave de la Tabla TIEMPO_NOTRAB.
    ''' </summary>
    ''' <param name="ID_TIEMPO_NOTRAB"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIEMPO_NOTRAB(ByVal ID_TIEMPO_NOTRAB As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_EC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_EC(dr, mEntidad)
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
    ''' las Columnas de la LLave de la Tabla TIPO_SELECC.
    ''' </summary>
    ''' <param name="ID_TIPO_SELECC"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_SELECC(ByVal ID_TIPO_SELECC As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_EC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_EC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_EC

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_EC
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_EC(dr, mEntidad)
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

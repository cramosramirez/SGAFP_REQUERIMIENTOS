Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_DL
''' Class	 : DL.dbSOLICITUD_INSCRIPCION_AF_HIST
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla SOLICITUD_INSCRIPCION_AF_HIST
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/09/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbSOLICITUD_INSCRIPCION_AF_HIST
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
    ''' 	[GenApp]	21/09/2010	Created
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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As SOLICITUD_INSCRIPCION_AF_HIST
        lEntidad = CType(aEntidad, SOLICITUD_INSCRIPCION_AF_HIST)

        Dim lID As Decimal
        If lEntidad.ID_SOLICITUD_HIST =  0 _
            Or lEntidad.ID_SOLICITUD_HIST = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Decimal)

            If lID = -1 Then Return -1

            lEntidad.ID_SOLICITUD_HIST = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder

        CType(aEntidad, SOLICITUD_INSCRIPCION_AF_HIST).LASTUPDATE = Now

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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder

        CType(aEntidad, SOLICITUD_INSCRIPCION_AF_HIST).LASTUPDATE = Now

        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_INSCRIPCION_AF_HIST que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_INSCRIPCION_AF_HIST que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
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
    ''' 	[GenApp]	21/09/2010	Created
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
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF_HIST(dr, CType(aEntidad,SOLICITUD_INSCRIPCION_AF_HIST))
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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As SOLICITUD_INSCRIPCION_AF_HIST, Optional ByVal aPARTICIPANTE As Boolean = False, Optional ByVal aACCION_FORMATIVA As Boolean = False, Optional ByVal aESTADO_SOLICITUD As Boolean = False, Optional ByVal aCONTROL_DOCUMENTOS As Boolean = False, Optional ByVal aTIPO_SOLICITUD As Boolean = False, Optional ByVal aEMPRESAS As Boolean = False, Optional ByVal aMUNICIPIO As Boolean = False, Optional ByVal aDEPARTAMENTO As Boolean = False, Optional ByVal aREGION As Boolean = False, Optional ByVal aCIUO As Boolean = False, Optional ByVal aNIVEL_ACADEMICO As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        If aPARTICIPANTE Or aACCION_FORMATIVA Or aESTADO_SOLICITUD Or aCONTROL_DOCUMENTOS Or aTIPO_SOLICITUD Or aEMPRESAS Or aMUNICIPIO Or aDEPARTAMENTO Or aREGION Or aCIUO Or aNIVEL_ACADEMICO Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(SOLICITUD_INSCRIPCION_AF_HIST), GetType(OracleParameter), strCampos, strWhere, 0, "SOLICITUD_INSCRIPCION_AF_HIST")
            strSQL.AppendLine("SELECT " + strCampos)
            If aPARTICIPANTE Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PARTICIPANTE, Nothing, GetType(PARTICIPANTE), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aACCION_FORMATIVA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ACCION_FORMATIVA, Nothing, GetType(ACCION_FORMATIVA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aESTADO_SOLICITUD Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ESTADO_SOLICITUD, Nothing, GetType(ESTADO_SOLICITUD), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aCONTROL_DOCUMENTOS Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CONTROL_DOCUMENTOS, Nothing, GetType(CONTROL_DOCUMENTOS), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aTIPO_SOLICITUD Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPO_SOLICITUD, Nothing, GetType(TIPO_SOLICITUD), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aEMPRESAS Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New EMPRESAS, Nothing, GetType(EMPRESAS), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aMUNICIPIO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New MUNICIPIO, Nothing, GetType(MUNICIPIO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aDEPARTAMENTO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New DEPARTAMENTO, Nothing, GetType(DEPARTAMENTO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aREGION Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New REGION, Nothing, GetType(REGION), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aCIUO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CIUO, Nothing, GetType(CIUO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aNIVEL_ACADEMICO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New NIVEL_ACADEMICO, Nothing, GetType(NIVEL_ACADEMICO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM SOLICITUD_INSCRIPCION_AF_HIST")
            numTabla = 0
            If aPARTICIPANTE Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PARTICIPANTE T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PARTICIPANTE = SOLICITUD_INSCRIPCION_AF_HIST.ID_PARTICIPANTE")
            End If
            If aACCION_FORMATIVA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ACCION_FORMATIVA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ACCION_FORMATIVA = SOLICITUD_INSCRIPCION_AF_HIST.ID_ACCION_FORMATIVA")
            End If
            If aESTADO_SOLICITUD Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ESTADO_SOLICITUD T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ESTADO_SOLICITUD = SOLICITUD_INSCRIPCION_AF_HIST.ID_ESTADO_SOLICITUD")
            End If
            If aCONTROL_DOCUMENTOS Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CONTROL_DOCUMENTOS T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".NUMERO_DOCUMENTO = SOLICITUD_INSCRIPCION_AF_HIST.NUMERO_DOCUMENTO")
            End If
            If aTIPO_SOLICITUD Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_SOLICITUD T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO_SOLICITUD = SOLICITUD_INSCRIPCION_AF_HIST.ID_TIPO_SOLICITUD")
            End If
            If aEMPRESAS Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN EMPRESAS T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".NUMERO_PATRONAL = SOLICITUD_INSCRIPCION_AF_HIST.NUMERO_PATRONAL")
            End If
            If aMUNICIPIO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN MUNICIPIO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIGO_MUNICIPIO = SOLICITUD_INSCRIPCION_AF_HIST.CODIGO_MUNICIPIO")
            End If
            If aDEPARTAMENTO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN DEPARTAMENTO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIGO_DEPARTAMENTO = SOLICITUD_INSCRIPCION_AF_HIST.CODIGO_DEPARTAMENTO")
            End If
            If aREGION Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN REGION T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIGO_REGION = SOLICITUD_INSCRIPCION_AF_HIST.CODIGO_REGION")
            End If
            If aCIUO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CIUO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CIUO = SOLICITUD_INSCRIPCION_AF_HIST.CIUO")
            End If
            If aNIVEL_ACADEMICO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN NIVEL_ACADEMICO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".NIVEL_ACADEMICO = SOLICITUD_INSCRIPCION_AF_HIST.NIVEL_ACADEMICO")
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
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF_HIST(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aPARTICIPANTE Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPARTICIPANTE(dr, aEntidad.fkID_PARTICIPANTE, "T" + numTabla.ToString())
                End If
                If aACCION_FORMATIVA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarACCION_FORMATIVA(dr, aEntidad.fkID_ACCION_FORMATIVA, "T" + numTabla.ToString())
                End If
                If aESTADO_SOLICITUD Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarESTADO_SOLICITUD(dr, aEntidad.fkID_ESTADO_SOLICITUD, "T" + numTabla.ToString())
                End If
                If aCONTROL_DOCUMENTOS Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCONTROL_DOCUMENTOS(dr, aEntidad.fkNUMERO_DOCUMENTO, "T" + numTabla.ToString())
                End If
                If aTIPO_SOLICITUD Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPO_SOLICITUD(dr, aEntidad.fkID_TIPO_SOLICITUD, "T" + numTabla.ToString())
                End If
                If aEMPRESAS Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarEMPRESAS(dr, aEntidad.fkNUMERO_PATRONAL, "T" + numTabla.ToString())
                End If
                If aMUNICIPIO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarMUNICIPIO(dr, aEntidad.fkCODIGO_MUNICIPIO, "T" + numTabla.ToString())
                End If
                If aDEPARTAMENTO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarDEPARTAMENTO(dr, aEntidad.fkCODIGO_DEPARTAMENTO, "T" + numTabla.ToString())
                End If
                If aREGION Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarREGION(dr, aEntidad.fkCODIGO_REGION, "T" + numTabla.ToString())
                End If
                If aCIUO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCIUO(dr, aEntidad.fkCIUO, "T" + numTabla.ToString())
                End If
                If aNIVEL_ACADEMICO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarNIVEL_ACADEMICO(dr, aEntidad.fkNIVEL_ACADEMICO, "T" + numTabla.ToString())
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
        strSQL.Append("SELECT NVL(MAX(ID_SOLICITUD_HIST),0) + 1 ")
        strSQL.Append(" FROM SOLICITUD_INSCRIPCION_AF_HIST ")

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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF_HIST))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF_HIST))
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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF_HIST))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("SOLICITUD_INSCRIPCION_AF_HIST".ToCharArray())

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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT SOLICITUD_INSCRIPCION_AF_HIST.ID_SOLICITUD_HIST, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.ID_SOLICITUD, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.FECHA_PRESENTACION, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.ID_PARTICIPANTE, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.ID_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.ID_ESTADO_SOLICITUD, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.NUMERO_DOCUMENTO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.ID_TIPO_SOLICITUD, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.NIT_EMPRESA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.NOMBRE_EMPRESA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.CARGO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.NUMERO_PATRONAL, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.NOMBRES, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.APELLIDOS, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.LUGAR_NACIMIENTO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.CODIGO_MUNICIPIO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.CODIGO_DEPARTAMENTO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.CODIGO_REGION, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.ZONA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.TELEFONO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.MOVIL, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.FAX, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.EMAIL, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.NIT, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.ISSS, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.CIUO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.EDAD, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.DEPARTAMENTO_NAC, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.MUNICIPIO_NAC, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.FECHA_NACIMIENTO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.DUI, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.GENERO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.DIRECCION, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.PROFESION_OFICIO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.ESTADO_CIVIL, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.NOMBRE_FAMILIAR, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.PARENTESCO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.DIRECCION_FAMILIAR, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.TELEFONO_FAMILIAR, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.OCUACT_TRABAJA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.OCUACT_ESTUDIA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.OCUACT_DESOCUPADO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.OCUACT_OFICIO_HOGAR, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.TIPTRA_EMPLEADO_EMPRESA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.TIPTRA_EMPRESA_PROPIA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.TIPTRA_EVENTUAL, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.TIPTRA_MEDIO_TIEMPO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.TIPTRA_INDEPENDIENTE, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.RTC_OCUPACION_EMPRESA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.RTC_PROPIA_EMPRESA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.RTC_TRABAJO_EVENTUAL, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.RTC_TRABAJO_MEDIO_TIEMPO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.RTC_INDEPENDIENTE, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.RTC_NO_OCUPACION_EMPRESA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.RTC_NO_PROPIA_EMPRESA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.RTC_NO_TRABAJO_EVENTUAL, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.RTC_NO_TRABAJO_MEDIO_TIEMPO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.RTC_NO_INDEPENDIENTE, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.NIVEL_ACADEMICO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.TITULO_CERTIFICADO_OBTENIDO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.TIEMPO_DEJO_ESTUDIAR, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.RECIBIO_CURSO_ANTERIOR, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.OBTUVO_BENEFICIOS_CURSO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.BENEF_PROM_EMP_ACT, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.BENEF_OBT_EMPLEO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.BENEF_OBT_ING_EXTRA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.BENEF_CAMB_EMP_X_CURSO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.BENEF_TRAB_CTA_PROPIA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.BENEF_OTRO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.RAZON_NO_BENEFICIO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.TRABAJA_ACTUALMENTE, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.TRABAJO_ANTERIOR, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.EXPFOR_PROMOCION_EMPLEO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.EXPFOR_CAMBIAR_EMPLEO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.EXPFOR_OBTENER_EMPLEO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.EXPFOR_TRABAJAR_CTA_PROPIA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.EXPFOR_INGRESOS_EXTRAS, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.EXPFOR_OTRO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.INGRESO_MENSUAL_INDIVIDUAL, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.INGRESO_MENSUAL_FAMILIAR, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.MIEMBROS_GRUPO_FAMILIAR, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.SUGERENCIAS, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.LUGAR_PRESENTACION, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.ID_PROVEEDOR_AF, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.USERID_HIST, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.LASTUPDATE_HIST, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.USERID, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF_HIST.LASTUPDATE ")
        strSQL.AppendLine(" FROM SOLICITUD_INSCRIPCION_AF_HIST ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE ID_PARTICIPANTE = :ID_PARTICIPANTE ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_PARTICIPANTE", OracleType.Number)
        args(0).Value = ID_PARTICIPANTE

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        args(0).Value = ID_ACCION_FORMATIVA

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorESTADO_SOLICITUD(ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE ID_ESTADO_SOLICITUD = :ID_ESTADO_SOLICITUD ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ESTADO_SOLICITUD", OracleType.Number)
        args(0).Value = ID_ESTADO_SOLICITUD

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    ''' <param name="NUMERO_DOCUMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCONTROL_DOCUMENTOS(ByVal NUMERO_DOCUMENTO As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE NUMERO_DOCUMENTO = :NUMERO_DOCUMENTO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":NUMERO_DOCUMENTO", OracleType.Number)
        args(0).Value = NUMERO_DOCUMENTO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    ''' <param name="ID_TIPO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_SOLICITUD(ByVal ID_TIPO_SOLICITUD As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE ID_TIPO_SOLICITUD = :ID_TIPO_SOLICITUD ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_TIPO_SOLICITUD", OracleType.Number)
        args(0).Value = ID_TIPO_SOLICITUD

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    ''' <param name="NUMERO_PATRONAL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorEMPRESAS(ByVal NUMERO_PATRONAL As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE NUMERO_PATRONAL = :NUMERO_PATRONAL ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":NUMERO_PATRONAL", OracleType.VarChar)
        args(0).Value = NUMERO_PATRONAL

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <param name="CODIGO_REGION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorMUNICIPIO(ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE CODIGO_MUNICIPIO = :CODIGO_MUNICIPIO ") 
        strSQL.Append(" AND CODIGO_REGION = :CODIGO_REGION ") 
        strSQL.Append(" AND CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(2) As OracleParameter
        args(0) = New OracleParameter(":CODIGO_MUNICIPIO", OracleType.VarChar)
        args(0).Value = CODIGO_MUNICIPIO
        args(1) = New OracleParameter(":CODIGO_REGION", OracleType.VarChar)
        args(1).Value = CODIGO_REGION
        args(2) = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
        args(2).Value = CODIGO_DEPARTAMENTO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    ''' <param name="CODIGO_REGION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorDEPARTAMENTO(ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE CODIGO_REGION = :CODIGO_REGION ") 
        strSQL.Append(" AND CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":CODIGO_REGION", OracleType.VarChar)
        args(0).Value = CODIGO_REGION
        args(1) = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
        args(1).Value = CODIGO_DEPARTAMENTO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    ''' <param name="CODIGO_REGION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorREGION(ByVal CODIGO_REGION As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE CODIGO_REGION = :CODIGO_REGION ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":CODIGO_REGION", OracleType.VarChar)
        args(0).Value = CODIGO_REGION

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    ''' <param name="CIUO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCIUO(ByVal CIUO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE CIUO = :CIUO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":CIUO", OracleType.VarChar)
        args(0).Value = CIUO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    ''' <param name="NIVEL_ACADEMICO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorNIVEL_ACADEMICO(ByVal NIVEL_ACADEMICO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE NIVEL_ACADEMICO = :NIVEL_ACADEMICO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":NIVEL_ACADEMICO", OracleType.VarChar)
        args(0).Value = NIVEL_ACADEMICO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF_HIST(dr, mEntidad)
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

Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_DL
''' Class	 : DL.dbSOLICITUD_INSCRIPCION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla SOLICITUD_INSCRIPCION_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/02/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbSOLICITUD_INSCRIPCION_AF
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
    ''' 	[GenApp]	14/02/2011	Created
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As SOLICITUD_INSCRIPCION_AF
        lEntidad = CType(aEntidad, SOLICITUD_INSCRIPCION_AF)

        Dim lID As Decimal
        If lEntidad.ID_SOLICITUD =  0 _
            Or lEntidad.ID_SOLICITUD = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Decimal)

            If lID = -1 Then Return -1

            lEntidad.ID_SOLICITUD = lID

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
    ''' 	[GenApp]	14/02/2011	Created
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
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_INSCRIPCION_AF que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_INSCRIPCION_AF que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
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
    ''' 	[GenApp]	14/02/2011	Created
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
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF(dr, CType(aEntidad,SOLICITUD_INSCRIPCION_AF))
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As SOLICITUD_INSCRIPCION_AF, Optional ByVal aPARTICIPANTE As Boolean = False, Optional ByVal aACCION_FORMATIVA As Boolean = False, Optional ByVal aESTADO_SOLICITUD As Boolean = False, Optional ByVal aTIPO_SOLICITUD As Boolean = False, Optional ByVal aPAIS As Boolean = False, Optional ByVal aESTADO_CIVIL As Boolean = False, Optional ByVal aEDUC_LEE_ESCRIBE As Boolean = False, Optional ByVal aNIVEL_ACADEMICO As Boolean = False, Optional ByVal aTIEMPO_DEJO_ESTUDIAR As Boolean = False, Optional ByVal aTIPO_EMPLEO As Boolean = False, Optional ByVal aREFERENCIA As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        If aPARTICIPANTE Or aACCION_FORMATIVA Or aESTADO_SOLICITUD Or aTIPO_SOLICITUD Or aPAIS Or aESTADO_CIVIL Or aEDUC_LEE_ESCRIBE Or aNIVEL_ACADEMICO Or aTIEMPO_DEJO_ESTUDIAR Or aTIPO_EMPLEO Or aREFERENCIA Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(SOLICITUD_INSCRIPCION_AF), GetType(OracleParameter), strCampos, strWhere, 0, "SOLICITUD_INSCRIPCION_AF")
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
            If aTIPO_SOLICITUD Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New TIPO_SOLICITUD, Nothing, GetType(TIPO_SOLICITUD), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
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
            If aEDUC_LEE_ESCRIBE Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New EDUC_LEE_ESCRIBE, Nothing, GetType(EDUC_LEE_ESCRIBE), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
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
            If aREFERENCIA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New REFERENCIA, Nothing, GetType(REFERENCIA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM SOLICITUD_INSCRIPCION_AF")
            numTabla = 0
            If aPARTICIPANTE Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PARTICIPANTE T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PARTICIPANTE = SOLICITUD_INSCRIPCION_AF.ID_PARTICIPANTE")
            End If
            If aACCION_FORMATIVA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ACCION_FORMATIVA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ACCION_FORMATIVA = SOLICITUD_INSCRIPCION_AF.ID_ACCION_FORMATIVA")
            End If
            If aESTADO_SOLICITUD Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ESTADO_SOLICITUD T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ESTADO_SOLICITUD = SOLICITUD_INSCRIPCION_AF.ID_ESTADO_SOLICITUD")
            End If
            If aTIPO_SOLICITUD Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_SOLICITUD T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO_SOLICITUD = SOLICITUD_INSCRIPCION_AF.ID_TIPO_SOLICITUD")
            End If
            If aPAIS Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PAIS T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PAIS = SOLICITUD_INSCRIPCION_AF.ID_PAIS")
            End If
            If aESTADO_CIVIL Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ESTADO_CIVIL T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ESTADO_CIVIL = SOLICITUD_INSCRIPCION_AF.ID_ESTADO_CIVIL")
            End If
            If aEDUC_LEE_ESCRIBE Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN EDUC_LEE_ESCRIBE T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_LEE_ESCRIBE = SOLICITUD_INSCRIPCION_AF.ID_LEE_ESCRIBE")
            End If
            If aNIVEL_ACADEMICO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN NIVEL_ACADEMICO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_NIVEL_ACADEMICO = SOLICITUD_INSCRIPCION_AF.ID_NIVEL_ACADEMICO")
            End If
            If aTIEMPO_DEJO_ESTUDIAR Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIEMPO_DEJO_ESTUDIAR T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIEMPO_DEJO_ESTUDIAR = SOLICITUD_INSCRIPCION_AF.ID_TIEMPO_DEJO_ESTUDIAR")
            End If
            If aTIPO_EMPLEO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_EMPLEO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO_EMPLEO = SOLICITUD_INSCRIPCION_AF.ID_TIPO_EMPLEO")
            End If
            If aREFERENCIA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN REFERENCIA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_REFERENCIA = SOLICITUD_INSCRIPCION_AF.ID_REFERENCIA")
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
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF(dr, aEntidad)
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
                If aTIPO_SOLICITUD Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIPO_SOLICITUD(dr, aEntidad.fkID_TIPO_SOLICITUD, "T" + numTabla.ToString())
                End If
                If aPAIS Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPAIS(dr, aEntidad.fkID_PAIS, "T" + numTabla.ToString())
                End If
                If aESTADO_CIVIL Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarESTADO_CIVIL(dr, aEntidad.fkID_ESTADO_CIVIL, "T" + numTabla.ToString())
                End If
                If aEDUC_LEE_ESCRIBE Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarEDUC_LEE_ESCRIBE(dr, aEntidad.fkID_LEE_ESCRIBE, "T" + numTabla.ToString())
                End If
                If aNIVEL_ACADEMICO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarNIVEL_ACADEMICO(dr, aEntidad.fkID_NIVEL_ACADEMICO, "T" + numTabla.ToString())
                End If
                If aTIEMPO_DEJO_ESTUDIAR Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarTIEMPO_DEJO_ESTUDIAR(dr, aEntidad.fkID_TIEMPO_DEJO_ESTUDIAR, "T" + numTabla.ToString())
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
        strSQL.Append("SELECT NVL(MAX(ID_SOLICITUD),0) + 1 ")
        strSQL.Append(" FROM SOLICITUD_INSCRIPCION_AF ")

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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF(dr, mEntidad)
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF))
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("SOLICITUD_INSCRIPCION_AF".ToCharArray())

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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT SOLICITUD_INSCRIPCION_AF.ID_SOLICITUD, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.FECHA_PRESENTACION, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.ID_PARTICIPANTE, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.ID_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.ID_ESTADO_SOLICITUD, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.NOMBRES, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.APELLIDOS, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.DUI, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.TIPO_DOCTO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.NUM_DOCTO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.NIT, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.ISSS, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.ID_TIPO_SOLICITUD, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.ID_PAIS, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.DEPARTAMENTO_NAC, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.MUNICIPIO_NAC, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.FECHA_NACIMIENTO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.GENERO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.EDAD, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.MIEMBROS_GRUPO_FAMILIAR, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.ID_ESTADO_CIVIL, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.ES_JEFE_HOGAR, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.TIENE_HIJOS, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.NO_DE_HIJOS, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.SE_DEDICA_ALGUNA_PROFESION, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.PROFESION_OFICIO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.DIRECCION, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.CODIGO_DEPARTAMENTO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.CODIGO_MUNICIPIO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.TELEFONO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.MOVIL, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.EMAIL, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.CON_DISCAPACIDAD, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.DISC_OTRA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.ID_LEE_ESCRIBE, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.ID_NIVEL_ACADEMICO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.OTRA_EDUCACION_FORMAL, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.TITULO_CERTIFICADO_OBTENIDO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.ESTUDIA_ACTUALMENTE, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.ID_TIEMPO_DEJO_ESTUDIAR, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.RECIBIO_CURSO_ANTERIOR, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.BENEF_PROM_EMP_ACT, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.BENEF_OBT_EMPLEO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.BENEF_OBT_ING_EXTRA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.BENEF_CAMB_EMP_X_CURSO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.BENEF_TRAB_CTA_PROPIA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.BENEF_OTRO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.RAZON_NO_BENEFICIO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.OCUACT_TRABAJA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.OCUACT_ESTUDIA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.OCUACT_DESOCUPADO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.OCUACT_OFICIO_HOGAR, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.OCUACT_BUSCA_TRABAJO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.OCUACT_OTRA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.ID_TIPO_EMPLEO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.TIPO_EMPLEO_OTRO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.SECTOR_EMPLEO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.TRABAJO_ANTERIOR, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.RECIBE_INGRESOS, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.MANERA_OBT_ING_TRABAJO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.MANERA_OBT_ING_AYUDA_FAM, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.MANERA_OBT_ING_REMESA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.MANERA_OBT_ING_PENSION, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.MANERA_OBT_ING_OTRO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.EXPFOR_PROMOCION_EMPLEO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.EXPFOR_CAMBIAR_EMPLEO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.EXPFOR_OBTENER_EMPLEO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.EXPFOR_TRABAJAR_CTA_PROPIA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.EXPFOR_INGRESOS_EXTRAS, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.EXPFOR_NINGUNO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.EXPFOR_OTRO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.CURSO_REL_TRAB_ACTUAL, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.CURSO_REL_TRAB_NUEVO, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.NOMBRE_REFERENCIA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.ID_REFERENCIA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.DIRECCION_REFERENCIA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.DEPARTAMENTO_REFERENCIA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.MUNICIPIO_REFERENCIA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.TELEFONO_REFERENCIA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.MOVIL_REFERENCIA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.EMAIL_REFERENCIA, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.SUGERENCIAS, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.USERID, ")
        strSQL.AppendLine(" SOLICITUD_INSCRIPCION_AF.LASTUPDATE ")
        strSQL.AppendLine(" FROM SOLICITUD_INSCRIPCION_AF ")

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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF))
        strSQL.Append(" WHERE ID_PARTICIPANTE = :ID_PARTICIPANTE ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_PARTICIPANTE", OracleType.Number)
        args(0).Value = ID_PARTICIPANTE

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF
                CargarEntidad(dr, CType(mEntidad, entidadBase))
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF))
        strSQL.Append(" WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        args(0).Value = ID_ACCION_FORMATIVA

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF(dr, mEntidad)
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorESTADO_SOLICITUD(ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF))
        strSQL.Append(" WHERE ID_ESTADO_SOLICITUD = :ID_ESTADO_SOLICITUD ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ESTADO_SOLICITUD", OracleType.Number)
        args(0).Value = ID_ESTADO_SOLICITUD

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF(dr, mEntidad)
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_SOLICITUD(ByVal ID_TIPO_SOLICITUD As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF))
        strSQL.Append(" WHERE ID_TIPO_SOLICITUD = :ID_TIPO_SOLICITUD ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_TIPO_SOLICITUD", OracleType.Number)
        args(0).Value = ID_TIPO_SOLICITUD

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF(dr, mEntidad)
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPAIS(ByVal ID_PAIS As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF))
        strSQL.Append(" WHERE ID_PAIS = :ID_PAIS ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_PAIS", OracleType.Number)
        args(0).Value = ID_PAIS

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF(dr, mEntidad)
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorESTADO_CIVIL(ByVal ID_ESTADO_CIVIL As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF))
        strSQL.Append(" WHERE ID_ESTADO_CIVIL = :ID_ESTADO_CIVIL ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ESTADO_CIVIL", OracleType.Number)
        args(0).Value = ID_ESTADO_CIVIL

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF(dr, mEntidad)
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
    ''' <param name="ID_LEE_ESCRIBE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorEDUC_LEE_ESCRIBE(ByVal ID_LEE_ESCRIBE As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF))
        strSQL.Append(" WHERE ID_LEE_ESCRIBE = :ID_LEE_ESCRIBE ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_LEE_ESCRIBE", OracleType.Number)
        args(0).Value = ID_LEE_ESCRIBE

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF(dr, mEntidad)
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorNIVEL_ACADEMICO(ByVal ID_NIVEL_ACADEMICO As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF))
        strSQL.Append(" WHERE ID_NIVEL_ACADEMICO = :ID_NIVEL_ACADEMICO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_NIVEL_ACADEMICO", OracleType.Number)
        args(0).Value = ID_NIVEL_ACADEMICO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF(dr, mEntidad)
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIEMPO_DEJO_ESTUDIAR(ByVal ID_TIEMPO_DEJO_ESTUDIAR As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF))
        strSQL.Append(" WHERE ID_TIEMPO_DEJO_ESTUDIAR = :ID_TIEMPO_DEJO_ESTUDIAR ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_TIEMPO_DEJO_ESTUDIAR", OracleType.Number)
        args(0).Value = ID_TIEMPO_DEJO_ESTUDIAR

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF(dr, mEntidad)
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
    ''' <param name="ID_TIPO_EMPLEO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorTIPO_EMPLEO(ByVal ID_TIPO_EMPLEO As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF))
        strSQL.Append(" WHERE ID_TIPO_EMPLEO = :ID_TIPO_EMPLEO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_TIPO_EMPLEO", OracleType.Number)
        args(0).Value = ID_TIPO_EMPLEO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF(dr, mEntidad)
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorREFERENCIA(ByVal ID_REFERENCIA As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_INSCRIPCION_AF

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_INSCRIPCION_AF))
        strSQL.Append(" WHERE ID_REFERENCIA = :ID_REFERENCIA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_REFERENCIA", OracleType.Number)
        args(0).Value = ID_REFERENCIA

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_INSCRIPCION_AF

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_INSCRIPCION_AF
                dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF(dr, mEntidad)
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

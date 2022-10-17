Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_DL
''' Class	 : DL.dbSOLIC_INSCRIPCION_AF_HIST
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla SOLIC_INSCRIPCION_AF_HIST
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/02/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbSOLIC_INSCRIPCION_AF_HIST
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

        Dim lEntidad As SOLIC_INSCRIPCION_AF_HIST
        lEntidad = CType(aEntidad, SOLIC_INSCRIPCION_AF_HIST)

        Dim lID As Decimal
        If lEntidad.ID_SOLICITUD_HIST =  0 _
            Or lEntidad.ID_SOLICITUD_HIST = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Decimal)

            If lID = -1 Then Return -1

            lEntidad.ID_SOLICITUD_HIST = lID

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
    ''' Función que Elimina un Registro de la Tabla SOLIC_INSCRIPCION_AF_HIST que se le envía como parámetro.
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
    ''' Función que Elimina un Registro de la Tabla SOLIC_INSCRIPCION_AF_HIST que se le envía como
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
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, CType(aEntidad,SOLIC_INSCRIPCION_AF_HIST))
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
    Public Function RecuperarConForaneas(ByVal aEntidad As SOLIC_INSCRIPCION_AF_HIST, Optional ByVal aSOLICITUD_INSCRIPCION_AF As Boolean = False, Optional ByVal aPARTICIPANTE As Boolean = False, Optional ByVal aACCION_FORMATIVA As Boolean = False, Optional ByVal aESTADO_SOLICITUD As Boolean = False, Optional ByVal aTIPO_SOLICITUD As Boolean = False, Optional ByVal aPAIS As Boolean = False, Optional ByVal aESTADO_CIVIL As Boolean = False, Optional ByVal aDEPARTAMENTO As Boolean = False, Optional ByVal aMUNICIPIO As Boolean = False, Optional ByVal aEDUC_LEE_ESCRIBE As Boolean = False, Optional ByVal aNIVEL_ACADEMICO As Boolean = False, Optional ByVal aTIEMPO_DEJO_ESTUDIAR As Boolean = False, Optional ByVal aTIPO_EMPLEO As Boolean = False, Optional ByVal aREFERENCIA As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        If aSOLICITUD_INSCRIPCION_AF Or aPARTICIPANTE Or aACCION_FORMATIVA Or aESTADO_SOLICITUD Or aTIPO_SOLICITUD Or aPAIS Or aESTADO_CIVIL Or aDEPARTAMENTO Or aMUNICIPIO Or aEDUC_LEE_ESCRIBE Or aNIVEL_ACADEMICO Or aTIEMPO_DEJO_ESTUDIAR Or aTIPO_EMPLEO Or aREFERENCIA Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(SOLIC_INSCRIPCION_AF_HIST), GetType(OracleParameter), strCampos, strWhere, 0, "SOLIC_INSCRIPCION_AF_HIST")
            strSQL.AppendLine("SELECT " + strCampos)
            If aSOLICITUD_INSCRIPCION_AF Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New SOLICITUD_INSCRIPCION_AF, Nothing, GetType(SOLICITUD_INSCRIPCION_AF), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
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
            strSQL.AppendLine("FROM SOLIC_INSCRIPCION_AF_HIST")
            numTabla = 0
            If aSOLICITUD_INSCRIPCION_AF Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SOLICITUD_INSCRIPCION_AF T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_SOLICITUD = SOLIC_INSCRIPCION_AF_HIST.ID_SOLICITUD")
            End If
            If aPARTICIPANTE Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PARTICIPANTE T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PARTICIPANTE = SOLIC_INSCRIPCION_AF_HIST.ID_PARTICIPANTE")
            End If
            If aACCION_FORMATIVA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ACCION_FORMATIVA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ACCION_FORMATIVA = SOLIC_INSCRIPCION_AF_HIST.ID_ACCION_FORMATIVA")
            End If
            If aESTADO_SOLICITUD Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ESTADO_SOLICITUD T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ESTADO_SOLICITUD = SOLIC_INSCRIPCION_AF_HIST.ID_ESTADO_SOLICITUD")
            End If
            If aTIPO_SOLICITUD Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_SOLICITUD T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO_SOLICITUD = SOLIC_INSCRIPCION_AF_HIST.ID_TIPO_SOLICITUD")
            End If
            If aPAIS Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PAIS T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PAIS = SOLIC_INSCRIPCION_AF_HIST.ID_PAIS")
            End If
            If aESTADO_CIVIL Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ESTADO_CIVIL T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ESTADO_CIVIL = SOLIC_INSCRIPCION_AF_HIST.ID_ESTADO_CIVIL")
            End If
            If aDEPARTAMENTO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN DEPARTAMENTO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIGO_DEPARTAMENTO = SOLIC_INSCRIPCION_AF_HIST.CODIGO_DEPARTAMENTO")
            End If
            If aMUNICIPIO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN MUNICIPIO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIGO_MUNICIPIO = SOLIC_INSCRIPCION_AF_HIST.CODIGO_MUNICIPIO")
            End If
            If aEDUC_LEE_ESCRIBE Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN EDUC_LEE_ESCRIBE T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_LEE_ESCRIBE = SOLIC_INSCRIPCION_AF_HIST.ID_LEE_ESCRIBE")
            End If
            If aNIVEL_ACADEMICO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN NIVEL_ACADEMICO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_NIVEL_ACADEMICO = SOLIC_INSCRIPCION_AF_HIST.ID_NIVEL_ACADEMICO")
            End If
            If aTIEMPO_DEJO_ESTUDIAR Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIEMPO_DEJO_ESTUDIAR T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIEMPO_DEJO_ESTUDIAR = SOLIC_INSCRIPCION_AF_HIST.ID_TIEMPO_DEJO_ESTUDIAR")
            End If
            If aTIPO_EMPLEO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN TIPO_EMPLEO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_TIPO_EMPLEO = SOLIC_INSCRIPCION_AF_HIST.ID_TIPO_EMPLEO")
            End If
            If aREFERENCIA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN REFERENCIA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_REFERENCIA = SOLIC_INSCRIPCION_AF_HIST.ID_REFERENCIA")
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
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aSOLICITUD_INSCRIPCION_AF Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSOLICITUD_INSCRIPCION_AF(dr, aEntidad.fkID_SOLICITUD, "T" + numTabla.ToString())
                End If
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
                If aDEPARTAMENTO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarDEPARTAMENTO(dr, aEntidad.fkCODIGO_DEPARTAMENTO, "T" + numTabla.ToString())
                End If
                If aMUNICIPIO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarMUNICIPIO(dr, aEntidad.fkCODIGO_MUNICIPIO, "T" + numTabla.ToString())
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
        strSQL.Append("SELECT NVL(MAX(ID_SOLICITUD_HIST),0) + 1 ")
        strSQL.Append(" FROM SOLIC_INSCRIPCION_AF_HIST ")

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
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaSOLIC_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, mEntidad)
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
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
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
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("SOLIC_INSCRIPCION_AF_HIST".ToCharArray())

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

        strSQL.AppendLine(" SELECT SOLIC_INSCRIPCION_AF_HIST.ID_SOLICITUD_HIST, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.ID_SOLICITUD, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.FECHA_PRESENTACION, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.ID_PARTICIPANTE, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.ID_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.ID_ESTADO_SOLICITUD, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.NOMBRES, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.APELLIDOS, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.DUI, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.TIPO_DOCTO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.NUM_DOCTO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.NIT, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.ISSS, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.ID_TIPO_SOLICITUD, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.ID_PAIS, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.DEPARTAMENTO_NAC, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.MUNICIPIO_NAC, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.FECHA_NACIMIENTO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.GENERO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.EDAD, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.MIEMBROS_GRUPO_FAMILIAR, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.ID_ESTADO_CIVIL, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.ES_JEFE_HOGAR, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.TIENE_HIJOS, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.NO_DE_HIJOS, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.SE_DEDICA_ALGUNA_PROFESION, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.PROFESION_OFICIO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.DIRECCION, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.CODIGO_DEPARTAMENTO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.CODIGO_MUNICIPIO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.TELEFONO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.MOVIL, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.EMAIL, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.CON_DISCAPACIDAD, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.DISC_OTRA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.ID_LEE_ESCRIBE, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.ID_NIVEL_ACADEMICO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.OTRA_EDUCACION_FORMAL, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.TITULO_CERTIFICADO_OBTENIDO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.ESTUDIA_ACTUALMENTE, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.ID_TIEMPO_DEJO_ESTUDIAR, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.RECIBIO_CURSO_ANTERIOR, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.BENEF_PROM_EMP_ACT, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.BENEF_OBT_EMPLEO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.BENEF_OBT_ING_EXTRA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.BENEF_CAMB_EMP_X_CURSO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.BENEF_TRAB_CTA_PROPIA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.BENEF_OTRO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.RAZON_NO_BENEFICIO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.OCUACT_TRABAJA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.OCUACT_ESTUDIA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.OCUACT_DESOCUPADO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.OCUACT_OFICIO_HOGAR, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.OCUACT_BUSCA_TRABAJO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.OCUACT_OTRA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.ID_TIPO_EMPLEO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.SECTOR_EMPLEO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.TRABAJO_ANTERIOR, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.RECIBE_INGRESOS, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.MANERA_OBT_ING_TRABAJO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.MANERA_OBT_ING_AYUDA_FAM, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.MANERA_OBT_ING_REMESA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.MANERA_OBT_ING_PENSION, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.MANERA_OBT_ING_OTRO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.EXPFOR_PROMOCION_EMPLEO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.EXPFOR_CAMBIAR_EMPLEO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.EXPFOR_OBTENER_EMPLEO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.EXPFOR_TRABAJAR_CTA_PROPIA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.EXPFOR_INGRESOS_EXTRAS, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.EXPFOR_NINGUNO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.EXPFOR_OTRO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.CURSO_REL_TRAB_ACTUAL, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.CURSO_REL_TRAB_NUEVO, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.NOMBRE_REFERENCIA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.ID_REFERENCIA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.DIRECCION_REFERENCIA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.DEPARTAMENTO_REFERENCIA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.MUNICIPIO_REFERENCIA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.TELEFONO_REFERENCIA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.MOVIL_REFERENCIA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.EMAIL_REFERENCIA, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.SUGERENCIAS, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.USERID, ")
        strSQL.AppendLine(" SOLIC_INSCRIPCION_AF_HIST.LASTUPDATE ")
        strSQL.AppendLine(" FROM SOLIC_INSCRIPCION_AF_HIST ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSOLICITUD_INSCRIPCION_AF(ByVal ID_SOLICITUD As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE ID_SOLICITUD = :ID_SOLICITUD ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_SOLICITUD", OracleType.Number)
        args(0).Value = ID_SOLICITUD

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE ID_PARTICIPANTE = :ID_PARTICIPANTE ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_PARTICIPANTE", OracleType.Number)
        args(0).Value = ID_PARTICIPANTE

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    Public Function ObtenerListaPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        args(0).Value = ID_ACCION_FORMATIVA

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    Public Function ObtenerListaPorESTADO_SOLICITUD(ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE ID_ESTADO_SOLICITUD = :ID_ESTADO_SOLICITUD ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ESTADO_SOLICITUD", OracleType.Number)
        args(0).Value = ID_ESTADO_SOLICITUD

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    Public Function ObtenerListaPorTIPO_SOLICITUD(ByVal ID_TIPO_SOLICITUD As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE ID_TIPO_SOLICITUD = :ID_TIPO_SOLICITUD ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_TIPO_SOLICITUD", OracleType.Number)
        args(0).Value = ID_TIPO_SOLICITUD

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    Public Function ObtenerListaPorPAIS(ByVal ID_PAIS As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE ID_PAIS = :ID_PAIS ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_PAIS", OracleType.Number)
        args(0).Value = ID_PAIS

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    Public Function ObtenerListaPorESTADO_CIVIL(ByVal ID_ESTADO_CIVIL As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE ID_ESTADO_CIVIL = :ID_ESTADO_CIVIL ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ESTADO_CIVIL", OracleType.Number)
        args(0).Value = ID_ESTADO_CIVIL

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    ''' <param name="CODIGO_REGION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_REGION As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ") 
        strSQL.Append(" AND CODIGO_REGION = :CODIGO_REGION ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
        args(0).Value = CODIGO_DEPARTAMENTO
        args(1) = New OracleParameter(":CODIGO_REGION", OracleType.VarChar)
        args(1).Value = CODIGO_REGION

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
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

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    Public Function ObtenerListaPorEDUC_LEE_ESCRIBE(ByVal ID_LEE_ESCRIBE As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE ID_LEE_ESCRIBE = :ID_LEE_ESCRIBE ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_LEE_ESCRIBE", OracleType.Number)
        args(0).Value = ID_LEE_ESCRIBE

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    Public Function ObtenerListaPorNIVEL_ACADEMICO(ByVal ID_NIVEL_ACADEMICO As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE ID_NIVEL_ACADEMICO = :ID_NIVEL_ACADEMICO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_NIVEL_ACADEMICO", OracleType.Number)
        args(0).Value = ID_NIVEL_ACADEMICO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    Public Function ObtenerListaPorTIEMPO_DEJO_ESTUDIAR(ByVal ID_TIEMPO_DEJO_ESTUDIAR As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE ID_TIEMPO_DEJO_ESTUDIAR = :ID_TIEMPO_DEJO_ESTUDIAR ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_TIEMPO_DEJO_ESTUDIAR", OracleType.Number)
        args(0).Value = ID_TIEMPO_DEJO_ESTUDIAR

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    Public Function ObtenerListaPorTIPO_EMPLEO(ByVal ID_TIPO_EMPLEO As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE ID_TIPO_EMPLEO = :ID_TIPO_EMPLEO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_TIPO_EMPLEO", OracleType.Number)
        args(0).Value = ID_TIPO_EMPLEO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, mEntidad)
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
    Public Function ObtenerListaPorREFERENCIA(ByVal ID_REFERENCIA As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLIC_INSCRIPCION_AF_HIST

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLIC_INSCRIPCION_AF_HIST))
        strSQL.Append(" WHERE ID_REFERENCIA = :ID_REFERENCIA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_REFERENCIA", OracleType.Number)
        args(0).Value = ID_REFERENCIA

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLIC_INSCRIPCION_AF_HIST

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLIC_INSCRIPCION_AF_HIST
                dbAsignarEntidades.AsignarSOLIC_INSCRIPCION_AF_HIST(dr, mEntidad)
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

Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_DL
''' Class	 : DL.dbPARTICIPANTE_EXONERADO_DOC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla PARTICIPANTE_EXONERADO_DOC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/11/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbPARTICIPANTE_EXONERADO_DOC
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
    ''' 	[GenApp]	19/11/2012	Created
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
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As PARTICIPANTE_EXONERADO_DOC
        lEntidad = CType(aEntidad, PARTICIPANTE_EXONERADO_DOC)

        Dim lID As Decimal
        If lEntidad.ID_PARTICIPANTE_EXONERADO = 0 _
            Or lEntidad.ID_PARTICIPANTE_EXONERADO = Nothing Then

            lID = CType(Me.ObtenerID(lEntidad), Decimal)

            If lID = -1 Then Return -1

            lEntidad.ID_PARTICIPANTE_EXONERADO = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder

        CType(aEntidad, PARTICIPANTE_EXONERADO_DOC).LASTUPDATE = Now
        CType(aEntidad, PARTICIPANTE_EXONERADO_DOC).USERID = EL.configuracion.usuarioActualiza

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
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder

        CType(aEntidad, PARTICIPANTE_EXONERADO_DOC).LASTUPDATE = Now
        CType(aEntidad, PARTICIPANTE_EXONERADO_DOC).USERID = EL.configuracion.usuarioActualiza

        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PARTICIPANTE_EXONERADO_DOC que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PARTICIPANTE_EXONERADO_DOC que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
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
    ''' 	[GenApp]	19/11/2012	Created
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
                dbAsignarEntidades.AsignarPARTICIPANTE_EXONERADO_DOC(dr, CType(aEntidad,PARTICIPANTE_EXONERADO_DOC))
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
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As PARTICIPANTE_EXONERADO_DOC, Optional ByVal aPARTICIPANTE As Boolean = False, Optional ByVal aPROVEEDOR_AF As Boolean = False, Optional ByVal aSITIO_CAPACITACION As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        If aPARTICIPANTE Or aPROVEEDOR_AF Or aSITIO_CAPACITACION Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(PARTICIPANTE_EXONERADO_DOC), GetType(OracleParameter), strCampos, strWhere, 0, "PARTICIPANTE_EXONERADO_DOC")
            strSQL.AppendLine("SELECT " + strCampos)
            If aPARTICIPANTE Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PARTICIPANTE, Nothing, GetType(PARTICIPANTE), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPROVEEDOR_AF Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PROVEEDOR_AF, Nothing, GetType(PROVEEDOR_AF), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aSITIO_CAPACITACION Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New SITIO_CAPACITACION, Nothing, GetType(SITIO_CAPACITACION), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM PARTICIPANTE_EXONERADO_DOC")
            numTabla = 0
            If aPARTICIPANTE Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PARTICIPANTE T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PARTICIPANTE = PARTICIPANTE_EXONERADO_DOC.ID_PARTICIPANTE")
            End If
            If aPROVEEDOR_AF Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PROVEEDOR_AF T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PROVEEDOR_AF = PARTICIPANTE_EXONERADO_DOC.ID_PROVEEDOR_AF")
            End If
            If aSITIO_CAPACITACION Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN SITIO_CAPACITACION T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_SITIO_CAPACITACION = PARTICIPANTE_EXONERADO_DOC.ID_SITIO_CAPACITACION")
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
                dbAsignarEntidades.AsignarPARTICIPANTE_EXONERADO_DOC(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aPARTICIPANTE Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPARTICIPANTE(dr, aEntidad.fkID_PARTICIPANTE, "T" + numTabla.ToString())
                End If
                If aPROVEEDOR_AF Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPROVEEDOR_AF(dr, aEntidad.fkID_PROVEEDOR_AF, "T" + numTabla.ToString())
                End If
                If aSITIO_CAPACITACION Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarSITIO_CAPACITACION(dr, aEntidad.fkID_SITIO_CAPACITACION, "T" + numTabla.ToString())
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
        strSQL.Append("SELECT NVL(MAX(ID_PARTICIPANTE_EXONERADO),0) + 1 ")
        strSQL.Append(" FROM PARTICIPANTE_EXONERADO_DOC ")

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
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPARTICIPANTE_EXONERADO_DOC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PARTICIPANTE_EXONERADO_DOC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(-1) As OracleParameter

        Dim dr As IDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPARTICIPANTE_EXONERADO_DOC

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE_EXONERADO_DOC
                dbAsignarEntidades.AsignarPARTICIPANTE_EXONERADO_DOC(dr, mEntidad)
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
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PARTICIPANTE_EXONERADO_DOC))
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
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PARTICIPANTE_EXONERADO_DOC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(-1) As OracleParameter

        Dim tables(0) As String
        tables(0) = New String("PARTICIPANTE_EXONERADO_DOC".ToCharArray())

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
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT PARTICIPANTE_EXONERADO_DOC.ID_PARTICIPANTE, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.USERID, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.LASTUPDATE, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.ID_PROVEEDOR_AF, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.ID_SITIO_CAPACITACION, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.NOMBRES, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.APELLIDOS, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.FECHA_NACIMIENTO, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.GENERO, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.CODIGO_DEPARTAMENTO, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.CODIGO_MUNICIPIO, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.DEPARTAMENTO_NAC, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.MUNICIPIO_NAC, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.DIRECCION, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.TELEFONO, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.MOVIL, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.CON_DISCAPACIDAD, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.EMAIL, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.ID_NIVEL_ACADEMICO, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.ID_PAIS, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.ID_ESTADO_CIVIL, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.FECHA_INGRESO, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.USUARIO_EVALUA, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.FECHA_EVALUA, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.ESTADO, ")
        strSQL.AppendLine(" PARTICIPANTE_EXONERADO_DOC.ID_PARTICIPANTE_EXONERADO ")
        strSQL.AppendLine(" FROM PARTICIPANTE_EXONERADO_DOC ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' las Columnas de la LLave de la Tabla PARTICIPANTE.
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPARTICIPANTE_EXONERADO_DOC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PARTICIPANTE_EXONERADO_DOC))
        strSQL.Append(" WHERE ID_PARTICIPANTE = :ID_PARTICIPANTE ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_PARTICIPANTE", OracleType.Number)
        args(0).Value = ID_PARTICIPANTE

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPARTICIPANTE_EXONERADO_DOC

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE_EXONERADO_DOC
                dbAsignarEntidades.AsignarPARTICIPANTE_EXONERADO_DOC(dr, mEntidad)
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
    ''' las Columnas de la LLave de la Tabla PROVEEDOR_AF.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPARTICIPANTE_EXONERADO_DOC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PARTICIPANTE_EXONERADO_DOC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPARTICIPANTE_EXONERADO_DOC

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE_EXONERADO_DOC
                dbAsignarEntidades.AsignarPARTICIPANTE_EXONERADO_DOC(dr, mEntidad)
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
    ''' las Columnas de la LLave de la Tabla SITIO_CAPACITACION.
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaPARTICIPANTE_EXONERADO_DOC

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New PARTICIPANTE_EXONERADO_DOC))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaPARTICIPANTE_EXONERADO_DOC

        Try
            Do While dr.Read()
                Dim mEntidad As New PARTICIPANTE_EXONERADO_DOC
                dbAsignarEntidades.AsignarPARTICIPANTE_EXONERADO_DOC(dr, mEntidad)
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

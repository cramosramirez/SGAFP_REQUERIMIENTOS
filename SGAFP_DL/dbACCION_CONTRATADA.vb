Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_DL
''' Class	 : DL.dbACCION_CONTRATADA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla ACCION_CONTRATADA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/02/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbACCION_CONTRATADA
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
    ''' 	[GenApp]	16/02/2022	Created
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
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As ACCION_CONTRATADA
        lEntidad = CType(aEntidad, ACCION_CONTRATADA)

        Dim lID As Decimal
        If lEntidad.ID_ACCION_CONTRATADA =  0 _
            Or lEntidad.ID_ACCION_CONTRATADA = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Decimal)

            If lID = -1 Then Return -1

            lEntidad.ID_ACCION_CONTRATADA = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder

        CType(aEntidad, ACCION_CONTRATADA).LASTUPDATE = Now
        CType(aEntidad, ACCION_CONTRATADA).USERID = EL.configuracion.usuarioActualiza

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
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder

        CType(aEntidad, ACCION_CONTRATADA).LASTUPDATE = Now
        CType(aEntidad, ACCION_CONTRATADA).USERID = EL.configuracion.usuarioActualiza

        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ACCION_CONTRATADA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ACCION_CONTRATADA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/02/2022	Created
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
    ''' 	[GenApp]	16/02/2022	Created
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
                dbAsignarEntidades.AsignarACCION_CONTRATADA(dr, CType(aEntidad,ACCION_CONTRATADA))
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
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As ACCION_CONTRATADA, Optional ByVal aCONTRATO_BOLPROS As Boolean = False, Optional ByVal aDEPARTAMENTO As Boolean = False, Optional ByVal aMUNICIPIO As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        If aCONTRATO_BOLPROS Or aDEPARTAMENTO Or aMUNICIPIO Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(ACCION_CONTRATADA), GetType(OracleParameter), strCampos, strWhere, 0, "ACCION_CONTRATADA")
            strSQL.AppendLine("SELECT " + strCampos)
            If aCONTRATO_BOLPROS Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CONTRATO_BOLPROS, Nothing, GetType(CONTRATO_BOLPROS), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
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
            strSQL.AppendLine("FROM ACCION_CONTRATADA")
            numTabla = 0
            If aCONTRATO_BOLPROS Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CONTRATO_BOLPROS T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CONTRATO = ACCION_CONTRATADA.ID_CONTRATO")
            End If
            If aDEPARTAMENTO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN DEPARTAMENTO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIGO_DEPARTAMENTO = ACCION_CONTRATADA.CODIGO_DEPARTAMENTO")
            End If
            If aMUNICIPIO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN MUNICIPIO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".CODIGO_MUNICIPIO = ACCION_CONTRATADA.CODIGO_MUNICIPIO")
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
                dbAsignarEntidades.AsignarACCION_CONTRATADA(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aCONTRATO_BOLPROS Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCONTRATO_BOLPROS(dr, aEntidad.fkID_CONTRATO, "T" + numTabla.ToString())
                End If
                If aDEPARTAMENTO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarDEPARTAMENTO(dr, aEntidad.fkCODIGO_DEPARTAMENTO, "T" + numTabla.ToString())
                End If
                If aMUNICIPIO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarMUNICIPIO(dr, aEntidad.fkCODIGO_MUNICIPIO, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT NVL(MAX(ID_ACCION_CONTRATADA),0) + 1 ")
        strSQL.AppendLine(" FROM ACCION_CONTRATADA ")

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
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaACCION_CONTRATADA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ACCION_CONTRATADA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaACCION_CONTRATADA

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_CONTRATADA
                dbAsignarEntidades.AsignarACCION_CONTRATADA(dr, mEntidad)
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
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ACCION_CONTRATADA))
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
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ACCION_CONTRATADA))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("ACCION_CONTRATADA".ToCharArray())

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
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT ACCION_CONTRATADA.ID_ACCION_CONTRATADA, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.ID_CONTRATO, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.CODIGO_DEPARTAMENTO, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.CODIGO_MUNICIPIO, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.CODIGO_PROGRAMA, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.DURACION, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.CANT_CURSOS, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.USUARIO_CREACION, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.FECHA_CREACION, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.USERID, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.LASTUPDATE, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.NUM_ITEM, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.MONTO, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.NO_CONVOCATORIA, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.COSTO_PARTICIPANTE, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.NOMBRE_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.COSTO_HORA, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.COSTO_VISITA, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.CODIGO_CATEG, ")
        strSQL.AppendLine(" ACCION_CONTRATADA.NOMBRE_CATEG ")
        strSQL.AppendLine(" FROM ACCION_CONTRATADA ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_CONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCONTRATO_BOLPROS(ByVal ID_CONTRATO As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaACCION_CONTRATADA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ACCION_CONTRATADA))
        strSQL.Append(" WHERE ID_CONTRATO = :ID_CONTRATO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_CONTRATO", OracleType.Number)
        args(0).Value = ID_CONTRATO

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaACCION_CONTRATADA

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_CONTRATADA
                dbAsignarEntidades.AsignarACCION_CONTRATADA(dr, mEntidad)
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
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaACCION_CONTRATADA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ACCION_CONTRATADA))
        strSQL.Append(" WHERE CODIGO_DEPARTAMENTO = :CODIGO_DEPARTAMENTO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":CODIGO_DEPARTAMENTO", OracleType.VarChar)
        args(0).Value = CODIGO_DEPARTAMENTO

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaACCION_CONTRATADA

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_CONTRATADA
                dbAsignarEntidades.AsignarACCION_CONTRATADA(dr, mEntidad)
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
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaACCION_CONTRATADA

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New ACCION_CONTRATADA))
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

        Dim lista As New listaACCION_CONTRATADA

        Try
            Do While dr.Read()
                Dim mEntidad As New ACCION_CONTRATADA
                dbAsignarEntidades.AsignarACCION_CONTRATADA(dr, mEntidad)
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

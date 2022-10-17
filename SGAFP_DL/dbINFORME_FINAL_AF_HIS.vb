Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_DL
''' Class	 : DL.dbINFORME_FINAL_AF_HIS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla INFORME_FINAL_AF_HIS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/07/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbINFORME_FINAL_AF_HIS
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
    ''' 	[GenApp]	20/07/2012	Created
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
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As INFORME_FINAL_AF_HIS
        lEntidad = CType(aEntidad, INFORME_FINAL_AF_HIS)

        Dim lID As Decimal
        If lEntidad.ID_INFORME_FINAL_HIS =  0 _
            Or lEntidad.ID_INFORME_FINAL_HIS = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Decimal)

            If lID = -1 Then Return -1

            lEntidad.ID_INFORME_FINAL_HIS = lID

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
    ''' 	[GenApp]	20/07/2012	Created
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
    ''' Función que Elimina un Registro de la Tabla INFORME_FINAL_AF_HIS que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla INFORME_FINAL_AF_HIS que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
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
    ''' 	[GenApp]	20/07/2012	Created
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
                dbAsignarEntidades.AsignarINFORME_FINAL_AF_HIS(dr, CType(aEntidad,INFORME_FINAL_AF_HIS))
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
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As INFORME_FINAL_AF_HIS, Optional ByVal aINFORME_FINAL_AF As Boolean = False, Optional ByVal aACCION_FORMATIVA As Boolean = False, Optional ByVal aPROVEEDOR_AF As Boolean = False, Optional ByVal aESTADO_INFORME_AF As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        If aINFORME_FINAL_AF Or aACCION_FORMATIVA Or aPROVEEDOR_AF Or aESTADO_INFORME_AF Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(INFORME_FINAL_AF_HIS), GetType(OracleParameter), strCampos, strWhere, 0, "INFORME_FINAL_AF_HIS")
            strSQL.AppendLine("SELECT " + strCampos)
            If aINFORME_FINAL_AF Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New INFORME_FINAL_AF, Nothing, GetType(INFORME_FINAL_AF), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aACCION_FORMATIVA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ACCION_FORMATIVA, Nothing, GetType(ACCION_FORMATIVA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPROVEEDOR_AF Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PROVEEDOR_AF, Nothing, GetType(PROVEEDOR_AF), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aESTADO_INFORME_AF Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New ESTADO_INFORME_AF, Nothing, GetType(ESTADO_INFORME_AF), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM INFORME_FINAL_AF_HIS")
            numTabla = 0
            If aINFORME_FINAL_AF Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN INFORME_FINAL_AF T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_INFORME_FINAL = INFORME_FINAL_AF_HIS.ID_INFORME_FINAL")
            End If
            If aACCION_FORMATIVA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ACCION_FORMATIVA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ACCION_FORMATIVA = INFORME_FINAL_AF_HIS.ID_ACCION_FORMATIVA")
            End If
            If aPROVEEDOR_AF Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PROVEEDOR_AF T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PROVEEDOR_AF = INFORME_FINAL_AF_HIS.ID_PROVEEDOR_AF")
            End If
            If aESTADO_INFORME_AF Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN ESTADO_INFORME_AF T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_ESTADO_INFORME = INFORME_FINAL_AF_HIS.ID_ESTADO_INFORME")
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
                dbAsignarEntidades.AsignarINFORME_FINAL_AF_HIS(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aINFORME_FINAL_AF Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarINFORME_FINAL_AF(dr, aEntidad.fkID_INFORME_FINAL, "T" + numTabla.ToString())
                End If
                If aACCION_FORMATIVA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarACCION_FORMATIVA(dr, aEntidad.fkID_ACCION_FORMATIVA, "T" + numTabla.ToString())
                End If
                If aPROVEEDOR_AF Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPROVEEDOR_AF(dr, aEntidad.fkID_PROVEEDOR_AF, "T" + numTabla.ToString())
                End If
                If aESTADO_INFORME_AF Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarESTADO_INFORME_AF(dr, aEntidad.fkID_ESTADO_INFORME, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT NVL(MAX(ID_INFORME_FINAL_HIS),0) + 1 ")
        strSQL.AppendLine(" FROM INFORME_FINAL_AF_HIS ")

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
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF_HIS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New INFORME_FINAL_AF_HIS))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaINFORME_FINAL_AF_HIS

        Try
            Do While dr.Read()
                Dim mEntidad As New INFORME_FINAL_AF_HIS
                dbAsignarEntidades.AsignarINFORME_FINAL_AF_HIS(dr, mEntidad)
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
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New INFORME_FINAL_AF_HIS))
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
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New INFORME_FINAL_AF_HIS))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("INFORME_FINAL_AF_HIS".ToCharArray())

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
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT INFORME_FINAL_AF_HIS.ID_INFORME_FINAL_HIS, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.ID_INFORME_FINAL, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.ID_ACCION_FORMATIVA, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.ID_PROVEEDOR_AF, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.FECHA_INFORME, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.NUMERO_FACTURA, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.ELABORADO_POR, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.MONTO_FACTURA, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.MONTO_APROBADO, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.PARTICIPANTES_INSCRITOS, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.PARTICIPANTES_FINALES, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.PORC_PROM_ASISTENCIA, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.NOTA_PROMEDIO, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.COMENTARIOS, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.USUARIO_APROBACION, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.LASTUPDATE, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.USERID, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.ID_ESTADO_INFORME, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.HORAS_DESARROLLADAS, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.FECHA_INICIAL, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.FECHA_FINAL, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.HORARIO, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.COSTO_X_HORA, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.MONTO_PAGO_INICIAL, ")
        strSQL.AppendLine(" INFORME_FINAL_AF_HIS.USUARIO_ASIGNADO ")
        strSQL.AppendLine(" FROM INFORME_FINAL_AF_HIS ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_INFORME_FINAL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    '''     [cramos]    15/08/2012  Se agrega lógica para adicionar el estado actual del Informe de Ejecución
    '''                             al histórico de Informes
    ''' </history>
    ''' -----------------------------------------------------------------------------            
    Public Function ObtenerListaPorINFORME_FINAL_AF(ByVal ID_INFORME_FINAL As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF_HIS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New INFORME_FINAL_AF_HIS))
        strSQL.Append(" WHERE ID_INFORME_FINAL = :ID_INFORME_FINAL ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_INFORME_FINAL", OracleType.Number)
        args(0).Value = ID_INFORME_FINAL

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaINFORME_FINAL_AF_HIS

        Try
            Do While dr.Read()
                Dim mEntidad As New INFORME_FINAL_AF_HIS
                dbAsignarEntidades.AsignarINFORME_FINAL_AF_HIS(dr, mEntidad)
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
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF_HIS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New INFORME_FINAL_AF_HIS))
        strSQL.Append(" WHERE ID_ACCION_FORMATIVA = :ID_ACCION_FORMATIVA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ACCION_FORMATIVA", OracleType.Number)
        args(0).Value = ID_ACCION_FORMATIVA

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaINFORME_FINAL_AF_HIS

        Try
            Do While dr.Read()
                Dim mEntidad As New INFORME_FINAL_AF_HIS
                dbAsignarEntidades.AsignarINFORME_FINAL_AF_HIS(dr, mEntidad)
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
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF_HIS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New INFORME_FINAL_AF_HIS))
        strSQL.Append(" WHERE ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
        args(0).Value = ID_PROVEEDOR_AF

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaINFORME_FINAL_AF_HIS

        Try
            Do While dr.Read()
                Dim mEntidad As New INFORME_FINAL_AF_HIS
                dbAsignarEntidades.AsignarINFORME_FINAL_AF_HIS(dr, mEntidad)
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
    ''' <param name="ID_ESTADO_INFORME"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorESTADO_INFORME_AF(ByVal ID_ESTADO_INFORME As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF_HIS

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New INFORME_FINAL_AF_HIS))
        strSQL.Append(" WHERE ID_ESTADO_INFORME = :ID_ESTADO_INFORME ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_ESTADO_INFORME", OracleType.Number)
        args(0).Value = ID_ESTADO_INFORME

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaINFORME_FINAL_AF_HIS

        Try
            Do While dr.Read()
                Dim mEntidad As New INFORME_FINAL_AF_HIS
                dbAsignarEntidades.AsignarINFORME_FINAL_AF_HIS(dr, mEntidad)
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

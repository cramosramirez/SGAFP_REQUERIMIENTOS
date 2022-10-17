Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_DL
''' Class	 : DL.dbTECNICOS_SITIOS_ASIG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla TECNICOS_SITIOS_ASIG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/06/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbTECNICOS_SITIOS_ASIG
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
    ''' 	[GenApp]	01/06/2010	Created
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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As New TECNICOS_SITIOS_ASIG
        lEntidad.USUARIO = CType(aEntidad, TECNICOS_SITIOS_ASIG).USUARIO
        lEntidad.ID_SITIO_CAPACITACION = CType(aEntidad, TECNICOS_SITIOS_ASIG).ID_SITIO_CAPACITACION
        lEntidad.ID_PROVEEDOR_AF = CType(aEntidad, TECNICOS_SITIOS_ASIG).ID_PROVEEDOR_AF

        Dim liRet As Integer = Me.Recuperar(lEntidad)
        If liRet < 1 Then
            Return Agregar(aEntidad)
        End If

        Dim strSQL As New StringBuilder

        CType(aEntidad, TECNICOS_SITIOS_ASIG).LASTUPDATE = Now

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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder

        CType(aEntidad, TECNICOS_SITIOS_ASIG).LASTUPDATE = Now

        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla TECNICOS_SITIOS_ASIG que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla TECNICOS_SITIOS_ASIG que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
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
    ''' 	[GenApp]	01/06/2010	Created
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
                dbAsignarEntidades.AsignarTECNICOS_SITIOS_ASIG(dr, CType(aEntidad, TECNICOS_SITIOS_ASIG))
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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As TECNICOS_SITIOS_ASIG, Optional ByVal aUSUARIO As Boolean = False, Optional ByVal aPROVEEDOR_AF As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        If aUSUARIO Or aPROVEEDOR_AF Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(TECNICOS_SITIOS_ASIG), GetType(OracleParameter), strCampos, strWhere, 0, "TECNICOS_SITIOS_ASIG")
            strSQL.AppendLine("SELECT " + strCampos)
            If aUSUARIO Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New USUARIO, Nothing, GetType(USUARIO), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPROVEEDOR_AF Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PROVEEDOR_AF, Nothing, GetType(PROVEEDOR_AF), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM TECNICOS_SITIOS_ASIG")
            numTabla = 0
            If aUSUARIO Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN USUARIO T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".USUARIO = TECNICOS_SITIOS_ASIG.USUARIO")
            End If
            If aPROVEEDOR_AF Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PROVEEDOR_AF T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PROVEEDOR_AF = TECNICOS_SITIOS_ASIG.ID_PROVEEDOR_AF")
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
                dbAsignarEntidades.AsignarTECNICOS_SITIOS_ASIG(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aUSUARIO Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarUSUARIO(dr, aEntidad.fkUSUARIO, "T" + numTabla.ToString())
                End If
                If aPROVEEDOR_AF Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPROVEEDOR_AF(dr, aEntidad.fkID_PROVEEDOR_AF, "T" + numTabla.ToString())
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

        Dim lEntidad As TECNICOS_SITIOS_ASIG
        lEntidad = CType(aEntidad, TECNICOS_SITIOS_ASIG)

        Dim strSQL As New StringBuilder
        strSQL.Append("SELECT NVL(MAX(ID_SITIO_CAPACITACION),0) + 1 ")
        strSQL.Append(" FROM TECNICOS_SITIOS_ASIG ")
        strSQL.Append(" WHERE USUARIO = :USUARIO ") 
        strSQL.Append(" AND ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ") 

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":USUARIO", OracleType.VarChar)
        args(0).Value = lEntidad.USUARIO
        args(1) = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
        args(1).Value = lEntidad.ID_PROVEEDOR_AF

        Return sql.ExecuteScalar(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal USUARIO As String, ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaTECNICOS_SITIOS_ASIG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New TECNICOS_SITIOS_ASIG))
        strSQL.Append(" WHERE USUARIO = :USUARIO ") 
        strSQL.Append(" AND ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":USUARIO", OracleType.VarChar)
        args(0).Value = USUARIO
        args(1) = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
        args(1).Value = ID_PROVEEDOR_AF

        Dim dr As OracleDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaTECNICOS_SITIOS_ASIG

        Try
            Do While dr.Read()
                Dim mEntidad As New TECNICOS_SITIOS_ASIG
                dbAsignarEntidades.AsignarTECNICOS_SITIOS_ASIG(dr, mEntidad)
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
    ''' <param name="USUARIO"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal USUARIO As String, ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New TECNICOS_SITIOS_ASIG))
        strSQL.Append(" WHERE USUARIO = :USUARIO ") 
        strSQL.Append(" AND ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":USUARIO", OracleType.VarChar)
        args(0).Value = USUARIO
        args(1) = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
        args(1).Value = ID_PROVEEDOR_AF

        Dim ds As DataSet

        ds = sql.ExecuteDataSet(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Return ds

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal USUARIO As String, ByVal ID_PROVEEDOR_AF As Decimal, ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New TECNICOS_SITIOS_ASIG))
        strSQL.Append(" WHERE USUARIO = :USUARIO ") 
        strSQL.Append(" AND ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(1) As OracleParameter
        args(0) = New OracleParameter(":USUARIO", OracleType.VarChar)
        args(0).Value = USUARIO
        args(1) = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
        args(1).Value = ID_PROVEEDOR_AF

        Dim tables(0) As String
        tables(0) = New String("TECNICOS_SITIOS_ASIG".ToCharArray())

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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT TECNICOS_SITIOS_ASIG.USUARIO, ")
        strSQL.AppendLine(" TECNICOS_SITIOS_ASIG.ID_PROVEEDOR_AF, ")
        strSQL.AppendLine(" TECNICOS_SITIOS_ASIG.ID_SITIO_CAPACITACION, ")
        strSQL.AppendLine(" TECNICOS_SITIOS_ASIG.USERID, ")
        strSQL.AppendLine(" TECNICOS_SITIOS_ASIG.LASTUPDATE ")
        strSQL.AppendLine(" FROM TECNICOS_SITIOS_ASIG ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorUSUARIO(ByVal USUARIO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaTECNICOS_SITIOS_ASIG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New TECNICOS_SITIOS_ASIG))
        strSQL.Append(" WHERE USUARIO = :USUARIO ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":USUARIO", OracleType.VarChar)
        args(0).Value = USUARIO

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaTECNICOS_SITIOS_ASIG

        Try
            Do While dr.Read()
                Dim mEntidad As New TECNICOS_SITIOS_ASIG
                dbAsignarEntidades.AsignarTECNICOS_SITIOS_ASIG(dr, mEntidad)
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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaTECNICOS_SITIOS_ASIG

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New TECNICOS_SITIOS_ASIG))
        strSQL.Append(" WHERE ID_PROVEEDOR_AF = :ID_PROVEEDOR_AF ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_PROVEEDOR_AF", OracleType.Number)
        args(0).Value = ID_PROVEEDOR_AF

        Dim dr As OracleDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaTECNICOS_SITIOS_ASIG

        Try
            Do While dr.Read()
                Dim mEntidad As New TECNICOS_SITIOS_ASIG
                dbAsignarEntidades.AsignarTECNICOS_SITIOS_ASIG(dr, mEntidad)
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

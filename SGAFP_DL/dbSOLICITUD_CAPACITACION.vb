Imports System.Text
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_DL
''' Class	 : DL.dbSOLICITUD_CAPACITACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Acceso a Datos que contiene las operaciones CRUD(Create, Read,
''' Update y Delete) de la tabla SOLICITUD_CAPACITACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/10/2016	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class dbSOLICITUD_CAPACITACION
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
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Actualizar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Actualizar(aEntidad, TipoConcurrencia.Optimistica)
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
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overloads Function Actualizar(ByVal aEntidad As entidadBase, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer

        Dim lEntidad As SOLICITUD_CAPACITACION
        lEntidad = CType(aEntidad, SOLICITUD_CAPACITACION)

        Dim lID As Decimal
        If lEntidad.ID_SOLICITUD =  0 _
            Or lEntidad.ID_SOLICITUD = Nothing Then 

            lID = CType(Me.ObtenerID(lEntidad), Decimal)

            If lID = -1 Then Return -1

            lEntidad.ID_SOLICITUD = lID

            Return Agregar(lEntidad)

        End If

        Dim strSQL As New StringBuilder

        CType(aEntidad, SOLICITUD_CAPACITACION).LASTUPDATE = Now
        CType(aEntidad, SOLICITUD_CAPACITACION).USERID = EL.configuracion.usuarioActualiza

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
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Agregar(ByVal aEntidad As entidadBase) As Integer

        Dim strSQL As New StringBuilder

        CType(aEntidad, SOLICITUD_CAPACITACION).LASTUPDATE = Now
        CType(aEntidad, SOLICITUD_CAPACITACION).USERID = EL.configuracion.usuarioActualiza

        Dim args(0) As OracleParameter

        strSQL.Append(Me.QueryInsert(aEntidad, args))


        Return sql.ExecuteNonQuery(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_CAPACITACION que se le envía como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <remarks>Por defecto manda a ejecutar eliminación con concurrencia pesimistica.
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Overrides Function Eliminar(ByVal aEntidad As entidadBase) As Integer
        Return Me.Eliminar(aEntidad, TipoConcurrencia.Pesimistica)
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_CAPACITACION que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde viene se obtienen los valores de la llave 
    ''' primaria del registro a eliminar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el 
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
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
    ''' 	[GenApp]	19/10/2016	Created
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
                dbAsignarEntidades.AsignarSOLICITUD_CAPACITACION(dr, CType(aEntidad,SOLICITUD_CAPACITACION))
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
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function RecuperarConForaneas(ByVal aEntidad As SOLICITUD_CAPACITACION, Optional ByVal aREFERENTE As Boolean = False, Optional ByVal aCENTRO_RESPONSABILIDAD As Boolean = False, Optional ByVal aUNIDAD_ORGANIZATIVA As Boolean = False, Optional ByVal aPROGRAMA_FORMACION As Boolean = False, Optional ByVal aPROYECTO_FORMACION As Boolean = False) As Integer

        Dim strSQL As New StringBuilder
        Dim args(0) As OracleParameter

        If aREFERENTE Or aCENTRO_RESPONSABILIDAD Or aUNIDAD_ORGANIZATIVA Or aPROGRAMA_FORMACION Or aPROYECTO_FORMACION Then
            Dim numTabla As Integer = 0
            Dim strCampos, strWhere As String
            strCampos = ""
            strWhere = ""
            Me.QuerySelectCampos(aEntidad, args, GetType(SOLICITUD_CAPACITACION), GetType(OracleParameter), strCampos, strWhere, 0, "SOLICITUD_CAPACITACION")
            strSQL.AppendLine("SELECT " + strCampos)
            If aREFERENTE Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New REFERENTE, Nothing, GetType(REFERENTE), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aCENTRO_RESPONSABILIDAD Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New CENTRO_RESPONSABILIDAD, Nothing, GetType(CENTRO_RESPONSABILIDAD), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aUNIDAD_ORGANIZATIVA Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New UNIDAD_ORGANIZATIVA, Nothing, GetType(UNIDAD_ORGANIZATIVA), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPROGRAMA_FORMACION Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PROGRAMA_FORMACION, Nothing, GetType(PROGRAMA_FORMACION), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            If aPROYECTO_FORMACION Then
                numTabla += 1
                Dim str As String = ""
                Me.QuerySelectCampos(New PROYECTO_FORMACION, Nothing, GetType(PROYECTO_FORMACION), Nothing, str, "", 0, "T" + numTabla.ToString(), "T" + numTabla.ToString() + "_")
                strSQL.AppendLine(", " + str)
            End If
            strSQL.AppendLine("FROM SOLICITUD_CAPACITACION")
            numTabla = 0
            If aREFERENTE Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN REFERENTE T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_REFERENTE = SOLICITUD_CAPACITACION.ID_REFERENTE")
            End If
            If aCENTRO_RESPONSABILIDAD Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN CENTRO_RESPONSABILIDAD T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_CENTRO_RESPONSABILIDAD = SOLICITUD_CAPACITACION.ID_CENTRO_RESPONSABILIDAD")
            End If
            If aUNIDAD_ORGANIZATIVA Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN UNIDAD_ORGANIZATIVA T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_UNIDAD_ORGANIZATIVA = SOLICITUD_CAPACITACION.ID_UNIDAD_ORGANIZATIVA")
            End If
            If aPROGRAMA_FORMACION Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PROGRAMA_FORMACION T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PROGRAMA_FORMACION = SOLICITUD_CAPACITACION.ID_PROGRAMA_FORMACION")
            End If
            If aPROYECTO_FORMACION Then
                numTabla += 1
                strSQL.AppendLine(" INNER JOIN PROYECTO_FORMACION T" + numTabla.ToString())
                 strSQL.Append(" ON T" + numTabla.ToString() + ".ID_PROYECTO_FORMACION = SOLICITUD_CAPACITACION.ID_PROYECTO_FORMACION")
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
                dbAsignarEntidades.AsignarSOLICITUD_CAPACITACION(dr, aEntidad)
                Dim numTabla As Integer = 0
                If aREFERENTE Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarREFERENTE(dr, aEntidad.fkID_REFERENTE, "T" + numTabla.ToString())
                End If
                If aCENTRO_RESPONSABILIDAD Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarCENTRO_RESPONSABILIDAD(dr, aEntidad.fkID_CENTRO_RESPONSABILIDAD, "T" + numTabla.ToString())
                End If
                If aUNIDAD_ORGANIZATIVA Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarUNIDAD_ORGANIZATIVA(dr, aEntidad.fkID_UNIDAD_ORGANIZATIVA, "T" + numTabla.ToString())
                End If
                If aPROGRAMA_FORMACION Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPROGRAMA_FORMACION(dr, aEntidad.fkID_PROGRAMA_FORMACION, "T" + numTabla.ToString())
                End If
                If aPROYECTO_FORMACION Then
                    numTabla += 1
                    dbAsignarEntidades.AsignarPROYECTO_FORMACION(dr, aEntidad.fkID_PROYECTO_FORMACION, "T" + numTabla.ToString())
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
        strSQL.AppendLine("SELECT NVL(MAX(ID_SOLICITUD),0) + 1 ")
        strSQL.AppendLine(" FROM SOLICITUD_CAPACITACION ")

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
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_CAPACITACION

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_CAPACITACION))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim dr As IDataReader

        dr = OracleHelper.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString())

        Dim lista As New listaSOLICITUD_CAPACITACION

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_CAPACITACION
                dbAsignarEntidades.AsignarSOLICITUD_CAPACITACION(dr, mEntidad)
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
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_CAPACITACION))
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
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetPorID(ByRef ds as DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_CAPACITACION))
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim tables(0) As String
        tables(0) = New String("SOLICITUD_CAPACITACION".ToCharArray())

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
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub SelectTabla(ByRef strSQL as StringBuilder)

        strSQL.AppendLine(" SELECT SOLICITUD_CAPACITACION.ID_SOLICITUD, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.ID_REFERENTE, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.ID_CENTRO_RESPONSABILIDAD, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.ID_UNIDAD_ORGANIZATIVA, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.ID_PROGRAMA_FORMACION, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.ID_PROYECTO_FORMACION, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.FECHA_SOLICITUD, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.OBJETIVO_CAPACITACION, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.HORARIO, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.TELEF1, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.TELEF2, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.TELEF3, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.TELEF_MOVIL, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.FAX, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.NOMBRES_CONTACTO, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.APELLIDOS_CONTACTO, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.EMAIL_CONTACTO, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.USERID, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.LASTUPDATE, ")
        strSQL.AppendLine(" SOLICITUD_CAPACITACION.PORC_PAGO_INFORME1 ")
        strSQL.AppendLine(" FROM SOLICITUD_CAPACITACION ")

    End Sub

#Region "Obtener Listas Por Foraneas"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_REFERENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorREFERENTE(ByVal ID_REFERENTE As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_CAPACITACION

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_CAPACITACION))
        strSQL.Append(" WHERE ID_REFERENTE = :ID_REFERENTE ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_REFERENTE", OracleType.Number)
        args(0).Value = ID_REFERENTE

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_CAPACITACION

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_CAPACITACION
                dbAsignarEntidades.AsignarSOLICITUD_CAPACITACION(dr, mEntidad)
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
    ''' <param name="ID_CENTRO_RESPONSABILIDAD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCENTRO_RESPONSABILIDAD(ByVal ID_CENTRO_RESPONSABILIDAD As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_CAPACITACION

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_CAPACITACION))
        strSQL.Append(" WHERE ID_CENTRO_RESPONSABILIDAD = :ID_CENTRO_RESPONSABILIDAD ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_CENTRO_RESPONSABILIDAD", OracleType.Number)
        args(0).Value = ID_CENTRO_RESPONSABILIDAD

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_CAPACITACION

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_CAPACITACION
                dbAsignarEntidades.AsignarSOLICITUD_CAPACITACION(dr, mEntidad)
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
    ''' <param name="ID_UNIDAD_ORGANIZATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorUNIDAD_ORGANIZATIVA(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_CAPACITACION

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_CAPACITACION))
        strSQL.Append(" WHERE ID_UNIDAD_ORGANIZATIVA = :ID_UNIDAD_ORGANIZATIVA ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_UNIDAD_ORGANIZATIVA", OracleType.Number)
        args(0).Value = ID_UNIDAD_ORGANIZATIVA

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_CAPACITACION

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_CAPACITACION
                dbAsignarEntidades.AsignarSOLICITUD_CAPACITACION(dr, mEntidad)
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
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROGRAMA_FORMACION(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_CAPACITACION

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_CAPACITACION))
        strSQL.Append(" WHERE ID_PROGRAMA_FORMACION = :ID_PROGRAMA_FORMACION ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_PROGRAMA_FORMACION", OracleType.Number)
        args(0).Value = ID_PROGRAMA_FORMACION

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_CAPACITACION

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_CAPACITACION
                dbAsignarEntidades.AsignarSOLICITUD_CAPACITACION(dr, mEntidad)
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
    ''' <param name="ID_PROYECTO_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorPROYECTO_FORMACION(ByVal ID_PROYECTO_FORMACION As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As listaSOLICITUD_CAPACITACION

        Dim strSQL As New StringBuilder
        strSQL.Append(Me.QuerySelect(New SOLICITUD_CAPACITACION))
        strSQL.Append(" WHERE ID_PROYECTO_FORMACION = :ID_PROYECTO_FORMACION ") 
        If asColumnaOrden <> "" Then
            strSQL.Append(" Order By " + asColumnaOrden + " " + asTipoOrden) 
        End If

        Dim args(0) As OracleParameter
        args(0) = New OracleParameter(":ID_PROYECTO_FORMACION", OracleType.Number)
        args(0).Value = ID_PROYECTO_FORMACION

        Dim dr As IDataReader

        dr = sql.ExecuteReader(Me.cnnStr, CommandType.Text, strSQL.ToString(), args)

        Dim lista As New listaSOLICITUD_CAPACITACION

        Try
            Do While dr.Read()
                Dim mEntidad As New SOLICITUD_CAPACITACION
                dbAsignarEntidades.AsignarSOLICITUD_CAPACITACION(dr, mEntidad)
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

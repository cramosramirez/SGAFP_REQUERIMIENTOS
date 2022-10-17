Partial Public Class cREFERENTE
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
    ''' 	[GenApp]	05/10/2012	Created
    '''     [cramos]	10/10/2012	Lógica para setear a Mayúsculas y quitar acentos
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarREFERENTE(ByVal aEntidad As REFERENTE) As Integer
        Try
            NormalizarREFERENTE(aEntidad)
            Return mDb.Actualizar(aEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarREFERENTE(ByVal aEntidad As REFERENTE, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            NormalizarREFERENTE(aEntidad)
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Private Sub NormalizarREFERENTE(ByRef lEntidad As REFERENTE)
        lEntidad.NOMBRE_REFERENTE = Utilerias.ReemplazarAcentos(lEntidad.NOMBRE_REFERENTE.ToUpper)
        lEntidad.DIRECCION_REFERENTE = Utilerias.ReemplazarAcentos(lEntidad.DIRECCION_REFERENTE.ToUpper)
        lEntidad.NOMBRE_CONTACTO = Utilerias.ReemplazarAcentos(lEntidad.NOMBRE_CONTACTO.ToUpper)
        lEntidad.APELLIDOS_CONTACTO = Utilerias.ReemplazarAcentos(lEntidad.APELLIDOS_CONTACTO.ToUpper)
        lEntidad.EMAIL_CONTACTO = lEntidad.EMAIL_CONTACTO.ToLower
    End Sub
End Class

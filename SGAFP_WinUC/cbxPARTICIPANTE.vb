Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlPARTICIPANTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla PARTICIPANTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/06/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxPARTICIPANTE
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cPARTICIPANTE
        Dim Lista As New listaPARTICIPANTE

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRES"
        Me.ValueMember = "ID_PARTICIPANTE"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla PAIS .
    ''' </summary>
    ''' <param name="ID_PAIS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPAIS(ByVal ID_PAIS As Decimal)
        Dim miComponente As New cPARTICIPANTE
        Dim Lista As New listaPARTICIPANTE

        Lista = miComponente.ObtenerListaPorPAIS(ID_PAIS)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRES"
        Me.ValueMember = "ID_PARTICIPANTE"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla ESTADO_CIVIL .
    ''' </summary>
    ''' <param name="ID_ESTADO_CIVIL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorESTADO_CIVIL(ByVal ID_ESTADO_CIVIL As Decimal)
        Dim miComponente As New cPARTICIPANTE
        Dim Lista As New listaPARTICIPANTE

        Lista = miComponente.ObtenerListaPorESTADO_CIVIL(ID_ESTADO_CIVIL)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRES"
        Me.ValueMember = "ID_PARTICIPANTE"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla DEPARTAMENTO .
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String)
        Dim miComponente As New cPARTICIPANTE
        Dim Lista As New listaPARTICIPANTE

        Lista = miComponente.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRES"
        Me.ValueMember = "ID_PARTICIPANTE"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla MUNICIPIO .
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String)
        Dim miComponente As New cPARTICIPANTE
        Dim Lista As New listaPARTICIPANTE

        Lista = miComponente.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRES"
        Me.ValueMember = "ID_PARTICIPANTE"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla NIVEL_ACADEMICO .
    ''' </summary>
    ''' <param name="ID_NIVEL_ACADEMICO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/06/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorNIVEL_ACADEMICO(ByVal ID_NIVEL_ACADEMICO As Decimal)
        Dim miComponente As New cPARTICIPANTE
        Dim Lista As New listaPARTICIPANTE

        Lista = miComponente.ObtenerListaPorNIVEL_ACADEMICO(ID_NIVEL_ACADEMICO)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRES"
        Me.ValueMember = "ID_PARTICIPANTE"
        Me.DataSource = Lista

    End Sub

End Class

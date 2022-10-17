Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlCONTRATO_BOLPROS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla CONTRATO_BOLPROS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	11/09/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxCONTRATO_BOLPROS
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cCONTRATO_BOLPROS
        Dim Lista As New listaCONTRATO_BOLPROS

        Lista = miComponente.ObtenerLista()
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NO_CONVOCATORIA"
        Me.ValueMember = "ID_CONTRATO"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla PROVEEDOR_AF .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal)
        Dim miComponente As New cCONTRATO_BOLPROS
        Dim Lista As New listaCONTRATO_BOLPROS

        Lista = miComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NO_CONVOCATORIA"
        Me.ValueMember = "ID_CONTRATO"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla PROGRAMA_FORMACION .
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorPROGRAMA_FORMACION(ByVal ID_PROGRAMA_FORMACION As Decimal)
        Dim miComponente As New cCONTRATO_BOLPROS
        Dim Lista As New listaCONTRATO_BOLPROS

        Lista = miComponente.ObtenerListaPorPROGRAMA_FORMACION(ID_PROGRAMA_FORMACION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NO_CONVOCATORIA"
        Me.ValueMember = "ID_CONTRATO"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla FUENTE_FINANCIAMIENTO .
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorFUENTE_FINANCIAMIENTO(ByVal ID_FUENTE As Decimal)
        Dim miComponente As New cCONTRATO_BOLPROS
        Dim Lista As New listaCONTRATO_BOLPROS

        Lista = miComponente.ObtenerListaPorFUENTE_FINANCIAMIENTO(ID_FUENTE)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NO_CONVOCATORIA"
        Me.ValueMember = "ID_CONTRATO"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla TIPO_CONTRATACION .
    ''' </summary>
    ''' <param name="ID_TIPO_CONTRATACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	11/09/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorTIPO_CONTRATACION(ByVal ID_TIPO_CONTRATACION As Decimal)
        Dim miComponente As New cCONTRATO_BOLPROS
        Dim Lista As New listaCONTRATO_BOLPROS

        Lista = miComponente.ObtenerListaPorTIPO_CONTRATACION(ID_TIPO_CONTRATACION)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NO_CONVOCATORIA"
        Me.ValueMember = "ID_CONTRATO"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Popula el ComboBox filtrada por los parÃ¡metros de la Tabla FUENTE_FINANCIAMIENTO .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal NUM_CONTRATO As String, Optional ByVal agregarVacio As Boolean = False, Optional ByVal agregarTodos As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC", Optional ByVal MostrarContratoLote As Boolean = False)
        Dim miComponente As New cCONTRATO_BOLPROS
        Dim Lista As New listaCONTRATO_BOLPROS

        Lista = miComponente.ObtenerListaPorCriterios(ID_PROVEEDOR_AF, ID_PROGRAMA_FORMACION, NUM_CONTRATO, -1, "", asColumnaOrden, asTipoOrden)
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        ' Si MostrarContratoLote = True entonces mostrar no solo el número de contrato sino el lote también
        If Lista IsNot Nothing AndAlso Lista.Count > 0 AndAlso MostrarContratoLote Then
            For i As Integer = 0 To Lista.Count - 1
                If Lista(i).LOTE <> "" Then Lista(i).NUM_CONTRATO = Lista(i).NUM_CONTRATO + " Lote " + Lista(i).LOTE
            Next
        End If

        If agregarVacio Then
            Dim lContrato As New CONTRATO_BOLPROS
            lContrato.ID_CONTRATO = -1
            lContrato.NUM_CONTRATO = "[Vacio]"
            Lista.Insert(0, lContrato)
        End If

        If agregarTodos Then
            Dim lContrato As New CONTRATO_BOLPROS
            lContrato.ID_CONTRATO = -1
            lContrato.NUM_CONTRATO = "[Todos]"
            Lista.Insert(0, lContrato)
        End If

        Me.DisplayMember = "NUM_CONTRATO"
        Me.ValueMember = "ID_CONTRATO"
        Me.DataSource = Lista

    End Sub

End Class

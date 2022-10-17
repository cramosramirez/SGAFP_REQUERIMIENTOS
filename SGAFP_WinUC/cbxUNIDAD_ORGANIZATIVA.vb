Imports System.ComponentModel

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_WinUC
''' Class	 : WinUC.ddlUNIDAD_ORGANIZATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario Personalizado de una Lista Desplegable Windows
''' de la tabla UNIDAD_ORGANIZATIVA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Public Class cbxUNIDAD_ORGANIZATIVA
    Inherits cbxBase

    Private Sub RecuperarLista()
        Dim miComponente As New cUNIDAD_ORGANIZATIVA
        Dim Lista As New listaUNIDAD_ORGANIZATIVA

        Lista = miComponente.ObtenerLista(False, False, "NOMBRE_UNIDAD")
        If Lista Is Nothing OrElse Not Lista.Count > 0 Then
            Me.DataSource = Nothing
            Return
        End If

        Me.DisplayMember = "NOMBRE_UNIDAD"
        Me.ValueMember = "ID_UNIDAD_ORGANIZATIVA"
        Me.DataSource = Lista

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Recuperar()
        RecuperarLista()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por los parámetros de la Tabla Padre.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorId(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal)
        Dim miComponente As New cUNIDAD_ORGANIZATIVA
        Dim Lista As New listaUNIDAD_ORGANIZATIVA
        Dim lEntidad As UNIDAD_ORGANIZATIVA

        lEntidad = miComponente.ObtenerUNIDAD_ORGANIZATIVA(ID_UNIDAD_ORGANIZATIVA)
        If lEntidad Is Nothing Then
            Me.DataSource = Nothing
            Return
        End If
        Lista.Add(miComponente.ObtenerUNIDAD_ORGANIZATIVA(ID_UNIDAD_ORGANIZATIVA))

        Me.DisplayMember = "NOMBRE_UNIDAD"
        Me.ValueMember = "ID_UNIDAD_ORGANIZATIVA"
        Me.DataSource = Lista
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Popula el ComboBox filtrada por las Unidades Organizativas que ejecutan Proyectos Especiales
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	18/01/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub RecuperarPorProyectosEspeciales()
        Dim miComponente As New cUNIDAD_ORGANIZATIVA
        Dim Lista As New listaUNIDAD_ORGANIZATIVA

        Lista.Add(miComponente.ObtenerUNIDAD_ORGANIZATIVA(9))
        Lista.Add(miComponente.ObtenerUNIDAD_ORGANIZATIVA(18))
        Lista.Add(miComponente.ObtenerUNIDAD_ORGANIZATIVA(22))
        Lista.Add(miComponente.ObtenerUNIDAD_ORGANIZATIVA(7))

        Me.DisplayMember = "NOMBRE_UNIDAD"
        Me.ValueMember = "ID_UNIDAD_ORGANIZATIVA"
        Me.DataSource = Lista
    End Sub

End Class

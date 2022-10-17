Imports System.ComponentModel
Imports System.Reflection
Public Class controladorBase
    'Inherits System.EnterpriseServices.ServicedComponent
    Public sError As String
    Public sErrorTecnico As String

    Private _ConnectionStringName As String
    Protected Property ConnectionStringName() As String
        Get
            Return _ConnectionStringName
        End Get
        Set(ByVal value As String)
            _ConnectionStringName = value
        End Set
    End Property

    Public Function ObtenerListaPorBusqueda(ByVal aEntidad As entidadBase, ByVal aCriterios() As Criteria, ByVal asColumnaOrden As String, ByVal asTipoOrden As String) As IBindingListView
        Try
            Dim tipoEntidad As Type = aEntidad.GetType()
            Dim lDB As dbBase = System.Reflection.Assembly.Load("SGAFP_DL").CreateInstance("SGAFP.DL.db" + tipoEntidad.Name)
            Return lDB.ObtenerListaPorBusqueda(aEntidad, aCriterios, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerListaPorBusqueda(ByVal aEntidad As entidadBase, ByVal aCriterios() As Criteria) As IBindingListView
        Try
            Return Me.ObtenerListaPorBusqueda(aEntidad, aCriterios, "", "ASC")
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class

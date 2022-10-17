Imports System.Reflection
Imports SGAFP.WinUC

Public Class ucBaseBusqueda

    Private ColumnList As List(Of WinUC.Column)
    Protected CriteriaList As List(Of Criteria)
    Dim lPredicado As New WinUC.PredicateColumn
    Private entidadAsignada As entidadBase
    Private controller As New controladorBase

#Region "Propiedades"

    Private _EntityType As Type = Nothing
    <Description("Tipo de la Entidad para la Busqueda"), Category("Find"), DefaultValue("")> _
    Public Property EntityType() As Type
        Get
            Return Me._EntityType
        End Get
        Set(ByVal value As Type)
            Me._EntityType = value
        End Set
    End Property

    Private _PermitirBuscarWidth As Integer = 490
    <Description("Find Window Width"), Category("Find"), DefaultValue(490)> _
    Public Property PermitirBuscarWidth() As Integer
        Get
            Return Me._PermitirBuscarWidth
        End Get
        Set(ByVal value As Integer)
            Me._PermitirBuscarWidth = value
        End Set
    End Property

    Private _PermitirBuscarHeight As Integer = 270
    <Description("Find Window Height"), Category("Find"), DefaultValue(270)> _
    Public Property PermitirBuscarHeight() As Integer
        Get
            Return Me._PermitirBuscarHeight
        End Get
        Set(ByVal value As Integer)
            Me._PermitirBuscarHeight = value
        End Set
    End Property

#End Region

    Private Sub AgregarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripButton.Click
        Me.UcListViewCriterios1.ObtenerDatos()
        Me.UcListViewCriterios1.mLista.Add(New Criteria("", "", "", ""))
        Me.UcListViewCriterios1.CargarDatos()
    End Sub

    Private Sub CargarEntidad()
        Dim tipoEntidad As Type = Me.EntityType
        Me.ColumnList = New List(Of WinUC.Column)
        Me.UcListViewCriterios1.ColumnList = New List(Of WinUC.Column)
        For Each PropiedadOrigen As PropertyInfo In tipoEntidad.GetProperties()
            Dim atributoColumna As ColumnAttribute
            Dim atributoDataObject As System.ComponentModel.DataObjectFieldAttribute
            Dim PropiedadDestino As PropertyInfo = tipoEntidad.GetProperty(PropiedadOrigen.Name)
            atributoColumna = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(ColumnAttribute)), ColumnAttribute)
            atributoDataObject = CType(Attribute.GetCustomAttribute(PropiedadOrigen, GetType(System.ComponentModel.DataObjectFieldAttribute)), System.ComponentModel.DataObjectFieldAttribute)
            If Not PropiedadDestino Is Nothing And Not atributoColumna Is Nothing Then
                If atributoDataObject Is Nothing Then
                    ColumnList.Add(New Column(atributoColumna.Storage, atributoColumna.Name, atributoColumna.DBType, PropiedadDestino.PropertyType.Name, True, 0, False))
                Else
                    ColumnList.Add(New Column(atributoColumna.Storage, atributoColumna.Name, atributoColumna.DBType, PropiedadDestino.PropertyType.Name, atributoDataObject.IsNullable, atributoDataObject.Length, atributoDataObject.PrimaryKey))
                End If
            End If
        Next
        Me.UcListViewCriterios1.ColumnList = ColumnList
    End Sub

    Public Sub Inicializar()
        If Me.EntityType Is Nothing Then
            Return
        End If
        entidadAsignada = CType(System.Reflection.Assembly.GetAssembly(EntityType).CreateInstance(EntityType.FullName), entidadBase)
        Me.CargarEntidad()
    End Sub

    Private Sub BuscarToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripButton.Click
        Me.UcListViewCriterios1.ObtenerDatos()
        If Me.CriteriaList Is Nothing Then Me.CriteriaList = New List(Of Criteria)
        Me.CriteriaList.Clear()
        If Me.UcListViewCriterios1.mLista.Count = 0 Then
            Me.AsignarMensaje("Debe ingresar al menos un Criterio de Recuperación", True)
            Return
        End If
        Me.CriteriaList.AddRange(Me.UcListViewCriterios1.mLista)
        Me.Buscar()
    End Sub

    Protected Overridable Sub Buscar()

    End Sub

    Private Sub BindingSourceCriterios_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles BindingSourceCriterios.AddingNew
        Dim lEntidad As New Criteria(ColumnList(0).Name, "=", "", "AND")
        e.NewObject = lEntidad
    End Sub

End Class

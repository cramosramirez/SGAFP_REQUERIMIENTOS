Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO
Imports System.Reflection
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text 
'<Serializable()> Public Class listaBase(Of T)
'    Inherits BindingList(Of T)
'    Implements IBindingListView
'    ' Generic version of the Sortable Bindinglist on the got dot net website
'    ' http://www.gotdotnet.com/Community/UserSamples/Details.aspx?SampleGuid=661b91f1-03c5-487c-8732-59af89eba601
'    Private m_bIsSorted As Boolean = False
'    Private m_bIsFiltered As Boolean = False
'    Private m_SortDirection As ListSortDirection
'    Private m_SortProperty As Object 'PropertyDescriptor
'    Private m_strFilter As String
'    Private m_lstOrginal As New List(Of T)
'    Private filtering As Boolean = False

'    Public Sub New()
'    End Sub

'    'Public Sub New(ByVal value As IEnumerable(Of T))
'    '    Me.Add(value)
'    'End Sub

'    Public Sub AddRange(ByVal lista As BindingList(Of T))
'        CType(MyBase.Items, List(Of T)).AddRange(lista)
'    End Sub

'    Protected Overrides Sub InsertItem(ByVal index As Integer, ByVal item As T)
'        MyBase.InsertItem(index, item)
'        If Not filtering Then
'            m_lstOrginal.Insert(index, item)
'        End If
'    End Sub

'    Protected Overrides Sub RemoveItem(ByVal index As Integer)
'        MyBase.RemoveItem(index)
'    End Sub

'    Protected Overrides Sub SetItem(ByVal index As Integer, ByVal item As T)
'        Dim myItem As T = Items(index)
'        Dim intItem As Integer
'        MyBase.SetItem(index, item)
'        intItem = m_lstOrginal.IndexOf(myItem)
'        m_lstOrginal.Item(intItem) = myItem
'    End Sub

'    Protected Overrides ReadOnly Property SupportsSortingCore() As Boolean
'        Get
'            Return True
'        End Get
'    End Property

'    Protected Overrides ReadOnly Property IsSortedCore() As Boolean
'        Get
'            Return m_bIsSorted
'        End Get
'    End Property

'    Protected Overrides Sub RemoveSortCore()
'        m_bIsSorted = False
'    End Sub

'    Protected Overrides Sub ApplySortCore(ByVal prop As System.ComponentModel.PropertyDescriptor, ByVal direction As System.ComponentModel.ListSortDirection)
'        ' Get list to sort
'        Dim myitems As List(Of T) = TryCast(Me.Items, List(Of T))
'        ' Apply and set the sort, if items to sort
'        If myitems IsNot Nothing Then
'            m_SortDirection = direction
'            m_SortProperty = prop

'            Dim pc As PropertyComparer(Of T) = _
'              New PropertyComparer(Of T)(prop, direction)
'            myitems.Sort(pc)
'            m_bIsSorted = True
'        Else
'            m_bIsSorted = False
'        End If
'        Me.OnListChanged(New ListChangedEventArgs(ListChangedType.Reset, -1))
'    End Sub

'    Protected Overrides ReadOnly Property SortPropertyCore() As System.ComponentModel.PropertyDescriptor
'        Get
'            Return CType(m_SortProperty, System.ComponentModel.PropertyDescriptor)
'        End Get
'    End Property

'    Protected Overrides ReadOnly Property SortDirectionCore() As System.ComponentModel.ListSortDirection
'        Get
'            Return m_SortDirection
'        End Get
'    End Property

'    Public Sub ApplySort(ByVal sorts As System.ComponentModel.ListSortDescriptionCollection) Implements System.ComponentModel.IBindingListView.ApplySort
'    End Sub

'    Public Property Filter() As String Implements System.ComponentModel.IBindingListView.Filter
'        Get
'            Return m_strFilter
'        End Get
'        Set(ByVal value As String)
'            m_strFilter = value
'            If String.IsNullOrEmpty(value) Then
'                RemoveFilter()
'            Else
'                DoFilter()
'            End If
'        End Set
'    End Property

'    Public Sub RemoveFilter() Implements System.ComponentModel.IBindingListView.RemoveFilter
'        m_bIsFiltered = False
'        FillList(m_lstOrginal)
'    End Sub

'    Public ReadOnly Property SortDescriptions() As System.ComponentModel.ListSortDescriptionCollection Implements System.ComponentModel.IBindingListView.SortDescriptions
'        Get
'            Return Nothing
'        End Get
'    End Property

'    Public ReadOnly Property SupportsAdvancedSorting() As Boolean Implements System.ComponentModel.IBindingListView.SupportsAdvancedSorting
'        Get
'            Return False
'        End Get
'    End Property

'    Public ReadOnly Property SupportsFiltering() As Boolean Implements System.ComponentModel.IBindingListView.SupportsFiltering
'        Get
'            Return True
'        End Get
'    End Property

'    Private Sub FillList(ByVal lst As List(Of T))
'        filtering = True
'        For z As Integer = Items.Count - 1 To 0 Step -1
'            Items.RemoveAt(z)
'        Next
'        For Each i As T In lst
'            Items.Add(i)
'        Next
'        filtering = False
'        Me.OnListChanged(New ListChangedEventArgs(ListChangedType.Reset, -1))
'    End Sub

'    Private Sub DoFilter()
'        FillList(DirectCast(Items, List(Of T)).FindAll(AddressOf FindFilter))
'    End Sub

'    Private Function FindFilter(ByVal value As T) As Boolean
'        Dim strSplitOperator() As String
'        Dim boolSplitOperator() As Boolean
'        If Filter.IndexOf("AND") <> -1 Then
'            strSplitOperator = Filter.Replace("AND", ";").Split(";"c) 'Filter.Split("AND")
'            ReDim boolSplitOperator(strSplitOperator.Length - 1)
'        Else
'            ReDim strSplitOperator(0)
'            ReDim boolSplitOperator(0)
'            strSplitOperator(0) = Filter.ToString()
'        End If
'        Dim i As Integer = 0
'        For Each strFiltro As String In strSplitOperator
'            Dim strSplit() As String = strFiltro.Trim().Split(" "c) 'Filter.Split(" "c)
'            'Dim strSplit() As String = Filter.Split("=")
'            Dim pi As PropertyInfo = value.[GetType]().GetProperty(strSplit(0))
'            Dim val As String
'            If pi.GetValue(value, Nothing) Is Nothing Then
'                val = ""
'            Else
'                val = pi.GetValue(value, Nothing).ToString
'            End If
'            Dim myType As Type = pi.PropertyType
'            If myType Is GetType(Integer) Or myType Is GetType(Short) Or myType Is GetType(Double) _
'                Or myType Is GetType(Single) Or myType Is GetType(Byte) Then
'                'Return NumCompare(strSplit(1), CDbl(val), CDbl(strSplit(2)))
'                boolSplitOperator(i) = NumCompare(strSplit(1), CDbl(val), CDbl(strSplit(2)))
'            Else
'                'Return StringCompare(strSplit(1), val, strSplit(2))
'                boolSplitOperator(i) = StringCompare(strSplit(1), val, strSplit(2))
'            End If
'            i += 1
'        Next

'        For Each boolOperator As Boolean In boolSplitOperator
'            If boolOperator = False Then Return False
'        Next

'        Return True
'    End Function

'    Public Function NumCompare(ByVal strType As String, ByVal propval As Double, ByVal compareval As Double) As Boolean
'        Select Case strType
'            Case ">"
'                Return propval > compareval
'            Case "<"
'                Return propval < compareval
'            Case ">="
'                Return propval >= compareval
'            Case "<="
'                Return propval <= compareval
'            Case "<>"
'                Return propval <> compareval
'            Case Else
'                Return propval = compareval
'        End Select
'    End Function

'    Public Function StringCompare(ByVal strtype As String, ByVal propval As String, ByVal compareval As String) As Boolean
'        Select Case strtype
'            Case "="
'                Return propval = compareval
'            Case "like"
'                Try
'                    Return propval Like compareval
'                Catch
'                    Return propval = compareval
'                End Try
'            Case ">"
'                Return propval > compareval
'            Case "<"
'                Return propval < compareval
'            Case ">="
'                Return propval >= compareval
'            Case "<="
'                Return propval <= compareval
'            Case "<>"
'                Return propval <> compareval
'            Case Else
'                Return False
'        End Select
'    End Function

'    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
'        Get
'            Return True
'        End Get
'    End Property

'    Protected Overrides Function FindCore(ByVal [property] As PropertyDescriptor, ByVal key As Object) As Integer

'        ' Specify search columns
'        If ([property] Is Nothing) Then
'            Return -1
'        End If

'        ' Get list to search
'        Dim items As IList(Of T) = Me.Items

'        ' Traverse list for value
'        For Each item As T In items

'            ' Test column search value
'            Dim value As String = CStr([property].GetValue(item))

'            'If value is the search value, return the 
'            ' index of the data item
'            If (CStr(key) = value) Then
'                Return IndexOf(item)
'            End If

'        Next item

'        Return -1

'    End Function

'    Public Function FindByColum(ByVal columnName As String, ByVal value As Object) As Integer
'        Return FindCore(GetPropertyDescriptor(columnName), value)
'    End Function

'    Public Sub Load(ByVal filename As String)

'        Me.ClearItems()

'        If Not Not File.Exists(filename) Then
'            Dim formatter As New BinaryFormatter
'            Using stream As FileStream = New FileStream(filename, FileMode.Open)
'                ' Deserialize data list items
'                CType(MyBase.Items, List(Of T)).AddRange(CType(formatter.Deserialize(stream), IEnumerable(Of T)))
'            End Using
'        End If

'        ' Let bound controls know they should refresh their views
'        Me.OnListChanged(New ListChangedEventArgs(ListChangedType.Reset, -1))

'    End Sub

'    Public Sub Save(ByVal filename As String)
'        Dim formatter1 As New BinaryFormatter
'        Using stream1 As FileStream = New FileStream(filename, FileMode.Create)
'            ' Serialize data list items
'            formatter1.Serialize(stream1, CType(MyBase.Items, List(Of T)))
'        End Using
'    End Sub

'    Private _PropertyHash As New System.Collections.Hashtable

'    Private Function GetPropertyDescriptor(ByVal [property] As String) As PropertyDescriptor

'        Dim itemType As Type = Nothing
'        If [property].Length > 0 Then
'            If _PropertyHash.Count = 0 Then

'                Dim props As PropertyDescriptorCollection = Nothing

'                Dim t As Type = Me(0).GetType() '(CType(BaseList, Object)).GetType()
'                Dim defaultMembers As MemberInfo() = t.GetDefaultMembers()
'                For Each member As MemberInfo In defaultMembers
'                    If member.MemberType = MemberTypes.Property Then
'                        itemType = (CType(member, PropertyInfo)).GetGetMethod().ReturnType
'                        GetProperties(itemType, _PropertyHash)
'                        Exit For
'                    End If
'                Next
'                ' if it is not a strongly-typed collection (eg if arraylist, etc)
'                ' then just get the base type of the zeroth elt and assume all elts are the same. 
'                If _PropertyHash.Count = 0 Then
'                    If (Me.Count > 0) Then
'                        itemType = Me(0).GetType()
'                        props = TypeDescriptor.GetProperties(itemType)
'                        For Each prop As PropertyDescriptor In props
'                            _PropertyHash(prop.Name) = prop
'                        Next
'                    Else
'                        Throw New Exception("Can not determine collection item type")
'                    End If
'                End If
'            End If

'            If _PropertyHash.ContainsKey([property]) Then
'                Return CType(_PropertyHash([property]), PropertyDescriptor)
'            End If
'        End If
'        Return Nothing
'    End Function

'    Private Sub GetProperties(ByVal itemType As Type, ByVal aPropertyHash As Hashtable)
'        GetProperties(String.Empty, itemType, aPropertyHash)
'    End Sub

'    Private Sub GetProperties(ByVal propertyNamePrefix As String, ByVal itemType As Type, ByVal aPropertyHash As Hashtable)

'        Dim props As PropertyDescriptorCollection = TypeDescriptor.GetProperties(itemType)
'        For Each pd As PropertyDescriptor In props
'            If pd.PropertyType Is itemType Then
'                Throw New SystemException("Due to the crappy implemetation, nested types are not allowed")
'            End If
'            If IsSortableType(pd.PropertyType) Then
'                Dim propertyName As String '= IIf(propertyNamePrefix.Length > 0, propertyNamePrefix + "." + pd.Name, pd.Name)
'                If propertyNamePrefix.Length > 0 Then
'                    propertyName = propertyNamePrefix + "." + pd.Name
'                Else
'                    propertyName = pd.Name
'                End If
'                If IsNestedType(pd.PropertyType) Then
'                    GetProperties(propertyName, pd.PropertyType, _PropertyHash)
'                Else
'                    _PropertyHash.Add(propertyName, pd)
'                End If
'            End If
'        Next
'    End Sub

'    Private Function IsSortableType(ByVal aType As Type) As Boolean
'        Return (Not (aType.Equals(GetType(ArrayList))) And Not (aType.IsSubclassOf(GetType(CollectionBase))))
'    End Function

'    Private Function IsNestedType(ByVal aType As Type) As Boolean
'        Return (Not aType.IsValueType And Not (aType.Equals(GetType(String))) And Not (aType.Equals(GetType(Object))))
'    End Function

'End Class

'Public Class PropertyComparer(Of T)
'    Implements IComparer(Of T)

'    Private _direction As ListSortDirection
'    Private _property As PropertyDescriptor

'    ' The following code contains code implemented by Rockford Lhotka:
'    ' http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dnadvnet/html/vbnet01272004.asp

'    Public Sub New(ByVal [property] As PropertyDescriptor, ByVal direction As ListSortDirection)
'        Me._property = [property]
'        Me._direction = direction
'    End Sub

'    Public Function Compare(ByVal xWord As T, ByVal yWord As T) As Integer Implements System.Collections.Generic.IComparer(Of T).Compare

'        ' Get property values
'        Dim xValue As Object = Me.GetPropertyValue(xWord, Me._property.Name)
'        Dim yValue As Object = Me.GetPropertyValue(yWord, Me._property.Name)

'        ' Determine sort order
'        If (Me._direction = ListSortDirection.Ascending) Then
'            Return Me.CompareAscending(xValue, yValue)
'        End If

'        Return Me.CompareDescending(xValue, yValue)

'    End Function

'    Private Function CompareAscending(ByVal xValue As Object, ByVal yValue As Object) As Integer

'        ' If values implement IComparer
'        If (TypeOf xValue Is IComparable) Then
'            Return CType(xValue, IComparable).CompareTo(yValue)
'        End If

'        ' If values don't implement IComparer but are equivalent
'        If (xValue.Equals(yValue)) Then
'            Return 0
'        End If

'        Return xValue.ToString.CompareTo(yValue.ToString)

'    End Function

'    Private Function CompareDescending(ByVal xValue As Object, ByVal yValue As Object) As Integer
'        Return (Me.CompareAscending(xValue, yValue) * -1)
'    End Function

'    Private Function GetPropertyValue(ByVal value As T, ByVal [property] As String) As Object
'        Dim propertyInfo As PropertyInfo = value.GetType.GetProperty([property])
'        Return propertyInfo.GetValue(value, Nothing)
'    End Function

'End Class

<Serializable()> Public Class listaBase(Of T)
    'Inherits List(Of T)
    Inherits BindingList(Of T)
    'Implements IBindingList
    Implements IBindingListView

    ' Generic version of the Sortable Bindinglist on the got dot net website
    ' http://www.gotdotnet.com/Community/UserSamples/Details.aspx?SampleGuid=661b91f1-03c5-487c-8732-59af89eba601
    Private m_bIsSorted As Boolean = False
    Private m_bIsFiltered As Boolean = False
    Private m_SortDirection As ListSortDirection
    Private m_SortProperty As PropertyDescriptor
    Private m_strFilter As String
    Private m_lstOrginal As New List(Of T)
    Private filtering As Boolean = False

    Public Sub New()
    End Sub

    Public Sub New(ByVal value As IEnumerable(Of T))
        Me.Add(CType(value, T))
    End Sub

    Public Sub AddRange(ByVal lista As BindingList(Of T))
        CType(MyBase.Items, List(Of T)).AddRange(lista)
    End Sub

    Public Sub AddRange(ByVal lista As IEnumerable(Of T))
        CType(MyBase.Items, List(Of T)).AddRange(lista)
    End Sub

    Public Function FindAll(ByVal match As System.Predicate(Of T)) As List(Of T)
        Return CType(MyBase.Items, List(Of T)).FindAll(match)
    End Function

    Public Function Find(ByVal match As System.Predicate(Of T)) As T
        Return CType(MyBase.Items, List(Of T)).Find(match)
    End Function

    Public Function FindLast(ByVal match As System.Predicate(Of T)) As T
        Return CType(MyBase.Items, List(Of T)).FindLast(match)
    End Function

    Public Function FindIndex(ByVal match As System.Predicate(Of T)) As Integer
        Return CType(MyBase.Items, List(Of T)).FindIndex(match)
    End Function

    Public Function FindIndex(ByVal startIndex As Integer, ByVal match As System.Predicate(Of T)) As Integer
        Return CType(MyBase.Items, List(Of T)).FindIndex(startIndex, match)
    End Function

    Public Function FindIndex(ByVal startIndex As Integer, ByVal count As Integer, ByVal match As System.Predicate(Of T)) As Integer
        Return CType(MyBase.Items, List(Of T)).FindIndex(startIndex, count, match)
    End Function

    Public Function FindLastIndex(ByVal match As System.Predicate(Of T)) As Integer
        Return CType(MyBase.Items, List(Of T)).FindLastIndex(match)
    End Function

    Public Function FindLastIndex(ByVal startIndex As Integer, ByVal match As System.Predicate(Of T)) As Integer
        Return CType(MyBase.Items, List(Of T)).FindLastIndex(startIndex, match)
    End Function

    Public Function FindLastIndex(ByVal startIndex As Integer, ByVal count As Integer, ByVal match As System.Predicate(Of T)) As Integer
        Return CType(MyBase.Items, List(Of T)).FindLastIndex(startIndex, count, match)
    End Function

    Protected Overrides Sub ApplySortCore(ByVal [property] As PropertyDescriptor, ByVal direction As ListSortDirection)
        If Not Me.m_bIsSorted Then
            m_lstOrginal.AddRange(MyBase.Items)
        End If
        ' Get list to sort
        Dim items As List(Of T) = TryCast(MyBase.Items, List(Of T))

        ' Apply and set the sort, if items to sort
        If (Not items Is Nothing) Then
            Dim pc As New PropertyComparer(Of T)([property], direction)
            items.Sort(pc)
            Me.m_bIsSorted = True
        Else
            Me.m_bIsSorted = False
        End If

        Me.m_SortProperty = [property]
        Me.m_SortDirection = direction

        ' Let bound controls know they should refresh their views
        Me.listaBase_ListChanged(Me, New ListChangedEventArgs(ListChangedType.ItemMoved, -1))

    End Sub

    Protected Overrides ReadOnly Property SupportsSortingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides ReadOnly Property SortPropertyCore() As System.ComponentModel.PropertyDescriptor
        Get
            Return Me.m_SortProperty
        End Get
    End Property

    Protected Overrides ReadOnly Property SortDirectionCore() As System.ComponentModel.ListSortDirection
        Get
            Return Me.m_SortDirection
        End Get
    End Property

    Protected Overrides ReadOnly Property IsSortedCore() As Boolean
        Get
            Return Me.m_bIsSorted
        End Get
    End Property

    Protected Overrides Sub RemoveSortCore()
        Me.m_SortDirection = Nothing
        Me.m_SortProperty = Nothing
        Me.m_bIsSorted = False
        'Me.Items.Clear()
        'CType(MyBase.Items, List(Of T)).AddRange(Me.m_lstOrginal)
        'Me.m_lstOrginal = Nothing

        Dim index As Integer = 0
        For Each item As T In Me.m_lstOrginal
            SetItem(index, item)
            index += 1
        Next

        Me.m_lstOrginal.Clear()

        ' Let bound controls know they should refresh their views
        Me.listaBase_ListChanged(Me, New ListChangedEventArgs(ListChangedType.Reset, -1))
    End Sub

    Public Sub ApplySort(ByVal sorts As System.ComponentModel.ListSortDescriptionCollection) Implements System.ComponentModel.IBindingListView.ApplySort

    End Sub

    Public Property Filter() As String Implements System.ComponentModel.IBindingListView.Filter
        Get
            Return m_strFilter
        End Get
        Set(ByVal value As String)
            m_strFilter = value
            If String.IsNullOrEmpty(value) Then
                RemoveFilter()
            Else
                DoFilter()
            End If
        End Set
    End Property

    Public Sub RemoveFilter() Implements System.ComponentModel.IBindingListView.RemoveFilter
        m_bIsFiltered = False
        FillList(m_lstOrginal)
    End Sub

    Public ReadOnly Property SortDescriptions() As System.ComponentModel.ListSortDescriptionCollection Implements System.ComponentModel.IBindingListView.SortDescriptions
        Get
            Return Nothing
        End Get
    End Property

    Public ReadOnly Property SupportsAdvancedSorting() As Boolean Implements System.ComponentModel.IBindingListView.SupportsAdvancedSorting
        Get
            Return False
        End Get
    End Property

    Public ReadOnly Property SupportsFiltering() As Boolean Implements System.ComponentModel.IBindingListView.SupportsFiltering
        Get
            Return True
        End Get
    End Property

    Private Sub FillList(ByVal lst As List(Of T))
        filtering = True
        For z As Integer = Me.Count - 1 To 0 Step -1
            Me.RemoveAt(z)
        Next
        For Each i As T In lst
            Me.Add(i)
        Next
        filtering = False
        Me.listaBase_ListChanged(Me, New ListChangedEventArgs(ListChangedType.Reset, -1))
    End Sub

    Private Sub DoFilter()
        FillList(Me.FindAll(AddressOf FindFilter))
    End Sub

    Private Function FindFilter(ByVal value As T) As Boolean

        Dim strSplitOperator() As String
        Dim boolSplitOperator() As Boolean
        If Filter.IndexOf("AND") <> -1 Then
            strSplitOperator = Filter.Replace("AND", ";").Split(";"c) 'Filter.Split("AND")
            ReDim boolSplitOperator(strSplitOperator.Length - 1)
            'ElseIf Filter.IndexOf("OR") <> -1 Then
            '    strSplitOperator = Filter.Replace("OR", ";").Split(";"c) 'Filter.Split("OR")
            '    ReDim boolSplitOperator(strSplitOperator.Length - 1)
        Else
            ReDim strSplitOperator(0)
            ReDim boolSplitOperator(0)
            strSplitOperator(0) = Filter.ToString()
        End If
        Dim i As Integer = 0
        For Each strFiltro As String In strSplitOperator
            Dim strSplit() As String = strFiltro.Trim().Split(" "c) 'Filter.Split(" "c)
            'Dim strSplit() As String = Filter.Split("=")
            Dim pi As PropertyInfo = value.[GetType]().GetProperty(strSplit(0))
            Dim val As String
            If pi.GetValue(value, Nothing) Is Nothing Then
                val = ""
            Else
                val = pi.GetValue(value, Nothing).ToString
            End If
            Dim myType As Type = pi.PropertyType
            If myType Is GetType(Integer) Or myType Is GetType(Short) Or myType Is GetType(Double) _
                Or myType Is GetType(Single) Or myType Is GetType(Byte) Then
                'Return NumCompare(strSplit(1), CDbl(val), CDbl(strSplit(2)))
                boolSplitOperator(i) = NumCompare(strSplit(1), CDbl(val), CDbl(strSplit(2)))
            Else
                'Return StringCompare(strSplit(1), val, strSplit(2))
                boolSplitOperator(i) = StringCompare(strSplit(1), val, strSplit(2))
            End If
            i += 1
        Next

        For Each boolOperator As Boolean In boolSplitOperator
            If boolOperator = False Then Return False
        Next

        Return True
    End Function

    Protected Function NumCompare(ByVal strType As String, ByVal propval As Double, ByVal compareval As Double) As Boolean
        Select Case strType
            Case ">"
                Return propval > compareval
            Case "<"
                Return propval < compareval
            Case ">="
                Return propval >= compareval
            Case "<="
                Return propval <= compareval
            Case "<>"
                Return propval <> compareval
            Case Else
                Return propval = compareval
        End Select
    End Function

    Protected Function StringCompare(ByVal strtype As String, ByVal propval As String, ByVal compareval As String) As Boolean
        Select Case strtype
            Case "="
                Return propval = compareval
            Case "like"
                Try
                    Return propval Like compareval
                Catch
                    Return propval = compareval
                End Try
            Case ">"
                Return propval > compareval
            Case "<"
                Return propval < compareval
            Case ">="
                Return propval >= compareval
            Case "<="
                Return propval <= compareval
            Case "<>"
                Return propval <> compareval
            Case Else
                Return False
        End Select
    End Function

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(ByVal [property] As PropertyDescriptor, ByVal key As Object) As Integer

        ' Specify search columns
        If ([property] Is Nothing) Then
            Return -1
        End If

        ' Get list to search
        Dim items As IList(Of T) = Me

        ' Traverse list for value
        For Each item As T In items

            ' Test column search value
            Dim value As String = CStr([property].GetValue(item))

            'If value is the search value, return the 
            ' index of the data item
            If (CStr(key) = value) Then
                Return IndexOf(item)
            End If

        Next item

        Return -1

    End Function

    Public Function FindByColum(ByVal columnName As String, ByVal value As Object) As Integer
        Return FindCore(GetPropertyDescriptor(columnName), value)
    End Function

    Public Sub Load(ByVal filename As String)

        Me.Clear()

        If Me.m_bIsSorted Then
            Me.RemoveSortCore()
        End If

        If Not Not File.Exists(filename) Then
            Dim formatter As New BinaryFormatter
            Using stream As FileStream = New FileStream(filename, FileMode.Open)
                ' Deserialize data list items
                Me.AddRange(CType(formatter.Deserialize(stream), IEnumerable(Of T)))
            End Using
        End If

        ' Let bound controls know they should refresh their views
        Me.listaBase_ListChanged(Me, New ListChangedEventArgs(ListChangedType.Reset, -1))

    End Sub

    Public Sub Save(ByVal filename As String)
        Dim formatter1 As New BinaryFormatter
        Using stream1 As FileStream = New FileStream(filename, FileMode.Create)
            ' Serialize data list items
            formatter1.Serialize(stream1, Me)
        End Using
    End Sub

    Private _PropertyHash As New System.Collections.Hashtable

    Private Function GetPropertyDescriptor(ByVal [property] As String) As PropertyDescriptor

        Dim itemType As Type = Nothing
        If [property].Length > 0 Then
            If _PropertyHash.Count = 0 Then

                Dim props As PropertyDescriptorCollection = Nothing

                Dim t As Type = Me(0).GetType() '(CType(BaseList, Object)).GetType()
                Dim defaultMembers As MemberInfo() = t.GetDefaultMembers()
                For Each member As MemberInfo In defaultMembers
                    If member.MemberType = MemberTypes.Property Then
                        itemType = (CType(member, PropertyInfo)).GetGetMethod().ReturnType
                        GetProperties(itemType, _PropertyHash)
                        Exit For
                    End If
                Next
                ' if it is not a strongly-typed collection (eg if arraylist, etc)
                ' then just get the base type of the zeroth elt and assume all elts are the same. 
                If _PropertyHash.Count = 0 Then
                    If (Me.Count > 0) Then
                        itemType = Me(0).GetType()
                        props = TypeDescriptor.GetProperties(itemType)
                        For Each prop As PropertyDescriptor In props
                            _PropertyHash(prop.Name) = prop
                        Next
                    Else
                        Throw New Exception("Can not determine collection item type")
                    End If
                End If
            End If

            If _PropertyHash.ContainsKey([property]) Then
                Return CType(_PropertyHash([property]), PropertyDescriptor)
            End If
        End If
        Return Nothing
    End Function

    Private Sub GetProperties(ByVal itemType As Type, ByVal aPropertyHash As Hashtable)
        GetProperties(String.Empty, itemType, aPropertyHash)
    End Sub

    Private Sub GetProperties(ByVal propertyNamePrefix As String, ByVal itemType As Type, ByVal aPropertyHash As Hashtable)

        Dim props As PropertyDescriptorCollection = TypeDescriptor.GetProperties(itemType)
        For Each pd As PropertyDescriptor In props
            If pd.PropertyType Is itemType Then
                Throw New SystemException("Due to the crappy implemetation, nested types are not allowed")
            End If
            If IsSortableType(pd.PropertyType) Then
                Dim propertyName As String '= IIf(propertyNamePrefix.Length > 0, propertyNamePrefix + "." + pd.Name, pd.Name)
                If propertyNamePrefix.Length > 0 Then
                    propertyName = propertyNamePrefix + "." + pd.Name
                Else
                    propertyName = pd.Name
                End If
                If IsNestedType(pd.PropertyType) Then
                    GetProperties(propertyName, pd.PropertyType, _PropertyHash)
                Else
                    _PropertyHash.Add(propertyName, pd)
                End If
            End If
        Next
    End Sub

    Private Function IsSortableType(ByVal aType As Type) As Boolean
        Return (Not (aType.Equals(GetType(ArrayList))) And Not (aType.IsSubclassOf(GetType(CollectionBase))))
    End Function

    Private Function IsNestedType(ByVal aType As Type) As Boolean
        Return (Not aType.IsValueType And Not (aType.Equals(GetType(String))) And Not (aType.Equals(GetType(Object))))
    End Function

    'Public Sub AddIndex(ByVal [property] As System.ComponentModel.PropertyDescriptor) Implements System.ComponentModel.IBindingList.AddIndex

    'End Sub

    'Public Function AddNew() As Object Implements System.ComponentModel.IBindingList.AddNew

    'End Function

    'Public ReadOnly Property AllowEdit() As Boolean Implements System.ComponentModel.IBindingList.AllowEdit
    '    Get

    '    End Get
    'End Property

    'Public ReadOnly Property AllowNew() As Boolean Implements System.ComponentModel.IBindingList.AllowNew
    '    Get
    '        Return True
    '    End Get
    'End Property

    'Public ReadOnly Property AllowRemove() As Boolean Implements System.ComponentModel.IBindingList.AllowRemove
    '    Get

    '    End Get
    'End Property

    'Public Sub ApplySort1(ByVal [property] As System.ComponentModel.PropertyDescriptor, ByVal direction As System.ComponentModel.ListSortDirection) Implements System.ComponentModel.IBindingList.ApplySort

    'End Sub

    'Public Function Find1(ByVal [property] As System.ComponentModel.PropertyDescriptor, ByVal key As Object) As Integer Implements System.ComponentModel.IBindingList.Find

    'End Function

    'Public ReadOnly Property IsSorted() As Boolean Implements System.ComponentModel.IBindingList.IsSorted
    '    Get

    '    End Get
    'End Property

    'Public Event ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Implements System.ComponentModel.IBindingList.ListChanged

    'Public Sub RemoveIndex(ByVal [property] As System.ComponentModel.PropertyDescriptor) Implements System.ComponentModel.IBindingList.RemoveIndex

    'End Sub

    'Public Sub RemoveSort() Implements System.ComponentModel.IBindingList.RemoveSort

    'End Sub

    'Public ReadOnly Property SortDirection() As System.ComponentModel.ListSortDirection Implements System.ComponentModel.IBindingList.SortDirection
    '    Get

    '    End Get
    'End Property

    'Public ReadOnly Property SortProperty() As System.ComponentModel.PropertyDescriptor Implements System.ComponentModel.IBindingList.SortProperty
    '    Get

    '    End Get
    'End Property

    'Public ReadOnly Property SupportsChangeNotification() As Boolean Implements System.ComponentModel.IBindingList.SupportsChangeNotification
    '    Get
    '        Return True
    '    End Get
    'End Property

    'Public ReadOnly Property SupportsSearching() As Boolean Implements System.ComponentModel.IBindingList.SupportsSearching
    '    Get
    '        Return True
    '    End Get
    'End Property

    'Public ReadOnly Property SupportsSorting() As Boolean Implements System.ComponentModel.IBindingList.SupportsSorting
    '    Get
    '        Return True
    '    End Get
    'End Property

    Private Sub listaBase_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles Me.ListChanged

    End Sub

    Public Sub SortByColum(ByVal propertyName As String, ByVal direction As System.ComponentModel.ListSortDirection)
        Me.ApplySortCore(GetPropertyDescriptor(propertyName), direction)
    End Sub

    Public Sub RemoveSort()
        Me.RemoveSortCore()
    End Sub

End Class

Public Class PropertyComparer(Of T)
    Implements IComparer(Of T)

    Private _direction As ListSortDirection
    Private _property As PropertyDescriptor

    Public Sub New(ByVal [property] As PropertyDescriptor, ByVal direction As ListSortDirection)
        Me._property = [property]
        Me._direction = direction
    End Sub

    Public Function Compare(ByVal xWord As T, ByVal yWord As T) As Integer Implements System.Collections.Generic.IComparer(Of T).Compare

        Dim xValue As Object = Me._property.GetValue(xWord)
        Dim yValue As Object = Me._property.GetValue(yWord)

        Dim valor As Integer
        valor = Comparer.Default.Compare(xValue, yValue)
        If (Me._direction = ListSortDirection.Descending) Then Return (0 - valor)
        Return valor

    End Function

End Class
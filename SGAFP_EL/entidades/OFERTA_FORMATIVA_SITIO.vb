''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.OFERTA_FORMATIVA_SITIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row OFERTA_FORMATIVA_SITIO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/09/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="OFERTA_FORMATIVA_SITIO")> Public Class OFERTA_FORMATIVA_SITIO
    Inherits entidadBase
    Implements IEquatable(Of OFERTA_FORMATIVA_SITIO), IComparable(Of OFERTA_FORMATIVA_SITIO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_OFERTA_FORMATIVA As Decimal, aID_PROVEEDOR_AF As Decimal, aID_SITIO_CAPACITACION As Decimal, aID_EJERCICIO As String, aDURACION_HORAS As Decimal, aCOSTO_X_PARTICIPANTE As Decimal, aUSER_ID As String, aLASTUPDATE As DateTime, aPARTICIPACION_ADJUDICADA As Decimal, aMONTO_ADJUDICADO As Decimal)
        Me._ID_OFERTA_FORMATIVA = aID_OFERTA_FORMATIVA
        Me._ID_PROVEEDOR_AF = aID_PROVEEDOR_AF
        Me._ID_SITIO_CAPACITACION = aID_SITIO_CAPACITACION
        Me._ID_EJERCICIO = aID_EJERCICIO
        Me._DURACION_HORAS = aDURACION_HORAS
        Me._COSTO_X_PARTICIPANTE = aCOSTO_X_PARTICIPANTE
        Me._USER_ID = aUSER_ID
        Me._LASTUPDATE = aLASTUPDATE
        Me._PARTICIPACION_ADJUDICADA = aPARTICIPACION_ADJUDICADA
        Me._MONTO_ADJUDICADO = aMONTO_ADJUDICADO
    End Sub

    Public Function Equals1(ByVal other As OFERTA_FORMATIVA_SITIO) As Boolean Implements System.IEquatable(Of OFERTA_FORMATIVA_SITIO).Equals
        Return Me.ID_OFERTA_FORMATIVA = other.ID_OFERTA_FORMATIVA And Me.ID_PROVEEDOR_AF = other.ID_PROVEEDOR_AF And Me.ID_SITIO_CAPACITACION = other.ID_SITIO_CAPACITACION And Me.ID_EJERCICIO = other.ID_EJERCICIO
    End Function

    Public Function CompareTo(ByVal other As OFERTA_FORMATIVA_SITIO) As Integer Implements System.IComparable(Of OFERTA_FORMATIVA_SITIO).CompareTo
        If Me.ID_OFERTA_FORMATIVA > other.ID_OFERTA_FORMATIVA Then
            If Me.ID_PROVEEDOR_AF > other.ID_PROVEEDOR_AF Then
                If Me.ID_SITIO_CAPACITACION > other.ID_SITIO_CAPACITACION Then
                    If Me.ID_EJERCICIO > other.ID_EJERCICIO Then Return 1
                    If Me.ID_EJERCICIO < other.ID_EJERCICIO Then Return -1
                Else
                    Return -1
                End If
            Else
                Return -1
            End If
        Else
            Return -1
        End If
        Return 0
    End Function


#Region " Properties "

    Private _ID_OFERTA_FORMATIVA As Decimal
    <Column(Name:="Id oferta formativa", Storage:="ID_OFERTA_FORMATIVA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_OFERTA_FORMATIVA() As Decimal
        Get
            Return _ID_OFERTA_FORMATIVA
        End Get
        Set(ByVal Value As Decimal)
            _ID_OFERTA_FORMATIVA = Value
            OnPropertyChanged("ID_OFERTA_FORMATIVA")
        End Set
    End Property 

    Private _fkID_OFERTA_FORMATIVA As OFERTA_FORMATIVA
    Public Property fkID_OFERTA_FORMATIVA() As OFERTA_FORMATIVA
        Get
            Return _fkID_OFERTA_FORMATIVA
        End Get
        Set(ByVal Value As OFERTA_FORMATIVA)
            _fkID_OFERTA_FORMATIVA = Value
        End Set
    End Property 

    Private _ID_PROVEEDOR_AF As Decimal
    <Column(Name:="Id proveedor af", Storage:="ID_PROVEEDOR_AF", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_PROVEEDOR_AF() As Decimal
        Get
            Return _ID_PROVEEDOR_AF
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROVEEDOR_AF = Value
            OnPropertyChanged("ID_PROVEEDOR_AF")
        End Set
    End Property 

    Private _fkID_PROVEEDOR_AF As PROVEEDOR_AF
    Public Property fkID_PROVEEDOR_AF() As PROVEEDOR_AF
        Get
            Return _fkID_PROVEEDOR_AF
        End Get
        Set(ByVal Value As PROVEEDOR_AF)
            _fkID_PROVEEDOR_AF = Value
        End Set
    End Property 

    Private _ID_SITIO_CAPACITACION As Decimal
    <Column(Name:="Id sitio capacitacion", Storage:="ID_SITIO_CAPACITACION", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_SITIO_CAPACITACION() As Decimal
        Get
            Return _ID_SITIO_CAPACITACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_SITIO_CAPACITACION = Value
            OnPropertyChanged("ID_SITIO_CAPACITACION")
        End Set
    End Property 

    Private _fkID_SITIO_CAPACITACION As SITIO_CAPACITACION
    Public Property fkID_SITIO_CAPACITACION() As SITIO_CAPACITACION
        Get
            Return _fkID_SITIO_CAPACITACION
        End Get
        Set(ByVal Value As SITIO_CAPACITACION)
            _fkID_SITIO_CAPACITACION = Value
        End Set
    End Property 

    Private _ID_EJERCICIO As String
    <Column(Name:="Id ejercicio", Storage:="ID_EJERCICIO", DbType:="CHAR(4) NOT NULL", Id:=True), _
     DataObjectField(True, False, False, 4)> _
    Public Property ID_EJERCICIO() As String
        Get
            Return _ID_EJERCICIO
        End Get
        Set(ByVal Value As String)
            _ID_EJERCICIO = Value
            OnPropertyChanged("ID_EJERCICIO")
        End Set
    End Property 

    Private _fkID_EJERCICIO As SITIO_CAPACITACION_EJERCICIO
    Public Property fkID_EJERCICIO() As SITIO_CAPACITACION_EJERCICIO
        Get
            Return _fkID_EJERCICIO
        End Get
        Set(ByVal Value As SITIO_CAPACITACION_EJERCICIO)
            _fkID_EJERCICIO = Value
        End Set
    End Property 

    Private _DURACION_HORAS As Decimal
    <Column(Name:="Duracion horas", Storage:="DURACION_HORAS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property DURACION_HORAS() As Decimal
        Get
            Return _DURACION_HORAS
        End Get
        Set(ByVal Value As Decimal)
            _DURACION_HORAS = Value
            OnPropertyChanged("DURACION_HORAS")
        End Set
    End Property 

    Private _DURACION_HORASOld As Decimal
    Public Property DURACION_HORASOld() As Decimal
        Get
            Return _DURACION_HORASOld
        End Get
        Set(ByVal Value As Decimal)
            _DURACION_HORASOld = Value
        End Set
    End Property 

    Private _COSTO_X_PARTICIPANTE As Decimal
    <Column(Name:="Costo x participante", Storage:="COSTO_X_PARTICIPANTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=2)> _
    Public Property COSTO_X_PARTICIPANTE() As Decimal
        Get
            Return _COSTO_X_PARTICIPANTE
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_X_PARTICIPANTE = Value
            OnPropertyChanged("COSTO_X_PARTICIPANTE")
        End Set
    End Property 

    Private _COSTO_X_PARTICIPANTEOld As Decimal
    Public Property COSTO_X_PARTICIPANTEOld() As Decimal
        Get
            Return _COSTO_X_PARTICIPANTEOld
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_X_PARTICIPANTEOld = Value
        End Set
    End Property 

    Private _USER_ID As String
    <Column(Name:="User id", Storage:="USER_ID", DbType:="VARCHAR2(256)", Id:=False), _
     DataObjectField(False, False, True, 256)> _
    Public Property USER_ID() As String
        Get
            Return _USER_ID
        End Get
        Set(ByVal Value As String)
            _USER_ID = Value
            OnPropertyChanged("USER_ID")
        End Set
    End Property 

    Private _USER_IDOld As String
    Public Property USER_IDOld() As String
        Get
            Return _USER_IDOld
        End Get
        Set(ByVal Value As String)
            _USER_IDOld = Value
        End Set
    End Property 

    Private _LASTUPDATE As DateTime
    <Column(Name:="Lastupdate", Storage:="LASTUPDATE", DbType:="DATE", Id:=False), _
     DataObjectField(False, False, True)> _
    Public Property LASTUPDATE() As DateTime
        Get
            Return _LASTUPDATE
        End Get
        Set(ByVal Value As DateTime)
            _LASTUPDATE = Value
            OnPropertyChanged("LASTUPDATE")
        End Set
    End Property 

    Private _LASTUPDATEOld As DateTime
    Public Property LASTUPDATEOld() As DateTime
        Get
            Return _LASTUPDATEOld
        End Get
        Set(ByVal Value As DateTime)
            _LASTUPDATEOld = Value
        End Set
    End Property 


    Private _PARTICIPACION_ADJUDICADA As Decimal
    <Column(Name:="Participacion adjudicada", Storage:="PARTICIPACION_ADJUDICADA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property PARTICIPACION_ADJUDICADA() As Decimal
        Get
            Return _PARTICIPACION_ADJUDICADA
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPACION_ADJUDICADA = Value
            OnPropertyChanged("PARTICIPACION_ADJUDICADA")
        End Set
    End Property

    Private _PARTICIPACION_ADJUDICADAOld As Decimal
    Public Property PARTICIPACION_ADJUDICADAOld() As Decimal
        Get
            Return _PARTICIPACION_ADJUDICADAOld
        End Get
        Set(ByVal Value As Decimal)
            _PARTICIPACION_ADJUDICADAOld = Value
        End Set
    End Property

    Private _MONTO_ADJUDICADO As Decimal
    <Column(Name:="Monto adjudicado", Storage:="MONTO_ADJUDICADO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property MONTO_ADJUDICADO() As Decimal
        Get
            Return _MONTO_ADJUDICADO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_ADJUDICADO = Value
            OnPropertyChanged("MONTO_ADJUDICADO")
        End Set
    End Property

    Private _MONTO_ADJUDICADOOld As Decimal
    Public Property MONTO_ADJUDICADOOld() As Decimal
        Get
            Return _MONTO_ADJUDICADOOld
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_ADJUDICADOOld = Value
        End Set
    End Property
#End Region

#Region " Relaciones "
#End Region
#End Region
End Class

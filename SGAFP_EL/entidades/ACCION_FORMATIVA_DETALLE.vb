''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.ACCION_FORMATIVA_DETALLE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row ACCION_FORMATIVA_DETALLE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="ACCION_FORMATIVA_DETALLE")> Public Class ACCION_FORMATIVA_DETALLE
    Inherits entidadBase
    Implements IEquatable(Of ACCION_FORMATIVA_DETALLE), IComparable(Of ACCION_FORMATIVA_DETALLE)

#Region " Metodos Generador "

  

    Public Sub New(aID_ACCION_FORMATIVA As Decimal, aID_PROGRAMA_FORMACION As Decimal, aID_MODALIDAD_FORMACION As Decimal, aID_CONTRATO As Decimal, aID_FUENTE As Decimal, aNO_CONVOCATORIA As Decimal, aCODIGO_DEPARTAMENTO As String, aCODIGO_MUNICIPIO As String, aLUGAR_EJECUCION As String, aTELEFONO As String, aCONTACTO As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_ACCION_FORMATIVA = aID_ACCION_FORMATIVA
        Me._ID_PROGRAMA_FORMACION = aID_PROGRAMA_FORMACION
        Me._ID_MODALIDAD_FORMACION = aID_MODALIDAD_FORMACION
        Me._ID_CONTRATO = aID_CONTRATO
        Me._ID_FUENTE = aID_FUENTE
        Me._NO_CONVOCATORIA = aNO_CONVOCATORIA
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._LUGAR_EJECUCION = aLUGAR_EJECUCION
        Me._TELEFONO = aTELEFONO
        Me._CONTACTO = aCONTACTO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As ACCION_FORMATIVA_DETALLE) As Boolean Implements System.IEquatable(Of ACCION_FORMATIVA_DETALLE).Equals
        Return Me.ID_ACCION_FORMATIVA = other.ID_ACCION_FORMATIVA
    End Function

    Public Function CompareTo(ByVal other As ACCION_FORMATIVA_DETALLE) As Integer Implements System.IComparable(Of ACCION_FORMATIVA_DETALLE).CompareTo
        If Me.ID_ACCION_FORMATIVA > other.ID_ACCION_FORMATIVA Then Return 1
        If Me.ID_ACCION_FORMATIVA < other.ID_ACCION_FORMATIVA Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_ACCION_FORMATIVA As Decimal
    <Column(Name:="Id accion formativa", Storage:="ID_ACCION_FORMATIVA", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            Return _ID_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As Decimal)
            _ID_ACCION_FORMATIVA = Value
            OnPropertyChanged("ID_ACCION_FORMATIVA")
        End Set
    End Property 

    Private _fkID_ACCION_FORMATIVA As ACCION_FORMATIVA
    Public Property fkID_ACCION_FORMATIVA() As ACCION_FORMATIVA
        Get
            Return _fkID_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As ACCION_FORMATIVA)
            _fkID_ACCION_FORMATIVA = Value
        End Set
    End Property 

    Private _ID_PROGRAMA_FORMACION As Decimal
    <Column(Name:="Id programa formacion", Storage:="ID_PROGRAMA_FORMACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_PROGRAMA_FORMACION() As Decimal
        Get
            Return _ID_PROGRAMA_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROGRAMA_FORMACION = Value
            OnPropertyChanged("ID_PROGRAMA_FORMACION")
        End Set
    End Property 

    Private _ID_PROGRAMA_FORMACIONOld As Decimal
    Public Property ID_PROGRAMA_FORMACIONOld() As Decimal
        Get
            Return _ID_PROGRAMA_FORMACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROGRAMA_FORMACIONOld = Value
        End Set
    End Property 

    Private _fkID_PROGRAMA_FORMACION As PROGRAMA_FORMACION
    Public Property fkID_PROGRAMA_FORMACION() As PROGRAMA_FORMACION
        Get
            Return _fkID_PROGRAMA_FORMACION
        End Get
        Set(ByVal Value As PROGRAMA_FORMACION)
            _fkID_PROGRAMA_FORMACION = Value
        End Set
    End Property 

    Private _ID_MODALIDAD_FORMACION As Decimal
    <Column(Name:="Id modalidad formacion", Storage:="ID_MODALIDAD_FORMACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_MODALIDAD_FORMACION() As Decimal
        Get
            Return _ID_MODALIDAD_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_MODALIDAD_FORMACION = Value
            OnPropertyChanged("ID_MODALIDAD_FORMACION")
        End Set
    End Property 

    Private _ID_MODALIDAD_FORMACIONOld As Decimal
    Public Property ID_MODALIDAD_FORMACIONOld() As Decimal
        Get
            Return _ID_MODALIDAD_FORMACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_MODALIDAD_FORMACIONOld = Value
        End Set
    End Property 

    Private _fkID_MODALIDAD_FORMACION As MODALIDAD_DE_FORMACION
    Public Property fkID_MODALIDAD_FORMACION() As MODALIDAD_DE_FORMACION
        Get
            Return _fkID_MODALIDAD_FORMACION
        End Get
        Set(ByVal Value As MODALIDAD_DE_FORMACION)
            _fkID_MODALIDAD_FORMACION = Value
        End Set
    End Property 

    Private _ID_CONTRATO As Decimal
    <Column(Name:="Id contrato", Storage:="ID_CONTRATO", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CONTRATO() As Decimal
        Get
            Return _ID_CONTRATO
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATO = Value
            OnPropertyChanged("ID_CONTRATO")
        End Set
    End Property 

    Private _ID_CONTRATOOld As Decimal
    Public Property ID_CONTRATOOld() As Decimal
        Get
            Return _ID_CONTRATOOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_CONTRATOOld = Value
        End Set
    End Property 

    Private _fkID_CONTRATO As CONTRATO_PROVEEDOR_AF
    Public Property fkID_CONTRATO() As CONTRATO_PROVEEDOR_AF
        Get
            Return _fkID_CONTRATO
        End Get
        Set(ByVal Value As CONTRATO_PROVEEDOR_AF)
            _fkID_CONTRATO = Value
        End Set
    End Property 

    Private _ID_FUENTE As Decimal
    <Column(Name:="Id fuente", Storage:="ID_FUENTE", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_FUENTE() As Decimal
        Get
            Return _ID_FUENTE
        End Get
        Set(ByVal Value As Decimal)
            _ID_FUENTE = Value
            OnPropertyChanged("ID_FUENTE")
        End Set
    End Property 

    Private _ID_FUENTEOld As Decimal
    Public Property ID_FUENTEOld() As Decimal
        Get
            Return _ID_FUENTEOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_FUENTEOld = Value
        End Set
    End Property 

    Private _fkID_FUENTE As FUENTE_FINANCIAMIENTO
    Public Property fkID_FUENTE() As FUENTE_FINANCIAMIENTO
        Get
            Return _fkID_FUENTE
        End Get
        Set(ByVal Value As FUENTE_FINANCIAMIENTO)
            _fkID_FUENTE = Value
        End Set
    End Property 

    Private _NO_CONVOCATORIA As Decimal
    <Column(Name:="No convocatoria", Storage:="NO_CONVOCATORIA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property NO_CONVOCATORIA() As Decimal
        Get
            Return _NO_CONVOCATORIA
        End Get
        Set(ByVal Value As Decimal)
            _NO_CONVOCATORIA = Value
            OnPropertyChanged("NO_CONVOCATORIA")
        End Set
    End Property 

    Private _NO_CONVOCATORIAOld As Decimal
    Public Property NO_CONVOCATORIAOld() As Decimal
        Get
            Return _NO_CONVOCATORIAOld
        End Get
        Set(ByVal Value As Decimal)
            _NO_CONVOCATORIAOld = Value
        End Set
    End Property 

    Private _CODIGO_DEPARTAMENTO As String
    <Column(Name:="Codigo departamento", Storage:="CODIGO_DEPARTAMENTO", DbType:="VARCHAR2(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return _CODIGO_DEPARTAMENTO
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPARTAMENTO = Value
            OnPropertyChanged("CODIGO_DEPARTAMENTO")
        End Set
    End Property 

    Private _CODIGO_DEPARTAMENTOOld As String
    Public Property CODIGO_DEPARTAMENTOOld() As String
        Get
            Return _CODIGO_DEPARTAMENTOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPARTAMENTOOld = Value
        End Set
    End Property 

    Private _fkCODIGO_DEPARTAMENTO As DEPARTAMENTO
    Public Property fkCODIGO_DEPARTAMENTO() As DEPARTAMENTO
        Get
            Return _fkCODIGO_DEPARTAMENTO
        End Get
        Set(ByVal Value As DEPARTAMENTO)
            _fkCODIGO_DEPARTAMENTO = Value
        End Set
    End Property 

    Private _CODIGO_MUNICIPIO As String
    <Column(Name:="Codigo municipio", Storage:="CODIGO_MUNICIPIO", DbType:="VARCHAR2(2) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 2)> _
    Public Property CODIGO_MUNICIPIO() As String
        Get
            Return _CODIGO_MUNICIPIO
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNICIPIO = Value
            OnPropertyChanged("CODIGO_MUNICIPIO")
        End Set
    End Property 

    Private _CODIGO_MUNICIPIOOld As String
    Public Property CODIGO_MUNICIPIOOld() As String
        Get
            Return _CODIGO_MUNICIPIOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNICIPIOOld = Value
        End Set
    End Property 

    Private _fkCODIGO_MUNICIPIO As MUNICIPIO
    Public Property fkCODIGO_MUNICIPIO() As MUNICIPIO
        Get
            Return _fkCODIGO_MUNICIPIO
        End Get
        Set(ByVal Value As MUNICIPIO)
            _fkCODIGO_MUNICIPIO = Value
        End Set
    End Property 

    Private _LUGAR_EJECUCION As String
    <Column(Name:="Lugar ejecucion", Storage:="LUGAR_EJECUCION", DbType:="VARCHAR2(255)", Id:=False), _
     DataObjectField(False, False, True, 255)> _
    Public Property LUGAR_EJECUCION() As String
        Get
            Return _LUGAR_EJECUCION
        End Get
        Set(ByVal Value As String)
            _LUGAR_EJECUCION = Value
            OnPropertyChanged("LUGAR_EJECUCION")
        End Set
    End Property 

    Private _LUGAR_EJECUCIONOld As String
    Public Property LUGAR_EJECUCIONOld() As String
        Get
            Return _LUGAR_EJECUCIONOld
        End Get
        Set(ByVal Value As String)
            _LUGAR_EJECUCIONOld = Value
        End Set
    End Property 

    Private _TELEFONO As String
    <Column(Name:="Telefono", Storage:="TELEFONO", DbType:="VARCHAR2(10)", Id:=False), _
     DataObjectField(False, False, True, 10)> _
    Public Property TELEFONO() As String
        Get
            Return _TELEFONO
        End Get
        Set(ByVal Value As String)
            _TELEFONO = Value
            OnPropertyChanged("TELEFONO")
        End Set
    End Property 

    Private _TELEFONOOld As String
    Public Property TELEFONOOld() As String
        Get
            Return _TELEFONOOld
        End Get
        Set(ByVal Value As String)
            _TELEFONOOld = Value
        End Set
    End Property 

    Private _CONTACTO As String
    <Column(Name:="Contacto", Storage:="CONTACTO", DbType:="VARCHAR2(50)", Id:=False), _
     DataObjectField(False, False, True, 50)> _
    Public Property CONTACTO() As String
        Get
            Return _CONTACTO
        End Get
        Set(ByVal Value As String)
            _CONTACTO = Value
            OnPropertyChanged("CONTACTO")
        End Set
    End Property 

    Private _CONTACTOOld As String
    Public Property CONTACTOOld() As String
        Get
            Return _CONTACTOOld
        End Get
        Set(ByVal Value As String)
            _CONTACTOOld = Value
        End Set
    End Property 

    Private _USERID As String
    <Column(Name:="Userid", Storage:="USERID", DbType:="VARCHAR2(256) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 256)> _
    Public Property USERID() As String
        Get
            Return _USERID
        End Get
        Set(ByVal Value As String)
            _USERID = Value
            OnPropertyChanged("USERID")
        End Set
    End Property 

    Private _USERIDOld As String
    Public Property USERIDOld() As String
        Get
            Return _USERIDOld
        End Get
        Set(ByVal Value As String)
            _USERIDOld = Value
        End Set
    End Property 

    Private _LASTUPDATE As DateTime
    <Column(Name:="Lastupdate", Storage:="LASTUPDATE", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
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
   
    
#End Region

#Region " Relaciones "
#End Region
#End Region
End Class

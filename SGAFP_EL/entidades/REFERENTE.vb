''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.REFERENTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row REFERENTE en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="REFERENTE")> Public Class REFERENTE
    Inherits entidadBase
    Implements IEquatable(Of REFERENTE), IComparable(Of REFERENTE)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_REFERENTE As Decimal, aCODIGO_DEPARTAMENTO As String, aCODIGO_MUNICIPIO As String, aNOMBRE_REFERENTE As String, aDIRECCION_REFERENTE As String, aTELEF1 As String, aTELEF2 As String, aTELEF3 As String, aTELEF_MOVIL As String, aFAX As String, aNOMBRE_CONTACTO As String, aAPELLIDOS_CONTACTO As String, aEMAIL_CONTACTO As String, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_REFERENTE = aID_REFERENTE
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._NOMBRE_REFERENTE = aNOMBRE_REFERENTE
        Me._DIRECCION_REFERENTE = aDIRECCION_REFERENTE
        Me._TELEF1 = aTELEF1
        Me._TELEF2 = aTELEF2
        Me._TELEF3 = aTELEF3
        Me._TELEF_MOVIL = aTELEF_MOVIL
        Me._FAX = aFAX
        Me._NOMBRE_CONTACTO = aNOMBRE_CONTACTO
        Me._APELLIDOS_CONTACTO = aAPELLIDOS_CONTACTO
        Me._EMAIL_CONTACTO = aEMAIL_CONTACTO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As REFERENTE) As Boolean Implements System.IEquatable(Of REFERENTE).Equals
        Return Me.ID_REFERENTE = other.ID_REFERENTE
    End Function

    Public Function CompareTo(ByVal other As REFERENTE) As Integer Implements System.IComparable(Of REFERENTE).CompareTo
        If Me.ID_REFERENTE > other.ID_REFERENTE Then Return 1
        If Me.ID_REFERENTE < other.ID_REFERENTE Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_REFERENTE As Decimal
    <Column(Name:="Id referente", Storage:="ID_REFERENTE", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_REFERENTE() As Decimal
        Get
            Return _ID_REFERENTE
        End Get
        Set(ByVal Value As Decimal)
            _ID_REFERENTE = Value
            OnPropertyChanged("ID_REFERENTE")
        End Set
    End Property 

    Private _CODIGO_DEPARTAMENTO As String
    <Column(Name:="Codigo departamento", Storage:="CODIGO_DEPARTAMENTO", DbType:="VARCHAR2(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
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
    <Column(Name:="Codigo municipio", Storage:="CODIGO_MUNICIPIO", DbType:="VARCHAR2(2)", Id:=False), _
     DataObjectField(False, False, True, 2)> _
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

    Private _NOMBRE_REFERENTE As String
    <Column(Name:="Nombre referente", Storage:="NOMBRE_REFERENTE", DbType:="VARCHAR2(150) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 150)> _
    Public Property NOMBRE_REFERENTE() As String
        Get
            Return _NOMBRE_REFERENTE
        End Get
        Set(ByVal Value As String)
            _NOMBRE_REFERENTE = Value
            OnPropertyChanged("NOMBRE_REFERENTE")
        End Set
    End Property 

    Private _NOMBRE_REFERENTEOld As String
    Public Property NOMBRE_REFERENTEOld() As String
        Get
            Return _NOMBRE_REFERENTEOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_REFERENTEOld = Value
        End Set
    End Property 

    Private _DIRECCION_REFERENTE As String
    <Column(Name:="Direccion referente", Storage:="DIRECCION_REFERENTE", DbType:="VARCHAR2(150) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 150)> _
    Public Property DIRECCION_REFERENTE() As String
        Get
            Return _DIRECCION_REFERENTE
        End Get
        Set(ByVal Value As String)
            _DIRECCION_REFERENTE = Value
            OnPropertyChanged("DIRECCION_REFERENTE")
        End Set
    End Property 

    Private _DIRECCION_REFERENTEOld As String
    Public Property DIRECCION_REFERENTEOld() As String
        Get
            Return _DIRECCION_REFERENTEOld
        End Get
        Set(ByVal Value As String)
            _DIRECCION_REFERENTEOld = Value
        End Set
    End Property 

    Private _TELEF1 As String
    <Column(Name:="Telef1", Storage:="TELEF1", DbType:="VARCHAR2(9) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 9)> _
    Public Property TELEF1() As String
        Get
            Return _TELEF1
        End Get
        Set(ByVal Value As String)
            _TELEF1 = Value
            OnPropertyChanged("TELEF1")
        End Set
    End Property 

    Private _TELEF1Old As String
    Public Property TELEF1Old() As String
        Get
            Return _TELEF1Old
        End Get
        Set(ByVal Value As String)
            _TELEF1Old = Value
        End Set
    End Property 

    Private _TELEF2 As String
    <Column(Name:="Telef2", Storage:="TELEF2", DbType:="VARCHAR2(9)", Id:=False), _
     DataObjectField(False, False, True, 9)> _
    Public Property TELEF2() As String
        Get
            Return _TELEF2
        End Get
        Set(ByVal Value As String)
            _TELEF2 = Value
            OnPropertyChanged("TELEF2")
        End Set
    End Property 

    Private _TELEF2Old As String
    Public Property TELEF2Old() As String
        Get
            Return _TELEF2Old
        End Get
        Set(ByVal Value As String)
            _TELEF2Old = Value
        End Set
    End Property 

    Private _TELEF3 As String
    <Column(Name:="Telef3", Storage:="TELEF3", DbType:="VARCHAR2(9)", Id:=False), _
     DataObjectField(False, False, True, 9)> _
    Public Property TELEF3() As String
        Get
            Return _TELEF3
        End Get
        Set(ByVal Value As String)
            _TELEF3 = Value
            OnPropertyChanged("TELEF3")
        End Set
    End Property 

    Private _TELEF3Old As String
    Public Property TELEF3Old() As String
        Get
            Return _TELEF3Old
        End Get
        Set(ByVal Value As String)
            _TELEF3Old = Value
        End Set
    End Property 

    Private _TELEF_MOVIL As String
    <Column(Name:="Telef movil", Storage:="TELEF_MOVIL", DbType:="VARCHAR2(9)", Id:=False), _
     DataObjectField(False, False, True, 9)> _
    Public Property TELEF_MOVIL() As String
        Get
            Return _TELEF_MOVIL
        End Get
        Set(ByVal Value As String)
            _TELEF_MOVIL = Value
            OnPropertyChanged("TELEF_MOVIL")
        End Set
    End Property 

    Private _TELEF_MOVILOld As String
    Public Property TELEF_MOVILOld() As String
        Get
            Return _TELEF_MOVILOld
        End Get
        Set(ByVal Value As String)
            _TELEF_MOVILOld = Value
        End Set
    End Property 

    Private _FAX As String
    <Column(Name:="Fax", Storage:="FAX", DbType:="VARCHAR2(9)", Id:=False), _
     DataObjectField(False, False, True, 9)> _
    Public Property FAX() As String
        Get
            Return _FAX
        End Get
        Set(ByVal Value As String)
            _FAX = Value
            OnPropertyChanged("FAX")
        End Set
    End Property 

    Private _FAXOld As String
    Public Property FAXOld() As String
        Get
            Return _FAXOld
        End Get
        Set(ByVal Value As String)
            _FAXOld = Value
        End Set
    End Property 

    Private _NOMBRE_CONTACTO As String
    <Column(Name:="Nombre contacto", Storage:="NOMBRE_CONTACTO", DbType:="VARCHAR2(30) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 30)> _
    Public Property NOMBRE_CONTACTO() As String
        Get
            Return _NOMBRE_CONTACTO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CONTACTO = Value
            OnPropertyChanged("NOMBRE_CONTACTO")
        End Set
    End Property 

    Private _NOMBRE_CONTACTOOld As String
    Public Property NOMBRE_CONTACTOOld() As String
        Get
            Return _NOMBRE_CONTACTOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CONTACTOOld = Value
        End Set
    End Property 

    Private _APELLIDOS_CONTACTO As String
    <Column(Name:="Apellidos contacto", Storage:="APELLIDOS_CONTACTO", DbType:="VARCHAR2(30) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 30)> _
    Public Property APELLIDOS_CONTACTO() As String
        Get
            Return _APELLIDOS_CONTACTO
        End Get
        Set(ByVal Value As String)
            _APELLIDOS_CONTACTO = Value
            OnPropertyChanged("APELLIDOS_CONTACTO")
        End Set
    End Property 

    Private _APELLIDOS_CONTACTOOld As String
    Public Property APELLIDOS_CONTACTOOld() As String
        Get
            Return _APELLIDOS_CONTACTOOld
        End Get
        Set(ByVal Value As String)
            _APELLIDOS_CONTACTOOld = Value
        End Set
    End Property 

    Private _EMAIL_CONTACTO As String
    <Column(Name:="Email contacto", Storage:="EMAIL_CONTACTO", DbType:="VARCHAR2(250)", Id:=False), _
     DataObjectField(False, False, True, 250)> _
    Public Property EMAIL_CONTACTO() As String
        Get
            Return _EMAIL_CONTACTO
        End Get
        Set(ByVal Value As String)
            _EMAIL_CONTACTO = Value
            OnPropertyChanged("EMAIL_CONTACTO")
        End Set
    End Property 

    Private _EMAIL_CONTACTOOld As String
    Public Property EMAIL_CONTACTOOld() As String
        Get
            Return _EMAIL_CONTACTOOld
        End Get
        Set(ByVal Value As String)
            _EMAIL_CONTACTOOld = Value
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

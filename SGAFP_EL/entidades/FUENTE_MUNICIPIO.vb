''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.FUENTE_MUNICIPIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row FUENTE_MUNICIPIO en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/11/2013	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="FUENTE_MUNICIPIO")> Public Class FUENTE_MUNICIPIO
    Inherits entidadBase
    Implements IEquatable(Of FUENTE_MUNICIPIO), IComparable(Of FUENTE_MUNICIPIO)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_FUENTE_MUNICIPIO As Decimal, aID_FUENTE As Decimal, aNO_CONVOCATORIA As Decimal, aCODIGO_DEPARTAMENTO As String, aCODIGO_MUNICIPIO As String, aNOMBRE_BANCO_LIQ As String, aNO_CTA_LIQ As String, aNOMBRE_CTA_LIQ As String, aCODIGO_FINANCIAMIENTO As String, aNOMBRE_BANCO_DESEMBOLSO As String, aNO_CTA_DESEMBOLSO As String, aNOMBRE_CTA_DESEMBOLSO As String, aUSUARIO_CREACION As String, aFECHA_CREACION As DateTime, aUSERID As String, aLASTUPDATE As DateTime)
        Me._ID_FUENTE_MUNICIPIO = aID_FUENTE_MUNICIPIO
        Me._ID_FUENTE = aID_FUENTE
        Me._NO_CONVOCATORIA = aNO_CONVOCATORIA
        Me._CODIGO_DEPARTAMENTO = aCODIGO_DEPARTAMENTO
        Me._CODIGO_MUNICIPIO = aCODIGO_MUNICIPIO
        Me._NOMBRE_BANCO_LIQ = aNOMBRE_BANCO_LIQ
        Me._NO_CTA_LIQ = aNO_CTA_LIQ
        Me._NOMBRE_CTA_LIQ = aNOMBRE_CTA_LIQ
        Me._CODIGO_FINANCIAMIENTO = aCODIGO_FINANCIAMIENTO
        Me._NOMBRE_BANCO_DESEMBOLSO = aNOMBRE_BANCO_DESEMBOLSO
        Me._NO_CTA_DESEMBOLSO = aNO_CTA_DESEMBOLSO
        Me._NOMBRE_CTA_DESEMBOLSO = aNOMBRE_CTA_DESEMBOLSO
        Me._USUARIO_CREACION = aUSUARIO_CREACION
        Me._FECHA_CREACION = aFECHA_CREACION
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
    End Sub

    Public Function Equals1(ByVal other As FUENTE_MUNICIPIO) As Boolean Implements System.IEquatable(Of FUENTE_MUNICIPIO).Equals
        Return Me.ID_FUENTE_MUNICIPIO = other.ID_FUENTE_MUNICIPIO
    End Function

    Public Function CompareTo(ByVal other As FUENTE_MUNICIPIO) As Integer Implements System.IComparable(Of FUENTE_MUNICIPIO).CompareTo
        If Me.ID_FUENTE_MUNICIPIO > other.ID_FUENTE_MUNICIPIO Then Return 1
        If Me.ID_FUENTE_MUNICIPIO < other.ID_FUENTE_MUNICIPIO Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_FUENTE_MUNICIPIO As Decimal
    <Column(Name:="Id fuente municipio", Storage:="ID_FUENTE_MUNICIPIO", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_FUENTE_MUNICIPIO() As Decimal
        Get
            Return _ID_FUENTE_MUNICIPIO
        End Get
        Set(ByVal Value As Decimal)
            _ID_FUENTE_MUNICIPIO = Value
            OnPropertyChanged("ID_FUENTE_MUNICIPIO")
        End Set
    End Property 

    Private _ID_FUENTE As Decimal
    <Column(Name:="Id fuente", Storage:="ID_FUENTE", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
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
    <Column(Name:="No convocatoria", Storage:="NO_CONVOCATORIA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=2, Scale:=0)> _
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

    Private _NOMBRE_BANCO_LIQ As String
    <Column(Name:="Nombre banco liq", Storage:="NOMBRE_BANCO_LIQ", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property NOMBRE_BANCO_LIQ() As String
        Get
            Return _NOMBRE_BANCO_LIQ
        End Get
        Set(ByVal Value As String)
            _NOMBRE_BANCO_LIQ = Value
            OnPropertyChanged("NOMBRE_BANCO_LIQ")
        End Set
    End Property 

    Private _NOMBRE_BANCO_LIQOld As String
    Public Property NOMBRE_BANCO_LIQOld() As String
        Get
            Return _NOMBRE_BANCO_LIQOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_BANCO_LIQOld = Value
        End Set
    End Property 

    Private _NO_CTA_LIQ As String
    <Column(Name:="No cta liq", Storage:="NO_CTA_LIQ", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property NO_CTA_LIQ() As String
        Get
            Return _NO_CTA_LIQ
        End Get
        Set(ByVal Value As String)
            _NO_CTA_LIQ = Value
            OnPropertyChanged("NO_CTA_LIQ")
        End Set
    End Property 

    Private _NO_CTA_LIQOld As String
    Public Property NO_CTA_LIQOld() As String
        Get
            Return _NO_CTA_LIQOld
        End Get
        Set(ByVal Value As String)
            _NO_CTA_LIQOld = Value
        End Set
    End Property 

    Private _NOMBRE_CTA_LIQ As String
    <Column(Name:="Nombre cta liq", Storage:="NOMBRE_CTA_LIQ", DbType:="VARCHAR2(150)", Id:=False), _
     DataObjectField(False, False, True, 150)> _
    Public Property NOMBRE_CTA_LIQ() As String
        Get
            Return _NOMBRE_CTA_LIQ
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CTA_LIQ = Value
            OnPropertyChanged("NOMBRE_CTA_LIQ")
        End Set
    End Property 

    Private _NOMBRE_CTA_LIQOld As String
    Public Property NOMBRE_CTA_LIQOld() As String
        Get
            Return _NOMBRE_CTA_LIQOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CTA_LIQOld = Value
        End Set
    End Property 

    Private _CODIGO_FINANCIAMIENTO As String
    <Column(Name:="Codigo financiamiento", Storage:="CODIGO_FINANCIAMIENTO", DbType:="VARCHAR2(100)", Id:=False), _
     DataObjectField(False, False, True, 100)> _
    Public Property CODIGO_FINANCIAMIENTO() As String
        Get
            Return _CODIGO_FINANCIAMIENTO
        End Get
        Set(ByVal Value As String)
            _CODIGO_FINANCIAMIENTO = Value
            OnPropertyChanged("CODIGO_FINANCIAMIENTO")
        End Set
    End Property 

    Private _CODIGO_FINANCIAMIENTOOld As String
    Public Property CODIGO_FINANCIAMIENTOOld() As String
        Get
            Return _CODIGO_FINANCIAMIENTOOld
        End Get
        Set(ByVal Value As String)
            _CODIGO_FINANCIAMIENTOOld = Value
        End Set
    End Property 

    Private _NOMBRE_BANCO_DESEMBOLSO As String
    <Column(Name:="Nombre banco desembolso", Storage:="NOMBRE_BANCO_DESEMBOLSO", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property NOMBRE_BANCO_DESEMBOLSO() As String
        Get
            Return _NOMBRE_BANCO_DESEMBOLSO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_BANCO_DESEMBOLSO = Value
            OnPropertyChanged("NOMBRE_BANCO_DESEMBOLSO")
        End Set
    End Property 

    Private _NOMBRE_BANCO_DESEMBOLSOOld As String
    Public Property NOMBRE_BANCO_DESEMBOLSOOld() As String
        Get
            Return _NOMBRE_BANCO_DESEMBOLSOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_BANCO_DESEMBOLSOOld = Value
        End Set
    End Property 

    Private _NO_CTA_DESEMBOLSO As String
    <Column(Name:="No cta desembolso", Storage:="NO_CTA_DESEMBOLSO", DbType:="VARCHAR2(20)", Id:=False), _
     DataObjectField(False, False, True, 20)> _
    Public Property NO_CTA_DESEMBOLSO() As String
        Get
            Return _NO_CTA_DESEMBOLSO
        End Get
        Set(ByVal Value As String)
            _NO_CTA_DESEMBOLSO = Value
            OnPropertyChanged("NO_CTA_DESEMBOLSO")
        End Set
    End Property 

    Private _NO_CTA_DESEMBOLSOOld As String
    Public Property NO_CTA_DESEMBOLSOOld() As String
        Get
            Return _NO_CTA_DESEMBOLSOOld
        End Get
        Set(ByVal Value As String)
            _NO_CTA_DESEMBOLSOOld = Value
        End Set
    End Property 

    Private _NOMBRE_CTA_DESEMBOLSO As String
    <Column(Name:="Nombre cta desembolso", Storage:="NOMBRE_CTA_DESEMBOLSO", DbType:="VARCHAR2(150)", Id:=False), _
     DataObjectField(False, False, True, 150)> _
    Public Property NOMBRE_CTA_DESEMBOLSO() As String
        Get
            Return _NOMBRE_CTA_DESEMBOLSO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CTA_DESEMBOLSO = Value
            OnPropertyChanged("NOMBRE_CTA_DESEMBOLSO")
        End Set
    End Property 

    Private _NOMBRE_CTA_DESEMBOLSOOld As String
    Public Property NOMBRE_CTA_DESEMBOLSOOld() As String
        Get
            Return _NOMBRE_CTA_DESEMBOLSOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRE_CTA_DESEMBOLSOOld = Value
        End Set
    End Property 

    Private _USUARIO_CREACION As String
    <Column(Name:="Usuario creacion", Storage:="USUARIO_CREACION", DbType:="VARCHAR2(250) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 250)> _
    Public Property USUARIO_CREACION() As String
        Get
            Return _USUARIO_CREACION
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREACION = Value
            OnPropertyChanged("USUARIO_CREACION")
        End Set
    End Property 

    Private _USUARIO_CREACIONOld As String
    Public Property USUARIO_CREACIONOld() As String
        Get
            Return _USUARIO_CREACIONOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREACIONOld = Value
        End Set
    End Property 

    Private _FECHA_CREACION As DateTime
    <Column(Name:="Fecha creacion", Storage:="FECHA_CREACION", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_CREACION() As DateTime
        Get
            Return _FECHA_CREACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREACION = Value
            OnPropertyChanged("FECHA_CREACION")
        End Set
    End Property 

    Private _FECHA_CREACIONOld As DateTime
    Public Property FECHA_CREACIONOld() As DateTime
        Get
            Return _FECHA_CREACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREACIONOld = Value
        End Set
    End Property 

    Private _USERID As String
    <Column(Name:="Userid", Storage:="USERID", DbType:="VARCHAR2(250) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 250)> _
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

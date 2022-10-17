''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.SOLICITUD_CAPACITACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row SOLICITUD_CAPACITACION en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/10/2016	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="SOLICITUD_CAPACITACION")> Public Class SOLICITUD_CAPACITACION
    Inherits entidadBase
    Implements IEquatable(Of SOLICITUD_CAPACITACION), IComparable(Of SOLICITUD_CAPACITACION)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_SOLICITUD As Decimal, aID_REFERENTE As Decimal, aID_CENTRO_RESPONSABILIDAD As Decimal, aID_UNIDAD_ORGANIZATIVA As Decimal, aID_PROGRAMA_FORMACION As Decimal, aID_PROYECTO_FORMACION As Decimal, aFECHA_SOLICITUD As DateTime, aOBJETIVO_CAPACITACION As String, aHORARIO As String, aTELEF1 As String, aTELEF2 As String, aTELEF3 As String, aTELEF_MOVIL As String, aFAX As String, aNOMBRES_CONTACTO As String, aAPELLIDOS_CONTACTO As String, aEMAIL_CONTACTO As String, aUSERID As String, aLASTUPDATE As DateTime, aPORC_PAGO_INFORME1 As Decimal)
        Me._ID_SOLICITUD = aID_SOLICITUD
        Me._ID_REFERENTE = aID_REFERENTE
        Me._ID_CENTRO_RESPONSABILIDAD = aID_CENTRO_RESPONSABILIDAD
        Me._ID_UNIDAD_ORGANIZATIVA = aID_UNIDAD_ORGANIZATIVA
        Me._ID_PROGRAMA_FORMACION = aID_PROGRAMA_FORMACION
        Me._ID_PROYECTO_FORMACION = aID_PROYECTO_FORMACION
        Me._FECHA_SOLICITUD = aFECHA_SOLICITUD
        Me._OBJETIVO_CAPACITACION = aOBJETIVO_CAPACITACION
        Me._HORARIO = aHORARIO
        Me._TELEF1 = aTELEF1
        Me._TELEF2 = aTELEF2
        Me._TELEF3 = aTELEF3
        Me._TELEF_MOVIL = aTELEF_MOVIL
        Me._FAX = aFAX
        Me._NOMBRES_CONTACTO = aNOMBRES_CONTACTO
        Me._APELLIDOS_CONTACTO = aAPELLIDOS_CONTACTO
        Me._EMAIL_CONTACTO = aEMAIL_CONTACTO
        Me._USERID = aUSERID
        Me._LASTUPDATE = aLASTUPDATE
        Me._PORC_PAGO_INFORME1 = aPORC_PAGO_INFORME1
    End Sub

    Public Function Equals1(ByVal other As SOLICITUD_CAPACITACION) As Boolean Implements System.IEquatable(Of SOLICITUD_CAPACITACION).Equals
        Return Me.ID_SOLICITUD = other.ID_SOLICITUD
    End Function

    Public Function CompareTo(ByVal other As SOLICITUD_CAPACITACION) As Integer Implements System.IComparable(Of SOLICITUD_CAPACITACION).CompareTo
        If Me.ID_SOLICITUD > other.ID_SOLICITUD Then Return 1
        If Me.ID_SOLICITUD < other.ID_SOLICITUD Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_SOLICITUD As Decimal
    <Column(Name:="Id solicitud", Storage:="ID_SOLICITUD", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_SOLICITUD() As Decimal
        Get
            Return _ID_SOLICITUD
        End Get
        Set(ByVal Value As Decimal)
            _ID_SOLICITUD = Value
            OnPropertyChanged("ID_SOLICITUD")
        End Set
    End Property 

    Private _ID_REFERENTE As Decimal
    <Column(Name:="Id referente", Storage:="ID_REFERENTE", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_REFERENTE() As Decimal
        Get
            Return _ID_REFERENTE
        End Get
        Set(ByVal Value As Decimal)
            _ID_REFERENTE = Value
            OnPropertyChanged("ID_REFERENTE")
        End Set
    End Property 

    Private _ID_REFERENTEOld As Decimal
    Public Property ID_REFERENTEOld() As Decimal
        Get
            Return _ID_REFERENTEOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_REFERENTEOld = Value
        End Set
    End Property 

    Private _fkID_REFERENTE As REFERENTE
    Public Property fkID_REFERENTE() As REFERENTE
        Get
            Return _fkID_REFERENTE
        End Get
        Set(ByVal Value As REFERENTE)
            _fkID_REFERENTE = Value
        End Set
    End Property 

    Private _ID_CENTRO_RESPONSABILIDAD As Decimal
    <Column(Name:="Id centro responsabilidad", Storage:="ID_CENTRO_RESPONSABILIDAD", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_CENTRO_RESPONSABILIDAD() As Decimal
        Get
            Return _ID_CENTRO_RESPONSABILIDAD
        End Get
        Set(ByVal Value As Decimal)
            _ID_CENTRO_RESPONSABILIDAD = Value
            OnPropertyChanged("ID_CENTRO_RESPONSABILIDAD")
        End Set
    End Property 

    Private _ID_CENTRO_RESPONSABILIDADOld As Decimal
    Public Property ID_CENTRO_RESPONSABILIDADOld() As Decimal
        Get
            Return _ID_CENTRO_RESPONSABILIDADOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_CENTRO_RESPONSABILIDADOld = Value
        End Set
    End Property 

    Private _fkID_CENTRO_RESPONSABILIDAD As CENTRO_RESPONSABILIDAD
    Public Property fkID_CENTRO_RESPONSABILIDAD() As CENTRO_RESPONSABILIDAD
        Get
            Return _fkID_CENTRO_RESPONSABILIDAD
        End Get
        Set(ByVal Value As CENTRO_RESPONSABILIDAD)
            _fkID_CENTRO_RESPONSABILIDAD = Value
        End Set
    End Property 

    Private _ID_UNIDAD_ORGANIZATIVA As Decimal
    <Column(Name:="Id unidad organizativa", Storage:="ID_UNIDAD_ORGANIZATIVA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_UNIDAD_ORGANIZATIVA() As Decimal
        Get
            Return _ID_UNIDAD_ORGANIZATIVA
        End Get
        Set(ByVal Value As Decimal)
            _ID_UNIDAD_ORGANIZATIVA = Value
            OnPropertyChanged("ID_UNIDAD_ORGANIZATIVA")
        End Set
    End Property 

    Private _ID_UNIDAD_ORGANIZATIVAOld As Decimal
    Public Property ID_UNIDAD_ORGANIZATIVAOld() As Decimal
        Get
            Return _ID_UNIDAD_ORGANIZATIVAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_UNIDAD_ORGANIZATIVAOld = Value
        End Set
    End Property 

    Private _fkID_UNIDAD_ORGANIZATIVA As UNIDAD_ORGANIZATIVA
    Public Property fkID_UNIDAD_ORGANIZATIVA() As UNIDAD_ORGANIZATIVA
        Get
            Return _fkID_UNIDAD_ORGANIZATIVA
        End Get
        Set(ByVal Value As UNIDAD_ORGANIZATIVA)
            _fkID_UNIDAD_ORGANIZATIVA = Value
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

    Private _ID_PROYECTO_FORMACION As Decimal
    <Column(Name:="Id proyecto formacion", Storage:="ID_PROYECTO_FORMACION", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_PROYECTO_FORMACION() As Decimal
        Get
            Return _ID_PROYECTO_FORMACION
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROYECTO_FORMACION = Value
            OnPropertyChanged("ID_PROYECTO_FORMACION")
        End Set
    End Property 

    Private _ID_PROYECTO_FORMACIONOld As Decimal
    Public Property ID_PROYECTO_FORMACIONOld() As Decimal
        Get
            Return _ID_PROYECTO_FORMACIONOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_PROYECTO_FORMACIONOld = Value
        End Set
    End Property 

    Private _fkID_PROYECTO_FORMACION As PROYECTO_FORMACION
    Public Property fkID_PROYECTO_FORMACION() As PROYECTO_FORMACION
        Get
            Return _fkID_PROYECTO_FORMACION
        End Get
        Set(ByVal Value As PROYECTO_FORMACION)
            _fkID_PROYECTO_FORMACION = Value
        End Set
    End Property 

    Private _FECHA_SOLICITUD As DateTime
    <Column(Name:="Fecha solicitud", Storage:="FECHA_SOLICITUD", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_SOLICITUD() As DateTime
        Get
            Return _FECHA_SOLICITUD
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_SOLICITUD = Value
            OnPropertyChanged("FECHA_SOLICITUD")
        End Set
    End Property 

    Private _FECHA_SOLICITUDOld As DateTime
    Public Property FECHA_SOLICITUDOld() As DateTime
        Get
            Return _FECHA_SOLICITUDOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_SOLICITUDOld = Value
        End Set
    End Property 

    Private _OBJETIVO_CAPACITACION As String
    <Column(Name:="Objetivo capacitacion", Storage:="OBJETIVO_CAPACITACION", DbType:="VARCHAR2(800) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 800)> _
    Public Property OBJETIVO_CAPACITACION() As String
        Get
            Return _OBJETIVO_CAPACITACION
        End Get
        Set(ByVal Value As String)
            _OBJETIVO_CAPACITACION = Value
            OnPropertyChanged("OBJETIVO_CAPACITACION")
        End Set
    End Property 

    Private _OBJETIVO_CAPACITACIONOld As String
    Public Property OBJETIVO_CAPACITACIONOld() As String
        Get
            Return _OBJETIVO_CAPACITACIONOld
        End Get
        Set(ByVal Value As String)
            _OBJETIVO_CAPACITACIONOld = Value
        End Set
    End Property 

    Private _HORARIO As String
    <Column(Name:="Horario", Storage:="HORARIO", DbType:="VARCHAR2(255) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 255)> _
    Public Property HORARIO() As String
        Get
            Return _HORARIO
        End Get
        Set(ByVal Value As String)
            _HORARIO = Value
            OnPropertyChanged("HORARIO")
        End Set
    End Property 

    Private _HORARIOOld As String
    Public Property HORARIOOld() As String
        Get
            Return _HORARIOOld
        End Get
        Set(ByVal Value As String)
            _HORARIOOld = Value
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

    Private _NOMBRES_CONTACTO As String
    <Column(Name:="Nombres contacto", Storage:="NOMBRES_CONTACTO", DbType:="VARCHAR2(30) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 30)> _
    Public Property NOMBRES_CONTACTO() As String
        Get
            Return _NOMBRES_CONTACTO
        End Get
        Set(ByVal Value As String)
            _NOMBRES_CONTACTO = Value
            OnPropertyChanged("NOMBRES_CONTACTO")
        End Set
    End Property 

    Private _NOMBRES_CONTACTOOld As String
    Public Property NOMBRES_CONTACTOOld() As String
        Get
            Return _NOMBRES_CONTACTOOld
        End Get
        Set(ByVal Value As String)
            _NOMBRES_CONTACTOOld = Value
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
    <Column(Name:="Email contacto", Storage:="EMAIL_CONTACTO", DbType:="VARCHAR2(250) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 250)> _
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

    Private _PORC_PAGO_INFORME1 As Decimal
    <Column(Name:="Porc pago informe1", Storage:="PORC_PAGO_INFORME1", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=10, Scale:=3)> _
    Public Property PORC_PAGO_INFORME1() As Decimal
        Get
            Return _PORC_PAGO_INFORME1
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PAGO_INFORME1 = Value
            OnPropertyChanged("PORC_PAGO_INFORME1")
        End Set
    End Property 

    Private _PORC_PAGO_INFORME1Old As Decimal
    Public Property PORC_PAGO_INFORME1Old() As Decimal
        Get
            Return _PORC_PAGO_INFORME1Old
        End Get
        Set(ByVal Value As Decimal)
            _PORC_PAGO_INFORME1Old = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class

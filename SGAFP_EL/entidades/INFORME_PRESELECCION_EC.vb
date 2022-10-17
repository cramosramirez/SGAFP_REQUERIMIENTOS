''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_EL
''' Class	 : EL.INFORME_PRESELECCION_EC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Class that allows manipulate a table row INFORME_PRESELECCION_EC en memoria
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	22/08/2019	Created
''' </history>
''' -----------------------------------------------------------------------------

<Serializable(), Table(Name:="INFORME_PRESELECCION_EC")> Public Class INFORME_PRESELECCION_EC
    Inherits entidadBase
    Implements IEquatable(Of INFORME_PRESELECCION_EC), IComparable(Of INFORME_PRESELECCION_EC)

#Region " Metodos Generador "

    Public Sub New()
    End Sub

    Public Sub New(aID_INFORME_PRESE As Decimal, aID_GRUPO_SELEC As Decimal, aID_CONTRATO As Decimal, aFECHA_REPORTE As DateTime, aFECHA_INICIO As DateTime, aFECHA_FINALIZACION As DateTime, aELABORADO_POR As String, aPARTI_EVALUADOS As Decimal, aCOSTO_X_PARTICIPANTE As Decimal, aCOSTO_X_HORA As Decimal, aCOSTO_X_VISITA As Decimal, aTOTAL_PAGAR As Decimal, aUSUARIO_CREA As String, aFECHA_CREA As DateTime, aUSUARIO_ACT As String, aFECHA_ACT As DateTime)
        Me._ID_INFORME_PRESE = aID_INFORME_PRESE
        Me._ID_GRUPO_SELEC = aID_GRUPO_SELEC
        Me._ID_CONTRATO = aID_CONTRATO
        Me._FECHA_REPORTE = aFECHA_REPORTE
        Me._FECHA_INICIO = aFECHA_INICIO
        Me._FECHA_FINALIZACION = aFECHA_FINALIZACION
        Me._ELABORADO_POR = aELABORADO_POR
        Me._PARTI_EVALUADOS = aPARTI_EVALUADOS
        Me._COSTO_X_PARTICIPANTE = aCOSTO_X_PARTICIPANTE
        Me._COSTO_X_HORA = aCOSTO_X_HORA
        Me._COSTO_X_VISITA = aCOSTO_X_VISITA
        Me._TOTAL_PAGAR = aTOTAL_PAGAR
        Me._USUARIO_CREA = aUSUARIO_CREA
        Me._FECHA_CREA = aFECHA_CREA
        Me._USUARIO_ACT = aUSUARIO_ACT
        Me._FECHA_ACT = aFECHA_ACT
    End Sub

    Public Function Equals1(ByVal other As INFORME_PRESELECCION_EC) As Boolean Implements System.IEquatable(Of INFORME_PRESELECCION_EC).Equals
        Return Me.ID_INFORME_PRESE = other.ID_INFORME_PRESE
    End Function

    Public Function CompareTo(ByVal other As INFORME_PRESELECCION_EC) As Integer Implements System.IComparable(Of INFORME_PRESELECCION_EC).CompareTo
        If Me.ID_INFORME_PRESE > other.ID_INFORME_PRESE Then Return 1
        If Me.ID_INFORME_PRESE < other.ID_INFORME_PRESE Then Return -1
        Return 0
    End Function


#Region " Properties "

    Private _ID_INFORME_PRESE As Decimal
    <Column(Name:="Id informe prese", Storage:="ID_INFORME_PRESE", DbType:="NUMBER NOT NULL", Id:=True), _
     DataObjectField(True, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_INFORME_PRESE() As Decimal
        Get
            Return _ID_INFORME_PRESE
        End Get
        Set(ByVal Value As Decimal)
            _ID_INFORME_PRESE = Value
            OnPropertyChanged("ID_INFORME_PRESE")
        End Set
    End Property 

    Private _ID_GRUPO_SELEC As Decimal
    <Column(Name:="Id grupo selec", Storage:="ID_GRUPO_SELEC", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=8, Scale:=0)> _
    Public Property ID_GRUPO_SELEC() As Decimal
        Get
            Return _ID_GRUPO_SELEC
        End Get
        Set(ByVal Value As Decimal)
            _ID_GRUPO_SELEC = Value
            OnPropertyChanged("ID_GRUPO_SELEC")
        End Set
    End Property 

    Private _ID_GRUPO_SELECOld As Decimal
    Public Property ID_GRUPO_SELECOld() As Decimal
        Get
            Return _ID_GRUPO_SELECOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_GRUPO_SELECOld = Value
        End Set
    End Property 

    Private _fkID_GRUPO_SELEC As GRUPO_SELECCION
    Public Property fkID_GRUPO_SELEC() As GRUPO_SELECCION
        Get
            Return _fkID_GRUPO_SELEC
        End Get
        Set(ByVal Value As GRUPO_SELECCION)
            _fkID_GRUPO_SELEC = Value
        End Set
    End Property 

    Private _ID_CONTRATO As Decimal
    <Column(Name:="Id contrato", Storage:="ID_CONTRATO", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
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

    Private _fkID_CONTRATO As CONTRATO_BOLPROS
    Public Property fkID_CONTRATO() As CONTRATO_BOLPROS
        Get
            Return _fkID_CONTRATO
        End Get
        Set(ByVal Value As CONTRATO_BOLPROS)
            _fkID_CONTRATO = Value
        End Set
    End Property 

    Private _FECHA_REPORTE As DateTime
    <Column(Name:="Fecha reporte", Storage:="FECHA_REPORTE", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_REPORTE() As DateTime
        Get
            Return _FECHA_REPORTE
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_REPORTE = Value
            OnPropertyChanged("FECHA_REPORTE")
        End Set
    End Property 

    Private _FECHA_REPORTEOld As DateTime
    Public Property FECHA_REPORTEOld() As DateTime
        Get
            Return _FECHA_REPORTEOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_REPORTEOld = Value
        End Set
    End Property 

    Private _FECHA_INICIO As DateTime
    <Column(Name:="Fecha inicio", Storage:="FECHA_INICIO", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_INICIO() As DateTime
        Get
            Return _FECHA_INICIO
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIO = Value
            OnPropertyChanged("FECHA_INICIO")
        End Set
    End Property 

    Private _FECHA_INICIOOld As DateTime
    Public Property FECHA_INICIOOld() As DateTime
        Get
            Return _FECHA_INICIOOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_INICIOOld = Value
        End Set
    End Property 

    Private _FECHA_FINALIZACION As DateTime
    <Column(Name:="Fecha finalizacion", Storage:="FECHA_FINALIZACION", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_FINALIZACION() As DateTime
        Get
            Return _FECHA_FINALIZACION
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FINALIZACION = Value
            OnPropertyChanged("FECHA_FINALIZACION")
        End Set
    End Property 

    Private _FECHA_FINALIZACIONOld As DateTime
    Public Property FECHA_FINALIZACIONOld() As DateTime
        Get
            Return _FECHA_FINALIZACIONOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_FINALIZACIONOld = Value
        End Set
    End Property 

    Private _ELABORADO_POR As String
    <Column(Name:="Elaborado por", Storage:="ELABORADO_POR", DbType:="VARCHAR2(100) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 100)> _
    Public Property ELABORADO_POR() As String
        Get
            Return _ELABORADO_POR
        End Get
        Set(ByVal Value As String)
            _ELABORADO_POR = Value
            OnPropertyChanged("ELABORADO_POR")
        End Set
    End Property 

    Private _ELABORADO_POROld As String
    Public Property ELABORADO_POROld() As String
        Get
            Return _ELABORADO_POROld
        End Get
        Set(ByVal Value As String)
            _ELABORADO_POROld = Value
        End Set
    End Property 

    Private _PARTI_EVALUADOS As Decimal
    <Column(Name:="Parti evaluados", Storage:="PARTI_EVALUADOS", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=0, Scale:=0)> _
    Public Property PARTI_EVALUADOS() As Decimal
        Get
            Return _PARTI_EVALUADOS
        End Get
        Set(ByVal Value As Decimal)
            _PARTI_EVALUADOS = Value
            OnPropertyChanged("PARTI_EVALUADOS")
        End Set
    End Property 

    Private _PARTI_EVALUADOSOld As Decimal
    Public Property PARTI_EVALUADOSOld() As Decimal
        Get
            Return _PARTI_EVALUADOSOld
        End Get
        Set(ByVal Value As Decimal)
            _PARTI_EVALUADOSOld = Value
        End Set
    End Property 

    Private _COSTO_X_PARTICIPANTE As Decimal
    <Column(Name:="Costo x participante", Storage:="COSTO_X_PARTICIPANTE", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
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

    Private _COSTO_X_HORA As Decimal
    <Column(Name:="Costo x hora", Storage:="COSTO_X_HORA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
    Public Property COSTO_X_HORA() As Decimal
        Get
            Return _COSTO_X_HORA
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_X_HORA = Value
            OnPropertyChanged("COSTO_X_HORA")
        End Set
    End Property 

    Private _COSTO_X_HORAOld As Decimal
    Public Property COSTO_X_HORAOld() As Decimal
        Get
            Return _COSTO_X_HORAOld
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_X_HORAOld = Value
        End Set
    End Property 

    Private _COSTO_X_VISITA As Decimal
    <Column(Name:="Costo x visita", Storage:="COSTO_X_VISITA", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=6)> _
    Public Property COSTO_X_VISITA() As Decimal
        Get
            Return _COSTO_X_VISITA
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_X_VISITA = Value
            OnPropertyChanged("COSTO_X_VISITA")
        End Set
    End Property 

    Private _COSTO_X_VISITAOld As Decimal
    Public Property COSTO_X_VISITAOld() As Decimal
        Get
            Return _COSTO_X_VISITAOld
        End Get
        Set(ByVal Value As Decimal)
            _COSTO_X_VISITAOld = Value
        End Set
    End Property 

    Private _TOTAL_PAGAR As Decimal
    <Column(Name:="Total pagar", Storage:="TOTAL_PAGAR", DbType:="NUMBER NOT NULL", Id:=False), _
     DataObjectField(False, False, False), Precision(Precision:=20, Scale:=2)> _
    Public Property TOTAL_PAGAR() As Decimal
        Get
            Return _TOTAL_PAGAR
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_PAGAR = Value
            OnPropertyChanged("TOTAL_PAGAR")
        End Set
    End Property 

    Private _TOTAL_PAGAROld As Decimal
    Public Property TOTAL_PAGAROld() As Decimal
        Get
            Return _TOTAL_PAGAROld
        End Get
        Set(ByVal Value As Decimal)
            _TOTAL_PAGAROld = Value
        End Set
    End Property 

    Private _USUARIO_CREA As String
    <Column(Name:="Usuario crea", Storage:="USUARIO_CREA", DbType:="VARCHAR2(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property USUARIO_CREA() As String
        Get
            Return _USUARIO_CREA
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREA = Value
            OnPropertyChanged("USUARIO_CREA")
        End Set
    End Property 

    Private _USUARIO_CREAOld As String
    Public Property USUARIO_CREAOld() As String
        Get
            Return _USUARIO_CREAOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_CREAOld = Value
        End Set
    End Property 

    Private _FECHA_CREA As DateTime
    <Column(Name:="Fecha crea", Storage:="FECHA_CREA", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_CREA() As DateTime
        Get
            Return _FECHA_CREA
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREA = Value
            OnPropertyChanged("FECHA_CREA")
        End Set
    End Property 

    Private _FECHA_CREAOld As DateTime
    Public Property FECHA_CREAOld() As DateTime
        Get
            Return _FECHA_CREAOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_CREAOld = Value
        End Set
    End Property 

    Private _USUARIO_ACT As String
    <Column(Name:="Usuario act", Storage:="USUARIO_ACT", DbType:="VARCHAR2(200) NOT NULL", Id:=False), _
     DataObjectField(False, False, False, 200)> _
    Public Property USUARIO_ACT() As String
        Get
            Return _USUARIO_ACT
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACT = Value
            OnPropertyChanged("USUARIO_ACT")
        End Set
    End Property 

    Private _USUARIO_ACTOld As String
    Public Property USUARIO_ACTOld() As String
        Get
            Return _USUARIO_ACTOld
        End Get
        Set(ByVal Value As String)
            _USUARIO_ACTOld = Value
        End Set
    End Property 

    Private _FECHA_ACT As DateTime
    <Column(Name:="Fecha act", Storage:="FECHA_ACT", DbType:="DATE NOT NULL", Id:=False), _
     DataObjectField(False, False, False)> _
    Public Property FECHA_ACT() As DateTime
        Get
            Return _FECHA_ACT
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACT = Value
            OnPropertyChanged("FECHA_ACT")
        End Set
    End Property 

    Private _FECHA_ACTOld As DateTime
    Public Property FECHA_ACTOld() As DateTime
        Get
            Return _FECHA_ACTOld
        End Get
        Set(ByVal Value As DateTime)
            _FECHA_ACTOld = Value
        End Set
    End Property 

#End Region

#Region " Relaciones "
#End Region
#End Region
End Class

﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace srvLOCAL
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://192.168.70.4/", ConfigurationName:="srvLOCAL.wsSGAFPSoap")>  _
    Public Interface wsSGAFPSoap
        
        'CODEGEN: Generating message contract since element name codigoArea from namespace http://192.168.70.4/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://192.168.70.4/ProcesarAsignacionGanador", ReplyAction:="*")>  _
        Function ProcesarAsignacionGanador(ByVal request As srvLOCAL.ProcesarAsignacionGanadorRequest) As srvLOCAL.ProcesarAsignacionGanadorResponse
        
        'CODEGEN: Generating message contract since element name tdr from namespace http://192.168.70.4/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://192.168.70.4/ProcesarCreacionOrdenCompra", ReplyAction:="*")>  _
        Function ProcesarCreacionOrdenCompra(ByVal request As srvLOCAL.ProcesarCreacionOrdenCompraRequest) As srvLOCAL.ProcesarCreacionOrdenCompraResponse
        
        'CODEGEN: Generating message contract since element name userid from namespace http://192.168.70.4/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://192.168.70.4/ProcesarQuedanFactura", ReplyAction:="*")>  _
        Function ProcesarQuedanFactura(ByVal request As srvLOCAL.ProcesarQuedanFacturaRequest) As srvLOCAL.ProcesarQuedanFacturaResponse
        
        'CODEGEN: Generating message contract since element name numeroCheque from namespace http://192.168.70.4/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://192.168.70.4/ProcesarChequeFactura", ReplyAction:="*")>  _
        Function ProcesarChequeFactura(ByVal request As srvLOCAL.ProcesarChequeFacturaRequest) As srvLOCAL.ProcesarChequeFacturaResponse
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ProcesarAsignacionGanadorRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ProcesarAsignacionGanador", [Namespace]:="http://192.168.70.4/", Order:=0)>  _
        Public Body As srvLOCAL.ProcesarAsignacionGanadorRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As srvLOCAL.ProcesarAsignacionGanadorRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://192.168.70.4/")>  _
    Partial Public Class ProcesarAsignacionGanadorRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public codigoArea As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public codigoPrograma As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public nombrePrograma As String
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=3)>  _
        Public duracionHoras As Decimal
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=4)>  _
        Public nombreProveedor As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=5)>  _
        Public nitProveedor As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=6)>  _
        Public codigoDepartamento As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=7)>  _
        Public codigoMunicipio As String
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=8)>  _
        Public tipoPersona As Integer
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=9)>  _
        Public noDui As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=10)>  _
        Public noNrc As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=11)>  _
        Public direccion As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=12)>  _
        Public email As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=13)>  _
        Public telefono As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=14)>  _
        Public fax As String
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=15)>  _
        Public numeroParticipantes As Integer
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=16)>  _
        Public tdr As String
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=17)>  _
        Public montoAdjudicado As Decimal
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=18)>  _
        Public userid As String
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=19)>  _
        Public correlativoGrupo As Decimal
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New( _
                    ByVal codigoArea As String,  _
                    ByVal codigoPrograma As String,  _
                    ByVal nombrePrograma As String,  _
                    ByVal duracionHoras As Decimal,  _
                    ByVal nombreProveedor As String,  _
                    ByVal nitProveedor As String,  _
                    ByVal codigoDepartamento As String,  _
                    ByVal codigoMunicipio As String,  _
                    ByVal tipoPersona As Integer,  _
                    ByVal noDui As String,  _
                    ByVal noNrc As String,  _
                    ByVal direccion As String,  _
                    ByVal email As String,  _
                    ByVal telefono As String,  _
                    ByVal fax As String,  _
                    ByVal numeroParticipantes As Integer,  _
                    ByVal tdr As String,  _
                    ByVal montoAdjudicado As Decimal,  _
                    ByVal userid As String,  _
                    ByVal correlativoGrupo As Decimal)
            MyBase.New
            Me.codigoArea = codigoArea
            Me.codigoPrograma = codigoPrograma
            Me.nombrePrograma = nombrePrograma
            Me.duracionHoras = duracionHoras
            Me.nombreProveedor = nombreProveedor
            Me.nitProveedor = nitProveedor
            Me.codigoDepartamento = codigoDepartamento
            Me.codigoMunicipio = codigoMunicipio
            Me.tipoPersona = tipoPersona
            Me.noDui = noDui
            Me.noNrc = noNrc
            Me.direccion = direccion
            Me.email = email
            Me.telefono = telefono
            Me.fax = fax
            Me.numeroParticipantes = numeroParticipantes
            Me.tdr = tdr
            Me.montoAdjudicado = montoAdjudicado
            Me.userid = userid
            Me.correlativoGrupo = correlativoGrupo
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ProcesarAsignacionGanadorResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ProcesarAsignacionGanadorResponse", [Namespace]:="http://192.168.70.4/", Order:=0)>  _
        Public Body As srvLOCAL.ProcesarAsignacionGanadorResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As srvLOCAL.ProcesarAsignacionGanadorResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://192.168.70.4/")>  _
    Partial Public Class ProcesarAsignacionGanadorResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public ProcesarAsignacionGanadorResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ProcesarAsignacionGanadorResult As String)
            MyBase.New
            Me.ProcesarAsignacionGanadorResult = ProcesarAsignacionGanadorResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ProcesarCreacionOrdenCompraRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ProcesarCreacionOrdenCompra", [Namespace]:="http://192.168.70.4/", Order:=0)>  _
        Public Body As srvLOCAL.ProcesarCreacionOrdenCompraRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As srvLOCAL.ProcesarCreacionOrdenCompraRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://192.168.70.4/")>  _
    Partial Public Class ProcesarCreacionOrdenCompraRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public tdr As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public nitProveedor As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public resolucion As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=3)>  _
        Public userid As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal tdr As String, ByVal nitProveedor As String, ByVal resolucion As String, ByVal userid As String)
            MyBase.New
            Me.tdr = tdr
            Me.nitProveedor = nitProveedor
            Me.resolucion = resolucion
            Me.userid = userid
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ProcesarCreacionOrdenCompraResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ProcesarCreacionOrdenCompraResponse", [Namespace]:="http://192.168.70.4/", Order:=0)>  _
        Public Body As srvLOCAL.ProcesarCreacionOrdenCompraResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As srvLOCAL.ProcesarCreacionOrdenCompraResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://192.168.70.4/")>  _
    Partial Public Class ProcesarCreacionOrdenCompraResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public ProcesarCreacionOrdenCompraResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ProcesarCreacionOrdenCompraResult As String)
            MyBase.New
            Me.ProcesarCreacionOrdenCompraResult = ProcesarCreacionOrdenCompraResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ProcesarQuedanFacturaRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ProcesarQuedanFactura", [Namespace]:="http://192.168.70.4/", Order:=0)>  _
        Public Body As srvLOCAL.ProcesarQuedanFacturaRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As srvLOCAL.ProcesarQuedanFacturaRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://192.168.70.4/")>  _
    Partial Public Class ProcesarQuedanFacturaRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public idFacturaAF As Decimal
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=1)>  _
        Public numeroQuedan As Decimal
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public userid As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal idFacturaAF As Decimal, ByVal numeroQuedan As Decimal, ByVal userid As String)
            MyBase.New
            Me.idFacturaAF = idFacturaAF
            Me.numeroQuedan = numeroQuedan
            Me.userid = userid
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ProcesarQuedanFacturaResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ProcesarQuedanFacturaResponse", [Namespace]:="http://192.168.70.4/", Order:=0)>  _
        Public Body As srvLOCAL.ProcesarQuedanFacturaResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As srvLOCAL.ProcesarQuedanFacturaResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://192.168.70.4/")>  _
    Partial Public Class ProcesarQuedanFacturaResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public ProcesarQuedanFacturaResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ProcesarQuedanFacturaResult As String)
            MyBase.New
            Me.ProcesarQuedanFacturaResult = ProcesarQuedanFacturaResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ProcesarChequeFacturaRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ProcesarChequeFactura", [Namespace]:="http://192.168.70.4/", Order:=0)>  _
        Public Body As srvLOCAL.ProcesarChequeFacturaRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As srvLOCAL.ProcesarChequeFacturaRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://192.168.70.4/")>  _
    Partial Public Class ProcesarChequeFacturaRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public idFacturaAF As Decimal
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public numeroCheque As String
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=2)>  _
        Public fechaEmision As Date
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=3)>  _
        Public userid As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal idFacturaAF As Decimal, ByVal numeroCheque As String, ByVal fechaEmision As Date, ByVal userid As String)
            MyBase.New
            Me.idFacturaAF = idFacturaAF
            Me.numeroCheque = numeroCheque
            Me.fechaEmision = fechaEmision
            Me.userid = userid
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ProcesarChequeFacturaResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ProcesarChequeFacturaResponse", [Namespace]:="http://192.168.70.4/", Order:=0)>  _
        Public Body As srvLOCAL.ProcesarChequeFacturaResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As srvLOCAL.ProcesarChequeFacturaResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://192.168.70.4/")>  _
    Partial Public Class ProcesarChequeFacturaResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public ProcesarChequeFacturaResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ProcesarChequeFacturaResult As String)
            MyBase.New
            Me.ProcesarChequeFacturaResult = ProcesarChequeFacturaResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface wsSGAFPSoapChannel
        Inherits srvLOCAL.wsSGAFPSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class wsSGAFPSoapClient
        Inherits System.ServiceModel.ClientBase(Of srvLOCAL.wsSGAFPSoap)
        Implements srvLOCAL.wsSGAFPSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function srvLOCAL_wsSGAFPSoap_ProcesarAsignacionGanador(ByVal request As srvLOCAL.ProcesarAsignacionGanadorRequest) As srvLOCAL.ProcesarAsignacionGanadorResponse Implements srvLOCAL.wsSGAFPSoap.ProcesarAsignacionGanador
            Return MyBase.Channel.ProcesarAsignacionGanador(request)
        End Function
        
        Public Function ProcesarAsignacionGanador( _
                    ByVal codigoArea As String,  _
                    ByVal codigoPrograma As String,  _
                    ByVal nombrePrograma As String,  _
                    ByVal duracionHoras As Decimal,  _
                    ByVal nombreProveedor As String,  _
                    ByVal nitProveedor As String,  _
                    ByVal codigoDepartamento As String,  _
                    ByVal codigoMunicipio As String,  _
                    ByVal tipoPersona As Integer,  _
                    ByVal noDui As String,  _
                    ByVal noNrc As String,  _
                    ByVal direccion As String,  _
                    ByVal email As String,  _
                    ByVal telefono As String,  _
                    ByVal fax As String,  _
                    ByVal numeroParticipantes As Integer,  _
                    ByVal tdr As String,  _
                    ByVal montoAdjudicado As Decimal,  _
                    ByVal userid As String,  _
                    ByVal correlativoGrupo As Decimal) As String
            Dim inValue As srvLOCAL.ProcesarAsignacionGanadorRequest = New srvLOCAL.ProcesarAsignacionGanadorRequest()
            inValue.Body = New srvLOCAL.ProcesarAsignacionGanadorRequestBody()
            inValue.Body.codigoArea = codigoArea
            inValue.Body.codigoPrograma = codigoPrograma
            inValue.Body.nombrePrograma = nombrePrograma
            inValue.Body.duracionHoras = duracionHoras
            inValue.Body.nombreProveedor = nombreProveedor
            inValue.Body.nitProveedor = nitProveedor
            inValue.Body.codigoDepartamento = codigoDepartamento
            inValue.Body.codigoMunicipio = codigoMunicipio
            inValue.Body.tipoPersona = tipoPersona
            inValue.Body.noDui = noDui
            inValue.Body.noNrc = noNrc
            inValue.Body.direccion = direccion
            inValue.Body.email = email
            inValue.Body.telefono = telefono
            inValue.Body.fax = fax
            inValue.Body.numeroParticipantes = numeroParticipantes
            inValue.Body.tdr = tdr
            inValue.Body.montoAdjudicado = montoAdjudicado
            inValue.Body.userid = userid
            inValue.Body.correlativoGrupo = correlativoGrupo
            Dim retVal As srvLOCAL.ProcesarAsignacionGanadorResponse = CType(Me,srvLOCAL.wsSGAFPSoap).ProcesarAsignacionGanador(inValue)
            Return retVal.Body.ProcesarAsignacionGanadorResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function srvLOCAL_wsSGAFPSoap_ProcesarCreacionOrdenCompra(ByVal request As srvLOCAL.ProcesarCreacionOrdenCompraRequest) As srvLOCAL.ProcesarCreacionOrdenCompraResponse Implements srvLOCAL.wsSGAFPSoap.ProcesarCreacionOrdenCompra
            Return MyBase.Channel.ProcesarCreacionOrdenCompra(request)
        End Function
        
        Public Function ProcesarCreacionOrdenCompra(ByVal tdr As String, ByVal nitProveedor As String, ByVal resolucion As String, ByVal userid As String) As String
            Dim inValue As srvLOCAL.ProcesarCreacionOrdenCompraRequest = New srvLOCAL.ProcesarCreacionOrdenCompraRequest()
            inValue.Body = New srvLOCAL.ProcesarCreacionOrdenCompraRequestBody()
            inValue.Body.tdr = tdr
            inValue.Body.nitProveedor = nitProveedor
            inValue.Body.resolucion = resolucion
            inValue.Body.userid = userid
            Dim retVal As srvLOCAL.ProcesarCreacionOrdenCompraResponse = CType(Me,srvLOCAL.wsSGAFPSoap).ProcesarCreacionOrdenCompra(inValue)
            Return retVal.Body.ProcesarCreacionOrdenCompraResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function srvLOCAL_wsSGAFPSoap_ProcesarQuedanFactura(ByVal request As srvLOCAL.ProcesarQuedanFacturaRequest) As srvLOCAL.ProcesarQuedanFacturaResponse Implements srvLOCAL.wsSGAFPSoap.ProcesarQuedanFactura
            Return MyBase.Channel.ProcesarQuedanFactura(request)
        End Function
        
        Public Function ProcesarQuedanFactura(ByVal idFacturaAF As Decimal, ByVal numeroQuedan As Decimal, ByVal userid As String) As String
            Dim inValue As srvLOCAL.ProcesarQuedanFacturaRequest = New srvLOCAL.ProcesarQuedanFacturaRequest()
            inValue.Body = New srvLOCAL.ProcesarQuedanFacturaRequestBody()
            inValue.Body.idFacturaAF = idFacturaAF
            inValue.Body.numeroQuedan = numeroQuedan
            inValue.Body.userid = userid
            Dim retVal As srvLOCAL.ProcesarQuedanFacturaResponse = CType(Me,srvLOCAL.wsSGAFPSoap).ProcesarQuedanFactura(inValue)
            Return retVal.Body.ProcesarQuedanFacturaResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function srvLOCAL_wsSGAFPSoap_ProcesarChequeFactura(ByVal request As srvLOCAL.ProcesarChequeFacturaRequest) As srvLOCAL.ProcesarChequeFacturaResponse Implements srvLOCAL.wsSGAFPSoap.ProcesarChequeFactura
            Return MyBase.Channel.ProcesarChequeFactura(request)
        End Function
        
        Public Function ProcesarChequeFactura(ByVal idFacturaAF As Decimal, ByVal numeroCheque As String, ByVal fechaEmision As Date, ByVal userid As String) As String
            Dim inValue As srvLOCAL.ProcesarChequeFacturaRequest = New srvLOCAL.ProcesarChequeFacturaRequest()
            inValue.Body = New srvLOCAL.ProcesarChequeFacturaRequestBody()
            inValue.Body.idFacturaAF = idFacturaAF
            inValue.Body.numeroCheque = numeroCheque
            inValue.Body.fechaEmision = fechaEmision
            inValue.Body.userid = userid
            Dim retVal As srvLOCAL.ProcesarChequeFacturaResponse = CType(Me,srvLOCAL.wsSGAFPSoap).ProcesarChequeFactura(inValue)
            Return retVal.Body.ProcesarChequeFacturaResult
        End Function
    End Class
End Namespace

Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Collections.Generic
Imports SGAFP.EL
Imports SGAFP.BL
Imports System
Imports System.Collections.Specialized

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la siguiente línea.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<System.Web.Script.Services.ScriptService()> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Proveedores
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function GetDropDownContents(ByVal knownCategoryValues As String, ByVal category As String) As AjaxControlToolkit.CascadingDropDownNameValue()
        Dim valores As List(Of AjaxControlToolkit.CascadingDropDownNameValue) = New List(Of AjaxControlToolkit.CascadingDropDownNameValue)()
        If category = "Proveedor" Then

            Dim proveedores As New listaPROVEEDOR_AF
            proveedores = (New cPROVEEDOR_AF).ObtenerLista()
            'Dim ta As InsaforpTableAdapters.DEPARTAMENTOTableAdapter = New InsaforpTableAdapters.DEPARTAMENTOTableAdapter()
            'deptos = ta.GetData()
            If (proveedores.Count = 0) Then
                Return valores.ToArray()
            End If
            For Each lEntidad As PROVEEDOR_AF In proveedores
                Dim valor As New AjaxControlToolkit.CascadingDropDownNameValue(lEntidad.NOMBRE_PROVEEDOR, lEntidad.ID_PROVEEDOR_AF)
                valores.Add(valor)
            Next
        Else

            Dim knownCategoryValuesDictionary As StringDictionary = AjaxControlToolkit.CascadingDropDown.ParseKnownCategoryValuesString(knownCategoryValues)

            Dim sitiosCapacitacion As New listaSITIO_CAPACITACION
            'Dim ta As InsaforpTableAdapters.MUNICIPIOTableAdapter = New InsaforpTableAdapters.MUNICIPIOTableAdapter()
            Dim codigo As String = ""
            For Each proveedor As String In knownCategoryValuesDictionary.Values

                codigo = proveedor

            Next
            sitiosCapacitacion = (New cSITIO_CAPACITACION).ObtenerListaPorPROVEEDOR_AF(Convert.ToInt32(codigo))
            If (sitiosCapacitacion.Count = 0) Then Return valores.ToArray()

            For Each lEntidad As SITIO_CAPACITACION In sitiosCapacitacion
                Dim valor As New AjaxControlToolkit.CascadingDropDownNameValue(lEntidad.NOMBRE_SITIO, lEntidad.ID_SITIO_CAPACITACION)
                valores.Add(valor)
            Next
        End If

        Return valores.ToArray()

    End Function


End Class

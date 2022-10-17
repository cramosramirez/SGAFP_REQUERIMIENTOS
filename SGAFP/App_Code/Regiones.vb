Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Collections.Generic
Imports SGAFP.EL
Imports SGAFP.BL
Imports System.Collections.Specialized

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la siguiente línea.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<System.Web.Script.Services.ScriptService()> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Regiones
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function GetDropDownContents(ByVal knownCategoryValues As String, ByVal category As String) As AjaxControlToolkit.CascadingDropDownNameValue()
        Dim valores As List(Of AjaxControlToolkit.CascadingDropDownNameValue) = New List(Of AjaxControlToolkit.CascadingDropDownNameValue)()
        If category = "Departamento" Then

            Dim deptos As New listaDEPARTAMENTO
            deptos = (New cDEPARTAMENTO).ObtenerLista("01")
            'Dim ta As InsaforpTableAdapters.DEPARTAMENTOTableAdapter = New InsaforpTableAdapters.DEPARTAMENTOTableAdapter()
            'deptos = ta.GetData()
            If (deptos.Count = 0) Then
                Return valores.ToArray()
            End If
            For Each lEntidad As DEPARTAMENTO In deptos
                Dim valor As New AjaxControlToolkit.CascadingDropDownNameValue(lEntidad.NOMBRE, lEntidad.CODIGO_DEPARTAMENTO)
                valores.Add(valor)
            Next
        Else

            Dim knownCategoryValuesDictionary As StringDictionary = AjaxControlToolkit.CascadingDropDown.ParseKnownCategoryValuesString(knownCategoryValues)

            Dim munics As New listaMUNICIPIO
            'Dim ta As InsaforpTableAdapters.MUNICIPIOTableAdapter = New InsaforpTableAdapters.MUNICIPIOTableAdapter()
            Dim codigo As String = ""
            For Each depto As String In knownCategoryValuesDictionary.Values

                codigo = depto

            Next
            munics = (New cMUNICIPIO).ObtenerLista("01", codigo)
            If (munics.Count = 0) Then Return valores.ToArray()

            For Each lEntidad As MUNICIPIO In munics
                Dim valor As New AjaxControlToolkit.CascadingDropDownNameValue(lEntidad.NOMBRE, lEntidad.CODIGO_MUNICIPIO)
                valores.Add(valor)
            Next
        End If

        Return valores.ToArray()

    End Function




End Class

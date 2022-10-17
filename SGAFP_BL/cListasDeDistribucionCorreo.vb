Imports SQLMembershipProvider.BL
Imports System.Web.Security

Public Class cListasDeDistribucionCorreo
    Function ListaCorreosParaAutorizaciones() As List(Of String)
        Dim _mp As New cmembershipProvider
        Dim sCorreo As String
        Dim lstIni As New List(Of String)
        Dim lstFin As New List(Of String)

        _mp = CType(Membership.Provider, cmembershipProvider)

        lstIni.Add("ymarroquin")
        lstIni.Add("etorres")
        lstIni.Add("golivo")
        lstIni.Add("nmendez")
        lstIni.Add("gaguiluz")

        For i As Int32 = 0 To lstIni.Count - 1
            sCorreo = _mp.ObtenerEmailPorNombreUsuario(lstIni(i), True)
            If sCorreo <> "" AndAlso Not lstFin.Contains(sCorreo) Then lstFin.Add(sCorreo)
        Next

        Return lstFin
    End Function
End Class

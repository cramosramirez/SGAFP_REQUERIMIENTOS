Imports System.DirectoryServices

Public Class Form2

    Dim i As Integer = 0
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.ReportViewer1.RefreshReport()
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    'Dim entryRoot As DirectoryEntry = New DirectoryEntry("LDAP://INSA", "INSA\gti_elmer", "ctvall", AuthenticationTypes.ReadonlyServer)
    '    Dim entryRoot As DirectoryEntry = New DirectoryEntry("LDAP://DC=INSA", "INSA\gti_elmer", "ctvall", AuthenticationTypes.ReadonlyServer)
    '    Dim domain As String = entryRoot.Properties("defaultNamingContext")(0)
    '    Dim domainpath As String = "LDAP://" + domain

    '    Dim searchRoot As DirectoryEntry = New DirectoryEntry(domainpath)
    '    Dim search As DirectorySearcher = New DirectorySearcher(searchRoot)
    '    search.Filter = "(&(objectClass=user)(objectCategory=person))"

    '    Dim result As SearchResult
    '    search.PageSize = 1000
    '    Dim resultCol As SearchResultCollection = search.FindAll()
    '    For Each result In resultCol
    '        Dim a As Integer = 0
    '    Next
    '    'for int counter = 0; counter < resultCol.Count; counter++)
    '    '{
    '    '    result = resultCol[counter];
    '    '    result.Properties["givenName"][0];
    '    '    result.Properties["initials"][0];
    '    '    result.Properties["sn"][0]; 

    '    '}
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DataSet1.ReadXml("C:\documentos\htp\CronogramaHTPOK.xml")
        Me.DataGridView1.DataSource = Me.DataSet1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        i = 0
        Me.DataGridView1.DataSource = Me.DataSet1.Tables(i)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If i > 0 Then i -= 1
        Me.DataGridView1.DataSource = Me.DataSet1.Tables(i)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If i < Me.DataSet1.Tables.Count - 1 Then i += 1
        Me.DataGridView1.DataSource = Me.DataSet1.Tables(i)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        i = Me.DataSet1.Tables.Count - 1
        Me.DataGridView1.DataSource = Me.DataSet1.Tables(i)
    End Sub
End Class
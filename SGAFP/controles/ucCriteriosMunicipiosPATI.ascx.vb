Imports System.Configuration.ConfigurationManager

Partial Class controles_ucCriteriosMunicipiosPATI
    Inherits ucBase

    Private Sub CargarDepartamentos()
        Me.odsDepartamento.SelectParameters("ID_FUENTE").DefaultValue = hf("IdFuente")
        Me.odsDepartamento.DataBind()
        Me.cbxDepartamento.DataBind()
        Me.cbxDepartamento.Items.Add("[Todos]", "-1").Selected = True
    End Sub

    Public ReadOnly Property IdFuente() As Decimal
        Get
            If Me.cbxFuenteFinanciamiento.Value Is Nothing Then Return -1
            Return Convert.ToDecimal(Me.cbxFuenteFinanciamiento.Value)
        End Get
    End Property

    Public ReadOnly Property NoConvocatoria() As Decimal
        Get
            If Me.speConvocatoria.Value Is Nothing Then Return -1
            Return Convert.ToDecimal(Me.speConvocatoria.Value)
        End Get
    End Property
    Public ReadOnly Property CodigoDepartamento() As String
        Get
            If Me.cbxDepartamento.Value Is Nothing Then Return -1
            Return Me.cbxDepartamento.Value
        End Get
    End Property
    Public ReadOnly Property CodigoMunicipio() As String
        Get
            If Me.cbxMunicipio.Value Is Nothing Then Return -1
            Return Me.cbxMunicipio.Value
        End Get
    End Property
    Private Sub CargarFuente()
        Me.odsFuente.DataBind()
        Me.cbxFuenteFinanciamiento.DataBind()
        Me.cbxFuenteFinanciamiento.SelectedItem = Me.cbxFuenteFinanciamiento.Items.FindByValue(hf("IdFuente"))
    End Sub

    Private Sub CargarMunicipios()
        Me.odsMunicipio.SelectParameters("ID_FUENTE").DefaultValue = hf("IdFuente")
        Me.odsMunicipio.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = hf("CodigoDepartamento")
        Me.odsMunicipio.DataBind()
        Me.cbxMunicipio.DataBind()
        Me.cbxMunicipio.Items.Add("[Todos]", "-1").Selected = True
    End Sub

    Protected Sub cbxFuenteFinanciamiento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxFuenteFinanciamiento.SelectedIndexChanged
        hf("IdFuente") = TryCast(sender, DevExpress.Web.ASPxEditors.ASPxComboBox).Value
        hf("CodigoDepartamento") = "-1"
        CargarDepartamentos()
        CargarMunicipios()
        InicializarNumConvocatoria()
    End Sub

    Protected Sub cbxMunicipio_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cbxMunicipio.Callback
        Dim parametros() As String = e.Parameter.Split(";")

        hf("IdFuente") = CDec(parametros(0))
        hf("CodigoDepartamento") = parametros(1)
        CargarMunicipios()
    End Sub

    Private Sub InicializarNumConvocatoria()
        If cbxFuenteFinanciamiento.Value = 1 Then
            Me.speConvocatoria.Value = AppSettings("PATI_BM_CONVOCATORIA")
        Else
            Me.speConvocatoria.Value = AppSettings("PATI_USAID_CONVOCATORIA")
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            hf.Add("IdFuente", CDec(1))
            hf.Add("CodigoDepartamento", "-1")
            hf.Add("CodigoMunicipio", "-1")
            CargarFuente()
            CargarDepartamentos()
            CargarMunicipios()
            InicializarNumConvocatoria()
        End If
    End Sub

    <System.ComponentModel.DefaultValue(True), _
   System.ComponentModel.Description("Permite Ver/Ocultar el Departamento")> _
   Public Property VerDepartamento() As Boolean
        Get
            Return Me.trDepartamento.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDepartamento.Visible = value
        End Set
    End Property

    <System.ComponentModel.DefaultValue(True), _
  System.ComponentModel.Description("Permite Ver/Ocultar el Municipio")> _
  Public Property VerMunicipio() As Boolean
        Get
            Return Me.trMunicipio.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMunicipio.Visible = value
        End Set
    End Property
End Class

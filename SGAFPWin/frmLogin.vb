Imports System.Configuration.ConfigurationManager
Imports SQLMembershipProvider.BL
Imports System.Security.Principal
Imports System.Web.Security

Public Class frmLogin
    Inherits frmBase

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblClave As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.lblClave = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(112, 52)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 21)
        Me.txtUsuario.TabIndex = 0
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(112, 86)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(100, 21)
        Me.txtClave.TabIndex = 1
        '
        'lblUsuario
        '
        Me.lblUsuario.Location = New System.Drawing.Point(48, 52)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(48, 17)
        Me.lblUsuario.TabIndex = 2
        Me.lblUsuario.Text = "Usuario:"
        '
        'lblClave
        '
        Me.lblClave.Location = New System.Drawing.Point(56, 86)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(40, 17)
        Me.lblClave.TabIndex = 3
        Me.lblClave.Text = "Clave:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAceptar.Location = New System.Drawing.Point(64, 110)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(71, 24)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelar.Location = New System.Drawing.Point(157, 110)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(71, 24)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Digite su Usuario y Clave para accesar al Sistema"
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(301, 151)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblClave)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ventana de Acceso"
        Me.Controls.SetChildIndex(Me.txtUsuario, 0)
        Me.Controls.SetChildIndex(Me.txtClave, 0)
        Me.Controls.SetChildIndex(Me.lblUsuario, 0)
        Me.Controls.SetChildIndex(Me.lblClave, 0)
        Me.Controls.SetChildIndex(Me.btnAceptar, 0)
        Me.Controls.SetChildIndex(Me.btnCancelar, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Public iIntentos As Integer = 3
    Private EstaAutenticado As Boolean = False
    Private _Usuario As String

    Public ReadOnly Property Usuario() As String
        Get
            Return _Usuario
        End Get
    End Property

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        'Autenticar al Usuario y guardar el resultado en Me.EstaAutenticado

        'Dim sr As New svcCURSO_TEMA.IsvcCURSO_TEMAClient
        'Dim a As List(Of CURSO_TEMA)

        'a = sr.ObtenerListaPorAREA_FORMACION(1, False, False, "", "")


        Me.EstaAutenticado = AutenticarUsuario(Me.txtUsuario.Text, Me.txtClave.Text)

        If Me.EstaAutenticado Then
            Me._Usuario = Me.txtUsuario.Text
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.AsignarMensaje("No se pudo ingresar al Sistema, Favor verifique", True)
            iIntentos -= 1
            If iIntentos = 0 Then
                Me.AsignarMensaje("Lo sentimos mucho, este fue su ultimo intento.", True)
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        End If
    End Sub

    Private Function AutenticarUsuario(ByRef user As String, ByVal pwd As String) As Boolean

        Dim _mp As cmembershipProvider
        _mp = CType(Membership.Provider, cmembershipProvider)

        If _mp.ValidateUser(user, pwd) Then
            user = _mp.GetUserNameByEmail(_mp.GetUser(user, True).Email)
            Return True
        Else
            Return False
        End If

    End Function

End Class


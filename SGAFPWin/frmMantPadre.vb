Imports System.Configuration.ConfigurationSettings
Imports System.ComponentModel
Public Class frmMantPadre
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
    Protected WithEvents lblTitulo As System.Windows.Forms.Label
    Protected WithEvents dsDatos As System.Data.DataSet
    Protected WithEvents ttToolTip As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.dsDatos = New System.Data.DataSet
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.ttToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dsDatos
        '
        Me.dsDatos.DataSetName = "NewDataSet"
        Me.dsDatos.Locale = New System.Globalization.CultureInfo("es-SV")
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTitulo.Location = New System.Drawing.Point(8, 8)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(440, 23)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "Mantenimiento de "
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmMantPadre
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 245)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmMantPadre"
        Me.Text = "Mantenimiento de "
        CType(Me.dsDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Declaraciones "
    Public miMantenimiento As ucBaseMant
#End Region

    Private _BarraHerramienta As Integer = TipoMantenimiento.Maestro

    <Category("Design"), Bindable(True), DefaultValue(TipoMantenimiento.Maestro), Description("Determina el tipo de Barra de Herramienta a utilizar")> _
    Property BarraHerramienta() As TipoMantenimiento
        Get
            Return CType(_BarraHerramienta, TipoMantenimiento)
        End Get
        Set(ByVal Value As TipoMantenimiento)
            _BarraHerramienta = Value
        End Set
    End Property

#Region " Herramientas "

    Public Sub SetearBarraHerramienta(ByVal aTipomantenimiento As TipoMantenimiento)
    End Sub

    Public Event RegistroModificado()

    Public Overridable Sub Aceptar()
        miMantenimiento.Aceptar()
        Me.RestablecerModoEdicion(False)
    End Sub

    Public Overridable Sub Cancelar()
        miMantenimiento.Cancelar()
        Me.RestablecerModoEdicion(False)
    End Sub

    Public Overridable Sub Nuevo()
        miMantenimiento.Nuevo()
        Me.RestablecerModoEdicion(True)
    End Sub

    Public Overridable Sub Editar()
        miMantenimiento.Editar()
        Me.RestablecerModoEdicion(True)
    End Sub

    Public Overridable Sub Eliminar()
        Dim eliminado As Integer
        eliminado = miMantenimiento.Eliminar()
        Select Case eliminado
            Case 1
                Me.AsignarMensaje("Registro eliminado satifactoriamente")
                RaiseEvent RegistroModificado()
            Case -1
                Me.AsignarMensaje("Error al eliminar el registro.")
            Case 100
                'No se hace nada, porque cancelo la eliminacion
            Case Else
                Me.AsignarMensaje("Error al eliminar el registro.Error: Registro no existe.")
        End Select
    End Sub

    Public Overridable Sub Guardar()
        miMantenimiento.Guardar()
        RaiseEvent RegistroModificado()
    End Sub

    Public Overridable Sub Primero()
        miMantenimiento.Primero()
    End Sub

    Public Overridable Sub Anterior()
        miMantenimiento.Anterior()
    End Sub

    Public Overridable Sub Siguiente()
        miMantenimiento.Siguiente()
    End Sub

    Public Overridable Sub Ultimo()
        miMantenimiento.Ultimo()
    End Sub

    Public Overridable Sub RestablecerModoEdicion( _
        ByVal btnEditar As Boolean)
    End Sub

#End Region

    Private Sub frmMantPadre_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.miMantenimiento.EnEdicion Then
            Select Case Me.Preguntar("¿Desea guardar los Cambios realizados?", MessageBoxButtons.YesNoCancel)
                Case Windows.Forms.DialogResult.Yes
                    Select Case Me.miMantenimiento.Guardar()
                        Case -1
                            Me.AsignarMensaje(Me.miMantenimiento.sError, True)
                            e.Cancel = True
                        Case -2
                            Me.AsignarMensaje(Me.miMantenimiento.sError)
                            e.Cancel = True
                        Case 1
                            Me.AsignarMensaje("Registro guardado satisfactoriamente")
                            e.Cancel = False
                        Case Else
                            e.Cancel = False
                    End Select
                Case Windows.Forms.DialogResult.No
                    e.Cancel = False
                Case Else
                    e.Cancel = True
            End Select
        End If
    End Sub

End Class

Public Enum TipoMantenimiento
    Maestro = 1
    Detalle = 2
    Consulta = 3
End Enum

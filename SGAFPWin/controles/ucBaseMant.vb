Imports System.Configuration.ConfigurationSettings
Public Class ucBaseMant
    Inherits ucBaseWin

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'ucBaseMant
        '
        Me.Name = "ucBaseMant"
        Me.Size = New System.Drawing.Size(60, 34)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected cm As System.Windows.Forms.CurrencyManager

    Private _EnEdicion As Boolean = False

    Public Overridable ReadOnly Property EnEdicion() As Boolean
        Get
            Return _EnEdicion
        End Get
    End Property

    Private _sError As String
    Public Property sError() As String
        Get
            Return _sError
        End Get
        Set(ByVal Value As String)
            _sError = Value
        End Set
    End Property

    Public Overridable Function Agregar() As Integer
    End Function

    Public Overridable Function Eliminar() As Integer
        If Preguntar("¿Esta seguro de eliminar el registro?") = DialogResult.No Then Return 100
        Return 1
    End Function

    Public Overridable Function Guardar() As Integer
    End Function

    Public Overridable Sub Editar()
    End Sub

    Public Sub Primero()
        Me.cm.Position = 0
    End Sub

    Public Sub Anterior()
        If Me.cm.Position > 0 Then
            Me.cm.Position -= 1
        Else
            Me.cm.Position = Me.cm.Count - 1
        End If
    End Sub

    Public Sub Siguiente()
        If Me.cm.Position < Me.cm.Count - 1 Then
            Me.cm.Position += 1
        Else
            Me.cm.Position = 0
        End If
    End Sub

    Public Sub Ultimo()
        Me.cm.Position = Me.cm.Count - 1
    End Sub

    Public Overridable Sub Aceptar()
        Me.cm.EndCurrentEdit()
    End Sub

    Public Overridable Sub Cancelar()
        Me.cm.CancelCurrentEdit()
    End Sub

    Public Overridable Function Nuevo() As Integer

    End Function

End Class

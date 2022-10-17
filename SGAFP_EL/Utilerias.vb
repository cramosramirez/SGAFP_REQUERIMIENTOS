Imports System.Text

Public Class Utilerias

    Public Shared Function ObtenerNombreDeAutorizacion(ByVal CODIGO As String) As String
        Select Case CODIGO
            Case Enumeradores.AutorizacionExcepcion.ProgramacionRetroactiva
                Return "INGRESO DE PROGRAMACION EN FECHA RETROACTIVA"
            Case Enumeradores.AutorizacionExcepcion.InscripcionExtemporaneaParticipantes
                Return "INSCRIPCION EXTEMPORANEA DE PARTICIPANTES"
            Case Enumeradores.AutorizacionExcepcion.FinalizacionExtemporaneaCurso
                Return "FINALIZAR CURSO EN FECHA EXTEMPORANEA"
            Case Enumeradores.AutorizacionExcepcion.HorarioSimultaneoInstructor
                Return "REGISTRO DE INSTRUCTOR EN HORARIO SIMULTANEO"
            Case Enumeradores.AutorizacionExcepcion.HorarioSimultaneoParticipante
                Return "REGISTRO DE PARTICIPANTE EN HORARIO SIMULTANEO"
            Case Enumeradores.AutorizacionExcepcion.AplicarMontoLiquidacionContrato
                Return "APLICACION PARA LIQUIDACION DE CONTRATO"
            Case Enumeradores.AutorizacionExcepcion.InicioCursoPosteriorUltimaFechaInicioOferta
                Return "INICIO DE CURSO POSTERIOR A LA ULTIMA FECHA DE INICIO DE OFERTA"
            Case Enumeradores.AutorizacionExcepcion.EliminarAccionFormativa
                Return "ELIMINAR ACCION FORMATIVA"
            Case Else
                Return ""
        End Select
    End Function

    Public Shared Function QuitarAcentoEspaciosMinusculas(ByVal s As String)
        s = UCase(Trim(s))
        s = Replace(s, "  ", " ")
        s = Replace(s, "   ", " ")
        s = Replace(s, "    ", " ")
        s = Replace(s, "á", "a")
        s = Replace(s, "é", "e")
        s = Replace(s, "í", "i")
        s = Replace(s, "ó", "o")
        s = Replace(s, "ú", "u")
        s = Replace(s, "Á", "A")
        s = Replace(s, "É", "E")
        s = Replace(s, "Í", "I")
        s = Replace(s, "Ó", "O")
        s = Replace(s, "Ú", "U")

        Return s
    End Function


    Public Shared Function QuitarAcentos(ByVal s As String)
        s = Replace(s, "á", "a")
        s = Replace(s, "é", "e")
        s = Replace(s, "í", "i")
        s = Replace(s, "ó", "o")
        s = Replace(s, "ú", "u")
        s = Replace(s, "Á", "A")
        s = Replace(s, "É", "E")
        s = Replace(s, "Í", "I")
        s = Replace(s, "Ó", "O")
        s = Replace(s, "Ú", "U")

        Return s
    End Function

    Public Shared Function EsDUI(ByVal dui As String) As Boolean
        Dim digitos As New List(Of Integer)
        Dim suma As String
        Dim digitoVerificador As String
        Dim lRet As Int32

        If dui.Length <> 9 Then
            Return False
        End If
        digitos.Add(CInt(dui.Substring(0, 1)) * 9)
        digitos.Add(CInt(dui.Substring(1, 1)) * 8)
        digitos.Add(CInt(dui.Substring(2, 1)) * 7)
        digitos.Add(CInt(dui.Substring(3, 1)) * 6)
        digitos.Add(CInt(dui.Substring(4, 1)) * 5)
        digitos.Add(CInt(dui.Substring(5, 1)) * 4)
        digitos.Add(CInt(dui.Substring(6, 1)) * 3)
        digitos.Add(CInt(dui.Substring(7, 1)) * 2)
        digitos.Add(CInt(dui.Substring(8, 1)))
        suma = Convert.ToString(digitos(0) + digitos(1) + digitos(2) + digitos(3) + digitos(4) + digitos(5) + digitos(6) + digitos(7))

        digitoVerificador = suma.Substring(suma.Length - 1, 1)
        If Convert.ToInt32(digitoVerificador) = 0 Then
            lRet = 0
        Else
            lRet = 10 - Convert.ToInt32(digitoVerificador)
        End If
        If lRet = digitos(8) Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Shared Function FormatearNIT(ByVal cadena As String) As String
        If cadena = Nothing Then cadena = String.Empty
        cadena = cadena.Trim.Replace("-", "")
        If cadena.Length = 14 Then
            Dim nit As New StringBuilder
            nit.Append(cadena.Substring(0, 4))
            nit.Append("-")
            nit.Append(cadena.Substring(4, 6))
            nit.Append("-")
            nit.Append(cadena.Substring(10, 3))
            nit.Append("-")
            nit.Append(cadena.Substring(13, 1))
            Return nit.ToString
        Else
            Return cadena
        End If
    End Function

    Public Shared Function FormatearDUI(ByVal cadena As String) As String
        If cadena = Nothing Then cadena = String.Empty
        cadena = cadena.Trim.Replace("-", "")
        If cadena.Length = 9 Then
            Dim dui As New StringBuilder
            dui.Append(cadena.Substring(0, 8))
            dui.Append("-")
            dui.Append(cadena.Substring(8, 1))
            Return dui.ToString
        Else
            Return cadena
        End If
    End Function

    Public Shared Function ObtenerListaMeses() As List(Of String)
        Dim lista As New List(Of String)

        lista.Add("ENERO")
        lista.Add("FEBRERO")
        lista.Add("MARZO")
        lista.Add("ABRIL")
        lista.Add("MAYO")
        lista.Add("JUNIO")
        lista.Add("JULIO")
        lista.Add("AGOSTO")
        lista.Add("SEPTIEMBRE")
        lista.Add("OCTUBRE")
        lista.Add("NOVIEMBRE")
        lista.Add("DICIEMBRE")

        Return lista
    End Function


    Public Shared Function EsNIT(ByVal nit As String) As Boolean
        Dim lValor As String
        Dim lSuma As Int32
        Dim lDigVer As Int32
        Dim lFactor As Int32
        Dim lResiduo As Int32

        If nit.Length <> 14 Then
            Return False
        End If
        lValor = nit.Substring(0, 13)

        If Convert.ToInt32(lValor.Substring(10, 3)) <= 100 Then
            For i As Integer = 1 To 13
                lSuma += (Convert.ToInt32(lValor.Substring(i - 1, 1)) * (15 - i))
            Next
            lDigVer = lSuma Mod 11
            If lDigVer = 10 Then lDigVer = 0
        Else
            For i As Integer = 1 To 13
                lFactor = (3 + 6 * Math.Truncate((i + 4) / 6)) - i
                lSuma += (Convert.ToInt32(lValor.Substring(i - 1, 1)) * lFactor)
            Next

            lResiduo = lSuma Mod 11
            If lResiduo > 1 Then lDigVer = 11 - lResiduo Else lDigVer = 0
        End If

        If lDigVer.ToString = nit.Substring(13, 1) Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Shared Function ObtenerTipoSolicitudPorFuente(ByVal ID_FUENTE As Enumeradores.FuenteFinanciamientoPATI) As Integer
        Select Case ID_FUENTE
            Case Enumeradores.FuenteFinanciamientoPATI.PATI_USAID
                Return Enumeradores.TipoSolicitud.PATI_USAID
            Case Enumeradores.FuenteFinanciamientoPATI.PATI_BM
                Return Enumeradores.TipoSolicitud.PATI_BM
            Case Enumeradores.FuenteFinanciamientoPATI.PATI_GOES
                Return Enumeradores.TipoSolicitud.PATI_2
        End Select
    End Function

    Public Shared Function EsProgramaPATI(ByVal ID_PROGRAMA_FORMACION As Enumeradores.ProgramasFormacion) As Boolean
        Select Case ID_PROGRAMA_FORMACION
            Case Enumeradores.ProgramasFormacion.PATI_USAID, Enumeradores.ProgramasFormacion.PATI_BM, Enumeradores.ProgramasFormacion.PATI_2
                Return True
            Case Else
                Return False
        End Select
    End Function

    Public Shared Function ObtenerFuentePorProgramaFormacion(ByVal ID_PROGRAMA_FORMACION As Enumeradores.ProgramasFormacion) As Integer
        Select Case ID_PROGRAMA_FORMACION
            Case Enumeradores.ProgramasFormacion.PATI_USAID
                Return Enumeradores.FuenteFinanciamientoPATI.PATI_USAID
            Case Enumeradores.ProgramasFormacion.PATI_BM
                Return Enumeradores.FuenteFinanciamientoPATI.PATI_BM
            Case Enumeradores.ProgramasFormacion.PATI_2
                Return Enumeradores.FuenteFinanciamientoPATI.PATI_GOES
            Case Else
                Return -1
        End Select
    End Function

    Public Shared Function ObtenerTipoSolicitudPorProgramaFormacion(ByVal ID_PROGRAMA_FORMACION As Enumeradores.ProgramasFormacion) As Integer
        Select Case ID_PROGRAMA_FORMACION
            Case Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE
                Return Enumeradores.TipoSolicitud.HabilTecnicoPermanente
            Case Enumeradores.ProgramasFormacion.PATI_USAID
                Return Enumeradores.TipoSolicitud.PATI_USAID
            Case Enumeradores.ProgramasFormacion.PATI_BM
                Return Enumeradores.TipoSolicitud.PATI_BM
            Case Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL
                Return Enumeradores.TipoSolicitud.PROYECTO_ESPECIAL
            Case Enumeradores.ProgramasFormacion.PATI_2
                Return Enumeradores.TipoSolicitud.PATI_2
            Case Else
                Return -1
        End Select
    End Function

    Public Shared Function ConvertirMinutosAFormatoHoras(ByVal Minutos As Decimal) As String
        If Minutos < 60 Then
            Return "0:" + Format(Minutos, "0#")
        Else
            Return Format(Math.Truncate(Minutos / 60), "0") + ":" + Format(Minutos Mod 60, "0#")
        End If
    End Function

    Public Shared Function ReemplazarAcentos(ByVal sCadena As String) As String
        sCadena = Replace(sCadena, "á", "a")
        sCadena = Replace(sCadena, "é", "e")
        sCadena = Replace(sCadena, "í", "i")
        sCadena = Replace(sCadena, "ó", "o")
        sCadena = Replace(sCadena, "ú", "u")
        sCadena = Replace(sCadena, "Á", "A")
        sCadena = Replace(sCadena, "É", "E")
        sCadena = Replace(sCadena, "Í", "I")
        sCadena = Replace(sCadena, "Ó", "O")
        sCadena = Replace(sCadena, "Ú", "U")
        Return sCadena
    End Function

    Public Shared Function ConvertirANombreAmigable(ByVal asStrNombre As String) As String
        Dim strNombreAmigable As String = ""
        Dim tipoLetraAnterior As String = ""
        For Each c As Char In asStrNombre.ToCharArray()
            Dim esMayuscula As Boolean
            esMayuscula = (Char.ToUpper(c) = c)
            Dim tipoLetraActual As String = "m"

            If esMayuscula Then tipoLetraActual = "M"

            If tipoLetraAnterior <> "" And tipoLetraActual <> tipoLetraAnterior And tipoLetraAnterior <> "M" Then
                strNombreAmigable += " " + Char.ToUpper(c).ToString()
                tipoLetraAnterior = "m"
                If (esMayuscula) Then tipoLetraAnterior = "M"
            ElseIf (tipoLetraAnterior = "") Then
                strNombreAmigable += Char.ToUpper(c).ToString()
                tipoLetraAnterior = "m"
                If esMayuscula Then tipoLetraAnterior = "M"
            ElseIf (tipoLetraAnterior <> "") Then
                strNombreAmigable += c.ToString().ToLower()
                tipoLetraAnterior = "m"
                If (esMayuscula) Then tipoLetraAnterior = "M"
            End If
        Next
        strNombreAmigable = strNombreAmigable.Replace("_", " ")
        Return strNombreAmigable
    End Function

    Public Shared Function ConvertirANombreUsuario(ByVal asStrNombre As String) As String
        Dim strNombreUsuario As String = ""
        strNombreUsuario = asStrNombre.ToUpper()
        strNombreUsuario = strNombreUsuario.Replace(" ", "")
        Return strNombreUsuario
    End Function

    Public Shared Function ObtenerUsuario() As String
        Return System.Threading.Thread.CurrentPrincipal.Identity.Name
    End Function

    Public Shared Function EstaEnRol(ByVal NombreRol As String) As Boolean
        Return System.Threading.Thread.CurrentPrincipal.IsInRole(NombreRol)
    End Function

    Public Shared Function CalcularEdad(ByVal fechaCumpleaños As Date, ByVal fechaCalculo As Date) As Integer
        ' Obtener el numero de años
        Dim YearsAge As Integer = fechaCalculo.Year - fechaCumpleaños.Year
        ' If the birthday hasn't occured this year, subtract one year from the age
        If fechaCalculo.Month < fechaCumpleaños.Month Or (fechaCalculo.Month = fechaCumpleaños.Month And fechaCalculo.Day < fechaCumpleaños.Day) Then
            YearsAge -= 1
        End If

        Return YearsAge
    End Function

    Public Shared Function Truncar(ByVal numero As Decimal, ByVal decimales As Integer) As Decimal
        Dim strCalc As String = "1"
        For i As Integer = 1 To decimales
            strCalc += "0"
        Next
        Dim numCalc As Integer = CInt(strCalc)
        Dim parteEntera As Integer
        Dim parteDecimal As Integer
        parteEntera = Conversion.Fix(CInt(numero))
        parteDecimal = Fix(CInt((numero - parteEntera) * numCalc))
        Return CDec(parteEntera + (parteDecimal / numCalc))
    End Function


#Region " Conversion Decimales y Enteros"

    Public Shared Function ConversionDecimales(ByVal nnumero As Double) As String
        Return of_convert(CDec(nnumero))
    End Function

    Public Shared Function ConversionEnteros(ByVal nnumero As Double) As String
        Return of_convert_sin_decimales(CLng(nnumero))
    End Function

#End Region

#Region " Funciones de Conversion"
    Private Shared Function of_convert(ByVal an_cantidad As Decimal) As String
        Dim ls_cents As String
        Dim entero, dezimal As Double

        ls_cents = of_right(an_cantidad.ToString("###,##0.00"), 2)
        entero = Decimal.Truncate(an_cantidad)

        If entero >= 0 Then
            Return of_numero_a_letras(entero) + " " + ls_cents + "/100"
        Else
            Return dezimal.ToString + "/100"
        End If

    End Function

    Private Shared Function of_convert_sin_decimales(ByVal an_cantidad As Long) As String
        Dim entero As Double

        entero = CInt(Decimal.Truncate(an_cantidad))
        Return of_numero_a_letras(entero)

    End Function

    Private Shared Function of_numero_a_letras(ByVal an_cantidad As Double) As String

        Dim tamano As Integer
        Dim ldb_num As Double
        Dim ls_numero As String



        ldb_num = CInt(Decimal.Truncate(CDec(an_cantidad)))

        ls_numero = ldb_num.ToString
        tamano = ls_numero.Length

        Select Case tamano
            Case 1
                If ldb_num = 1 Then
                    Return "uno"
                Else
                    Return of_unidades(CLng(ldb_num))
                End If
            Case 2
                Return of_decenas(ls_numero)
            Case 3
                Return of_centenas(ls_numero)
            Case 4
                Return of_miles(ls_numero)
            Case 5
                Return of_decenas(of_left(ls_numero, 2)) + " mil " + of_centenas(of_right(ls_numero, 3))
            Case 6
                Return of_centenas(of_left(ls_numero, 3)) + " mil " + of_centenas(of_right(ls_numero, 3))
            Case 7
                Return of_millones(ls_numero)
            Case 8
                If CInt(of_Mid(ls_numero, 3, 3)) > 0 Then
                    Return of_decenas(of_left(ls_numero, 2)) + " millones " + of_centenas(of_Mid(ls_numero, 3, 3)) + " mil " + of_centenas(of_right(ls_numero, 3))
                Else
                    Return of_decenas(of_left(ls_numero, 2)) + " millones " + of_centenas(of_right(ls_numero, 3))
                End If
            Case 9
                If CInt(of_Mid(ls_numero, 4, 3)) > 0 Then
                    Return of_centenas(of_left(ls_numero, 3)) + " millones " + of_centenas(of_Mid(ls_numero, 4, 3)) + " mil " + of_centenas(of_right(ls_numero, 3))
                Else
                    Return of_centenas(of_left(ls_numero, 3)) + " millones " + of_centenas(of_right(ls_numero, 3))
                End If
            Case Else
                Return " "
        End Select

    End Function

    Private Shared Function of_right(ByVal asObject As String, ByVal aLongitud As Integer) As String
        Return asObject.Trim.Substring(CInt(asObject.Length - aLongitud), aLongitud)
    End Function

    Private Shared Function of_left(ByVal asObject As String, ByVal aLongitud As Integer) As String
        Return asObject.Trim.Substring(0, aLongitud)
    End Function

    Private Shared Function of_Mid(ByVal asObject As String, ByVal aInicio As Integer, ByVal aFin As Integer) As String
        Return asObject.Trim.ToString.Substring(aInicio - 1, aFin)
    End Function

    Private Shared Function of_unidades(ByVal an_unidad As Long) As String
        Select Case an_unidad
            Case 0
                Return "cero"
            Case 1
                Return "un"
            Case 2
                Return "dos"
            Case 3
                Return "tres"
            Case 4
                Return "cuatro"
            Case 5
                Return "cinco"
            Case 6
                Return "seis"
            Case 7
                Return "siete"
            Case 8
                Return "ocho"
            Case 9
                Return "nueve"
        End Select
        Return ""
    End Function

    Private Shared Function of_decenas(ByVal as_cantidad As String) As String

        as_cantidad = as_cantidad.Trim
        Dim unidad As String

        Dim ll_length As Integer

        ll_length = as_cantidad.Length - 1

        unidad = of_unidades(CInt(as_cantidad.Substring(ll_length, 1)))

        Select Case CInt(as_cantidad.Substring(0, 1)) 'CInt(left(as_cantidad, 1))
            Case 0
                Return ""
            Case 1
                Select Case as_cantidad
                    Case "10"
                        Return "diez"
                    Case "11"
                        Return "once"
                    Case "12"
                        Return "doce"
                    Case "13"
                        Return "trece"
                    Case "14"
                        Return "catorce"
                    Case "15"
                        Return "quince"
                    Case "16"
                        Return "dieciseis"
                    Case "17"
                        Return "diecisiete"
                    Case "18"
                        Return "dieciocho"
                    Case "19"
                        Return "diecinueve"
                End Select
            Case 2
                Select Case CInt(as_cantidad.Trim.Substring(ll_length, 1))
                    Case 0
                        Return "veinte"
                    Case Else
                        Return "veinte y " + unidad
                End Select
            Case 3
                Select Case CInt(as_cantidad.Trim.Substring(ll_length, 1))
                    Case 0
                        Return "treinta"
                    Case Else
                        Return "treinta y " + unidad
                End Select
            Case 4
                Select Case CInt(as_cantidad.Trim.Substring(ll_length, 1))
                    Case 0
                        Return "cuarenta"
                    Case Else
                        Return "cuarenta y " + unidad
                End Select

            Case 5
                Select Case CInt(as_cantidad.Trim.Substring(ll_length, 1))
                    Case 0
                        Return "cincuenta"
                    Case Else
                        Return "cincuenta y " + unidad
                End Select
            Case 6
                Select Case CInt(as_cantidad.Trim.Substring(ll_length, 1))
                    Case 0
                        Return "sesenta"
                    Case Else
                        Return "sesenta y " + unidad
                End Select

            Case 7
                Select Case CInt(as_cantidad.Trim.Substring(ll_length, 1))
                    Case 0
                        Return "setenta"
                    Case Else
                        Return "setenta y " + unidad
                End Select
            Case 8
                Select Case CInt(as_cantidad.Trim.Substring(ll_length, 1))
                    Case 0
                        Return "ochenta"
                    Case Else
                        Return "ochenta y " + unidad
                End Select
            Case 9
                Select Case CInt(as_cantidad.Trim.Substring(ll_length, 1))
                    Case 0
                        Return "noventa"
                    Case Else
                        Return "noventa y " + unidad
                End Select
        End Select
        Return ""
    End Function

    Private Shared Function of_centenas(ByVal as_cantidad As String) As String
        Select Case as_cantidad.Trim.Substring(0, 1)
            Case "0"
                Return of_decenas(as_cantidad.Trim.Substring(1, 2))
            Case "1"
                If as_cantidad = "100" Then
                    Return "cien"
                Else
                    Return "ciento " + of_decenas(as_cantidad.Trim.Substring(1, 2))
                End If
            Case "5"
                Return "quinientos " + of_decenas(as_cantidad.Trim.Substring(1, 2))
            Case "7"
                Return "setecientos " + of_decenas(as_cantidad.Trim.Substring(1, 2))
            Case "9"
                Return "novecientos " + of_decenas(as_cantidad.Trim.Substring(1, 2))
            Case Else
                Return of_unidades(CInt(as_cantidad.ToString.Substring(0, 1))) + "cientos " + of_decenas(as_cantidad.Trim.Substring(1, 2))

        End Select
        Return ""
    End Function

    Private Shared Function of_millones(ByVal as_cantidad As String) As String
        as_cantidad = as_cantidad.Trim
        Dim ls_millon, ls_miles As String

        If of_left(as_cantidad, 1) = "1" Then
            ls_millon = " millón "
        Else
            ls_millon = " millones "
        End If
        If CInt(of_Mid(as_cantidad, 2, 3)) > 0 Then
            ls_miles = of_centenas(of_Mid(as_cantidad, 2, 3)) + " mil "
        Else
            ls_miles = ""
        End If

        Return of_unidades(CInt(of_left(as_cantidad, 1))) + ls_millon + ls_miles + of_centenas(of_right(as_cantidad, 3))

    End Function

    Private Shared Function of_miles(ByVal as_cantidad As String) As String
        as_cantidad = as_cantidad.Trim
        Return of_unidades(CInt(as_cantidad.ToString.Substring(0, 1))) + " mil " + of_centenas(as_cantidad.Trim.Substring(as_cantidad.Length - 3, 3)) ' right(as_cantidad, 3))
    End Function

#End Region

End Class

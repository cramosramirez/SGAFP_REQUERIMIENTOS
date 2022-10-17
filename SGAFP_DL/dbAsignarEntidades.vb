Friend Module dbAsignarEntidades

    Public Sub AsignarCOMPRA_EX_PAGO_ASISTE(ByVal dr As IDataReader, ByRef e As COMPRA_EX_PAGO_ASISTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New COMPRA_EX_PAGO_ASISTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CONTRATACION_EX = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATACION_EX", aliasTabla))))
        e.REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}REFERENCIA", aliasTabla))))
        e.ID_TIPO_CONTRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_CONTRA", aliasTabla)), -1))
    End Sub
    

    Public Sub AsignarASISTENCIA_PAGO_DET(ByVal dr As IDataReader, ByRef e As ASISTENCIA_PAGO_DET, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ASISTENCIA_PAGO_DET
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ASISTE_PAGO_DET = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ASISTE_PAGO_DET", aliasTabla))))
        e.ID_ASISTE_PAGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ASISTE_PAGO", aliasTabla))))
        e.ID_MODALIDAD_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_MODALIDAD_FORMACION", aliasTabla)), -1))
        e.PORC_ASISTE_INI = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_ASISTE_INI", aliasTabla))))
        e.PORC_ASISTE_FIN = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_ASISTE_FIN", aliasTabla))))
        e.PORC_PAGO_COSTO_PARTI = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_PAGO_COSTO_PARTI", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarASISTENCIA_PAGO(ByVal dr As IDataReader, ByRef e As ASISTENCIA_PAGO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ASISTENCIA_PAGO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ASISTE_PAGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ASISTE_PAGO", aliasTabla))))
        e.DESCRIPCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_EJERCICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ID_EJERCICIO", aliasTabla))))
    End Sub


    Public Sub AsignarCONTRATO_COMPRA_PENALIZACION(ByVal dr As IDataReader, ByRef e As CONTRATO_COMPRA_PENALIZACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTRATO_COMPRA_PENALIZACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CONTRA_PENA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRA_PENA", aliasTabla))))
        e.ID_CONTRATO_COMPRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO_COMPRA", aliasTabla))))
        e.ID_TIPO_PENA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PENA", aliasTabla))))
        e.RANGO_INI = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RANGO_INI", aliasTabla))))
        e.RANGO_FIN = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RANGO_FIN", aliasTabla))))
        e.PORC_PENA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_PENA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarCONTRATO_COMPRA_PGOACTIVOS(ByVal dr As IDataReader, ByRef e As CONTRATO_COMPRA_PGOACTIVOS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTRATO_COMPRA_PGOACTIVOS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PAGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PAGO", aliasTabla))))
        e.ID_CONTRATO_COMPRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO_COMPRA", aliasTabla)), -1))
        e.NO_ACTIVOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_ACTIVOS", aliasTabla)), -1))
        e.PORC_RECONOCIMIENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_RECONOCIMIENTO", aliasTabla)), -1))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarACCION_VISITAS_SEGUI(ByVal dr As IDataReader, ByRef e As ACCION_VISITAS_SEGUI, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ACCION_VISITAS_SEGUI
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ACCION_VISITA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_VISITA", aliasTabla))))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla))))
        e.NO_VISITAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_VISITAS", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarINFORME_PRESELECCION_EC(ByVal dr As IDataReader, ByRef e As INFORME_PRESELECCION_EC, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New INFORME_PRESELECCION_EC
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_INFORME_PRESE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_INFORME_PRESE", aliasTabla))))
        e.ID_GRUPO_SELEC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_GRUPO_SELEC", aliasTabla))))
        e.ID_CONTRATO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO", aliasTabla))))
        e.FECHA_REPORTE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_REPORTE", aliasTabla))))
        e.FECHA_INICIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIO", aliasTabla))))
        e.FECHA_FINALIZACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FINALIZACION", aliasTabla))))
        e.ELABORADO_POR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ELABORADO_POR", aliasTabla))))
        e.PARTI_EVALUADOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTI_EVALUADOS", aliasTabla))))
        e.COSTO_X_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}COSTO_X_PARTICIPANTE", aliasTabla))))
        e.COSTO_X_HORA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}COSTO_X_HORA", aliasTabla))))
        e.COSTO_X_VISITA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}COSTO_X_VISITA", aliasTabla))))
        e.TOTAL_PAGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL_PAGAR", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
    End Sub

    Public Sub AsignarSOLICITUD_INSCRIPCION_EC(ByVal dr As IDataReader, ByRef e As SOLICITUD_INSCRIPCION_EC, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLICITUD_INSCRIPCION_EC
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ID_SOLIC_PRESELEC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_PRESELEC", aliasTabla)), -1))
        e.ID_ACTI_ECONOMICA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACTI_ECONOMICA", aliasTabla)), -1))
        e.ID_AREA_EMPRESA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_AREA_EMPRESA", aliasTabla)), -1))
        e.ID_GRUPO_SELEC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_GRUPO_SELEC", aliasTabla)), -1))
        e.ID_INGRESO_MES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_INGRESO_MES", aliasTabla)), -1))
        e.ID_MOTIVO_DEJO_ESTU = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_MOTIVO_DEJO_ESTU", aliasTabla)), -1))
        e.ID_MOTIVO_DEJO_TRAB = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_MOTIVO_DEJO_TRAB", aliasTabla)), -1))
        e.ID_TIEMPO_NOTRAB = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIEMPO_NOTRAB", aliasTabla)), -1))
        e.ID_TIPO_SELECC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_SELECC", aliasTabla)), -1))
        e.ID_ULT_SALARIO_MES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ULT_SALARIO_MES", aliasTabla)), -1))
        e.MANERA_OBT_ING_BECA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MANERA_OBT_ING_BECA", aliasTabla))))
        e.MOTIVO_ELIGIO_CARRERA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOTIVO_ELIGIO_CARRERA", aliasTabla))))
        e.OCUACT_ESTU_TRAB = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_ESTU_TRAB", aliasTabla)), -1))
        e.OTRO_MOTIVO_DEJO_ESTU = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OTRO_MOTIVO_DEJO_ESTU", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
    End Sub


    Public Sub AsignarCALE_HORARIO(ByVal dr As IDataReader, ByRef e As CALE_HORARIO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CALE_HORARIO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_HORA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_HORA", aliasTabla))))
        e.ID_CALE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CALE", aliasTabla)), -1))
        e.HORA_INI = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}HORA_INI", aliasTabla))))
        e.HORA_FIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}HORA_FIN", aliasTabla))))
        e.MINUTOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MINUTOS", aliasTabla)), -1))
    End Sub

    Public Sub AsignarCALE_FECHA(ByVal dr As IDataReader, ByRef e As CALE_FECHA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CALE_FECHA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CALE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CALE", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.HORARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}HORARIO", aliasTabla))))
        e.MINUTOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MINUTOS", aliasTabla)), -1))
    End Sub

    Public Sub AsignarSOLIC_PRESELE_CURREC(ByVal dr As IDataReader, ByRef e As SOLIC_PRESELE_CURREC, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_PRESELE_CURREC
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PRESELE_CURREC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PRESELE_CURREC", aliasTabla))))
        e.ID_SOLIC_PRESELEC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_PRESELEC", aliasTabla)), -1))
        e.APOYO_INSAFORP = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}APOYO_INSAFORP", aliasTabla)), -1))
        e.ANIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ANIO", aliasTabla)), -1))
        e.NOMBRE_CURSO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CURSO", aliasTabla))))
    End Sub

    Public Sub AsignarSOLIC_PRESELE_EMPRE(ByVal dr As IDataReader, ByRef e As SOLIC_PRESELE_EMPRE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_PRESELE_EMPRE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_EMPRESA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_EMPRESA", aliasTabla))))
        e.ID_SOLIC_PRESELEC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_PRESELEC", aliasTabla))))
        e.NOMBRE_EMPRESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_EMPRESA", aliasTabla))))
        e.CARGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CARGO", aliasTabla))))
        e.FUNCIONES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}FUNCIONES", aliasTabla))))
        e.DESDE_HASTA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESDE_HASTA", aliasTabla))))
    End Sub

    Public Sub AsignarDISCA_SOLIC_PRESELE(ByVal dr As IDataReader, ByRef e As DISCA_SOLIC_PRESELE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DISCA_SOLIC_PRESELE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DISCA_SOLIC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_DISCA_SOLIC", aliasTabla))))
        e.ID_DISCAPACIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_DISCAPACIDAD", aliasTabla))))
        e.ID_SOLIC_PRESELEC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_PRESELEC", aliasTabla))))
    End Sub

    Public Sub AsignarSOLICITUD_PRESELECCION_EC(ByVal dr As IDataReader, ByRef e As SOLICITUD_PRESELECCION_EC, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLICITUD_PRESELECCION_EC
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLIC_PRESELEC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLIC_PRESELEC", aliasTabla))))
        e.FECHA_PRESENTACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_PRESENTACION", aliasTabla))))
        e.ID_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PARTICIPANTE", aliasTabla))))
        e.ID_ESTADO_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_SOLICITUD", aliasTabla))))
        e.ID_GRUPO_SELEC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_GRUPO_SELEC", aliasTabla))))
        e.ID_TIPO_SELECC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_SELECC", aliasTabla))))
        e.NOMBRES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES", aliasTabla))))
        e.APELLIDOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.TIPO_DOCTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIPO_DOCTO", aliasTabla)), -1))
        e.NUM_DOCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUM_DOCTO", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.ISSS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ISSS", aliasTabla))))
        e.ID_PAIS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PAIS", aliasTabla)), -1))
        e.DEPARTAMENTO_NAC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DEPARTAMENTO_NAC", aliasTabla))))
        e.MUNICIPIO_NAC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MUNICIPIO_NAC", aliasTabla))))
        e.FECHA_NACIMIENTO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_NACIMIENTO", aliasTabla))))
        e.GENERO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}GENERO", aliasTabla))))
        e.EDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EDAD", aliasTabla)), -1))
        e.MIEMBROS_GRUPO_FAMILIAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MIEMBROS_GRUPO_FAMILIAR", aliasTabla)), -1))
        e.ID_ESTADO_CIVIL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_CIVIL", aliasTabla)), -1))
        e.ES_JEFE_HOGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ES_JEFE_HOGAR", aliasTabla)), -1))
        e.TIENE_HIJOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIENE_HIJOS", aliasTabla)), -1))
        e.NO_DE_HIJOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_DE_HIJOS", aliasTabla)), -1))
        e.SE_DEDICA_ALGUNA_PROFESION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SE_DEDICA_ALGUNA_PROFESION", aliasTabla)), -1))
        e.PROFESION_OFICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PROFESION_OFICIO", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.MOVIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOVIL", aliasTabla))))
        e.EMAIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL", aliasTabla))))
        e.CON_DISCAPACIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CON_DISCAPACIDAD", aliasTabla)), -1))
        e.DISC_OTRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DISC_OTRA", aliasTabla))))
        e.ID_NIVEL_ACADEMICO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_NIVEL_ACADEMICO", aliasTabla)), -1))
        e.OTRA_EDUCACION_FORMAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OTRA_EDUCACION_FORMAL", aliasTabla))))
        e.TITULO_CERTIFICADO_OBTENIDO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TITULO_CERTIFICADO_OBTENIDO", aliasTabla))))
        e.ESTUDIA_ACTUALMENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ESTUDIA_ACTUALMENTE", aliasTabla)), -1))
        e.ID_TIEMPO_DEJO_ESTUDIAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIEMPO_DEJO_ESTUDIAR", aliasTabla)), -1))
        e.ID_MOTIVO_DEJO_ESTU = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_MOTIVO_DEJO_ESTU", aliasTabla)), -1))
        e.OTRO_MOTIVO_DEJO_ESTU = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OTRO_MOTIVO_DEJO_ESTU", aliasTabla))))
        e.RECIBIO_CURSO_ANTERIOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}RECIBIO_CURSO_ANTERIOR", aliasTabla))))
        e.BENEF_PROM_EMP_ACT = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_PROM_EMP_ACT", aliasTabla)), -1))
        e.BENEF_OBT_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_OBT_EMPLEO", aliasTabla)), -1))
        e.BENEF_OBT_ING_EXTRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_OBT_ING_EXTRA", aliasTabla)), -1))
        e.BENEF_CAMB_EMP_X_CURSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_CAMB_EMP_X_CURSO", aliasTabla)), -1))
        e.BENEF_TRAB_CTA_PROPIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_TRAB_CTA_PROPIA", aliasTabla)), -1))
        e.BENEF_OTRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}BENEF_OTRO", aliasTabla))))
        e.RAZON_NO_BENEFICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}RAZON_NO_BENEFICIO", aliasTabla))))
        e.OCUACT_TRABAJA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_TRABAJA", aliasTabla)), -1))
        e.OCUACT_ESTUDIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_ESTUDIA", aliasTabla)), -1))
        e.OCUACT_ESTU_TRAB = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_ESTU_TRAB", aliasTabla)), -1))
        e.OCUACT_OFICIO_HOGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_OFICIO_HOGAR", aliasTabla)), -1))
        e.OCUACT_BUSCA_TRAB = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_BUSCA_TRAB", aliasTabla)), -1))
        e.OCUACT_OTRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OCUACT_OTRA", aliasTabla))))
        e.RECIBE_INGRESOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RECIBE_INGRESOS", aliasTabla)), -1))
        e.MANERA_OBT_ING_TRABAJO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MANERA_OBT_ING_TRABAJO", aliasTabla)), -1))
        e.MANERA_OBT_ING_BECA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MANERA_OBT_ING_BECA", aliasTabla)), -1))
        e.MANERA_OBT_ING_AYUDA_FAM = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MANERA_OBT_ING_AYUDA_FAM", aliasTabla)), -1))
        e.MANERA_OBT_ING_REMESA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MANERA_OBT_ING_REMESA", aliasTabla)), -1))
        e.MANERA_OBT_ING_OTRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MANERA_OBT_ING_OTRO", aliasTabla))))
        e.ID_INGRESO_MES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_INGRESO_MES", aliasTabla))))
        e.ID_TIEMPO_NOTRAB = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIEMPO_NOTRAB", aliasTabla)), -1))
        e.ID_ACTI_ECONOMICA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACTI_ECONOMICA", aliasTabla)), -1))
        e.ID_AREA_EMPRESA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_AREA_EMPRESA", aliasTabla)), -1))
        e.ID_MOTIVO_DEJO_TRAB = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_MOTIVO_DEJO_TRAB", aliasTabla)), -1))
        e.EXPFOR_OBTENER_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_OBTENER_EMPLEO", aliasTabla)), -1))
        e.EXPFOR_INGRESOS_EXTRAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_INGRESOS_EXTRAS", aliasTabla)), -1))
        e.EXPFOR_TRABAJAR_CTA_PROPIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_TRABAJAR_CTA_PROPIA", aliasTabla)), -1))
        e.EXPFOR_OTRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_OTRO", aliasTabla))))
        e.MOTIVO_ELIGIO_CARRERA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOTIVO_ELIGIO_CARRERA", aliasTabla))))
        e.NOMBRE_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_REFERENCIA", aliasTabla))))
        e.ID_REFERENCIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_REFERENCIA", aliasTabla)), -1))
        e.DIRECCION_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION_REFERENCIA", aliasTabla))))
        e.DEPARTAMENTO_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DEPARTAMENTO_REFERENCIA", aliasTabla))))
        e.MUNICIPIO_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MUNICIPIO_REFERENCIA", aliasTabla))))
        e.TELEFONO_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO_REFERENCIA", aliasTabla))))
        e.MOVIL_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOVIL_REFERENCIA", aliasTabla))))
        e.EMAIL_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL_REFERENCIA", aliasTabla))))
        e.SUGERENCIAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SUGERENCIAS", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.TIPO_EMPLEO_OTRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_EMPLEO_OTRO", aliasTabla))))
        e.TRABAJO_ANTERIOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TRABAJO_ANTERIOR", aliasTabla))))
        e.PUESTO_DESEMPENO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PUESTO_DESEMPENO", aliasTabla))))
        e.ID_ULT_SALARIO_MES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ULT_SALARIO_MES", aliasTabla)), -1))
        e.ES_RECLUTA_INICIAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ES_RECLUTA_INICIAL", aliasTabla)), -1))
        e.ES_RECLUTA_EXTRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ES_RECLUTA_EXTRA", aliasTabla)), -1))
        e.REQUI_AUTORIZACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REQUI_AUTORIZACION", aliasTabla)), -1))
        e.OBSERVACION_AURIZACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACION_AURIZACION", aliasTabla))))
        e.AUTORIZADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AUTORIZADO", aliasTabla)), -1))
        e.MOTIVO_AUTORIZADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOTIVO_AUTORIZADO", aliasTabla))))
        e.USUARIO_AUTORIZO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_AUTORIZO", aliasTabla))))
        e.FECHA_AITORIZA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_AITORIZA", aliasTabla))))
    End Sub

    Public Sub AsignarMOTIVO_DEJO_TRAB(ByVal dr As IDataReader, ByRef e As MOTIVO_DEJO_TRAB, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New MOTIVO_DEJO_TRAB
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_MOTIVO_DEJO_TRAB = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_MOTIVO_DEJO_TRAB", aliasTabla))))
        e.NOMBRE_MOTIVO_DEJO_TRAB = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_MOTIVO_DEJO_TRAB", aliasTabla))))
    End Sub

    Public Sub AsignarAREA_EMPRESA(ByVal dr As IDataReader, ByRef e As AREA_EMPRESA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New AREA_EMPRESA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_AREA_EMPRESA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_AREA_EMPRESA", aliasTabla))))
        e.NOMBRE_AREA_EMPRESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_AREA_EMPRESA", aliasTabla))))
    End Sub

    Public Sub AsignarACTI_ECONOMICA(ByVal dr As IDataReader, ByRef e As ACTI_ECONOMICA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ACTI_ECONOMICA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ACTI_ECONOMICA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACTI_ECONOMICA", aliasTabla))))
        e.NOMBRE_ACTI_ECONOMICA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ACTI_ECONOMICA", aliasTabla))))
    End Sub

    Public Sub AsignarMOTIVO_DEJO_ESTU(ByVal dr As IDataReader, ByRef e As MOTIVO_DEJO_ESTU, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New MOTIVO_DEJO_ESTU
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_MOTIVO_DEJO_ESTU = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_MOTIVO_DEJO_ESTU", aliasTabla))))
        e.NOMBRE_MOTIVO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_MOTIVO", aliasTabla))))
    End Sub

    Public Sub AsignarTIEMPO_NOTRAB(ByVal dr As IDataReader, ByRef e As TIEMPO_NOTRAB, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIEMPO_NOTRAB
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIEMPO_NOTRAB = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIEMPO_NOTRAB", aliasTabla))))
        e.NOMBRE_TIEMPO_NOTRAB = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TIEMPO_NOTRAB", aliasTabla))))
    End Sub

    Public Sub AsignarINGRESO_MES(ByVal dr As IDataReader, ByRef e As INGRESO_MES, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New INGRESO_MES
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_INGRESO_MES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_INGRESO_MES", aliasTabla))))
        e.NOMBRE_ING = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ING", aliasTabla))))
    End Sub

    Public Sub AsignarTIPO_SELECC(ByVal dr As IDataReader, ByRef e As TIPO_SELECC, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_SELECC
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_SELECC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_SELECC", aliasTabla))))
        e.NOMBRE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE", aliasTabla))))
    End Sub


    Public Sub AsignarGRUPO_SELECCION(ByVal dr As IDataReader, ByRef e As GRUPO_SELECCION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New GRUPO_SELECCION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_GRUPO_SELEC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_GRUPO_SELEC", aliasTabla))))
        e.ID_ACCION_CONTRATADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_CONTRATADA", aliasTabla))))
        e.FECHA_HABILITA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_HABILITA", aliasTabla))))
        e.FECHA_INICIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIO", aliasTabla))))
        e.FECHA_FIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN", aliasTabla))))
        e.NO_GRUPO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_GRUPO", aliasTabla))))
        e.CODIGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.LUGAR_EJECUCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}LUGAR_EJECUCION", aliasTabla))))
    End Sub

    Public Sub AsignarRANGO_PORC_PENA(ByVal dr As IDataReader, ByRef e As RANGO_PORC_PENA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New RANGO_PORC_PENA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_RANGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_RANGO", aliasTabla))))
        e.ID_TIPO_PENA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PENA", aliasTabla))))
        e.RANGO_INI = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RANGO_INI", aliasTabla))))
        e.RANGO_FIN = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RANGO_FIN", aliasTabla))))
        e.PORC_PENA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_PENA", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.ID_PROGRAMA_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROGRAMA_FORMACION", aliasTabla))))
        e.IsDirty = False
    End Sub

    Public Sub AsignarTIPO_PENALIZA(ByVal dr As IDataReader, ByRef e As TIPO_PENALIZA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_PENALIZA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_PENA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PENA", aliasTabla))))
        e.NOMBRE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE", aliasTabla))))
        e.IsDirty = False
    End Sub

    Public Sub AsignarAREA_FORMACION_CONTRA(ByVal dr As IDataReader, ByRef e As AREA_FORMACION_CONTRA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New AREA_FORMACION_CONTRA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_AREA_CONTRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_AREA_CONTRA", aliasTabla))))
        e.ID_CONTRATO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO", aliasTabla))))
        e.ID_AREA_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_AREA_FORMACION", aliasTabla))))
        e.MONTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO", aliasTabla))))
        e.PARTICIPACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIPACION", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.IsDirty = False
    End Sub

    Public Sub AsignarTIPO_ADJUDICACION(ByVal dr As IDataReader, ByRef e As TIPO_ADJUDICACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_ADJUDICACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_ADJ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ADJ", aliasTabla))))
        e.NOMBRE_ADJ = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ADJ", aliasTabla))))
        e.IsDirty = False
    End Sub

    Public Sub AsignarACCION_FORMATIVA_SEGUI(ByVal dr As IDataReader, ByRef e As ACCION_FORMATIVA_SEGUI, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ACCION_FORMATIVA_SEGUI
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ACCION_FORMATIVA_SEGUI = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA_SEGUI", aliasTabla))))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla))))
        e.FECHA_VISITA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_VISITA", aliasTabla))))
        e.OBSERVACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACION", aliasTabla))))
        e.COMENTARIO_ADMIN_PROGRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COMENTARIO_ADMIN_PROGRA", aliasTabla))))
        e.ID_UNIDAD_ORGANIZATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_UNIDAD_ORGANIZATIVA", aliasTabla)), -1))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
    End Sub

    Public Sub AsignarACCION_FORMATIVA_PENA(ByVal dr As IDataReader, ByRef e As ACCION_FORMATIVA_PENA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ACCION_FORMATIVA_PENA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ACCION_FORMATIVA_PENA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA_PENA", aliasTabla))))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla))))
        e.PORC_PENALIZACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_PENALIZACION", aliasTabla))))
        e.MOTIVO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOTIVO", aliasTabla))))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.ID_TIPO_PENA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PENA", aliasTabla))))
    End Sub

    Public Sub AsignarACCION_PROGRA_RETRO(ByVal dr As IDataReader, ByRef e As ACCION_PROGRA_RETRO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ACCION_PROGRA_RETRO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ACCION_PROGRA_RETRO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_PROGRA_RETRO", aliasTabla))))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla))))
        e.ID_EJERCICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ID_EJERCICIO", aliasTabla))))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla)), -1))
        e.NOMBRE_ACCION_FORMATIVA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ACCION_FORMATIVA", aliasTabla))))
        e.CODIGO_GRUPO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_GRUPO", aliasTabla))))
        e.FECHA_EXPIRA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_EXPIRA", aliasTabla))))
        e.MOTIVO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOTIVO", aliasTabla))))
        e.ACTIVO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ACTIVO", aliasTabla))))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.USUARIO_PROGRAMO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_PROGRAMO", aliasTabla))))
        e.FECHA_PROGRAMO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_PROGRAMO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.CODIGO_ESTADO_AF_PROP = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_ESTADO_AF_PROP", aliasTabla))))
    End Sub


    Public Sub AsignarCONTRATO_COMPRA(ByVal dr As IDataReader, ByRef e As CONTRATO_COMPRA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTRATO_COMPRA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CONTRATO_COMPRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO_COMPRA", aliasTabla))))
        e.NO_CONTRATO_COMPRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_CONTRATO_COMPRA", aliasTabla))))
        e.FECHA_INGRESO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INGRESO", aliasTabla))))
        e.USUARIO_CREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREA", aliasTabla))))
        e.FECHA_CREA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREA", aliasTabla))))
        e.USUARIO_ACT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ACT", aliasTabla))))
        e.FECHA_ACT = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACT", aliasTabla))))
        e.FECHA_INI_EJEC = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INI_EJEC", aliasTabla))))
        e.FECHA_FIN_EJEC = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN_EJEC", aliasTabla))))
        e.PORC_ASISTENCIA_MIN = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_ASISTENCIA_MIN", aliasTabla))))
        e.PAGO_POR_PARTICIPACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PAGO_POR_PARTICIPACION", aliasTabla))))
        e.BASE_PARTI = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BASE_PARTI", aliasTabla)), -1))
        e.ULTFECHA_CALENDARIZA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}ULTFECHA_CALENDARIZA", aliasTabla))))
        e.ID_UNIDAD_ORGANIZATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_UNIDAD_ORGANIZATIVA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarFUENTE_MUNICIPIO(ByVal dr As IDataReader, ByRef e As FUENTE_MUNICIPIO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New FUENTE_MUNICIPIO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_FUENTE_MUNICIPIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FUENTE_MUNICIPIO", aliasTabla))))
        e.ID_FUENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FUENTE", aliasTabla))))
        e.NO_CONVOCATORIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_CONVOCATORIA", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.NOMBRE_BANCO_LIQ = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_BANCO_LIQ", aliasTabla))))
        e.NO_CTA_LIQ = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_CTA_LIQ", aliasTabla))))
        e.NOMBRE_CTA_LIQ = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CTA_LIQ", aliasTabla))))
        e.CODIGO_FINANCIAMIENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_FINANCIAMIENTO", aliasTabla))))
        e.NOMBRE_BANCO_DESEMBOLSO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_BANCO_DESEMBOLSO", aliasTabla))))
        e.NO_CTA_DESEMBOLSO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_CTA_DESEMBOLSO", aliasTabla))))
        e.NOMBRE_CTA_DESEMBOLSO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CTA_DESEMBOLSO", aliasTabla))))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarSIPU_TIPOCAPACITACIONES(ByVal dr As IDataReader, ByRef e As SIPU_TIPOCAPACITACIONES, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SIPU_TIPOCAPACITACIONES
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.IDTIPOCAPACITACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IDTIPOCAPACITACION", aliasTabla))))
        e.DESCRIPCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION", aliasTabla))))
    End Sub

    Public Sub AsignarSIPU_MUNICIPIO(ByVal dr As IDataReader, ByRef e As SIPU_MUNICIPIO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SIPU_MUNICIPIO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.IDMUNICIPIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IDMUNICIPIO", aliasTabla))))
        e.DESCRIPCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION", aliasTabla))))
        e.IDDEPARTAMENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IDDEPARTAMENTO", aliasTabla))))
        e.CODMUNICIPIOFIS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CODMUNICIPIOFIS", aliasTabla))))
        e.CODIGO_DEPTO_INSAFORP = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPTO_INSAFORP", aliasTabla))))
        e.CODIGO_MUNI_INSAFORP = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNI_INSAFORP", aliasTabla))))
    End Sub

    Public Sub AsignarSIPU_GENERACION(ByVal dr As IDataReader, ByRef e As SIPU_GENERACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SIPU_GENERACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_GENERACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_GENERACION", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.FUENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}FUENTE", aliasTabla))))
        e.NUMERO_CONVOCATORIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NUMERO_CONVOCATORIA", aliasTabla))))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.NOMBRE_ARCHIVO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ARCHIVO", aliasTabla))))
    End Sub

    Public Sub AsignarSIPU_DETALLECAPACITACIONES(ByVal dr As IDataReader, ByRef e As SIPU_DETALLECAPACITADO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SIPU_DETALLECAPACITADO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.IDDETALLECAPACITADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IDDETALLECAPACITADO", aliasTabla))))
        e.ID_CAPACITACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CAPACITACION", aliasTabla))))
        e.CONVENIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CONVENIO", aliasTabla))))
        e.ESTADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla))))
    End Sub

    Public Sub AsignarSIPU_CAPACITACIONES(ByVal dr As IDataReader, ByRef e As SIPU_CAPACITACIONES, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SIPU_CAPACITACIONES
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.IDCAPACITACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IDCAPACITACION", aliasTabla))))
        e.DESCRIPCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION", aliasTabla))))
        e.IDTIPOCAPACITACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IDTIPOCAPACITACION", aliasTabla)), -1))
        e.IDESTADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IDESTADO", aliasTabla)), -1))
        e.FECHAINICIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHAINICIO", aliasTabla))))
        e.FECHAFIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHAFIN", aliasTabla))))
        e.IDMUNICIPIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}IDMUNICIPIO", aliasTabla))))
        e.ID_GENERACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_GENERACION", aliasTabla))))
    End Sub

    Public Sub AsignarTIPO_CONTRATACION(ByVal dr As IDataReader, ByRef e As TIPO_CONTRATACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_CONTRATACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_CONTRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_CONTRA", aliasTabla))))
        e.NOM_TIPO_CONTRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOM_TIPO_CONTRA", aliasTabla))))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarACCION_PARTI_SINDOCTOS(ByVal dr As IDataReader, ByRef e As ACCION_PARTI_SINDOCTOS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ACCION_PARTI_SINDOCTOS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ACCION_PARTI = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_PARTI", aliasTabla))))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla))))
        e.CANT_PARTICIPANTES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANT_PARTICIPANTES", aliasTabla))))
        e.ES_ACTIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ES_ACTIVA", aliasTabla))))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.TIPO_AUTORIZACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_AUTORIZACION", aliasTabla))))
    End Sub

    Public Sub AsignarGRUPO_ACCION_CONTRATADA(ByVal dr As IDataReader, ByRef e As GRUPO_ACCION_CONTRATADA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New GRUPO_ACCION_CONTRATADA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_GRUPO_ACCION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_GRUPO_ACCION", aliasTabla))))
        e.ID_ACCION_CONTRATADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_CONTRATADA", aliasTabla))))
        e.ID_GRUPO_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_GRUPO_AF", aliasTabla))))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla)), -1))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.MONTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO", aliasTabla))))
        e.HABILITADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}HABILITADO", aliasTabla))))
    End Sub

    Public Sub AsignarCONTRATO_BOLPROS(ByVal dr As IDataReader, ByRef e As CONTRATO_BOLPROS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTRATO_BOLPROS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CONTRATO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO", aliasTabla))))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla))))
        e.ID_PROGRAMA_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROGRAMA_FORMACION", aliasTabla))))
        e.ID_FUENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FUENTE", aliasTabla)), -1))
        e.NUM_CONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUM_CONTRATO", aliasTabla))))
        e.MONTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO", aliasTabla))))
        e.LOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}LOTE", aliasTabla))))
        e.SUB_LOTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SUB_LOTE", aliasTabla))))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.ID_TIPO_CONTRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_CONTRA", aliasTabla)), -1))
        e.ID_OFERTA_COMPRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_OFERTA_COMPRA", aliasTabla)), -1))
        e.ID_CONTRATO_COMPRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO_COMPRA", aliasTabla)), -1))
        e.FECHA_INI_EJEC = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INI_EJEC", aliasTabla))))
        e.FECHA_FIN_EJEC = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN_EJEC", aliasTabla))))
        e.ES_PAGO_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ES_PAGO_PARTICIPANTE", aliasTabla)), -1))
        e.ID_TIPO_ADJ = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_ADJ", aliasTabla)), -1))
        e.COSTO_X_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}COSTO_X_PARTICIPANTE", aliasTabla)), -1))
        e.PARTICIPACIONES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIPACIONES", aliasTabla)), -1))
        e.ES_INCREMENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ES_INCREMENTO", aliasTabla)), -1))
        e.NO_PRODUCTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_PRODUCTO", aliasTabla)), -1))
    End Sub

    Public Sub AsignarACCION_CONTRATADA(ByVal dr As IDataReader, ByRef e As ACCION_CONTRATADA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ACCION_CONTRATADA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ACCION_CONTRATADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_CONTRATADA", aliasTabla))))
        e.ID_CONTRATO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.CODIGO_PROGRAMA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_PROGRAMA", aliasTabla))))
        e.DURACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DURACION", aliasTabla))))
        e.CANT_CURSOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANT_CURSOS", aliasTabla))))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.NUM_ITEM = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NUM_ITEM", aliasTabla))))
        e.MONTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO", aliasTabla))))
        e.NO_CONVOCATORIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_CONVOCATORIA", aliasTabla)), -1))
        e.COSTO_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}COSTO_PARTICIPANTE", aliasTabla)), -1))
        e.NOMBRE_ACCION_FORMATIVA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ACCION_FORMATIVA", aliasTabla))))
        e.COSTO_HORA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}COSTO_HORA", aliasTabla)), -1))
        e.COSTO_VISITA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}COSTO_VISITA", aliasTabla)), -1))
        e.CODIGO_CATEG = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_CATEG", aliasTabla))))
        e.NOMBRE_CATEG = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CATEG", aliasTabla))))
    End Sub


    Public Sub AsignarROL_PROGRAMA(ByVal dr As IDataReader, ByRef e As ROL_PROGRAMA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ROL_PROGRAMA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ROL_PROGRAMA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ROL_PROGRAMA", aliasTabla))))
        e.ROL_USUARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ROL_USUARIO", aliasTabla))))
        e.ID_PROGRAMA_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROGRAMA_FORMACION", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarOFERTA_FORMATIVA_DEPTO(ByVal dr As IDataReader, ByRef e As OFERTA_FORMATIVA_DEPTO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New OFERTA_FORMATIVA_DEPTO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_OFERTA_FORMATIVA_DEPTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_OFERTA_FORMATIVA_DEPTO", aliasTabla))))
        e.ID_OFERTA_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_OFERTA_FORMATIVA", aliasTabla))))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.PARTI_ADJUDICADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTI_ADJUDICADA", aliasTabla))))
        e.MONTO_ADJUDICADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_ADJUDICADO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarSITIO_CAPACITACION_EJERCICIO(ByVal dr As IDataReader, ByRef e As SITIO_CAPACITACION_EJERCICIO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SITIO_CAPACITACION_EJERCICIO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SITIO_CAPACITACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SITIO_CAPACITACION", aliasTabla))))
        e.ID_EJERCICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ID_EJERCICIO", aliasTabla))))
    End Sub

    Public Sub AsignarOFERTA_FORMATIVA_SITIO(ByVal dr As IDataReader, ByRef e As OFERTA_FORMATIVA_SITIO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New OFERTA_FORMATIVA_SITIO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_OFERTA_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_OFERTA_FORMATIVA", aliasTabla))))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla))))
        e.ID_SITIO_CAPACITACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SITIO_CAPACITACION", aliasTabla))))
        e.ID_EJERCICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ID_EJERCICIO", aliasTabla))))
        e.DURACION_HORAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DURACION_HORAS", aliasTabla)), -1))
        e.COSTO_X_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}COSTO_X_PARTICIPANTE", aliasTabla)), -1))
        e.USER_ID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USER_ID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.PARTICIPACION_ADJUDICADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIPACION_ADJUDICADA", aliasTabla)), -1))
        e.MONTO_ADJUDICADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_ADJUDICADO", aliasTabla)), -1))
    End Sub

    Public Sub AsignarPARTICIPANTE_EXONERADO_DOC(ByVal dr As IDataReader, ByRef e As PARTICIPANTE_EXONERADO_DOC, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PARTICIPANTE_EXONERADO_DOC
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PARTICIPANTE_EXONERADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PARTICIPANTE_EXONERADO", aliasTabla))))
        e.ID_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PARTICIPANTE", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla)), -1))
        e.ID_SITIO_CAPACITACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SITIO_CAPACITACION", aliasTabla)), -1))
        e.NOMBRES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES", aliasTabla))))
        e.APELLIDOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS", aliasTabla))))
        e.FECHA_NACIMIENTO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_NACIMIENTO", aliasTabla))))
        e.GENERO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}GENERO", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.DEPARTAMENTO_NAC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DEPARTAMENTO_NAC", aliasTabla))))
        e.MUNICIPIO_NAC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MUNICIPIO_NAC", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.MOVIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOVIL", aliasTabla))))
        e.CON_DISCAPACIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CON_DISCAPACIDAD", aliasTabla))))
        e.EMAIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL", aliasTabla))))
        e.ID_NIVEL_ACADEMICO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_NIVEL_ACADEMICO", aliasTabla))))
        e.ID_PAIS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PAIS", aliasTabla))))
        e.ID_ESTADO_CIVIL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_CIVIL", aliasTabla))))
        e.FECHA_INGRESO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INGRESO", aliasTabla))))
        e.USUARIO_EVALUA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_EVALUA", aliasTabla))))
        e.FECHA_EVALUA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_EVALUA", aliasTabla))))
        e.ESTADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla))))
    End Sub

    Public Sub AsignarACCION_FORMATIVA_PATI(ByVal dr As IDataReader, ByRef e As ACCION_FORMATIVA_PATI, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ACCION_FORMATIVA_PATI
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla))))
        e.ID_FUENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FUENTE", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.NO_CONVOCATORIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_CONVOCATORIA", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarSUB_AREA_FORMACION(ByVal dr As IDataReader, ByRef e As SUB_AREA_FORMACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SUB_AREA_FORMACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SUBAREA_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SUBAREA_FORMACION", aliasTabla))))
        e.ID_AREA_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_AREA_FORMACION", aliasTabla))))
        e.NOMBRE_SUBAREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_SUBAREA", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarDESEMBOLSO_MUNI_LIQUI_DET(ByVal dr As IDataReader, ByRef e As DESEMBOLSO_MUNI_LIQUI_DET, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DESEMBOLSO_MUNI_LIQUI_DET
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DESEMBOLSO_MUNI = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_DESEMBOLSO_MUNI", aliasTabla))))
        e.ID_DESEMBOLSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_DESEMBOLSO", aliasTabla))))
        e.ID_LIQUIDACION_DET = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_LIQUIDACION_DET", aliasTabla))))
        e.MONTO_DESEMBOLSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_DESEMBOLSO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarDESEMBOLSO(ByVal dr As IDataReader, ByRef e As DESEMBOLSO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DESEMBOLSO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DESEMBOLSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_DESEMBOLSO", aliasTabla))))
        e.ID_FUENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FUENTE", aliasTabla))))
        e.NO_CONVOCATORIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_CONVOCATORIA", aliasTabla))))
        e.NUM_DESEMBOLSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NUM_DESEMBOLSO", aliasTabla))))
        e.FECHA_DESEMBOLSO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_DESEMBOLSO", aliasTabla))))
        e.MONTO_AUTORIZADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_AUTORIZADO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarMUNICIPIO_CONVOCATORIA(ByVal dr As IDataReader, ByRef e As MUNICIPIO_CONVOCATORIA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New MUNICIPIO_CONVOCATORIA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.NO_CONVOCATORIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_CONVOCATORIA", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.APORTE_FISDL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}APORTE_FISDL", aliasTabla))))
        e.MONTO_LIQUIDADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_LIQUIDADO", aliasTabla))))
        e.ASESOR_MUNICIPAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ASESOR_MUNICIPAL", aliasTabla))))
        e.CODIGO_PROYECTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_PROYECTO", aliasTabla))))
        e.NOMBRE_PROYECTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PROYECTO", aliasTabla))))
        e.NUMERO_CHEQUE_REINTEGRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUMERO_CHEQUE_REINTEGRO", aliasTabla))))
        e.FECHA_CHEQUE_REINTEGRO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CHEQUE_REINTEGRO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.ID_FUENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FUENTE", aliasTabla))))
    End Sub

    Public Sub AsignarMUNICIPIO_LIQUIDACION_DET(ByVal dr As IDataReader, ByRef e As MUNICIPIO_LIQUIDACION_DET, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New MUNICIPIO_LIQUIDACION_DET
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_LIQUIDACION_DET = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_LIQUIDACION_DET", aliasTabla))))
        e.ID_LIQUIDACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_LIQUIDACION", aliasTabla))))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla))))
        e.COSTO_X_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}COSTO_X_PARTICIPANTE", aliasTabla))))
        e.TOTAL_PAGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL_PAGAR", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarMUNICIPIO_LIQUIDACION(ByVal dr As IDataReader, ByRef e As MUNICIPIO_LIQUIDACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New MUNICIPIO_LIQUIDACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_LIQUIDACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_LIQUIDACION", aliasTabla))))
        e.NO_CONVOCATORIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_CONVOCATORIA", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.NO_LIQUIDACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_LIQUIDACION", aliasTabla))))
        e.FECHA_ELABORACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ELABORACION", aliasTabla))))
        e.MONTO_LIQUIDADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_LIQUIDADO", aliasTabla)), -1))
        e.ASESOR_MUNICIPAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ASESOR_MUNICIPAL", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.ID_FUENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FUENTE", aliasTabla))))
    End Sub

    Public Sub AsignarFACTURA_DET(ByVal dr As IDataReader, ByRef e As FACTURA_DET, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New FACTURA_DET
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_FACTURA_DET = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FACTURA_DET", aliasTabla))))
        e.ID_FACTURA_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FACTURA_AF", aliasTabla)), -1))
        e.ID_INFORME_FINAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_INFORME_FINAL", aliasTabla)), -1))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub


    Public Sub AsignarFACTURA_AF(ByVal dr As IDataReader, ByRef e As FACTURA_AF, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New FACTURA_AF
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_FACTURA_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FACTURA_AF", aliasTabla))))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla))))
        e.NUMERO_DOCUMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUMERO_DOCUMENTO", aliasTabla))))
        e.TIPO_DOCUMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_DOCUMENTO", aliasTabla))))
        e.FECHA_DOCUMENTO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_DOCUMENTO", aliasTabla))))
        e.NUMERO_QUEDAN = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NUMERO_QUEDAN", aliasTabla)), -1))
        e.FECHA_QUEDAN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_QUEDAN", aliasTabla))))
        e.NUMERO_CHEQUE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUMERO_CHEQUE", aliasTabla))))
        e.FECHA_CHEQUE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CHEQUE", aliasTabla))))
        e.ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.OBSERVACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACION", aliasTabla))))
    End Sub

    Public Sub AsignarCONTRATO_PROVEEDOR_AF(ByVal dr As IDataReader, ByRef e As CONTRATO_PROVEEDOR_AF, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTRATO_PROVEEDOR_AF
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CONTRATO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO", aliasTabla))))
        e.NUM_CONTRATO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUM_CONTRATO", aliasTabla))))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla))))
        e.ID_EJERCICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ID_EJERCICIO", aliasTabla))))
        e.MONTO_ADJUDICADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_ADJUDICADO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.NUM_LICITACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUM_LICITACION", aliasTabla))))
        e.MONTO_DEVENGADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_DEVENGADO", aliasTabla))))
        e.ID_PROGRAMA_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROGRAMA_FORMACION", aliasTabla)), -1))
        e.PARTICIP_ADJUDICADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIP_ADJUDICADA", aliasTabla)), -1))
        e.FECHA_INICIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIO", aliasTabla))))
        e.FECHA_FIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN", aliasTabla))))
        e.ID_PROYECTO_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROYECTO_FORMACION", aliasTabla)), -1))
    End Sub

    Public Sub AsignarCENTRO_RESPONSABILIDAD(ByVal dr As IDataReader, ByRef e As CENTRO_RESPONSABILIDAD, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CENTRO_RESPONSABILIDAD
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CENTRO_RESPONSABILIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CENTRO_RESPONSABILIDAD", aliasTabla))))
        e.ID_CENTRO_RESPONSABILIDAD_PADR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CENTRO_RESPONSABILIDAD_PADR", aliasTabla))))
        e.CODIGO_CENTRO_RESPONSABILIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_CENTRO_RESPONSABILIDAD", aliasTabla))))
        e.NOMBRE_CENTRO_RESPONSABILIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CENTRO_RESPONSABILIDAD", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarCENTRO_RESPONSABILIDAD_UNIDAD(ByVal dr As IDataReader, ByRef e As CENTRO_RESPONSABILIDAD_UNIDAD, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CENTRO_RESPONSABILIDAD_UNIDAD
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CENTRO_RESPONSABILIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CENTRO_RESPONSABILIDAD", aliasTabla))))
        e.ID_UNIDAD_ORGANIZATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_UNIDAD_ORGANIZATIVA", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub


    Public Sub AsignarCONTRATO_SUB_AREA_FORMACION(ByVal dr As IDataReader, ByRef e As CONTRATO_SUB_AREA_FORMACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTRATO_SUB_AREA_FORMACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CONTRATO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO", aliasTabla))))
        e.ID_SUBAREA_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SUBAREA_FORMACION", aliasTabla))))
        e.MONTO_ADJUDICADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_ADJUDICADO", aliasTabla))))
        e.PARTICIP_ADJUDICADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIP_ADJUDICADA", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.MONTO_DEVENGADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_DEVENGADO", aliasTabla)), -1))
    End Sub

    Public Sub AsignarTERMINO_REFERENCIA_AF(ByVal dr As IDataReader, ByRef e As TERMINO_REFERENCIA_AF, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TERMINO_REFERENCIA_AF
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla))))
        e.RESOLUCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}RESOLUCION", aliasTabla))))
        e.TDR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TDR", aliasTabla))))
        e.MONTO_ADJUDICADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_ADJUDICADO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.CORRELATIVO_GRUPO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CORRELATIVO_GRUPO", aliasTabla)), -1))
        e.ID_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla)), -1))
    End Sub

    Public Sub AsignarASISTENCIA_AF_HORARIO_REPROG(ByVal dr As IDataReader, ByRef e As ASISTENCIA_AF_HORARIO_REPROG, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ASISTENCIA_AF_HORARIO_REPROG
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ASISTENCIA_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ASISTENCIA_AF", aliasTabla))))
        e.ID_ASISTENCIA_AF_HORARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ASISTENCIA_AF_HORARIO", aliasTabla))))
        e.HORA_INICIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}HORA_INICIO", aliasTabla))))
        e.HORA_FIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}HORA_FIN", aliasTabla))))
        e.CANTIDAD_MINUTOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD_MINUTOS", aliasTabla))))
    End Sub

    Public Sub AsignarASISTENCIA_AF_REPROG(ByVal dr As IDataReader, ByRef e As ASISTENCIA_AF_REPROG, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ASISTENCIA_AF_REPROG
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ASISTENCIA_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ASISTENCIA_AF", aliasTabla))))
        e.ID_ACCION_FORMATIVA_REPROG = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA_REPROG", aliasTabla)), -1))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.CANTIDAD_HORAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD_HORAS", aliasTabla))))
        e.INSTRUCTOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}INSTRUCTOR", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarTIPO_EMPLEO(ByVal dr As IDataReader, ByRef e As TIPO_EMPLEO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_EMPLEO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_EMPLEO", aliasTabla))))
        e.NOMBRE_TIPO_EMPLEO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TIPO_EMPLEO", aliasTabla))))
    End Sub

    Public Sub AsignarPARTICIPANTE_AF(ByVal dr As IDataReader, ByRef e As PARTICIPANTE_AF, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PARTICIPANTE_AF
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PARTICIPANTE", aliasTabla))))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla))))
        e.FECHA_INSCRIPCION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INSCRIPCION", aliasTabla))))
        e.NOTA_FINAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NOTA_FINAL", aliasTabla)), -1))
        e.PORC_ASISTENCIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_ASISTENCIA", aliasTabla)), -1))
        e.ENTREGA_DIPLOMA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ENTREGA_DIPLOMA", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.ES_CAPACITADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ES_CAPACITADO", aliasTabla))))
    End Sub

    Public Sub AsignarUSUARIO(ByVal dr As IDataReader, ByRef e As USUARIO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New USUARIO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.USUARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO", aliasTabla))))
        e.NOMBRE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE", aliasTabla))))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla)), -1))
        e.ID_SITIO_CAPACITACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SITIO_CAPACITACION", aliasTabla)), -1))
        e.ID_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PARTICIPANTE", aliasTabla)), -1))
        e.DEPARTAMENTO_ALCALDIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DEPARTAMENTO_ALCALDIA", aliasTabla))))
        e.MUNICIPIO_ALCALDIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MUNICIPIO_ALCALDIA", aliasTabla))))
    End Sub

    Public Sub AsignarUNIDAD_ORGANIZATIVA(ByVal dr As IDataReader, ByRef e As UNIDAD_ORGANIZATIVA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New UNIDAD_ORGANIZATIVA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_UNIDAD_ORGANIZATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_UNIDAD_ORGANIZATIVA", aliasTabla))))
        e.NOMBRE_UNIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_UNIDAD", aliasTabla))))
        e.CODIGO_UNIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_UNIDAD", aliasTabla))))
        e.ID_UNIDAD_PADRE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_UNIDAD_PADRE", aliasTabla)), -1))
        e.ESTADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla)), -1))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarTIPO_SOLICITUD(ByVal dr As IDataReader, ByRef e As TIPO_SOLICITUD, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_SOLICITUD
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_SOLICITUD", aliasTabla))))
        e.CODIGO_PROCESO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_PROCESO", aliasTabla))))
        e.TIPO_SOLICITUD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_SOLICITUD", aliasTabla))))
        e.TABLA_RELACIONAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TABLA_RELACIONAL", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarTIPO_PERSONA(ByVal dr As IDataReader, ByRef e As TIPO_PERSONA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIPO_PERSONA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_PERSONA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PERSONA", aliasTabla))))
        e.TIPO_PERSONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_PERSONA", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
    End Sub

    Public Sub AsignarSUPERVISION_AF_DET(ByVal dr As IDataReader, ByRef e As SUPERVISION_AF_DET, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SUPERVISION_AF_DET
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SUPERVISION_DET = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SUPERVISION_DET", aliasTabla))))
        e.ID_LISTA_SUPERVISION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_LISTA_SUPERVISION", aliasTabla)), -1))
        e.ID_SUPERVISION_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SUPERVISION_AF", aliasTabla)), -1))
        e.COMENTARIOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COMENTARIOS", aliasTabla))))
    End Sub

    Public Sub AsignarSUPERVISION_AF(ByVal dr As IDataReader, ByRef e As SUPERVISION_AF, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SUPERVISION_AF
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SUPERVISION_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SUPERVISION_AF", aliasTabla))))
        e.ID_MODALIDAD_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_MODALIDAD_FORMACION", aliasTabla))))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla)), -1))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.NOMBRE_AF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_AF", aliasTabla))))
        e.CENTRO_FORMACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CENTRO_FORMACION", aliasTabla))))
        e.OPCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OPCION", aliasTabla))))
        e.GRUPO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}GRUPO", aliasTabla))))
        e.HORARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}HORARIO", aliasTabla))))
        e.CODIGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO", aliasTabla))))
        e.COORDINADOR_CFP = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COORDINADOR_CFP", aliasTabla))))
        e.DIRECTOR_CFP = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECTOR_CFP", aliasTabla))))
        e.PARTICIPANTES_PRESENTES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIPANTES_PRESENTES", aliasTabla)), -1))
        e.PARTICIPANTES_AUSENTES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIPANTES_AUSENTES", aliasTabla)), -1))
        e.PARTICIPANTES_INSCRITOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIPANTES_INSCRITOS", aliasTabla)), -1))
        e.PARTICIPANTES_DESERTADOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIPANTES_DESERTADOS", aliasTabla)), -1))
        e.PARTICIPANTES_SUPLENTES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIPANTES_SUPLENTES", aliasTabla)), -1))
        e.OBJETIVO_VISITA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBJETIVO_VISITA", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
        e.DURACION_VISITA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DURACION_VISITA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarSOLICITUD_INSCRIPCION_AF(ByVal dr As IDataReader, ByRef e As SOLICITUD_INSCRIPCION_AF, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLICITUD_INSCRIPCION_AF
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.FECHA_PRESENTACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_PRESENTACION", aliasTabla))))
        e.ID_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PARTICIPANTE", aliasTabla))))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla))))
        e.ID_ESTADO_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_SOLICITUD", aliasTabla))))
        e.NOMBRES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES", aliasTabla))))
        e.APELLIDOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.TIPO_DOCTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIPO_DOCTO", aliasTabla)), -1))
        e.NUM_DOCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUM_DOCTO", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.ISSS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ISSS", aliasTabla))))
        e.ID_TIPO_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_SOLICITUD", aliasTabla))))
        e.ID_PAIS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PAIS", aliasTabla)), -1))
        e.DEPARTAMENTO_NAC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DEPARTAMENTO_NAC", aliasTabla))))
        e.MUNICIPIO_NAC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MUNICIPIO_NAC", aliasTabla))))
        e.FECHA_NACIMIENTO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_NACIMIENTO", aliasTabla))))
        e.GENERO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}GENERO", aliasTabla))))
        e.EDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EDAD", aliasTabla)), -1))
        e.MIEMBROS_GRUPO_FAMILIAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MIEMBROS_GRUPO_FAMILIAR", aliasTabla)), -1))
        e.ID_ESTADO_CIVIL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_CIVIL", aliasTabla)), -1))
        e.ES_JEFE_HOGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ES_JEFE_HOGAR", aliasTabla)), -1))
        e.TIENE_HIJOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIENE_HIJOS", aliasTabla)), -1))
        e.NO_DE_HIJOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_DE_HIJOS", aliasTabla)), -1))
        e.SE_DEDICA_ALGUNA_PROFESION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SE_DEDICA_ALGUNA_PROFESION", aliasTabla)), -1))
        e.PROFESION_OFICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PROFESION_OFICIO", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.MOVIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOVIL", aliasTabla))))
        e.EMAIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL", aliasTabla))))
        e.CON_DISCAPACIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CON_DISCAPACIDAD", aliasTabla)), -1))
        e.DISC_OTRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DISC_OTRA", aliasTabla))))
        e.ID_LEE_ESCRIBE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_LEE_ESCRIBE", aliasTabla)), -1))
        e.ID_NIVEL_ACADEMICO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_NIVEL_ACADEMICO", aliasTabla)), -1))
        e.OTRA_EDUCACION_FORMAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OTRA_EDUCACION_FORMAL", aliasTabla))))
        e.TITULO_CERTIFICADO_OBTENIDO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TITULO_CERTIFICADO_OBTENIDO", aliasTabla))))
        e.ESTUDIA_ACTUALMENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ESTUDIA_ACTUALMENTE", aliasTabla)), -1))
        e.ID_TIEMPO_DEJO_ESTUDIAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIEMPO_DEJO_ESTUDIAR", aliasTabla)), -1))
        e.RECIBIO_CURSO_ANTERIOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}RECIBIO_CURSO_ANTERIOR", aliasTabla))))
        e.BENEF_PROM_EMP_ACT = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_PROM_EMP_ACT", aliasTabla)), -1))
        e.BENEF_OBT_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_OBT_EMPLEO", aliasTabla)), -1))
        e.BENEF_OBT_ING_EXTRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_OBT_ING_EXTRA", aliasTabla)), -1))
        e.BENEF_CAMB_EMP_X_CURSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_CAMB_EMP_X_CURSO", aliasTabla)), -1))
        e.BENEF_TRAB_CTA_PROPIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_TRAB_CTA_PROPIA", aliasTabla)), -1))
        e.BENEF_OTRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}BENEF_OTRO", aliasTabla))))
        e.RAZON_NO_BENEFICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}RAZON_NO_BENEFICIO", aliasTabla))))
        e.OCUACT_TRABAJA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_TRABAJA", aliasTabla)), -1))
        e.OCUACT_ESTUDIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_ESTUDIA", aliasTabla)), -1))
        e.OCUACT_DESOCUPADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_DESOCUPADO", aliasTabla)), -1))
        e.OCUACT_OFICIO_HOGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_OFICIO_HOGAR", aliasTabla)), -1))
        e.OCUACT_BUSCA_TRABAJO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_BUSCA_TRABAJO", aliasTabla)), -1))
        e.OCUACT_OTRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OCUACT_OTRA", aliasTabla))))
        e.ID_TIPO_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_EMPLEO", aliasTabla)), -1))
        e.TIPO_EMPLEO_OTRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_EMPLEO_OTRO", aliasTabla))))
        e.SECTOR_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SECTOR_EMPLEO", aliasTabla)), -1))
        e.TRABAJO_ANTERIOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TRABAJO_ANTERIOR", aliasTabla))))
        e.RECIBE_INGRESOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RECIBE_INGRESOS", aliasTabla)), -1))
        e.MANERA_OBT_ING_TRABAJO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MANERA_OBT_ING_TRABAJO", aliasTabla)), -1))
        e.MANERA_OBT_ING_AYUDA_FAM = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MANERA_OBT_ING_AYUDA_FAM", aliasTabla)), -1))
        e.MANERA_OBT_ING_REMESA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MANERA_OBT_ING_REMESA", aliasTabla)), -1))
        e.MANERA_OBT_ING_PENSION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MANERA_OBT_ING_PENSION", aliasTabla)), -1))
        e.MANERA_OBT_ING_OTRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MANERA_OBT_ING_OTRO", aliasTabla))))
        e.EXPFOR_PROMOCION_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_PROMOCION_EMPLEO", aliasTabla)), -1))
        e.EXPFOR_CAMBIAR_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_CAMBIAR_EMPLEO", aliasTabla)), -1))
        e.EXPFOR_OBTENER_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_OBTENER_EMPLEO", aliasTabla)), -1))
        e.EXPFOR_TRABAJAR_CTA_PROPIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_TRABAJAR_CTA_PROPIA", aliasTabla)), -1))
        e.EXPFOR_INGRESOS_EXTRAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_INGRESOS_EXTRAS", aliasTabla)), -1))
        e.EXPFOR_NINGUNO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_NINGUNO", aliasTabla)), -1))
        e.EXPFOR_OTRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_OTRO", aliasTabla))))
        e.CURSO_REL_TRAB_ACTUAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CURSO_REL_TRAB_ACTUAL", aliasTabla)), -1))
        e.CURSO_REL_TRAB_NUEVO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CURSO_REL_TRAB_NUEVO", aliasTabla)), -1))
        e.NOMBRE_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_REFERENCIA", aliasTabla))))
        e.ID_REFERENCIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_REFERENCIA", aliasTabla)), -1))
        e.DIRECCION_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION_REFERENCIA", aliasTabla))))
        e.DEPARTAMENTO_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DEPARTAMENTO_REFERENCIA", aliasTabla))))
        e.MUNICIPIO_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MUNICIPIO_REFERENCIA", aliasTabla))))
        e.TELEFONO_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO_REFERENCIA", aliasTabla))))
        e.MOVIL_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOVIL_REFERENCIA", aliasTabla))))
        e.EMAIL_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL_REFERENCIA", aliasTabla))))
        e.SUGERENCIAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SUGERENCIAS", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarSOLIC_INSCRIPCION_AF_HIST(ByVal dr As IDataReader, ByRef e As SOLIC_INSCRIPCION_AF_HIST, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_INSCRIPCION_AF_HIST
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLICITUD_HIST = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD_HIST", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.FECHA_PRESENTACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_PRESENTACION", aliasTabla))))
        e.ID_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PARTICIPANTE", aliasTabla))))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla))))
        e.ID_ESTADO_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_SOLICITUD", aliasTabla))))
        e.NOMBRES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES", aliasTabla))))
        e.APELLIDOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.TIPO_DOCTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIPO_DOCTO", aliasTabla)), -1))
        e.NUM_DOCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUM_DOCTO", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.ISSS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ISSS", aliasTabla))))
        e.ID_TIPO_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_SOLICITUD", aliasTabla))))
        e.ID_PAIS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PAIS", aliasTabla)), -1))
        e.DEPARTAMENTO_NAC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DEPARTAMENTO_NAC", aliasTabla))))
        e.MUNICIPIO_NAC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MUNICIPIO_NAC", aliasTabla))))
        e.FECHA_NACIMIENTO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_NACIMIENTO", aliasTabla))))
        e.GENERO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}GENERO", aliasTabla))))
        e.EDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EDAD", aliasTabla)), -1))
        e.MIEMBROS_GRUPO_FAMILIAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MIEMBROS_GRUPO_FAMILIAR", aliasTabla)), -1))
        e.ID_ESTADO_CIVIL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_CIVIL", aliasTabla)), -1))
        e.ES_JEFE_HOGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ES_JEFE_HOGAR", aliasTabla)), -1))
        e.TIENE_HIJOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIENE_HIJOS", aliasTabla)), -1))
        e.NO_DE_HIJOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_DE_HIJOS", aliasTabla)), -1))
        e.SE_DEDICA_ALGUNA_PROFESION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SE_DEDICA_ALGUNA_PROFESION", aliasTabla)), -1))
        e.PROFESION_OFICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PROFESION_OFICIO", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.MOVIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOVIL", aliasTabla))))
        e.EMAIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL", aliasTabla))))
        e.CON_DISCAPACIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CON_DISCAPACIDAD", aliasTabla)), -1))
        e.DISC_OTRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DISC_OTRA", aliasTabla))))
        e.ID_LEE_ESCRIBE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_LEE_ESCRIBE", aliasTabla)), -1))
        e.ID_NIVEL_ACADEMICO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_NIVEL_ACADEMICO", aliasTabla)), -1))
        e.OTRA_EDUCACION_FORMAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OTRA_EDUCACION_FORMAL", aliasTabla))))
        e.TITULO_CERTIFICADO_OBTENIDO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TITULO_CERTIFICADO_OBTENIDO", aliasTabla))))
        e.ESTUDIA_ACTUALMENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ESTUDIA_ACTUALMENTE", aliasTabla)), -1))
        e.ID_TIEMPO_DEJO_ESTUDIAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIEMPO_DEJO_ESTUDIAR", aliasTabla)), -1))
        e.RECIBIO_CURSO_ANTERIOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}RECIBIO_CURSO_ANTERIOR", aliasTabla))))
        e.BENEF_PROM_EMP_ACT = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_PROM_EMP_ACT", aliasTabla)), -1))
        e.BENEF_OBT_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_OBT_EMPLEO", aliasTabla)), -1))
        e.BENEF_OBT_ING_EXTRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_OBT_ING_EXTRA", aliasTabla)), -1))
        e.BENEF_CAMB_EMP_X_CURSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_CAMB_EMP_X_CURSO", aliasTabla)), -1))
        e.BENEF_TRAB_CTA_PROPIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_TRAB_CTA_PROPIA", aliasTabla)), -1))
        e.BENEF_OTRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}BENEF_OTRO", aliasTabla))))
        e.RAZON_NO_BENEFICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}RAZON_NO_BENEFICIO", aliasTabla))))
        e.OCUACT_TRABAJA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_TRABAJA", aliasTabla)), -1))
        e.OCUACT_ESTUDIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_ESTUDIA", aliasTabla)), -1))
        e.OCUACT_DESOCUPADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_DESOCUPADO", aliasTabla)), -1))
        e.OCUACT_OFICIO_HOGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_OFICIO_HOGAR", aliasTabla)), -1))
        e.OCUACT_BUSCA_TRABAJO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_BUSCA_TRABAJO", aliasTabla)), -1))
        e.OCUACT_OTRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OCUACT_OTRA", aliasTabla))))
        e.ID_TIPO_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_EMPLEO", aliasTabla)), -1))
        e.SECTOR_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SECTOR_EMPLEO", aliasTabla)), -1))
        e.TRABAJO_ANTERIOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TRABAJO_ANTERIOR", aliasTabla))))
        e.RECIBE_INGRESOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RECIBE_INGRESOS", aliasTabla)), -1))
        e.MANERA_OBT_ING_TRABAJO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MANERA_OBT_ING_TRABAJO", aliasTabla)), -1))
        e.MANERA_OBT_ING_AYUDA_FAM = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MANERA_OBT_ING_AYUDA_FAM", aliasTabla)), -1))
        e.MANERA_OBT_ING_REMESA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MANERA_OBT_ING_REMESA", aliasTabla)), -1))
        e.MANERA_OBT_ING_PENSION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MANERA_OBT_ING_PENSION", aliasTabla)), -1))
        e.MANERA_OBT_ING_OTRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MANERA_OBT_ING_OTRO", aliasTabla))))
        e.EXPFOR_PROMOCION_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_PROMOCION_EMPLEO", aliasTabla)), -1))
        e.EXPFOR_CAMBIAR_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_CAMBIAR_EMPLEO", aliasTabla)), -1))
        e.EXPFOR_OBTENER_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_OBTENER_EMPLEO", aliasTabla)), -1))
        e.EXPFOR_TRABAJAR_CTA_PROPIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_TRABAJAR_CTA_PROPIA", aliasTabla)), -1))
        e.EXPFOR_INGRESOS_EXTRAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_INGRESOS_EXTRAS", aliasTabla)), -1))
        e.EXPFOR_NINGUNO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_NINGUNO", aliasTabla)), -1))
        e.EXPFOR_OTRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_OTRO", aliasTabla))))
        e.CURSO_REL_TRAB_ACTUAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CURSO_REL_TRAB_ACTUAL", aliasTabla)), -1))
        e.CURSO_REL_TRAB_NUEVO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CURSO_REL_TRAB_NUEVO", aliasTabla)), -1))
        e.NOMBRE_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_REFERENCIA", aliasTabla))))
        e.ID_REFERENCIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_REFERENCIA", aliasTabla)), -1))
        e.DIRECCION_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION_REFERENCIA", aliasTabla))))
        e.DEPARTAMENTO_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DEPARTAMENTO_REFERENCIA", aliasTabla))))
        e.MUNICIPIO_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MUNICIPIO_REFERENCIA", aliasTabla))))
        e.TELEFONO_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO_REFERENCIA", aliasTabla))))
        e.MOVIL_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOVIL_REFERENCIA", aliasTabla))))
        e.EMAIL_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL_REFERENCIA", aliasTabla))))
        e.SUGERENCIAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SUGERENCIAS", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    'Public Sub AsignarSOLICITUD_INSCRIPCION_AF_HIST(ByVal dr As IDataReader, ByRef e As SOLICITUD_INSCRIPCION_AF_HIST, Optional ByVal aliasTabla As String = "")
    '    If IsNothing(e) Then
    '        e = New SOLICITUD_INSCRIPCION_AF_HIST
    '    End If
    '    If aliasTabla <> "" Then
    '        aliasTabla = String.Format("{0}.", aliasTabla)
    '    End If
    '    e.ID_SOLICITUD_HIST = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD_HIST", aliasTabla))))
    '    e.ID_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
    '    e.FECHA_PRESENTACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_PRESENTACION", aliasTabla))))
    '    e.ID_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PARTICIPANTE", aliasTabla)), -1))
    '    e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla)), -1))
    '    e.ID_ESTADO_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_SOLICITUD", aliasTabla)), -1))
    '    e.NUMERO_DOCUMENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NUMERO_DOCUMENTO", aliasTabla)), -1))
    '    e.ID_TIPO_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_SOLICITUD", aliasTabla)), -1))
    '    e.NIT_EMPRESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT_EMPRESA", aliasTabla))))
    '    e.NOMBRE_EMPRESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_EMPRESA", aliasTabla))))
    '    e.CARGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CARGO", aliasTabla))))
    '    e.NUMERO_PATRONAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUMERO_PATRONAL", aliasTabla))))
    '    e.NOMBRES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES", aliasTabla))))
    '    e.APELLIDOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS", aliasTabla))))
    '    e.LUGAR_NACIMIENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}LUGAR_NACIMIENTO", aliasTabla))))
    '    e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
    '    e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
    '    e.CODIGO_REGION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_REGION", aliasTabla))))
    '    e.ZONA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ZONA", aliasTabla))))
    '    e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
    '    e.MOVIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOVIL", aliasTabla))))
    '    e.FAX = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}FAX", aliasTabla))))
    '    e.EMAIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL", aliasTabla))))
    '    e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
    '    e.ISSS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ISSS", aliasTabla))))
    '    e.CIUO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CIUO", aliasTabla))))
    '    e.EDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EDAD", aliasTabla)), -1))
    '    e.DEPARTAMENTO_NAC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DEPARTAMENTO_NAC", aliasTabla))))
    '    e.MUNICIPIO_NAC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MUNICIPIO_NAC", aliasTabla))))
    '    e.FECHA_NACIMIENTO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_NACIMIENTO", aliasTabla))))
    '    e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
    '    e.GENERO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}GENERO", aliasTabla))))
    '    e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
    '    e.PROFESION_OFICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PROFESION_OFICIO", aliasTabla))))
    '    e.ESTADO_CIVIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO_CIVIL", aliasTabla))))
    '    e.NOMBRE_FAMILIAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_FAMILIAR", aliasTabla))))
    '    e.PARENTESCO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PARENTESCO", aliasTabla))))
    '    e.DIRECCION_FAMILIAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION_FAMILIAR", aliasTabla))))
    '    e.TELEFONO_FAMILIAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO_FAMILIAR", aliasTabla))))
    '    e.OCUACT_TRABAJA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_TRABAJA", aliasTabla)), -1))
    '    e.OCUACT_ESTUDIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_ESTUDIA", aliasTabla)), -1))
    '    e.OCUACT_DESOCUPADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_DESOCUPADO", aliasTabla)), -1))
    '    e.OCUACT_OFICIO_HOGAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OCUACT_OFICIO_HOGAR", aliasTabla)), -1))
    '    e.TIPTRA_EMPLEADO_EMPRESA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIPTRA_EMPLEADO_EMPRESA", aliasTabla)), -1))
    '    e.TIPTRA_EMPRESA_PROPIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIPTRA_EMPRESA_PROPIA", aliasTabla)), -1))
    '    e.TIPTRA_EVENTUAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIPTRA_EVENTUAL", aliasTabla)), -1))
    '    e.TIPTRA_MEDIO_TIEMPO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIPTRA_MEDIO_TIEMPO", aliasTabla)), -1))
    '    e.TIPTRA_INDEPENDIENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIPTRA_INDEPENDIENTE", aliasTabla)), -1))
    '    e.RTC_OCUPACION_EMPRESA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RTC_OCUPACION_EMPRESA", aliasTabla)), -1))
    '    e.RTC_PROPIA_EMPRESA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RTC_PROPIA_EMPRESA", aliasTabla)), -1))
    '    e.RTC_TRABAJO_EVENTUAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RTC_TRABAJO_EVENTUAL", aliasTabla)), -1))
    '    e.RTC_TRABAJO_MEDIO_TIEMPO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RTC_TRABAJO_MEDIO_TIEMPO", aliasTabla)), -1))
    '    e.RTC_INDEPENDIENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RTC_INDEPENDIENTE", aliasTabla)), -1))
    '    e.RTC_NO_OCUPACION_EMPRESA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RTC_NO_OCUPACION_EMPRESA", aliasTabla)), -1))
    '    e.RTC_NO_PROPIA_EMPRESA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RTC_NO_PROPIA_EMPRESA", aliasTabla)), -1))
    '    e.RTC_NO_TRABAJO_EVENTUAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RTC_NO_TRABAJO_EVENTUAL", aliasTabla)), -1))
    '    e.RTC_NO_TRABAJO_MEDIO_TIEMPO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RTC_NO_TRABAJO_MEDIO_TIEMPO", aliasTabla)), -1))
    '    e.RTC_NO_INDEPENDIENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}RTC_NO_INDEPENDIENTE", aliasTabla)), -1))
    '    e.NIVEL_ACADEMICO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIVEL_ACADEMICO", aliasTabla))))
    '    e.TITULO_CERTIFICADO_OBTENIDO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TITULO_CERTIFICADO_OBTENIDO", aliasTabla))))
    '    e.TIEMPO_DEJO_ESTUDIAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIEMPO_DEJO_ESTUDIAR", aliasTabla))))
    '    e.RECIBIO_CURSO_ANTERIOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}RECIBIO_CURSO_ANTERIOR", aliasTabla))))
    '    e.OBTUVO_BENEFICIOS_CURSO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBTUVO_BENEFICIOS_CURSO", aliasTabla))))
    '    e.BENEF_PROM_EMP_ACT = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_PROM_EMP_ACT", aliasTabla)), -1))
    '    e.BENEF_OBT_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_OBT_EMPLEO", aliasTabla)), -1))
    '    e.BENEF_OBT_ING_EXTRA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_OBT_ING_EXTRA", aliasTabla)), -1))
    '    e.BENEF_CAMB_EMP_X_CURSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_CAMB_EMP_X_CURSO", aliasTabla)), -1))
    '    e.BENEF_TRAB_CTA_PROPIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEF_TRAB_CTA_PROPIA", aliasTabla)), -1))
    '    e.BENEF_OTRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}BENEF_OTRO", aliasTabla))))
    '    e.RAZON_NO_BENEFICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}RAZON_NO_BENEFICIO", aliasTabla))))
    '    e.TRABAJA_ACTUALMENTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TRABAJA_ACTUALMENTE", aliasTabla))))
    '    e.TRABAJO_ANTERIOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TRABAJO_ANTERIOR", aliasTabla))))
    '    e.EXPFOR_PROMOCION_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_PROMOCION_EMPLEO", aliasTabla)), -1))
    '    e.EXPFOR_CAMBIAR_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_CAMBIAR_EMPLEO", aliasTabla)), -1))
    '    e.EXPFOR_OBTENER_EMPLEO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_OBTENER_EMPLEO", aliasTabla)), -1))
    '    e.EXPFOR_TRABAJAR_CTA_PROPIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_TRABAJAR_CTA_PROPIA", aliasTabla)), -1))
    '    e.EXPFOR_INGRESOS_EXTRAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_INGRESOS_EXTRAS", aliasTabla)), -1))
    '    e.EXPFOR_OTRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EXPFOR_OTRO", aliasTabla))))
    '    e.INGRESO_MENSUAL_INDIVIDUAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}INGRESO_MENSUAL_INDIVIDUAL", aliasTabla))))
    '    e.INGRESO_MENSUAL_FAMILIAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}INGRESO_MENSUAL_FAMILIAR", aliasTabla))))
    '    e.MIEMBROS_GRUPO_FAMILIAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MIEMBROS_GRUPO_FAMILIAR", aliasTabla)), -1))
    '    e.SUGERENCIAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SUGERENCIAS", aliasTabla))))
    '    e.LUGAR_PRESENTACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}LUGAR_PRESENTACION", aliasTabla))))
    '    e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla)), -1))
    '    e.USERID_HIST = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID_HIST", aliasTabla))))
    '    e.LASTUPDATE_HIST = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE_HIST", aliasTabla))))
    '    e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
    '    e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    'End Sub


    Public Sub AsignarSOLIC_EMPLEO_ANTERIOR(ByVal dr As IDataReader, ByRef e As SOLIC_EMPLEO_ANTERIOR, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_EMPLEO_ANTERIOR
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_EMPLEO_ANT = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_EMPLEO_ANT", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.TIEMPO_NO_TRABAJA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIEMPO_NO_TRABAJA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarSOLIC_EMPLEO_ACTUAL(ByVal dr As IDataReader, ByRef e As SOLIC_EMPLEO_ACTUAL, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_EMPLEO_ACTUAL
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_EMPLEO_ACTUAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_EMPLEO_ACTUAL", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.NOMBRE_EMPRESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_EMPRESA", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.TELEFONOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONOS", aliasTabla))))
        e.TIEMPO_TRABAJO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIEMPO_TRABAJO", aliasTabla)), -1))
        e.AREA_TRABAJO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}AREA_TRABAJO", aliasTabla)), -1))
        e.AREA_OTRO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}AREA_OTRO", aliasTabla))))
    End Sub

    Public Sub AsignarSOLIC_CURSOS_RECIBIDOS(ByVal dr As IDataReader, ByRef e As SOLIC_CURSOS_RECIBIDOS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLIC_CURSOS_RECIBIDOS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CURSO_RECIBIDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CURSO_RECIBIDO", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla)), -1))
        e.APOYO_INSAFORP = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}APOYO_INSAFORP", aliasTabla)), -1))
        e.ANIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ANIO", aliasTabla)), -1))
        e.NOMBRE_CURSO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CURSO", aliasTabla))))
        e.BENEFICIO_CURSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}BENEFICIO_CURSO", aliasTabla)), -1))
    End Sub

    Public Sub AsignarSOLICITUD_CAPACITACION(ByVal dr As IDataReader, ByRef e As SOLICITUD_CAPACITACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SOLICITUD_CAPACITACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ID_REFERENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_REFERENTE", aliasTabla))))
        e.ID_CENTRO_RESPONSABILIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CENTRO_RESPONSABILIDAD", aliasTabla))))
        e.ID_UNIDAD_ORGANIZATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_UNIDAD_ORGANIZATIVA", aliasTabla))))
        e.ID_PROGRAMA_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROGRAMA_FORMACION", aliasTabla))))
        e.ID_PROYECTO_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROYECTO_FORMACION", aliasTabla))))
        e.FECHA_SOLICITUD = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_SOLICITUD", aliasTabla))))
        e.OBJETIVO_CAPACITACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBJETIVO_CAPACITACION", aliasTabla))))
        e.HORARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}HORARIO", aliasTabla))))
        e.TELEF1 = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEF1", aliasTabla))))
        e.TELEF2 = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEF2", aliasTabla))))
        e.TELEF3 = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEF3", aliasTabla))))
        e.TELEF_MOVIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEF_MOVIL", aliasTabla))))
        e.FAX = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}FAX", aliasTabla))))
        e.NOMBRES_CONTACTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES_CONTACTO", aliasTabla))))
        e.APELLIDOS_CONTACTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS_CONTACTO", aliasTabla))))
        e.EMAIL_CONTACTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL_CONTACTO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.PORC_PAGO_INFORME1 = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_PAGO_INFORME1", aliasTabla)), -1))
        e.IsDirty = False
    End Sub

    Public Sub AsignarPROYECTO_FORMACION(ByVal dr As IDataReader, ByRef e As PROYECTO_FORMACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PROYECTO_FORMACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PROYECTO_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROYECTO_FORMACION", aliasTabla))))
        e.NOMBRE_PROYECTO_FORMACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PROYECTO_FORMACION", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.IsDirty = False
    End Sub

    Public Sub AsignarPROGRAMA_FORMACION_TIPOPAGO(ByVal dr As IDataReader, ByRef e As PROGRAMA_FORMACION_TIPOPAGO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PROGRAMA_FORMACION_TIPOPAGO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIPO_PAGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PAGO", aliasTabla))))
        e.NOMBRE_TIPO_PAGO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TIPO_PAGO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarREFERENTE(ByVal dr As IDataReader, ByRef e As REFERENTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New REFERENTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_REFERENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_REFERENTE", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.NOMBRE_REFERENTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_REFERENTE", aliasTabla))))
        e.DIRECCION_REFERENTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION_REFERENTE", aliasTabla))))
        e.TELEF1 = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEF1", aliasTabla))))
        e.TELEF2 = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEF2", aliasTabla))))
        e.TELEF3 = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEF3", aliasTabla))))
        e.TELEF_MOVIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEF_MOVIL", aliasTabla))))
        e.FAX = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}FAX", aliasTabla))))
        e.NOMBRE_CONTACTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CONTACTO", aliasTabla))))
        e.APELLIDOS_CONTACTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS_CONTACTO", aliasTabla))))
        e.EMAIL_CONTACTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL_CONTACTO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.IsDirty = False
    End Sub

    Public Sub AsignarSITIO_CAPACITACION(ByVal dr As IDataReader, ByRef e As SITIO_CAPACITACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New SITIO_CAPACITACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_SITIO_CAPACITACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SITIO_CAPACITACION", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla)), -1))
        e.NOMBRE_SITIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_SITIO", aliasTabla))))
        e.FORMATO_CODIGO_CURSO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}FORMATO_CODIGO_CURSO", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.FAX = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}FAX", aliasTabla))))
        e.EMAIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL", aliasTabla))))
        e.NUMERO_AULAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NUMERO_AULAS", aliasTabla)), -1))
        e.FECHA_REGISTRO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_REGISTRO", aliasTabla))))
        e.ENCARGADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ENCARGADO", aliasTabla))))
        e.TELEFONO_ENCARGADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO_ENCARGADO", aliasTabla))))
        e.EMAIL_ENCARGADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL_ENCARGADO", aliasTabla))))
        e.CARGO_ENCARGADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CARGO_ENCARGADO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.LATITUD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}LATITUD", aliasTabla)), -1))
        e.LONGITUD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}LONGITUD", aliasTabla)), -1))
    End Sub

    Public Sub AsignarREGION(ByVal dr As IDataReader, ByRef e As REGION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New REGION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODIGO_REGION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_REGION", aliasTabla))))
        e.NOMBRE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarPROVEEDOR_AF(ByVal dr As IDataReader, ByRef e As PROVEEDOR_AF, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PROVEEDOR_AF
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.ID_TIPO_PERSONA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PERSONA", aliasTabla)), -1))
        e.NOMBRE_PROVEEDOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PROVEEDOR", aliasTabla))))
        e.RAZON_SOCIAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}RAZON_SOCIAL", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.NRC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NRC", aliasTabla))))
        e.ISSS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ISSS", aliasTabla))))
        e.FECHA_INGRESO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INGRESO", aliasTabla))))
        e.FECHA_ACREDITACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACREDITACION", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.EMAIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL", aliasTabla))))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.FAX = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}FAX", aliasTabla))))
        e.URL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}URL", aliasTabla))))
        e.CONTACTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONTACTO", aliasTabla))))
        e.TELEFONO_CONTACTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO_CONTACTO", aliasTabla))))
        e.EMAIL_CONTACTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL_CONTACTO", aliasTabla))))
        e.CARGO_CONTACTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CARGO_CONTACTO", aliasTabla))))
        e.ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
    End Sub


    Public Sub AsignarPROGRAMA_FORMACION(ByVal dr As IDataReader, ByRef e As PROGRAMA_FORMACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PROGRAMA_FORMACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PROGRAMA_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROGRAMA_FORMACION", aliasTabla))))
        e.NOMBRE_PROGRAMA_FORMACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PROGRAMA_FORMACION", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.PORC_ASISTENCIA_MINIMA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_ASISTENCIA_MINIMA", aliasTabla)), -1))
        e.NOTA_MINIMA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NOTA_MINIMA", aliasTabla)), -1))
        e.ID_TIPO_PAGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PAGO", aliasTabla)), -1))
        e.MONTO_APOYO_PARTI = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_APOYO_PARTI", aliasTabla)), -1))
    End Sub

    Public Sub AsignarPROCESO(ByVal dr As IDataReader, ByRef e As PROCESO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PROCESO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODIGO_PROCESO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_PROCESO", aliasTabla))))
        e.NOMBRE_PROCESO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PROCESO", aliasTabla))))
        e.DURACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DURACION", aliasTabla)), -1))
        e.UNIDAD_DE_TIEMPO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}UNIDAD_DE_TIEMPO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarPARTICIPANTE(ByVal dr As IDataReader, ByRef e As PARTICIPANTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PARTICIPANTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PARTICIPANTE", aliasTabla))))
        e.NOMBRES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRES", aliasTabla))))
        e.APELLIDOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}APELLIDOS", aliasTabla))))
        e.GENERO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}GENERO", aliasTabla))))
        e.ID_PAIS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PAIS", aliasTabla)), -1))
        e.FECHA_NACIMIENTO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_NACIMIENTO", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.ISSS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ISSS", aliasTabla))))
        e.TIPO_DOCTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIPO_DOCTO", aliasTabla)), -1))
        e.NUM_DOCTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUM_DOCTO", aliasTabla))))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.MOVIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOVIL", aliasTabla))))
        e.EMAIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL", aliasTabla))))
        e.ID_ESTADO_CIVIL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_CIVIL", aliasTabla)), -1))
        e.PROFESION_OFICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PROFESION_OFICIO", aliasTabla))))
        e.OCUPACION_ACTUAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OCUPACION_ACTUAL", aliasTabla))))
        e.TITULO_CERTIFICADO_OBTENIDO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TITULO_CERTIFICADO_OBTENIDO", aliasTabla))))
        e.DEPARTAMENTO_NAC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DEPARTAMENTO_NAC", aliasTabla))))
        e.MUNICIPIO_NAC = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MUNICIPIO_NAC", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.ID_NIVEL_ACADEMICO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_NIVEL_ACADEMICO", aliasTabla)), -1))
        e.OTRA_EDUCACION_FORMAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OTRA_EDUCACION_FORMAL", aliasTabla))))
        e.CON_DISCAPACIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CON_DISCAPACIDAD", aliasTabla)), -1))
        e.DISC_OTRA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DISC_OTRA", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.IsDirty = False
    End Sub

    Public Sub AsignarOPCION_MENU(ByVal dr As IDataReader, ByRef e As OPCION_MENU, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New OPCION_MENU
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_OPCION_MENU = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_OPCION_MENU", aliasTabla))))
        e.OPCION_MENU = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OPCION_MENU", aliasTabla))))
        e.OPCION_SISTEMA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OPCION_SISTEMA", aliasTabla))))
        e.URL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}URL", aliasTabla))))
        e.PAGINA_HTML = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PAGINA_HTML", aliasTabla))))
        e.OBJETO_USUARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBJETO_USUARIO", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
    End Sub

    Public Sub AsignarOPCION_GRUPO(ByVal dr As IDataReader, ByRef e As OPCION_GRUPO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New OPCION_GRUPO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_OPCION_GRUPO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_OPCION_GRUPO", aliasTabla))))
        e.ID_OPCION_MENU = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_OPCION_MENU", aliasTabla)), -1))
        e.ID_GRUPO_USUARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_GRUPO_USUARIO", aliasTabla)), -1))
        e.FECHA_INGRESO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INGRESO", aliasTabla))))
        e.ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    'Public Sub AsignarOFERTA_FORMATIVA_SITIO(ByVal dr As IDataReader, ByRef e As OFERTA_FORMATIVA_SITIO, Optional ByVal aliasTabla As String = "")
    '    If IsNothing(e) Then
    '        e = New OFERTA_FORMATIVA_SITIO
    '    End If
    '    If aliasTabla <> "" Then
    '        aliasTabla = String.Format("{0}.", aliasTabla)
    '    End If
    '    e.ID_OFERTA_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_OFERTA_FORMATIVA", aliasTabla))))
    '    e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla))))
    '    e.ID_SITIO_CAPACITACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SITIO_CAPACITACION", aliasTabla))))
    '    e.ID_EJERCICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ID_EJERCICIO", aliasTabla))))
    '    e.DURACION_HORAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DURACION_HORAS", aliasTabla)), -1))
    '    e.COSTO_X_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}COSTO_X_PARTICIPANTE", aliasTabla)), -1))
    '    e.USER_ID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USER_ID", aliasTabla))))
    '    e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    'End Sub

    'Public Sub AsignarOFERTA_FORMATIVA_PADRE(ByVal dr As IDataReader, ByRef e As OFERTA_FORMATIVA_PADRE, Optional ByVal aliasTabla As String = "")
    '    If IsNothing(e) Then
    '        e = New OFERTA_FORMATIVA_PADRE
    '    End If
    '    If aliasTabla <> "" Then
    '        aliasTabla = String.Format("{0}.", aliasTabla)
    '    End If
    '    e.ID_OFERTA_FORMATIVA_P = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_OFERTA_FORMATIVA_P", aliasTabla))))
    '    e.ID_OFERTA_FORMATIVA_H = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_OFERTA_FORMATIVA_H", aliasTabla))))
    '    e.NUM_MODULO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NUM_MODULO", aliasTabla))))
    'End Sub

    Public Sub AsignarOFERTA_FORMATIVA(ByVal dr As IDataReader, ByRef e As OFERTA_FORMATIVA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New OFERTA_FORMATIVA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_OFERTA_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_OFERTA_FORMATIVA", aliasTabla))))
        e.ID_EJERCICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ID_EJERCICIO", aliasTabla))))
        e.ID_TEMA_CURSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TEMA_CURSO", aliasTabla))))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla))))
        e.DURACION_HORAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DURACION_HORAS", aliasTabla)), -1))
        e.COSTO_X_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}COSTO_X_PARTICIPANTE", aliasTabla)), -1))
        e.FECHA_INICIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIO", aliasTabla))))
        e.FECHA_FIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
        e.ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla))))
        e.FECHA_APROBACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_APROBACION", aliasTabla))))
        e.USUARIO_APROBACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_APROBACION", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.TEMA_CURSO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TEMA_CURSO", aliasTabla))))
    End Sub

    Public Sub AsignarNIVEL_ACADEMICO(ByVal dr As IDataReader, ByRef e As NIVEL_ACADEMICO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New NIVEL_ACADEMICO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_NIVEL_ACADEMICO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_NIVEL_ACADEMICO", aliasTabla))))
        e.NOMBRE_NIVEL_ACADEMICO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_NIVEL_ACADEMICO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarMUNICIPIO(ByVal dr As IDataReader, ByRef e As MUNICIPIO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New MUNICIPIO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.NOMBRE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.LATITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LATITUD", aliasTabla)), -1))
        e.LONGITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LONGITUD", aliasTabla)), -1))
    End Sub

    Public Sub AsignarMODALIDAD_DE_FORMACION(ByVal dr As IDataReader, ByRef e As MODALIDAD_DE_FORMACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New MODALIDAD_DE_FORMACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_MODALIDAD_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_MODALIDAD_FORMACION", aliasTabla))))
        e.MODALIDAD_FORMACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MODALIDAD_FORMACION", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
    End Sub

    Public Sub AsignarGRUPO_SOLICITUD(ByVal dr As IDataReader, ByRef e As GRUPO_SOLICITUD, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New GRUPO_SOLICITUD
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_GRUPO_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_GRUPO_SOLICITUD", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.ID_MODALIDAD_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_MODALIDAD_FORMACION", aliasTabla))))
        e.CODIGO_PROGRAMA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_PROGRAMA", aliasTabla))))
        e.DURACION_HORAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DURACION_HORAS", aliasTabla))))
        e.NUM_PARTICIPANTES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NUM_PARTICIPANTES", aliasTabla))))
        e.TDR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TDR", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.CORRELATIVO_GRUPO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CORRELATIVO_GRUPO", aliasTabla))))
        e.USUARIO_CREACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_CREACION", aliasTabla))))
        e.FECHA_CREACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_CREACION", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.LUGAR_EJECUCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}LUGAR_EJECUCION", aliasTabla))))
        e.NOMBRE_ACCION_FORMATIVA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ACCION_FORMATIVA", aliasTabla)), Nothing))
        e.IsDirty = False
    End Sub

    Public Sub AsignarMETODO_EVALUACION(ByVal dr As IDataReader, ByRef e As METODO_EVALUACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New METODO_EVALUACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_METODO_EVALUACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_METODO_EVALUACION", aliasTabla))))
        e.METODO_EVALUACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}METODO_EVALUACION", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
    End Sub

    Public Sub AsignarLISTA_SUPERVISION_AF(ByVal dr As IDataReader, ByRef e As LISTA_SUPERVISION_AF, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New LISTA_SUPERVISION_AF
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_LISTA_SUPERVISION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_LISTA_SUPERVISION", aliasTabla))))
        e.LISTA_SUPERVISION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}LISTA_SUPERVISION", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
    End Sub

    Public Sub AsignarESTADO_INFORME_AF(ByVal dr As IDataReader, ByRef e As ESTADO_INFORME_AF, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ESTADO_INFORME_AF
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ESTADO_INFORME = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_INFORME", aliasTabla))))
        e.ID_FASE_ESTADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FASE_ESTADO", aliasTabla)), -1))
        e.NOMBRE_ESTADO_INFORME = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ESTADO_INFORME", aliasTabla))))
        e.DESCRIPCION_ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION_ESTADO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarFASE_ESTADO_INFORME(ByVal dr As IDataReader, ByRef e As FASE_ESTADO_INFORME, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New FASE_ESTADO_INFORME
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_FASE_ESTADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FASE_ESTADO", aliasTabla))))
        e.NOMBRE_FASE_ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_FASE_ESTADO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarINFORME_FINAL_AF(ByVal dr As IDataReader, ByRef e As INFORME_FINAL_AF, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New INFORME_FINAL_AF
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_INFORME_FINAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_INFORME_FINAL", aliasTabla))))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla)), -1))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla)), -1))
        e.FECHA_INFORME = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INFORME", aliasTabla))))
        e.NUMERO_FACTURA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUMERO_FACTURA", aliasTabla))))
        e.ELABORADO_POR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ELABORADO_POR", aliasTabla))))
        e.MONTO_FACTURA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_FACTURA", aliasTabla)), -1))
        e.MONTO_APROBADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_APROBADO", aliasTabla)), -1))
        e.PARTICIPANTES_INSCRITOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIPANTES_INSCRITOS", aliasTabla)), -1))
        e.PARTICIPANTES_FINALES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIPANTES_FINALES", aliasTabla)), -1))
        e.PORC_PROM_ASISTENCIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_PROM_ASISTENCIA", aliasTabla)), -1))
        e.NOTA_PROMEDIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NOTA_PROMEDIO", aliasTabla)), -1))
        e.COMENTARIOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COMENTARIOS", aliasTabla))))
        e.USUARIO_APROBACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_APROBACION", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.ID_ESTADO_INFORME = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_INFORME", aliasTabla)), -1))
        e.HORAS_DESARROLLADAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}HORAS_DESARROLLADAS", aliasTabla)), -1))
        e.FECHA_INICIAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIAL", aliasTabla))))
        e.FECHA_FINAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FINAL", aliasTabla))))
        e.HORARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}HORARIO", aliasTabla))))
        e.COSTO_X_HORA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}COSTO_X_HORA", aliasTabla))))
        e.MONTO_PAGO_INICIAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_PAGO_INICIAL", aliasTabla)), -1))
        e.USUARIO_ASIGNADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_ASIGNADO", aliasTabla))))
    End Sub

    Public Sub AsignarINFORME_FINAL_AF_HIS(ByVal dr As IDataReader, ByRef e As INFORME_FINAL_AF_HIS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New INFORME_FINAL_AF_HIS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_INFORME_FINAL_HIS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_INFORME_FINAL_HIS", aliasTabla))))
        e.ID_INFORME_FINAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_INFORME_FINAL", aliasTabla)), -1))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla)), -1))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla)), -1))
        e.FECHA_INFORME = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INFORME", aliasTabla))))
        e.NUMERO_FACTURA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUMERO_FACTURA", aliasTabla))))
        e.ELABORADO_POR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ELABORADO_POR", aliasTabla))))
        e.MONTO_FACTURA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_FACTURA", aliasTabla))))
        e.MONTO_APROBADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_APROBADO", aliasTabla))))
        e.PARTICIPANTES_INSCRITOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIPANTES_INSCRITOS", aliasTabla))))
        e.PARTICIPANTES_FINALES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIPANTES_FINALES", aliasTabla))))
        e.PORC_PROM_ASISTENCIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_PROM_ASISTENCIA", aliasTabla))))
        e.NOTA_PROMEDIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NOTA_PROMEDIO", aliasTabla)), -1))
        e.COMENTARIOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COMENTARIOS", aliasTabla))))
        e.USUARIO_APROBACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_APROBACION", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.ID_ESTADO_INFORME = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_INFORME", aliasTabla)), -1))
        e.HORAS_DESARROLLADAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}HORAS_DESARROLLADAS", aliasTabla)), -1))
        e.FECHA_INICIAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIAL", aliasTabla))))
        e.FECHA_FINAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FINAL", aliasTabla))))
        e.HORARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}HORARIO", aliasTabla))))
        e.MONTO_PAGO_INICIAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_PAGO_INICIAL", aliasTabla)), -1))
    End Sub

    Public Sub AsignarHALLAZGO_SUPERVISION(ByVal dr As IDataReader, ByRef e As HALLAZGO_SUPERVISION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New HALLAZGO_SUPERVISION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_HALLAZGO_SUPERVISION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_HALLAZGO_SUPERVISION", aliasTabla))))
        e.ID_AREA_SUPERVISION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_AREA_SUPERVISION", aliasTabla)), -1))
        e.ID_SUPERVISION_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SUPERVISION_AF", aliasTabla)), -1))
        e.HALLAZGO_SUPERVISION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}HALLAZGO_SUPERVISION", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.TIPO_SANCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_SANCION", aliasTabla))))
        e.TIEMPO_SANCION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIEMPO_SANCION", aliasTabla)), -1))
        e.MONTO_SANCION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_SANCION", aliasTabla)), -1))
        e.TIEMPO_SUBSANACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIEMPO_SUBSANACION", aliasTabla)), -1))
    End Sub

    Public Sub AsignarGRUPO_USUARIO(ByVal dr As IDataReader, ByRef e As GRUPO_USUARIO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New GRUPO_USUARIO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_GRUPO_USUARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_GRUPO_USUARIO", aliasTabla))))
        e.ROL_USUARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ROL_USUARIO", aliasTabla))))
        e.NIVEL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NIVEL", aliasTabla)), -1))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
    End Sub

    Public Sub AsignarFACILITADOR_CAPACITADOR(ByVal dr As IDataReader, ByRef e As FACILITADOR_CAPACITADOR, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New FACILITADOR_CAPACITADOR
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_FACILITADOR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FACILITADOR", aliasTabla))))
        e.ID_TIPO_PERSONA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_PERSONA", aliasTabla)), -1))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla)), -1))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.NOMBRE_FACILITADOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_FACILITADOR", aliasTabla))))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.DUI = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DUI", aliasTabla))))
        e.ISSS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ISSS", aliasTabla))))
        e.FECHA_INGRESO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INGRESO", aliasTabla))))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.EMAIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL", aliasTabla))))
        e.DIRECCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarEVALUACIONES_AF_DET(ByVal dr As IDataReader, ByRef e As EVALUACIONES_AF_DET, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New EVALUACIONES_AF_DET
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_EVALUACION_DET = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_EVALUACION_DET", aliasTabla))))
        e.ID_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PARTICIPANTE", aliasTabla)), -1))
        e.ID_EVALUACION_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_EVALUACION_AF", aliasTabla)), -1))
        e.NOTA_OBTENIDA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NOTA_OBTENIDA", aliasTabla)), -1))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
    End Sub

    Public Sub AsignarEVALUACION_AF(ByVal dr As IDataReader, ByRef e As EVALUACION_AF, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New EVALUACION_AF
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_EVALUACION_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_EVALUACION_AF", aliasTabla))))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla)), -1))
        e.FECHA_EVALUACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_EVALUACION", aliasTabla))))
        e.TEMA_EVALUACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TEMA_EVALUACION", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
        e.EVALUADOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EVALUADOR", aliasTabla))))
        e.TIPO_EVALUACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_EVALUACION", aliasTabla))))
        e.PORC_APROBACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_APROBACION", aliasTabla)), -1))
        e.PORC_REPROBADOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_REPROBADOS", aliasTabla)), -1))
    End Sub

    Public Sub AsignarETAPA(ByVal dr As IDataReader, ByRef e As ETAPA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ETAPA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODIGO_ETAPA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_ETAPA", aliasTabla))))
        e.CODIGO_PROCESO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_PROCESO", aliasTabla))))
        e.ID_ESTADO_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_SOLICITUD", aliasTabla)), -1))
        e.UNIDAD_DE_TIEMPO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}UNIDAD_DE_TIEMPO", aliasTabla))))
        e.NOMBRE_ETAPA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ETAPA", aliasTabla))))
        e.ETAPA_ANT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ETAPA_ANT", aliasTabla))))
        e.ETAPA_SIG = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ETAPA_SIG", aliasTabla))))
        e.TIPO_ETAPA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_ETAPA", aliasTabla))))
        e.DURACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DURACION", aliasTabla)), -1))
        e.ORDEN_EJECUCION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ORDEN_EJECUCION", aliasTabla)), -1))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarESTADO_SOLICITUD(ByVal dr As IDataReader, ByRef e As ESTADO_SOLICITUD, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ESTADO_SOLICITUD
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ESTADO_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_SOLICITUD", aliasTabla))))
        e.ESTADO_SOLICITUD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO_SOLICITUD", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
    End Sub

    Public Sub AsignarESTADO_ACCION_FORMATIVA(ByVal dr As IDataReader, ByRef e As ESTADO_ACCION_FORMATIVA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ESTADO_ACCION_FORMATIVA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODIGO_ESTADO_AF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_ESTADO_AF", aliasTabla))))
        e.NOMBRE_ESTADO_AF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ESTADO_AF", aliasTabla))))
        e.ESTADO_INICIAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ESTADO_INICIAL", aliasTabla)), -1))
        e.PERMITE_INSCRIPCION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PERMITE_INSCRIPCION", aliasTabla)), -1))
        e.ESTADO_FINAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ESTADO_FINAL", aliasTabla)), -1))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
    End Sub

    Public Sub AsignarEMPRESAS(ByVal dr As IDataReader, ByRef e As EMPRESAS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New EMPRESAS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.NUMERO_PATRONAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUMERO_PATRONAL", aliasTabla))))
        e.NIT_EMPRESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT_EMPRESA", aliasTabla))))
        e.CIUU = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CIUU", aliasTabla))))
        e.SECTOR_PRODUCTIVO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SECTOR_PRODUCTIVO", aliasTabla))))
        e.CODIGO_ASESOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_ASESOR", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_REGION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_REGION", aliasTabla))))
        e.NOMBRE_EMPRESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_EMPRESA", aliasTabla))))
        e.TIPO_EMPRESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPO_EMPRESA", aliasTabla))))
        e.CONTACTO_EMPRESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONTACTO_EMPRESA", aliasTabla))))
        e.TELEFONO_CONTACTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO_CONTACTO", aliasTabla))))
        e.CARGO_CONTACTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CARGO_CONTACTO", aliasTabla))))
        e.DIRECCION_EMPRESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DIRECCION_EMPRESA", aliasTabla))))
        e.TELEFONO_EMPRESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO_EMPRESA", aliasTabla))))
        e.FAX_EMPRESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}FAX_EMPRESA", aliasTabla))))
        e.EMAIL_EMPRESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}EMAIL_EMPRESA", aliasTabla))))
        e.ESPECIALIDAD_EMPRESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESPECIALIDAD_EMPRESA", aliasTabla))))
        e.TOTAL_PERSONA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL_PERSONA", aliasTabla)), -1))
        e.TOTAL_PLANILLA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL_PLANILLA", aliasTabla)), -1))
        e.REPRESENTANTE_LEGAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}REPRESENTANTE_LEGAL", aliasTabla))))
        e.FECHA_REGISTRO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_REGISTRO", aliasTabla))))
        e.TOTAL_TRABAJADORES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TOTAL_TRABAJADORES", aliasTabla)), -1))
        e.FEMENINOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}FEMENINOS", aliasTabla)), -1))
        e.MASCULINOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MASCULINOS", aliasTabla)), -1))
        e.TAMANO_EMPRESA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TAMANO_EMPRESA", aliasTabla))))
        e.CON_MANDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CON_MANDO", aliasTabla)), -1))
        e.SIN_MANDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}SIN_MANDO", aliasTabla)), -1))
        e.ADMINISTRATIVOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ADMINISTRATIVOS", aliasTabla)), -1))
        e.MANDOS_MEDIOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MANDOS_MEDIOS", aliasTabla)), -1))
        e.OPERATIVOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}OPERATIVOS", aliasTabla)), -1))
        e.GERENCIAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}GERENCIAL", aliasTabla)), -1))
        e.SIGLAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SIGLAS", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.OBSERVACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACION", aliasTabla))))
        e.NUM_PAT_ISSS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUM_PAT_ISSS", aliasTabla))))
        e.TIPOPERSON = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TIPOPERSON", aliasTabla))))
        e.NUM = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NUM", aliasTabla)), -1))
        e.REPRESENTANTE_PROFESION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}REPRESENTANTE_PROFESION", aliasTabla))))
        e.CONTACTO_EMAIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONTACTO_EMAIL", aliasTabla))))
        e.APORTE_INSAFORP = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}APORTE_INSAFORP", aliasTabla)), -1))
        e.ZONA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ZONA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarEJERCICIO(ByVal dr As IDataReader, ByRef e As EJERCICIO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New EJERCICIO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_EJERCICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ID_EJERCICIO", aliasTabla))))
        e.ETIQUETA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ETIQUETA", aliasTabla))))
        e.FECHA_INICIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIO", aliasTabla))))
        e.FECHA_FIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
    End Sub

    Public Sub AsignarDEPARTAMENTO(ByVal dr As IDataReader, ByRef e As DEPARTAMENTO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DEPARTAMENTO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_REGION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_REGION", aliasTabla))))
        e.NOMBRE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.LATITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LATITUD", aliasTabla)), -1))
        e.LONGITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}LONGITUD", aliasTabla)), -1))
        e.COOR_POLIGONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COOR_POLIGONO", aliasTabla))))
    End Sub

    Public Sub AsignarCURSO_TEMA(ByVal dr As IDataReader, ByRef e As CURSO_TEMA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CURSO_TEMA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TEMA_CURSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TEMA_CURSO", aliasTabla))))
        e.ID_SUBAREA_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SUBAREA_FORMACION", aliasTabla)), -1))
        e.TEMA_CURSO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TEMA_CURSO", aliasTabla))))
        e.DURACION_HORAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DURACION_HORAS", aliasTabla)), -1))
        e.FECHA_ACREDITACION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_ACREDITACION", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
        e.CODIGO_PROGRAMA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_PROGRAMA", aliasTabla))))
        e.REF_ID_TEMA_CURSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}REF_ID_TEMA_CURSO", aliasTabla)), -1))
        e.ID_AREA_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_AREA_FORMACION", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarCOMPROMISO_CONTRATO(ByVal dr As IDataReader, ByRef e As COMPROMISO_CONTRATO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New COMPROMISO_CONTRATO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_COMPROMISO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_COMPROMISO", aliasTabla))))
        e.ID_CONTRATO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO", aliasTabla))))
        e.NUM_COMPROMISO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUM_COMPROMISO", aliasTabla))))
        e.FECHA_INICIAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIAL", aliasTabla))))
        e.FECHA_FINAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FINAL", aliasTabla))))
        e.MONTO_COMPROMETIDO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_COMPROMETIDO", aliasTabla))))
        e.MONTO_PROVISIONADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_PROVISIONADO", aliasTabla))))
        e.MONTO_DEVENGADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_DEVENGADO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarCOMPROMISO_AF(ByVal dr As IDataReader, ByRef e As COMPROMISO_AF, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New COMPROMISO_AF
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_COMPROMISO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_COMPROMISO", aliasTabla))))
        e.ID_INFORME_FINAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_INFORME_FINAL", aliasTabla))))
        e.MONTO_DEVENGADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_DEVENGADO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarCONTROL_DOCUMENTOS(ByVal dr As IDataReader, ByRef e As CONTROL_DOCUMENTOS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CONTROL_DOCUMENTOS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.NUMERO_DOCUMENTO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NUMERO_DOCUMENTO", aliasTabla))))
        e.NUMERO_PATRONAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUMERO_PATRONAL", aliasTabla))))
        e.NUMERO_FOLIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NUMERO_FOLIO", aliasTabla))))
        e.ID_TIPO_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIPO_SOLICITUD", aliasTabla)), -1))
        e.CODIGO_ETAPA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_ETAPA", aliasTabla))))
        e.CODIGO_PROCESO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_PROCESO", aliasTabla))))
        e.ID_ESTADO_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_SOLICITUD", aliasTabla)), -1))
        e.NIT = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NIT", aliasTabla))))
        e.PRESENTADO_POR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PRESENTADO_POR", aliasTabla))))
        e.FECHA_RECEPCION = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_RECEPCION", aliasTabla))))
        e.RESPONSABLE_ACTUAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}RESPONSABLE_ACTUAL", aliasTabla))))
        e.RESPONSABLE_ANTERIOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}RESPONSABLE_ANTERIOR", aliasTabla))))
        e.PRIORIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PRIORIDAD", aliasTabla))))
        e.NO_DOCUMENTO_ORIGEN = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_DOCUMENTO_ORIGEN", aliasTabla)), -1))
        e.NO_DOCUMENTO_PADRE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_DOCUMENTO_PADRE", aliasTabla)), -1))
        e.FECHA_REQUERIDA_FIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_REQUERIDA_FIN", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarCIUU(ByVal dr As IDataReader, ByRef e As CIUU, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CIUU
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CIUU = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CIUU", aliasTabla))))
        e.DESCRIPCION_CIIU = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION_CIIU", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarCIUO(ByVal dr As IDataReader, ByRef e As CIUO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CIUO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.CIUO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CIUO", aliasTabla))))
        e.DESCRIPCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION", aliasTabla))))
        e.DESCRIPCION_NACIONAL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}DESCRIPCION_NACIONAL", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarCATCURSO_2(ByVal dr As IDataReader, ByRef e As CATCURSO_2, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New CATCURSO_2
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_CURSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CURSO", aliasTabla))))
        e.NOMBRE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE", aliasTabla))))
        e.DURACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DURACION", aliasTabla)), -1))
    End Sub

    Public Sub AsignarASISTENCIA_AF_DET(ByVal dr As IDataReader, ByRef e As ASISTENCIA_AF_DET, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ASISTENCIA_AF_DET
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ASISTENCIA_DET = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ASISTENCIA_DET", aliasTabla))))
        e.ID_ASISTENCIA_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ASISTENCIA_AF", aliasTabla)), -1))
        e.ID_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PARTICIPANTE", aliasTabla)), -1))
        e.ASISTIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ASISTIO", aliasTabla))))
        e.PRESENTA_JUSTIFICACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}PRESENTA_JUSTIFICACION", aliasTabla))))
        e.JUSTIFICACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}JUSTIFICACION", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        'e.HORAS_ASISTENCIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}HORAS_ASISTENCIA", aliasTabla))))
    End Sub

    Public Sub AsignarASISTENCIA_AF(ByVal dr As IDataReader, ByRef e As ASISTENCIA_AF, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ASISTENCIA_AF
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ASISTENCIA_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ASISTENCIA_AF", aliasTabla))))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla)), -1))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.INSTRUCTOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}INSTRUCTOR", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarAREA_SUPERVISION(ByVal dr As IDataReader, ByRef e As AREA_SUPERVISION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New AREA_SUPERVISION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_AREA_SUPERVISION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_AREA_SUPERVISION", aliasTabla))))
        e.AREA_SUPERVISION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}AREA_SUPERVISION", aliasTabla))))
        e.SANCIONATORIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}SANCIONATORIA", aliasTabla))))
        e.MONTO_SANCION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_SANCION", aliasTabla)), -1))
        e.TIEMPO_SANCION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}TIEMPO_SANCION", aliasTabla)), -1))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
    End Sub

    Public Sub AsignarAREA_FORMACION(ByVal dr As IDataReader, ByRef e As AREA_FORMACION, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New AREA_FORMACION
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_AREA_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_AREA_FORMACION", aliasTabla))))
        e.AREA_FORMACION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}AREA_FORMACION", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
        e.CODIGO_AREA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_AREA", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarACCION_FORMATIVA_HIST(ByVal dr As IDataReader, ByRef e As ACCION_FORMATIVA_HIST, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ACCION_FORMATIVA_HIST
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ACCION_FORMATIVA_HIST = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA_HIST", aliasTabla))))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla))))
        e.ID_OFERTA_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_OFERTA_FORMATIVA", aliasTabla)), -1))
        e.ID_SITIO_CAPACITACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SITIO_CAPACITACION", aliasTabla)), -1))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla)), -1))
        e.ID_TEMA_CURSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TEMA_CURSO", aliasTabla)), -1))
        e.ID_EJERCICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ID_EJERCICIO", aliasTabla))))
        e.NOMBRE_ACCION_FORMATIVA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ACCION_FORMATIVA", aliasTabla))))
        e.CODIGO_GRUPO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_GRUPO", aliasTabla))))
        e.NUMERO_PARTICIPANTES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NUMERO_PARTICIPANTES", aliasTabla)), -1))
        e.PARTICIPANTES_INSCRITOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIPANTES_INSCRITOS", aliasTabla)), -1))
        e.HORARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}HORARIO", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
        e.CODIGO_ESTADO_AF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_ESTADO_AF", aliasTabla))))
        e.DURACION_HORAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DURACION_HORAS", aliasTabla)), -1))
        e.COSTO_X_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}COSTO_X_PARTICIPANTE", aliasTabla)), -1))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.FECHA_INICIO_REAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIO_REAL", aliasTabla))))
        e.FECHA_FIN_REAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN_REAL", aliasTabla))))
        e.OBSERVACIONES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACIONES", aliasTabla))))
        e.ID_ACCION_CONTRATADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_CONTRATADA", aliasTabla)), -1))
        e.CODI_FORMADOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_FORMADOR", aliasTabla))))
        e.NOMBRE_FORMADOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_FORMADOR", aliasTabla))))
    End Sub

    Public Sub AsignarACCION_FORMATIVA(ByVal dr As IDataReader, ByRef e As ACCION_FORMATIVA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ACCION_FORMATIVA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla))))
        e.ID_OFERTA_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_OFERTA_FORMATIVA", aliasTabla)), -1))
        e.ID_SITIO_CAPACITACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SITIO_CAPACITACION", aliasTabla)), -1))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla)), -1))
        e.ID_TEMA_CURSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TEMA_CURSO", aliasTabla)), -1))
        e.ID_EJERCICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ID_EJERCICIO", aliasTabla))))
        e.NOMBRE_ACCION_FORMATIVA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ACCION_FORMATIVA", aliasTabla))))
        e.CODIGO_GRUPO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_GRUPO", aliasTabla))))
        e.NUMERO_PARTICIPANTES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NUMERO_PARTICIPANTES", aliasTabla)), -1))
        e.PARTICIPANTES_INSCRITOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIPANTES_INSCRITOS", aliasTabla)), -1))
        e.FECHA_INICIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIO", aliasTabla))))
        e.FECHA_FIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN", aliasTabla))))
        e.HORARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}HORARIO", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
        e.CODIGO_ESTADO_AF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_ESTADO_AF", aliasTabla))))
        e.DURACION_HORAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DURACION_HORAS", aliasTabla)), -1))
        e.COSTO_X_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}COSTO_X_PARTICIPANTE", aliasTabla)), -1))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.FECHA_INICIO_REAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIO_REAL", aliasTabla))))
        e.FECHA_FIN_REAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN_REAL", aliasTabla))))
        e.OBSERVACIONES = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}OBSERVACIONES", aliasTabla))))
        e.ID_ACCION_CONTRATADA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_CONTRATADA", aliasTabla)), -1))
        e.CODI_FORMADOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_FORMADOR", aliasTabla))))
        e.NOMBRE_FORMADOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_FORMADOR", aliasTabla))))
    End Sub

    Public Sub AsignarACCION_FORMATIVA_DETALLE(ByVal dr As IDataReader, ByRef e As ACCION_FORMATIVA_DETALLE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ACCION_FORMATIVA_DETALLE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla))))
        e.ID_PROGRAMA_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROGRAMA_FORMACION", aliasTabla))))
        e.ID_MODALIDAD_FORMACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_MODALIDAD_FORMACION", aliasTabla))))
        e.ID_CONTRATO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_CONTRATO", aliasTabla)), -1))
        e.ID_FUENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FUENTE", aliasTabla)), -1))
        e.NO_CONVOCATORIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NO_CONVOCATORIA", aliasTabla)), -1))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.LUGAR_EJECUCION = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}LUGAR_EJECUCION", aliasTabla))))
        e.TELEFONO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}TELEFONO", aliasTabla))))
        e.CONTACTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CONTACTO", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.ID_GRUPO_SELEC = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_GRUPO_SELEC", aliasTabla)), -1))
        e.ID_UNIDAD_ORGANIZATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_UNIDAD_ORGANIZATIVA", aliasTabla)), -1))
    End Sub

    Public Sub AsignarINFORME_FINAL_DET(ByVal dr As IDataReader, ByRef e As INFORME_FINAL_DET, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New INFORME_FINAL_DET
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_INFORME_FINAL_DET = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_INFORME_FINAL_DET", aliasTabla))))
        e.ID_INFORME_FINAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_INFORME_FINAL", aliasTabla)), -1))
        e.ID_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PARTICIPANTE", aliasTabla)), -1))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla)), -1))
        e.NOTA_OBTENIDA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NOTA_OBTENIDA", aliasTabla)), -1))
        e.PORC_ASISTENCIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_ASISTENCIA", aliasTabla)), -1))
        e.MONTO_SOLICITADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_SOLICITADO", aliasTabla)), -1))
        e.MONTO_APROBADO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}MONTO_APROBADO", aliasTabla)), -1))
        e.ESTADO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.NOTA_TEORICA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NOTA_TEORICA", aliasTabla)), -1))
        e.NOTA_PRACTICA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NOTA_PRACTICA", aliasTabla)), -1))
        e.PORC_PAGO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PORC_PAGO", aliasTabla)), -1))
    End Sub

    Public Sub AsignarESTADO_REPROG(ByVal dr As IDataReader, ByRef e As ESTADO_REPROG, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ESTADO_REPROG
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ESTADO_REPROG = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_REPROG", aliasTabla))))
        e.ESTADO_REPROG = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ESTADO_REPROG", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
    End Sub

    Public Sub AsignarACCION_FORMATIVA_REPROG(ByVal dr As IDataReader, ByRef e As ACCION_FORMATIVA_REPROG, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ACCION_FORMATIVA_REPROG
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ACCION_FORMATIVA_REPROG = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA_REPROG", aliasTabla))))
        e.ID_ESTADO_REPROG = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_REPROG", aliasTabla)), -1))
        e.ID_ACCION_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ACCION_FORMATIVA", aliasTabla))))
        e.ID_OFERTA_FORMATIVA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_OFERTA_FORMATIVA", aliasTabla)), -1))
        e.ID_SITIO_CAPACITACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SITIO_CAPACITACION", aliasTabla)), -1))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla)), -1))
        e.ID_TEMA_CURSO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TEMA_CURSO", aliasTabla)), -1))
        e.ID_EJERCICIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}ID_EJERCICIO", aliasTabla))))
        e.NOMBRE_ACCION_FORMATIVA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ACCION_FORMATIVA", aliasTabla))))
        e.CODIGO_GRUPO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_GRUPO", aliasTabla))))
        e.NUMERO_PARTICIPANTES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NUMERO_PARTICIPANTES", aliasTabla)), -1))
        e.PARTICIPANTES_INSCRITOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}PARTICIPANTES_INSCRITOS", aliasTabla)), -1))
        e.HORARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}HORARIO", aliasTabla))))
        e.NOTAS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOTAS", aliasTabla))))
        e.CODIGO_ESTADO_AF = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_ESTADO_AF", aliasTabla))))
        e.DURACION_HORAS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}DURACION_HORAS", aliasTabla)), -1))
        e.COSTO_X_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}COSTO_X_PARTICIPANTE", aliasTabla)), -1))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.FECHA_INICIO_REAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_INICIO_REAL", aliasTabla))))
        e.FECHA_FIN_REAL = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_FIN_REAL", aliasTabla))))
        e.MOTIVOREPROG = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOTIVOREPROG", aliasTabla))))
        e.MOTIVORECHAZO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}MOTIVORECHAZO", aliasTabla))))
        e.FECHA_SOLIC_REPROG = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA_SOLIC_REPROG", aliasTabla))))
        e.CODI_FORMADOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODI_FORMADOR", aliasTabla))))
        e.NOMBRE_FORMADOR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_FORMADOR", aliasTabla))))
    End Sub

    Public Sub AsignarTECNICOS_SITIOS_ASIG(ByVal dr As IDataReader, ByRef e As TECNICOS_SITIOS_ASIG, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TECNICOS_SITIOS_ASIG
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.USUARIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO", aliasTabla))))
        e.ID_PROVEEDOR_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PROVEEDOR_AF", aliasTabla))))
        e.ID_SITIO_CAPACITACION = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SITIO_CAPACITACION", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarFUENTE_FINANCIAMIENTO(ByVal dr As IDataReader, ByRef e As FUENTE_FINANCIAMIENTO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New FUENTE_FINANCIAMIENTO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_FUENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FUENTE", aliasTabla))))
        e.NOMBRE_FUENTE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_FUENTE", aliasTabla))))
        e.NOMBRE_BANCO_LIQ = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_BANCO_LIQ", aliasTabla))))
        e.NO_CTA_LIQ = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_CTA_LIQ", aliasTabla))))
        e.NOMBRE_CTA_LIQ = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CTA_LIQ", aliasTabla))))
        e.CODIGO_FINANCIAMIENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_FINANCIAMIENTO", aliasTabla))))
        e.COSTO_X_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}COSTO_X_PARTICIPANTE", aliasTabla)), -1))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.NOMBRE_BANCO_DESEMBOLSO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_BANCO_DESEMBOLSO", aliasTabla))))
        e.NO_CTA_DESEMBOLSO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NO_CTA_DESEMBOLSO", aliasTabla))))
        e.NOMBRE_CTA_DESEMBOLSO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_CTA_DESEMBOLSO", aliasTabla))))
    End Sub

    Public Sub AsignarFASE_MUNICIPIOS(ByVal dr As IDataReader, ByRef e As FASE_MUNICIPIOS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New FASE_MUNICIPIOS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_FASE_MUNICIPIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FASE_MUNICIPIO", aliasTabla))))
        e.ID_FUENTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FUENTE", aliasTabla)), -1))
        e.ID_FASE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FASE", aliasTabla)), -1))
        e.CODIGO_MUNICIPIO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_MUNICIPIO", aliasTabla))))
        e.CODIGO_DEPARTAMENTO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}CODIGO_DEPARTAMENTO", aliasTabla))))
        e.NUM_AUP = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NUM_AUP", aliasTabla)), -1))
        e.NUMERO_PARTICIPANTES = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}NUMERO_PARTICIPANTES", aliasTabla)), -1))
    End Sub

    Public Sub AsignarFASE(ByVal dr As IDataReader, ByRef e As FASE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New FASE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_FASE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_FASE", aliasTabla))))
        e.NOMBRE_FASE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_FASE", aliasTabla))))
    End Sub

    Public Sub AsignarPAQUETE_INFORME_DET(ByVal dr As IDataReader, ByRef e As PAQUETE_INFORME_DET, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PAQUETE_INFORME_DET
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PAQUETE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PAQUETE", aliasTabla))))
        e.ID_INFORME_FINAL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_INFORME_FINAL", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
    End Sub

    Public Sub AsignarPAQUETE_INFORME(ByVal dr As IDataReader, ByRef e As PAQUETE_INFORME, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PAQUETE_INFORME
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PAQUETE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PAQUETE", aliasTabla))))
        e.FECHA = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}FECHA", aliasTabla))))
        e.COMENTARIOS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}COMENTARIOS", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.USUARIO_TECNICO = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USUARIO_TECNICO", aliasTabla))))
    End Sub

    Public Sub AsignarASISTENCIA_AF_HORARIO(ByVal dr As IDataReader, ByRef e As ASISTENCIA_AF_HORARIO, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ASISTENCIA_AF_HORARIO
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ASISTENCIA_AF = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ASISTENCIA_AF", aliasTabla))))
        e.ID_ASISTENCIA_AF_HORARIO = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ASISTENCIA_AF_HORARIO", aliasTabla))))
        e.HORA_INICIO = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}HORA_INICIO", aliasTabla))))
        e.HORA_FIN = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}HORA_FIN", aliasTabla))))
        e.CANTIDAD_MINUTOS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}CANTIDAD_MINUTOS", aliasTabla)), -1))
    End Sub

    Public Sub AsignarDISCA_POR_PARTICIPANTE(ByVal dr As IDataReader, ByRef e As DISCA_POR_PARTICIPANTE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DISCA_POR_PARTICIPANTE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DISCAPACIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_DISCAPACIDAD", aliasTabla))))
        e.ID_PARTICIPANTE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PARTICIPANTE", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarDISCA_POR_SOLICITUD(ByVal dr As IDataReader, ByRef e As DISCA_POR_SOLICITUD, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DISCA_POR_SOLICITUD
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DISCAPACIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_DISCAPACIDAD", aliasTabla))))
        e.ID_SOLICITUD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_SOLICITUD", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarDISCAPACIDAD(ByVal dr As IDataReader, ByRef e As DISCAPACIDAD, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New DISCAPACIDAD
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_DISCAPACIDAD = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_DISCAPACIDAD", aliasTabla))))
        e.NOMBRE_DISCAPACIDAD = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_DISCAPACIDAD", aliasTabla))))
        e.USERID = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}USERID", aliasTabla))))
        e.LASTUPDATE = Convert.ToDateTime(ObtenerValor(dr.Item(String.Format("{0}LASTUPDATE", aliasTabla))))
    End Sub

    Public Sub AsignarEDUC_LEE_ESCRIBE(ByVal dr As IDataReader, ByRef e As EDUC_LEE_ESCRIBE, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New EDUC_LEE_ESCRIBE
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_LEE_ESCRIBE = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_LEE_ESCRIBE", aliasTabla))))
        e.NOMBRE_LEE_ESCRIBE = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_LEE_ESCRIBE", aliasTabla))))
    End Sub

    Public Sub AsignarESTADO_CIVIL(ByVal dr As IDataReader, ByRef e As ESTADO_CIVIL, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New ESTADO_CIVIL
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_ESTADO_CIVIL = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_ESTADO_CIVIL", aliasTabla))))
        e.NOMBRE_ESTADO_CIVIL = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_ESTADO_CIVIL", aliasTabla))))
    End Sub

    Public Sub AsignarPAIS(ByVal dr As IDataReader, ByRef e As PAIS, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New PAIS
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_PAIS = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_PAIS", aliasTabla))))
        e.NOMBRE_PAIS = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_PAIS", aliasTabla))))
    End Sub

    Public Sub AsignarREFERENCIA(ByVal dr As IDataReader, ByRef e As REFERENCIA, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New REFERENCIA
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_REFERENCIA = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_REFERENCIA", aliasTabla))))
        e.NOMBRE_REFERENCIA = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_REFERENCIA", aliasTabla))))
    End Sub

    Public Sub AsignarTIEMPO_DEJO_ESTUDIAR(ByVal dr As IDataReader, ByRef e As TIEMPO_DEJO_ESTUDIAR, Optional ByVal aliasTabla As String = "")
        If IsNothing(e) Then
            e = New TIEMPO_DEJO_ESTUDIAR
        End If
        If aliasTabla <> "" Then
            aliasTabla = String.Format("{0}.", aliasTabla)
        End If
        e.ID_TIEMPO_DEJO_ESTUDIAR = Convert.ToDecimal(ObtenerValor(dr.Item(String.Format("{0}ID_TIEMPO_DEJO_ESTUDIAR", aliasTabla))))
        e.NOMBRE_TIEMPO_DEJO_ESTUDIAR = Convert.ToString(ObtenerValor(dr.Item(String.Format("{0}NOMBRE_TIEMPO_DEJO_ESTUDIAR", aliasTabla))))
    End Sub

    Public Function ObtenerValor(ByVal valor As Object) As Object
        Dim s As String = ""

        If valor Is DBNull.Value Then
            Return Nothing
        Else
            Return valor
        End If
    End Function

    Public Function ObtenerValor(ByVal valor As Object, ByVal valorDefault As Integer) As Object
        If valor Is DBNull.Value Then
            Return valorDefault
        Else
            Return valor
        End If
    End Function
End Module

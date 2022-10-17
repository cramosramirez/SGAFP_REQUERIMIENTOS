<%@ Page Title="" Language="VB" MasterPageFile="~/principal.master" AutoEventWireup="false" CodeFile="wfPreguntasFrecuentes.aspx.vb" Inherits="wfPreguntasFrecuentes" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

p.MsoBodyTextIndent
	{margin-top:0cm;
	margin-right:0cm;
	margin-bottom:0cm;
	margin-left:35.4pt;
	margin-bottom:.0001pt;
	font-size:12.0pt;
	font-family:"Times New Roman";
	}
p.MsoNormal
	{margin-bottom:.0001pt;
	font-size:12.0pt;
	font-family:"Times New Roman";
	        margin-left: 0cm;
            margin-right: 0cm;
            margin-top: 0cm;
        }
    h2
	{margin-top:0cm;
	margin-right:0cm;
	margin-bottom:0cm;
	margin-left:35.4pt;
	margin-bottom:.0001pt;
	page-break-after:avoid;
	font-size:12.0pt;
	font-family:"Times New Roman";
	}
        .style1
        {
            text-align: justify;
            font-size: 12.0pt;
            font-family: "Times New Roman";
            font-weight: bold;
            margin-left: 0cm;
            margin-right: 0cm;
            margin-top: 0cm;
            margin-bottom: .0001pt;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <div style="font-family: 'Arial Unicode MS'; font-size: large">
        Preguntas Frecuentes</div>
    <ajaxToolkit:Accordion ID="MyAccordion" runat="server" SelectedIndex="0" HeaderCssClass="accordionHeader"
        HeaderSelectedCssClass="accordionHeaderSelected" ContentCssClass="accordionContent"
        FadeTransitions="false" FramesPerSecond="40" TransitionDuration="250" AutoSize="None"
        RequireOpenedPane="false" SuppressHeaderPostbacks="true">
        <Panes>
            <ajaxToolkit:AccordionPane ID="AccordionPane1" runat="server">
                <Header>
                    <a href="" class="accordionLink">1. ¿En forma resumida cuáles son los pasos para Ingresar
                        y aprobar una solicitud?</a></Header>
                <Content>
                    <p class="MsoNormal">
                        <![if !supportLists]><span lang="ES-MX" style="mso-ansi-language: ES-MX">a)<span
                            style="font: 7.0pt &quot; times new roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </span></span><![endif]><span lang="ES-MX" style="mso-ansi-language: ES-MX"> Agregue
                            un curso en Calendarización de Cursos<o:p></o:p></span></p>
                    <p class="MsoNormal">
                        <![if !supportLists]><span lang="ES-MX" style="mso-ansi-language: ES-MX">b)<span
                            style="font: 7.0pt &quot; times new roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </span></span><![endif]><span lang="ES-MX" style="mso-ansi-language: ES-MX"> Cambie
                            el estado del Curso a Matrícula<o:p></o:p></span></p>
                    <p class="MsoNormal">
                        <![if !supportLists]><span lang="ES-MX" style="mso-ansi-language: ES-MX">c)<span
                            style="font: 7.0pt &quot; times new roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </span></span><![endif]><span lang="ES-MX" style="mso-ansi-language: ES-MX">En Disponibilidad
                            de Curso busque el curso e ingrese las solicitudes<o:p></o:p></span></p>
                    <p class="MsoNormal">
                        <![if !supportLists]><span lang="ES-MX" style="mso-ansi-language: ES-MX">d)<span
                            style="font: 7.0pt &quot; times new roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </span></span><![endif]><span lang="ES-MX" style="mso-ansi-language: ES-MX">En evaluación
                            de solicitudes busque la solicitud y apruébela.<o:p></o:p></span></p>
                </Content>
            </ajaxToolkit:AccordionPane>
            <ajaxToolkit:AccordionPane ID="AccordionPane2" runat="server">
                <Header>
                    <a href="" class="accordionLink">2. ¿Cuáles son los pasos para Iniciar un Curso?</a></Header>
                <Content>
                    <p class="MsoNormal">
                        <![if !supportLists]><span lang="ES-MX" style="mso-ansi-language: ES-MX">a)<span
                            style="font: 7.0pt &quot; times new roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </span></span><![endif]><span lang="ES-MX" style="mso-ansi-language: ES-MX">En calendarización
                            de Cursos cambie el estado del curso a Iniciado (no deben existir solicitudes pendientes
                            de evaluar)<o:p></o:p></span></p>
                    <p class="MsoNormal">
                        <![if !supportLists]><span lang="ES-MX" style="mso-ansi-language: ES-MX">b)<span
                            style="font: 7.0pt &quot; times new roman&quot;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </span></span><![endif]><span lang="ES-MX" style="mso-ansi-language: ES-MX"> Genere
                            las listas de asistencia del curso<o:p></o:p></span></p>
                    <p class="MsoNormal">
                        <span lang="ES-MX" style="mso-ansi-language: ES-MX"><![if !supportEmptyParas]>&nbsp;<![endif]><o:p></o:p></span></p>
                </Content>
            </ajaxToolkit:AccordionPane>
            <ajaxToolkit:AccordionPane ID="AccordionPane3" runat="server">
                <Header>
                    <a href="" class="accordionLink">3. ¿Cuáles son los pasos para Finalizar o Cerrar un
                        curso?</a></Header>
                <Content>
                    <p class="MsoNormal">
                        <span lang="ES-MX" style="mso-ansi-language: ES-MX">En calendarización de Cursos busque
                            el curso y ciérrelo cuando este haya finalizado.<o:p></o:p></span></p>
                    <p class="MsoNormal">
                        <span lang="ES-MX" style="mso-ansi-language: ES-MX"><![if !supportEmptyParas]>&nbsp;<![endif]><o:p></o:p></span></p>
                </Content>
            </ajaxToolkit:AccordionPane>
            <ajaxToolkit:AccordionPane ID="AccordionPane4" runat="server">
                <Header>
                    <a href="" class="accordionLink">4. ¿Cómo consulto la Oferta Formativa aprobada?</a></Header>
                <Content>
                    <p class="MsoNormal">
                        <span lang="ES-MX" style="mso-ansi-language: ES-MX">Para consultar las ofertas formativas
                            o cursos que se tienen aprobados vaya a la opción <i>Consultas &gt;&gt; Oferta Formativa</i><b>.</b>
                            En esta página puede buscar cursos por Centro de Formación, Área de Formación, Curso
                            o Tema y ejercicio.<o:p></o:p></span></p>
                    <p class="MsoNormal">
                        <span lang="ES-MX" style="mso-ansi-language: ES-MX"><![if !supportEmptyParas]>&nbsp;<![endif]><o:p></o:p></span></p>
                </Content>
            </ajaxToolkit:AccordionPane>
            <ajaxToolkit:AccordionPane ID="AccordionPane5" runat="server">
                <Header>
                    <a href="" class="accordionLink">5. ¿Cómo inicio un curso?</a></Header>
                <Content>
                    <p class="MsoNormal">
                        <span lang="ES-MX" style="font-weight: normal">Para iniciar un nuevo curso</span><span
                            lang="ES-MX"> </span><span lang="ES-MX" style="font-weight: normal">seleccione la opción</span><span
                                lang="ES-MX"> </span><i><span lang="ES-MX" style="font-weight: normal">Centros de Formación
                                    &gt;&gt; Calendarización de Cursos</span></i><span lang="ES-MX">, </span>
                        <span lang="ES-MX" style="font-weight: normal">haga clic en el botón <i><u>Agregar</u></i>.
                            Complete el formulario que se muestra; después haga clic en <i><u>Agregar</u> </i>
                            para guardar el curso, este curso se encontrará en estado INGRESADO.
                            <o:p></o:p>
                        </span>
                    </p>
                </Content>
            </ajaxToolkit:AccordionPane>
            <ajaxToolkit:AccordionPane ID="AccordionPane6" runat="server">
                <Header>
                    <a href="" class="accordionLink">6. ¿Cómo puedo cambiar el horario o fechas de un curso
                        que esta en estado ingresado?</a></Header>
                <Content>
                    <p class="MsoNormal">
                        <span lang="ES-MX">Para volver a Calendarizar un curso ya ingresado</span><span lang="ES-MX"
                            style="font-weight: normal"> (Sólo aplica para cursos en estado INGRESADO)</span><span
                                lang="ES-MX"> </span><span lang="ES-MX" style="font-weight: normal">seleccione la opción</span><span
                                    lang="ES-MX"> </span><i><span lang="ES-MX" style="font-weight: normal">Centros de Formación
                                        &gt;&gt; Calendarización de Cursos</span></i><span lang="ES-MX" style="font-weight: normal">,
                                            busque el curso que se encuentra en estado INGRESADO, una vez encontrado el curso
                                            haga clic en la opción <i><u>Editar</u></i> ubicada en la primera columna. Edite
                                            la información pertinente. Haga clic en <i><u>Actualizar</u></i> para guardar los
                                            cambios<o:p></o:p></span>
                    </p>
                </Content>
            </ajaxToolkit:AccordionPane>
            <ajaxToolkit:AccordionPane ID="AccordionPane7" runat="server">
                <Header>
                    <a href="" class="accordionLink">7. ¿Cómo puedo ingresar una solicitud a un curso?</a></Header>
                <Content>
                    <p class="MsoNormal">
                        <b><span lang="ES-MX"><![if !supportEmptyParas]>&nbsp;<![endif]><o:p></o:p></span></b></p>
                    <p class="MsoNormal">
                        <b><span lang="ES-MX">a) Para Cambiar de estado un curso </span></b><span lang="ES-MX">
                            seleccione la opción <i>Centros de Formación &gt;&gt; Calendarización de Cursos</i>,
                            busque el curso deseado. Buscar los cursos con estado ingresado una vez encontrado
                            puede cambiar su estado haciendo clic en la columna "Cambiar a" como se presenta en la
                            siguiente imagen:</span></p>
                    <p class="MsoNormal">
                        <span lang="ES-MX"><![if !supportEmptyParas]>&nbsp;<![endif]><o:p></o:p></span></p>
                    <p class="MsoNormal">
                        <span lang="ES-MX">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/calendarizarCursos.gif" /></span></p>
                    <p class="MsoNormal">
                        <span lang="ES-MX"><![if !supportEmptyParas]>&nbsp;<![endif]><o:p></o:p></span></p>
                    <p class="MsoNormal">
                        <span lang="ES-MX">Haga clic en la columna "Cambiar a" en la opción que dice <i>Matrícula</i>,
                            con ello el curso pasará al estado de matricula y permitirá ingresar las solicitudes
                            correspondientes.</span></p>
                    <p class="MsoNormal">
                        <b><span lang="ES-MX" style="mso-ansi-language: ES-MX">b) Para ingresar solicitudes
                            para un curso </span></b><span lang="ES-MX" style="mso-ansi-language: ES-MX">seleccione
                                la opción <i>Cursos de Formación &gt;&gt; Disponibilidad de Cursos.</i> Busque el
                                curso deseado haga clic en la opción Ingresar solicitud. Llene la solicitud que
                                se le presenta (recuerde llenar las opciones ubicadas en la parte superior de la
                                solicitud, también recuerde que cuenta con una búsqueda por DUI NIT para comprobar
                                si ya existe el participante) luego haga clic en el botón <i>Enviar solicitud</i>.
                                Esta solicitud podrá consultarla en la consulta de solicitudes.<o:p></o:p></span></p>
                    <p class="MsoNormal">
                        <span lang="ES-MX" style="mso-ansi-language: ES-MX"><![if !supportEmptyParas]>&nbsp;<![endif]><o:p></o:p></span></p>
                    <p class="MsoNormal">
                        <b><span lang="ES-MX" style="mso-ansi-language: ES-MX">c) Para consultar o modificar
                            una solicitud ya ingresada </span></b><span lang="ES-MX" style="mso-ansi-language: ES-MX">
                                seleccione la opción <i>Centros de Formación &gt;&gt; Consulta de Solicitudes, </i>
                                busque la solicitud deseada utilizando los filtros de búsqueda de ser necesario.
                                Sólo podrá modificar una solicitud que se encuentre en estado “Ingresada” o “En
                                estado de aprobación”. Una vez encontrada la solicitud haga clic en la opción <i><u>
                                    Solicitud</u></i>. Haga los cambios respectivos en el formulario y luego haga
                                clic en el botón Enviar solicitud.
                                <o:p></o:p>
                            </span>
                    </p>
                    <p class="MsoNormal">
                        <b><span lang="ES-MX" style="mso-ansi-language: ES-MX"><![if !supportEmptyParas]> &nbsp;<![endif]><o:p></o:p></span></b></p>
                </Content>
            </ajaxToolkit:AccordionPane>
            <ajaxToolkit:AccordionPane ID="AccordionPane8" runat="server">
                <Header>
                    <a href="" class="accordionLink">8. ¿Cómo doy inicio a un curso cuando ya he ingresado
                        todas las solicitudes?</a></Header>
                <Content>
                    <p class="MsoNormal">
                        <span lang="ES-MX" style="mso-ansi-language: ES-MX">Primeramente debe evaluar todas
                            las solicitudes antes de iniciar el curso<b>, </b><span style="mso-bidi-font-weight: bold">
                                para lo cual </span>seleccione la opción <i>Centros de Formación &gt;&gt; Evaluación
                                    de Solicitudes, </i>busque la(s) solicitud(es) a evaluar utilizando los
                            filtros de búsqueda de ser necesario. Una vez encontrada la(s) solicitud(es) haga
                            clic en la opción <i><u>Seleccionar</u></i> si lo desea puede ver detalle de la
                            solicitud y los cursos solicitados. Haga clic en la ficha <i><u>Evaluación</u></i>
                            ubicada en la parte superior. En la sección que se muestra puede <b>Aprobar</b>,
                            <b>Rechazar</b> o poner <b>en espera</b> la solicitud.
                            <o:p></o:p>
                        </span>
                    </p>
                    <p class="MsoNormal">
                        <span lang="ES-MX" style="mso-ansi-language: ES-MX">Una vez que todas las solicitudes
                            estén evaluadas inicie el curso de la siguiente forma: Diríjase a la opción <i>Centros
                                de Formación &gt;&gt; Evaluación de Solicitudes</i> filtre los cursos por el
                            estado <i>EN MATRICULA</i>, busque el curso deseado y haga clic en la última columna
                            en la opción <i>Iniciar Curso</i>.<o:p></o:p></span></p>
                    <p class="MsoNormal">
                        <span lang="ES-MX" style="mso-ansi-language: ES-MX"><![if !supportEmptyParas]>&nbsp;<![endif]><o:p></o:p></span></p>
                </Content>
            </ajaxToolkit:AccordionPane>
            <ajaxToolkit:AccordionPane ID="AccordionPane9" runat="server">
                <Header>
                    <a href="" class="accordionLink">9. ¿Cómo ingreso la asistencia de cada participante
                        en el sistema?</a></Header>
                <Content>
                    <p class="MsoNormal">
                        <b><span lang="ES-MX" style="mso-ansi-language: ES-MX">a) Genere el listado de asistencia</span></b><span
                            lang="ES-MX" style="mso-ansi-language: ES-MX">. Seleccione la opción <i>Centros de Formación
                                &gt;&gt; Asistencia Cursos, </i>busque el curso deseado utilizando los filtros
                            de búsqueda. Una vez encontrado el curso haga clic en la opción <i><u>Seleccionar</u></i>
                            después haga clic en la opción <i>Listados de Asistencia.<o:p></o:p></i></span></p>
                    <p class="MsoNormal">
                        <i><span lang="ES-MX" style="mso-ansi-language: ES-MX"><![if !supportEmptyParas]> &nbsp;<![endif]><o:p></o:p></span></i></p>
                    <p class="MsoNormal">
                        <span lang="ES-MX" style="mso-ansi-language: ES-MX">Ahora usted puede hacer que el sistema
                            genere un listado automáticamente haciendo clic en botón <i>Generar Asistencia</i>
                            <i>
                                <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/botonGenerar.PNG" /><span style="mso-spacerun: yes">&nbsp;</span></i>o
                            usted mismo puede agregar manualmente la asistencia por cada día del curso mediante
                            el botón Agregar. <i>
                                <asp:Image ID="Image3" runat="server" ImageUrl="~/imagenes/botonAgregar.PNG" /><o:p></o:p></i></span></p>
                    <p class="MsoNormal">
                        <i><span lang="ES-MX" style="mso-ansi-language: ES-MX"><![if !supportEmptyParas]> &nbsp;<![endif]><o:p></o:p></span></i></p>
                    <p class="MsoNormal">
                        <b><span lang="ES-MX" style="font-size: 10.0pt; mso-bidi-font-size: 12.0pt; mso-ansi-language: ES-MX">
                            Si usted selecciona la opción <i>Generar asistencia</i> el sistema generara todos
                            los días comprendidos entre la fecha inicial y final que dura el curso. Solo podrá
                            ejecutar un tipo de generación (automática /manual) una vez, no podrá volver a ejecutar
                            la misma u otra diferente.<o:p></o:p></span></b></p>
                    <p class="MsoNormal">
                        <b><span lang="ES-MX" style="mso-ansi-language: ES-MX"><![if !supportEmptyParas]> &nbsp;<![endif]><o:p></o:p></span></b></p>
                    <p class="MsoNormal">
                        <b><span lang="ES-MX" style="mso-ansi-language: ES-MX">b) Registre la asistencia /no
                            asistencia de cada participante</span></b><span lang="ES-MX" style="mso-ansi-language: ES-MX">.
                                Una vez que haya elegido el método para generar el listado de asistencia (literal
                                a) en la opción <i>Listados de Asistencia </i>seleccione el día sobre el cual desea
                                registrar la asistencia. Por defecto todos los participantes aparecen como que han
                                asistido; desmarque la columna <i>asistió</i> si algún participante no ha asistido
                                al curso. Marque el cuadrito en la columna <i>justificó</i> si el participante no
                                asistió y tiene una justificación. Para terminar haga clic en <i>Actualizar</i>.<o:p></o:p></span></p>
                </Content>
            </ajaxToolkit:AccordionPane>
            <ajaxToolkit:AccordionPane ID="AccordionPane10" runat="server">
                <Header>
                    <a href="" class="accordionLink">10. ¿Cómo imprimo la lista de asistencia para firma?</a></Header>
                <Content>
                    <p class="MsoNormal">
                        <span lang="ES-MX" style="mso-ansi-language: ES-MX">Seleccione la opción <i>Centros
                            de Formación &gt;&gt; Asistencia Cursos, </i>busque el curso deseado utilizando
                            los filtros de búsqueda. Una vez encontrado el curso haga clic en la opción <i><u>Seleccionar</u></i>
                            después haga clic en la opción <i>Listados de Asistencia y haga clic en el botón Lista
                                para firma.</i> Se mostrará una página con el formato por día para que lo imprima.<o:p></o:p></span></p>
                </Content>
            </ajaxToolkit:AccordionPane>
        </Panes>
    </ajaxToolkit:Accordion>
</asp:Content>


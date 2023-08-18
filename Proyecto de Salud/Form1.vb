Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        Dim nombre As String = txtNombre.Text
        Dim sintoma As String = ""
        Dim nivel As String = ""


        If rbMareado.Checked Then
            sintoma = "mareado"
        ElseIf rbGanasDeVomitar.Checked Then
            sintoma = "ganas de vomitar"
        ElseIf rbFiebre.Checked Then
            sintoma = "fiebre"
        ElseIf rbDoloresMusculares.Checked Then
            sintoma = "dolores musculares"
        ElseIf rbFatiga.Checked Then
            sintoma = "fatiga"
        ElseIf rbResfriadoLeve.Checked Then
            sintoma = "Resfriado leve"

        ElseIf rbPicaduraDeInsecto.Checked Then
            sintoma = "Picadura de insecto"
        ElseIf rbLesion.Checked Then
            sintoma = "Lesion deportiva leve (torcedura o distension"
        ElseIf rbAcidez.Checked Then
            sintoma = "Acidez estomacal cronica"
        ElseIf rbInfeccion.Checked Then
            sintoma = "Infeccion de garganta y fiebre moderada"
        ElseIf rbInsomnio.Checked Then
            sintoma = "Insomnio ocasional"
        ElseIf rbHipertension.Checked Then
            sintoma = "Hipertension arterial"
        ElseIf rbSobrepeso.Checked Then
            sintoma = "Sobrepeso moderado"
        ElseIf rbAnsiedad.Checked Then
            sintoma = "Ansiedad moderada"
        ElseIf rbCancer.Checked Then
            sintoma = "Cancer en etapa avanzada"
        ElseIf rbCardiovascular.Checked Then
            sintoma = "Enfermedad cardiovascular avanzada"
        ElseIf rbDiabetes.Checked Then
            sintoma = "Diabetes tipo 2 mal controlada"
        ElseIf rbMental.Checked Then
            sintoma = "Transtorno mental grave (por ejemplo, la esquizofrenia)"

        End If


        If rbBajo.Checked Then
            nivel = "bajo"
        ElseIf rbMedio.Checked Then
            nivel = "medio"
        ElseIf rbAlto.Checked Then
            nivel = "alto"
        End If


        Dim resultado As String = ""

        Select Case sintoma
            Case "mareado"
                Select Case nivel
                    Case "bajo"
                        resultado = "Descanse en casa."
                    Case "medio"
                        resultado = "Tome un acetaminofén y descanse."
                    Case "alto"
                        resultado = "Necesita hospitalización."
                End Select

            Case "ganas de vomitar"
                Select Case nivel
                    Case "bajo"
                        resultado = "Oler alcohol."
                    Case "medio"
                        resultado = "Tomar una pastilla gástrica."
                    Case "alto"
                        resultado = "Tomar una pastilla y estar en supervisión."
                End Select
            Case "fiebre"
                Select Case nivel
                    Case "bajo"
                        resultado = "Tomar una aspirina."
                    Case "medio"
                        resultado = "Aplicar una inyección."
                    Case "alto"
                        resultado = "Necesita hospitalización."
                End Select
            Case "dolores musculares"
                Select Case nivel
                    Case "bajo"
                        resultado = "Aplicar una crema."
                    Case "medio"
                        resultado = "Tomar un calmante."
                    Case "alto"
                        resultado = "Recibir sesiones de masajes."
                End Select
            Case "fatiga"
                Select Case nivel
                    Case "bajo"
                        resultado = "Proporcionar oxígeno."
                    Case "medio"
                        resultado = "Usar un respirador."
                    Case "alto"
                        resultado = "Necesita hospitalización."
                End Select

            Case "Resfriado leve"
                Select Case nivel
                    Case "bajo"
                        resultado = "Descanso para permitir que el sistema inmunológico combata el virus, 
                                     hidratación para mantener las membranas mucosas y medicamentos como el paracetamol para reducir la fiebre y el malestar."
                    Case "medio"
                        resultado = "Además de las soluciones en el nivel bajo, asegúrate de tener una ingesta adecuada de vitamina C y zinc, 
                                     que pueden ayudar a fortalecer el sistema inmunológico."
                    Case "alto"
                        resultado = "Si los síntomas no mejoran después de varios días o empeoran, 
                                     es importante consultar a un médico para evitar complicaciones como infecciones secundarias."
                End Select

            Case "Picadura de insecto"
                Select Case nivel
                    Case "bajo"
                        resultado = "Lave la zona afectada con agua y jabón para reducir el riesgo de infección, 
                                     y aplique una crema tópica con antihistamínicos para aliviar la picazón y la inflamación."
                    Case "medio"
                        resultado = "Además de las soluciones en el nivel bajo, 
                                     considera la aplicación de compresas frías para vasoconstricción localizada y reducción de la inflamación."
                    Case "alto"
                        resultado = "Si se desarrolla una reacción alérgica grave, 
                                     busca atención médica inmediata para evitar complicaciones sistémicas."
                End Select

            Case "Lesion deportiva leve (torcedura o distension"
                Select Case nivel
                    Case "bajo"
                        resultado = "Aplicar hielo para reducir la inflamación local, compresión para controlar la hinchazón, 
                                     elevación para mejorar el retorno venoso y analgésicos para aliviar el dolor."
                    Case "medio"
                        resultado = "Además de las soluciones en el nivel bajo, 
                                     considera la realización de ejercicios de rehabilitación y fortalecimiento supervisados por un fisioterapeuta."
                    Case "alto"
                        resultado = "Si la lesión es grave o no mejora con el tratamiento conservador, 
                                     busca atención médica para evitar daños a largo plazo."
                End Select

            Case "Acidez estomacal cronica"
                Select Case nivel
                    Case "bajo"
                        resultado = "Modificar la dieta para evitar alimentos que desencadenan la acidez, 
                                     medicamentos antiácidos para neutralizar el exceso de ácido gástrico y 
                                     elevar la cabecera de la cama durante el sueño para prevenir el reflujo."
                    Case "medio"
                        resultado = "Además de las soluciones en el nivel bajo, 
                                     considera la incorporación de probióticos para mejorar la salud gastrointestinal y 
                                     el manejo del estrés para reducir la producción de ácido."
                    Case "alto"
                        resultado = "Si la acidez es severa o persistente, 
                                     busca orientación médica para descartar condiciones subyacentes como el reflujo gastroesofágico crónico."
                End Select

            Case "Infeccion de garganta y fiebre moderada"
                Select Case nivel
                    Case "bajo"
                        resultado = "Antibióticos (si la infección es bacteriana) bajo prescripción médica, 
                                     hidratación para mantener la humedad de las membranas mucosas y 
                                     descanso para permitir que el sistema inmunológico combata la infección."
                    Case "medio"
                        resultado = "Además de las soluciones en el nivel bajo, 
                                     considera el consumo de alimentos ricos en antioxidantes como vitamina C y 
                                     zinc para apoyar el sistema inmunológico."
                    Case "alto"
                        resultado = "Si la fiebre persiste o los síntomas empeoran, 
                                     es importante consultar a un médico para obtener un diagnóstico preciso y ajuste en el tratamiento."
                End Select

            Case "Cancer en etapa avanzada"
                Select Case nivel
                    Case "bajo"
                        resultado = "Mantener una dieta saludable, realizar ejercicio regular y acudir a chequeos médicos regulares para detección temprana."
                    Case "medio"
                        resultado = "Además de las soluciones en el nivel bajo, 
                                     el tratamiento del cáncer en etapa avanzada puede incluir cirugía, 
                                     radioterapia, quimioterapia y terapias dirigidas según lo determine un oncólogo."
                    Case "alto"
                        resultado = "En el caso del cáncer en etapa avanzada, 
                                     es esencial trabajar con un equipo médico multidisciplinario que incluya oncólogos, 
                                     cirujanos y especialistas en cuidados paliativos para abordar el tratamiento y la calidad de vida."
                End Select

            Case "Enfermedad cardiovascular avanzada"
                Select Case nivel
                    Case "bajo"
                        resultado = "Mantener una dieta baja en sodio y grasas saturadas,
                                     realizar ejercicio regular y evitar el tabaco."
                    Case "medio"
                        resultado = "Además de las soluciones en el nivel bajo, 
                                     es fundamental tomar medicamentos recetados por un cardiólogo y 
                                     someterse a procedimientos médicos como cateterismos y cirugías si son necesarios."
                    Case "alto"
                        resultado = "Las enfermedades cardiovasculares avanzadas requieren una atención médica especializada. 
                                     Un cardiólogo desarrollará un plan de tratamiento integral que puede incluir medicamentos, 
                                     terapia de rehabilitación cardíaca y seguimiento constante."

                End Select

            Case "Diabetes tipo 2 mal controlada"
                Select Case nivel
                    Case "bajo"
                        resultado = "Mantener una dieta saludable y realizar actividad física regular para controlar los niveles de azúcar en sangre."
                    Case "medio"
                        resultado = "Además de las soluciones en el nivel bajo, 
                                     considera la monitorización constante de los niveles de glucosa, 
                                     la administración adecuada de medicamentos y la consulta regular con un endocrinólogo."
                    Case "alto"
                        resultado = " La diabetes tipo 2 mal controlada puede llevar a complicaciones graves. 
                                      Busca el apoyo de un equipo médico que incluya un endocrinólogo, 
                                      un dietista y un educador en diabetes para un manejo completo y personalizado."
                End Select

            Case "Transtorno mental grave (por ejemplo, la esquizofrenia)"
                Select Case nivel
                    Case "bajo"
                        resultado = "Buscar apoyo de familiares y amigos, mantener un estilo de vida saludable y 
                                     practicar técnicas de manejo del estrés."
                    Case "medio"
                        resultado = "Además de las soluciones en el nivel bajo, es fundamental recibir tratamiento psiquiátrico y 
                                     psicoterapia de un profesional de la salud mental."
                    Case "alto"
                        resultado = " Los trastornos mentales graves requieren intervenciones terapéuticas intensivas y 
                                      posiblemente medicamentos psicotrópicos. 
                                      Es crucial buscar atención de psiquiatras y psicoterapeutas experimentados."
                End Select

            Case "Insomnio ocasional"
                Select Case nivel
                    Case "bajo"
                        resultado = "Establecer una rutina de sueño regular, crear un ambiente propicio para dormir (oscuridad, silencio, temperatura adecuada) y 
                                     evitar estimulantes como la cafeína antes de acostarse."
                    Case "medio"
                        resultado = "Además de las soluciones en el nivel bajo, considera técnicas de relajación como la meditación y 
                                     el yoga para promover la relajación antes de dormir."
                    Case "alto"
                        resultado = "Si el insomnio persiste y afecta tu bienestar, consulta a un médico para evaluar posibles trastornos del sueño y 
                                     recibir orientación sobre opciones de tratamiento."
                End Select
            Case "Hipertension arterial"
                Select Case nivel
                    Case "bajo"
                        resultado = "Modificar la dieta para reducir la ingesta de sodio y grasas saturadas, 
                                     realizar actividad física regular y mantener un peso saludable."
                    Case "medio"
                        resultado = "Además de las soluciones en el nivel bajo, considera la medición regular de la presión arterial en casa y 
                                     la posible necesidad de medicamentos bajo prescripción médica."
                    Case "alto"
                        resultado = "Si la hipertensión es persistente y no responde a cambios en el estilo de vida, 
                                     es esencial consultar a un médico para evitar complicaciones cardiovasculares."
                End Select
            Case "Sobrepeso moderado"
                Select Case nivel
                    Case "bajo"
                        resultado = "Mantener una dieta balanceada con un déficit calórico, realizar ejercicio regular y 
                                     evitar el consumo excesivo de alimentos procesados y azúcares."
                    Case "medio"
                        resultado = "Además de las soluciones en el nivel bajo, 
                                     considera la asesoría de un nutricionista para desarrollar un plan alimenticio adecuado a tus necesidades y metas."
                    Case "alto"
                        resultado = "Si el sobrepeso se asocia con problemas de salud, 
                                     consulta a un profesional de la salud para recibir una evaluación completa y apoyo en la pérdida de peso."
                End Select

            Case "Ansiedad moderada"
                Select Case nivel
                    Case "bajo"
                        resultado = " Practicar la exposición gradual a situaciones que generan ansiedad, mantener una dieta saludable y 
                                      realizar actividad física regular para liberar endorfinas y mejorar el estado de ánimo."
                    Case "medio"
                        resultado = "Además de las soluciones en el nivel bajo, 
                                     considera la terapia cognitivo-conductual (TCC) con un terapeuta para aprender estrategias de manejo de la ansiedad."
                    Case "alto"
                        resultado = "Si la ansiedad interfiere significativamente con las actividades diarias, 
                                     busca la ayuda de un profesional de la salud mental para recibir un tratamiento adecuado y terapia."
                End Select

        End Select

        lblResultado.Text = $"Estimado(a) {nombre}, basado en su síntoma de {sintoma} y su nivel de molestia {nivel}, se le recomienda: {resultado}"

    End Sub


End Class
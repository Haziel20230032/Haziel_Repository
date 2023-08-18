<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        tabControl = New TabControl()
        tabChequeo = New TabPage()
        PictureBox1 = New PictureBox()
        btnCheck = New Button()
        txtNombre = New TextBox()
        lblNombre = New Label()
        gpNivel = New GroupBox()
        rbAlto = New RadioButton()
        rbMedio = New RadioButton()
        rbBajo = New RadioButton()
        gbSintomas = New GroupBox()
        rbMental = New RadioButton()
        rbCancer = New RadioButton()
        rbCardiovascular = New RadioButton()
        rbDiabetes = New RadioButton()
        rbSobrepeso = New RadioButton()
        rbHipertension = New RadioButton()
        rbAnsiedad = New RadioButton()
        rbInsomnio = New RadioButton()
        rbAcidez = New RadioButton()
        rbLesion = New RadioButton()
        rbInfeccion = New RadioButton()
        rbPicaduraDeInsecto = New RadioButton()
        rbResfriadoLeve = New RadioButton()
        rbFatiga = New RadioButton()
        rbDoloresMusculares = New RadioButton()
        rbFiebre = New RadioButton()
        rbGanasDeVomitar = New RadioButton()
        rbMareado = New RadioButton()
        tabResultado = New TabPage()
        lblResultado = New Label()
        tabControl.SuspendLayout()
        tabChequeo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        gpNivel.SuspendLayout()
        gbSintomas.SuspendLayout()
        tabResultado.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabControl
        ' 
        tabControl.Controls.Add(tabChequeo)
        tabControl.Controls.Add(tabResultado)
        tabControl.Location = New Point(12, 12)
        tabControl.Name = "tabControl"
        tabControl.SelectedIndex = 0
        tabControl.Size = New Size(1782, 681)
        tabControl.TabIndex = 0
        ' 
        ' tabChequeo
        ' 
        tabChequeo.BackColor = Color.LightCoral
        tabChequeo.Controls.Add(PictureBox1)
        tabChequeo.Controls.Add(btnCheck)
        tabChequeo.Controls.Add(txtNombre)
        tabChequeo.Controls.Add(lblNombre)
        tabChequeo.Controls.Add(gpNivel)
        tabChequeo.Controls.Add(gbSintomas)
        tabChequeo.Location = New Point(4, 34)
        tabChequeo.Name = "tabChequeo"
        tabChequeo.Padding = New Padding(3)
        tabChequeo.Size = New Size(1774, 643)
        tabChequeo.TabIndex = 0
        tabChequeo.Text = "Consulta"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Medi
        PictureBox1.Location = New Point(1146, 214)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(567, 379)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btnCheck
        ' 
        btnCheck.Location = New Point(1150, 140)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(150, 34)
        btnCheck.TabIndex = 4
        btnCheck.Text = "Check"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(1150, 71)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(150, 31)
        txtNombre.TabIndex = 3
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(1150, 43)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(78, 25)
        lblNombre.TabIndex = 2
        lblNombre.Text = "Nombre"
        ' 
        ' gpNivel
        ' 
        gpNivel.Controls.Add(rbAlto)
        gpNivel.Controls.Add(rbMedio)
        gpNivel.Controls.Add(rbBajo)
        gpNivel.Font = New Font("Stencil", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        gpNivel.Location = New Point(23, 362)
        gpNivel.Name = "gpNivel"
        gpNivel.Size = New Size(1100, 269)
        gpNivel.TabIndex = 1
        gpNivel.TabStop = False
        gpNivel.Text = "Nivel"
        ' 
        ' rbAlto
        ' 
        rbAlto.AutoSize = True
        rbAlto.Font = New Font("Stencil", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        rbAlto.Location = New Point(7, 155)
        rbAlto.Name = "rbAlto"
        rbAlto.Size = New Size(78, 25)
        rbAlto.TabIndex = 2
        rbAlto.TabStop = True
        rbAlto.Text = "Alto"
        rbAlto.UseVisualStyleBackColor = True
        ' 
        ' rbMedio
        ' 
        rbMedio.AutoSize = True
        rbMedio.Font = New Font("Stencil", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        rbMedio.Location = New Point(8, 100)
        rbMedio.Name = "rbMedio"
        rbMedio.Size = New Size(90, 25)
        rbMedio.TabIndex = 1
        rbMedio.TabStop = True
        rbMedio.Text = "Medio"
        rbMedio.UseVisualStyleBackColor = True
        ' 
        ' rbBajo
        ' 
        rbBajo.AutoSize = True
        rbBajo.Font = New Font("Stencil", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        rbBajo.Location = New Point(8, 51)
        rbBajo.Name = "rbBajo"
        rbBajo.Size = New Size(79, 25)
        rbBajo.TabIndex = 0
        rbBajo.TabStop = True
        rbBajo.Text = "Bajo"
        rbBajo.UseVisualStyleBackColor = True
        ' 
        ' gbSintomas
        ' 
        gbSintomas.Controls.Add(rbMental)
        gbSintomas.Controls.Add(rbCancer)
        gbSintomas.Controls.Add(rbCardiovascular)
        gbSintomas.Controls.Add(rbDiabetes)
        gbSintomas.Controls.Add(rbSobrepeso)
        gbSintomas.Controls.Add(rbHipertension)
        gbSintomas.Controls.Add(rbAnsiedad)
        gbSintomas.Controls.Add(rbInsomnio)
        gbSintomas.Controls.Add(rbAcidez)
        gbSintomas.Controls.Add(rbLesion)
        gbSintomas.Controls.Add(rbInfeccion)
        gbSintomas.Controls.Add(rbPicaduraDeInsecto)
        gbSintomas.Controls.Add(rbResfriadoLeve)
        gbSintomas.Controls.Add(rbFatiga)
        gbSintomas.Controls.Add(rbDoloresMusculares)
        gbSintomas.Controls.Add(rbFiebre)
        gbSintomas.Controls.Add(rbGanasDeVomitar)
        gbSintomas.Controls.Add(rbMareado)
        gbSintomas.Location = New Point(23, 27)
        gbSintomas.Name = "gbSintomas"
        gbSintomas.Size = New Size(1100, 327)
        gbSintomas.TabIndex = 0
        gbSintomas.TabStop = False
        gbSintomas.Text = "Sintomas"
        ' 
        ' rbMental
        ' 
        rbMental.AutoSize = True
        rbMental.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbMental.Location = New Point(545, 279)
        rbMental.Name = "rbMental"
        rbMental.Size = New Size(468, 24)
        rbMental.TabIndex = 17
        rbMental.TabStop = True
        rbMental.Text = "Transtorno mental grave (por ejemplo, la esquizofrenia)"
        rbMental.UseVisualStyleBackColor = True
        ' 
        ' rbCancer
        ' 
        rbCancer.AutoSize = True
        rbCancer.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbCancer.Location = New Point(796, 170)
        rbCancer.Name = "rbCancer"
        rbCancer.Size = New Size(237, 24)
        rbCancer.TabIndex = 16
        rbCancer.TabStop = True
        rbCancer.Text = "Cancer en etapa avanzada"
        rbCancer.UseVisualStyleBackColor = True
        ' 
        ' rbCardiovascular
        ' 
        rbCardiovascular.AutoSize = True
        rbCardiovascular.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbCardiovascular.Location = New Point(688, 113)
        rbCardiovascular.Name = "rbCardiovascular"
        rbCardiovascular.Size = New Size(324, 24)
        rbCardiovascular.TabIndex = 15
        rbCardiovascular.TabStop = True
        rbCardiovascular.Text = "Enfermedad cardiovascular avanzada"
        rbCardiovascular.UseVisualStyleBackColor = True
        ' 
        ' rbDiabetes
        ' 
        rbDiabetes.AutoSize = True
        rbDiabetes.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbDiabetes.Location = New Point(688, 62)
        rbDiabetes.Name = "rbDiabetes"
        rbDiabetes.Size = New Size(273, 24)
        rbDiabetes.TabIndex = 14
        rbDiabetes.TabStop = True
        rbDiabetes.Text = "Diabetes tipo 2 mal controlada"
        rbDiabetes.UseVisualStyleBackColor = True
        ' 
        ' rbSobrepeso
        ' 
        rbSobrepeso.AutoSize = True
        rbSobrepeso.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbSobrepeso.Location = New Point(644, 220)
        rbSobrepeso.Name = "rbSobrepeso"
        rbSobrepeso.Size = New Size(198, 24)
        rbSobrepeso.TabIndex = 13
        rbSobrepeso.TabStop = True
        rbSobrepeso.Text = "Sobrepeso moderado"
        rbSobrepeso.UseVisualStyleBackColor = True
        ' 
        ' rbHipertension
        ' 
        rbHipertension.AutoSize = True
        rbHipertension.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbHipertension.Location = New Point(594, 170)
        rbHipertension.Name = "rbHipertension"
        rbHipertension.Size = New Size(195, 24)
        rbHipertension.TabIndex = 12
        rbHipertension.TabStop = True
        rbHipertension.Text = "Hipertension arterial"
        rbHipertension.UseVisualStyleBackColor = True
        ' 
        ' rbAnsiedad
        ' 
        rbAnsiedad.AutoSize = True
        rbAnsiedad.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbAnsiedad.Location = New Point(479, 113)
        rbAnsiedad.Name = "rbAnsiedad"
        rbAnsiedad.Size = New Size(189, 24)
        rbAnsiedad.TabIndex = 11
        rbAnsiedad.TabStop = True
        rbAnsiedad.Text = "Ansiedad moderada"
        rbAnsiedad.UseVisualStyleBackColor = True
        ' 
        ' rbInsomnio
        ' 
        rbInsomnio.AutoSize = True
        rbInsomnio.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbInsomnio.Location = New Point(479, 62)
        rbInsomnio.Name = "rbInsomnio"
        rbInsomnio.Size = New Size(186, 24)
        rbInsomnio.TabIndex = 10
        rbInsomnio.TabStop = True
        rbInsomnio.Text = "Insomnio ocasional"
        rbInsomnio.UseVisualStyleBackColor = True
        ' 
        ' rbAcidez
        ' 
        rbAcidez.AutoSize = True
        rbAcidez.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbAcidez.Location = New Point(229, 279)
        rbAcidez.Name = "rbAcidez"
        rbAcidez.Size = New Size(230, 24)
        rbAcidez.TabIndex = 9
        rbAcidez.TabStop = True
        rbAcidez.Text = "Acidez estomacal cronica"
        rbAcidez.UseVisualStyleBackColor = True
        ' 
        ' rbLesion
        ' 
        rbLesion.AutoSize = True
        rbLesion.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbLesion.Location = New Point(228, 220)
        rbLesion.Name = "rbLesion"
        rbLesion.Size = New Size(390, 24)
        rbLesion.TabIndex = 8
        rbLesion.TabStop = True
        rbLesion.Text = "Lesion deportiva leve (torcedura o distension)"
        rbLesion.UseVisualStyleBackColor = True
        ' 
        ' rbInfeccion
        ' 
        rbInfeccion.AutoSize = True
        rbInfeccion.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbInfeccion.Location = New Point(228, 170)
        rbInfeccion.Name = "rbInfeccion"
        rbInfeccion.Size = New Size(348, 24)
        rbInfeccion.TabIndex = 7
        rbInfeccion.TabStop = True
        rbInfeccion.Text = "Infeccion de garganta y fiebre moderada"
        rbInfeccion.UseVisualStyleBackColor = True
        ' 
        ' rbPicaduraDeInsecto
        ' 
        rbPicaduraDeInsecto.AutoSize = True
        rbPicaduraDeInsecto.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbPicaduraDeInsecto.Location = New Point(228, 113)
        rbPicaduraDeInsecto.Name = "rbPicaduraDeInsecto"
        rbPicaduraDeInsecto.Size = New Size(185, 24)
        rbPicaduraDeInsecto.TabIndex = 6
        rbPicaduraDeInsecto.TabStop = True
        rbPicaduraDeInsecto.Text = "Picadura de insecto"
        rbPicaduraDeInsecto.UseVisualStyleBackColor = True
        ' 
        ' rbResfriadoLeve
        ' 
        rbResfriadoLeve.AutoSize = True
        rbResfriadoLeve.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbResfriadoLeve.Location = New Point(228, 62)
        rbResfriadoLeve.Name = "rbResfriadoLeve"
        rbResfriadoLeve.Size = New Size(144, 24)
        rbResfriadoLeve.TabIndex = 5
        rbResfriadoLeve.TabStop = True
        rbResfriadoLeve.Text = "Resfriado leve"
        rbResfriadoLeve.UseVisualStyleBackColor = True
        ' 
        ' rbFatiga
        ' 
        rbFatiga.AutoSize = True
        rbFatiga.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbFatiga.Location = New Point(2, 279)
        rbFatiga.Name = "rbFatiga"
        rbFatiga.Size = New Size(82, 24)
        rbFatiga.TabIndex = 4
        rbFatiga.TabStop = True
        rbFatiga.Text = "Fatiga"
        rbFatiga.UseVisualStyleBackColor = True
        ' 
        ' rbDoloresMusculares
        ' 
        rbDoloresMusculares.AutoSize = True
        rbDoloresMusculares.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbDoloresMusculares.Location = New Point(0, 220)
        rbDoloresMusculares.Name = "rbDoloresMusculares"
        rbDoloresMusculares.Size = New Size(187, 24)
        rbDoloresMusculares.TabIndex = 3
        rbDoloresMusculares.TabStop = True
        rbDoloresMusculares.Text = "Dolores Musculares"
        rbDoloresMusculares.UseVisualStyleBackColor = True
        ' 
        ' rbFiebre
        ' 
        rbFiebre.AutoSize = True
        rbFiebre.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbFiebre.Location = New Point(2, 170)
        rbFiebre.Name = "rbFiebre"
        rbFiebre.Size = New Size(82, 24)
        rbFiebre.TabIndex = 2
        rbFiebre.TabStop = True
        rbFiebre.Text = "Fiebre"
        rbFiebre.UseVisualStyleBackColor = True
        ' 
        ' rbGanasDeVomitar
        ' 
        rbGanasDeVomitar.AutoSize = True
        rbGanasDeVomitar.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbGanasDeVomitar.Location = New Point(1, 113)
        rbGanasDeVomitar.Name = "rbGanasDeVomitar"
        rbGanasDeVomitar.Size = New Size(172, 24)
        rbGanasDeVomitar.TabIndex = 1
        rbGanasDeVomitar.TabStop = True
        rbGanasDeVomitar.Text = "Ganas de vomitar"
        rbGanasDeVomitar.UseVisualStyleBackColor = True
        ' 
        ' rbMareado
        ' 
        rbMareado.AutoSize = True
        rbMareado.Font = New Font("Times New Roman", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        rbMareado.Location = New Point(4, 62)
        rbMareado.Name = "rbMareado"
        rbMareado.Size = New Size(104, 24)
        rbMareado.TabIndex = 0
        rbMareado.TabStop = True
        rbMareado.Text = "Mareado"
        rbMareado.UseVisualStyleBackColor = True
        ' 
        ' tabResultado
        ' 
        tabResultado.BackColor = Color.LightCoral
        tabResultado.Controls.Add(lblResultado)
        tabResultado.Location = New Point(4, 34)
        tabResultado.Name = "tabResultado"
        tabResultado.Padding = New Padding(3)
        tabResultado.Size = New Size(1774, 643)
        tabResultado.TabIndex = 1
        tabResultado.Text = "Resultado"
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(13, 43)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(90, 25)
        lblResultado.TabIndex = 0
        lblResultado.Text = "Resultado"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1752, 731)
        Controls.Add(tabControl)
        Name = "Form1"
        Text = "Form1"
        tabControl.ResumeLayout(False)
        tabChequeo.ResumeLayout(False)
        tabChequeo.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        gpNivel.ResumeLayout(False)
        gpNivel.PerformLayout()
        gbSintomas.ResumeLayout(False)
        gbSintomas.PerformLayout()
        tabResultado.ResumeLayout(False)
        tabResultado.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tabControl As TabControl
    Friend WithEvents tabChequeo As TabPage
    Friend WithEvents tabResultado As TabPage
    Friend WithEvents gbSintomas As GroupBox
    Friend WithEvents rbGanasDeVomitar As RadioButton
    Friend WithEvents rbMareado As RadioButton
    Friend WithEvents rbDoloresMusculares As RadioButton
    Friend WithEvents rbFiebre As RadioButton
    Friend WithEvents gpNivel As GroupBox
    Friend WithEvents rbBajo As RadioButton
    Friend WithEvents rbFatiga As RadioButton
    Friend WithEvents lblNombre As Label
    Friend WithEvents rbAlto As RadioButton
    Friend WithEvents rbMedio As RadioButton
    Friend WithEvents btnCheck As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents rbResfriadoLeve As RadioButton
    Friend WithEvents rbAcidez As RadioButton
    Friend WithEvents rbLesion As RadioButton
    Friend WithEvents rbInfeccion As RadioButton
    Friend WithEvents rbPicaduraDeInsecto As RadioButton
    Friend WithEvents rbAnsiedad As RadioButton
    Friend WithEvents rbInsomnio As RadioButton
    Friend WithEvents rbSobrepeso As RadioButton
    Friend WithEvents rbHipertension As RadioButton
    Friend WithEvents rbMental As RadioButton
    Friend WithEvents rbCancer As RadioButton
    Friend WithEvents rbCardiovascular As RadioButton
    Friend WithEvents rbDiabetes As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LSensTemp1 = New System.Windows.Forms.Label()
        Me.LSensTemp2 = New System.Windows.Forms.Label()
        Me.LMuestraSangre = New System.Windows.Forms.Label()
        Me.LSensGota3 = New System.Windows.Forms.Label()
        Me.LValvSelect = New System.Windows.Forms.Label()
        Me.LSensGota1 = New System.Windows.Forms.Label()
        Me.LSensGota2 = New System.Windows.Forms.Label()
        Me.LPinch2 = New System.Windows.Forms.Label()
        Me.LPinch3 = New System.Windows.Forms.Label()
        Me.LFiltroAire = New System.Windows.Forms.Label()
        Me.LPinch1 = New System.Windows.Forms.Label()
        Me.PBJar1 = New System.Windows.Forms.PictureBox()
        Me.PBJar2 = New System.Windows.Forms.PictureBox()
        Me.LSensColor = New System.Windows.Forms.Label()
        Me.LCeldaMedicion = New System.Windows.Forms.Label()
        Me.LValvPinch4 = New System.Windows.Forms.Label()
        Me.LSensVacio = New System.Windows.Forms.Label()
        Me.LBombaVac = New System.Windows.Forms.Label()
        Me.LSensPeso1 = New System.Windows.Forms.Label()
        Me.LSensPeso2 = New System.Windows.Forms.Label()
        Me.LSensPeso3 = New System.Windows.Forms.Label()
        Me.PBJar3 = New System.Windows.Forms.PictureBox()
        Me.BComienzo = New System.Windows.Forms.Button()
        CType(Me.PBJar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBJar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBJar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LSensTemp1
        '
        Me.LSensTemp1.AutoSize = True
        Me.LSensTemp1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LSensTemp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSensTemp1.Location = New System.Drawing.Point(12, 9)
        Me.LSensTemp1.Name = "LSensTemp1"
        Me.LSensTemp1.Size = New System.Drawing.Size(177, 20)
        Me.LSensTemp1.TabIndex = 0
        Me.LSensTemp1.Text = "Sensor de Temperatura"
        Me.LSensTemp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LSensTemp2
        '
        Me.LSensTemp2.AutoSize = True
        Me.LSensTemp2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LSensTemp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSensTemp2.Location = New System.Drawing.Point(785, 9)
        Me.LSensTemp2.Name = "LSensTemp2"
        Me.LSensTemp2.Size = New System.Drawing.Size(177, 20)
        Me.LSensTemp2.TabIndex = 1
        Me.LSensTemp2.Text = "Sensor de Temperatura"
        Me.LSensTemp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LMuestraSangre
        '
        Me.LMuestraSangre.BackColor = System.Drawing.Color.Firebrick
        Me.LMuestraSangre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LMuestraSangre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMuestraSangre.Location = New System.Drawing.Point(38, 113)
        Me.LMuestraSangre.Name = "LMuestraSangre"
        Me.LMuestraSangre.Size = New System.Drawing.Size(81, 46)
        Me.LMuestraSangre.TabIndex = 2
        Me.LMuestraSangre.Text = "Muestra de sangre"
        Me.LMuestraSangre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LSensGota3
        '
        Me.LSensGota3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LSensGota3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSensGota3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSensGota3.Location = New System.Drawing.Point(149, 119)
        Me.LSensGota3.Name = "LSensGota3"
        Me.LSensGota3.Size = New System.Drawing.Size(65, 35)
        Me.LSensGota3.TabIndex = 3
        Me.LSensGota3.Text = "Sensor de gota 3"
        Me.LSensGota3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LValvSelect
        '
        Me.LValvSelect.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LValvSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LValvSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LValvSelect.Location = New System.Drawing.Point(259, 106)
        Me.LValvSelect.Name = "LValvSelect"
        Me.LValvSelect.Size = New System.Drawing.Size(101, 53)
        Me.LValvSelect.TabIndex = 4
        Me.LValvSelect.Text = "Válvula selectora"
        Me.LValvSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LSensGota1
        '
        Me.LSensGota1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LSensGota1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSensGota1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSensGota1.Location = New System.Drawing.Point(225, 200)
        Me.LSensGota1.Name = "LSensGota1"
        Me.LSensGota1.Size = New System.Drawing.Size(65, 35)
        Me.LSensGota1.TabIndex = 5
        Me.LSensGota1.Text = "Sensor de gota 1"
        Me.LSensGota1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LSensGota2
        '
        Me.LSensGota2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LSensGota2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSensGota2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSensGota2.Location = New System.Drawing.Point(315, 200)
        Me.LSensGota2.Name = "LSensGota2"
        Me.LSensGota2.Size = New System.Drawing.Size(65, 35)
        Me.LSensGota2.TabIndex = 6
        Me.LSensGota2.Text = "Sensor de gota 2"
        Me.LSensGota2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LPinch2
        '
        Me.LPinch2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LPinch2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LPinch2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPinch2.Location = New System.Drawing.Point(387, 54)
        Me.LPinch2.Name = "LPinch2"
        Me.LPinch2.Size = New System.Drawing.Size(65, 35)
        Me.LPinch2.TabIndex = 7
        Me.LPinch2.Text = "Válvula Pinch 2"
        Me.LPinch2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LPinch3
        '
        Me.LPinch3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LPinch3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LPinch3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPinch3.Location = New System.Drawing.Point(387, 124)
        Me.LPinch3.Name = "LPinch3"
        Me.LPinch3.Size = New System.Drawing.Size(65, 35)
        Me.LPinch3.TabIndex = 8
        Me.LPinch3.Text = "Válvula Pinch 3"
        Me.LPinch3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LFiltroAire
        '
        Me.LFiltroAire.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LFiltroAire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LFiltroAire.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFiltroAire.Location = New System.Drawing.Point(426, 227)
        Me.LFiltroAire.Name = "LFiltroAire"
        Me.LFiltroAire.Size = New System.Drawing.Size(65, 35)
        Me.LFiltroAire.TabIndex = 9
        Me.LFiltroAire.Text = "Filtro de aire"
        Me.LFiltroAire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LPinch1
        '
        Me.LPinch1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LPinch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LPinch1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPinch1.Location = New System.Drawing.Point(52, 179)
        Me.LPinch1.Name = "LPinch1"
        Me.LPinch1.Size = New System.Drawing.Size(65, 35)
        Me.LPinch1.TabIndex = 10
        Me.LPinch1.Text = "Válvula Pinch 1"
        Me.LPinch1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PBJar1
        '
        Me.PBJar1.Image = CType(resources.GetObject("PBJar1.Image"), System.Drawing.Image)
        Me.PBJar1.Location = New System.Drawing.Point(225, 261)
        Me.PBJar1.Name = "PBJar1"
        Me.PBJar1.Size = New System.Drawing.Size(65, 107)
        Me.PBJar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBJar1.TabIndex = 11
        Me.PBJar1.TabStop = False
        '
        'PBJar2
        '
        Me.PBJar2.Image = CType(resources.GetObject("PBJar2.Image"), System.Drawing.Image)
        Me.PBJar2.Location = New System.Drawing.Point(315, 261)
        Me.PBJar2.Name = "PBJar2"
        Me.PBJar2.Size = New System.Drawing.Size(65, 107)
        Me.PBJar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBJar2.TabIndex = 12
        Me.PBJar2.TabStop = False
        '
        'LSensColor
        '
        Me.LSensColor.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LSensColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSensColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSensColor.Location = New System.Drawing.Point(486, 124)
        Me.LSensColor.Name = "LSensColor"
        Me.LSensColor.Size = New System.Drawing.Size(65, 35)
        Me.LSensColor.TabIndex = 13
        Me.LSensColor.Text = "Sensor de color"
        Me.LSensColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LCeldaMedicion
        '
        Me.LCeldaMedicion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LCeldaMedicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LCeldaMedicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCeldaMedicion.Location = New System.Drawing.Point(587, 106)
        Me.LCeldaMedicion.Name = "LCeldaMedicion"
        Me.LCeldaMedicion.Size = New System.Drawing.Size(101, 53)
        Me.LCeldaMedicion.TabIndex = 14
        Me.LCeldaMedicion.Text = "Celda de medición"
        Me.LCeldaMedicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LValvPinch4
        '
        Me.LValvPinch4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LValvPinch4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LValvPinch4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LValvPinch4.Location = New System.Drawing.Point(720, 124)
        Me.LValvPinch4.Name = "LValvPinch4"
        Me.LValvPinch4.Size = New System.Drawing.Size(65, 35)
        Me.LValvPinch4.TabIndex = 15
        Me.LValvPinch4.Text = "Válvula Pinch 4"
        Me.LValvPinch4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LSensVacio
        '
        Me.LSensVacio.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LSensVacio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSensVacio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSensVacio.Location = New System.Drawing.Point(897, 186)
        Me.LSensVacio.Name = "LSensVacio"
        Me.LSensVacio.Size = New System.Drawing.Size(65, 35)
        Me.LSensVacio.TabIndex = 16
        Me.LSensVacio.Text = "Sensor de vacío"
        Me.LSensVacio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBombaVac
        '
        Me.LBombaVac.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LBombaVac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBombaVac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBombaVac.Location = New System.Drawing.Point(897, 243)
        Me.LBombaVac.Name = "LBombaVac"
        Me.LBombaVac.Size = New System.Drawing.Size(65, 35)
        Me.LBombaVac.TabIndex = 17
        Me.LBombaVac.Text = "Bomba de vacío"
        Me.LBombaVac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LSensPeso1
        '
        Me.LSensPeso1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LSensPeso1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSensPeso1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSensPeso1.Location = New System.Drawing.Point(225, 371)
        Me.LSensPeso1.Name = "LSensPeso1"
        Me.LSensPeso1.Size = New System.Drawing.Size(65, 35)
        Me.LSensPeso1.TabIndex = 18
        Me.LSensPeso1.Text = "Sensor de peso 1"
        Me.LSensPeso1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LSensPeso2
        '
        Me.LSensPeso2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LSensPeso2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSensPeso2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSensPeso2.Location = New System.Drawing.Point(315, 371)
        Me.LSensPeso2.Name = "LSensPeso2"
        Me.LSensPeso2.Size = New System.Drawing.Size(65, 35)
        Me.LSensPeso2.TabIndex = 19
        Me.LSensPeso2.Text = "Sensor de peso 2"
        Me.LSensPeso2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LSensPeso3
        '
        Me.LSensPeso3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LSensPeso3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSensPeso3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSensPeso3.Location = New System.Drawing.Point(799, 371)
        Me.LSensPeso3.Name = "LSensPeso3"
        Me.LSensPeso3.Size = New System.Drawing.Size(65, 35)
        Me.LSensPeso3.TabIndex = 20
        Me.LSensPeso3.Text = "Sensor de peso 3"
        Me.LSensPeso3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PBJar3
        '
        Me.PBJar3.Image = CType(resources.GetObject("PBJar3.Image"), System.Drawing.Image)
        Me.PBJar3.Location = New System.Drawing.Point(799, 261)
        Me.PBJar3.Name = "PBJar3"
        Me.PBJar3.Size = New System.Drawing.Size(65, 107)
        Me.PBJar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBJar3.TabIndex = 21
        Me.PBJar3.TabStop = False
        '
        'BComienzo
        '
        Me.BComienzo.Location = New System.Drawing.Point(569, 403)
        Me.BComienzo.Name = "BComienzo"
        Me.BComienzo.Size = New System.Drawing.Size(130, 46)
        Me.BComienzo.TabIndex = 22
        Me.BComienzo.Text = "Comenzar medición"
        Me.BComienzo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.BComienzo)
        Me.Controls.Add(Me.PBJar3)
        Me.Controls.Add(Me.LSensPeso3)
        Me.Controls.Add(Me.LSensPeso2)
        Me.Controls.Add(Me.LSensPeso1)
        Me.Controls.Add(Me.LBombaVac)
        Me.Controls.Add(Me.LSensVacio)
        Me.Controls.Add(Me.LValvPinch4)
        Me.Controls.Add(Me.LCeldaMedicion)
        Me.Controls.Add(Me.LSensColor)
        Me.Controls.Add(Me.PBJar2)
        Me.Controls.Add(Me.PBJar1)
        Me.Controls.Add(Me.LPinch1)
        Me.Controls.Add(Me.LFiltroAire)
        Me.Controls.Add(Me.LPinch3)
        Me.Controls.Add(Me.LPinch2)
        Me.Controls.Add(Me.LSensGota2)
        Me.Controls.Add(Me.LSensGota1)
        Me.Controls.Add(Me.LValvSelect)
        Me.Controls.Add(Me.LSensGota3)
        Me.Controls.Add(Me.LMuestraSangre)
        Me.Controls.Add(Me.LSensTemp2)
        Me.Controls.Add(Me.LSensTemp1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PBJar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBJar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBJar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LSensTemp1 As Label
    Friend WithEvents LSensTemp2 As Label
    Friend WithEvents LMuestraSangre As Label
    Friend WithEvents LSensGota3 As Label
    Friend WithEvents LValvSelect As Label
    Friend WithEvents LSensGota1 As Label
    Friend WithEvents LSensGota2 As Label
    Friend WithEvents LPinch2 As Label
    Friend WithEvents LPinch3 As Label
    Friend WithEvents LFiltroAire As Label
    Friend WithEvents LPinch1 As Label
    Friend WithEvents PBJar1 As PictureBox
    Friend WithEvents PBJar2 As PictureBox
    Friend WithEvents LSensColor As Label
    Friend WithEvents LCeldaMedicion As Label
    Friend WithEvents LValvPinch4 As Label
    Friend WithEvents LSensVacio As Label
    Friend WithEvents LBombaVac As Label
    Friend WithEvents LSensPeso1 As Label
    Friend WithEvents LSensPeso2 As Label
    Friend WithEvents LSensPeso3 As Label
    Friend WithEvents PBJar3 As PictureBox
    Friend WithEvents BComienzo As Button
End Class

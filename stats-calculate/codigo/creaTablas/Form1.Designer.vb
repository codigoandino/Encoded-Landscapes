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
        Me.txtW = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPaso = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt6500 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt60006500 = New System.Windows.Forms.TextBox()
        Me.txt50005500 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt55006000 = New System.Windows.Forms.TextBox()
        Me.txt40004500 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt45005000 = New System.Windows.Forms.TextBox()
        Me.txt3500 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt35004000 = New System.Windows.Forms.TextBox()
        Me.lblSalidas = New System.Windows.Forms.Label()
        Me.btbSalida = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.openFile = New System.Windows.Forms.OpenFileDialog()
        Me.saveFile = New System.Windows.Forms.SaveFileDialog()
        Me.lblMsg1 = New System.Windows.Forms.Label()
        Me.lblMsg2 = New System.Windows.Forms.Label()
        Me.lblMsg3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtEi = New System.Windows.Forms.TextBox()
        Me.txtNi = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtNf = New System.Windows.Forms.TextBox()
        Me.txtEf = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtW
        '
        Me.txtW.Location = New System.Drawing.Point(43, 19)
        Me.txtW.Name = "txtW"
        Me.txtW.Size = New System.Drawing.Size(46, 20)
        Me.txtW.TabIndex = 2
        Me.txtW.Text = "1000"
        Me.txtW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "W(m)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "D"
        Me.Label3.Visible = False
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(95, 43)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(46, 20)
        Me.txtD.TabIndex = 4
        Me.txtD.Text = "2"
        Me.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtD.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtPaso)
        Me.GroupBox1.Controls.Add(Me.txtW)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtD)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 262)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(97, 124)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Geometría"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(9, 85)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(82, 27)
        Me.btnRefresh.TabIndex = 13
        Me.btnRefresh.Text = "Refrescar"
        Me.btnRefresh.UseVisualStyleBackColor = True
        Me.btnRefresh.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Paso(°)"
        '
        'txtPaso
        '
        Me.txtPaso.Location = New System.Drawing.Point(58, 43)
        Me.txtPaso.Name = "txtPaso"
        Me.txtPaso.Size = New System.Drawing.Size(32, 20)
        Me.txtPaso.TabIndex = 6
        Me.txtPaso.Text = "1"
        Me.txtPaso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt6500)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt60006500)
        Me.GroupBox2.Controls.Add(Me.txt50005500)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt55006000)
        Me.GroupBox2.Controls.Add(Me.txt40004500)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt45005000)
        Me.GroupBox2.Controls.Add(Me.txt3500)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt35004000)
        Me.GroupBox2.Location = New System.Drawing.Point(117, 262)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 124)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pesos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(130, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = ">6500"
        '
        'txt6500
        '
        Me.txt6500.Location = New System.Drawing.Point(194, 97)
        Me.txt6500.Name = "txt6500"
        Me.txt6500.Size = New System.Drawing.Size(46, 20)
        Me.txt6500.TabIndex = 16
        Me.txt6500.Text = "7"
        Me.txt6500.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(130, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "6000-6500"
        '
        'txt60006500
        '
        Me.txt60006500.Location = New System.Drawing.Point(194, 71)
        Me.txt60006500.Name = "txt60006500"
        Me.txt60006500.Size = New System.Drawing.Size(46, 20)
        Me.txt60006500.TabIndex = 14
        Me.txt60006500.Text = "6"
        Me.txt60006500.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt50005500
        '
        Me.txt50005500.Location = New System.Drawing.Point(194, 19)
        Me.txt50005500.Name = "txt50005500"
        Me.txt50005500.Size = New System.Drawing.Size(46, 20)
        Me.txt50005500.TabIndex = 10
        Me.txt50005500.Text = "4"
        Me.txt50005500.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(130, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "5500-6000"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(130, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "5000-5500"
        '
        'txt55006000
        '
        Me.txt55006000.Location = New System.Drawing.Point(194, 45)
        Me.txt55006000.Name = "txt55006000"
        Me.txt55006000.Size = New System.Drawing.Size(46, 20)
        Me.txt55006000.TabIndex = 12
        Me.txt55006000.Text = "5"
        Me.txt55006000.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt40004500
        '
        Me.txt40004500.Location = New System.Drawing.Point(75, 71)
        Me.txt40004500.Name = "txt40004500"
        Me.txt40004500.Size = New System.Drawing.Size(46, 20)
        Me.txt40004500.TabIndex = 6
        Me.txt40004500.Text = "2"
        Me.txt40004500.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "4500-5000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "4000-4500"
        '
        'txt45005000
        '
        Me.txt45005000.Location = New System.Drawing.Point(75, 97)
        Me.txt45005000.Name = "txt45005000"
        Me.txt45005000.Size = New System.Drawing.Size(46, 20)
        Me.txt45005000.TabIndex = 8
        Me.txt45005000.Text = "3"
        Me.txt45005000.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt3500
        '
        Me.txt3500.Location = New System.Drawing.Point(75, 19)
        Me.txt3500.Name = "txt3500"
        Me.txt3500.Size = New System.Drawing.Size(46, 20)
        Me.txt3500.TabIndex = 2
        Me.txt3500.Text = "0"
        Me.txt3500.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "3500-4000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "<3500"
        '
        'txt35004000
        '
        Me.txt35004000.Location = New System.Drawing.Point(75, 45)
        Me.txt35004000.Name = "txt35004000"
        Me.txt35004000.Size = New System.Drawing.Size(46, 20)
        Me.txt35004000.TabIndex = 4
        Me.txt35004000.Text = "1"
        Me.txt35004000.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSalidas
        '
        Me.lblSalidas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSalidas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalidas.Location = New System.Drawing.Point(13, 198)
        Me.lblSalidas.Name = "lblSalidas"
        Me.lblSalidas.Size = New System.Drawing.Size(930, 28)
        Me.lblSalidas.TabIndex = 9
        Me.lblSalidas.Text = "Estadísticas resultantes del proceso"
        Me.lblSalidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btbSalida
        '
        Me.btbSalida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btbSalida.Location = New System.Drawing.Point(949, 197)
        Me.btbSalida.Name = "btbSalida"
        Me.btbSalida.Size = New System.Drawing.Size(90, 30)
        Me.btbSalida.TabIndex = 8
        Me.btbSalida.Text = "Salida"
        Me.btbSalida.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcesar.Location = New System.Drawing.Point(12, 455)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(1025, 30)
        Me.btnProcesar.TabIndex = 10
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'openFile
        '
        Me.openFile.Filter = "Separado por TAB |*.tab;*.TAB;*.Tab|Archivo Raster ASCII |*.asc;*.ASC;*.Asc|Archi" &
    "vo texto |*.txt;*.TXT;*.Txt"
        Me.openFile.Title = "Abrir Coordenadas Tab"
        '
        'saveFile
        '
        Me.saveFile.DefaultExt = "txt"
        Me.saveFile.Filter = "Archivo Estadísticas|*.txt"
        Me.saveFile.Title = "Archivo de Salida de Resultados"
        '
        'lblMsg1
        '
        Me.lblMsg1.AutoSize = True
        Me.lblMsg1.BackColor = System.Drawing.Color.Silver
        Me.lblMsg1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg1.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblMsg1.Location = New System.Drawing.Point(395, 232)
        Me.lblMsg1.Name = "lblMsg1"
        Me.lblMsg1.Size = New System.Drawing.Size(0, 18)
        Me.lblMsg1.TabIndex = 11
        '
        'lblMsg2
        '
        Me.lblMsg2.AutoSize = True
        Me.lblMsg2.BackColor = System.Drawing.Color.Silver
        Me.lblMsg2.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg2.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblMsg2.Location = New System.Drawing.Point(395, 256)
        Me.lblMsg2.Name = "lblMsg2"
        Me.lblMsg2.Size = New System.Drawing.Size(0, 18)
        Me.lblMsg2.TabIndex = 12
        '
        'lblMsg3
        '
        Me.lblMsg3.AutoSize = True
        Me.lblMsg3.BackColor = System.Drawing.Color.Silver
        Me.lblMsg3.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg3.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblMsg3.Location = New System.Drawing.Point(395, 281)
        Me.lblMsg3.Name = "lblMsg3"
        Me.lblMsg3.Size = New System.Drawing.Size(0, 18)
        Me.lblMsg3.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(13, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(917, 28)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Archivo lista coordenadas X,Y,Z"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(936, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 30)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "peak_final"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Brown
        Me.Label14.Location = New System.Drawing.Point(1003, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 18)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Versión Antigua"
        Me.Label14.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Brown
        Me.Label15.Location = New System.Drawing.Point(12, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(153, 18)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Versión Tomasz 2023"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Brown
        Me.Label16.Location = New System.Drawing.Point(12, 179)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(125, 18)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Archivo de Salida:"
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(13, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(917, 28)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Archivo lista coordenadas X,Y,Z"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(936, 59)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 30)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "peak_final_05p"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Location = New System.Drawing.Point(12, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(917, 28)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Archivo lista coordenadas X,Y,Z"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(935, 95)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 30)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "peak_final_08p"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Location = New System.Drawing.Point(12, 132)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(917, 28)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Archivo lista coordenadas X,Y,Z"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(935, 131)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(103, 30)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "peak_final_12p"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtEi
        '
        Me.txtEi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEi.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtEi.Location = New System.Drawing.Point(509, 407)
        Me.txtEi.Name = "txtEi"
        Me.txtEi.Size = New System.Drawing.Size(82, 21)
        Me.txtEi.TabIndex = 27
        Me.txtEi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNi
        '
        Me.txtNi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNi.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtNi.Location = New System.Drawing.Point(509, 429)
        Me.txtNi.Name = "txtNi"
        Me.txtNi.Size = New System.Drawing.Size(82, 21)
        Me.txtNi.TabIndex = 28
        Me.txtNi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(481, 411)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(25, 13)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "E(x)"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(481, 432)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(26, 13)
        Me.Label21.TabIndex = 30
        Me.Label21.Text = "N(y)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(597, 310)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(124, 121)
        Me.Panel1.TabIndex = 31
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(727, 326)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(26, 13)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "N(y)"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(727, 305)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(25, 13)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "E(x)"
        '
        'txtNf
        '
        Me.txtNf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNf.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtNf.Location = New System.Drawing.Point(754, 323)
        Me.txtNf.Name = "txtNf"
        Me.txtNf.Size = New System.Drawing.Size(81, 21)
        Me.txtNf.TabIndex = 33
        Me.txtNf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEf
        '
        Me.txtEf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEf.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtEf.Location = New System.Drawing.Point(754, 301)
        Me.txtEf.Name = "txtEf"
        Me.txtEf.Size = New System.Drawing.Size(81, 21)
        Me.txtEf.TabIndex = 32
        Me.txtEf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Brown
        Me.Label24.Location = New System.Drawing.Point(742, 413)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(273, 18)
        Me.Label24.TabIndex = 36
        Me.Label24.Text = "Coordenadas Extremas Área Extracción"
        '
        'Label25
        '
        Me.Label25.AutoEllipsis = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Brown
        Me.Label25.Location = New System.Drawing.Point(16, 392)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(198, 39)
        Me.Label25.TabIndex = 37
        Me.Label25.Text = "W: Ancho Bin.                       Paso: Variación de Azimut."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 491)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtNf)
        Me.Controls.Add(Me.txtEf)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtNi)
        Me.Controls.Add(Me.txtEi)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblMsg3)
        Me.Controls.Add(Me.lblMsg2)
        Me.Controls.Add(Me.lblMsg1)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.lblSalidas)
        Me.Controls.Add(Me.btbSalida)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExtraeTablas v20240125"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtW As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtD As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPaso As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt6500 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt60006500 As TextBox
    Friend WithEvents txt50005500 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt55006000 As TextBox
    Friend WithEvents txt40004500 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt45005000 As TextBox
    Friend WithEvents txt3500 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt35004000 As TextBox
    Friend WithEvents lblSalidas As Label
    Friend WithEvents btbSalida As Button
    Friend WithEvents btnProcesar As Button
    Friend WithEvents openFile As OpenFileDialog
    Friend WithEvents saveFile As SaveFileDialog
    Friend WithEvents lblMsg1 As Label
    Friend WithEvents lblMsg2 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblMsg3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents txtEi As TextBox
    Friend WithEvents txtNi As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtNf As TextBox
    Friend WithEvents txtEf As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
End Class

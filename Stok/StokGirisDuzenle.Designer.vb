﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StokGirisDuzenle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StokGirisDuzenle))
        Me.dgFisListe = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnSil = New DevExpress.XtraEditors.SimpleButton()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnIptal = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBirim = New System.Windows.Forms.TextBox()
        Me.nudMiktar = New System.Windows.Forms.NumericUpDown()
        Me.btnListeEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStokKodu = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnStokKart = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTutar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtStokAdi = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBirimFiyat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbDepo = New System.Windows.Forms.ComboBox()
        Me.txtAciklama = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTopTutar = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTopBirim = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnFisDuzenle = New DevExpress.XtraEditors.SimpleButton()
        Me.lblFisId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFisTarihi = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFisNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbBolum = New System.Windows.Forms.ComboBox()
        CType(Me.dgFisListe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudMiktar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgFisListe
        '
        Me.dgFisListe.AllowUserToAddRows = False
        Me.dgFisListe.AllowUserToDeleteRows = False
        Me.dgFisListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgFisListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFisListe.Location = New System.Drawing.Point(14, 20)
        Me.dgFisListe.Name = "dgFisListe"
        Me.dgFisListe.ReadOnly = True
        Me.dgFisListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFisListe.Size = New System.Drawing.Size(536, 107)
        Me.dgFisListe.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnSil)
        Me.GroupBox4.Controls.Add(Me.dgFisListe)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox4.Location = New System.Drawing.Point(12, 348)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(556, 172)
        Me.GroupBox4.TabIndex = 70
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fiş Liste"
        '
        'btnSil
        '
        Me.btnSil.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnSil.Appearance.Options.UseForeColor = True
        Me.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnSil.Image = CType(resources.GetObject("btnSil.Image"), System.Drawing.Image)
        Me.btnSil.Location = New System.Drawing.Point(448, 133)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSil.Size = New System.Drawing.Size(102, 26)
        Me.btnSil.TabIndex = 15
        Me.btnSil.Text = "Kaldır"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(271, 26)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(50, 13)
        Me.lblid.TabIndex = 43
        Me.lblid.Text = "Ürün ID"
        Me.lblid.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 641)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 28)
        Me.Panel1.TabIndex = 69
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(580, 28)
        Me.Panel2.TabIndex = 68
        '
        'btnIptal
        '
        Me.btnIptal.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btnIptal.Appearance.Options.UseForeColor = True
        Me.btnIptal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnIptal.Image = CType(resources.GetObject("btnIptal.Image"), System.Drawing.Image)
        Me.btnIptal.Location = New System.Drawing.Point(259, 600)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnIptal.Size = New System.Drawing.Size(85, 26)
        Me.btnIptal.TabIndex = 67
        Me.btnIptal.Text = "Kapat"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblid)
        Me.GroupBox2.Controls.Add(Me.txtBirim)
        Me.GroupBox2.Controls.Add(Me.nudMiktar)
        Me.GroupBox2.Controls.Add(Me.btnListeEkle)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtStokKodu)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.btnStokKart)
        Me.GroupBox2.Controls.Add(Me.txtTutar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtStokAdi)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtBirimFiyat)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(556, 136)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ürün Bilgileri"
        '
        'txtBirim
        '
        Me.txtBirim.Enabled = False
        Me.txtBirim.Location = New System.Drawing.Point(87, 103)
        Me.txtBirim.Name = "txtBirim"
        Me.txtBirim.Size = New System.Drawing.Size(88, 21)
        Me.txtBirim.TabIndex = 42
        '
        'nudMiktar
        '
        Me.nudMiktar.Location = New System.Drawing.Point(87, 76)
        Me.nudMiktar.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudMiktar.Name = "nudMiktar"
        Me.nudMiktar.Size = New System.Drawing.Size(88, 21)
        Me.nudMiktar.TabIndex = 41
        '
        'btnListeEkle
        '
        Me.btnListeEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnListeEkle.Image = CType(resources.GetObject("btnListeEkle.Image"), System.Drawing.Image)
        Me.btnListeEkle.Location = New System.Drawing.Point(405, 101)
        Me.btnListeEkle.Name = "btnListeEkle"
        Me.btnListeEkle.Size = New System.Drawing.Size(145, 23)
        Me.btnListeEkle.TabIndex = 23
        Me.btnListeEkle.Text = "Fiş'e Yeni Ürün Ekle"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(11, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Stok Kodu :"
        '
        'txtStokKodu
        '
        Me.txtStokKodu.Enabled = False
        Me.txtStokKodu.Location = New System.Drawing.Point(87, 23)
        Me.txtStokKodu.Name = "txtStokKodu"
        Me.txtStokKodu.Size = New System.Drawing.Size(151, 21)
        Me.txtStokKodu.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(514, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "TL"
        '
        'btnStokKart
        '
        Me.btnStokKart.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.btnStokKart.Appearance.Options.UseBackColor = True
        Me.btnStokKart.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnStokKart.Image = CType(resources.GetObject("btnStokKart.Image"), System.Drawing.Image)
        Me.btnStokKart.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnStokKart.Location = New System.Drawing.Point(244, 21)
        Me.btnStokKart.Name = "btnStokKart"
        Me.btnStokKart.Size = New System.Drawing.Size(32, 23)
        Me.btnStokKart.TabIndex = 10
        Me.btnStokKart.Text = "Seç"
        '
        'txtTutar
        '
        Me.txtTutar.Location = New System.Drawing.Point(413, 49)
        Me.txtTutar.Name = "txtTutar"
        Me.txtTutar.Size = New System.Drawing.Size(95, 21)
        Me.txtTutar.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(21, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Stok Adı :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(363, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Tutar :"
        '
        'txtStokAdi
        '
        Me.txtStokAdi.Enabled = False
        Me.txtStokAdi.Location = New System.Drawing.Point(87, 49)
        Me.txtStokAdi.Name = "txtStokAdi"
        Me.txtStokAdi.Size = New System.Drawing.Size(151, 21)
        Me.txtStokAdi.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(514, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "TL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(31, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Miktar :"
        '
        'txtBirimFiyat
        '
        Me.txtBirimFiyat.Enabled = False
        Me.txtBirimFiyat.Location = New System.Drawing.Point(413, 23)
        Me.txtBirimFiyat.Name = "txtBirimFiyat"
        Me.txtBirimFiyat.Size = New System.Drawing.Size(95, 21)
        Me.txtBirimFiyat.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(334, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Birim Fiyat :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(39, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Birim :"
        '
        'cmbDepo
        '
        Me.cmbDepo.FormattingEnabled = True
        Me.cmbDepo.Location = New System.Drawing.Point(413, 22)
        Me.cmbDepo.Name = "cmbDepo"
        Me.cmbDepo.Size = New System.Drawing.Size(121, 21)
        Me.cmbDepo.TabIndex = 6
        '
        'txtAciklama
        '
        Me.txtAciklama.Location = New System.Drawing.Point(87, 76)
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.Size = New System.Drawing.Size(193, 66)
        Me.txtAciklama.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txtTopTutar)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txtTopBirim)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox5.Location = New System.Drawing.Point(12, 526)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(556, 62)
        Me.GroupBox5.TabIndex = 65
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Fiş Toplamı"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(506, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "TL"
        '
        'txtTopTutar
        '
        Me.txtTopTutar.Enabled = False
        Me.txtTopTutar.Location = New System.Drawing.Point(368, 25)
        Me.txtTopTutar.Name = "txtTopTutar"
        Me.txtTopTutar.Size = New System.Drawing.Size(132, 21)
        Me.txtTopTutar.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DimGray
        Me.Label14.Location = New System.Drawing.Point(275, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Toplam Tutar :"
        '
        'txtTopBirim
        '
        Me.txtTopBirim.Enabled = False
        Me.txtTopBirim.Location = New System.Drawing.Point(130, 25)
        Me.txtTopBirim.Name = "txtTopBirim"
        Me.txtTopBirim.Size = New System.Drawing.Size(139, 21)
        Me.txtTopBirim.TabIndex = 24
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(37, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Toplam Birim :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtAciklama)
        Me.GroupBox1.Controls.Add(Me.btnFisDuzenle)
        Me.GroupBox1.Controls.Add(Me.lblFisId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFisTarihi)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFisNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbDepo)
        Me.GroupBox1.Controls.Add(Me.cmbBolum)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 158)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fiş Bilgileri"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(16, 79)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Açıklama :"
        '
        'btnFisDuzenle
        '
        Me.btnFisDuzenle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.btnFisDuzenle.Image = CType(resources.GetObject("btnFisDuzenle.Image"), System.Drawing.Image)
        Me.btnFisDuzenle.Location = New System.Drawing.Point(448, 119)
        Me.btnFisDuzenle.Name = "btnFisDuzenle"
        Me.btnFisDuzenle.Size = New System.Drawing.Size(102, 23)
        Me.btnFisDuzenle.TabIndex = 44
        Me.btnFisDuzenle.Text = "Fiş Düzenle"
        '
        'lblFisId
        '
        Me.lblFisId.AutoSize = True
        Me.lblFisId.Location = New System.Drawing.Point(244, 28)
        Me.lblFisId.Name = "lblFisId"
        Me.lblFisId.Size = New System.Drawing.Size(36, 13)
        Me.lblFisId.TabIndex = 44
        Me.lblFisId.Text = "fis ID"
        Me.lblFisId.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(18, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fiş Tarihi :"
        '
        'dtpFisTarihi
        '
        Me.dtpFisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFisTarihi.Location = New System.Drawing.Point(87, 22)
        Me.dtpFisTarihi.Name = "dtpFisTarihi"
        Me.dtpFisTarihi.Size = New System.Drawing.Size(151, 21)
        Me.dtpFisTarihi.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(36, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fiş No :"
        '
        'txtFisNo
        '
        Me.txtFisNo.Location = New System.Drawing.Point(87, 49)
        Me.txtFisNo.Name = "txtFisNo"
        Me.txtFisNo.Size = New System.Drawing.Size(151, 21)
        Me.txtFisNo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(323, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Giriş Deposu :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(317, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Geldiği Bölüm :"
        '
        'cmbBolum
        '
        Me.cmbBolum.FormattingEnabled = True
        Me.cmbBolum.Location = New System.Drawing.Point(413, 49)
        Me.cmbBolum.Name = "cmbBolum"
        Me.cmbBolum.Size = New System.Drawing.Size(121, 21)
        Me.cmbBolum.TabIndex = 7
        '
        'StokGirisDuzenle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(580, 669)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "StokGirisDuzenle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Giriş Fişi Düzenleme"
        CType(Me.dgFisListe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudMiktar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgFisListe As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblid As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnIptal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBirim As TextBox
    Friend WithEvents nudMiktar As NumericUpDown
    Friend WithEvents btnListeEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStokKodu As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnStokKart As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTutar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtStokAdi As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBirimFiyat As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbDepo As ComboBox
    Friend WithEvents txtAciklama As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTopTutar As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTopBirim As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFisTarihi As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFisNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbBolum As ComboBox
    Friend WithEvents lblFisId As Label
    Friend WithEvents btnFisDuzenle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label15 As Label
End Class

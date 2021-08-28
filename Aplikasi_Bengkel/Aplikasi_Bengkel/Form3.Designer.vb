<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.pnlAtas = New System.Windows.Forms.Panel()
        Me.pnlDataBarang = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.pnlKiri = New System.Windows.Forms.Panel()
        Me.lblSelected6 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblSelected5 = New System.Windows.Forms.Label()
        Me.btnTentangAPK = New System.Windows.Forms.Button()
        Me.lblSelected3 = New System.Windows.Forms.Label()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.lblSelected2 = New System.Windows.Forms.Label()
        Me.btnTransaksi = New System.Windows.Forms.Button()
        Me.lblSelected1 = New System.Windows.Forms.Label()
        Me.btnMaster = New System.Windows.Forms.Button()
        Me.pnlBarang = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlLaporan = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPendapatan = New System.Windows.Forms.TextBox()
        Me.DGVLaporan = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlTransaksi = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txt_Harga = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tgl = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_Proses = New System.Windows.Forms.Button()
        Me.txtKembalian = New System.Windows.Forms.TextBox()
        Me.txtJmlh_uang = New System.Windows.Forms.TextBox()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.txt_Jumlah = New System.Windows.Forms.TextBox()
        Me.txt_NamaBarang = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlTentangApk = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlAtas.SuspendLayout()
        Me.pnlKiri.SuspendLayout()
        Me.pnlBarang.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLaporan.SuspendLayout()
        CType(Me.DGVLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTransaksi.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTentangApk.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAtas
        '
        Me.pnlAtas.BackColor = System.Drawing.Color.MediumVioletRed
        Me.pnlAtas.Controls.Add(Me.pnlDataBarang)
        Me.pnlAtas.Controls.Add(Me.lblStatus)
        Me.pnlAtas.Controls.Add(Me.btnClose)
        Me.pnlAtas.Controls.Add(Me.btnMax)
        Me.pnlAtas.Controls.Add(Me.btnMin)
        Me.pnlAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Size = New System.Drawing.Size(784, 34)
        Me.pnlAtas.TabIndex = 30
        '
        'pnlDataBarang
        '
        Me.pnlDataBarang.Location = New System.Drawing.Point(38, 29)
        Me.pnlDataBarang.Name = "pnlDataBarang"
        Me.pnlDataBarang.Size = New System.Drawing.Size(784, 390)
        Me.pnlDataBarang.TabIndex = 32
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblStatus.Location = New System.Drawing.Point(3, 7)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(331, 20)
        Me.lblStatus.TabIndex = 17
        Me.lblStatus.Text = "Selamat Datang DI SISFO ONDERDILE"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.Aplikasi_Bengkel.My.Resources.Resources.close15px
        Me.btnClose.Location = New System.Drawing.Point(754, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(18, 18)
        Me.btnClose.TabIndex = 0
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMax
        '
        Me.btnMax.BackColor = System.Drawing.Color.Transparent
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.ForeColor = System.Drawing.Color.Transparent
        Me.btnMax.Image = Global.Aplikasi_Bengkel.My.Resources.Resources.maximize15px
        Me.btnMax.Location = New System.Drawing.Point(733, 7)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(18, 18)
        Me.btnMax.TabIndex = 2
        Me.btnMax.UseVisualStyleBackColor = False
        '
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Image = Global.Aplikasi_Bengkel.My.Resources.Resources.minimize15px
        Me.btnMin.Location = New System.Drawing.Point(712, 7)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(18, 18)
        Me.btnMin.TabIndex = 1
        Me.btnMin.UseVisualStyleBackColor = False
        '
        'pnlKiri
        '
        Me.pnlKiri.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.pnlKiri.Controls.Add(Me.lblSelected6)
        Me.pnlKiri.Controls.Add(Me.btnLogout)
        Me.pnlKiri.Controls.Add(Me.lblSelected5)
        Me.pnlKiri.Controls.Add(Me.btnTentangAPK)
        Me.pnlKiri.Controls.Add(Me.lblSelected3)
        Me.pnlKiri.Controls.Add(Me.btnLaporan)
        Me.pnlKiri.Controls.Add(Me.lblSelected2)
        Me.pnlKiri.Controls.Add(Me.btnTransaksi)
        Me.pnlKiri.Controls.Add(Me.lblSelected1)
        Me.pnlKiri.Controls.Add(Me.btnMaster)
        Me.pnlKiri.Location = New System.Drawing.Point(0, 31)
        Me.pnlKiri.Name = "pnlKiri"
        Me.pnlKiri.Size = New System.Drawing.Size(784, 36)
        Me.pnlKiri.TabIndex = 31
        '
        'lblSelected6
        '
        Me.lblSelected6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSelected6.Location = New System.Drawing.Point(13, 22)
        Me.lblSelected6.Name = "lblSelected6"
        Me.lblSelected6.Size = New System.Drawing.Size(32, 10)
        Me.lblSelected6.TabIndex = 13
        Me.lblSelected6.Visible = False
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(-17, -1)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(68, 35)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "   Log out"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblSelected5
        '
        Me.lblSelected5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSelected5.Location = New System.Drawing.Point(702, 22)
        Me.lblSelected5.Name = "lblSelected5"
        Me.lblSelected5.Size = New System.Drawing.Size(71, 10)
        Me.lblSelected5.TabIndex = 9
        Me.lblSelected5.Visible = False
        '
        'btnTentangAPK
        '
        Me.btnTentangAPK.FlatAppearance.BorderSize = 0
        Me.btnTentangAPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTentangAPK.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTentangAPK.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTentangAPK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTentangAPK.Location = New System.Drawing.Point(667, 2)
        Me.btnTentangAPK.Name = "btnTentangAPK"
        Me.btnTentangAPK.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnTentangAPK.Size = New System.Drawing.Size(114, 27)
        Me.btnTentangAPK.TabIndex = 8
        Me.btnTentangAPK.Text = "   Tentang Aplikasi"
        Me.btnTentangAPK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTentangAPK.UseVisualStyleBackColor = True
        '
        'lblSelected3
        '
        Me.lblSelected3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSelected3.Location = New System.Drawing.Point(625, 22)
        Me.lblSelected3.Name = "lblSelected3"
        Me.lblSelected3.Size = New System.Drawing.Size(43, 10)
        Me.lblSelected3.TabIndex = 5
        Me.lblSelected3.Visible = False
        '
        'btnLaporan
        '
        Me.btnLaporan.FlatAppearance.BorderSize = 0
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.Location = New System.Drawing.Point(596, -2)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnLaporan.Size = New System.Drawing.Size(73, 35)
        Me.btnLaporan.TabIndex = 4
        Me.btnLaporan.Text = "   Laporan"
        Me.btnLaporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'lblSelected2
        '
        Me.lblSelected2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSelected2.Location = New System.Drawing.Point(543, 22)
        Me.lblSelected2.Name = "lblSelected2"
        Me.lblSelected2.Size = New System.Drawing.Size(49, 10)
        Me.lblSelected2.TabIndex = 3
        Me.lblSelected2.Visible = False
        '
        'btnTransaksi
        '
        Me.btnTransaksi.FlatAppearance.BorderSize = 0
        Me.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaksi.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTransaksi.Location = New System.Drawing.Point(513, -2)
        Me.btnTransaksi.Name = "btnTransaksi"
        Me.btnTransaksi.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnTransaksi.Size = New System.Drawing.Size(80, 35)
        Me.btnTransaksi.TabIndex = 2
        Me.btnTransaksi.Text = "   Transaksi"
        Me.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTransaksi.UseVisualStyleBackColor = True
        '
        'lblSelected1
        '
        Me.lblSelected1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSelected1.Location = New System.Drawing.Point(450, 22)
        Me.lblSelected1.Name = "lblSelected1"
        Me.lblSelected1.Size = New System.Drawing.Size(66, 10)
        Me.lblSelected1.TabIndex = 1
        Me.lblSelected1.Visible = False
        '
        'btnMaster
        '
        Me.btnMaster.FlatAppearance.BorderSize = 0
        Me.btnMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaster.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMaster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMaster.Location = New System.Drawing.Point(420, -2)
        Me.btnMaster.Name = "btnMaster"
        Me.btnMaster.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnMaster.Size = New System.Drawing.Size(109, 35)
        Me.btnMaster.TabIndex = 0
        Me.btnMaster.Text = "Data Penjualan"
        Me.btnMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMaster.UseVisualStyleBackColor = True
        '
        'pnlBarang
        '
        Me.pnlBarang.Controls.Add(Me.btnEdit)
        Me.pnlBarang.Controls.Add(Me.btnHapus)
        Me.pnlBarang.Controls.Add(Me.btnTambah)
        Me.pnlBarang.Controls.Add(Me.DGV)
        Me.pnlBarang.Controls.Add(Me.Label1)
        Me.pnlBarang.Location = New System.Drawing.Point(0, 60)
        Me.pnlBarang.Name = "pnlBarang"
        Me.pnlBarang.Size = New System.Drawing.Size(784, 390)
        Me.pnlBarang.TabIndex = 40
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEdit.Location = New System.Drawing.Point(146, 318)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 43
        Me.btnEdit.Text = "&EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHapus.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnHapus.Location = New System.Drawing.Point(53, 318)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 42
        Me.btnHapus.Text = "&HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTambah.ForeColor = System.Drawing.Color.Transparent
        Me.btnTambah.Location = New System.Drawing.Point(629, 74)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 41
        Me.btnTambah.Text = "&TAMBAH"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.GridColor = System.Drawing.Color.Teal
        Me.DGV.Location = New System.Drawing.Point(53, 107)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(651, 205)
        Me.DGV.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(648, 38)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Data Penjualan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlLaporan
        '
        Me.pnlLaporan.Controls.Add(Me.Label19)
        Me.pnlLaporan.Controls.Add(Me.txtPendapatan)
        Me.pnlLaporan.Controls.Add(Me.DGVLaporan)
        Me.pnlLaporan.Controls.Add(Me.Label3)
        Me.pnlLaporan.Location = New System.Drawing.Point(0, 63)
        Me.pnlLaporan.Name = "pnlLaporan"
        Me.pnlLaporan.Size = New System.Drawing.Size(784, 422)
        Me.pnlLaporan.TabIndex = 44
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(433, 280)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(126, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "PENDAPATAN :  Rp."
        '
        'txtPendapatan
        '
        Me.txtPendapatan.Location = New System.Drawing.Point(565, 276)
        Me.txtPendapatan.Name = "txtPendapatan"
        Me.txtPendapatan.Size = New System.Drawing.Size(139, 20)
        Me.txtPendapatan.TabIndex = 41
        '
        'DGVLaporan
        '
        Me.DGVLaporan.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGVLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLaporan.GridColor = System.Drawing.Color.Teal
        Me.DGVLaporan.Location = New System.Drawing.Point(55, 79)
        Me.DGVLaporan.Name = "DGVLaporan"
        Me.DGVLaporan.Size = New System.Drawing.Size(649, 191)
        Me.DGVLaporan.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(55, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(648, 38)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Laporan Pendapatan"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlTransaksi
        '
        Me.pnlTransaksi.Controls.Add(Me.Button2)
        Me.pnlTransaksi.Controls.Add(Me.GroupBox1)
        Me.pnlTransaksi.Controls.Add(Me.Label2)
        Me.pnlTransaksi.Location = New System.Drawing.Point(0, 60)
        Me.pnlTransaksi.Name = "pnlTransaksi"
        Me.pnlTransaksi.Size = New System.Drawing.Size(784, 425)
        Me.pnlTransaksi.TabIndex = 41
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(625, 377)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 29)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "&CETAK STRUK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnHitung)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.txt_Harga)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tgl)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btn_Proses)
        Me.GroupBox1.Controls.Add(Me.txtKembalian)
        Me.GroupBox1.Controls.Add(Me.txtJmlh_uang)
        Me.GroupBox1.Controls.Add(Me.txt_Total)
        Me.GroupBox1.Controls.Add(Me.txt_Jumlah)
        Me.GroupBox1.Controls.Add(Me.txt_NamaBarang)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(675, 318)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaksi"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(591, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 20)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "&REFRESH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(648, 156)
        Me.DataGridView1.TabIndex = 41
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdate.Location = New System.Drawing.Point(517, 132)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(68, 20)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "&UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHitung.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnHitung.Location = New System.Drawing.Point(468, 71)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(109, 20)
        Me.btnHitung.TabIndex = 24
        Me.btnHitung.Text = "&Hitung Kembalian"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSimpan.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSimpan.Location = New System.Drawing.Point(443, 132)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(68, 20)
        Me.btnSimpan.TabIndex = 23
        Me.btnSimpan.Text = "&SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'txt_Harga
        '
        Me.txt_Harga.Location = New System.Drawing.Point(307, 61)
        Me.txt_Harga.Name = "txt_Harga"
        Me.txt_Harga.Size = New System.Drawing.Size(117, 20)
        Me.txt_Harga.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(204, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Harga"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(100, 25)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(93, 20)
        Me.txtID.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "ID Barang"
        '
        'tgl
        '
        Me.tgl.Location = New System.Drawing.Point(307, 25)
        Me.tgl.Name = "tgl"
        Me.tgl.Size = New System.Drawing.Size(117, 20)
        Me.tgl.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(200, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Tanggal Keluar"
        '
        'btn_Proses
        '
        Me.btn_Proses.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Proses.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Proses.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Proses.Location = New System.Drawing.Point(203, 93)
        Me.btn_Proses.Name = "btn_Proses"
        Me.btn_Proses.Size = New System.Drawing.Size(87, 26)
        Me.btn_Proses.TabIndex = 16
        Me.btn_Proses.Text = "&Hitung Total"
        Me.btn_Proses.UseVisualStyleBackColor = False
        '
        'txtKembalian
        '
        Me.txtKembalian.Location = New System.Drawing.Point(468, 97)
        Me.txtKembalian.Name = "txtKembalian"
        Me.txtKembalian.Size = New System.Drawing.Size(109, 20)
        Me.txtKembalian.TabIndex = 13
        '
        'txtJmlh_uang
        '
        Me.txtJmlh_uang.Location = New System.Drawing.Point(468, 25)
        Me.txtJmlh_uang.Name = "txtJmlh_uang"
        Me.txtJmlh_uang.Size = New System.Drawing.Size(109, 20)
        Me.txtJmlh_uang.TabIndex = 12
        '
        'txt_Total
        '
        Me.txt_Total.Location = New System.Drawing.Point(307, 97)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.Size = New System.Drawing.Size(117, 20)
        Me.txt_Total.TabIndex = 11
        '
        'txt_Jumlah
        '
        Me.txt_Jumlah.Location = New System.Drawing.Point(100, 92)
        Me.txt_Jumlah.Name = "txt_Jumlah"
        Me.txt_Jumlah.Size = New System.Drawing.Size(93, 20)
        Me.txt_Jumlah.TabIndex = 9
        '
        'txt_NamaBarang
        '
        Me.txt_NamaBarang.Location = New System.Drawing.Point(100, 61)
        Me.txt_NamaBarang.Name = "txt_NamaBarang"
        Me.txt_NamaBarang.Size = New System.Drawing.Size(93, 20)
        Me.txt_NamaBarang.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(465, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Masukkan Jumlah Uang"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 98)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Jumlah"
        '
        'txtNama
        '
        Me.txtNama.AutoSize = True
        Me.txtNama.Location = New System.Drawing.Point(23, 64)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(72, 13)
        Me.txtNama.TabIndex = 0
        Me.txtNama.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(55, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(675, 38)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Data Transaksi"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlTentangApk
        '
        Me.pnlTentangApk.Controls.Add(Me.Label10)
        Me.pnlTentangApk.Controls.Add(Me.Label8)
        Me.pnlTentangApk.Controls.Add(Me.PictureBox1)
        Me.pnlTentangApk.Controls.Add(Me.Label5)
        Me.pnlTentangApk.Controls.Add(Me.Label6)
        Me.pnlTentangApk.Location = New System.Drawing.Point(0, 63)
        Me.pnlTentangApk.Name = "pnlTentangApk"
        Me.pnlTentangApk.Size = New System.Drawing.Size(784, 422)
        Me.pnlTentangApk.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(297, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(418, 208)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = resources.GetString("Label10.Text")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(287, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Fitur Yang Tersedia :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aplikasi_Bengkel.My.Resources.Resources.images_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(55, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 253)
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(287, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(446, 26)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Aplikasi ini menjual barang dan peralatan kendaraan, untuk mempermudah admin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dal" & _
    "am pendataaan penjualan barang yang dilengkapi dengan CRUD data dan Cetak STRUK" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(55, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(648, 38)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Tentang Aplikasi"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(784, 487)
        Me.Controls.Add(Me.pnlTentangApk)
        Me.Controls.Add(Me.pnlLaporan)
        Me.Controls.Add(Me.pnlTransaksi)
        Me.Controls.Add(Me.pnlBarang)
        Me.Controls.Add(Me.pnlKiri)
        Me.Controls.Add(Me.pnlAtas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.pnlAtas.ResumeLayout(False)
        Me.pnlAtas.PerformLayout()
        Me.pnlKiri.ResumeLayout(False)
        Me.pnlBarang.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLaporan.ResumeLayout(False)
        Me.pnlLaporan.PerformLayout()
        CType(Me.DGVLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTransaksi.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTentangApk.ResumeLayout(False)
        Me.pnlTentangApk.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMax As System.Windows.Forms.Button
    Friend WithEvents btnMin As System.Windows.Forms.Button
    Friend WithEvents pnlKiri As System.Windows.Forms.Panel
    Friend WithEvents lblSelected6 As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents lblSelected5 As System.Windows.Forms.Label
    Friend WithEvents btnTentangAPK As System.Windows.Forms.Button
    Friend WithEvents lblSelected3 As System.Windows.Forms.Label
    Friend WithEvents btnLaporan As System.Windows.Forms.Button
    Friend WithEvents lblSelected2 As System.Windows.Forms.Label
    Friend WithEvents btnTransaksi As System.Windows.Forms.Button
    Friend WithEvents lblSelected1 As System.Windows.Forms.Label
    Friend WithEvents btnMaster As System.Windows.Forms.Button
    Friend WithEvents pnlDataBarang As System.Windows.Forms.Panel
    Friend WithEvents pnlBarang As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlTransaksi As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents txt_Harga As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_Proses As System.Windows.Forms.Button
    Friend WithEvents txtKembalian As System.Windows.Forms.TextBox
    Friend WithEvents txtJmlh_uang As System.Windows.Forms.TextBox
    Friend WithEvents txt_Jumlah As System.Windows.Forms.TextBox
    Friend WithEvents txt_NamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.Label
    Friend WithEvents pnlLaporan As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_Total As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtPendapatan As System.Windows.Forms.TextBox
    Friend WithEvents DGVLaporan As System.Windows.Forms.DataGridView
    Friend WithEvents pnlTentangApk As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class

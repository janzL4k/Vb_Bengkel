Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class Form3
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim Panjang
    Dim garis

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If

    End Sub

    Sub hapusdata()
        txtID.Clear()
        txt_NamaBarang.Clear()
        txtID.Focus()

    End Sub

    Private Sub btnMaster_Click(sender As Object, e As EventArgs) Handles btnMaster.Click

        Call TampilData_Penjualan()
        'buttton dipilih
        lblSelected1.Visible = True
        lblSelected2.Visible = False
        lblSelected3.Visible = False

        lblSelected5.Visible = False
        lblSelected6.Visible = False

        'menampilkan panel conten
        pnlBarang.Visible = True
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
        ''pnlLainnya.Visible = False
        pnlTentangApk.Visible = False

    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = True
        lblSelected3.Visible = False

        lblSelected5.Visible = False
        lblSelected6.Visible = False

        'menampilkan panel conten
        pnlBarang.Visible = False
        pnlTransaksi.Visible = True
        pnlLaporan.Visible = False
        ''pnlLainnya.Visible = False
        pnlTentangApk.Visible = False

    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        Call TampilData_Laporan()
        Call total()
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = True

        lblSelected5.Visible = False
        lblSelected6.Visible = False

        'menampilkan panel conten
        pnlBarang.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = True
        ''pnlLainnya.Visible = False
        pnlTentangApk.Visible = False

    End Sub


    Private Sub btnTentangAPK_Click(sender As Object, e As EventArgs) Handles btnTentangAPK.Click

        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False

        lblSelected5.Visible = True
        lblSelected6.Visible = False

        'menampilkan panel conten
        pnlBarang.Visible = False
        pnlTransaksi.Visible = False
        pnlLaporan.Visible = False
        pnlTentangApk.Visible = True
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        lblSelected1.Visible = False
        lblSelected2.Visible = False
        lblSelected3.Visible = False

        lblSelected5.Visible = False
        lblSelected6.Visible = True
        End
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilData_Bengkel()
        Call TampilData_Penjualan()
        Call TampilData_Laporan()
        Call total()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call Koneksi()
        If txtID.Text = "" Or txt_NamaBarang.Text = "" Or txt_Jumlah.Text = "" Or txtJmlh_uang.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Information, "Information")
            txtID.Focus()
            Exit Sub
        Else
            Call Koneksi()
            txtID.Focus()
            cmd = New OleDbCommand("Select * From data_bengkel where ID_Barang= '" & txtID.Text & "' ", Conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                Call Koneksi()

                Dim Simpan As String = "insert into data_bengkel(ID_Barang,Nama,Tanggal,Jumlah,Harga,Total_Harga,Jmlh_uang,Kembalian) Values('" & txtID.Text & "','" & txt_NamaBarang.Text & "','" & tgl.Text & "','" & txt_Jumlah.Text & "','" & txt_Harga.Text & "','" & txt_Total.Text & "','" & txtJmlh_uang.Text & "','" & txtKembalian.Text & "')"
                cmd = New OleDbCommand(Simpan, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Simpan Data Sukses", MsgBoxStyle.Information, "Information")
                txtID.Text = ""
                txt_NamaBarang.Text = ""
                tgl.Text = ""
                txt_Jumlah.Text = ""

                txt_Harga.Text = ""
                txt_Total.Text = ""
                txtJmlh_uang.Text = ""
                txtKembalian.Text = ""

            Else
                MsgBox("ID sudah digunakan", MsgBoxStyle.Information, "Information")
                txtID.Text = ""
                txt_NamaBarang.Text = ""
                tgl.Text = ""
                txt_Jumlah.Text = ""

                txt_Harga.Text = ""
                txt_Total.Text = ""
                txtJmlh_uang.Text = ""
                txtKembalian.Text = ""

            End If
        End If

    End Sub

    Sub TampilData_Bengkel()
        da = New OleDbDataAdapter("Select * From data_bengkel", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "data_bengkel")
        DataGridView1.DataSource = ds.Tables("data_bengkel")
        DataGridView1.Refresh()
    End Sub

    Sub TampilData_Penjualan()
        da = New OleDbDataAdapter("Select * From data_bengkel", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "data_bengkel")
        DGV.DataSource = ds.Tables("data_bengkel")
        DGV.Refresh()
    End Sub

    Sub TampilData_Laporan()
        da = New OleDbDataAdapter("Select * From data_bengkel", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "data_bengkel")
        DGVLaporan.DataSource = ds.Tables("data_bengkel")
        DGVLaporan.Refresh()
    End Sub

    Private Sub total()
        Call TampilData_Bengkel()

        Dim total As Long = 0
        For t As Integer = 0 To DGV.Rows.Count - 1
            total = total + Val(DGV.Rows(t).Cells(6).Value)
        Next
        txtPendapatan.Text = total



    End Sub


    Private Sub btn_Proses_Click(sender As Object, e As EventArgs) Handles btn_Proses.Click
        Dim a, b As Integer

        Dim hasil As Integer
        If txtID.Text = "" Or txt_NamaBarang.Text = "" Or txt_Jumlah.Text = "" Or tgl.Text = "" Or txt_Harga.Text = "" Then
            MsgBox("Input data dulu!", MsgBoxStyle.Information, "Information")
            txtID.Focus()
            Exit Sub
        Else
            a = txt_Jumlah.Text
            b = txt_Harga.Text

            hasil = a * b
            txt_Total.Text = hasil

            txt_Total.Text = hasil



        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim x, y, kembalian As Integer
        If txtJmlh_uang.Text = "" Then
            MsgBox("Masukkan Jumlah Uang!", MsgBoxStyle.Information, "Information")
            txtID.Focus()
            Exit Sub
        Else
            x = txtJmlh_uang.Text
            y = txt_Total.Text
            kembalian = x - y
            txtKembalian.Text = kembalian
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Koneksi()
        Call TampilData_Bengkel()
    End Sub


    '' Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        txtID.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        txt_NamaBarang.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        tgl.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txt_Jumlah.Text = DGV.Rows(e.RowIndex).Cells(3).Value

        '' txt_Harga.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        txt_Harga.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        ''cbKualitas.Text = DGV.Rows(e.RowIndex).Cells(6).Value
        txt_Total.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        txtJmlh_uang.Text = DGV.Rows(e.RowIndex).Cells(6).Value
        txtKembalian.Text = DGV.Rows(e.RowIndex).Cells(7).Value
        txtID.Enabled = False
        ''End Sub
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtID.Text = "" Or txt_NamaBarang.Text = "" Or tgl.Text = "" Or txt_Jumlah.Text = "" Or txt_Harga.Text = "" Or txtJmlh_uang.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.Information, "Information")
            txtID.Focus()
            Exit Sub
        Else
            Call Koneksi()
            cmd = New OleDbCommand("Update data_bengkel set Nama='" & txt_NamaBarang.Text & "',Tanggal='" & tgl.Text & "',Jumlah='" & txt_Jumlah.Text & "',Harga='" & txt_Harga.Text & "',Total_Harga='" & txt_Total.Text & "' where ID_Barang='" & txtID.Text & "'", Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Edit Data Sukses", MsgBoxStyle.Information, "Information")
            txtID.Text = ""
            txt_NamaBarang.Text = ""
            tgl.Text = ""
            txt_Jumlah.Text = ""
            txt_Harga.Text = ""
            txt_Total.Text = ""
            txtJmlh_uang.Text = ""
            txtKembalian.Text = ""

        End If

        Call TampilData_Bengkel()

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        pnlTransaksi.Show()
        pnlTransaksi.Visible = True
        pnlBarang.Visible = False
        txtID.Enabled = True
        txtID.Text = ""
        txt_NamaBarang.Text = ""
        tgl.Text = ""
        txt_Jumlah.Text = ""
        txt_Harga.Text = ""
        txt_Total.Text = ""
        txtJmlh_uang.Text = ""
        txtKembalian.Text = ""

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        cmd = New OleDbCommand("Select * From data_bengkel'" & txtID.Text & "' ", Conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            MsgBox("Data Kosong", MsgBoxStyle.Information, "Information")
            Exit Sub
        Else
            pnlTransaksi.Show()
            pnlBarang.Visible = False
            pnlTransaksi.Visible = True
            txtID.Enabled = False
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub pnlBarang_Paint(sender As Object, e As PaintEventArgs) Handles pnlBarang.Paint

    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

        Call TampilData_Bengkel()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        cmd = New OleDbCommand("Select * From data_bengkel'" & txtID.Text & "' ", Conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            MsgBox("Data Kosong", MsgBoxStyle.Information, "Information")
            Exit Sub
        Else
            cmd = New OleDbCommand("delete From data_bengkel where ID_Barang='" & txtID.Text & "'", Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Yakin Mau Hapus Data?", MsgBoxStyle.Information, "Information")
            Call TampilData_Penjualan()
            Call hapusdata()
            Call Koneksi()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        cmd = New OleDbCommand("Select * From data_bengkel'" & txtID.Text & "' ", Conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            MsgBox("Data Kosong", MsgBoxStyle.Information, "Information")
            Exit Sub
        Else
            pnlLaporan.Show()
            pnlBarang.Visible = False
            pnlLaporan.Visible = True
            txtID.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If txtJmlh_uang.Text = "" Or txtKembalian.Text = "" Then
            MsgBox("Masukkan Uang Pelanggan Setelah itu click button Hitung", MsgBoxStyle.Information, "Information")
            txtID.Focus()
            Exit Sub
        Else
            Call ubahpanjang()
            PPD.Document = PD
            PPD.ShowDialog()
            Call Koneksi()
            txtID.Focus()
            cmd = New OleDbCommand("Select * From data_bengkel where ID_Barang= '" & txtID.Text & "' ", Conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                Call Koneksi()

                Dim Simpan As String = "insert into data_bengkel(ID_Barang,Nama,Tanggal,Jumlah,Harga,Total_Harga,Jmlh_uang,Kembalian) Values('" & txtID.Text & "','" & txt_NamaBarang.Text & "','" & tgl.Text & "','" & txt_Jumlah.Text & "','" & txt_Harga.Text & "','" & txt_Total.Text & "','" & txtJmlh_uang.Text & "','" & txtKembalian.Text & "')"
                cmd = New OleDbCommand(Simpan, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Simpan Data ?", MsgBoxStyle.YesNo, "Information")
                txtID.Text = ""
                txt_NamaBarang.Text = ""
                tgl.Text = ""
                txt_Jumlah.Text = ""
                txt_Harga.Text = ""
                txt_Total.Text = ""
                txtJmlh_uang.Text = ""
                txtKembalian.Text = ""

            End If
        End If
    End Sub

    Sub ubahpanjang()
        Dim rowcount As Integer
        Panjang = 0
        rowcount = DGV.Rows.Count
        Panjang = rowcount * 30
        Panjang = Panjang + 150
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("cutom", 250, Panjang)
        PD.DefaultPageSettings = pagesetup

    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        On Error Resume Next
        cmd = New OleDbCommand("Select * From data_bengkel'" & txtID.Text & "' ", Conn)
        Call Koneksi()
        Dim f9 As New Font("Times new roman", 5, FontStyle.Regular)
        Dim f10 As New Font("Times new roman", 10, FontStyle.Regular)
        Dim f14 As New Font("Times new roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        garis = "-----------------------------------------------------------"

        e.Graphics.DrawString("Bengkel Onderdil", f14, Brushes.Blue, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl.Raya Pendidikan no 12", f10, Brushes.Blue, centermargin, 27, tengah)
        e.Graphics.DrawString("Tlp. 081907943762", f10, Brushes.Blue, centermargin, 42, tengah)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 48)

        e.Graphics.DrawString("ID_Barang", f10, Brushes.Black, 0, 67)
        e.Graphics.DrawString(":", f10, Brushes.Black, 100, 67)
        e.Graphics.DrawString(txtID.Text, f10, Brushes.Black, 110, 67)

        e.Graphics.DrawString("Nama Barang", f10, Brushes.Black, 0, 85)
        e.Graphics.DrawString(":", f10, Brushes.Black, 100, 85)
        e.Graphics.DrawString(txt_NamaBarang.Text, f10, Brushes.Black, 110, 85)

        e.Graphics.DrawString("Tanggal", f10, Brushes.Black, 0, 100)
        e.Graphics.DrawString(":", f10, Brushes.Black, 100, 100)
        e.Graphics.DrawString(tgl.Text, f10, Brushes.Black, 110, 100)

        e.Graphics.DrawString("Jumlah Beli", f10, Brushes.Black, 0, 115)
        e.Graphics.DrawString(":", f10, Brushes.Black, 100, 115)
        e.Graphics.DrawString(txt_Jumlah.Text, f10, Brushes.Black, 110, 115)

        e.Graphics.DrawString("Harga", f10, Brushes.Black, 0, 145)
        e.Graphics.DrawString(":", f10, Brushes.Black, 100, 145)
        e.Graphics.DrawString(txt_Harga.Text, f10, Brushes.Black, 110, 145)

        e.Graphics.DrawString("Total_Harga", f10, Brushes.Black, 0, 175)
        e.Graphics.DrawString(":", f10, Brushes.Black, 100, 175)
        e.Graphics.DrawString(txt_Total.Text, f10, Brushes.Black, 110, 175)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 190)
        e.Graphics.DrawString("Kasir : Ibjan Syarif H.S", f10, Brushes.Black, 0, 175)
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 190)
    End Sub

    Private Sub DGVLaporan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVLaporan.CellContentClick
        Call TampilData_Laporan()
    End Sub

    Private Sub pnlLaporan_Paint(sender As Object, e As PaintEventArgs) Handles pnlLaporan.Paint
        Call TampilData_Laporan()
    End Sub

    Private Sub txtPendapatan_TextChanged(sender As Object, e As EventArgs) Handles txtPendapatan.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub lblSelected3_Click(sender As Object, e As EventArgs) Handles lblSelected3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
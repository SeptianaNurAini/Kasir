Public Class FormMenuKasir
    Dim harga As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblkode.Text = "Kode Barang"
        lblnama.Text = "Nama Barang"
        lbljumlah.Text = "Jumlah"
        lbldiskon.Text = "Diskon"
        lblppn.Text = "PPN"
        lbltotal.Text = "Total : Rp."
        lblbayar.Text = "Bayar"
        lblkembali.Text = "Kembali"
        lbltanggal.Text = Today
        btninput.Text = "Input"
        btnbatal.Text = "Batal"
        btntotal.Text = "Total"
        btnbayar.Text = "Bayar"
        txtnama.Text = ""
        txtjumlah.Text = 0
        txttotal.Text = ""
        txtppn.Text = ""
        txtbayar.Text = ""
        txtppn.Text = 0
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbljam.Text = TimeOfDay
    End Sub

    Private Sub btninput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninput.Click
        If txtnama.Text = "" Or cbkode.Text = "" Or txtjumlah.Text = "" Or txtppn.Text = "" Or cbdiskon.Text = "" Then
            MsgBox("Anda Harus Mengisi Semua Data!", MsgBoxStyle.Information + vbOKOnly, "Atention")
            txtnama.Focus()
        ElseIf txtjumlah.Text = 0 Then
            MsgBox("Jumlah Harus Di Isi!", MsgBoxStyle.Information + vbOKOnly, "Atention")
            txtjumlah.Focus()
            txtjumlah.Text = ""
        Else
            DGVinput.Rows.Add(1)
            DGVinput.Rows(DGVinput.RowCount - 2).Cells(0).Value = cbkode.Text
            DGVinput.Rows(DGVinput.RowCount - 2).Cells(1).Value = txtnama.Text
            DGVinput.Rows(DGVinput.RowCount - 2).Cells(2).Value = harga
            DGVinput.Rows(DGVinput.RowCount - 2).Cells(3).Value = txtjumlah.Text
            DGVinput.Rows(DGVinput.RowCount - 2).Cells(4).Value = txtppn.Text + "%"
            DGVinput.Rows(DGVinput.RowCount - 2).Cells(5).Value = cbdiskon.Text + "%"
            DGVinput.Rows(DGVinput.RowCount - 2).Cells(6).Value = (harga - (harga * (cbdiskon.Text * 0.01))) * txtjumlah.Text + +(harga * (txtppn.Text * 0.01))
            DGVinput.Update()
        End If
        If DGVinput.Rows.Count > 0 Then
            btntotal.Enabled = True
            btnbatal.Enabled = True
        ElseIf DGVinput.Rows.Count < 0 Then
            btntotal.Enabled = True
            btnbatal.Enabled = True
        End If
    End Sub

    Private Sub cbkode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbkode.SelectedIndexChanged
        If cbkode.Text = "AA001" Then
            txtnama.Text = "Oreo"
            harga = 12000
        ElseIf cbkode.Text = "AA002" Then
            txtnama.Text = "Good Day"
            harga = 8000
        ElseIf cbkode.Text = "AA003" Then
            txtnama.Text = "Nu Milk Tea"
            harga = 6000
        ElseIf cbkode.Text = "AA004" Then
            txtnama.Text = "Sprite"
            harga = 5000
        ElseIf cbkode.Text = "AA005" Then
            txtnama.Text = "Citato"
            harga = 11000
        ElseIf cbkode.Text = "AA006" Then
            txtnama.Text = "Lays"
            harga = 13000
        ElseIf cbkode.Text = "BB001" Then
            txtnama.Text = "Molto"
            harga = 15000
        ElseIf cbkode.Text = "BB002" Then
            txtnama.Text = "Mama Lemon"
            harga = 9000
        ElseIf cbkode.Text = "BB003" Then
            txtnama.Text = "Rinso"
            harga = 20000
        ElseIf cbkode.Text = "BB004" Then
            txtnama.Text = "Dove"
            harga = 28000
        ElseIf cbkode.Text = "BB005" Then
            txtnama.Text = "Biore"
            harga = 26000
        ElseIf cbkode.Text = "BB006" Then
            txtnama.Text = "Pantene"
            harga = 19000
        ElseIf cbkode.Text = "CC001" Then
            txtnama.Text = "Bimoli"
            harga = 28000
        ElseIf cbkode.Text = "CC002" Then
            txtnama.Text = "Kecap Bangau"
            harga = 8000
        ElseIf cbkode.Text = "CC003" Then
            txtnama.Text = "Gula Pasir"
            harga = 11000
        ElseIf cbkode.Text = "CC004" Then
            txtnama.Text = "Saus Sambal ABC"
            harga = 7000
        ElseIf cbkode.Text = "CC005" Then
            txtnama.Text = "Boncabe"
            harga = 6000
        ElseIf cbkode.Text = "CC006" Then
            txtnama.Text = "Indomie Goreng"
            harga = 3000
        ElseIf cbkode.Text = "DD001" Then
            txtnama.Text = "Ramen"
            harga = 5000
        ElseIf cbkode.Text = "DD002" Then
            txtnama.Text = "Silver Queen"
            harga = 17000
        ElseIf cbkode.Text = "DD003" Then
            txtnama.Text = "Mie Sedaap Goreng"
            harga = 3000
        ElseIf cbkode.Text = "DD004" Then
            txtnama.Text = "Wardah Facial Wash"
            harga = 28000
        ElseIf cbkode.Text = "DD005" Then
            txtnama.Text = "Acness"
            harga = 32000
        ElseIf cbkode.Text = "DD006" Then
            txtnama.Text = "Sariayu"
            harga = 25000

        End If
    End Sub

    Private Sub btntotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntotal.Click
        Dim total As Integer
        For baris As Integer = 0 To DGVinput.Rows.Count - 1
            total = total + +DGVinput.Rows(baris).Cells(6).Value
        Next
        txttotal.Text = total
        btnbayar.Enabled = True
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        DGVinput.Rows.RemoveAt(DGVinput.CurrentRow.Index)
        If DGVinput.Rows.Count > 1 Then
            btntotal.Enabled = True
            btnbatal.Enabled = True
        ElseIf DGVinput.Rows.Count <= 1 Then
            btntotal.Enabled = True
            btnbatal.Enabled = True
        End If
    End Sub

    Private Sub btnbayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbayar.Click
        If txtbayar.Text = "" Then
            MsgBox("Anda Belum Memasukkan Jumlah Uang", MsgBoxStyle.Exclamation + vbOKOnly, "Perhatian")
            txtbayar.Focus()
        ElseIf txtbayar.Text - txttotal.Text < 0 Then
            MsgBox("Jumlah Uang Yang Anda Masukkan Belum Cukup", MsgBoxStyle.Exclamation + vbOKOnly, "Perhatian")
            txtbayar.Focus()
            txtbayar.Text = ""
        ElseIf txtbayar.Text - txttotal.Text > 0 Then
            txtkembali.Text = txtbayar.Text - txttotal.Text

        End If
    End Sub
    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        cbkode.Text = ""
        cbdiskon.Text = ""
        txtjumlah.Text = ""
        txtnama.Text = ""
        txtppn.Text = ""
        txttotal.Text = ""
        txtbayar.Text = ""
        txtkembali.Text = ""
        cbkode.Focus()

    End Sub
    Private Sub btncetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncetak.Click
        If txtbayar.Text = "" Then
            MsgBox("Anda Belum Memasukkan Jumlah Uang", MsgBoxStyle.Exclamation + vbOKOnly, "Perhatian")
            txtbayar.Focus()
        ElseIf txtbayar.Text - txttotal.Text < 0 Then
            MsgBox("Jumlah Uang Yang Anda Masukkan Belum Cukup", MsgBoxStyle.Exclamation + vbOKOnly, "Perhatian")
            txtbayar.Focus()
            txtbayar.Text = ""
        ElseIf txtbayar.Text - txttotal.Text >= 0 Then
            MsgBox("Anda Berhasil Melakukan Pembayaran", MsgBoxStyle.Exclamation + vbOKOnly, "Transaksi Berhasil")
            txtkembali.Text = txtbayar.Text - txttotal.Text

            FormStruk.lblkasir.Text = "Septiana"
            With FormStruk.ListView1
                For baris As Integer = 0 To DGVinput.RowCount - 2
                    .Items.Add(Me.DGVinput.Rows(baris).Cells(1).Value)
                    .Items.Add(Me.DGVinput.Rows(baris).Cells(2).Value)
                    .Items.Add(Me.DGVinput.Rows(baris).Cells(3).Value)
                    .Items.Add(Me.DGVinput.Rows(baris).Cells(4).Value)
                    .Items.Add(Me.DGVinput.Rows(baris).Cells(5).Value)
                    .Items.Add(Me.DGVinput.Rows(baris).Cells(6).Value)
                    With .Items(.Items.Count - 1).SubItems
                        .Add(Me.DGVinput.Rows(baris).Cells(2).Value)
                        .Add(Me.DGVinput.Rows(baris).Cells(3).Value)
                        .Add(Me.DGVinput.Rows(baris).Cells(4).Value)
                        .Add(Me.DGVinput.Rows(baris).Cells(5).Value)
                        .Add(Me.DGVinput.Rows(baris).Cells(6).Value)
                    End With
                Next
            End With
            FormStruk.lbltotal.Text = Me.txttotal.Text
            FormStruk.lbluang.Text = Me.txtbayar.Text
            FormStruk.lblkembali.Text = Me.txtkembali.Text
            FormStruk.Show()
        Else
            MsgBox("Anda Berhasil Melakukan Transaksi", MsgBoxStyle.Information + vbOKOnly, "Succesful")
        End If
    End Sub

   
    Private Sub lbltanggal_Click(sender As System.Object, e As System.EventArgs) Handles lbltanggal.Click

    End Sub
End Class

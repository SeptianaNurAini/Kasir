<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuKasir
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
        Me.components = New System.ComponentModel.Container()
        Me.lblkasir = New System.Windows.Forms.Label()
        Me.lblkode = New System.Windows.Forms.Label()
        Me.lblnama = New System.Windows.Forms.Label()
        Me.lbljumlah = New System.Windows.Forms.Label()
        Me.lbldiskon = New System.Windows.Forms.Label()
        Me.lblppn = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.cbkode = New System.Windows.Forms.ComboBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.cbdiskon = New System.Windows.Forms.ComboBox()
        Me.txtppn = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.lblpersendiskon = New System.Windows.Forms.Label()
        Me.lblpersenppn = New System.Windows.Forms.Label()
        Me.DGVinput = New System.Windows.Forms.DataGridView()
        Me.dgvkode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvnamabarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvharga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvjumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvppn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvdiskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblbayar = New System.Windows.Forms.Label()
        Me.lblkembali = New System.Windows.Forms.Label()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.txtkembali = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btninput = New System.Windows.Forms.Button()
        Me.btnbayar = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btntotal = New System.Windows.Forms.Button()
        Me.lbljam = New System.Windows.Forms.Label()
        Me.lbltanggal = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btncetak = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        CType(Me.DGVinput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblkasir
        '
        Me.lblkasir.AutoSize = True
        Me.lblkasir.Font = New System.Drawing.Font("Calisto MT", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblkasir.Location = New System.Drawing.Point(12, 18)
        Me.lblkasir.Name = "lblkasir"
        Me.lblkasir.Size = New System.Drawing.Size(146, 46)
        Me.lblkasir.TabIndex = 0
        Me.lblkasir.Text = "KASIR"
        '
        'lblkode
        '
        Me.lblkode.AutoSize = True
        Me.lblkode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkode.Location = New System.Drawing.Point(17, 106)
        Me.lblkode.Name = "lblkode"
        Me.lblkode.Size = New System.Drawing.Size(102, 20)
        Me.lblkode.TabIndex = 1
        Me.lblkode.Text = "Kode Barang"
        '
        'lblnama
        '
        Me.lblnama.AutoSize = True
        Me.lblnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnama.Location = New System.Drawing.Point(17, 148)
        Me.lblnama.Name = "lblnama"
        Me.lblnama.Size = New System.Drawing.Size(107, 20)
        Me.lblnama.TabIndex = 2
        Me.lblnama.Text = "Nama Barang"
        '
        'lbljumlah
        '
        Me.lbljumlah.AutoSize = True
        Me.lbljumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljumlah.Location = New System.Drawing.Point(17, 193)
        Me.lbljumlah.Name = "lbljumlah"
        Me.lbljumlah.Size = New System.Drawing.Size(60, 20)
        Me.lbljumlah.TabIndex = 3
        Me.lbljumlah.Text = "Jumlah"
        '
        'lbldiskon
        '
        Me.lbldiskon.AutoSize = True
        Me.lbldiskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiskon.Location = New System.Drawing.Point(397, 106)
        Me.lbldiskon.Name = "lbldiskon"
        Me.lbldiskon.Size = New System.Drawing.Size(58, 20)
        Me.lbldiskon.TabIndex = 4
        Me.lbldiskon.Text = "Diskon"
        '
        'lblppn
        '
        Me.lblppn.AutoSize = True
        Me.lblppn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblppn.Location = New System.Drawing.Point(397, 148)
        Me.lblppn.Name = "lblppn"
        Me.lblppn.Size = New System.Drawing.Size(40, 20)
        Me.lblppn.TabIndex = 5
        Me.lblppn.Text = "PPN"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Calisto MT", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lbltotal.Location = New System.Drawing.Point(393, 27)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(262, 46)
        Me.lbltotal.TabIndex = 6
        Me.lbltotal.Text = "TOTAL : Rp."
        '
        'cbkode
        '
        Me.cbkode.FormattingEnabled = True
        Me.cbkode.Items.AddRange(New Object() {"AA001", "AA002", "AA003", "AA004", "AA005", "AA005", "BB001", "BB002", "BB003", "BB004", "BB005", "BB006", "CC001", "CC002", "CC003", "CC004", "CC005", "CC006", "DD001", "DD002", "DD003", "DD004", "DD005", "DD006"})
        Me.cbkode.Location = New System.Drawing.Point(147, 105)
        Me.cbkode.Name = "cbkode"
        Me.cbkode.Size = New System.Drawing.Size(168, 21)
        Me.cbkode.TabIndex = 7
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(147, 150)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(168, 20)
        Me.txtnama.TabIndex = 8
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(147, 195)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(168, 20)
        Me.txtjumlah.TabIndex = 9
        '
        'cbdiskon
        '
        Me.cbdiskon.FormattingEnabled = True
        Me.cbdiskon.Items.AddRange(New Object() {"0", "5", "10", "15", "20", "25", "30", "50", "60"})
        Me.cbdiskon.Location = New System.Drawing.Point(484, 105)
        Me.cbdiskon.Name = "cbdiskon"
        Me.cbdiskon.Size = New System.Drawing.Size(168, 21)
        Me.cbdiskon.TabIndex = 10
        '
        'txtppn
        '
        Me.txtppn.Location = New System.Drawing.Point(484, 150)
        Me.txtppn.Name = "txtppn"
        Me.txtppn.Size = New System.Drawing.Size(168, 20)
        Me.txtppn.TabIndex = 11
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Calisto MT", 30.0!)
        Me.txttotal.Location = New System.Drawing.Point(658, 18)
        Me.txttotal.Multiline = True
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(247, 65)
        Me.txttotal.TabIndex = 12
        '
        'lblpersendiskon
        '
        Me.lblpersendiskon.AutoSize = True
        Me.lblpersendiskon.Location = New System.Drawing.Point(658, 111)
        Me.lblpersendiskon.Name = "lblpersendiskon"
        Me.lblpersendiskon.Size = New System.Drawing.Size(15, 13)
        Me.lblpersendiskon.TabIndex = 13
        Me.lblpersendiskon.Text = "%"
        '
        'lblpersenppn
        '
        Me.lblpersenppn.AutoSize = True
        Me.lblpersenppn.Location = New System.Drawing.Point(658, 153)
        Me.lblpersenppn.Name = "lblpersenppn"
        Me.lblpersenppn.Size = New System.Drawing.Size(15, 13)
        Me.lblpersenppn.TabIndex = 14
        Me.lblpersenppn.Text = "%"
        '
        'DGVinput
        '
        Me.DGVinput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVinput.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvkode, Me.dgvnamabarang, Me.dgvharga, Me.dgvjumlah, Me.dgvppn, Me.dgvdiskon, Me.dgvtotal})
        Me.DGVinput.Location = New System.Drawing.Point(21, 235)
        Me.DGVinput.Name = "DGVinput"
        Me.DGVinput.Size = New System.Drawing.Size(884, 150)
        Me.DGVinput.TabIndex = 15
        '
        'dgvkode
        '
        Me.dgvkode.HeaderText = "Kode Barang"
        Me.dgvkode.Name = "dgvkode"
        Me.dgvkode.Width = 120
        '
        'dgvnamabarang
        '
        Me.dgvnamabarang.HeaderText = "Nama Barang"
        Me.dgvnamabarang.Name = "dgvnamabarang"
        Me.dgvnamabarang.Width = 120
        '
        'dgvharga
        '
        Me.dgvharga.HeaderText = "Harga"
        Me.dgvharga.Name = "dgvharga"
        Me.dgvharga.Width = 120
        '
        'dgvjumlah
        '
        Me.dgvjumlah.HeaderText = "Jumlah"
        Me.dgvjumlah.Name = "dgvjumlah"
        Me.dgvjumlah.Width = 120
        '
        'dgvppn
        '
        Me.dgvppn.HeaderText = "PPN"
        Me.dgvppn.Name = "dgvppn"
        Me.dgvppn.Width = 120
        '
        'dgvdiskon
        '
        Me.dgvdiskon.HeaderText = "Diskon"
        Me.dgvdiskon.Name = "dgvdiskon"
        Me.dgvdiskon.Width = 120
        '
        'dgvtotal
        '
        Me.dgvtotal.HeaderText = "Total"
        Me.dgvtotal.Name = "dgvtotal"
        Me.dgvtotal.Width = 120
        '
        'lblbayar
        '
        Me.lblbayar.AutoSize = True
        Me.lblbayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbayar.Location = New System.Drawing.Point(657, 411)
        Me.lblbayar.Name = "lblbayar"
        Me.lblbayar.Size = New System.Drawing.Size(50, 20)
        Me.lblbayar.TabIndex = 16
        Me.lblbayar.Text = "Bayar"
        '
        'lblkembali
        '
        Me.lblkembali.AutoSize = True
        Me.lblkembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkembali.Location = New System.Drawing.Point(657, 451)
        Me.lblkembali.Name = "lblkembali"
        Me.lblkembali.Size = New System.Drawing.Size(65, 20)
        Me.lblkembali.TabIndex = 17
        Me.lblkembali.Text = "Kembali"
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(725, 411)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(171, 20)
        Me.txtbayar.TabIndex = 18
        '
        'txtkembali
        '
        Me.txtkembali.Location = New System.Drawing.Point(728, 453)
        Me.txtkembali.Name = "txtkembali"
        Me.txtkembali.Size = New System.Drawing.Size(168, 20)
        Me.txtkembali.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "PEDURUNGAN, SEMARANG, 50192"
        '
        'btninput
        '
        Me.btninput.Location = New System.Drawing.Point(706, 103)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(75, 23)
        Me.btninput.TabIndex = 21
        Me.btninput.Text = "Input"
        Me.btninput.UseVisualStyleBackColor = True
        '
        'btnbayar
        '
        Me.btnbayar.Location = New System.Drawing.Point(520, 411)
        Me.btnbayar.Name = "btnbayar"
        Me.btnbayar.Size = New System.Drawing.Size(75, 23)
        Me.btnbayar.TabIndex = 22
        Me.btnbayar.Text = "Bayar"
        Me.btnbayar.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(706, 145)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.btnbatal.TabIndex = 23
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btntotal
        '
        Me.btntotal.Location = New System.Drawing.Point(706, 190)
        Me.btntotal.Name = "btntotal"
        Me.btntotal.Size = New System.Drawing.Size(75, 23)
        Me.btntotal.TabIndex = 24
        Me.btntotal.Text = "Total"
        Me.btntotal.UseVisualStyleBackColor = True
        '
        'lbljam
        '
        Me.lbljam.AutoSize = True
        Me.lbljam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbljam.Location = New System.Drawing.Point(32, 451)
        Me.lbljam.Name = "lbljam"
        Me.lbljam.Size = New System.Drawing.Size(2, 15)
        Me.lbljam.TabIndex = 26
        '
        'lbltanggal
        '
        Me.lbltanggal.AutoSize = True
        Me.lbltanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltanggal.Location = New System.Drawing.Point(32, 416)
        Me.lbltanggal.Name = "lbltanggal"
        Me.lbltanggal.Size = New System.Drawing.Size(2, 15)
        Me.lbltanggal.TabIndex = 25
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(520, 448)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(75, 23)
        Me.btncetak.TabIndex = 27
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(806, 105)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 28
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'FormMenuKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(917, 494)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btncetak)
        Me.Controls.Add(Me.lbljam)
        Me.Controls.Add(Me.lbltanggal)
        Me.Controls.Add(Me.btntotal)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnbayar)
        Me.Controls.Add(Me.btninput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtkembali)
        Me.Controls.Add(Me.txtbayar)
        Me.Controls.Add(Me.lblkembali)
        Me.Controls.Add(Me.lblbayar)
        Me.Controls.Add(Me.DGVinput)
        Me.Controls.Add(Me.lblpersenppn)
        Me.Controls.Add(Me.lblpersendiskon)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtppn)
        Me.Controls.Add(Me.cbdiskon)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.cbkode)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblppn)
        Me.Controls.Add(Me.lbldiskon)
        Me.Controls.Add(Me.lbljumlah)
        Me.Controls.Add(Me.lblnama)
        Me.Controls.Add(Me.lblkode)
        Me.Controls.Add(Me.lblkasir)
        Me.Name = "FormMenuKasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KASIR"
        CType(Me.DGVinput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblkasir As System.Windows.Forms.Label
    Friend WithEvents lblkode As System.Windows.Forms.Label
    Friend WithEvents lblnama As System.Windows.Forms.Label
    Friend WithEvents lbljumlah As System.Windows.Forms.Label
    Friend WithEvents lbldiskon As System.Windows.Forms.Label
    Friend WithEvents lblppn As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents cbkode As System.Windows.Forms.ComboBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents cbdiskon As System.Windows.Forms.ComboBox
    Friend WithEvents txtppn As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents lblpersendiskon As System.Windows.Forms.Label
    Friend WithEvents lblpersenppn As System.Windows.Forms.Label
    Friend WithEvents DGVinput As System.Windows.Forms.DataGridView
    Friend WithEvents lblbayar As System.Windows.Forms.Label
    Friend WithEvents lblkembali As System.Windows.Forms.Label
    Friend WithEvents txtbayar As System.Windows.Forms.TextBox
    Friend WithEvents txtkembali As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btninput As System.Windows.Forms.Button
    Friend WithEvents btnbayar As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btntotal As System.Windows.Forms.Button
    Friend WithEvents dgvkode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvnamabarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvharga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvjumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvppn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvdiskon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbljam As System.Windows.Forms.Label
    Friend WithEvents lbltanggal As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btncetak As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button

End Class

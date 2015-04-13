<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoaiSanpham
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.txtMaloai = New System.Windows.Forms.TextBox()
        Me.txttenloai = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnDanhsach = New System.Windows.Forms.Button()
        Me.txtngaynhap = New System.Windows.Forms.TextBox()
        Me.txtngaysx = New System.Windows.Forms.TextBox()
        Me.txtngayhh = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã loại SP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên loại SP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ngày nhập kho"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ngày sản xuất"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ngày hết hạn"
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(12, 286)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(454, 208)
        Me.DataGridView3.TabIndex = 6
        '
        'txtMaloai
        '
        Me.txtMaloai.Location = New System.Drawing.Point(240, 19)
        Me.txtMaloai.Name = "txtMaloai"
        Me.txtMaloai.Size = New System.Drawing.Size(189, 20)
        Me.txtMaloai.TabIndex = 9
        '
        'txttenloai
        '
        Me.txttenloai.Location = New System.Drawing.Point(240, 53)
        Me.txttenloai.Name = "txttenloai"
        Me.txttenloai.Size = New System.Drawing.Size(189, 20)
        Me.txttenloai.TabIndex = 10
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(17, 232)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 11
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(143, 232)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 12
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(269, 232)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 13
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnDanhsach
        '
        Me.btnDanhsach.Location = New System.Drawing.Point(391, 232)
        Me.btnDanhsach.Name = "btnDanhsach"
        Me.btnDanhsach.Size = New System.Drawing.Size(75, 23)
        Me.btnDanhsach.TabIndex = 14
        Me.btnDanhsach.Text = "Danh sách"
        Me.btnDanhsach.UseVisualStyleBackColor = True
        '
        'txtngaynhap
        '
        Me.txtngaynhap.Location = New System.Drawing.Point(240, 91)
        Me.txtngaynhap.Name = "txtngaynhap"
        Me.txtngaynhap.Size = New System.Drawing.Size(189, 20)
        Me.txtngaynhap.TabIndex = 15
        '
        'txtngaysx
        '
        Me.txtngaysx.Location = New System.Drawing.Point(240, 129)
        Me.txtngaysx.Name = "txtngaysx"
        Me.txtngaysx.Size = New System.Drawing.Size(189, 20)
        Me.txtngaysx.TabIndex = 16
        '
        'txtngayhh
        '
        Me.txtngayhh.Location = New System.Drawing.Point(240, 173)
        Me.txtngayhh.Name = "txtngayhh"
        Me.txtngayhh.Size = New System.Drawing.Size(189, 20)
        Me.txtngayhh.TabIndex = 17
        '
        'frmLoaiSanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 506)
        Me.Controls.Add(Me.txtngayhh)
        Me.Controls.Add(Me.txtngaysx)
        Me.Controls.Add(Me.txtngaynhap)
        Me.Controls.Add(Me.btnDanhsach)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txttenloai)
        Me.Controls.Add(Me.txtMaloai)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLoaiSanpham"
        Me.Text = "Loại_sản_phẩm"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents txtMaloai As System.Windows.Forms.TextBox
    Friend WithEvents txttenloai As System.Windows.Forms.TextBox
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnDanhsach As System.Windows.Forms.Button
    Friend WithEvents txtngaynhap As System.Windows.Forms.TextBox
    Friend WithEvents txtngaysx As System.Windows.Forms.TextBox
    Friend WithEvents txtngayhh As System.Windows.Forms.TextBox
End Class

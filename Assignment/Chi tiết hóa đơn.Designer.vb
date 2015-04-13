<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chi_tiết_hóa_đơn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chi_tiết_hóa_đơn))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnthem1 = New System.Windows.Forms.Button()
        Me.btnsua1 = New System.Windows.Forms.Button()
        Me.btnxoa1 = New System.Windows.Forms.Button()
        Me.btndanhsach1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Chi tiết hóa đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Số lượng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mã sản phẩm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Mã hóa đơn"
        '
        'btnthem1
        '
        Me.btnthem1.Location = New System.Drawing.Point(15, 263)
        Me.btnthem1.Name = "btnthem1"
        Me.btnthem1.Size = New System.Drawing.Size(75, 23)
        Me.btnthem1.TabIndex = 5
        Me.btnthem1.Text = "Thêm"
        Me.btnthem1.UseVisualStyleBackColor = True
        '
        'btnsua1
        '
        Me.btnsua1.Location = New System.Drawing.Point(132, 263)
        Me.btnsua1.Name = "btnsua1"
        Me.btnsua1.Size = New System.Drawing.Size(75, 23)
        Me.btnsua1.TabIndex = 6
        Me.btnsua1.Text = "Sửa"
        Me.btnsua1.UseVisualStyleBackColor = True
        '
        'btnxoa1
        '
        Me.btnxoa1.Location = New System.Drawing.Point(243, 263)
        Me.btnxoa1.Name = "btnxoa1"
        Me.btnxoa1.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa1.TabIndex = 7
        Me.btnxoa1.Text = "Xóa"
        Me.btnxoa1.UseVisualStyleBackColor = True
        '
        'btndanhsach1
        '
        Me.btndanhsach1.Location = New System.Drawing.Point(372, 263)
        Me.btndanhsach1.Name = "btndanhsach1"
        Me.btndanhsach1.Size = New System.Drawing.Size(75, 23)
        Me.btndanhsach1.TabIndex = 8
        Me.btndanhsach1.Text = "Danh sách"
        Me.btndanhsach1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(205, 144)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(210, 20)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(205, 181)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(210, 20)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(205, 221)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(210, 20)
        Me.TextBox3.TabIndex = 11
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(12, 305)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(452, 192)
        Me.DataGridView5.TabIndex = 12
        '
        'Chi_tiết_hóa_đơn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 509)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btndanhsach1)
        Me.Controls.Add(Me.btnxoa1)
        Me.Controls.Add(Me.btnsua1)
        Me.Controls.Add(Me.btnthem1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Chi_tiết_hóa_đơn"
        Me.Text = "Chi_tiết_hóa_đơn"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnthem1 As System.Windows.Forms.Button
    Friend WithEvents btnsua1 As System.Windows.Forms.Button
    Friend WithEvents btnxoa1 As System.Windows.Forms.Button
    Friend WithEvents btndanhsach1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
End Class

Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmLoaiSanpham

    Dim Dangnhap As String = "workstation id=thulmps02240.mssql.somee.com;packet size=4096;user id=thulmps02240_SQLLogin_1;pwd=cslhzeqijs;data source=thulmps02240.mssql.somee.com;persist security info=False;initial catalog=thulmps02240"
    Dim Assignment As New DataTable

    Private Sub Loại_sản_phẩm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        ' Kết nối đến database online
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        ' Mở kết nối
        Ketnoi.Open()

        Dim stradd As String = "insert into Loai_San_Pham Values (@Ma_Loai_SP, @Ten_LoaiSP, @Ngay_Nhap_Kho, @Ngay_San_Xuat, @Ngay_Het_Han)"
        Dim com As SqlCommand = New SqlCommand(stradd, Ketnoi)
        Try
            com.Parameters.AddWithValue("@Ma_Loai_SP", txtMaloai.Text)
            com.Parameters.AddWithValue("@Ten_LSP", txttenloai.Text)
            com.Parameters.AddWithValue("@Ngay_Nhap_Kho", txtngaynhap.Text)
            com.Parameters.AddWithValue("@Ngay_San_Xuat", txtngaysx.Text)
            com.Parameters.AddWithValue("@Ngay_Het_Han", txtngayhh.Text)

            ' Thực thi câu lệnh Insert dữ liệu vào database
            com.ExecuteNonQuery()
            ' Đóng kết nối
            Ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show(" Thêm thành công ")
        End Try
        Assignment.Clear()
        DataGridView3.DataSource = Assignment
        DataGridView3.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Dim SqlAdapter As New SqlDataAdapter("select * from Loai_San_Pham", Ketnoi)

        Try
            SqlAdapter.Fill(Assignment)

        Catch ex As Exception

        End Try
        DataGridView3.DataSource = Assignment
        Ketnoi.Close()
    End Sub

    Private Sub btnDanhsach_Click(sender As Object, e As EventArgs) Handles btnDanhsach.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Dim SqlAdapter As New SqlDataAdapter("select * from Loai_San_Pham", Ketnoi)

        Try
            Ketnoi.Open()
            SqlAdapter.Fill(Assignment)

        Catch ex As Exception

        End Try
        DataGridView3.DataSource = Assignment
        Ketnoi.Close()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Ketnoi.Open()
        ' Sửa dữ liệu
        Dim stradd As String = " UPDATE Loai_San_Pham SET Ten_LSP = @Ten_LSP, Ngay_Nhap_Kho = @Ngay_Nhap_Kho, Ngay_San_Xuat = @Ngay_San_Xuat, Ngay_Het_Han = @Ngay_Het_Han Where Ma_Loai_SP = @Ma_Loai_SP"
        Dim com As New SqlCommand(stradd, Ketnoi)

        Try
            ' Thêm dữ liệu vào câu truy vấn
            com.Parameters.AddWithValue("@Ma_Loai_SP", txtMaloai.Text)
            com.Parameters.AddWithValue("@Ten_LSP", txttenloai.Text)
            com.Parameters.AddWithValue("@Ngay_Nhap_Kho", txtngaynhap.Text)
            com.Parameters.AddWithValue("@Ngay_San_Xuat", txtngaysx.Text)
            com.Parameters.AddWithValue("@Ngay_Het_Han", txtngayhh.Text)
            ' Thực thi câu truy vấn
            com.ExecuteNonQuery()
            Ketnoi.Close()

        Catch ex As Exception
            MessageBox.Show(" Kết nối không thành công")

        End Try
        Assignment.Clear()
        DataGridView3.DataSource = Assignment
        DataGridView3.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Ketnoi.Open()
        ' Sửa dữ liệu
        Dim stradd As String = "Delete from Loai_San_Pham where Ma_LSP = @Ma_LSP"
        Dim com As New SqlCommand(stradd, Ketnoi)

        Try
            com.Parameters.AddWithValue("@Ma_LSP", txtMaloai.Text)
            com.ExecuteNonQuery()
            Ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối không thành công")
        End Try
        Assignment.Clear()
        DataGridView3.DataSource = Assignment
        DataGridView3.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        ' Click vào trong dòng nào, thì sẽ hiện dữ liệu lên textbox
        Dim index As Integer = DataGridView3.CurrentCell.RowIndex
        txtMaloai.Text = DataGridView3.Item(0, index).Value
        txttenloai.Text = DataGridView3.Item(1, index).Value
        txtngaynhap.Text = DataGridView3.Item(2, index).Value
        txtngaysx.Text = DataGridView3.Item(3, index).Value
        txtngayhh.Text = DataGridView3.Item(3, index).Value
    End Sub
End Class
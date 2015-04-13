Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Hóa_đơn
    Dim Dangnhap As String = "workstation id=thulmps02240.mssql.somee.com;packet size=4096;user id=thulmps02240_SQLLogin_1;pwd=cslhzeqijs;data source=thulmps02240.mssql.somee.com;persist security info=False;initial catalog=thulmps02240"
    Dim Assignment As New DataTable


    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click

        ' Kết nối đến database online
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        ' Mở kết nối
        Ketnoi.Open()

        Dim stradd As String = "insert into Hoa_Don Values (@Ma_HD, @Loai_HD, @Ngay_Ghi_HD, @Tong_Tien, @KHACH_HANG_Ma_KH, @Nhan_Vien_Ma_NV)"
        Dim com As SqlCommand = New SqlCommand(stradd, Ketnoi)
        Try
            com.Parameters.AddWithValue("@Ma_NV", txt1.Text)
            com.Parameters.AddWithValue("@Loai_HD", txt2.Text)
            com.Parameters.AddWithValue("@Ngay_Ghi_HD", txt3.Text)
            com.Parameters.AddWithValue("@Tong_Tien", txt4.Text)
            com.Parameters.AddWithValue("@KHACH_HANG_Ma_KH", txt5.Text)
            com.Parameters.AddWithValue("@Nhan_Vien_Ma_NV", txt6.Text)
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
        Dim SqlAdapter As New SqlDataAdapter("select * from Hoa_Don", Ketnoi)

        Try
            SqlAdapter.Fill(Assignment)

        Catch ex As Exception

        End Try
        DataGridView3.DataSource = Assignment
        Ketnoi.Close()
    End Sub

    Private Sub btndanhsach_Click(sender As Object, e As EventArgs) Handles btndanhsach.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Dim SqlAdapter As New SqlDataAdapter("select * from Hoa_Don", Ketnoi)

        Try
            Ketnoi.Open()
            SqlAdapter.Fill(Assignment)

        Catch ex As Exception

        End Try
        DataGridView3.DataSource = Assignment
        Ketnoi.Close()
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Ketnoi.Open()
        ' Sửa dữ liệu
        Dim stradd As String = " UPDATE Hoa_Don SET Loai_HD = @Loai_HD, Ngay_Ghi_HD = @Ngay_Ghi_HD, Tong_Tien = @Tong_Tien, KHACH_HANG_Ma_KH = @KHACH_HANG_Ma_KH, Nhan_Vien_Ma_NV = @Nhan_Vien_Ma_NV Where Ma_HD = @Ma_HD"
        Dim com As New SqlCommand(stradd, Ketnoi)

        Try
            ' Thêm dữ liệu vào câu truy vấn
            com.Parameters.AddWithValue("@Ma_HD", txt1.Text)
            com.Parameters.AddWithValue("@Loai_HD", txt2.Text)
            com.Parameters.AddWithValue("@Ngay_Ghi_HD", txt3.Text)
            com.Parameters.AddWithValue("@Tong_Tien", txt4.Text)
            com.Parameters.AddWithValue("@KHACH_HANG_Ma_KH", txt5.Text)
            com.Parameters.AddWithValue("@Nhan_Vien_Ma_NV", txt6.Text)
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

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Ketnoi.Open()
        ' Sửa dữ liệu
        Dim stradd As String = "Delete from Hoa_Don where Ma_HD = @Ma_HD"
        Dim com As New SqlCommand(stradd, Ketnoi)

        Try
            com.Parameters.AddWithValue("@Ma_HD", txt1.Text)
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
End Class
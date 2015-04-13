Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmQuanly
    Dim Dangnhap As String = "workstation id=thulmps02240.mssql.somee.com;packet size=4096;user id=thulmps02240_SQLLogin_1;pwd=cslhzeqijs;data source=thulmps02240.mssql.somee.com;persist security info=False;initial catalog=thulmps02240"
    Dim Assignment As New DataTable

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        ' Kết nối đến database online
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        ' Mở kết nối
        Ketnoi.Open()

        Dim stradd As String = "insert into San_Pham Values (@Ma_SP, @Ten_SP, @So_Luong, @Don_Gia, @Mo_Ta_SP, @Khuyen_Mai, Loai_San_Pham_Ma_LSP = @Loai_San_Pham_Ma_LSP)"
        Dim com As SqlCommand = New SqlCommand(stradd, Ketnoi)
        Try
            com.Parameters.AddWithValue("@Ma_SP", txtMa.Text)
            com.Parameters.AddWithValue("@Ten_SP", txtTen.Text)
            com.Parameters.AddWithValue("@So_Luong", txtsoluong.Text)
            com.Parameters.AddWithValue("@Don_Gia", txtdongia.Text)
            com.Parameters.AddWithValue("@Mo_Ta_SP", txtmota.Text)
            com.Parameters.AddWithValue("@Khuyen_Mai", txtkhuyenmai.Text)
            com.Parameters.AddWithValue("@Loai_San_Pham_Ma_LSP", txtmaloaisanpham.Text)
            ' Thực thi câu lệnh Insert dữ liệu vào database
            com.ExecuteNonQuery()
            ' Đóng kết nối
            Ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show(" Kết nối không thành công ")
        End Try
        Assignment.Clear()
        DataGridView1.DataSource = Assignment
        DataGridView1.DataSource = Nothing
        LoadData()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Click vào trong dòng nào, thì sẽ hiện dữ liệu lên textbox
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMa = DataGridView1.Item(0, index).Value
        txtTen = DataGridView1.Item(1, index).Value
        txtsoluong = DataGridView1.Item(2, index).Value
        txtdongia = DataGridView1.Item(3, index).Value
        txtmota = DataGridView1.Item(4, index).Value
        txtkhuyenmai = DataGridView1.Item(5, index).Value
    End Sub

   
    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Ketnoi.Open()
        ' Sửa dữ liệu
        Dim stradd As String = " UPDATE San_Pham SET Ten_SP = @Ten_SP, SoLuong = @SoLuong, Don_Gia = @Don_Gia, Mo_Ta_SP = @Mo_Ta_SP, Khuyen_Mai = @Khuyen_Mai, Loai_San_Pham_Ma_LSP Where Ma_SP = @Ma_SP"
        Dim com As New SqlCommand(stradd, Ketnoi)

        Try
            ' Thêm dữ liệu vào câu truy vấn
            com.Parameters.AddWithValue("@Ma_SP", txtMa.Text)
            com.Parameters.AddWithValue("@Ten_SP", txtTen.Text)
            com.Parameters.AddWithValue("@Don_Gia", txtdongia.Text)
            com.Parameters.AddWithValue("@Mo_Ta_SP", txtmota.Text)
            com.Parameters.AddWithValue("@Khuyen_Mai", txtkhuyenmai.Text)
            com.Parameters.AddWithValue("@Loai_San_Pham_Ma_LSP", txtmaloaisanpham.Text)

            ' Thực thi câu truy vấn
            com.ExecuteNonQuery()
            Ketnoi.Close()

        Catch ex As Exception
            MessageBox.Show(" Kết nối không thành công")

        End Try
        Assignment.Clear()
        DataGridView1.DataSource = Assignment
        DataGridView1.DataSource = Nothing
        LoadData()

    End Sub

  

    Private Sub frmQuanly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        frmMain.Show()

    End Sub

    Private Sub LoadData()
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Dim SqlAdapter As New SqlDataAdapter("select * from San_Pham", Ketnoi)

        Try
            SqlAdapter.Fill(Assignment)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = Assignment
        Ketnoi.Close()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Ketnoi.Open()
        ' Sửa dữ liệu
        Dim stradd As String = "Delete from San_Pham where Ma_SP = @Ma_SP"
        Dim com As New SqlCommand(stradd, Ketnoi)

        Try
            com.Parameters.AddWithValue("@Ma_SP", txtMa.Text)
            com.ExecuteNonQuery()
            Ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối không thành công")
        End Try
        Assignment.Clear()
        DataGridView1.DataSource = Assignment
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Dim SqlAdapter As New SqlDataAdapter("select * from San_Pham", Ketnoi)

        Try
            Ketnoi.Open()
            SqlAdapter.Fill(Assignment)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = Assignment
        Ketnoi.Close()
    End Sub
End Class
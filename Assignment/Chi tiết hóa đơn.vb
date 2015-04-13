Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Chi_tiết_hóa_đơn
    Dim Dangnhap As String = "workstation id=thulmps02240.mssql.somee.com;packet size=4096;user id=thulmps02240_SQLLogin_1;pwd=cslhzeqijs;data source=thulmps02240.mssql.somee.com;persist security info=False;initial catalog=thulmps02240"
    Dim Assignment As New DataTable
    Private Sub btnthem1_Click(sender As Object, e As EventArgs) Handles btnthem1.Click
        ' Kết nối đến database online
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        ' Mở kết nối
        Ketnoi.Open()

        Dim stradd As String = "insert into Chi_Tiet_Hoa_Don Values (@SoLuong, @San_Pham_Ma_SP, @Hoa_Don_Ma_HD)"
        Dim com As SqlCommand = New SqlCommand(stradd, Ketnoi)
        Try
            com.Parameters.AddWithValue("@SoLuong", TextBox1.Text)
            com.Parameters.AddWithValue("@San_Pham_Ma_SP", TextBox2.Text)
            com.Parameters.AddWithValue("@Hoa_Don_Ma_HD", TextBox3.Text)


            ' Thực thi câu lệnh Insert dữ liệu vào database
            com.ExecuteNonQuery()
            ' Đóng kết nối
            Ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show(" Thêm thành công ")
        End Try
        Assignment.Clear()
        DataGridView5.DataSource = Assignment
        DataGridView5.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Dim SqlAdapter As New SqlDataAdapter("select * from Chi_Tiet_Hoa_Don", Ketnoi)

        Try
            SqlAdapter.Fill(Assignment)

        Catch ex As Exception

        End Try
        DataGridView5.DataSource = Assignment
        Ketnoi.Close()
    End Sub

    Private Sub btndanhsach1_Click(sender As Object, e As EventArgs) Handles btndanhsach1.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Dim SqlAdapter As New SqlDataAdapter("select * from Chi_Tiet_Hoa_Don", Ketnoi)

        Try
            Ketnoi.Open()
            SqlAdapter.Fill(Assignment)

        Catch ex As Exception

        End Try
        DataGridView5.DataSource = Assignment
        Ketnoi.Close()
    End Sub

    Private Sub btnxoa1_Click(sender As Object, e As EventArgs) Handles btnxoa1.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Ketnoi.Open()
        ' Sửa dữ liệu
        Dim stradd As String = "Delete from Chi_Tiet_HD where SoLuong = @SoLuong"
        Dim com As New SqlCommand(stradd, Ketnoi)

        Try
            com.Parameters.AddWithValue("@MSoLuong", TextBox1.Text)
            com.ExecuteNonQuery()
            Ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối không thành công")
        End Try
        Assignment.Clear()
        DataGridView5.DataSource = Assignment
        DataGridView5.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick
        Dim index As Integer = DataGridView5.CurrentCell.RowIndex
        TextBox1.Text = DataGridView5.Item(0, index).Value
        TextBox2.Text = DataGridView5.Item(1, index).Value
        TextBox3.Text = DataGridView5.Item(2, index).Value

    End Sub

    Private Sub btnsua1_Click(sender As Object, e As EventArgs) Handles btnsua1.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Ketnoi.Open()
        ' Sửa dữ liệu
        Dim stradd As String = " UPDATE Chi_Tiet_Hoa_Don SET San_Pham_Ma_SP = @San_Pham_Ma_SP, Hoa_Don_Ma_HD = @Hoa_Don_Ma_HD  Where SoLuong = @So_Luong"
        Dim com As New SqlCommand(stradd, Ketnoi)

        Try
            ' Thêm dữ liệu vào câu truy vấn
            com.Parameters.AddWithValue("@SoLuong", TextBox1.Text)
            com.Parameters.AddWithValue("@San_Pham_Ma_SP", TextBox2.Text)
            com.Parameters.AddWithValue("@Hoa_Don_Ma_HD", TextBox3.Text)

            ' Thực thi câu truy vấn
            com.ExecuteNonQuery()
            Ketnoi.Close()

        Catch ex As Exception
            MessageBox.Show(" Kết nối không thành công")

        End Try
        Assignment.Clear()
        DataGridView5.DataSource = Assignment
        DataGridView5.DataSource = Nothing
        LoadData()
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Khách_hàng

    Dim Dangnhap As String = "workstation id=thulmps02240.mssql.somee.com;packet size=4096;user id=thulmps02240_SQLLogin_1;pwd=cslhzeqijs;data source=thulmps02240.mssql.somee.com;persist security info=False;initial catalog=thulmps02240"
    Dim Assignment As New DataTable

    Private Sub Khách_hàng_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        ' Kết nối đến database online
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        ' Mở kết nối
        Ketnoi.Open()

        Dim stradd As String = "insert into KHACH_HANG Values (@Ma_KH, @Password, @Ten_KH, @Dia_Chi, @SDT)"
        Dim com As SqlCommand = New SqlCommand(stradd, Ketnoi)
        Try
            com.Parameters.AddWithValue("@Ma_KH", TextBox1.Text)
            com.Parameters.AddWithValue("@Ten_KH", TextBox2.Text)
            com.Parameters.AddWithValue("@Dia_Chi", TextBox3.Text)
            com.Parameters.AddWithValue("@SDT", TextBox4.Text)

            ' Thực thi câu lệnh Insert dữ liệu vào database
            com.ExecuteNonQuery()
            ' Đóng kết nối
            Ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show(" Thêm thành công ")
        End Try
        Assignment.Clear()
        DataGridView4.DataSource = Assignment
        DataGridView4.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Dim SqlAdapter As New SqlDataAdapter("select * from KHACH_HANG", Ketnoi)

        Try
            SqlAdapter.Fill(Assignment)

        Catch ex As Exception

        End Try
        DataGridView4.DataSource = Assignment
        Ketnoi.Close()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Dim SqlAdapter As New SqlDataAdapter("select * from KHACH_HANG", Ketnoi)

        Try
            Ketnoi.Open()
            SqlAdapter.Fill(Assignment)

        Catch ex As Exception

        End Try
        DataGridView4.DataSource = Assignment
        Ketnoi.Close()
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        Dim index As Integer = DataGridView4.CurrentCell.RowIndex
        TextBox1.Text = DataGridView4.Item(0, index).Value
        TextBox2.Text = DataGridView4.Item(1, index).Value
        TextBox3.Text = DataGridView4.Item(2, index).Value
        TextBox4.Text = DataGridView4.Item(3, index).Value
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Ketnoi.Open()
        ' Sửa dữ liệu
        Dim stradd As String = " UPDATE KHACH_HANG SET Ten_KH = @Ten_KH, Dia_Chi = @Dia_Chi, SDT = @SDT Where Ma_NV = @Ma_KH"
        Dim com As New SqlCommand(stradd, Ketnoi)

        Try
            ' Thêm dữ liệu vào câu truy vấn
            com.Parameters.AddWithValue("@Ma_KH", TextBox1.Text)
            com.Parameters.AddWithValue("@Ten_KH", TextBox2.Text)
            com.Parameters.AddWithValue("@Dia_Chi", TextBox3.Text)
            com.Parameters.AddWithValue("@SDT", TextBox4.Text)
            ' Thực thi câu truy vấn
            com.ExecuteNonQuery()
            Ketnoi.Close()

        Catch ex As Exception
            MessageBox.Show(" Kết nối không thành công")

        End Try
        Assignment.Clear()
        DataGridView4.DataSource = Assignment
        DataGridView4.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Ketnoi.Open()
        ' Sửa dữ liệu
        Dim stradd As String = "Delete from KHACH_HANG where Ma_KH = @Ma_KH"
        Dim com As New SqlCommand(stradd, Ketnoi)

        Try
            com.Parameters.AddWithValue("@Ma_KH", TextBox1.Text)
            com.ExecuteNonQuery()
            Ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối không thành công")
        End Try
        Assignment.Clear()
        DataGridView4.DataSource = Assignment
        DataGridView4.DataSource = Nothing
        LoadData()
    End Sub
End Class
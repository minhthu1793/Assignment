Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class Nhân_viên

    Dim Dangnhap As String = "workstation id=thulmps02240.mssql.somee.com;packet size=4096;user id=thulmps02240_SQLLogin_1;pwd=cslhzeqijs;data source=thulmps02240.mssql.somee.com;persist security info=False;initial catalog=thulmps02240"
    Dim Assignment As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        ' Kết nối đến database online
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        ' Mở kết nối
        Ketnoi.Open()

        Dim stradd As String = "insert into Nhan_Vien Values (@Ma_NV, @Password, @Ten_NV, @Gioi_Tinh)"
        Dim com As SqlCommand = New SqlCommand(stradd, Ketnoi)
        Try
            com.Parameters.AddWithValue("@Ma_NV", txtmanv.Text)
            com.Parameters.AddWithValue("@Password", txtpass.Text)
            com.Parameters.AddWithValue("@Ten_NV", txttenv.Text)
            com.Parameters.AddWithValue("@Gioi_Tinh", txttinh.Text)
            
            ' Thực thi câu lệnh Insert dữ liệu vào database
            com.ExecuteNonQuery()
            ' Đóng kết nối
            Ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show(" Thêm thành công ")
        End Try
        Assignment.Clear()
        DataGridView2.DataSource = Assignment
        DataGridView2.DataSource = Nothing
        LoadData()

    End Sub

    Private Sub Nhân_viên_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Close()
        frmMain.Show()

    End Sub

    Private Sub LoadData()

        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Dim SqlAdapter As New SqlDataAdapter("select * from Nhan_Vien", Ketnoi)

        Try
            SqlAdapter.Fill(Assignment)

        Catch ex As Exception

        End Try
        DataGridView2.DataSource = Assignment
        Ketnoi.Close()

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        ' Click vào trong dòng nào, thì sẽ hiện dữ liệu lên textbox
        Dim index As Integer = DataGridView2.CurrentCell.RowIndex
        txtmanv.Text = DataGridView2.Item(0, index).Value
        txtpass.Text = DataGridView2.Item(1, index).Value
        txttenv.Text = DataGridView2.Item(2, index).Value
        txttinh.Text = DataGridView2.Item(3, index).Value

    End Sub


    Private Sub btnDanhsach_Click(sender As Object, e As EventArgs) Handles btnDanhsach.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Dim SqlAdapter As New SqlDataAdapter("select * from Nhan_Vien", Ketnoi)

        Try
            Ketnoi.Open()
            SqlAdapter.Fill(Assignment)

        Catch ex As Exception

        End Try
        DataGridView2.DataSource = Assignment
        Ketnoi.Close()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Ketnoi.Open()
        ' Sửa dữ liệu
        Dim stradd As String = " UPDATE Nhan_Vien SET Password = @Password, Ten_NV = @Ten_NV, Gioi_Tinh = @Gioi_Tinh Where Ma_NV = @Ma_NV"
        Dim com As New SqlCommand(stradd, Ketnoi)

        Try
            ' Thêm dữ liệu vào câu truy vấn
            com.Parameters.AddWithValue("@Ma_NV", txtmanv.Text)
            com.Parameters.AddWithValue("@Password", txtpass.Text)
            com.Parameters.AddWithValue("@Ten_NV", txttenv.Text)
            com.Parameters.AddWithValue("@Gioi_Tinh", txttinh.Text)
            ' Thực thi câu truy vấn
            com.ExecuteNonQuery()
            Ketnoi.Close()

        Catch ex As Exception
            MessageBox.Show(" Kết nối không thành công")

        End Try
        Assignment.Clear()
        DataGridView2.DataSource = Assignment
        DataGridView2.DataSource = Nothing
        LoadData()

    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Ketnoi.Open()
        ' Sửa dữ liệu
        Dim stradd As String = "Delete from Nhan_Vien where Ma_NV = @Ma_NV"
        Dim com As New SqlCommand(stradd, Ketnoi)

        Try
            com.Parameters.AddWithValue("@Ma_NV", txtmanv.Text)
            com.ExecuteNonQuery()
            Ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Kết nối không thành công")
        End Try
        Assignment.Clear()
        DataGridView2.DataSource = Assignment
        DataGridView2.DataSource = Nothing
        LoadData()
    End Sub
End Class
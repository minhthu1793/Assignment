Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Login

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDangnhap_Click(sender As Object, e As EventArgs) Handles btnDangnhap.Click
        Dim Dangnhap As String = "workstation id=thulmps02240.mssql.somee.com;packet size=4096;user id=thulmps02240_SQLLogin_1;pwd=cslhzeqijs;data source=thulmps02240.mssql.somee.com;persist security info=False;initial catalog=thulmps02240"

        Dim Ketnoi As SqlConnection = New SqlConnection(Dangnhap)
        Dim SqlAdapter As New SqlDataAdapter("select * from Nhan_Vien where Ma_NV = '" & txtname.Text & "' and Password ='" & txtpass.Text & "'", Ketnoi)
        Dim Assignment As New DataTable

        Try
            Ketnoi.Open()
            SqlAdapter.Fill(Assignment)
            If Assignment.Rows.Count > 0 Then
                MessageBox.Show(" Kết nối thành công ")
                frmMain.Show()
                Me.Hide()

            Else
                MessageBox.Show(" Sai tài khoản hoặc mật khẩu ")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()

    End Sub
End Class

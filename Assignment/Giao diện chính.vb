Public Class frmMain

    Private Sub GiaoDienChinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiSảnPhẩmToolStripMenuItem.Click
        Me.Hide()
        frmLoaiSanpham.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click

    End Sub

    Private Sub QuảnLýNVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýNVToolStripMenuItem.Click
        Me.Show()
        Nhân_viên.Show()


    End Sub

    Private Sub HỗTrợToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HỗTrợToolStripMenuItem.Click
        Me.Hide()
        Khách_hàng.Show()

    End Sub

    Private Sub HóaĐơnTheoNgàyToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        Me.Hide()
        Hóa_đơn.Show()

    End Sub

    Private Sub ChiTiếtSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtSảnPhẩmToolStripMenuItem.Click
        Me.Hide()
        frmQuanly.Show()

    End Sub

    Private Sub NhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhânViênToolStripMenuItem.Click

    End Sub
End Class
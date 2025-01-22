Public Class Log
    Private Sub Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 初始化 DataGridView 列
        DataGridView1.ColumnCount = 8
        DataGridView1.Columns(0).Name = "形状名称"
        DataGridView1.Columns(1).Name = "位置 X"
        DataGridView1.Columns(2).Name = "位置 Y"
        DataGridView1.Columns(3).Name = "旋转角度"
        DataGridView1.Columns(4).Name = "线速度 X"
        DataGridView1.Columns(5).Name = "线速度 Y"
        DataGridView1.Columns(6).Name = "分力 X"
        DataGridView1.Columns(7).Name = "分力 Y"
    End Sub

    ' 公共方法：追加数据到 DataGridView
    Public Sub AppendData(shapeName As String, positionX As String, positionY As String, rotation As String, linearVelocityX As String, linearVelocityY As String, forceX As String, forceY As String)
        ' 添加数据行
        DataGridView1.Rows.Add(shapeName, positionX, positionY, rotation, linearVelocityX, linearVelocityY, forceX, forceY)

        ' 滚动到最新的一行
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
        End If
    End Sub

    Private Sub Log_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' 隐藏窗体而不是关闭
        e.Cancel = True
        Me.Hide()
    End Sub
End Class
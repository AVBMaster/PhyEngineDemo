Imports System.Runtime.InteropServices

Module MyPublic
    Public force = 0
    Public force_angle = ForceAngle.TextBox2.Text
    Public force_x = 0
    Public force_y = 0
    Public Const Pi = 3.1415926
    Public Const TimeStep = 50000000
    Public displayText As String = "按下F11进入全屏模式"
    ' 日志文件路径
    Public logFilePath As String = "SimulationLog.log"

    Public Sub CopyDataGridView(sourceDataGridView As DataGridView, targetDataGridView As DataGridView)
        ' 清空目标 DataGridView 的现有数据
        targetDataGridView.Rows.Clear()
        targetDataGridView.Columns.Clear()

        ' 复制列结构
        For Each column As DataGridViewColumn In sourceDataGridView.Columns
            targetDataGridView.Columns.Add(column.Clone())
        Next

        ' 复制行数据
        For Each row As DataGridViewRow In sourceDataGridView.Rows
            If Not row.IsNewRow Then ' 跳过新行（最后一行）
                Dim newRow As DataGridViewRow = CType(row.Clone(), DataGridViewRow)
                For i As Integer = 0 To row.Cells.Count - 1
                    newRow.Cells(i).Value = row.Cells(i).Value
                Next
                targetDataGridView.Rows.Add(newRow)
            End If
        Next
    End Sub

    Public Function RoundDecimal(value As Double, decimalPlaces As Integer) As Double
        ' 使用 Math.Round 方法进行四舍五入
        Return Math.Round(value, decimalPlaces)
    End Function

    Public Sub AppendDataGridViewDataWithColumnNames(sourceDataGridView As DataGridView, targetDataGridView As DataGridView)
        ' 遍历源 DataGridView 的每一行
        For Each row As DataGridViewRow In sourceDataGridView.Rows
            If Not row.IsNewRow Then
                ' 创建一个新行
                Dim newRow As New DataGridViewRow()
                newRow.CreateCells(targetDataGridView)

                ' 根据列名匹配数据
                For Each col As DataGridViewColumn In sourceDataGridView.Columns
                    Dim targetCol As DataGridViewColumn = targetDataGridView.Columns(col.Name)
                    If targetCol IsNot Nothing Then
                        newRow.Cells(targetCol.Index).Value = row.Cells(col.Name).Value
                    End If
                Next

                ' 将新行添加到目标 DataGridView 的末尾
                targetDataGridView.Rows.Add(newRow)
            End If
        Next
    End Sub
End Module


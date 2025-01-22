Public Class ForceXY

    Dim calculatedResult1, calculatedResult2 As single
    Private Sub Force_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Owner = Main
        TextBox1.Multiline = False
        TextBox2.Multiline = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) Then
            If Not String.IsNullOrWhiteSpace(TextBox2.Text) Then
                Try
                    Dim result1, result2
                    ' 使用 DataTable.Compute 来计算表达式
                    result1 = New DataTable().Compute(TextBox1.Text, Nothing)
                    result2 = New DataTable().Compute(TextBox2.Text, Nothing)
                    If single.IsInfinity(result1) Or single.IsInfinity(result2) Then
                        MsgBox("您不应该把0作为除数！", vbObjectError, Application.ProductName)
                        Exit Sub
                    ElseIf single.IsNaN(result1) Or single.IsNaN(result2) Then
                        MsgBox("您不应该把0作为除数和被除数！", vbObjectError, Application.ProductName)
                        Exit Sub
                    End If

                    ' 将结果转换为 single 类型
                    calculatedResult1 = Convert.Tosingle(result1)
                    calculatedResult2 = Convert.Tosingle(result2)

                    force_x = calculatedResult1
                    force_y = calculatedResult2
                    Me.Dispose()

                Catch ex As Exception
                    MsgBox("表达式无效：" + ex.Message, vbObjectError, Application.ProductName)
                    Exit Sub
                End Try
            End If
        Else MsgBox("表达式不能为空！", vbObjectError, Application.ProductName)
        End If
    End Sub
End Class
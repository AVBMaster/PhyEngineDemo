Imports System.ComponentModel

Public Class ForceAngle
    Private Sub ForceAngle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        TextBox2.Multiline = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox2.Width = 272
        Label1.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox2.Width -= Label1.Width
        Label1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not String.IsNullOrWhiteSpace(TextBox1.Text) AndAlso Not String.IsNullOrWhiteSpace(TextBox2.Text) Then
            Dim magnitude As Single
            Dim angle As Single

            If Not Single.TryParse(TextBox1.Text, magnitude) Then
                MsgBox("力的大小无效！", vbExclamation, "错误")
                Exit Sub
            End If

            If Not Single.TryParse(TextBox2.Text, angle) Then
                MsgBox("角度/弧度无效！", vbExclamation, "错误")
                Exit Sub
            End If

            ' 保存力的大小和角度
            force = magnitude
            force_angle = angle

            ' 如果是角度，转换为弧度
            If RadioButton1.Checked Then
                force_angle *= Math.PI / 180.0F  ' 转换为弧度
            End If

            Me.Close()  ' 关闭窗体
        Else
            MsgBox("力的大小和角度/弧度不能为空！", vbExclamation, "错误")
        End If
    End Sub
End Class
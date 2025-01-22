Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports PhyEngineCOMLib
Imports System.IO
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Drawing.Interop

Public Class Main
    Dim PhyEngine As IPhyEngine = New PhyEngine
    Dim shapes As New List(Of Shape)()
    Dim box() As String
    Dim boxid() As Integer
    Dim box_index As Integer = 0
    Dim square_index As Integer = 0
    Dim circle_index As Integer = 0
    Dim x As Integer = 0
    Dim y As Integer = 0
    Dim isFullScreen As Boolean = False
    Dim Form_Width As Integer
    Dim Form_Height As Integer
    Dim logFilePath As String = "SimulationLog.log"  ' 日志文件路径
    Dim isSimulating As Boolean = False  ' 用于控制模拟是否在运行
    Dim simulationTask As Task  ' 用于运行模拟的后台任务
    Dim cancellationTokenSource As CancellationTokenSource  ' 用于取消任务

    Public Sub New()
        InitializeComponent()
        Me.StartPosition = FormStartPosition.CenterScreen
        c_boxstyle.Items.Add("矩形")
        c_boxstyle.Items.Add("圆形")
        c_boxstyle.SelectedIndex = 0
        c_boxstyle.DropDownStyle = ComboBoxStyle.DropDownList
        c_box.DropDownStyle = ComboBoxStyle.DropDownList
        If c_box.Items.Count = 0 Then c_box.Enabled = False : b_forceAngle.Enabled = False : b_forceXY.Enabled = False : b_start.Enabled = False
        t_x.Multiline = False
        t_y.Multiline = False
        TextBox2.Multiline = False
        TextBox3.Multiline = False
        t_x.Text = 200
        t_y.Text = 300
        TextBox2.Text = 25
        TextBox3.Text = 25
        GroupBox7.Size = GroupBox6.Size
        p_Screen.Parent = GroupBox7
        p_Screen.Dock = DockStyle.Fill

        ' 初始化 DataGridView
        DataGridView1.ColumnCount = 8
        DataGridView1.Columns(0).Name = "形状名称"
        DataGridView1.Columns(1).Name = "位置 X"
        DataGridView1.Columns(2).Name = "位置 Y"
        DataGridView1.Columns(3).Name = "旋转角度"
        DataGridView1.Columns(4).Name = "线速度 X"
        DataGridView1.Columns(5).Name = "线速度 Y"
        DataGridView1.Columns(6).Name = "分力 X"
        DataGridView1.Columns(7).Name = "分力 Y"

        ' 创建或清空日志文件
        File.WriteAllText(logFilePath, "")

        Form_Width = Me.Width
        Form_Height = Me.Height

        PhyEngine.AddSquare(0, -50, 10000000, 82.5, 1, 1, True)
        PhyEngine.AddSquare(-60, -10, 100, 10000000, 1, 1, True)
        PhyEngine.AddSquare(Screen.PrimaryScreen.Bounds.Width + 40, -10, 100, 10000000, 1, 1, True)

    End Sub

    Private Sub b_addbox_Click(sender As Object, e As EventArgs) Handles b_addbox.Click
        ReDim Preserve box(box_index)
        ReDim Preserve boxid(box_index)

        Dim x As Single
        Dim y As Single
        If Not Single.TryParse(t_x.Text, x) Then
            MsgBox("无效的 X 坐标！", vbExclamation, "错误")
            Return
        End If
        If Not Single.TryParse(t_y.Text, y) Then
            MsgBox("无效的 Y 坐标！", vbExclamation, "错误")
            Return
        End If

        Dim bodyId As Integer
        If c_boxstyle.SelectedItem = "矩形" Then
            box(box_index) = "矩形" & square_index.ToString
            square_index += 1
            bodyId = PhyEngine.AddSquare(x, y, TextBox2.Text, TextBox3.Text, 1, 0, False)
            shapes.Add(New Square(x, y, TextBox2.Text, bodyId))
        ElseIf c_boxstyle.SelectedItem = "圆形" Then
            box(box_index) = "圆形" & circle_index.ToString
            circle_index += 1
            bodyId = PhyEngine.AddCircle(x, y, TextBox2.Text, 1, 0, False)
            shapes.Add(New Circle(x, y, TextBox2.Text, bodyId))
        End If

        boxid(box_index) = bodyId
        c_box.Items.Add(box(box_index))
        If c_box.Items.Count >= 1 Then
            c_box.SelectedIndex = box_index
            c_box.Enabled = True
            b_forceAngle.Enabled = True
            b_forceXY.Enabled = True
            b_start.Enabled = True
        End If

        p_Screen.Invalidate()
        box_index += 1
    End Sub

    Private Sub b_start_Click(sender As Object, e As EventArgs) Handles b_start.Click
        If Not isSimulating Then
            isSimulating = True
            b_start.Text = "停止模拟"
            cancellationTokenSource = New CancellationTokenSource()
            simulationTask = Task.Run(Async Function()
                                          Await ExecuteSimulation(cancellationTokenSource.Token)
                                      End Function)
        Else
            isSimulating = False
            b_start.Text = "开始模拟"
            cancellationTokenSource.Cancel()
        End If
    End Sub

    Private Async Function ExecuteSimulation(token As CancellationToken) As Task
        While Not token.IsCancellationRequested
            PhyEngine.StartSimulation(1 / 30, 1, 3) ' 每秒 30 帧目测效果最好

            ' 更新 UI（必须在主线程中执行）
            UpdateDataGridView()


            ' 触发 PictureBox 重绘
            p_Screen.Invoke(Sub()
                                p_Screen.Invalidate()
                            End Sub)

            ' 等待一小段时间以模拟帧率
            Await Task.Delay(1, token)
        End While
    End Function

    Private Sub UpdateDataGridView()
        If DataGridView1.InvokeRequired Then
            DataGridView1.Invoke(Sub()
                                     UpdateDataGridViewCore()
                                 End Sub)
        Else
            UpdateDataGridViewCore()
        End If
    End Sub

    Private Sub UpdateDataGridViewCore()
        'AppendDataGridViewDataWithColumnNames(DataGridView1, Log.DataGridView1)
        ' 清空 Main 窗体的 DataGridView
        DataGridView1.Rows.Clear()

        ' 遍历所有物体并记录状态
        For i As Integer = 0 To boxid.Length - 1
            Dim positionX, positionY As Single
            Dim rotation As Single
            Dim linearVelocityX, linearVelocityY As Single
            Dim forceX, forceY As Single

            PhyEngine.GetPosition(boxid(i), positionX, positionY)
            rotation = PhyEngine.GetRotation(boxid(i))
            PhyEngine.GetLinearVelocity(boxid(i), linearVelocityX, linearVelocityY)
            PhyEngine.GetForce(boxid(i), forceX, forceY)

            '全部转换为2位小数，方便观察
            positionX = RoundDecimal(positionX, 2)
            positionY = RoundDecimal(positionY, 2)
            rotation = RoundDecimal(rotation, 2)
            linearVelocityX = RoundDecimal(linearVelocityX, 2)
            linearVelocityY = RoundDecimal(linearVelocityY, 2)
            forceX = RoundDecimal(forceX, 2)
            forceY = RoundDecimal(forceY, 2)
            ' 将物理状态记录到 Main 窗体的 DataGridView 中
            DataGridView1.Rows.Add(
                box(i),  ' 形状名称
                positionX.ToString(),  ' 位置 X
                positionY.ToString(),  ' 位置 Y
                rotation.ToString(),  ' 旋转角度
                linearVelocityX.ToString(),  ' 线速度 X
                linearVelocityY.ToString(),  ' 线速度 Y
                forceX.ToString(),  ' 分力 X
                forceY.ToString()   ' 分力 Y
            )


        Next

        ' 滚动到最新的一行
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
        End If
    End Sub

    Private Sub p_Screen_Paint(sender As Object, e As PaintEventArgs) Handles p_Screen.Paint
        Dim g = e.Graphics
        Dim screenWidth = p_Screen.Width  ' PictureBox 的宽度
        Dim screenHeight = p_Screen.Height  ' PictureBox 的高度

        ' 调整坐标系统：左下角为 (0,0)，向上 y 增大，向右 x 增大
        g.TranslateTransform(0, screenHeight)  ' 将原点移动到左下角
        g.ScaleTransform(1, -1)  ' 翻转 Y 轴方向

        ' 绘制所有形状
        For Each shape In shapes
            Dim positionX, positionY As Single
            Dim rotation As Single

            ' 获取形状的最新位置和角度
            PhyEngine.GetPosition(shape.BodyId, positionX, positionY)
            rotation = PhyEngine.GetRotation(shape.BodyId)

            ' 更新形状的位置和角度
            shape.X = positionX
            shape.Y = positionY
            shape.Angle = rotation

            ' 绘制形状
            shape.Draw(g, positionX, positionY)
        Next

        ' 在右上角绘制指定内容
        If displayText <> "" Then
            ' 恢复默认的坐标系统
            g.ResetTransform()

            ' 设置字体和颜色
            Dim font As New Font("Arial", 13, FontStyle.Bold)
            Dim brush As New SolidBrush(Color.White)
            Dim sizef = g.MeasureString(displayText, font)
            Dim textRect As New RectangleF(screenWidth - sizef.Width - 10, 10, sizef.Width, sizef.Height)  ' 右上角位置

            ' 绘制文本
            g.DrawString(displayText, font, brush, textRect)

            ' 释放资源
            font.Dispose()
            brush.Dispose()
        End If
    End Sub
    Private Sub b_forceXY_Click(sender As Object, e As EventArgs) Handles b_forceXY.Click
        ForceXY.ShowDialog()
        x = force_x
        y = force_y
    End Sub

    Private Sub b_forceAngle_Click(sender As Object, e As EventArgs) Handles b_forceAngle.Click
        If c_box.SelectedIndex = -1 Then
            MsgBox("请先选择一个物体！", vbExclamation, "错误")
            Return
        End If

        ForceAngle.ShowDialog()

        ' 获取选中的物体 ID
        Dim selectedBodyId As Integer = boxid(c_box.SelectedIndex)

        ' 对选中的物体施加力
        PhyEngine.ApplyForceAtAngle(selectedBodyId, force, force_angle)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 切换全屏模式
        isFullScreen = Not isFullScreen

        If isFullScreen Then
            displayText = "全屏模式——按 ESC 退出全屏"
            ' 进入全屏模式
            Me.WindowState = FormWindowState.Maximized
            Me.FormBorderStyle = FormBorderStyle.None
            Me.TopMost = True ' 确保窗体始终在最上层

            ' 调整 p_Screen 的大小以填充整个窗体
            GroupBox7.Parent = Me
            GroupBox7.Size = Me.Size
            GroupBox7.BringToFront()
            p_Screen.Focus()
            p_Screen.Parent = GroupBox7
            p_Screen.Dock = DockStyle.Fill
            p_Screen.BringToFront()
            p_Screen.Invalidate()
        Else
            ' 退出全屏模式
            displayText = "按下F11进入全屏模式"
            Me.WindowState = FormWindowState.Normal
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.TopMost = False
            Me.Width = Form_Width
            Me.Height = Form_Height

            ' 恢复 p_Screen 的原始布局
            GroupBox7.Parent = GroupBox6
            GroupBox7.Size = GroupBox6.Size
            GroupBox7.BringToFront()
            p_Screen.Parent = GroupBox7
            p_Screen.Dock = DockStyle.Fill
            p_Screen.BringToFront()
            p_Screen.Invalidate()
        End If
    End Sub

    ' 重写 ProcessCmdKey 方法以捕获按键事件
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Escape AndAlso isFullScreen Then
            ' 如果按下 ESC 键且处于全屏模式，则退出全屏
            Button1.PerformClick()
            Return True
        ElseIf keyData = Keys.F11 AndAlso Not isFullScreen Then
            ' 如果按下 ESC 键且不处于全屏模式，则进入全屏
            Button1.PerformClick()
            Return True
        End If
        ' 如果不是 ESC 键或不在全屏模式下，调用基类方法
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Log.Show()  ' 否则直接显示
    End Sub
End Class
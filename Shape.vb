Imports System.Drawing.Drawing2D

Public MustInherit Class Shape
    Public Property X As Single
    Public Property Y As Single
    Public Property Width As Single
    Public Property Height As Single
    Public Property Angle As Single  ' 旋转角度
    Public Property BodyId As Integer  ' 物体 ID

    Public Sub New(x As Single, y As Single, width As Single, height As Single, bodyId As Integer)
        Me.X = x
        Me.Y = y
        Me.Width = width
        Me.Height = height
        Me.BodyId = bodyId
        Me.Angle = 0  ' 默认角度为0
    End Sub

    Public MustOverride Sub Draw(g As Graphics, screenX As Single, screenY As Single)
End Class

Public Class Square
    Inherits Shape

    Public Sub New(x As Single, y As Single, sideLength As Single, bodyId As Integer)
        MyBase.New(x, y, sideLength, sideLength, bodyId)
    End Sub

    Public Overrides Sub Draw(g As Graphics, screenX As Single, screenY As Single)
        ' 保存当前状态
        Dim state As GraphicsState = g.Save()

        ' 设置旋转中心为形状的中心
        g.TranslateTransform(screenX + Width / 2, screenY + Height / 2)
        g.RotateTransform(Angle)
        g.TranslateTransform(-Width / 2, -Height / 2)

        ' 绘制正方形
        g.FillRectangle(Brushes.Blue, 0, 0, Width, Height)

        ' 恢复状态
        g.Restore(state)
    End Sub
End Class

Public Class Circle
    Inherits Shape

    Public Sub New(x As Single, y As Single, radius As Single, bodyId As Integer)
        MyBase.New(x, y, radius * 2, radius * 2, bodyId)
    End Sub

    Public Overrides Sub Draw(g As Graphics, screenX As Single, screenY As Single)
        ' 保存当前状态
        Dim state As GraphicsState = g.Save()

        ' 设置旋转中心为形状的中心
        g.TranslateTransform(screenX + Width / 2, screenY + Height / 2)
        g.RotateTransform(Angle)
        g.TranslateTransform(-Width / 2, -Height / 2)

        ' 绘制圆形
        g.FillEllipse(Brushes.BurlyWood, 0, 0, Width, Height)

        ' 恢复状态
        g.Restore(state)
    End Sub
End Class
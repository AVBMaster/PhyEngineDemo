<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForceAngle
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Label1 = New Label()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(383, 209)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoEllipsis = True
        Label2.Location = New Point(10, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(357, 46)
        Label2.TabIndex = 14
        Label2.Text = "如果您在使用弧度制时不希望使用π，请您在表达式中除以π的近似值（如/3.1415）"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(346, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(21, 21)
        Label1.TabIndex = 13
        Label1.Text = "π"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(115, 99)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(133, 25)
        RadioButton2.TabIndex = 12
        RadioButton2.TabStop = True
        RadioButton2.Text = "弧度制（rad）"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(7, 99)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(115, 25)
        RadioButton1.TabIndex = 11
        RadioButton1.TabStop = True
        RadioButton1.Text = "角度制（°）"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(95, 55)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(272, 23)
        TextBox2.TabIndex = 9
        TextBox2.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 56)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 21)
        Label3.TabIndex = 8
        Label3.Text = "施力方向："
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(252, 99)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 32)
        Button1.TabIndex = 6
        Button1.Text = "生成施力方向"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(95, 24)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(272, 23)
        TextBox1.TabIndex = 11
        TextBox1.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 21)
        Label4.TabIndex = 10
        Label4.Text = "力的大小："
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(346, 24)
        Label5.Name = "Label5"
        Label5.Size = New Size(23, 21)
        Label5.TabIndex = 15
        Label5.Text = "N"
        ' 
        ' ForceAngle
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(383, 209)
        Controls.Add(GroupBox1)
        Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ForceAngle"
        StartPosition = FormStartPosition.CenterParent
        Text = "以角度的形式设置施力方向"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class

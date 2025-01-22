<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox6 = New GroupBox()
        GroupBox7 = New GroupBox()
        p_Screen = New PictureBox()
        GroupBox2 = New GroupBox()
        DataGridView1 = New DataGridView()
        GroupBox3 = New GroupBox()
        GroupBox5 = New GroupBox()
        b_forceAngle = New Button()
        b_forceXY = New Button()
        Label2 = New Label()
        c_box = New ComboBox()
        GroupBox4 = New GroupBox()
        b_addbox = New Button()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        t_y = New TextBox()
        t_x = New TextBox()
        Label1 = New Label()
        c_boxstyle = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        Button1 = New Button()
        b_start = New Button()
        HelpProvider1 = New HelpProvider()
        GroupBox6.SuspendLayout()
        GroupBox7.SuspendLayout()
        CType(p_Screen, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(GroupBox7)
        GroupBox6.Location = New Point(5, 7)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(646, 553)
        GroupBox6.TabIndex = 25
        GroupBox6.TabStop = False
        ' 
        ' GroupBox7
        ' 
        GroupBox7.Controls.Add(p_Screen)
        GroupBox7.Location = New Point(0, 0)
        GroupBox7.Name = "GroupBox7"
        GroupBox7.Size = New Size(646, 553)
        GroupBox7.TabIndex = 17
        GroupBox7.TabStop = False
        ' 
        ' p_Screen
        ' 
        p_Screen.BackColor = SystemColors.ActiveCaption
        p_Screen.BorderStyle = BorderStyle.FixedSingle
        p_Screen.Location = New Point(3, 13)
        p_Screen.Margin = New Padding(4)
        p_Screen.Name = "p_Screen"
        p_Screen.Size = New Size(640, 526)
        p_Screen.TabIndex = 17
        p_Screen.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(DataGridView1)
        GroupBox2.Location = New Point(5, 566)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(646, 151)
        GroupBox2.TabIndex = 24
        GroupBox2.TabStop = False
        GroupBox2.Text = "模拟物理世界信息输出区"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(3, 24)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(640, 124)
        DataGridView1.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(GroupBox5)
        GroupBox3.Controls.Add(GroupBox4)
        GroupBox3.Location = New Point(657, 7)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(440, 553)
        GroupBox3.TabIndex = 27
        GroupBox3.TabStop = False
        GroupBox3.Text = "操作区"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(b_forceAngle)
        GroupBox5.Controls.Add(b_forceXY)
        GroupBox5.Controls.Add(Label2)
        GroupBox5.Controls.Add(c_box)
        GroupBox5.Location = New Point(0, 284)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(433, 263)
        GroupBox5.TabIndex = 7
        GroupBox5.TabStop = False
        ' 
        ' b_forceAngle
        ' 
        b_forceAngle.Location = New Point(7, 109)
        b_forceAngle.Margin = New Padding(4)
        b_forceAngle.Name = "b_forceAngle"
        b_forceAngle.Size = New Size(426, 37)
        b_forceAngle.TabIndex = 9
        b_forceAngle.Text = "以角度的形式设置施力方向"
        b_forceAngle.UseVisualStyleBackColor = True
        ' 
        ' b_forceXY
        ' 
        b_forceXY.Location = New Point(6, 166)
        b_forceXY.Margin = New Padding(4)
        b_forceXY.Name = "b_forceXY"
        b_forceXY.Size = New Size(426, 37)
        b_forceXY.TabIndex = 8
        b_forceXY.Text = "以二维坐标的形式设置施力方向"
        b_forceXY.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 21)
        Label2.TabIndex = 4
        Label2.Text = "对指定物块施力"
        ' 
        ' c_box
        ' 
        c_box.FormattingEnabled = True
        c_box.Location = New Point(6, 60)
        c_box.Name = "c_box"
        c_box.Size = New Size(426, 29)
        c_box.TabIndex = 3
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(b_addbox)
        GroupBox4.Controls.Add(TextBox3)
        GroupBox4.Controls.Add(TextBox2)
        GroupBox4.Controls.Add(t_y)
        GroupBox4.Controls.Add(t_x)
        GroupBox4.Controls.Add(Label1)
        GroupBox4.Controls.Add(c_boxstyle)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Controls.Add(Label3)
        GroupBox4.Controls.Add(Label5)
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Location = New Point(0, 26)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(440, 256)
        GroupBox4.TabIndex = 6
        GroupBox4.TabStop = False
        ' 
        ' b_addbox
        ' 
        b_addbox.Location = New Point(6, 214)
        b_addbox.Margin = New Padding(4)
        b_addbox.Name = "b_addbox"
        b_addbox.Size = New Size(426, 37)
        b_addbox.TabIndex = 2
        b_addbox.Text = "添加物块"
        b_addbox.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(80, 179)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(352, 28)
        TextBox3.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(80, 145)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(352, 28)
        TextBox2.TabIndex = 9
        ' 
        ' t_y
        ' 
        t_y.Location = New Point(80, 111)
        t_y.Name = "t_y"
        t_y.Size = New Size(352, 28)
        t_y.TabIndex = 7
        ' 
        ' t_x
        ' 
        t_x.Location = New Point(80, 72)
        t_x.Name = "t_x"
        t_x.Size = New Size(352, 28)
        t_x.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(234, 21)
        Label1.TabIndex = 4
        Label1.Text = "向模拟物理世界中添加指定物块"
        ' 
        ' c_boxstyle
        ' 
        c_boxstyle.FormattingEnabled = True
        c_boxstyle.Location = New Point(6, 38)
        c_boxstyle.Name = "c_boxstyle"
        c_boxstyle.Size = New Size(426, 29)
        c_boxstyle.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 21)
        Label4.TabIndex = 8
        Label4.Text = "Y坐标："
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 79)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 21)
        Label3.TabIndex = 6
        Label3.Text = "X坐标："
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 148)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 21)
        Label5.TabIndex = 10
        Label5.Text = "宽度："
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 182)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 21)
        Label6.TabIndex = 12
        Label6.Text = "高度："
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(b_start)
        GroupBox1.Location = New Point(657, 566)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(440, 151)
        GroupBox1.TabIndex = 26
        GroupBox1.TabStop = False
        GroupBox1.Text = "控制区"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(159, 76)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(121, 37)
        Button2.TabIndex = 4
        Button2.Text = "打开日志区"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(7, 75)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 37)
        Button1.TabIndex = 3
        Button1.Text = "模拟区全屏"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' b_start
        ' 
        b_start.Location = New Point(7, 31)
        b_start.Margin = New Padding(4)
        b_start.Name = "b_start"
        b_start.Size = New Size(426, 37)
        b_start.TabIndex = 2
        b_start.Text = "开始模拟"
        b_start.UseVisualStyleBackColor = True
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1100, 725)
        Controls.Add(GroupBox6)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4)
        MaximizeBox = False
        Name = "Main"
        Text = "物理模拟实验室"
        GroupBox6.ResumeLayout(False)
        GroupBox7.ResumeLayout(False)
        CType(p_Screen, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents b_forceAngle As Button
    Friend WithEvents b_forceXY As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents c_box As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents b_addbox As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents t_y As TextBox
    Friend WithEvents t_x As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents c_boxstyle As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents b_start As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents p_Screen As PictureBox
    Friend WithEvents HelpProvider1 As HelpProvider

End Class

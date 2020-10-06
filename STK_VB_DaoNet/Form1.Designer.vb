<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxAgUiAxVOCntrl1 = New AGI.STKX.Controls.AxAgUiAxVOCntrl()
        Me.AxAgUiAx2DCntrl1 = New AGI.STKX.Controls.AxAgUiAx2DCntrl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AxAgUiAxVOCntrl1
        '
        Me.AxAgUiAxVOCntrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AxAgUiAxVOCntrl1.Location = New System.Drawing.Point(2, 3)
        Me.AxAgUiAxVOCntrl1.Name = "AxAgUiAxVOCntrl1"
        Me.AxAgUiAxVOCntrl1.Picture = CType(resources.GetObject("AxAgUiAxVOCntrl1.Picture"), System.Drawing.Image)
        Me.AxAgUiAxVOCntrl1.Size = New System.Drawing.Size(497, 408)
        Me.AxAgUiAxVOCntrl1.TabIndex = 0
        '
        'AxAgUiAx2DCntrl1
        '
        Me.AxAgUiAx2DCntrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AxAgUiAx2DCntrl1.Location = New System.Drawing.Point(2, 411)
        Me.AxAgUiAx2DCntrl1.Name = "AxAgUiAx2DCntrl1"
        Me.AxAgUiAx2DCntrl1.Picture = CType(resources.GetObject("AxAgUiAx2DCntrl1.Picture"), System.Drawing.Image)
        Me.AxAgUiAx2DCntrl1.Size = New System.Drawing.Size(574, 488)
        Me.AxAgUiAx2DCntrl1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(533, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "导入"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(533, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 27)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "创建"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(533, 85)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 31)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "清空"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(671, 118)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 28)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "开始"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(671, 152)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 29)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "暂停"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(671, 187)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(70, 30)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "重置"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(537, 281)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 36)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "生成图表"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(661, 52)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(92, 26)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "保存"
        Me.Button8.UseVisualStyleBackColor = True
        Me.Button8.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 903)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AxAgUiAx2DCntrl1)
        Me.Controls.Add(Me.AxAgUiAxVOCntrl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxAgUiAxVOCntrl1 As AGI.STKX.Controls.AxAgUiAxVOCntrl
    Friend WithEvents AxAgUiAx2DCntrl1 As AGI.STKX.Controls.AxAgUiAx2DCntrl
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button8 As Button
End Class

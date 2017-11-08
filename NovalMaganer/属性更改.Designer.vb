<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAE
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ED_txtName = New System.Windows.Forms.TextBox()
        Me.ED_txtType = New System.Windows.Forms.TextBox()
        Me.ED_txtSize = New System.Windows.Forms.TextBox()
        Me.ED_txtPath = New System.Windows.Forms.TextBox()
        Me.ED_txtET = New System.Windows.Forms.TextBox()
        Me.ED_txtCT = New System.Windows.Forms.TextBox()
        Me.ED_txtID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ED_chkExsit = New System.Windows.Forms.CheckBox()
        Me.ED_txtAT = New System.Windows.Forms.TextBox()
        Me.ED_txtRM = New System.Windows.Forms.TextBox()
        Me.ED_cboValuation = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ED_btnEdit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(12, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "名称:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "文件类型:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "大小:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "路径:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 12)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "创建时间:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(49, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 12)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "修改时间:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 12)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "访问时间:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 12)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "评价:"
        '
        'ED_txtName
        '
        Me.ED_txtName.Location = New System.Drawing.Point(125, 46)
        Me.ED_txtName.Name = "ED_txtName"
        Me.ED_txtName.Size = New System.Drawing.Size(347, 21)
        Me.ED_txtName.TabIndex = 10
        '
        'ED_txtType
        '
        Me.ED_txtType.Location = New System.Drawing.Point(125, 76)
        Me.ED_txtType.Name = "ED_txtType"
        Me.ED_txtType.ReadOnly = True
        Me.ED_txtType.Size = New System.Drawing.Size(200, 21)
        Me.ED_txtType.TabIndex = 11
        '
        'ED_txtSize
        '
        Me.ED_txtSize.Location = New System.Drawing.Point(125, 106)
        Me.ED_txtSize.Name = "ED_txtSize"
        Me.ED_txtSize.ReadOnly = True
        Me.ED_txtSize.Size = New System.Drawing.Size(200, 21)
        Me.ED_txtSize.TabIndex = 12
        '
        'ED_txtPath
        '
        Me.ED_txtPath.Location = New System.Drawing.Point(125, 136)
        Me.ED_txtPath.Name = "ED_txtPath"
        Me.ED_txtPath.Size = New System.Drawing.Size(347, 21)
        Me.ED_txtPath.TabIndex = 13
        '
        'ED_txtET
        '
        Me.ED_txtET.Location = New System.Drawing.Point(125, 196)
        Me.ED_txtET.Name = "ED_txtET"
        Me.ED_txtET.ReadOnly = True
        Me.ED_txtET.Size = New System.Drawing.Size(200, 21)
        Me.ED_txtET.TabIndex = 14
        '
        'ED_txtCT
        '
        Me.ED_txtCT.Location = New System.Drawing.Point(125, 166)
        Me.ED_txtCT.Name = "ED_txtCT"
        Me.ED_txtCT.ReadOnly = True
        Me.ED_txtCT.Size = New System.Drawing.Size(200, 21)
        Me.ED_txtCT.TabIndex = 15
        '
        'ED_txtID
        '
        Me.ED_txtID.Location = New System.Drawing.Point(125, 16)
        Me.ED_txtID.Name = "ED_txtID"
        Me.ED_txtID.ReadOnly = True
        Me.ED_txtID.Size = New System.Drawing.Size(200, 21)
        Me.ED_txtID.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 289)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 12)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "备注:"
        '
        'ED_chkExsit
        '
        Me.ED_chkExsit.AutoSize = True
        Me.ED_chkExsit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ED_chkExsit.Location = New System.Drawing.Point(343, 18)
        Me.ED_chkExsit.Name = "ED_chkExsit"
        Me.ED_chkExsit.Size = New System.Drawing.Size(72, 16)
        Me.ED_chkExsit.TabIndex = 18
        Me.ED_chkExsit.Text = "是否存在"
        Me.ED_chkExsit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ED_chkExsit.UseVisualStyleBackColor = True
        '
        'ED_txtAT
        '
        Me.ED_txtAT.Location = New System.Drawing.Point(125, 226)
        Me.ED_txtAT.Name = "ED_txtAT"
        Me.ED_txtAT.ReadOnly = True
        Me.ED_txtAT.Size = New System.Drawing.Size(200, 21)
        Me.ED_txtAT.TabIndex = 19
        '
        'ED_txtRM
        '
        Me.ED_txtRM.Location = New System.Drawing.Point(9, 304)
        Me.ED_txtRM.Multiline = True
        Me.ED_txtRM.Name = "ED_txtRM"
        Me.ED_txtRM.Size = New System.Drawing.Size(505, 210)
        Me.ED_txtRM.TabIndex = 20
        '
        'ED_cboValuation
        '
        Me.ED_cboValuation.FormattingEnabled = True
        Me.ED_cboValuation.Items.AddRange(New Object() {"收藏", "删除", "推荐", "赞扬"})
        Me.ED_cboValuation.Location = New System.Drawing.Point(125, 256)
        Me.ED_cboValuation.Name = "ED_cboValuation"
        Me.ED_cboValuation.Size = New System.Drawing.Size(200, 20)
        Me.ED_cboValuation.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ED_btnEdit)
        Me.GroupBox1.Controls.Add(Me.ED_cboValuation)
        Me.GroupBox1.Controls.Add(Me.ED_txtType)
        Me.GroupBox1.Controls.Add(Me.ED_txtRM)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ED_txtAT)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ED_chkExsit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ED_txtID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ED_txtCT)
        Me.GroupBox1.Controls.Add(Me.ED_txtET)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ED_txtPath)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ED_txtSize)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ED_txtName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 520)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'ED_btnEdit
        '
        Me.ED_btnEdit.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ED_btnEdit.Location = New System.Drawing.Point(414, 241)
        Me.ED_btnEdit.Name = "ED_btnEdit"
        Me.ED_btnEdit.Size = New System.Drawing.Size(100, 60)
        Me.ED_btnEdit.TabIndex = 22
        Me.ED_btnEdit.Text = "修改"
        Me.ED_btnEdit.UseVisualStyleBackColor = True
        '
        'frmAE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 541)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(560, 580)
        Me.MinimumSize = New System.Drawing.Size(560, 580)
        Me.Name = "frmAE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "属性更改"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ED_txtName As TextBox
    Friend WithEvents ED_txtType As TextBox
    Friend WithEvents ED_txtSize As TextBox
    Friend WithEvents ED_txtPath As TextBox
    Friend WithEvents ED_txtET As TextBox
    Friend WithEvents ED_txtCT As TextBox
    Friend WithEvents ED_txtID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ED_chkExsit As CheckBox
    Friend WithEvents ED_txtAT As TextBox
    Friend WithEvents ED_txtRM As TextBox
    Friend WithEvents ED_cboValuation As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ED_btnEdit As Button
End Class

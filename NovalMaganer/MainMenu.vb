Imports System.Windows.Forms
Imports System
Imports System.Data.OleDb
Imports System.IO


Public Class MainMenu
    '路径
    Dim SP As String
    Dim NoDB As Boolean
    '数据库是否为空
    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' 关闭此父窗体的所有子窗体。
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    '窗口加载调用显示
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim fExist As Boolean
        Dim Mymutex As New Threading.Mutex(True, "OnlyOneTime", fExist)
        If fExist Then
            Mymutex.ReleaseMutex()
            Call Display()
        Else
            MsgBox("程序已经在运行")
            Me.Close()
        End If

    End Sub
    '文件夹浏览对话框,有相应的流程图
    Private Sub tsbFolderBD_Click(sender As Object, e As EventArgs) Handles tsbFolderBD.Click
        If folderBD.ShowDialog(Me) = DialogResult.OK Then
            '获取路径
            SP = folderBD.SelectedPath
        Else
            Exit Sub
        End If

        If SP.CompareTo(tlblPath.Text) = 0 Then
            MsgBox("当前路径与数据库中一致,无需更改", vbOKOnly + vbExclamation, "数据一致")
            Exit Sub
        ElseIf MsgBox("是否要更新书单路径,请确认?", vbOKCancel + vbInformation, "确认更新") = vbOK Then

            With My.Settings
                .sPath = SP
            End With
            My.Settings.Save()
            Call tsbRefresh_Click(Nothing, Nothing)
        End If
    End Sub
    '刷新功能,调用显示
    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        Dim sw As New Stopwatch()
        sw.Start()

        '如果数据库为空,调用记录添加,调用显示
        If Not noDB Then
            Call DataNewAdd()
            Call Display()
        Else
            '执行更新
            'Call DataUpdate()
        End If

        MsgBox(sw.Elapsed.TotalSeconds.ToString)
    End Sub
    '显示按钮,调用显示
    Private Sub tsbDisplay_Click(sender As Object, e As EventArgs) Handles tsbDisplay.Click
        Call Display()
    End Sub
    '删除按钮删除数据库,调用显示
    Private Sub tsbDelete_Click(sender As Object, e As EventArgs) Handles tsbDelete.Click
        Dim sqlStr As String = "DELETE FROM NovelDB"
        If MsgBox("此操作将会删除所有数据,请确认是否继续操作", vbOKCancel + vbExclamation, "警告") = vbOK Then
            UpdateData(sqlStr)
            dgv.DataSource = "数据库为空"
            MsgBox("操作完成", vbOKOnly, "amin")
            Call Display()
        Else
            Exit Sub
        End If
    End Sub
    '插入新记录
    Private Sub DataNewAdd()
        Dim sqlStr As String = "SELECT * FROM NovelDB"
        Dim myDS As New DataSet()
        myDS.Clear()
        myDS = GetDataFromDB(sqlStr)
        Dim tb As DataTable = myDS.Tables(0)
        Dim cdm2 As New OleDbCommandBuilder(Adp)
        For Each folder As String In Directory.GetDirectories(SP)
            If Not folder.Contains("_gsdata_") Then
                For Each file As String In Directory.GetFiles(folder)
                    Dim fa As FileInfo = My.Computer.FileSystem.GetFileInfo(file)
                    Dim datarow As DataRow = tb.NewRow()
                    With fa
                        datarow(tb.Columns("ID")) = .GetHashCode()
                        datarow(tb.Columns("名称")) = .Name
                        datarow(tb.Columns("文件类型")) = .Extension
                        datarow(tb.Columns("大小")) = .Length
                        datarow(tb.Columns("路径")) = .FullName
                        datarow(tb.Columns("是否存在")) = CInt(.Exists)
                        datarow(tb.Columns("创建时间")) = .CreationTime
                        datarow(tb.Columns("访问时间")) = .LastAccessTime
                        datarow(tb.Columns("修改时间")) = .LastWriteTime
                        datarow(tb.Columns("评价")) = ""
                        datarow(tb.Columns("备注")) = ""
                        tb.Rows.Add(datarow)
                    End With
                Next
            End If
        Next
        Adp.Update(tb)
        MsgBox("ok", vbOKOnly, "刷新")
    End Sub

    Private Sub DataUpdate(ByVal myDS As DataSet)


    End Sub
    '在Datagridview显示数据
    Private Sub Display()
        Me.tlblPath.Text = My.Settings.sPath
        If tlblPath.Text.Length <> 0 Then
            SP = tlblPath.Text
            Dim myDS As New DataSet()
            Dim sqlStr As String = "SELECT * FROM NovelDB"
            myDS.Clear()
            myDS = GetDataFromDB(sqlStr)

            If myDS.Tables(0).Rows.Count = 0 Then
                NoDB = False
            Else
                NoDB = True
                dgv.DataSource = myDS.Tables(0).DefaultView
                myDS.Dispose()
                myDS = Nothing
            End If

            Call NoDB_Changed()

        Else
            Call tsbFolderBD_Click(Nothing, Nothing)
        End If
    End Sub
    '属性修改窗口
    Private Sub dgv_DoubleClick(sender As Object, e As EventArgs) Handles dgv.DoubleClick
        With frmAE
            .ED_txtID.Text = dgv.Item("ID", dgv.CurrentRow.Index).Value
            .ED_txtName.Text = dgv.Item("名称", dgv.CurrentRow.Index).Value
            .ED_txtType.Text = dgv.Item("文件类型", dgv.CurrentRow.Index).Value
            .ED_txtSize.Text = dgv.Item("大小", dgv.CurrentRow.Index).Value
            .ED_txtPath.Text = dgv.Item("路径", dgv.CurrentRow.Index).Value
            .ED_chkExsit.Checked = dgv.Item("是否存在", dgv.CurrentRow.Index).Value
            .ED_txtCT.Text = dgv.Item("创建时间", dgv.CurrentRow.Index).Value
            .ED_txtET.Text = dgv.Item("修改时间", dgv.CurrentRow.Index).Value
            .ED_txtAT.Text = dgv.Item("访问时间", dgv.CurrentRow.Index).Value
            .ED_cboValuation.Text = dgv.Item("评价", dgv.CurrentRow.Index).Value
            .ED_txtRM.Text = dgv.Item("备注", dgv.CurrentRow.Index).Value
        End With
        frmAE.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub
    Private Sub NoDB_Changed()
        Me.dgv.Enabled = NoDB
        Me.tsbDisplay.Enabled = NoDB
        Me.tsbDelete.Enabled = NoDB
        Me.lblNoDB.Visible = Not NoDB
    End Sub

    Private Sub lblNoDB_Click(sender As Object, e As EventArgs) Handles lblNoDB.Click

    End Sub
End Class

Imports System
Imports System.Data
Imports System.Data.OleDb

Module connectToDB
    Public Adp As OleDbDataAdapter
    Public cnn As OleDbConnection
    Dim DS As DataSet
    Public conStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\资源管理系统数据库.accdb;Persist Security Info=false"

    Public Function GetDataFromDB(ByVal sqlstr As String) As DataSet
        Try
            cnn = New OleDbConnection(conStr)
            Adp = New OleDbDataAdapter(sqlstr, cnn)
            DS = New DataSet()
            DS.Clear()
            Adp.Fill(DS)
            cnn.Close()
        Catch ex As Exception
            MsgBox("错误号: " & ex.HResult & " 错误描述: " & ex.Message, vbOKOnly + vbExclamation, "数据查询错误")
        End Try
        Return DS
    End Function

    Public Function UpdateData(ByVal sqlstr As String) As Boolean
        Try
            cnn = New OleDbConnection(conStr)
            Dim cmd As New OleDbCommand(sqlstr, cnn)
            cnn.Open()
            cmd.ExecuteNonQuery()
            cnn.Close()
        Catch ex As Exception
            MsgBox("错误号: " & ex.HResult & " 错误描述: " & ex.Message)
            Return False
        End Try
        Return True
    End Function

End Module

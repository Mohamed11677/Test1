Imports System.Data.OleDb
Public Class Frmadd
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\dbegrar.accdb")
    'Dim DT As New DataTable
    'Dim DA As New OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click

        If tb1.Text = "" Then
            MsgBox("يرجى كتابة" + " " + lbTitle.Text)
            Return
        End If
        Select Case lbTitle.Text
            Case "العنوان 9"
                Try
                    Dim sql As String = "Insert Into com9(name_t) values (@name_t)"
                    cmd = New OleDbCommand(sql, con)
                    cmd.Parameters.Add("@name_t", OleDbType.VarChar).Value = tb1.Text.ToString
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("تمت الإضافة بنجاح", MsgBoxStyle.Information, "الاضافة")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
                Form1.Enabled = True
                Me.Close()
                Refresh()

            Case "العنوان 10"
                Try
                    Dim sql As String = "Insert Into com10(name_t) values (@name_t)"
                    cmd = New OleDbCommand(sql, con)
                    cmd.Parameters.Add("@name_t", OleDbType.VarChar).Value = tb1.Text.ToString
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("تمت الإضافة بنجاح", MsgBoxStyle.Information, "الاضافة")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
                Form1.Enabled = True
                Me.Close()
                Refresh()

            Case "مصدر البضاعة"
                Try
                    Dim sql As String = "Insert Into com11(name_t) values (@name_t)"
                    cmd = New OleDbCommand(sql, con)
                    cmd.Parameters.Add("@name_t", OleDbType.VarChar).Value = tb1.Text.ToString
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("تمت الإضافة بنجاح", MsgBoxStyle.Information, "الاضافة")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
                Form1.Enabled = True
                Me.Close()
                Refresh()


            Case "منشأ البضاعة"
                Try
                    Dim sql As String = "Insert Into com12(name_t) values (@name_t)"
                    cmd = New OleDbCommand(sql, con)
                    cmd.Parameters.Add("@name_t", OleDbType.VarChar).Value = tb1.Text.ToString
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("تمت الإضافة بنجاح", MsgBoxStyle.Information, "الاضافة")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
                Form1.Enabled = True
                Me.Close()
                Refresh()


            Case "اسم وسيلة النقل"
                Try
                    Dim sql As String = "Insert Into com15(name_t) values (@name_t)"
                    cmd = New OleDbCommand(sql, con)
                    cmd.Parameters.Add("@name_t", OleDbType.VarChar).Value = tb1.Text.ToString
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("تمت الإضافة بنجاح", MsgBoxStyle.Information, "الاضافة")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
                Form1.Enabled = True
                Me.Close()
                Refresh()


            Case "ميناء الشحن "
                Try
                    Dim sql As String = "Insert Into com17(name_t) values (@name_t)"
                    cmd = New OleDbCommand(sql, con)
                    cmd.Parameters.Add("@name_t", OleDbType.VarChar).Value = tb1.Text.ToString
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("تمت الإضافة بنجاح", MsgBoxStyle.Information, "الاضافة")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
                Form1.Enabled = True
                Me.Close()
                Refresh()


            Case "ميناء الوصول"
                Try
                    Dim sql As String = "Insert Into com18(name_t) values (@name_t)"
                    cmd = New OleDbCommand(sql, con)
                    cmd.Parameters.Add("@name_t", OleDbType.VarChar).Value = tb1.Text.ToString
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("تمت الإضافة بنجاح", MsgBoxStyle.Information, "الاضافة")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
                Form1.Enabled = True
                Me.Close()
                Refresh()


            Case "اسم المصرف"
                Try
                    Dim sql As String = "Insert Into com23(name_t) values (@name_t)"
                    cmd = New OleDbCommand(sql, con)
                    cmd.Parameters.Add("@name_t", OleDbType.VarChar).Value = tb1.Text.ToString
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("تمت الإضافة بنجاح", MsgBoxStyle.Information, "الاضافة")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
                Form1.Enabled = True
                Me.Close()
                Refresh()


            Case "نوع العملة"
                Try
                    Dim sql As String = "Insert Into com26(name_t) values (@name_t)"
                    cmd = New OleDbCommand(sql, con)
                    cmd.Parameters.Add("@name_t", OleDbType.VarChar).Value = tb1.Text.ToString
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("تمت الإضافة بنجاح", MsgBoxStyle.Information, "الاضافة")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
                Form1.Enabled = True
                Me.Close()
                Refresh()


            Case "طريقة الشراء"
                Try
                    Dim sql As String = "Insert Into com25(name_t) values (@name_t)"
                    cmd = New OleDbCommand(sql, con)
                    cmd.Parameters.Add("@name_t", OleDbType.VarChar).Value = tb1.Text.ToString
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("تمت الإضافة بنجاح", MsgBoxStyle.Information, "الاضافة")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    con.Close()
                End Try
                Form1.Enabled = True
                Me.Close()
                Refresh()

        End Select
    End Sub

    Private Sub lbCancel_Click(sender As Object, e As EventArgs) Handles lbCancel.Click
        Form1.Enabled = True
        Me.Close()
    End Sub
End Class
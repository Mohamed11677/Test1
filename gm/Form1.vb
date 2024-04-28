Imports System.Data.OleDb


Public Class Form1

    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\dbegrar.accdb")
    Dim DT As New DataTable
    Dim DA As New OleDbDataAdapter
    Dim f21 As String
    Public cmd As New OleDbCommand
    Public dr As OleDbDataReader


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combo18.Text = "مصراتة"
        Textf013.Text = "وكيل"
        Textf3.Text = "نهائي"
        Date20.Text = Date.Now

        ComboLoad()

    End Sub

    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click
        End
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If RadioButton1.Checked = True Then
            f21 = RadioButton1.Text
        Else
            f21 = RadioButton2.Text
        End If
        Try
            Dim sql As String = "Insert Into egrar(f2 ,f3 ,f4 ,f5 ,f7 ,f8 ,f9 ,f10 ,f11 ,f12 ,f13 ,f13_1 ,f14 ,f15 ,f46 ,f17 ,f18 ,f20 ,f22 ,f23 ,f24 ,f25 ,f25_1 ,f26 ,f27 ,f28 ,f29, f21)  values (@f2 ,@f3 ,@f4 ,@f5 ,@f7 ,@f8 ,@f9 ,@f10 ,@f11 ,@f12 ,@f13 ,@f13_1 ,@f14 ,@f15 ,@f46 ,@f17 ,@f18 ,@f20 ,@f22 ,@f23 ,@f24 ,@f25 ,@f25_1 ,@f26 ,@f27 ,@f28 ,@f29, @f21)"
            Dim cmd As New OleDbCommand(sql, con)
            'cmd.Parameters.Add(New OleDbParameter("@f1", CType(Textf1.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("@f2", CType(Textf2.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("@f3", CType(Textf3.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("@f4", CType(Textf4.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("@f5", CType(Textf5.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("@f7", CType(Textf7.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("@f8", CType(Textf8.Text, String)))
            cmd.Parameters.Add("@f9", OleDbType.VarChar).Value = Combo9.Text
            cmd.Parameters.Add("@f10", OleDbType.VarChar).Value = Combo10.Text
            cmd.Parameters.Add("@f11", OleDbType.VarChar).Value = Combo11.Text
            cmd.Parameters.Add("@f12", OleDbType.VarChar).Value = Combo12.Text
            cmd.Parameters.Add(New OleDbParameter("@f13", CType(Textf13.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("f13_1", CType(Textf013.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("@f14", CType(Textf14.Text, String)))
            cmd.Parameters.Add("@f15", OleDbType.VarChar).Value = Combo15.Text
            cmd.Parameters.Add(New OleDbParameter("@f46", CType(Textf46.Text, String)))
            cmd.Parameters.Add("@f17", OleDbType.VarChar).Value = Combo17.Text
            cmd.Parameters.Add("@f18", OleDbType.VarChar).Value = Combo18.Text
            cmd.Parameters.Add("@f20", OleDbType.DBDate).Value = Date20.Value
            cmd.Parameters.Add(New OleDbParameter("@f22", CType(Textf22.Text, String)))
            cmd.Parameters.Add("@f23", OleDbType.VarChar).Value = Combo23.Text
            cmd.Parameters.Add(New OleDbParameter("@f24", CType(Textf24.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("@f25", CType(Textf25.Text, Integer)))
            cmd.Parameters.Add("@f25_1", OleDbType.VarChar).Value = Combo25.Text
            cmd.Parameters.Add("@f26", OleDbType.VarChar).Value = Combo26.Text
            cmd.Parameters.Add(New OleDbParameter("@f27", CType(Textf27.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("@f28", CType(Textf28.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("@f29", CType(Textf29.Text, String)))
            cmd.Parameters.Add("@f21", OleDbType.VarChar).Value = f21
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("تمت الإضافة بنجاح", MsgBoxStyle.Information, "الاضافة")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DA = New OleDbDataAdapter("select * from egrar", con)
        DA.Fill(DT)
        DataGridView2.DataSource = DT
    End Sub

   
    Private Sub Ladd9_Click(sender As Object, e As EventArgs) Handles Ladd9.Click
        Frmadd.lbTitle.Text = "العنوان 9"
        Me.Enabled = False
        Frmadd.Show()

    End Sub

    Private Sub Ladd10_Click(sender As Object, e As EventArgs) Handles Ladd10.Click
        Frmadd.lbTitle.Text = "العنوان 10"
        Me.Enabled = False
        Frmadd.Show()
    End Sub

    Private Sub Ladd11_Click(sender As Object, e As EventArgs) Handles Ladd11.Click
        Frmadd.lbTitle.Text = "مصدر البضاعة"
        Me.Enabled = False
        Frmadd.Show()
    End Sub

    Private Sub Ladd12_Click(sender As Object, e As EventArgs) Handles Ladd12.Click
        Frmadd.lbTitle.Text = "منشأ البضاعة"
        Me.Enabled = False
        Frmadd.Show()
    End Sub

    Private Sub Ladd15_Click(sender As Object, e As EventArgs) Handles Ladd15.Click
        Frmadd.lbTitle.Text = "اسم وسيلة النقل"
        Me.Enabled = False
        Frmadd.Show()
    End Sub

    Private Sub Ladd17_Click(sender As Object, e As EventArgs) Handles Ladd17.Click
        Frmadd.lbTitle.Text = "ميناء الشحن "
        Me.Enabled = False
        Frmadd.Show()
    End Sub

    Private Sub Ladd18_Click(sender As Object, e As EventArgs) Handles Ladd18.Click
        Frmadd.lbTitle.Text = "ميناء الوصول"
        Me.Enabled = False
        Frmadd.Show()
    End Sub

    Private Sub Ladd23_Click(sender As Object, e As EventArgs) Handles Ladd23.Click
        Frmadd.lbTitle.Text = "اسم المصرف"
        Me.Enabled = False
        Frmadd.Show()
    End Sub

    Private Sub Ladd26_Click(sender As Object, e As EventArgs) Handles Ladd26.Click
        Frmadd.lbTitle.Text = "نوع العملة"
        Me.Enabled = False
        Frmadd.Show()
    End Sub

    Private Sub Ladd25_Click(sender As Object, e As EventArgs) Handles Ladd25.Click
        Frmadd.lbTitle.Text = "طريقة الشراء"
        Me.Enabled = False
        Frmadd.Show()
    End Sub

    Private Sub ComboLoad()
        con.Open()
        Combo9.Items.Clear()
        cmd.CommandText = "Select * from com9"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            Combo9.Items.Add(dr.GetString(1))
        End While
        dr.Close()
        con.Close()

        con.Open()
        Combo10.Items.Clear()
        cmd.CommandText = "Select * from com10"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            Combo10.Items.Add(dr.GetString(1))
        End While
        dr.Close()
        con.Close()

        con.Open()
        Combo11.Items.Clear()
        cmd.CommandText = "Select * from com11"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            Combo11.Items.Add(dr.GetString(1))
        End While
        dr.Close()
        con.Close()

        con.Open()
        Combo12.Items.Clear()
        cmd.CommandText = "Select * from com12"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            Combo12.Items.Add(dr.GetString(1))
        End While
        dr.Close()
        con.Close()

        con.Open()
        Combo15.Items.Clear()
        cmd.CommandText = "Select * from com15"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            Combo15.Items.Add(dr.GetString(1))
        End While
        dr.Close()
        con.Close()

        con.Open()
        Combo17.Items.Clear()
        cmd.CommandText = "Select * from com17"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            Combo17.Items.Add(dr.GetString(1))
        End While
        dr.Close()
        con.Close()

        con.Open()
        Combo18.Items.Clear()
        cmd.CommandText = "Select * from com18"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            Combo18.Items.Add(dr.GetString(1))
        End While
        dr.Close()
        con.Close()

        con.Open()
        Combo23.Items.Clear()
        cmd.CommandText = "Select * from com23"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            Combo23.Items.Add(dr.GetString(1))
        End While
        dr.Close()
        con.Close()

        con.Open()
        Combo25.Items.Clear()
        cmd.CommandText = "Select * from com25"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            Combo25.Items.Add(dr.GetString(1))
        End While
        dr.Close()
        con.Close()

        con.Open()
        Combo26.Items.Clear()
        cmd.CommandText = "Select * from com26"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            Combo26.Items.Add(dr.GetString(1))
        End While
        dr.Close()
        con.Close()


    End Sub







    'loadbasic()
    'DataGridView2.DataSource = DT
    'Try
    '    con.Open()
    '    DA = New OleDb.OleDbDataAdapter(" Select from egrar", con)
    '    DA.Fill(DT, "myaddressbook")
    '    con.Close()
    'Catch ex As Exception
    '    MessageBox.Show(ex.ToString)
    'End Try





    

    
End Class




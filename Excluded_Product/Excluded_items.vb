
Imports System.Data.SqlClient

Public Class Excluded_items
    Public Shared Org_createDate As DateTime
    Public Shared Org_prodCode As String
    Public Shared Org_creator As String
    Public Shared Org_createDate_remarks As DateTime
    Public Shared Org_remarks As String
    Public Shared Org_creator_remarks As String
    Private Sub Excluded_items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SOTDataSet.REMARKS' table. You can move, or remove it, as needed.
        Me.REMARKSTableAdapter.Fill(Me.SOTDataSet.REMARKS)
        'TODO: This line of code loads data into the 'SOTDataSet.EXPROD' table. You can move, or remove it, as needed.
        Me.EXPRODTableAdapter.Fill(Me.SOTDataSet.EXPROD)
        txt_createDate.Text = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
        txt_createDate_remarks.Text = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
        txt_creator.Text = Environment.UserName
        txt_creator_remarks.Text = Environment.UserName
    End Sub

    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If TabControl1.SelectedTab.Name = "prodCode" Then
            If txt_prodCode.Text <> "" Then
                Try
                    DataGridView1.DataSource = EXPRODBindingSource
                    txt_createDate.Text = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
                    Dim creatDate As DateTime = Date.ParseExact(txt_createDate.Text, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture)
                    Me.EXPRODTableAdapter.InsertQuery(creatDate, Environment.UserName, txt_prodCode.Text)
                    Me.EXPRODTableAdapter.Fill(SOTDataSet.EXPROD)
                    Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1
                Catch ex As SqlException
                    MsgBox("Error: " + ex.ToString + "Dữ liệu bị trùng lập!")
                End Try
            Else
                MsgBox("Vui lòng nhập trường bắt buộc!")
            End If
        ElseIf TabControl1.SelectedTab.Name = "remarks" Then
            If txt_remarks.Text <> "" Then
                Try
                    DataGridView2.DataSource = REMARKSBindingSource
                    txt_createDate_remarks.Text = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
                    Me.REMARKSTableAdapter.InsertQuery(txt_createDate_remarks.Text, Environment.UserName, txt_remarks.Text)
                    Me.REMARKSTableAdapter.Fill(SOTDataSet.REMARKS)
                    Me.DataGridView2.FirstDisplayedScrollingRowIndex = Me.DataGridView2.RowCount - 1
                Catch ex As Exception
                    MsgBox("Dữ liệu bị trùng lập!")
                End Try
            Else
                MsgBox("Vui lòng nhập trường bắt buộc!")
            End If
        End If

    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim result As Integer = MessageBox.Show("Bạn có chắn muốn xóa dữ liệu?", "Cảnh báo xóa dữ liệu", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            If TabControl1.SelectedTab.Name = "prodCode" Then
                Try
                    DataGridView1.DataSource = EXPRODBindingSource
                    Me.EXPRODTableAdapter.DeleteQuery(txt_prodCode.Text)
                    Me.EXPRODTableAdapter.Fill(SOTDataSet.EXPROD)
                    If DataGridView1.Rows.Count > 0 Then
                        Dim selectedRow As DataGridViewRow = DataGridView1.Rows(0)
                        txt_createDate.Text = selectedRow.Cells(0).Value.ToString
                        txt_creator.Text = selectedRow.Cells(1).Value.ToString
                        txt_prodCode.Text = selectedRow.Cells(2).Value.ToString
                        Org_createDate = selectedRow.Cells(0).Value
                        Org_creator = selectedRow.Cells(1).Value.ToString
                        Org_prodCode = selectedRow.Cells(2).Value.ToString
                    Else
                        MsgBox("Không có dữ liệu!")
                    End If
                Catch ex As Exception
                    MsgBox("Không có dữ liệu!")
                End Try
            ElseIf TabControl1.SelectedTab.Name = "remarks" Then
                Try
                    DataGridView2.DataSource = REMARKSBindingSource
                    Me.REMARKSTableAdapter.DeleteQuery(txt_remarks.Text)
                    Me.REMARKSTableAdapter.Fill(SOTDataSet.REMARKS)
                    If DataGridView2.Rows.Count > 0 Then
                        Dim selectedRow As DataGridViewRow = DataGridView2.Rows(0)
                        txt_createDate_remarks.Text = selectedRow.Cells(0).Value.ToString
                        txt_creator_remarks.Text = selectedRow.Cells(1).Value.ToString
                        txt_remarks.Text = selectedRow.Cells(2).Value.ToString
                        Org_createDate_remarks = selectedRow.Cells(0).Value
                        Org_creator_remarks = selectedRow.Cells(1).Value.ToString
                        Org_remarks = selectedRow.Cells(2).Value.ToString
                    Else
                        MsgBox("Không có dữ liệu!")
                    End If
                Catch ex As Exception
                    MsgBox("Không có dữ liệu!")
                End Try
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim rowIdex As Integer = e.RowIndex
        If rowIdex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(rowIdex)
            txt_createDate.Text = selectedRow.Cells(0).Value.ToString
            txt_creator.Text = selectedRow.Cells(1).Value.ToString
            txt_prodCode.Text = selectedRow.Cells(2).Value.ToString
            Org_createDate = selectedRow.Cells(0).Value
            Org_creator = selectedRow.Cells(1).Value.ToString
            Org_prodCode = selectedRow.Cells(2).Value.ToString
        End If
    End Sub
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim rowIdex As Integer = e.RowIndex
        If rowIdex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView2.Rows(rowIdex)
            txt_createDate_remarks.Text = selectedRow.Cells(0).Value.ToString
            txt_creator_remarks.Text = selectedRow.Cells(1).Value.ToString
            txt_remarks.Text = selectedRow.Cells(2).Value.ToString
            Org_createDate_remarks = selectedRow.Cells(0).Value
            Org_creator_remarks = selectedRow.Cells(1).Value.ToString
            Org_remarks = selectedRow.Cells(2).Value.ToString
        End If
    End Sub
    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If TabControl1.SelectedTab.Name = "prodCode" Then
            Try
                DataGridView1.DataSource = EXPRODBindingSource
                txt_createDate.Text = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
                Me.EXPRODTableAdapter.UpdateQuery(txt_createDate.Text, Environment.UserName, txt_prodCode.Text, Org_prodCode)
                Me.EXPRODTableAdapter.Fill(SOTDataSet.EXPROD)
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox("Vui lòng nhập trường bắt buộc!")
            End Try
        ElseIf TabControl1.SelectedTab.Name = "remarks" Then
            Try
                DataGridView2.DataSource = REMARKSBindingSource
                txt_createDate_remarks.Text = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
                Me.REMARKSTableAdapter.UpdateQuery(txt_createDate_remarks.Text, Environment.UserName, txt_remarks.Text, Org_remarks)
                Me.REMARKSTableAdapter.Fill(SOTDataSet.REMARKS)
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox("Vui lòng nhập trường bắt buộc!")
            End Try
        End If

    End Sub

    Private Sub Btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Dim searchAdpt As New SOTDataSetTableAdapters.EXPRODTableAdapter
        Dim dataSearch As DataTable = searchAdpt.GetDataByPRODCODE(txt_prodCode.Text)
        DataGridView1.DataSource = dataSearch
    End Sub

    Private Sub Btn_search_remarks_Click(sender As Object, e As EventArgs) Handles btn_search_remarks.Click
        Dim searchAdpt As New SOTDataSetTableAdapters.REMARKSTableAdapter
        Dim dataSearch As DataTable = searchAdpt.GetDataByREMARKS(txt_remarks.Text)
        DataGridView2.DataSource = dataSearch
    End Sub
End Class

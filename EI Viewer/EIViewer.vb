Public Class EIViewer
    Public Shared Org_TD002 As String
    Public Shared Org_TD003 As String
    Public Shared Org_TD004 As String
    Public Shared Org_TD008 As String
    Public Shared Org_TD013 As String

    Private Sub EIViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SOTDataSet.BLCOPTD' table. You can move, or remove it, as needed.
        Try
            Me.BLCOPTDTableAdapter.Fill(Me.SOTDataSet.BLCOPTD)

        Catch ex As Exception

        End Try
        'TODO: This line of code loads data into the 'TECHLINKDataSet.COPTC' table. You can move, or remove it, as needed.
        Me.COPTCTableAdapter.Fill(Me.TECHLINKDataSet.COPTC)
        btn_update.Enabled = True
        btn_delete.Enabled = False
    End Sub

    Private Sub Btn_search_orderType_Click(sender As Object, e As EventArgs) Handles btn_search_orderType.Click
        Dim searchAdpt As New TECHLINKDataSetTableAdapters.COPTCTableAdapter
        Dim dataSearch As DataTable = searchAdpt.GetDataByTC012(txt_TC012.Text)
        dvg_COPTC.DataSource = dataSearch
    End Sub

    Private Sub Dvg_COPTC_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvg_COPTC.CellClick
        Dim rowIdex As Integer = e.RowIndex
        If rowIdex >= 0 Then
            Dim selectedRow As DataGridViewRow = dvg_COPTC.Rows(rowIdex)
            txt_creator.Text = selectedRow.Cells(0).Value.ToString
            txt_createDate.Text = selectedRow.Cells(1).Value.ToString
            txt_TC012.Text = selectedRow.Cells(2).Value.ToString
            txt_TC001.Text = selectedRow.Cells(3).Value.ToString
            txt_TC002.Text = selectedRow.Cells(4).Value.ToString
            txt_TC003.Text = selectedRow.Cells(5).Value.ToString
            txt_TC004.Text = selectedRow.Cells(6).Value.ToString
            txt_TC005.Text = selectedRow.Cells(7).Value.ToString
            txt_TC008.Text = selectedRow.Cells(8).Value.ToString
        End If
    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If TabControl1.SelectedTab.Name = "orderType" Then
            Try
                dvg_COPTC.DataSource = COPTCBindingSource
                Me.COPTCTableAdapter.UpdateTC001(txt_TC001.Text, txt_TC012.Text, txt_TC002.Text)
                Me.COPTCTableAdapter.Fill(TECHLINKDataSet.COPTC)
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox("Vui lòng nhập trường bắt buộc!")
            End Try
        End If
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        If TabControl1.SelectedTab.Name = "orderType" Then
            btn_update.Enabled = True
            btn_delete.Enabled = False
        Else
            btn_update.Enabled = False
            btn_delete.Enabled = True
        End If
    End Sub

    Private Sub Dvg_BLCOPTD_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvg_BLCOPTD.CellClick
        Dim rowIdex As Integer = e.RowIndex
        If rowIdex >= 0 Then
            Dim selectedRow As DataGridViewRow = dvg_BLCOPTD.Rows(rowIdex)
            txt_TD002.Text = selectedRow.Cells(0).Value.ToString
            txt_TD003.Text = selectedRow.Cells(1).Value.ToString
            txt_TD004.Text = selectedRow.Cells(2).Value.ToString
            txt_TD008.Text = selectedRow.Cells(3).Value.ToString
            txt_TD013.Text = selectedRow.Cells(4).Value.ToString
        End If
    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim result As Integer = MessageBox.Show("Bạn có chắn muốn xóa dữ liệu?", "Cảnh báo xóa dữ liệu", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            Try
                dvg_BLCOPTD.DataSource = BLCOPTDBindingSource
                Me.BLCOPTDTableAdapter.DeleteQuery(txt_TD002.Text)
                Me.BLCOPTDTableAdapter.Fill(SOTDataSet.BLCOPTD)
                If dvg_BLCOPTD.Rows.Count > 0 Then
                    Dim selectedRow As DataGridViewRow = dvg_BLCOPTD.Rows(0)
                    txt_TD002.Text = selectedRow.Cells(0).Value.ToString
                    txt_TD003.Text = selectedRow.Cells(1).Value.ToString
                    txt_TD004.Text = selectedRow.Cells(2).Value.ToString
                    txt_TD008.Text = selectedRow.Cells(3).Value.ToString
                    txt_TD013.Text = selectedRow.Cells(4).Value.ToString
                    Org_TD002 = txt_TD002.Text
                    Org_TD003 = txt_TD003.Text
                    Org_TD004 = txt_TD004.Text
                    Org_TD008 = txt_TD008.Text
                    Org_TD013 = txt_TD013.Text
                Else
                    MsgBox("Không có dữ liệu!")
                End If
            Catch ex As Exception
                MsgBox("Không có dữ liệu!")
            End Try
        End If
    End Sub

    Private Sub Btn_search_BLCOPTD_Click(sender As Object, e As EventArgs) Handles btn_search_BLCOPTD.Click
        Dim searchAdpt As New SOTDataSetTableAdapters.BLCOPTDTableAdapter
        Dim dataSearch As DataTable = searchAdpt.GetDataByTD002(txt_TD002.Text)
        dvg_BLCOPTD.DataSource = dataSearch
    End Sub
End Class


Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports Excel = Microsoft.Office.Interop.Excel
'Imports System.Configuration
'Imports System.Net.Mail
'Imports System.Runtime.CompilerServices
'Imports System.ComponentModel
Public Class SOT
    'Public Shared perc As Integer = 0 '---> 0% for initializing
    ' Report table for MO
    Public Shared DtFailedUpdMO As New DataTable
    Public Shared dtSuccessMO As New DataTable
    ' Report table for SO
    Public Shared DtMissOrgMO As New DataTable
    Public Shared DtMissProdInfo As New DataTable
    Public Shared DtSuccessDelSO As New DataTable
    Public Shared DtSuccessUpdSO As New DataTable
    Public Shared DtSuccessInsSO As New DataTable
    Private Sub SOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        ' Retrieving usr settings
        Dim dummy As String = My.Settings.dummy
        For Each value As Configuration.SettingsPropertyValue In My.Settings.PropertyValues
            Dim strValue As String = value.Name
            If Strings.Left(strValue, 3) = "cfg" Then
                '  MsgBox(strValue & " - " & value.PropertyValue.ToString)
                Dim strCtrName As String = Replace(strValue, "cfg", "txt")
                Dim ctrName = Me.Controls.Find(strCtrName, True)
                If ctrName.Count = 1 Then
                    Try
                        ctrName(0).Text = value.PropertyValue.ToString
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        Next
        Elog("Configuration loaded.")
    End Sub

    Private Sub EnumControls(ByVal ctl As Control, sts As Boolean)
        If TypeOf ctl IsNot Form And TypeOf ctl IsNot TabControl And TypeOf ctl IsNot TabPage Then
            If ctl.Name <> "btn_stop" And
               ctl.Name <> "lbl_eventlogs" And
               ctl.Name <> "txt_elogs" And
               ctl.Name <> "grp_process_sts" And
               ctl.Name <> "lbl_data_trans" And
               ctl.Name <> "prb_data_trans" And
               ctl.Name <> "lbl_next_trigger" And
               ctl.Name <> "txt_recipients" And
               ctl.Name <> "prb_next_trigger" Then
                ctl.Enabled = sts
            End If
        End If
        If ctl.HasChildren Then
            For Each c As Control In ctl.Controls
                EnumControls(c, sts)
            Next
        End If
    End Sub

    Delegate Sub LogMessageDelegate(textToAdd As String, prg As Integer)

    Private Sub Elog(ByVal str As String, Optional pr As Integer = 0)
        Dim cl As Color = Color.Black
        If pr = 1 Then
            cl = Color.Orange
        ElseIf pr = 2 Then
            cl = Color.Green
        ElseIf pr = 3 Then
            cl = Color.Red
        End If
        Dim inst_time = Date.Now.ToString("dd/MM/yyyy hh:mm:ss")
        With txt_elogs
            .SelectionColor = cl
            .AppendText(inst_time & ": " & str & vbNewLine)
        End With
    End Sub

    Private Sub Src_btn_test_Click(sender As Object, e As EventArgs) Handles src_btn_test.Click
        Dim strCN As String = "Data Source=" & txt_src_hostname.Text & "," & txt_src_port.Text &
                                   "; Network Library=dbmssocn; Initial Catalog=" & txt_src_db.Text &
                                        "; User ID=" & txt_src_usrname.Text & "; Password=" & txt_src_pw.Text
        EnumControls(Me, False)
        Try
            Elog("Connecting to " & txt_src_hostname.Text & "...", 1)
            Dim connection As New SqlConnection(strCN)
            connection.Open()
            connection.Close()
            Elog(String.Format("Connection to {0} successful. Test passed.", txt_src_hostname.Text), 2)
            MsgBox("Connection successful.", MsgBoxStyle.Information)
        Catch ex As Exception
            Elog(String.Format("Connection to {0} failed. Error: {1}", txt_src_hostname.Text, ex.Message.ToString), 3)
            MsgBox("Connection failed. Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
        EnumControls(Me, True)
    End Sub

    Private Sub Tar_btn_test_Click(sender As Object, e As EventArgs) Handles tar_btn_test.Click
        'Remember to add Port and Network Library=dbmssocn; when deploy
        Dim strCN As String = "Data Source=" & txt_tar_hostname.Text &
                                "; Initial Catalog=" & txt_tar_db.Text &
                                    "; User ID=" & txt_tar_usrname.Text & "; Password=" & txt_tar_pw.Text
        EnumControls(Me, False)
        Try
            Elog("Connecting to " & txt_tar_hostname.Text & "...", 1)
            Dim connection As New SqlConnection(strCN)
            connection.Open()
            connection.Close()
            Elog(String.Format("Connection to {0} successful. Test passed.", txt_tar_hostname.Text), 2)
            MsgBox("Connection successful.", MsgBoxStyle.Information)
        Catch ex As Exception
            Elog(String.Format("Connection to {0} failed. Error: {1}", txt_tar_hostname.Text, ex.Message.ToString), 3)
            MsgBox("Connection failed. Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
        EnumControls(Me, True)
    End Sub

    Private Sub src_txt_hostname_LostFocus(sender As Object, e As EventArgs) Handles txt_src_hostname.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_src_hostname = txt_src_hostname.Text
        mySettings.Save()
        'MessageBox.Show(My.Settings.src_hostname)
    End Sub

    Private Sub src_txt_port_LostFocus(sender As Object, e As EventArgs) Handles txt_src_port.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_src_port = txt_src_port.Text
        mySettings.Save()
    End Sub

    Private Sub src_usrname_LostFocus(sender As Object, e As EventArgs) Handles txt_src_usrname.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_src_usrname = txt_src_usrname.Text
        mySettings.Save()
    End Sub

    Private Sub src_pw_LostFocus(sender As Object, e As EventArgs) Handles txt_src_pw.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_src_pw = txt_src_pw.Text
        mySettings.Save()
    End Sub

    Private Sub src_txt_db_LostFocus(sender As Object, e As EventArgs) Handles txt_src_db.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_src_db = txt_src_db.Text
        mySettings.Save()
    End Sub

    Private Sub tar_txt_hostname_LostFocus(sender As Object, e As EventArgs) Handles txt_tar_hostname.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_tar_hostname = txt_tar_hostname.Text
        mySettings.Save()
    End Sub

    Private Sub tar_txt_port_LostFocus(sender As Object, e As EventArgs) Handles txt_tar_port.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_tar_port = txt_tar_port.Text
        mySettings.Save()
    End Sub

    Private Sub tar_txt_usrname_LostFocus(sender As Object, e As EventArgs) Handles txt_tar_usrname.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_tar_usrname = txt_tar_usrname.Text
        mySettings.Save()
    End Sub

    Private Sub tar_txt_pw_LostFocus(sender As Object, e As EventArgs) Handles txt_tar_pw.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_tar_pw = txt_tar_pw.Text
        mySettings.Save()
    End Sub

    Private Sub tar_txt_db_LostFocus(sender As Object, e As EventArgs) Handles txt_tar_db.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_tar_db = txt_tar_db.Text
        mySettings.Save()
    End Sub

    Private Sub txt_email_sender_LostFocus(sender As Object, e As EventArgs) Handles txt_sender.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_sender = txt_sender.Text
        mySettings.Save()
    End Sub

    Private Sub txt_sender_pw_LostFocus(sender As Object, e As EventArgs) Handles txt_sender_pw.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_sender_pw = txt_sender_pw.Text
        mySettings.Save()
    End Sub

    Private Sub txt_recipients_LostFocus(sender As Object, e As EventArgs) Handles txt_recipients.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_recipients = txt_recipients.Text
        mySettings.Save()
    End Sub

    Private Sub dtp_sp_LostFocus(sender As Object, e As EventArgs) Handles txt_spt.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_spt = txt_spt.Text
        mySettings.Save()
    End Sub

    Private Sub Btn_email_test_Click(sender As Object, e As EventArgs) Handles btn_email_test.Click
        Dim mySettings = My.Settings
        Elog(String.Format("Authorizing email {0}...", mySettings.cfg_sender), 1)
        Dim email As String = mySettings.cfg_sender
        Dim smtp As String = Strings.Right(email, email.Length - email.IndexOf("@"))
        If smtp = "@gmail.com" Then
            mySettings.smtp_server = "smtp.gmail.com"
            mySettings.smtp_port = "587"
        ElseIf smtp = "@techlink.vn" Then
            mySettings.smtp_server = "smtp.gg.com"
            mySettings.smtp_port = "465"
        End If
        mySettings.Save()
        Dim GGmail As New GMAIL(mySettings.cfg_sender, mySettings.cfg_sender_pw)
        Dim ToAddressies As String() = {mySettings.cfg_sender}
        'Dim attachs() As String = {"d:\temp_Excell226.xlsx", "d:\temp_Excell224.xlsx", "d:\temp_Excell225.xlsx"}
        Dim subject As String = "Test Email"
        Dim body As String = "This is for testing SMTP mail from GMAIL."
        EnumControls(Me, False)
        Dim result As Boolean = GGmail.SendMail(ToAddressies, subject, body)
        If result Then
            Elog("Email authorized successfully.", 2)
            MsgBox("Email authorized successfully.", MsgBoxStyle.Information)
        Else
            Elog("Authorization failed. Error: " & GGmail.ErrorText, 3)
            MsgBox(GGmail.ErrorText, MsgBoxStyle.Critical)
        End If
        EnumControls(Me, True)
    End Sub

    Private Sub Tmr_Schedule_Tick(sender As Object, e As EventArgs) Handles tmr_schedule.Tick
        If Not BW.IsBusy = True Then
            txt_elogs.Text = ""
            BW.RunWorkerAsync()
        End If
    End Sub

    Private Function GetData(cn As SqlConnection, cmd As String, strDt As String) As DataTable
        Using da As New SqlDataAdapter(cmd, cn)
            Dim dt As New DataTable(strDt)
            Try
                da.Fill(dt)
                'perc += dt.Rows.Count
                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {String.Format("Data in table {0} read sucessfully. {1} new data entries found.", dt.TableName, dt.Rows.Count), 2})
            Catch ex As SqlException
                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Can't read table " & dt.TableName & ". Error: " & ex.Message.ToString, 3})
            End Try
            Return dt
        End Using
    End Function

    ' Transform datarow to string to put into the sqlcommand
    Private Function DataArr2DataStr(Arr()) As String
        For i As Integer = 0 To Arr.Length - 1
            Arr(i) = Arr(i).ToString.Replace("'", "''")
        Next i
        Dim str As String = "'" + String.Join("', '", Arr) + "'"
        Return str
    End Function

    ' Create auto increment number to insert into the datatable
    Private Sub IncrementSub(ByVal dt As DataTable, col As String, fm As String)
        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i)(col) = (i + 1).ToString(fm)
        Next i
    End Sub

    ' Fill CUS CODE
    Private Sub CusFill(dtScr As DataTable, clSrc As String, dtTar As DataTable, clTar As String)
        For i As Integer = 0 To dtTar.Rows.Count - 1
            Dim found As Boolean = False
            Dim foundPosition As Integer
            'dtTar.Rows(i)("XA008") = Strings.Left(dtTar.Rows(i)("XA008"), 3) '--> Currency EURO to EUR
            For j As Integer = 0 To dtScr.Rows.Count - 1
                Dim valLookUP As String = Strings.Trim(dtScr.Rows(j)(clSrc))
                If valLookUP = Strings.Trim(dtTar.Rows(i)(clTar)) Then
                    found = True
                    foundPosition = j
                End If
            Next j
            If found Then
                dtTar.Rows(i)(clTar) = Strings.Trim(dtScr.Rows(foundPosition)("MA001")) '--> Customer code
                dtTar.Rows(i)("XA007") = Strings.Trim(dtScr.Rows(foundPosition)("MA003")) '--> Customer full name
            Else
                dtTar.Rows(i)(clTar) = "DL01"
                dtTar.Rows(i)("XA007") = "得霖科技有限公司"
            End If
        Next i
    End Sub

    ' Get XB001, XB002
    Private Sub AssignMONo(dtMODic As DataTable, dtSO As DataTable, dtRp As DataTable)
        For Each drSO As DataRow In dtSO.Rows
            Dim found As Boolean = False
            For Each drMO As DataRow In dtMODic.Rows
                If drMO(2) = drSO(2) Then
                    drSO(0) = drMO(0)
                    drSO(1) = drMO(1)
                    found = True
                    Exit For
                End If
            Next drMO
            If Not found Then
                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"The original Order No. " & drSO(2).ToString & " not found. Please update it mannually.", 1})
                dtRp.Rows.Add(drSO.ItemArray)
                drSO.Delete()
            End If
        Next drSO
        dtSO.AcceptChanges()
    End Sub

    ' Fill Product Number
    Private Sub ProdNoFill(dtPRO As DataTable, dtSO As DataTable, strCNVNBL As String, strDtBL As String, dtRp As DataTable)
        Dim tbclBL As String = Tbcol(Strings.Right(strDtBL, 2))
        Dim DelRows As New List(Of DataRow)
        Dim drSO As DataRow
        For Each drSO In dtSO.Rows
            Dim found As Boolean = False
            For Each drPRO As DataRow In dtPRO.Rows
                If drSO("XB006") = drPRO("MG003") Then
                    found = True
                    drSO("XB006") = drPRO("MG002")
                    Exit For
                End If
            Next
            If Not found Then
                Dim dataValArr() = drSO.ItemArray
                Dim dataValSO As String = DataArr2DataStr(dataValArr)
                Dim strInsSO As String = String.Format("INSERT INTO dbo.{0} ({1}) VALUES ({2})", strDtBL, tbclBL, dataValSO)
                Using cn As New SqlConnection(strCNVNBL)
                    cn.Open()
                    Try
                        Using cmdSO As New SqlCommand()
                            With cmdSO
                                .Connection = cn
                                .CommandType = CommandType.Text
                                .CommandText = strInsSO
                            End With
                            cmdSO.ExecuteNonQuery()
                        End Using
                        dtRp.Rows.Add(drSO.ItemArray)
                        DelRows.Add(drSO)
                        'dtSO.Rows.Remove(drSO)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                    txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"The product number " & dataValArr(5).ToString & " not found. Cannot import Order No. " & dataValArr(2).ToString & "-" & dataValArr(4).ToString & ".", 3})
                End Using
            End If
        Next
        For Each drBL As DataRow In DelRows
            dtSO.Rows.Remove(drBL)
        Next
        dtSO.AcceptChanges()
    End Sub

    ' Fill Delivery address
    Private Sub AddrFill(dtMO As DataTable, dtSO As DataTable)
        For Each drMO As DataRow In dtMO.Rows
            For Each drSO As DataRow In dtSO.Rows
                If drMO("XA003") = drSO("XB003") Then
                    Dim mystr As String = drSO("XB006")
                    Dim dashCount() As String = mystr.Split(New String() {"-"}, StringSplitOptions.RemoveEmptyEntries)
                    If dashCount.Length >= 2 Then
                        drMO("XA011") = dashCount(1)
                        Exit For
                    End If
                End If
            Next drSO
        Next drMO
    End Sub

    Private Sub MoveBL2NewSO(dtBL As DataTable, dtNewSO As DataTable, strCNVNBL As String)
        For Each dr As DataRow In dtBL.Rows
            dtNewSO.Rows.Add(dr.ItemArray)
        Next dr
        Dim strSQL As String = "TRUNCATE TABLE BLCOPXB"
        Using cnvnbl As New SqlConnection(strCNVNBL)
            Dim cmd As New SqlCommand(strSQL, cnvnbl)
            cmd.Connection.Open()
            Try
                cmd.ExecuteNonQuery()
            Catch ex As SqlException
                MsgBox(ex)
            End Try
        End Using
    End Sub

    Private Sub TransData(strcn As String, srcDtMO As DataTable, srcDtSO As DataTable)
        Dim strDtMO As String = srcDtMO.TableName.ToString
        Dim strDtSO As String = srcDtSO.TableName.ToString
        Dim tbclMO As String = Tbcol(Strings.Right(strDtMO, 2))
        Dim tbclSO As String = Tbcol(Strings.Right(strDtSO, 2))
        'Dim rowcnt As Integer = perc
        For Each rowdtMO As DataRow In srcDtMO.Rows
            Dim dataValArr() = rowdtMO.ItemArray
            Dim curOrNO As String = dataValArr(2)
            Dim dataValMO As String = DataArr2DataStr(dataValArr)
            Dim strInsMO As String = String.Format("INSERT INTO dbo.{0} ({1}) VALUES ({2})", strDtMO, tbclMO, dataValMO)
            Using cn As New SqlConnection(strcn)
                cn.Open()
                Using trans As SqlTransaction = cn.BeginTransaction()
                    Using cmdMO As New SqlCommand()
                        With cmdMO
                            .Connection = cn
                            .CommandType = CommandType.Text
                            .CommandText = strInsMO
                        End With
                        Try
                            cmdMO.Transaction = trans
                            cmdMO.ExecuteNonQuery()
                            'rowcnt += 1
                            'BW.ReportProgress(CInt(rowcnt * 100 / perc / 2))
                            Dim selectSO() As DataRow = srcDtSO.Select(String.Format("XB003 = '{0}'", curOrNO))
                            For Each rowdtSO In selectSO
                                Dim dataValSO As String = DataArr2DataStr(rowdtSO.ItemArray)
                                Dim strInsSo As String = String.Format("INSERT INTO dbo.{0} ({1}) VALUES ({2})", strDtSO, tbclSO, dataValSO)
                                Using cmdSO As New SqlCommand()
                                    With cmdSO
                                        .Connection = cn
                                        .CommandType = CommandType.Text
                                        .CommandText = strInsSo
                                    End With
                                    cmdSO.Transaction = trans
                                    cmdSO.ExecuteNonQuery()
                                    'rowcnt += 1
                                    'BW.ReportProgress(CInt(rowcnt * 100 / perc / 2))
                                End Using
                            Next rowdtSO
                            txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Order No. " & dataValArr(2).ToString & " has been imported.", 0})
                            trans.Commit()
                        Catch ex As SqlException
                            trans.Rollback()
                            txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Failed to import Order No. " & dataValArr(2).ToString & ". Error: " & ex.Message.ToString, 3})
                        End Try
                    End Using
                End Using
            End Using
            My.Settings.cfg_spt = dataValArr(1)
        Next rowdtMO
    End Sub

    Private Sub SOTrans(srcDt As DataTable, tarDt As String, strCN As String, sts As String, dtRp As DataTable, Optional addtoDic As Boolean = False)
        Dim strTarTbName As String = tarDt
        Dim strTarTbclName As String = Tbcol(Strings.Right(strTarTbName, 2))
        For Each dr As DataRow In srcDt.Rows
            Dim dataValArr() = dr.ItemArray
            Dim dataVal As String = DataArr2DataStr(dataValArr)
            Dim strIns As String = String.Format("INSERT INTO dbo.{0} ({1}) VALUES ({2})", strTarTbName, strTarTbclName, dataVal)
            Using cn As New SqlConnection(strCN)
                cn.Open()
                Using trans As SqlTransaction = cn.BeginTransaction()
                    Using cmdMO As New SqlCommand()
                        With cmdMO
                            .Connection = cn
                            .CommandType = CommandType.Text
                            .CommandText = strIns
                        End With
                        Try
                            cmdMO.Transaction = trans
                            cmdMO.ExecuteNonQuery()
                            dtRp.Rows.Add(dataValArr)
                            txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Order No. " & dataValArr(2).ToString & " has been " & sts & "ed.", 0})
                            trans.Commit()
                            If addtoDic Then
                                Dim mysettings = My.Settings
                                Dim valXA001 As String = dataValArr(0)
                                Dim valXA002 As String = dataValArr(1)
                                Dim valXA003 As String = dataValArr(2)
                                Dim strAddtoDic As String = String.Format("INSERT INTO dbo.{0} (XA001, XA002, XA003) VALUES ('{1}', '{2}', '{3}')", "MAINSODIC", valXA001, valXA002, valXA003)
                                Dim strNewCN As String = String.Format(mysettings.strCNVN,
                                              mysettings.cfg_tar_hostname,
                                              "SOT",
                                              mysettings.cfg_tar_usrname,
                                              mysettings.cfg_tar_pw)
                                Using newCN As New SqlConnection(strNewCN)
                                    newCN.Open()
                                    Using cmdIns As New SqlCommand()
                                        With cmdIns
                                            .Connection = newCN
                                            .CommandType = CommandType.Text
                                            .CommandText = strAddtoDic
                                        End With
                                        Try
                                            cmdIns.ExecuteNonQuery()
                                        Catch ex As Exception
                                            MsgBox(ex)
                                        End Try
                                    End Using
                                End Using
                            End If
                        Catch ex As SqlException
                            trans.Rollback()
                            txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Failed to " & sts & "Order No. " & dataValArr(2).ToString & ". Error: " & ex.Message.ToString, 3})
                        End Try
                    End Using
                End Using
            End Using
        Next dr
    End Sub

    Private Sub AddcolNameSO(dt As DataTable)
        dt.Clear()
        If dt.Columns.Count < 1 Then
            dt.Columns.Add(New DataColumn("轉入日期", GetType(String)))
            dt.Columns.Add(New DataColumn("序號", GetType(String)))
            dt.Columns.Add(New DataColumn("MT訂單編號", GetType(String)))
            dt.Columns.Add(New DataColumn("修改版次", GetType(String)))
            dt.Columns.Add(New DataColumn("項次", GetType(String)))
            dt.Columns.Add(New DataColumn("品號", GetType(String)))
            dt.Columns.Add(New DataColumn("數量", GetType(String)))
            dt.Columns.Add(New DataColumn("單價", GetType(String)))
            dt.Columns.Add(New DataColumn("預計交期", GetType(String)))
            dt.Columns.Add(New DataColumn("WF單別", GetType(String)))
            dt.Columns.Add(New DataColumn("WF單號", GetType(String)))
            dt.Columns.Add(New DataColumn("WF序號", GetType(String)))
            dt.Columns.Add(New DataColumn("處理方式", GetType(String)))
            dt.Columns.Add(New DataColumn("處理狀態", GetType(String)))
            dt.Columns.Add(New DataColumn("備註", GetType(String)))
        End If
    End Sub

    Private Sub AddcolNameMO(dt As DataTable)
        dt.Clear()
        If dt.Columns.Count < 1 Then
            dt.Columns.Add(New DataColumn("轉入日期", GetType(String)))
            dt.Columns.Add(New DataColumn("序號", GetType(String)))
            dt.Columns.Add(New DataColumn("MT訂單編號", GetType(String)))
            dt.Columns.Add(New DataColumn("修改版次", GetType(String)))
            dt.Columns.Add(New DataColumn("客戶代號", GetType(String)))
            dt.Columns.Add(New DataColumn("訂單日期", GetType(String)))
            dt.Columns.Add(New DataColumn("終端客戶全名", GetType(String)))
            dt.Columns.Add(New DataColumn("幣別", GetType(String)))
            dt.Columns.Add(New DataColumn("重量單位", GetType(String)))
            dt.Columns.Add(New DataColumn("材積單位", GetType(String)))
            dt.Columns.Add(New DataColumn("送貨地址", GetType(String)))
            dt.Columns.Add(New DataColumn("處理方式", GetType(String)))
            dt.Columns.Add(New DataColumn("處理狀態", GetType(String)))
            dt.Columns.Add(New DataColumn("備註", GetType(String)))
            dt.Columns.Add(New DataColumn("程式代號", GetType(String)))
        End If
    End Sub

    Private Sub WriteReport2Excel(_excel As Excel.Application, wBook As Excel.Workbook, wsNumber As Integer, wsName As String, dtTemp As DataTable)
        Dim wSheet As Excel.Worksheet
        wSheet = wBook.Worksheets(wsNumber)
        wSheet.Name = wsName
        wSheet.Activate()
        If dtTemp.Rows.Count > 1 Then
            Dim dt As DataTable = dtTemp
            Dim dc As DataColumn
            Dim dr As DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0
            For Each dc In dt.Columns
                colIndex += 1
                _excel.Cells(1, colIndex) = dc.ColumnName
            Next
            For Each dr In dt.Rows
                rowIndex += 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex += 1
                    _excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
            Next
            wSheet.Columns.AutoFit()
        Else
            Try
                _excel.Cells(1, 1) = "No data..."
            Catch ex As Exception
                MsgBox(ex)
            End Try
        End If
    End Sub

    Private Function Tbcol(ByVal xa As String) As String
        Dim str As String = ""
        For i As Integer = 1 To 14
            str = str + xa + i.ToString("000") + ", "
        Next i
        str = str + xa + "015"
        Return str
    End Function

    Private Function GetAllControls(control As Control) As IEnumerable(Of Control)
        Dim controls = control.Controls.Cast(Of Control)()
        Return controls.SelectMany(Function(ctrl) GetAllControls(ctrl)).Concat(controls)
    End Function

    Private Sub Btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Dim mySettings = My.Settings
        Dim int_day As Integer = 0
        If mySettings.cfg_int_day <> "" Then
            int_day = mySettings.cfg_int_day * 24 * 60 * 60 * 1000
        End If
        Dim int_hrs As Integer = 0
        If mySettings.cfg_int_hrs <> "" Then
            int_hrs = mySettings.cfg_int_hrs * 60 * 60 * 1000
        End If
        Dim int_min As Integer = 0
        If mySettings.cfg_int_min <> "" Then
            int_min = mySettings.cfg_int_min * 60 * 1000
        End If
        Dim job_interval As Integer = int_day + int_hrs + int_min
        EnumControls(Me, False)
        tmr_schedule.Interval = job_interval
        tmr_schedule.Start()
        Tmr_Schedule_Tick(Nothing, Nothing)
        prb_next_trigger.Maximum = job_interval
        tmr_next_trigger.Start()
        Tmr_next_trigger_Tick(Nothing, Nothing)
    End Sub

    Private Sub Btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        tmr_next_trigger.Stop()
        prb_next_trigger.Value = 0
        prb_data_trans.Value = 0
        tmr_schedule.Stop()
        EnumControls(Me, True)
        If BW.IsBusy Then
            If BW.WorkerSupportsCancellation Then
                BW.CancelAsync()
            End If
        End If
    End Sub

    Private Sub Txt_int_day_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_int_day.MaskInputRejected
        MsgBox("Error: " + e.RejectionHint.ToString(), MsgBoxStyle.Critical)
    End Sub

    Private Sub Txt_int_hrs_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_int_hrs.MaskInputRejected
        MsgBox("Error: " + e.RejectionHint.ToString(), MsgBoxStyle.Critical)
    End Sub

    Private Sub Txt_int_min_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_int_min.MaskInputRejected
        MsgBox("Error: " + e.RejectionHint.ToString(), MsgBoxStyle.Critical)
    End Sub

    Private Sub txt_int_day_LostFocus(sender As Object, e As EventArgs) Handles txt_int_day.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_int_day = txt_int_day.Text
        mySettings.Save()
    End Sub

    Private Sub txt_int_hrs_LostFocus(sender As Object, e As EventArgs) Handles txt_int_hrs.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_int_hrs = txt_int_hrs.Text
        mySettings.Save()
    End Sub

    Private Sub txt_int_min_LostFocus(sender As Object, e As EventArgs) Handles txt_int_min.LostFocus
        Dim mySettings = My.Settings
        mySettings.cfg_int_min = txt_int_min.Text
        mySettings.Save()
    End Sub

    Private Sub Tmr_next_trigger_Tick(sender As Object, e As EventArgs) Handles tmr_next_trigger.Tick
        Dim max As Integer = prb_next_trigger.Maximum
        prb_next_trigger.Increment(1000)
        If prb_next_trigger.Value = max Then
            prb_next_trigger.Value = 0
        End If
    End Sub

    Private Sub SetProgressNoAnimation(ByVal value As Integer)
        ' To get around the progressive animation, we need to move the 
        ' progress bar backwards.
        If (value = prb_data_trans.Maximum) Then
            ' Special case as value can't be set greater than Maximum.
            prb_data_trans.Maximum = (value + 1)
            ' Temporarily Increase Maximum
            prb_data_trans.Value = (value + 1)
            ' Move past
            prb_data_trans.Maximum = value
            ' Reset maximum
        Else
            prb_data_trans.Value = (value + 1)
            ' Move past
        End If
        prb_data_trans.Value = value
        ' Move to correct value
    End Sub

    Private Sub BW_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW.ProgressChanged
        'SetProgressNoAnimation(e.ProgressPercentage)
        prb_data_trans.Value = e.ProgressPercentage
        If prb_data_trans.Value = prb_data_trans.Maximum Then
            prb_data_trans.Value = 0
        End If
        prb_data_trans.Update()
    End Sub

    Private Sub BW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW.DoWork
        'perc = 0
        'prb_data_trans.Value = 0
        Dim mysettings = My.Settings
        mysettings.session_number = Date.Now.ToString("yyMMddhhmm")
        mysettings.Save()
        txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Session " & mysettings.session_number & " has started.", 2})

        ' Connection String
        Dim strCNHK As String = String.Format(mysettings.strCNHK,
                                              mysettings.cfg_src_hostname,
                                              mysettings.cfg_src_port,
                                              mysettings.cfg_src_db,
                                              mysettings.cfg_src_usrname,
                                              mysettings.cfg_src_pw)
        Dim strCNHKDEL As String = String.Format(mysettings.strCNHK,
                                              mysettings.cfg_src_hostname,
                                              mysettings.cfg_src_port,
                                              "ntls_sot",
                                              "sa", mysettings.sa_pw)
        Dim strCNVN As String = String.Format(mysettings.strCNVN,
                                              mysettings.cfg_tar_hostname,
                                              mysettings.cfg_tar_db,
                                              mysettings.cfg_tar_usrname,
                                              mysettings.cfg_tar_pw)
        Dim strCNVNBL As String = String.Format(mysettings.strCNVN,
                                              mysettings.cfg_tar_hostname,
                                              "SOT",
                                              mysettings.cfg_tar_usrname,
                                              mysettings.cfg_tar_pw)
        ' Starting point for retrieving data
        Dim spt As String = mysettings.cfg_spt.ToString("yyyy-MM-dd hh:mm:ss.fff")

        ' SQL Command for retrieving data
        Dim strCmdMO As String = String.Format(mysettings.strCmdMO, spt)
        Dim strCmdSO As String = String.Format(mysettings.strCmdSO, spt)
        Dim strCmdSODel As String = String.Format(mysettings.strCmdDelSO, spt)
        Dim strCmdMODel As String = String.Format(mysettings.strCmdDelMO, spt)
        Dim strCmdCUS As String = mysettings.strCmdCUS
        Dim strCmdPRO As String = mysettings.strCmdPRO
        Dim strCmdDIC As String = mysettings.strCmdDIC
        Dim StrCmdBL As String = mysettings.strCmdBL

        ' Target table
        Dim strDtMO As String = "COPXA"
        Dim strDtSO As String = "COPXB"
        Dim strDtCUS As String = "COPMA"
        Dim strDtPRO As String = "COPMG" '-- MG002 (VN) MG003 (HK)
        Dim strDtSODel As String = "SOTTEMPDEL"
        Dim strDtMODel As String = "MAINSOTEMPDEL"
        Dim strDtBL As String = "BLCOPXB"
        Dim strDtDic As String = "MAINSODEL"

        ' Create column name for report
        AddcolNameMO(DtFailedUpdMO)
        AddcolNameMO(dtSuccessMO)
        AddcolNameSO(DtMissOrgMO)
        AddcolNameSO(DtMissProdInfo)
        AddcolNameSO(DtSuccessDelSO)
        AddcolNameSO(DtSuccessUpdSO)
        AddcolNameSO(DtSuccessInsSO)

        ' Get update of COPMA (customer) and COPMG (product)
        Dim cnVN As New SqlConnection(strCNVN)
        cnVN.Open()
        ' Get table COPMA
        Dim dtCUS As New DataTable
        dtCUS = GetData(cnVN, strCmdCUS, strDtCUS)
        BW.ReportProgress(2)

        ' Get table COPMG
        Dim dtPRO As New DataTable
        dtPRO = GetData(cnVN, strCmdPRO, strDtPRO)
        BW.ReportProgress(8)
        cnVN.Close()

        ' Get update of MAINSODIC AND BLCOPXB
        Dim cnVNBL As New SqlConnection(strCNVNBL)
        cnVNBL.Open()
        Dim dtDic As New DataTable
        dtDic = GetData(cnVNBL, strCmdDIC, strDtDic)
        BW.ReportProgress(14)
        Dim dtBL As New DataTable
        dtBL = GetData(cnVNBL, StrCmdBL, strDtBL)
        BW.ReportProgress(16)
        cnVNBL.Close()

        Dim cnHKDel As New SqlConnection(strCNHKDEL)
        cnHKDel.Open()
        ' Get Del MO
        Dim dtMODel As New DataTable
        '=====Delete MO======
        dtMODel = GetData(cnHKDel, strCmdMODel, strDtMODel)
        ' Assign MO Number for Deleted Order
        If dtMODel Is Nothing Then
            txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"No deleted Main Order found.", 0})
        Else
            AssignMONo(dtDic, dtMODel, DtFailedUpdMO)
            ' Tranfer Deleted MO to COPXA for status updating
            SOTrans(dtMODel, strDtMO, strCNVN, "delete", dtSuccessMO)
        End If
        BW.ReportProgress(20)
        ' Get Del SO
        Dim dtSODel As New DataTable
        dtSODel = GetData(cnHKDel, strCmdSODel, strDtSODel)
        '======Delete SO=======
        If dtSODel Is Nothing Then
            txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"No deleted Sub Order found.", 0})
        Else
            AssignMONo(dtDic, dtSODel, DtMissOrgMO)
            ' Tranfer Deleted SO to COPXB for status updating
            SOTrans(dtSODel, strDtSO, strCNVN, "delete", DtSuccessDelSO)
        End If
        BW.ReportProgress(28)
        cnHKDel.Close()
        '======New/Update MO/SO======
        Using cnHK As New SqlConnection(strCNHK)
            Try
                cnHK.Open()
                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {String.Format("Connection to {0} is opened.", mysettings.cfg_src_hostname), 2})
            Catch ex As SqlException
                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {String.Format("Cannot connect to {0}. Error: {1}", mysettings.cfg_src_hostname, ex.Message), 3})
            End Try

            'get MO
            Dim dtMO As New DataTable
            dtMO = GetData(cnHK, strCmdMO, strDtMO)
            BW.ReportProgress(31)

            If dtMO.Rows.Count < 1 Then
                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"No Main Order found.", 0})
            Else
                'get New startpoint for the next schedule
                Try
                    Dim lastDr As DataRow = dtMO.Rows(dtMO.Rows.Count - 1)
                    Dim newspt As Date = lastDr(0)
                    mysettings.cfg_spt = newspt.ToString("yyyy-MM-dd hh:mm:ss.fff")
                    dtMO.Columns.Remove("DATETIME")
                Catch ex As SqlException
                    MsgBox(ex)
                End Try

                'get New MO
                Dim dtNewMO As DataTable = dtMO.Select("XA004 = 1").CopyToDataTable
                If dtNewMO Is Nothing Then
                    txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"No new Main Order found.", 0})
                Else
                    'Generate MO Number
                    IncrementSub(dtNewMO, "XA002", "0000")
                    BW.ReportProgress(38)
                    'Fill Customer Information
                    CusFill(dtCUS, "MA004", dtNewMO, "XA005")
                End If
                BW.ReportProgress(36)

                'get Update MO
                Dim dtUpdateMO As DataTable = dtMO.Select("XA004 > 1").CopyToDataTable
                If dtUpdateMO Is Nothing Then
                    txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"No updated Main Order found.", 0})
                Else
                    'Assign MO Number
                    AssignMONo(dtDic, dtUpdateMO, DtFailedUpdMO)
                    ' Tranfer Deleted MO to COPXA for status updating
                    SOTrans(dtUpdateMO, strDtMO, strCNVN, "update", dtSuccessMO)
                End If
                BW.ReportProgress(50)

                ' get SO
                Dim dtSO As New DataTable
                dtSO = GetData(cnHK, strCmdSO, strDtSO)
                BW.ReportProgress(56)

                If dtSO Is Nothing Then
                    txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"No Sub Order found.", 0})
                Else
                    '=====New SO=======
                    Dim dtNewSO As DataTable = dtSO.Select("XB004 = 1").CopyToDataTable
                    If dtNewSO Is Nothing Then
                        txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"No new Sub Order found.", 0})
                    Else
                        'Assign MO Number
                        AssignMONo(dtNewMO, dtNewSO, DtMissOrgMO)
                        'Add Backlog SO to New SO datatable
                        MoveBL2NewSO(dtBL, dtNewSO, strCNVNBL)
                        'Fill Product Number Information
                        ProdNoFill(dtPRO, dtNewSO, strCNVNBL, strDtBL, DtMissProdInfo)
                        'Fill Address Information
                        AddrFill(dtNewMO, dtNewSO)
                        ' Tranfer Deleted MO to COPXA for status updating
                        SOTrans(dtNewMO, strDtMO, strCNVN, "insert", dtSuccessMO, True)
                        ' Tranfer Deleted MO to COPXB for status updating
                        SOTrans(dtNewSO, strDtSO, strCNVN, "insert", DtSuccessInsSO)
                    End If
                    BW.ReportProgress(80)

                    'get Update SO
                    Dim dtUpdateSO As DataTable = dtSO.Select("XB004 > 1").CopyToDataTable
                    If dtUpdateSO Is Nothing Then
                        txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"No updated Sub Order found.", 0})
                    Else
                        'Assign MO Number
                        AssignMONo(dtDic, dtUpdateSO, DtMissOrgMO)
                        ' Tranfer Deleted MO to COPXA for status updating
                        SOTrans(dtUpdateSO, strDtSO, strCNVN, "update", DtSuccessUpdSO)
                    End If
                    BW.ReportProgress(94)
                End If
                BW.ReportProgress(98)
            End If
            BW.ReportProgress(100)
        End Using
    End Sub

    Private Sub BW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW.RunWorkerCompleted
        Dim mysettings = My.Settings
        Elog("Session " & mysettings.session_number & " completed.", 2)
        'Write session log to .txt file
        Dim sessionLog As String = String.Format("Report\SessionLog_{0}.txt", mysettings.session_number)
        Using logWriter As StreamWriter = New StreamWriter(sessionLog)
            logWriter.Write(txt_elogs.Text)
        End Using

        'Run Excel Application
        Dim xlsApp As New Excel.Application
        xlsApp.SheetsInNewWorkbook = 6
        Dim wBook As Excel.Workbook
        'Creat a workbook
        wBook = xlsApp.Workbooks.Add()
        Elog("Generating session report...", 1)
        ' Write report to excel file
        WriteReport2Excel(xlsApp, wBook, 1, "Failed MO", DtFailedUpdMO)
        WriteReport2Excel(xlsApp, wBook, 2, "Failed SO", DtMissOrgMO)
        WriteReport2Excel(xlsApp, wBook, 3, "Missing Code", DtMissProdInfo)
        WriteReport2Excel(xlsApp, wBook, 4, "Deleted SO", DtSuccessDelSO)
        WriteReport2Excel(xlsApp, wBook, 5, "Updated SO", DtSuccessUpdSO)
        WriteReport2Excel(xlsApp, wBook, 6, "New SO", DtSuccessInsSO)
        wBook.Worksheets("Failed MO").Activate
        'Save the workbook in xlsx format
        Dim detailXls As String = Environment.CurrentDirectory + String.Format("\Report\Detailed Report {0}.xlsx", mysettings.session_number)
        If System.IO.File.Exists(detailXls) Then
            System.IO.File.Delete(detailXls)
        End If
        wBook.SaveAs(detailXls)
        wBook.Close()
        xlsApp.Quit()
        Elog("Session report generated.", 2)
        Dim ttFailedMO As Integer = DtFailedUpdMO.Rows.Count
        Dim ttMissOrgMO As Integer = DtMissOrgMO.Rows.Count
        Dim ttMissPrdInfo As Integer = DtMissProdInfo.Rows.Count
        Dim ttDelSO As Integer = DtSuccessDelSO.Rows.Count
        Dim ttUpdSO As Integer = DtSuccessUpdSO.Rows.Count
        Dim ttNewSO As Integer = DtSuccessInsSO.Rows.Count
        'Send notification
        Dim GGmail As New GMAIL(mysettings.cfg_sender, mysettings.cfg_sender_pw)
        Dim ToAddressies() As String = mysettings.cfg_recipients.Split({vbLf}, StringSplitOptions.RemoveEmptyEntries)
        Dim attachs() As String = {sessionLog, detailXls}
        Dim subject As String = String.Format("SOT Report No. {0}", mysettings.session_number)
        Dim body As String = String.Format(mysettings.notification_email_body, mysettings.session_number, ttFailedMO, ttMissOrgMO, ttMissPrdInfo, ttDelSO, ttUpdSO, ttNewSO)
        Dim result As Boolean = GGmail.SendMail(ToAddressies, subject, body, attachs)
        If result Then
            Elog("Session report has sent.", 2)
        Else
            Elog("Session report failed to sent. Error: " & GGmail.ErrorText, 3)
        End If
    End Sub

    Private Sub SOT_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            'The user has requested the form be closed so mimimise to the system tray instead.
            e.Cancel = True
            Me.Visible = False
            Me.NotifyIcon.Visible = True
        End If
    End Sub

    Private Sub MenuItemShow_Click(sender As Object, e As EventArgs) Handles MenuItemShow.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub MenuItemExit_Click(sender As Object, e As EventArgs) Handles MenuItemExit.Click
        Dim pw As String = Microsoft.VisualBasic.Interaction.InputBox("Once you close the application, sales orders won't be tranformed automatically any more. Please enter your super admin password to terminate the application process!", "Warning", "*******")
        If pw = My.Settings.supw Then
            Application.Exit()
        Else
            MsgBox("Incorrect password!", MsgBoxStyle.Critical)
        End If
    End Sub
End Class

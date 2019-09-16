Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports Excel = Microsoft.Office.Interop.Excel
'Imports System.Configuration
'Imports System.Net.Mail
'Imports System.Runtime.CompilerServices
'Imports System.ComponentModel
Imports Sales_Order_Transformation.ntlsDataSetTableAdapters
Imports Sales_Order_Transformation.ntls_sotDataSetTableAdapters
Imports Sales_Order_Transformation.TECHLINKDataSetTableAdapters
Imports Sales_Order_Transformation.DSCSYSDataSetTableAdapters
Imports Sales_Order_Transformation.SOTDataSetTableAdapters
Public Class SOT
    'Public Shared perc As Integer = 0 '---> 0% for initializing
    ' Report table for MO
    Public Shared DtFailedUpdMO As New DataTable
    Public Shared dtSuccessMO As New DataTable
    Public Shared dtSuccessMOUpdated As New DataTable
    Public Shared DtMissProdInfoMO As New DataTable
    ' Report table for SO
    Public Shared DtMissOrgMO As New DataTable
    Public Shared DtMissProdInfo As New DataTable
    Public Shared DtMissProdInfoSOUpdated As New DataTable
    Public Shared DtSuccessDelSO As New DataTable
    Public Shared DtSuccessUpdSO As New DataTable
    Public Shared DtSuccessInsSO As New DataTable
    Public Shared DtMultiSORNO As New DataTable
    Public Shared startPoint As String
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
        txt_spt.Enabled = False
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
               ctl.Name <> "txt_spt" And
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

    Private Sub txt_spt_LostFocus(sender As Object, e As EventArgs) Handles txt_spt.LostFocus
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
        Dim Result(Arr.Length - 2) As Object
        For i As Integer = 1 To Arr.Length - 1
            Result(i - 1) = Arr(i).ToString.Replace("'", "''")
        Next
        Dim str As String = "'" + String.Join("', '", Result) + "'"
        Return str
    End Function

    ' Create auto increment number to insert into the datatable
    Private Sub IncrementSub(RefDtAdpt As OrdTableAdapter, ByVal dt As DataTable, col As String)
        Dim yymm As String = ""
        Dim ordNo As Integer = 0
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim yymmTemp As String = Trim(dt.Rows(i)(col))
            Dim OrdNoTemp As Integer = 0
            If yymm <> yymmTemp Then
                OrdNoTemp = RefDtAdpt.GetLastOrdNo(yymmTemp).Rows(0)(0)
                If OrdNoTemp = 0 Then
                    OrdNoTemp = Integer.Parse(yymmTemp) * 1000
                End If
                ordNo = OrdNoTemp + 1
            Else
                ordNo += 1
            End If
            dt.Columns(col).MaxLength = 11
            dt.Rows(i)(col) = ordNo
            yymm = yymmTemp
        Next
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
            dtTar.Columns(clTar).MaxLength = 10
            dtTar.Columns("TC014").MaxLength = 16
            dtTar.Columns("TC016").MaxLength = 1
            dtTar.Columns("TC018").MaxLength = 30
            dtTar.Columns("TC019").MaxLength = 1
            dtTar.Columns("TC032").MaxLength = 10
            dtTar.Columns("TC042").MaxLength = 6
            dtTar.Columns("TC053").MaxLength = 80
            dtTar.Columns("TC065").MaxLength = 80
            dtTar.Columns("TC071").MaxLength = 80
            dtTar.Columns("TC078").MaxLength = 3
            If found Then
                dtTar.Rows(i)(clTar) = Strings.Trim(dtScr.Rows(foundPosition)("MA001")) '--> Customer code
                dtTar.Rows(i)("TC014") = Strings.Trim(dtScr.Rows(foundPosition)("MA031"))
                dtTar.Rows(i)("TC016") = Strings.Trim(dtScr.Rows(foundPosition)("MA038"))
                dtTar.Rows(i)("TC018") = Strings.Trim(dtScr.Rows(foundPosition)("MA101"))
                dtTar.Rows(i)("TC019") = Strings.Trim(dtScr.Rows(foundPosition)("MA048"))
                dtTar.Rows(i)("TC032") = Strings.Trim(dtScr.Rows(foundPosition)("MA001"))
                dtTar.Rows(i)("TC042") = Strings.Trim(dtScr.Rows(foundPosition)("MA083"))
                dtTar.Rows(i)("TC053") = Strings.Trim(dtScr.Rows(foundPosition)("MA003")) '--> Customer full name
                dtTar.Rows(i)("TC065") = Strings.Trim(dtScr.Rows(foundPosition)("MA003")) '--> Customer full name
                dtTar.Rows(i)("TC071") = Strings.Trim(dtScr.Rows(foundPosition)("MA110"))
                dtTar.Rows(i)("TC078") = Strings.Trim(dtScr.Rows(foundPosition)("MA118"))
            Else
                dtTar.Rows(i)(clTar) = "DL01"
                dtTar.Rows(i)("TC014") = "得霖科技有限公司"
                dtTar.Rows(i)("TC016") = 3
                dtTar.Rows(i)("TC018") = ""
                dtTar.Rows(i)("TC019") = 1
                dtTar.Rows(i)("TC032") = "DL01"
                dtTar.Rows(i)("TC042") = ""
                dtTar.Rows(i)("TC053") = "得霖科技有限公司" '--> Customer full name
                dtTar.Rows(i)("TC065") = "得霖科技有限公司" '--> Customer full name
                dtTar.Rows(i)("TC071") = "Tech-link silicones Co.,Ltd"
                dtTar.Rows(i)("TC078") = "003"
            End If
        Next i
    End Sub

    ' Get TD001, TD002
    Private Sub AssignMONo(dtMODic As DataTable, dtSO As DataTable, dtRp As DataTable)
        SetColOrder(dtSO)
        Dim DelRows As New List(Of DataRow)
        For Each drSO As DataRow In dtSO.Rows
            Dim found As Boolean = False
            For Each drMO As DataRow In dtMODic.Rows
                If drMO("TC012") = drSO("TD002") Then
                    drSO("TD002") = drMO("TC002")
                    found = True
                    Exit For
                End If
            Next drMO
            If Not found Then
                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"The original Order No. " & drSO(1).ToString & " not found. Please update it mannually.", 1})
                dtRp.Rows.Add(drSO.ItemArray)
                DelRows.Add(drSO)
                'drSO.Delete()
            End If
        Next drSO
        For Each drBL As DataRow In DelRows
            dtSO.Rows.Remove(drBL)
        Next
        dtSO.AcceptChanges()
    End Sub

    ' Fill Product Number
    Private Sub ProdNoFill(dtSO As DataTable, dtRp As DataTable)
        SetColOrder(dtSO)
        SortTable(dtSO, "TD002")
        Dim DelRows As New List(Of DataRow)
        Dim drSO As DataRow
        Dim ProAdpt As New ProductTableAdapter
        Dim BLAdpt As New BLCOPTDTableAdapter
        Dim ExProdAdpt As New EXPRODTableAdapter
        Dim Exlist As DataTable = ExProdAdpt.GetData()
        Dim TempSORNO As String = ""
        Dim TempOrdType As String = ""
        For Each drSO In dtSO.Rows
            Dim Product As New DataTable
            Dim getSuccess As Boolean = False
            Try
                Product = ProAdpt.GetData(drSO("TD004"))
                getSuccess = True
            Catch EX As SqlException
                getSuccess = False
                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Failed to get info of the product number " & drSO("TD004") & EX.ToString, 3})
            End Try
            If getSuccess AndAlso Product.Rows.Count <> 0 Then
                Dim SORNO As String = Trim(drSO("TD002"))
                Dim Note As String = Strings.Left(Strings.LTrim(Product(0)("TD004")), 1)
                If Note = "Y" Then
                    dtSO.Columns("TD020").MaxLength = 255
                    drSO("TD020") = drSO("TD004")
                End If
                dtSO.Columns("TD004").MaxLength = 40
                drSO("TD004") = Product(0)("TD004")
                dtSO.Columns("TD005").MaxLength = 120
                drSO("TD005") = Product(0)("TD005")
                dtSO.Columns("TD010").MaxLength = 6
                drSO("TD010") = Product(0)("TD010")
                drSO("TD011") = UnitPrice(drSO("TD004"))
                drSO("TD012") = drSO("TD011") * drSO("TD008")
                drSO("TD032") = Product(0)("TD032") * drSO("TD008")
                dtSO.Columns("TD036").MaxLength = 6
                drSO("TD036") = Product(0)("TD036")
                dtSO.Columns("TD077").MaxLength = 6
                drSO("TD077") = Product(0)("TD010")
                dtSO.Columns("TD001").MaxLength = 4
                If TempSORNO <> SORNO Then
                    drSO("TD001") = OrdType(drSO("TD004"))
                Else
                    drSO("TD001") = TempOrdType
                End If
                'drSO("TD001") = OrdType(drSO("TD004"))
                dtSO.Columns("TD007").MaxLength = 10
                drSO("TD007") = StorageCode(drSO("TD004"))
                TempSORNO = SORNO
                TempOrdType = drSO("TD001")
            Else
                Dim foundException As Boolean = ExceptionalItem(Trim(drSO("TD004")), Exlist)
                If foundException Then
                    txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"The Order " & drSO("TD002") & "contains the item " & drSO("TD004") & " that is not transformed.", 3})
                    DelRows.Add(drSO)
                Else
                    Dim FLAG As Decimal = drSO("FLAG")
                    Dim TD008 As Decimal = drSO("TD008")
                    Dim TD009 As Decimal = drSO("TD009")
                    Dim TD011 As Decimal = drSO("TD011")
                    Dim TD012 As Decimal = drSO("TD012")
                    Dim TD022 As Decimal = drSO("TD022")
                    Dim TD024 As Decimal = drSO("TD024")
                    Dim TD025 As Decimal = drSO("TD025")
                    Dim TD026 As Decimal = drSO("TD026")
                    Dim TD031 As Decimal = drSO("TD031")
                    Dim TD032 As Decimal = drSO("TD032")
                    Dim TD034 As Decimal = drSO("TD034")
                    Dim TD035 As Decimal = drSO("TD035")
                    Dim TD045 As Decimal = drSO("TD045")
                    Dim TD076 As Decimal = drSO("TD076")
                    Dim TD078 As Decimal = drSO("TD078")
                    Try
                        BLAdpt.InsertQuery(drSO("DATETIME"), FLAG, drSO("CREATOR"), drSO("CREATE_DATE"), drSO("TD001"),
                                           drSO("TD002"), drSO("TD003"), drSO("TD004"), drSO("TD005"), drSO("TD007"), TD008,
                                           TD009, drSO("TD010"), TD011, TD012, drSO("TD013"), drSO("TD016"),
                                           drSO("TD020"), drSO("TD021"), TD022, TD024, TD025, TD026,
                                           TD031, TD032, TD034, TD035, drSO("TD036"), drSO("TD045"),
                                           drSO("TD047"), drSO("TD048"), drSO("TD049"), TD076, drSO("TD077"), TD078)
                        dtRp.Rows.Add(drSO.ItemArray)
                        DelRows.Add(drSO)
                        'dtSO.Rows.Remove(drSO)
                    Catch ex As SqlException
                        MsgBox(ex.ToString)
                        txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Failed to move the product number " & drSO("TD004") & " to the backlog." + ex.ToString, 3})
                    End Try
                    txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"The product number " & drSO("TD004") & " not found. Cannot import Order No. " & drSO("TD002") & "-" & drSO("TD003") & ".", 3})
                End If
            End If
        Next
        For Each drBL As DataRow In DelRows
            dtSO.Rows.Remove(drBL)
        Next
        dtSO.AcceptChanges()
    End Sub

    Private Function ExceptionalItem(ItemName As String, Exlist As DataTable) As Boolean
        Dim result As Boolean = False
        For Each item As DataRow In Exlist.Rows
            If ItemName = Trim(item("PRODCODE")) Then
                result = True
                Exit For
            End If
        Next
        Return result
    End Function

    Private Function UnitPrice(ItemName As String) As Decimal
        Dim UP As Decimal = 0
        Dim UPTable As New DataTable
        Dim UPAdpt As New COPTBTableAdapter
        Try
            UPTable = UPAdpt.GetData(ItemName)
        Catch ex As Exception
            txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"UnitPrice: Failed to get UP of the product number " & ItemName & ex.ToString, 3})
        End Try
        If UPTable.Rows.Count = 1 Then
            UP = UPTable.Rows(0)("TB009")
        End If
        Return UP
    End Function
    Private Sub ProdNoFill2(dtSO As DataTable, dtRp As DataTable)
        SetColOrder(dtSO)
        SortTable(dtSO, "TF002")
        Dim DelRows As New List(Of DataRow)
        Dim drSO As DataRow
        Dim ProAdpt As New ProductTableAdapter
        Dim ExProdAdpt As New EXPRODTableAdapter
        Dim Exlist As New DataTable
        Exlist = ExProdAdpt.GetData()
        Dim TempSORNO As String = ""
        Dim TempOrdType As String = ""
        For Each drSO In dtSO.Rows
            Dim Product As New DataTable
            Try
                Product = ProAdpt.GetData(drSO("TF005"))
            Catch ex As Exception
                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Failed to get info of the product number " & drSO("TF005") & ex.ToString, 3})
            End Try
            Product = ProAdpt.GetData(drSO("TF005"))
            If Product.Rows.Count <> 0 Then
                Dim SORNO As String = Trim(drSO("TF002"))
                dtSO.Columns("TF005").MaxLength = 40
                drSO("TF005") = Product(0)("TD004")
                dtSO.Columns("TF006").MaxLength = 120
                drSO("TF006") = Product(0)("TD005")
                dtSO.Columns("TF010").MaxLength = 6
                drSO("TF010") = Product(0)("TD010")
                drSO("TF013") = UnitPrice(drSO("TF005"))
                drSO("TF014") = drSO("TF013") * drSO("TF009")
                dtSO.Columns("TF075").MaxLength = 6
                drSO("TF075") = Product(0)("TD010")
                drSO("TF026") = Product(0)("TD032") * drSO("TF009")
                dtSO.Columns("TF028").MaxLength = 6
                drSO("TF028") = Product(0)("TD036")
                'dtSO.Columns("TF001").MaxLength = 4
                'If TempSORNO <> SORNO Then
                '    drSO("TF001") = OrdType(drSO("TF005"))
                'Else
                '    drSO("TF001") = TempOrdType
                'End If
                'drSO("TF001") = OrdType(drSO("TF005"))
                dtSO.Columns("TF008").MaxLength = 10
                drSO("TF008") = StorageCode(drSO("TF005"))
                TempSORNO = SORNO
                TempOrdType = drSO("TF001")
            Else
                'in the case edited order contain a new product --> have to process Backlog here
                Dim foundException As Boolean = ExceptionalItem(Trim(drSO("TF005")), Exlist)
                If foundException Then
                    txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Update: The Order " & drSO("TF002") & "contains the item " & drSO("TF005") & " that is not transformed.", 3})
                    DelRows.Add(drSO)
                Else
                    Try
                        dtRp.Rows.Add(drSO.ItemArray)
                        DelRows.Add(drSO)
                        'dtSO.Rows.Remove(drSO)
                    Catch ex As SqlException
                        MsgBox(ex.ToString)
                    End Try
                    txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"The changed order has the product number " & drSO("TF005") & " not found. Cannot import Order No. " & drSO("TF002") & "-" & drSO("TF003") & ".", 3})
                End If
            End If
        Next
        For Each drBL As DataRow In DelRows
            dtSO.Rows.Remove(drBL)
        Next
        dtSO.AcceptChanges()
    End Sub

    ' Fill Delivery address
    Private Sub AddrFill(dtMO As DataTable, dtSO As DataTable, dtRp As DataTable)
        SetColOrder(dtMO)
        dtRp.PrimaryKey = New DataColumn() {dtRp.Columns(5)}
        'Dim DelRows As New List(Of DataRow)
        Dim drMO As DataRow
        dtMO.Columns("TC010").MaxLength = 255
        dtMO.Columns("TC001").MaxLength = 4
        dtMO.Columns("TC005").MaxLength = 10
        For Each drMO In dtMO.Rows
            Dim found As Boolean = False
            For Each drSO As DataRow In dtSO.Rows
                If drMO("TC002") = drSO("TD002") Then
                    found = True
                    Dim mystr As String = drSO("TD004")
                    Dim dashCount() As String = mystr.Split(New String() {"-"}, StringSplitOptions.RemoveEmptyEntries)
                    If dashCount.Length >= 2 Then
                        drMO("TC010") = dashCount(1)
                    End If
                    drMO("TC001") = drSO("TD001")
                    drMO("TC005") = DeptCode(drSO("TD004"))
                    Exit For
                End If
            Next
            If Not found Then
                'Dim FLAG As Decimal = drMO("FLAG")
                'Dim TC009 As Decimal = drMO("TC009")
                'Dim TC026 As Decimal = drMO("TC026")
                'Dim TC028 As Decimal = drMO("TC028")
                'Dim TC029 As Decimal = drMO("TC029")
                'Dim TC030 As Decimal = drMO("TC030")
                'Dim TC031 As Decimal = drMO("TC031")
                'Dim TC041 As Decimal = drMO("TC041")
                'Dim TC043 As Decimal = drMO("TC043")
                'Dim TC044 As Decimal = drMO("TC044")
                'Dim TC045 As Decimal = drMO("TC045")
                'Dim TC046 As Decimal = drMO("TC046")
                'Dim TC052 As Decimal = drMO("TC052")
                'Dim TC072 As Decimal = drMO("TC072")
                'Dim TC073 As Decimal = drMO("TC073")
                'Dim BLAdpt As New BLCOPTCTableAdapter
                Try
                    'BLAdpt.InsertQuery(drMO("DATETIME"), FLAG, drMO("CREATOR"), drMO("CREATE_DATE"), drMO("TC001"), drMO("TC002"), drMO("TC003"), drMO("TC004"),
                    'drMO("TC005"), drMO("TC007"), drMO("TC008"), TC009, drMO("TC010"), drMO("TC012"),
                    'drMO("TC014"), drMO("TC016"), drMO("TC018"), drMO("TC019"), TC026, drMO("TC027"), TC028, TC029, TC030, TC031, drMO("TC032"), drMO("TC039"),
                    'drMO("TC040"), TC041, drMO("TC042"), TC043, TC044, TC045, TC046, drMO("TC048"), drMO("TC050"), TC052, drMO("TC053"), drMO("TC056"),
                    'drMO("TC057"), drMO("TC060"), drMO("TC065"), drMO("TC068"), drMO("TC069"), drMO("TC070"),
                    'drMO("TC071"), TC072, TC073, drMO("TC077"), drMO("TC078"), drMO("TC091"))
                    dtRp.Rows.Add(drMO.ItemArray)
                    'DelRows.Add(drMO)
                Catch ex As Exception
                End Try
            End If
        Next
        'For Each drBL As DataRow In DelRows
        'dtMO.Rows.Remove(drBL)
        'Next
        'dtMO.AcceptChanges()
    End Sub

    ' Sum Qty and Sum weight fill
    Private Sub SumFill(dtMO As DataTable, dtSO As DataTable)
        For Each drMO As DataRow In dtMO.Rows
            For Each drSO As DataRow In dtSO.Rows
                If drMO("TC002") = drSO("TD002") Then
                    drMO("TC031") = drMO("TC031") + drSO("TD008")
                    drMO("TC046") = drMO("TC046") + +drSO("TD032")
                End If
            Next
        Next
    End Sub
    Private Sub ExchangeFill(RefDT As CurrencyTableAdapter, dtMO As DataTable)
        For Each dr As DataRow In dtMO.Rows
            Dim currencyCode As String = dr("TC008")
            dtMO.Columns("TC009").MaxLength = 20
            If currencyCode = "VND" Then
                dr("TC009") = 1
            Else
                Try
                    dr("TC009") = RefDT.GetLatestExRate(currencyCode).Rows(0)(0)
                Catch ex As Exception
                    txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Failed to get Exchange Rate of the Currency " & currencyCode & ". Error: " & ex.Message.ToString, 3})
                End Try
            End If
        Next
    End Sub
    Private Sub ExchangeFill2(RefDT As CurrencyTableAdapter, dtMO As DataTable)
        For Each dr As DataRow In dtMO.Rows
            Dim currencyCode As String = dr("TE011")
            dtMO.Columns("TE012").MaxLength = 20
            If currencyCode = "VND" Then
                dr("TE012") = 1
            Else
                Try
                    dr("TE012") = RefDT.GetLatestExRate(currencyCode).Rows(0)(0)
                Catch ex As Exception
                    txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Failed to get Exchange Rate of the Currency " & currencyCode & ". Error: " & ex.Message.ToString, 3})
                End Try
            End If
        Next
    End Sub
    Private Sub MoveBL2NewSO(dtNewSO As DataTable, strCNVNBL As String)
        SetColOrder(dtNewSO)
        Dim BLAdpt As New BLCOPTDTableAdapter
        Dim dtBL As DataTable = BLAdpt.GetData
        SetColOrder(dtBL)
        For Each dr As DataRow In dtBL.Rows
            'dr("TD001") = ""
            dtNewSO.Rows.Add(dr.ItemArray)
        Next
        Dim strSQL As String = "TRUNCATE TABLE BLCOPTD"
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

    Private Sub MoveBL2NewMO(dtNewMO As DataTable, strCNVNBL As String)
        SetColOrder(dtNewMO)
        Dim BLAdpt As New BLCOPTCTableAdapter
        Dim dtBL As DataTable = BLAdpt.GetData
        SetColOrder(dtBL)
        For Each dr As DataRow In dtBL.Rows
            'dr("TC001") = ""
            dtNewMO.Rows.Add(dr.ItemArray)
        Next
        Dim strSQL As String = "TRUNCATE TABLE BLCOPTD"
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

    Private Sub MoveFailedLookUp2NewMO(dtNewMO As DataTable, FailedList As List(Of String))
        SetColOrder(dtNewMO)
        Dim MOAdpt As New MAINSO1TableAdapter
        For Each SORNO As String In FailedList
            Dim dt As DataTable = MOAdpt.GetDataBySORNO(SORNO)
            SetColOrder(dt)
            dtNewMO.Rows.Add(dt.Rows(0).ItemArray)
        Next
    End Sub
    Private Sub MoveFailedLookUp2NewSO(dtNewSO As DataTable, FailedList As DataTable)
        SetColOrder(dtNewSO)
        Dim SOAdpt As New SOTTableAdapter
        For Each dr As DataRow In FailedList.Rows
            Dim dt As DataTable = SOAdpt.GetDataBySORNO_ITEMNO(dr("TF002"), dr("TF004"))
            SetColOrder(dt)
            dtNewSO.Rows.Add(dt.Rows(0).ItemArray)
        Next
    End Sub
    Private Sub SetColOrder(dt As DataTable)
        Dim MaxCol As Integer = dt.Columns.Count
        For i As Integer = 0 To MaxCol - 1
            Dim col As DataColumn = dt.Columns(i)
            Dim ColName As String = col.ColumnName
            If ColName = "DATETIME" Then
                col.SetOrdinal(0)
            ElseIf ColName = "FLAG" Then
                col.SetOrdinal(1)
            ElseIf ColName = "CREATOR" Then
                col.SetOrdinal(2)
            ElseIf ColName = "CREATE_DATE" Then
                col.SetOrdinal(3)
            End If
        Next
        For i As Integer = 5 To MaxCol - 1
            Dim col As DataColumn = dt.Columns(i)
            Dim ColName As String = col.ColumnName
            Dim CurID As Integer = Integer.Parse(Strings.Right(ColName, 3))
            Dim j As Integer = i - 1
            While j >= 4 AndAlso Integer.Parse(Strings.Right(dt.Columns(j).ColumnName, 3)) > CurID
                dt.Columns(j).SetOrdinal(j + 1)
                j -= 1
            End While
        Next
    End Sub

    Private Sub SortTable(ByRef mytable As DataTable, ByVal column As String)
        'create a blank table. tablecopy is the name
        Dim tablecopy As New DataTable
        'make an exact copy of the table you passed in by reference, and
        'store it in your tablecopy table
        tablecopy = mytable.Copy()
        'clear the contents of the table you just passed in, because
        'you will soon fill it with newly sorted rows
        mytable.Clear()
        'create a rows array
        Dim foundRows() As DataRow
        foundRows = tablecopy.Select("", column + " ASC")
        'iterate through each row and import them into
        'the table that you passed in by reference
        Dim dbrow As DataRow
        For Each dbrow In foundRows
            mytable.ImportRow(dbrow)
        Next
        'finally clear the contents of the tablecopy you created.
        tablecopy.Clear()
    End Sub
    Private Sub SOTrans(srcDt As DataTable, tarDt As String, strCN As String, sts As String, dtRp As DataTable, Optional isMO As Boolean = False)
        SetColOrder(srcDt)
        Dim strTarTbName As String = tarDt
        Dim strTarTbclName As String = Tbcol(srcDt)
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
                            If isMO Then
                                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Order No. " & dataValArr(13).ToString & " has been " & sts & "d.", 0})
                            Else
                                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Order No. " & dataValArr(5).ToString & " has been " & sts & "d.", 0})
                            End If
                            trans.Commit()
                        Catch ex As SqlException
                            trans.Rollback()
                            If isMO Then
                                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Failed to " & sts & " Order No. " & dataValArr(13).ToString & ". Error: " & ex.Message.ToString, 3})
                            Else
                                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Failed to " & sts & " Order No. " & dataValArr(5).ToString & ". Error: " & ex.Message.ToString, 3})
                            End If
                        End Try
                    End Using
                End Using
            End Using
        Next
    End Sub

    Private Sub AddcolNameSO(dt As DataTable)
        dt.Clear()
        If dt.Columns.Count < 1 Then
            Dim RefAdpt As New SOTTableAdapter
            Dim RefTable As DataTable = RefAdpt.GetData(Date.Now)
            SetColOrder(RefTable)
            Dim ColAdpt As New ColTableAdapter
            Dim ColTable As DataTable = ColAdpt.GetDataByTableCode("COPTD")
            dt.Columns.Add(New DataColumn("DATETIME", GetType(String)))
            dt.Columns.Add(New DataColumn("FLAG", GetType(String)))
            dt.Columns.Add(New DataColumn("CREATOR", GetType(String)))
            dt.Columns.Add(New DataColumn("CREATE_DATE", GetType(String)))
            For Each dc As DataColumn In RefTable.Columns
                For Each dr As DataRow In ColTable.Rows
                    If dc.ColumnName = dr("Column Code") Then
                        Try
                            dt.Columns.Add(New DataColumn(dr("Column Name").ToString, GetType(String)))
                        Catch ex As Exception
                            dt.Columns.Add(New DataColumn(dr("Column Name").ToString + "0", GetType(String)))
                        End Try
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub AddcolNameMO(dt As DataTable)
        dt.Clear()
        If dt.Columns.Count < 1 Then
            Dim RefAdpt As New MAINSOTableAdapter
            Dim RefTable As DataTable = RefAdpt.GetData(Date.Now)
            RemoveREMARKSCol(RefTable)
            SetColOrder(RefTable)
            Dim ColAdpt As New ColTableAdapter
            Dim ColTable As DataTable = ColAdpt.GetDataByTableCode("COPTC")
            dt.Columns.Add(New DataColumn("DATETIME", GetType(String)))
            dt.Columns.Add(New DataColumn("FLAG", GetType(String)))
            dt.Columns.Add(New DataColumn("CREATOR", GetType(String)))
            dt.Columns.Add(New DataColumn("CREATE_DATE", GetType(String)))
            For Each dc As DataColumn In RefTable.Columns
                For Each dr As DataRow In ColTable.Rows
                    If dc.ColumnName = dr("Column Code") Then
                        Try
                            dt.Columns.Add(New DataColumn(dr("Column Name").ToString, GetType(String)))
                        Catch ex As Exception
                            dt.Columns.Add(New DataColumn(dr("Column Name").ToString + "0", GetType(String)))
                        End Try
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub RemoveREMARKSCol(dt As DataTable)
        If dt.Columns.Contains("REMARKS") Then
            dt.Columns.Remove("REMARKS")
        End If
    End Sub
    Private Sub AddcolNameCOPTE(dt As DataTable)
        dt.Clear()
        If dt.Columns.Count < 1 Then
            Dim RefAdpt As New COPTETableAdapter
            Dim RefTable As DataTable = RefAdpt.GetData(Date.Now)
            RemoveREMARKSCol(RefTable)
            SetColOrder(RefTable)
            Dim ColAdpt As New ColTableAdapter
            Dim ColTable As DataTable = ColAdpt.GetDataByTableCode("COPTE")
            dt.Columns.Add(New DataColumn("DATETIME", GetType(String)))
            dt.Columns.Add(New DataColumn("FLAG", GetType(String)))
            dt.Columns.Add(New DataColumn("CREATOR", GetType(String)))
            dt.Columns.Add(New DataColumn("CREATE_DATE", GetType(String)))
            For Each dc As DataColumn In RefTable.Columns
                For Each dr As DataRow In ColTable.Rows
                    If dc.ColumnName = dr("Column Code") Then
                        Try
                            dt.Columns.Add(New DataColumn(dr("Column Name").ToString, GetType(String)))
                        Catch ex As Exception
                            dt.Columns.Add(New DataColumn(dr("Column Name").ToString + "0", GetType(String)))
                        End Try
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub AddcolNameCOPTF(dt As DataTable)
        dt.Clear()
        If dt.Columns.Count < 1 Then
            Dim RefAdpt As New COPTFTableAdapter
            Dim RefTable As DataTable = RefAdpt.GetData(Date.Now)
            SetColOrder(RefTable)
            Dim ColAdpt As New ColTableAdapter
            Dim ColTable As DataTable = ColAdpt.GetDataByTableCode("COPTF")
            dt.Columns.Add(New DataColumn("DATETIME", GetType(String)))
            dt.Columns.Add(New DataColumn("FLAG", GetType(String)))
            dt.Columns.Add(New DataColumn("CREATOR", GetType(String)))
            dt.Columns.Add(New DataColumn("CREATE_DATE", GetType(String)))
            For Each dc As DataColumn In RefTable.Columns
                For Each dr As DataRow In ColTable.Rows
                    If dc.ColumnName = dr("Column Code") Then
                        Try
                            dt.Columns.Add(New DataColumn(dr("Column Name").ToString, GetType(String)))
                        Catch ex As Exception
                            dt.Columns.Add(New DataColumn(dr("Column Name").ToString + "0", GetType(String)))
                        End Try
                    End If
                Next
            Next
        End If
    End Sub
    Private Sub AddcolNameMultiOR(dt As DataTable)
        dt.Clear()
        If dt.Columns.Count < 1 Then
            Dim RefAdpt As New COPTC1TableAdapter
            Dim RefTable As DataTable = RefAdpt.GetDataBySORNO("DUMMY")
            SetColOrder(RefTable)
            Dim ColAdpt As New ColTableAdapter
            Dim ColTable As DataTable = ColAdpt.GetDataByTableCode("COPTC")
            dt.Columns.Add(New DataColumn("DATETIME", GetType(String)))
            dt.Columns.Add(New DataColumn("FLAG", GetType(String)))
            dt.Columns.Add(New DataColumn("CREATOR", GetType(String)))
            dt.Columns.Add(New DataColumn("CREATE_DATE", GetType(String)))
            For Each dc As DataColumn In RefTable.Columns
                For Each dr As DataRow In ColTable.Rows
                    If dc.ColumnName = dr("Column Code") Then
                        Try
                            dt.Columns.Add(New DataColumn(dr("Column Name").ToString, GetType(String)))
                        Catch ex As Exception
                            dt.Columns.Add(New DataColumn(dr("Column Name").ToString + "0", GetType(String)))
                        End Try
                    End If
                Next
            Next
        End If
    End Sub
    Private Sub AddcolNameMultiOR1(dt As DataTable)
        dt.Clear()
        If dt.Columns.Count < 1 Then
            Dim RefAdpt As New COPTFTableAdapter
            Dim RefTable As DataTable = RefAdpt.GetData(Date.Now)
            SetColOrder(RefTable)
            Dim ColAdpt As New ColTableAdapter
            Dim ColTable As DataTable = ColAdpt.GetDataByTableCode("COPTF")
            dt.Columns.Add(New DataColumn("DATETIME", GetType(String)))
            dt.Columns.Add(New DataColumn("FLAG", GetType(String)))
            dt.Columns.Add(New DataColumn("CREATOR", GetType(String)))
            dt.Columns.Add(New DataColumn("CREATE_DATE", GetType(String)))
            For Each dc As DataColumn In RefTable.Columns
                For Each dr As DataRow In ColTable.Rows
                    If dc.ColumnName = dr("Column Code") Then
                        dt.Columns.Add(New DataColumn(dr("Column Code").ToString, GetType(String)))
                    End If
                Next
            Next
        End If
    End Sub
    Private Function OrdType(TC004 As String) As String
        'Dim result As String = ""
        Dim T1 As String = Strings.Left(TC004, 1)
        Dim T2 As String = Strings.Left(TC004, 2)
        Dim T3 As String = Strings.Left(TC004, 3)
        Dim T4 As String = Strings.Left(TC004, 4)
        Select Case T4
            Case "BWTX"
                'Return "B221"
                Return "B224"
        End Select
        Select Case T3
            Case "BMH"
                'Return "B221"
                Return "B224"
            Case "BVR", "BFF"
                'Return "B222"
                Return "B225"
            Case "JMH"
                'Return "J221"
                Return "J222"
            Case "AYM", "CYM", "BRJ", "PTL"
                'Return "Y221"
                Return "Y222"
        End Select
        Select Case T2
            Case "BY", "PE", "AI", "CI", "AM"
                'Return "Y221"
                Return "Y222"
            Case "JC"
                'Return "P221"
                Return "P222"
        End Select
        Select Case T1
            Case "A", "E"
                'Return "A221"
                Return "A222"
            Case "C"
                'Return "C221"
                Return "C222"
            Case "P"
                'Return "P221"
                Return "P222"
            Case "Y"
                'Return "Y221"
                Return "Y222"
        End Select
        Return ""
    End Function
    Private Function DeptCode(TC004 As String) As String
        'Dim result As String = ""
        Dim T1 As String = Strings.Left(TC004, 1)
        Dim T2 As String = Strings.Left(TC004, 2)
        Dim T3 As String = Strings.Left(TC004, 3)
        Dim T4 As String = Strings.Left(TC004, 4)
        Select Case T4
            Case "BWTX"
                Return "B01-1"
        End Select
        Select Case T3
            Case "BMH"
                Return "B01-1"
            Case "BVR", "BFF"
                Return "B01-2"
            Case "JMH"
                Return "J01-1"
            Case "AYM", "CYM", "BRJ", "PTL"
                Return "Y01"
        End Select
        Select Case T2
            Case "BY", "PE", "AI", "CI", "AM"
                Return "Y01"
            Case "JC"
                Return "J01-2"
        End Select
        Select Case T1
            Case "A", "C", "E"
                Return "A01"
            Case "P"
                Return "J01-2"
            Case "Y"
                Return "Y01"
        End Select
        Return ""
    End Function
    Private Function StorageCode(TC004 As String) As String
        'Dim result As String = ""
        Dim T1 As String = Strings.Left(TC004, 1)
        Dim T2 As String = Strings.Left(TC004, 2)
        Dim T3 As String = Strings.Left(TC004, 3)
        Dim T4 As String = Strings.Left(TC004, 4)
        Select Case T4
            Case "BWTX"
                Return "B02"
        End Select
        Select Case T3
            Case "BMH"
                Return "B02"
            Case "BVR", "BFF"
                Return "B03"
            Case "JMH"
                Return "B02"
            Case "AYM", "CYM", "BRJ", "PTL"
                Return "Y04"
        End Select
        Select Case T2
            Case "BY", "PE", "AI", "CI", "AM"
                Return "Y04"
            Case "JC"
                Return "P04"
        End Select
        Select Case T1
            Case "A", "C", "E"
                Return "A04"
            Case "P"
                Return "P04"
            Case "Y"
                Return "Y04"
        End Select
        Return ""
    End Function

    Private Sub GetBLMO(dtNewBLSO As DataTable, dtNewBLMO As DataTable)
        Dim BLAdpt As New COPTC2TableAdapter
        For Each row As DataRow In dtNewBLSO.Rows
            Dim TC002 As String = row("TD002").ToString
            Dim BLMORow As DataRow
            Try
                BLMORow = BLAdpt.GetDataByTC002(TC002)(0)
                If BLMORow IsNot Nothing AndAlso Trim(BLMORow("TC001")) = "" Then
                    dtNewBLMO.Rows.Add(BLMORow.ItemArray)
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub MergeBLSO2NewSO(dtNewBLSO As DataTable, dtNewSO As DataTable)
        For Each dr As DataRow In dtNewBLSO.Rows
            dtNewSO.Rows.Add(dr.ItemArray)
        Next
    End Sub

    Private Sub SOUpdate(dtNewBLMO As DataTable)
        Dim BLAdpt As New COPTC2TableAdapter
        For Each dr As DataRow In dtNewBLMO.Rows
            Dim TC031 As Decimal = dr("TC031")
            Dim TC046 As Decimal = dr("TC046")
            Try
                BLAdpt.UpdateQuery(dr("TC001"), dr("TC005"), dr("TC010"), TC031, TC046, dr("TC002"))
            Catch ex As SqlException
                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"SOUpdate Failed. MO Number: " & dr("TC002") & ex.ToString, 3})
            End Try
        Next
    End Sub
    Private Sub OrderLookup(dtSO As DataTable, dtRp As List(Of String))
        SetColOrder(dtSO)
        Dim DelRows As New List(Of DataRow)
        Dim drSO As DataRow
        Dim COPTCAdpt As New COPTC1TableAdapter
        dtSO.Columns("TE001").MaxLength = 4
        dtSO.Columns("TE002").MaxLength = 11
        dtSO.Columns("TE007").MaxLength = 10
        dtSO.Columns("TE008").MaxLength = 10
        dtSO.Columns("TE010").MaxLength = 6
        dtSO.Columns("TE013").MaxLength = 255
        dtSO.Columns("TE055").MaxLength = 80
        dtSO.Columns("TE058").MaxLength = 80
        dtSO.Columns("TE062").MaxLength = 80
        dtSO.Columns("TE107").MaxLength = 10
        dtSO.Columns("TE108").MaxLength = 10
        dtSO.Columns("TE110").MaxLength = 6
        dtSO.Columns("TE111").MaxLength = 4
        dtSO.Columns("TE112").MaxLength = 20
        dtSO.Columns("TE113").MaxLength = 255
        dtSO.Columns("TE115").MaxLength = 20
        dtSO.Columns("TE117").MaxLength = 16
        dtSO.Columns("TE129").MaxLength = 10
        dtSO.Columns("TE137").MaxLength = 6
        dtSO.Columns("TE145").MaxLength = 80
        dtSO.Columns("TE148").MaxLength = 80
        dtSO.Columns("TE152").MaxLength = 80
        dtSO.Columns("TE017").MaxLength = 16
        dtSO.Columns("TE031").MaxLength = 10
        dtSO.Columns("TE103").MaxLength = 4
        dtSO.Columns("TE169").MaxLength = 3

        For Each drSO In dtSO.Rows
            Dim Order As DataTable = COPTCAdpt.GetDataBySORNO(drSO("TE015"))
            If Order.Rows.Count <> 0 Then
                drSO("TE001") = Order(0)("TC001")
                drSO("TE002") = Order(0)("TC002")
                drSO("TE007") = Order(0)("TC004")
                drSO("TE008") = Order(0)("TC005")
                drSO("TE010") = Order(0)("TC007")
                drSO("TE013") = Order(0)("TC010")
                drSO("TE055") = Order(0)("TC053")
                drSO("TE058") = Order(0)("TC065")
                drSO("TE062") = Order(0)("TC071")
                drSO("TE107") = Order(0)("TC004")
                drSO("TE108") = Order(0)("TC005")
                drSO("TE110") = Order(0)("TC007")
                drSO("TE111") = Order(0)("TC008")
                drSO("TE112") = Order(0)("TC009")
                drSO("TE113") = Order(0)("TC010")
                drSO("TE115") = Order(0)("TC012")
                drSO("TE117") = Order(0)("TC014")
                drSO("TE129") = Order(0)("TC032")
                drSO("TE137") = Order(0)("TC042")
                drSO("TE145") = Order(0)("TC053")
                drSO("TE148") = Order(0)("TC065")
                drSO("TE152") = Order(0)("TC071")
                drSO("TE017") = Order(0)("TC014")
                drSO("TE021") = Order(0)("TC019")
                drSO("TE031") = Order(0)("TC004")
                drSO("TE069") = Order(0)("TC078")
                drSO("TE103") = Order(0)("TC069")
                drSO("TE169") = Order(0)("TC078")
            Else
                Try
                    dtRp.Add(drSO("TE015"))
                    DelRows.Add(drSO)
                    'dtSO.Rows.Remove(drSO)
                Catch ex As SqlException
                    MsgBox(ex.ToString)
                End Try
                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"The Sale Order number " & drSO("TE015") & " not found.", 3})
            End If
        Next
        For Each drBL As DataRow In DelRows
            dtSO.Rows.Remove(drBL)
        Next
        dtSO.AcceptChanges()
    End Sub

    Private Sub SubOrderLookup(dtSO As DataTable, dtRp As DataTable, DtMultiSO As DataTable)
        SetColOrder(dtSO)
        DtMultiSO.PrimaryKey = New DataColumn() {DtMultiSO.Columns(1), DtMultiSO.Columns(2)}
        Dim DelRows As New List(Of DataRow)
        Dim drSO As DataRow
        Dim COPTCAdpt As New COPTC1TableAdapter
        Dim COPTDAdpt As New COPTDTableAdapter
        'dtSO.Columns("TF002").MaxLength = 40
        For Each drSO In dtSO.Rows
            Dim Order As DataTable = COPTCAdpt.GetDataBySORNO(drSO("TF002"))
            If Order.Rows.Count = 1 Then
                drSO("TF001") = Order(0)("TC001")
                drSO("TF002") = Order(0)("TC002")
                Dim SubOrder As DataTable = COPTDAdpt.GetDataByTD123(drSO("TF001"), drSO("TF002"), drSO("TF004"))
                If SubOrder.Rows.Count < 1 Then
                    drSO("TF065") = 3
                Else
                    drSO("TF123") = SubOrder(0)("TD009")
                    drSO("TF130") = SubOrder(0)("TD033")
                End If
            ElseIf Order.Rows.Count < 1 Then
                Try
                    dtRp.Rows.Add(drSO.ItemArray)
                    DelRows.Add(drSO)
                    'dtSO.Rows.Remove(drSO)
                Catch ex As SqlException
                    MsgBox(ex.ToString)
                End Try
                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"The Sale Order number " & drSO("TF002") & " not found.", 3})
            Else
                SetColOrder(Order)
                For Each dr As DataRow In Order.Rows
                    Try
                        DtMultiSO.Rows.Add(dr.ItemArray)
                    Catch ex As Exception
                    End Try
                Next
                DelRows.Add(drSO)
                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Order number " & drSO("TF002") & " has more than one ERP Order No. System cannot decide!", 3})
            End If
        Next
        For Each drBL As DataRow In DelRows
            dtSO.Rows.Remove(drBL)
        Next
        dtSO.AcceptChanges()
    End Sub
    Private Sub WriteReport2Excel(_excel As Excel.Application, wBook As Excel.Workbook, wsNumber As Integer, wsName As String, dtTemp As DataTable)
        Dim wSheet As Excel.Worksheet
        wSheet = wBook.Worksheets(wsNumber)
        wSheet.Name = wsName
        wSheet.Activate()
        If dtTemp.Rows.Count >= 1 Then
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

    Private Function Tbcol(ByVal dt As DataTable) As String
        Dim str As String = ""
        For i As Integer = 0 To dt.Columns.Count - 1
            Dim colName As String = dt.Columns(i).ColumnName.ToString
            If colName <> "DATETIME" Then
                str = str + dt.Columns(i).ColumnName.ToString + ", "
            End If
        Next
        str = str.Remove(str.LastIndexOf(","))
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
        txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"Start point: " & mysettings.cfg_spt, 2})
        ' Connection String
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
        Dim spt As String = mysettings.cfg_spt '.ToString("yyyy-MM-dd hh:mm:ss.fff")

        ' SQL Command for retrieving data
        Dim strCmdDIC As String = mysettings.strCmdDIC
        Dim StrCmdBL As String = mysettings.strCmdBL

        ' Target table
        Dim strDtMO As String = "COPTC"
        Dim strDtMOEdited As String = "COPTE"
        Dim strDtSO As String = "COPTD"
        Dim strDtSOEdited As String = "COPTF"
        Dim strDtCUS As String = "COPMA"
        Dim strDtPRO As String = "COPMG" '-- MG002 (VN) MG003 (HK)
        Dim strDtSODel As String = "SOTTEMPDEL"
        Dim strDtMODel As String = "MAINSOTEMPDEL"
        Dim strDtBL As String = "BLCOPTD"
        Dim strDtDic As String = "MAINSODEL"
        Dim FailMOLookUp As New List(Of String)
        Dim FailSOLookUp As New DataTable
        ' Create column name for report
        AddcolNameMO(DtFailedUpdMO)
        AddcolNameMO(dtSuccessMO)
        AddcolNameCOPTE(dtSuccessMOUpdated)
        AddcolNameMO(DtMissProdInfoMO)
        AddcolNameSO(DtMissOrgMO)
        AddcolNameSO(DtMissProdInfo)
        AddcolNameSO(DtSuccessDelSO)
        AddcolNameCOPTF(DtSuccessUpdSO)
        AddcolNameSO(DtSuccessInsSO)
        AddcolNameCOPTF(DtMissProdInfoSOUpdated)
        AddcolNameMultiOR(DtMultiSORNO)
        AddcolNameMultiOR1(FailSOLookUp)
        ' Get update of COPMA (customer) and COPMG (product)
        ' Get table CUS
        Dim CusAdpt As New CusTableAdapter
        Dim dtCUS As DataTable = CusAdpt.GetData()
        BW.ReportProgress(2)

        ' Get table COPMG
        'Dim ProAdpt As New ProdTableAdapter
        'Dim dtPRO As DataTable = ProAdpt.GetData()
        BW.ReportProgress(8)

        ' Get update of MAINSODIC AND BLCOPXB
        Dim cnVNBL As New SqlConnection(strCNVNBL)
        cnVNBL.Open()
        'Dim dtDic As New DataTable
        'dtDic = GetData(cnVNBL, strCmdDIC, strDtDic)
        BW.ReportProgress(14)
        'Dim dtBL As New DataTable
        'dtBL = GetData(cnVNBL, StrCmdBL, strDtBL)
        BW.ReportProgress(16)
        cnVNBL.Close()

        'Del MO process here

        '======New/Update MO/SO======
        Try
            txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {String.Format("Connection to {0} is opened.", mysettings.cfg_src_hostname), 2})
        Catch ex As SqlException
            txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {String.Format("Cannot connect to {0}. Error: {1}", mysettings.cfg_src_hostname, ex.Message), 3})
        End Try

        'get MO
        Dim MOAdpt As New MAINSOTableAdapter
        Dim dtMO As DataTable = MOAdpt.GetData(spt)
        Dim RMAdpt As New REMARKSTableAdapter
        Dim dtRM As DataTable = RMAdpt.GetData()
        Dim dtUpdateMO As New DataTable
        Dim dtUpdateMOforFilterSO As New DataTable
        FilterRemarks(dtMO, dtRM)
        BW.ReportProgress(31)

        If dtMO.Rows.Count < 1 Then
            txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"No Main Order found.", 0})
        Else
            'get New startpoint for the next schedule
            Try
                SetColOrder(dtMO)
                Dim lastDr As DataRow = dtMO.Rows(dtMO.Rows.Count - 1)
                Dim newspt As Date = lastDr(0)
                startPoint = mysettings.cfg_spt
                mysettings.cfg_spt = newspt.ToString("yyyy-MM-dd HH:mm:ss.fff")
                mysettings.Save()
                'dtMO.Columns.Remove("DATETIME")
            Catch ex As SqlException
                MsgBox(ex)
            End Try
            'get New MO
            Dim dtNewMO As DataTable = MOAdpt.GetDataByNew(spt)
            FilterRemarks(dtNewMO, dtRM)
            If dtNewMO Is Nothing Then
                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"No new Main Order found.", 0})
            Else
                'get Update MO
                Dim MOEAdpt As New COPTETableAdapter
                dtUpdateMO = MOEAdpt.GetData(spt)
                FilterRemarks(dtUpdateMO, dtRM)
                dtUpdateMOforFilterSO = dtUpdateMO.Copy
                If dtUpdateMO Is Nothing Then
                    txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"No updated Main Order found.", 0})
                Else
                    'Exchange Rate Fill
                    ExchangeFill2(New CurrencyTableAdapter, dtUpdateMO)
                    'Lookup SORNO and fill relevant info
                    OrderLookup(dtUpdateMO, FailMOLookUp)
                    'Tranfer Deleted MO to COPXA for status updating
                    SOTrans(dtUpdateMO, strDtMOEdited, strCNVN, "update", dtSuccessMOUpdated)
                End If
                BW.ReportProgress(36)

                'Add Failed LookUp MO to New MO
                MoveFailedLookUp2NewMO(dtNewMO, FailMOLookUp)
                SortTable(dtNewMO, "TC002")
                'Generate MO Number
                IncrementSub(New OrdTableAdapter, dtNewMO, "TC002")
                BW.ReportProgress(38)
                'Fill Customer Information
                CusFill(dtCUS, "MA004", dtNewMO, "TC004")
                'Fill Latest Exchange Rate
                ExchangeFill(New CurrencyTableAdapter, dtNewMO)
            End If
            BW.ReportProgress(50)

            ' get SO
            Dim SOAdpt As New SOTTableAdapter
            Dim dtSO As DataTable = SOAdpt.GetData(spt)
            FilterSO(dtSO, "TD002", dtMO, "TC012")
            BW.ReportProgress(56)

            If dtSO Is Nothing Then
                txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"No Sub Order found.", 0})
            Else
                '=====New SO=======
                Dim dtNewSO As DataTable = SOAdpt.GetDataByNew(spt)
                FilterSO(dtNewSO, "TD002", dtNewMO, "TC012")
                If dtNewSO Is Nothing Then
                    txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"No new Sub Order found.", 0})
                Else
                    'get Update SO
                    Dim SOEAdpt As New COPTFTableAdapter
                    Dim dtUpdateSO As DataTable = SOEAdpt.GetData(spt)
                    FilterSO(dtUpdateSO, "TF002", dtUpdateMOforFilterSO, "TE015")
                    If dtUpdateSO Is Nothing Then
                        txt_elogs.Invoke(New LogMessageDelegate(AddressOf Elog), New Object() {"No updated Sub Order found.", 0})
                    Else
                        'Assign MO Number
                        SubOrderLookup(dtUpdateSO, FailSOLookUp, DtMultiSORNO)
                        'Fill Product Info
                        ProdNoFill2(dtUpdateSO, DtMissProdInfoSOUpdated)
                        ' Tranfer Updated MO to COPTF for status updating
                        SOTrans(dtUpdateSO, strDtSOEdited, strCNVN, "update", DtSuccessUpdSO)
                    End If
                    BW.ReportProgress(80)
                    'Add Failed LookUp SO to New SO
                    MoveFailedLookUp2NewSO(dtNewSO, FailSOLookUp)
                    'Assign MO Number
                    AssignMONo(dtNewMO, dtNewSO, DtMissOrgMO)
                    'Load backlog to datatable
                    Dim dtNewBLSO As DataTable = dtNewSO.Clone
                    MoveBL2NewSO(dtNewBLSO, strCNVNBL)
                    'Fill Product Number Information for backlog SO
                    If dtNewBLSO.Rows.Count > 0 Then
                        ProdNoFill(dtNewBLSO, DtMissProdInfo)
                    End If
                    'Get BLMO for update
                    If dtNewBLSO.Rows.Count > 0 Then
                        Dim dtNewBLMO As New DataTable
                        dtNewBLMO.Columns.Add(New DataColumn("TC001", GetType(String)))
                        dtNewBLMO.Columns.Add(New DataColumn("TC002", GetType(String)))
                        dtNewBLMO.Columns.Add(New DataColumn("TC005", GetType(String)))
                        dtNewBLMO.Columns.Add(New DataColumn("TC010", GetType(String)))
                        dtNewBLMO.Columns.Add(New DataColumn("TC031", GetType(Decimal)))
                        dtNewBLMO.Columns.Add(New DataColumn("TC046", GetType(Decimal)))
                        GetBLMO(dtNewBLSO, dtNewBLMO)
                        'Fill Address Information for BLMO
                        AddrFill(dtNewBLMO, dtNewBLSO, DtMissProdInfoMO)
                        'Fill Sum Qty and Weight for BLMO
                        SumFill(dtNewBLMO, dtNewBLSO)
                        'Update BLMO
                        SOUpdate(dtNewBLMO)
                    End If
                    'Add Backlog MO to New MO datatable
                    'MoveBL2NewMO(dtNewMO, strCNVNBL)-->not need
                    'Fill Product Number Information
                    ProdNoFill(dtNewSO, DtMissProdInfo)
                    'Fill Address Information
                    AddrFill(dtNewMO, dtNewSO, DtMissProdInfoMO)
                    'Fill Sum Qty and Weight
                    SumFill(dtNewMO, dtNewSO)
                    ' Tranfer New MO to COPTC for status updating
                    SOTrans(dtNewMO, strDtMO, strCNVN, "create", dtSuccessMO, True)
                    ' Tranfer New SO to COPTD for status updating
                    Try
                        MergeBLSO2NewSO(dtNewBLSO, dtNewSO)
                    Catch ex As SQLException

                    End Try
                    SOTrans(dtNewSO, strDtSO, strCNVN, "create", DtSuccessInsSO)
                End If
                BW.ReportProgress(94)
            End If
            BW.ReportProgress(98)
        End If
        BW.ReportProgress(100)
    End Sub

    Private Sub FilterRemarks(dtMO As DataTable, dtRM As DataTable)
        Dim DelRows As New List(Of DataRow)
        For Each drMO As DataRow In dtMO.Rows
            Dim MORemark As String = Trim(drMO("REMARKS"))
            For Each drRM As DataRow In dtRM.Rows
                Dim Remark As String = Trim(drRM("REMARKS"))
                If MORemark.Contains(Remark) Then
                    DelRows.Add(drMO)
                    Exit For
                End If
            Next
        Next
        For Each dr As DataRow In DelRows
            dtMO.Rows.Remove(dr)
        Next
        dtMO.AcceptChanges()
        RemoveREMARKSCol(dtMO)
    End Sub
    Private Sub FilterSO(dtSO As DataTable, SO_SORNOCOL As String, dtMO As DataTable, MO_SORNOCOL As String)
        Dim DelRows As New List(Of DataRow)
        For Each drSO As DataRow In dtSO.Rows
            Dim SOSORNO As String = Trim(drSO(SO_SORNOCOL))
            Dim found As Boolean = False
            For Each drMO As DataRow In dtMO.Rows
                Dim MOSORNO As String = Trim(drMO(MO_SORNOCOL))
                If SOSORNO = MOSORNO Then
                    found = True
                    Exit For
                End If
            Next
            If Not found Then
                DelRows.Add(drSO)
            End If
        Next
        For Each dr As DataRow In DelRows
            dtSO.Rows.Remove(dr)
        Next
        dtSO.AcceptChanges()
    End Sub

    Private Sub BW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW.RunWorkerCompleted
        Dim mysettings = My.Settings
        txt_spt.Text = mysettings.cfg_spt
        Elog("End point: " & mysettings.cfg_spt, 2)
        Elog("Session " & mysettings.session_number & " completed.", 2)
        'Write session log to .txt file
        Dim sessionLog As String = String.Format("Report\SessionLog_{0}.txt", mysettings.session_number)
        Using logWriter As StreamWriter = New StreamWriter(sessionLog)
            logWriter.Write(txt_elogs.Text)
        End Using

        'Run Excel Application
        Dim xlsApp As New Excel.Application
        xlsApp.SheetsInNewWorkbook = 8
        Dim wBook As Excel.Workbook
        'Creat a workbook
        wBook = xlsApp.Workbooks.Add()
        Elog("Generating session report...", 1)
        ' Write report to excel file
        WriteReport2Excel(xlsApp, wBook, 1, "MO Missing Product Code", DtMissProdInfoMO)
        WriteReport2Excel(xlsApp, wBook, 2, "SO Missing Product Code", DtMissProdInfo)
        WriteReport2Excel(xlsApp, wBook, 3, "Failed Updt SO w New Item", DtMissProdInfoSOUpdated)
        WriteReport2Excel(xlsApp, wBook, 4, "Failed Updt MO w Multilink", DtMultiSORNO)
        WriteReport2Excel(xlsApp, wBook, 5, "Updated MO", dtSuccessMOUpdated)
        WriteReport2Excel(xlsApp, wBook, 6, "Updated SO", DtSuccessUpdSO)
        WriteReport2Excel(xlsApp, wBook, 7, "New MO", dtSuccessMO)
        WriteReport2Excel(xlsApp, wBook, 8, "New SO", DtSuccessInsSO)
        wBook.Worksheets("MO Missing Product Code").Activate
        'Save the workbook in xlsx format
        Dim detailXls As String = Environment.CurrentDirectory + String.Format("\Report\Detailed Report {0}.xlsx", mysettings.session_number)
        If System.IO.File.Exists(detailXls) Then
            System.IO.File.Delete(detailXls)
        End If
        wBook.SaveAs(detailXls)
        wBook.Close()
        xlsApp.Quit()
        Elog("Session report generated.", 2)
        Dim ttFailedMO As Integer = DtMissProdInfoMO.Rows.Count
        Dim ttMissOrgMO As Integer = DtMultiSORNO.Rows.Count
        Dim ttMissPrdInfo As Integer = DtMissProdInfo.Rows.Count
        'Dim ttDelSO As Integer = DtSuccessDelSO.Rows.Count
        Dim ttUpdSO As Integer = DtSuccessUpdSO.Rows.Count
        Dim ttNewSO As Integer = DtSuccessInsSO.Rows.Count
        'Send notification
        Dim GGmail As New GMAIL(mysettings.cfg_sender, mysettings.cfg_sender_pw)
        Dim ToAddressies() As String = mysettings.cfg_recipients.Split({vbLf}, StringSplitOptions.RemoveEmptyEntries)
        Dim attachs() As String = {sessionLog, detailXls}
        Dim subject As String = String.Format("SOT Report No. {0}", mysettings.session_number)
        Dim body As String = String.Format(mysettings.notification_email_body, mysettings.session_number, ttFailedMO, ttMissOrgMO, ttMissPrdInfo, ttUpdSO, ttNewSO, startPoint)
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

    Private Sub Btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If txt_spt.Enabled Then
            btn_edit.Text = "Edit"
            txt_spt.Enabled = False
        Else
            Dim pw As String = Microsoft.VisualBasic.Interaction.InputBox("Changing start point may lead to duplicate order. May sure you know what you do! Please enter your super admin password to terminate the application process!", "Warning", "*******")
            If pw = My.Settings.supw Then
                txt_spt.Enabled = True
                btn_edit.Text = "Lock"
            Else
                MsgBox("Incorrect password!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class

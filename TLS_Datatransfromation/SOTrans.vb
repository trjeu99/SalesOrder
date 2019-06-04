Imports System.Data.SqlClient
Module SOTrans
    Sub Main()
        Dim mySettings = My.Settings
        ' Open a connection to the database.
        Dim strConnectionHK As String = "Data Source=223.255.178.194,11433; Network Library=dbmssocn; Initial Catalog=ntls; User ID=ntlsdoc; Password=ntls@2121"
        Dim cnHK As SqlConnection = New SqlConnection(strConnectionHK)
        cnHK.Open()
        ' Set up a data set command object.
        Dim strSelectMop As String = "SELECT dbo.MAINSO.TDATE AS XA001, dbo.MAINSO.DATETIME AS XA002, dbo.MAINSO.SORNO AS XA003, dbo.MAINSO.REV AS XA004, dbo.CUS.CUSGP1 AS XA005, dbo.MAINSO.DDATE AS XA006, dbo.CUS.CNAME AS XA007, dbo.MAINSO.CUR AS XA008, dbo.MAINSO.WEIGHTUNIT AS XA009, dbo.MAINSO.MEASUNIT AS XA010, dbo.CUS.REGION AS XA011, 0 AS XA012, 0 AS XA013, '' AS XA014, 'PR001' AS XA015
                                        FROM dbo.CUS INNER JOIN dbo.MAINSO ON dbo.CUS.CUS = dbo.MAINSO.CUS
                                            WHERE (((dbo.MAINSO.DATETIME) >= '4/1/2019 04:00:00 AM') AND ((dbo.MAINSO.CUS) Like '%VN'))
                                                ORDER BY dbo.MAINSO.DATETIME DESC;"
        Console.WriteLine(strSelectMop)
        ' Console.Read()
        '  Dim strSelectSop As String = "Select dbo.SOT.TDATE As XB001, dbo.SOT.DATETIME As XB002, dbo.SOT.SORNO As XB003, dbo.SOT.REV As XB004, dbo.SOT.CODE As XB005, dbo.SOT.BDESC As XB006, dbo.SOT.QTY As XB007, dbo.SOT.UP As XB008, dbo.SOT.SETA As XB009, '' AS XB010, '' AS XB011, '' AS XB012, 0 AS XB013, 0 AS XB014, '' AS XB015
        ' From dbo.SOT
        'WHERE (((dbo.SOT.TDATE)>='4/1/2019'))"
        ' Load a data set.
        Dim cmdMop As New SqlCommand(strSelectMop, cnHK)
        'Dim cmdSop As New SqlCommand(strSelectSop, cnHK)
        Dim readerMop As SqlDataReader = cmdMop.ExecuteReader()
        'Dim readerSop As SqlDataReader = cmdSop.ExecuteReader()

        Dim strConnectionVN As String = "Data Source=TIM; Database=TLS; User ID=sa; Password=!QAZxdr5"
        Using cnVN As New SqlConnection(strConnectionVN)
            cnVN.Open()
            Using copyMop As New SqlBulkCopy(cnVN)
                copyMop.DestinationTableName = "dbo.COPXA"
                Try
                    copyMop.WriteToServer(readerMop)
                Catch ex As SqlException
                    MsgBox(ex.Message)
                End Try
            End Using
            cnVN.Close()
        End Using
        cnHK.Close()

        ' Console.Read()
    End Sub
End Module

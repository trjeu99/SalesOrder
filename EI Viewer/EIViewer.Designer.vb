<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EIViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EIViewer))
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.orderType = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dvg_COPTC = New System.Windows.Forms.DataGridView()
        Me.CREATORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CREATE_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TC012DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TC001DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TC002DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TC003DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TC004DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TC005DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TC008DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COPTCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TECHLINKDataSet = New EI_Viewer.TECHLINKDataSet()
        Me.txt_creator = New System.Windows.Forms.TextBox()
        Me.txt_TC002 = New System.Windows.Forms.TextBox()
        Me.txt_TC003 = New System.Windows.Forms.TextBox()
        Me.txt_TC004 = New System.Windows.Forms.TextBox()
        Me.txt_TC005 = New System.Windows.Forms.TextBox()
        Me.txt_TC008 = New System.Windows.Forms.TextBox()
        Me.txt_createDate = New System.Windows.Forms.TextBox()
        Me.txt_TC012 = New System.Windows.Forms.TextBox()
        Me.txt_TC001 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_search_orderType = New System.Windows.Forms.Button()
        Me.dvg_BLCOPTD = New System.Windows.Forms.DataGridView()
        Me.TD002DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TD003DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TD004DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TD008DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TD013DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BLCOPTDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SOTDataSet = New EI_Viewer.SOTDataSet()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_TD002 = New System.Windows.Forms.TextBox()
        Me.txt_TD003 = New System.Windows.Forms.TextBox()
        Me.txt_TD004 = New System.Windows.Forms.TextBox()
        Me.txt_TD008 = New System.Windows.Forms.TextBox()
        Me.txt_TD013 = New System.Windows.Forms.TextBox()
        Me.btn_search_BLCOPTD = New System.Windows.Forms.Button()
        Me.backlogs = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.COPTCTableAdapter = New EI_Viewer.TECHLINKDataSetTableAdapters.COPTCTableAdapter()
        Me.BLCOPTDTableAdapter = New EI_Viewer.SOTDataSetTableAdapters.BLCOPTDTableAdapter()
        Me.orderType.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dvg_COPTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COPTCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TECHLINKDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvg_BLCOPTD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BLCOPTDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SOTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.backlogs.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(1236, 2)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(93, 39)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(1135, 2)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(93, 39)
        Me.btn_update.TabIndex = 2
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Location = New System.Drawing.Point(1028, 2)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(101, 42)
        Me.btn_add.TabIndex = 11
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        Me.btn_add.Visible = False
        '
        'orderType
        '
        Me.orderType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.orderType.Controls.Add(Me.TableLayoutPanel2)
        Me.orderType.Location = New System.Drawing.Point(4, 27)
        Me.orderType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.orderType.Name = "orderType"
        Me.orderType.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.orderType.Size = New System.Drawing.Size(1318, 348)
        Me.orderType.TabIndex = 0
        Me.orderType.Text = "ĐẦU ĐƠN"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 10
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dvg_COPTC, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_creator, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_TC002, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_TC003, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_TC004, 6, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_TC005, 7, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_TC008, 8, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_createDate, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_TC012, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_TC001, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 8, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_search_orderType, 9, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 2)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1312, 344)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 30)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "CREATOR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dvg_COPTC
        '
        Me.dvg_COPTC.AllowUserToAddRows = False
        Me.dvg_COPTC.AllowUserToResizeColumns = False
        Me.dvg_COPTC.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dvg_COPTC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dvg_COPTC.AutoGenerateColumns = False
        Me.dvg_COPTC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvg_COPTC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dvg_COPTC.BackgroundColor = System.Drawing.Color.White
        Me.dvg_COPTC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvg_COPTC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dvg_COPTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_COPTC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CREATORDataGridViewTextBoxColumn, Me.CREATE_DATE, Me.TC012DataGridViewTextBoxColumn, Me.TC001DataGridViewTextBoxColumn, Me.TC002DataGridViewTextBoxColumn, Me.TC003DataGridViewTextBoxColumn, Me.TC004DataGridViewTextBoxColumn, Me.TC005DataGridViewTextBoxColumn, Me.TC008DataGridViewTextBoxColumn})
        Me.TableLayoutPanel2.SetColumnSpan(Me.dvg_COPTC, 10)
        Me.dvg_COPTC.DataSource = Me.COPTCBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvg_COPTC.DefaultCellStyle = DataGridViewCellStyle3
        Me.dvg_COPTC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dvg_COPTC.EnableHeadersVisualStyles = False
        Me.dvg_COPTC.GridColor = System.Drawing.Color.DeepSkyBlue
        Me.dvg_COPTC.Location = New System.Drawing.Point(3, 58)
        Me.dvg_COPTC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dvg_COPTC.MultiSelect = False
        Me.dvg_COPTC.Name = "dvg_COPTC"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvg_COPTC.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dvg_COPTC.RowHeadersVisible = False
        Me.dvg_COPTC.RowHeadersWidth = 51
        Me.dvg_COPTC.RowTemplate.Height = 24
        Me.dvg_COPTC.RowTemplate.ReadOnly = True
        Me.dvg_COPTC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvg_COPTC.ShowCellErrors = False
        Me.dvg_COPTC.ShowCellToolTips = False
        Me.dvg_COPTC.ShowEditingIcon = False
        Me.dvg_COPTC.ShowRowErrors = False
        Me.dvg_COPTC.Size = New System.Drawing.Size(1307, 284)
        Me.dvg_COPTC.TabIndex = 1
        Me.dvg_COPTC.TabStop = False
        '
        'CREATORDataGridViewTextBoxColumn
        '
        Me.CREATORDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CREATORDataGridViewTextBoxColumn.DataPropertyName = "CREATOR"
        Me.CREATORDataGridViewTextBoxColumn.FillWeight = 529.4119!
        Me.CREATORDataGridViewTextBoxColumn.HeaderText = "CREATOR"
        Me.CREATORDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CREATORDataGridViewTextBoxColumn.Name = "CREATORDataGridViewTextBoxColumn"
        Me.CREATORDataGridViewTextBoxColumn.Width = 110
        '
        'CREATE_DATE
        '
        Me.CREATE_DATE.DataPropertyName = "CREATE_DATE"
        Me.CREATE_DATE.FillWeight = 46.32352!
        Me.CREATE_DATE.HeaderText = "CREATE_DATE"
        Me.CREATE_DATE.MinimumWidth = 6
        Me.CREATE_DATE.Name = "CREATE_DATE"
        '
        'TC012DataGridViewTextBoxColumn
        '
        Me.TC012DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TC012DataGridViewTextBoxColumn.DataPropertyName = "TC012"
        Me.TC012DataGridViewTextBoxColumn.FillWeight = 46.32352!
        Me.TC012DataGridViewTextBoxColumn.HeaderText = "MÃ ĐƠN HK"
        Me.TC012DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TC012DataGridViewTextBoxColumn.Name = "TC012DataGridViewTextBoxColumn"
        Me.TC012DataGridViewTextBoxColumn.Width = 122
        '
        'TC001DataGridViewTextBoxColumn
        '
        Me.TC001DataGridViewTextBoxColumn.DataPropertyName = "TC001"
        Me.TC001DataGridViewTextBoxColumn.FillWeight = 46.32352!
        Me.TC001DataGridViewTextBoxColumn.HeaderText = "MÃ LOẠI ĐƠN"
        Me.TC001DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TC001DataGridViewTextBoxColumn.Name = "TC001DataGridViewTextBoxColumn"
        '
        'TC002DataGridViewTextBoxColumn
        '
        Me.TC002DataGridViewTextBoxColumn.DataPropertyName = "TC002"
        Me.TC002DataGridViewTextBoxColumn.FillWeight = 46.32352!
        Me.TC002DataGridViewTextBoxColumn.HeaderText = "MÃ ĐƠN ERP"
        Me.TC002DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TC002DataGridViewTextBoxColumn.Name = "TC002DataGridViewTextBoxColumn"
        '
        'TC003DataGridViewTextBoxColumn
        '
        Me.TC003DataGridViewTextBoxColumn.DataPropertyName = "TC003"
        Me.TC003DataGridViewTextBoxColumn.FillWeight = 46.32352!
        Me.TC003DataGridViewTextBoxColumn.HeaderText = "NGÀY ĐH"
        Me.TC003DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TC003DataGridViewTextBoxColumn.Name = "TC003DataGridViewTextBoxColumn"
        '
        'TC004DataGridViewTextBoxColumn
        '
        Me.TC004DataGridViewTextBoxColumn.DataPropertyName = "TC004"
        Me.TC004DataGridViewTextBoxColumn.FillWeight = 46.32352!
        Me.TC004DataGridViewTextBoxColumn.HeaderText = "MÃ KH"
        Me.TC004DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TC004DataGridViewTextBoxColumn.Name = "TC004DataGridViewTextBoxColumn"
        '
        'TC005DataGridViewTextBoxColumn
        '
        Me.TC005DataGridViewTextBoxColumn.DataPropertyName = "TC005"
        Me.TC005DataGridViewTextBoxColumn.FillWeight = 46.32352!
        Me.TC005DataGridViewTextBoxColumn.HeaderText = "MÃ BỘ PHẬN"
        Me.TC005DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TC005DataGridViewTextBoxColumn.Name = "TC005DataGridViewTextBoxColumn"
        '
        'TC008DataGridViewTextBoxColumn
        '
        Me.TC008DataGridViewTextBoxColumn.DataPropertyName = "TC008"
        Me.TC008DataGridViewTextBoxColumn.FillWeight = 46.32352!
        Me.TC008DataGridViewTextBoxColumn.HeaderText = "TIỀN TỆ"
        Me.TC008DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TC008DataGridViewTextBoxColumn.Name = "TC008DataGridViewTextBoxColumn"
        '
        'COPTCBindingSource
        '
        Me.COPTCBindingSource.DataMember = "COPTC"
        Me.COPTCBindingSource.DataSource = Me.TECHLINKDataSet
        '
        'TECHLINKDataSet
        '
        Me.TECHLINKDataSet.DataSetName = "TECHLINKDataSet"
        Me.TECHLINKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_creator
        '
        Me.txt_creator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_creator.Enabled = False
        Me.txt_creator.Location = New System.Drawing.Point(3, 32)
        Me.txt_creator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_creator.Name = "txt_creator"
        Me.txt_creator.Size = New System.Drawing.Size(114, 24)
        Me.txt_creator.TabIndex = 2
        '
        'txt_TC002
        '
        Me.txt_TC002.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TC002.Enabled = False
        Me.txt_TC002.Location = New System.Drawing.Point(512, 32)
        Me.txt_TC002.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TC002.Name = "txt_TC002"
        Me.txt_TC002.Size = New System.Drawing.Size(114, 24)
        Me.txt_TC002.TabIndex = 6
        '
        'txt_TC003
        '
        Me.txt_TC003.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TC003.Enabled = False
        Me.txt_TC003.Location = New System.Drawing.Point(632, 32)
        Me.txt_TC003.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TC003.Name = "txt_TC003"
        Me.txt_TC003.Size = New System.Drawing.Size(114, 24)
        Me.txt_TC003.TabIndex = 7
        '
        'txt_TC004
        '
        Me.txt_TC004.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TC004.Enabled = False
        Me.txt_TC004.Location = New System.Drawing.Point(752, 32)
        Me.txt_TC004.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TC004.Name = "txt_TC004"
        Me.txt_TC004.Size = New System.Drawing.Size(114, 24)
        Me.txt_TC004.TabIndex = 8
        '
        'txt_TC005
        '
        Me.txt_TC005.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TC005.Enabled = False
        Me.txt_TC005.Location = New System.Drawing.Point(872, 32)
        Me.txt_TC005.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TC005.Name = "txt_TC005"
        Me.txt_TC005.Size = New System.Drawing.Size(125, 24)
        Me.txt_TC005.TabIndex = 9
        '
        'txt_TC008
        '
        Me.txt_TC008.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TC008.Enabled = False
        Me.txt_TC008.Location = New System.Drawing.Point(1003, 32)
        Me.txt_TC008.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TC008.Name = "txt_TC008"
        Me.txt_TC008.Size = New System.Drawing.Size(125, 24)
        Me.txt_TC008.TabIndex = 10
        '
        'txt_createDate
        '
        Me.txt_createDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_createDate.Enabled = False
        Me.txt_createDate.Location = New System.Drawing.Point(123, 32)
        Me.txt_createDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_createDate.Name = "txt_createDate"
        Me.txt_createDate.Size = New System.Drawing.Size(114, 24)
        Me.txt_createDate.TabIndex = 11
        '
        'txt_TC012
        '
        Me.txt_TC012.BackColor = System.Drawing.SystemColors.Info
        Me.txt_TC012.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TC012.Location = New System.Drawing.Point(243, 32)
        Me.txt_TC012.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TC012.Name = "txt_TC012"
        Me.txt_TC012.Size = New System.Drawing.Size(143, 24)
        Me.txt_TC012.TabIndex = 12
        '
        'txt_TC001
        '
        Me.txt_TC001.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TC001.Location = New System.Drawing.Point(392, 32)
        Me.txt_TC001.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TC001.Name = "txt_TC001"
        Me.txt_TC001.Size = New System.Drawing.Size(114, 24)
        Me.txt_TC001.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(123, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 30)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "CREATE DATE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(243, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 30)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "MÃ ĐƠN HK"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(392, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 30)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "MÃ LOẠI ĐƠN"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(512, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 30)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "MÃ ĐƠN ERP"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Location = New System.Drawing.Point(632, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 30)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "NGÀY ĐH"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label11.Location = New System.Drawing.Point(752, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 30)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "MÃ KH"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Location = New System.Drawing.Point(872, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 30)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "MÃ BỘ PHẬN"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Location = New System.Drawing.Point(1003, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 30)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "TIỀN TỆ"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_search_orderType
        '
        Me.btn_search_orderType.BackColor = System.Drawing.Color.White
        Me.btn_search_orderType.BackgroundImage = Global.EI_Viewer.My.Resources.Resources.search1
        Me.btn_search_orderType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_search_orderType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_search_orderType.Location = New System.Drawing.Point(1134, 2)
        Me.btn_search_orderType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_search_orderType.Name = "btn_search_orderType"
        Me.TableLayoutPanel2.SetRowSpan(Me.btn_search_orderType, 2)
        Me.btn_search_orderType.Size = New System.Drawing.Size(176, 52)
        Me.btn_search_orderType.TabIndex = 23
        Me.btn_search_orderType.UseVisualStyleBackColor = False
        '
        'dvg_BLCOPTD
        '
        Me.dvg_BLCOPTD.AllowUserToAddRows = False
        Me.dvg_BLCOPTD.AllowUserToResizeColumns = False
        Me.dvg_BLCOPTD.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dvg_BLCOPTD.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dvg_BLCOPTD.AutoGenerateColumns = False
        Me.dvg_BLCOPTD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvg_BLCOPTD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dvg_BLCOPTD.BackgroundColor = System.Drawing.Color.White
        Me.dvg_BLCOPTD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvg_BLCOPTD.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dvg_BLCOPTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_BLCOPTD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TD002DataGridViewTextBoxColumn, Me.TD003DataGridViewTextBoxColumn, Me.TD004DataGridViewTextBoxColumn, Me.TD008DataGridViewTextBoxColumn, Me.TD013DataGridViewTextBoxColumn})
        Me.TableLayoutPanel3.SetColumnSpan(Me.dvg_BLCOPTD, 6)
        Me.dvg_BLCOPTD.DataSource = Me.BLCOPTDBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dvg_BLCOPTD.DefaultCellStyle = DataGridViewCellStyle7
        Me.dvg_BLCOPTD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dvg_BLCOPTD.EnableHeadersVisualStyles = False
        Me.dvg_BLCOPTD.GridColor = System.Drawing.Color.DeepSkyBlue
        Me.dvg_BLCOPTD.Location = New System.Drawing.Point(3, 58)
        Me.dvg_BLCOPTD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dvg_BLCOPTD.MultiSelect = False
        Me.dvg_BLCOPTD.Name = "dvg_BLCOPTD"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dvg_BLCOPTD.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dvg_BLCOPTD.RowHeadersVisible = False
        Me.dvg_BLCOPTD.RowHeadersWidth = 51
        Me.dvg_BLCOPTD.RowTemplate.Height = 24
        Me.dvg_BLCOPTD.RowTemplate.ReadOnly = True
        Me.dvg_BLCOPTD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dvg_BLCOPTD.ShowCellErrors = False
        Me.dvg_BLCOPTD.ShowCellToolTips = False
        Me.dvg_BLCOPTD.ShowEditingIcon = False
        Me.dvg_BLCOPTD.ShowRowErrors = False
        Me.dvg_BLCOPTD.Size = New System.Drawing.Size(1307, 284)
        Me.dvg_BLCOPTD.TabIndex = 1
        Me.dvg_BLCOPTD.TabStop = False
        '
        'TD002DataGridViewTextBoxColumn
        '
        Me.TD002DataGridViewTextBoxColumn.DataPropertyName = "TD002"
        Me.TD002DataGridViewTextBoxColumn.HeaderText = "TD002"
        Me.TD002DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TD002DataGridViewTextBoxColumn.Name = "TD002DataGridViewTextBoxColumn"
        '
        'TD003DataGridViewTextBoxColumn
        '
        Me.TD003DataGridViewTextBoxColumn.DataPropertyName = "TD003"
        Me.TD003DataGridViewTextBoxColumn.HeaderText = "TD003"
        Me.TD003DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TD003DataGridViewTextBoxColumn.Name = "TD003DataGridViewTextBoxColumn"
        '
        'TD004DataGridViewTextBoxColumn
        '
        Me.TD004DataGridViewTextBoxColumn.DataPropertyName = "TD004"
        Me.TD004DataGridViewTextBoxColumn.HeaderText = "TD004"
        Me.TD004DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TD004DataGridViewTextBoxColumn.Name = "TD004DataGridViewTextBoxColumn"
        '
        'TD008DataGridViewTextBoxColumn
        '
        Me.TD008DataGridViewTextBoxColumn.DataPropertyName = "TD008"
        Me.TD008DataGridViewTextBoxColumn.HeaderText = "TD008"
        Me.TD008DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TD008DataGridViewTextBoxColumn.Name = "TD008DataGridViewTextBoxColumn"
        '
        'TD013DataGridViewTextBoxColumn
        '
        Me.TD013DataGridViewTextBoxColumn.DataPropertyName = "TD013"
        Me.TD013DataGridViewTextBoxColumn.HeaderText = "TD013"
        Me.TD013DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TD013DataGridViewTextBoxColumn.Name = "TD013DataGridViewTextBoxColumn"
        '
        'BLCOPTDBindingSource
        '
        Me.BLCOPTDBindingSource.DataMember = "BLCOPTD"
        Me.BLCOPTDBindingSource.DataSource = Me.SOTDataSet
        '
        'SOTDataSet
        '
        Me.SOTDataSet.DataSetName = "SOTDataSet"
        Me.SOTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.dvg_BLCOPTD, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label14, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label16, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_TD002, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_TD003, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_TD004, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_TD008, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_TD013, 4, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_search_BLCOPTD, 5, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 2)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1313, 344)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MÃ ĐƠN ERP"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(204, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 30)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "STT"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Location = New System.Drawing.Point(433, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(226, 30)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "MÃ SẢN PHẨM"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label15.Location = New System.Drawing.Point(665, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(226, 30)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "SỐ LƯỢNG"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label16.Location = New System.Drawing.Point(897, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(245, 30)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "NGÀY ETD"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_TD002
        '
        Me.txt_TD002.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TD002.Location = New System.Drawing.Point(3, 32)
        Me.txt_TD002.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TD002.Name = "txt_TD002"
        Me.txt_TD002.Size = New System.Drawing.Size(195, 24)
        Me.txt_TD002.TabIndex = 7
        '
        'txt_TD003
        '
        Me.txt_TD003.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TD003.Enabled = False
        Me.txt_TD003.Location = New System.Drawing.Point(204, 32)
        Me.txt_TD003.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TD003.Name = "txt_TD003"
        Me.txt_TD003.Size = New System.Drawing.Size(223, 24)
        Me.txt_TD003.TabIndex = 8
        '
        'txt_TD004
        '
        Me.txt_TD004.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TD004.Enabled = False
        Me.txt_TD004.Location = New System.Drawing.Point(433, 32)
        Me.txt_TD004.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TD004.Name = "txt_TD004"
        Me.txt_TD004.Size = New System.Drawing.Size(226, 24)
        Me.txt_TD004.TabIndex = 9
        '
        'txt_TD008
        '
        Me.txt_TD008.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TD008.Enabled = False
        Me.txt_TD008.Location = New System.Drawing.Point(665, 32)
        Me.txt_TD008.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TD008.Name = "txt_TD008"
        Me.txt_TD008.Size = New System.Drawing.Size(226, 24)
        Me.txt_TD008.TabIndex = 10
        '
        'txt_TD013
        '
        Me.txt_TD013.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_TD013.Enabled = False
        Me.txt_TD013.Location = New System.Drawing.Point(897, 32)
        Me.txt_TD013.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_TD013.Name = "txt_TD013"
        Me.txt_TD013.Size = New System.Drawing.Size(245, 24)
        Me.txt_TD013.TabIndex = 11
        '
        'btn_search_BLCOPTD
        '
        Me.btn_search_BLCOPTD.BackColor = System.Drawing.Color.White
        Me.btn_search_BLCOPTD.BackgroundImage = Global.EI_Viewer.My.Resources.Resources.search1
        Me.btn_search_BLCOPTD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_search_BLCOPTD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_search_BLCOPTD.Location = New System.Drawing.Point(1148, 2)
        Me.btn_search_BLCOPTD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_search_BLCOPTD.Name = "btn_search_BLCOPTD"
        Me.TableLayoutPanel3.SetRowSpan(Me.btn_search_BLCOPTD, 2)
        Me.btn_search_BLCOPTD.Size = New System.Drawing.Size(162, 52)
        Me.btn_search_BLCOPTD.TabIndex = 12
        Me.btn_search_BLCOPTD.UseVisualStyleBackColor = False
        '
        'backlogs
        '
        Me.backlogs.BackColor = System.Drawing.Color.WhiteSmoke
        Me.backlogs.Controls.Add(Me.TableLayoutPanel3)
        Me.backlogs.Location = New System.Drawing.Point(4, 27)
        Me.backlogs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backlogs.Name = "backlogs"
        Me.backlogs.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backlogs.Size = New System.Drawing.Size(1319, 348)
        Me.backlogs.TabIndex = 1
        Me.backlogs.Text = "THÂN ĐƠN CHƯA CHUYỂN"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label8, 4)
        Me.Label8.Location = New System.Drawing.Point(3, 429)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Copyright © Mandigi Co., Ltd"
        '
        'TabControl1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TabControl1, 4)
        Me.TabControl1.Controls.Add(Me.orderType)
        Me.TabControl1.Controls.Add(Me.backlogs)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 48)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1326, 379)
        Me.TabControl1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1019, 46)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "MANDIGI CO., LTD"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_delete, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_update, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_add, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.72261!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.27739!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1332, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'COPTCTableAdapter
        '
        Me.COPTCTableAdapter.ClearBeforeFill = True
        '
        'BLCOPTDTableAdapter
        '
        Me.BLCOPTDTableAdapter.ClearBeforeFill = True
        '
        'EIViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "EIViewer"
        Me.Text = "ERP INTERFACE VIEWER"
        Me.orderType.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.dvg_COPTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COPTCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TECHLINKDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvg_BLCOPTD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BLCOPTDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SOTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.backlogs.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents orderType As TabPage
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dvg_COPTC As DataGridView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents dvg_BLCOPTD As DataGridView
    Friend WithEvents backlogs As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Label4 As Label
    Friend WithEvents TECHLINKDataSet As TECHLINKDataSet
    Friend WithEvents COPTCBindingSource As BindingSource
    Friend WithEvents COPTCTableAdapter As TECHLINKDataSetTableAdapters.COPTCTableAdapter
    Friend WithEvents SOTDataSet As SOTDataSet
    Friend WithEvents BLCOPTDBindingSource As BindingSource
    Friend WithEvents BLCOPTDTableAdapter As SOTDataSetTableAdapters.BLCOPTDTableAdapter
    Friend WithEvents TD002DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TD003DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TD004DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TD008DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TD013DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_creator As TextBox
    Friend WithEvents txt_TC002 As TextBox
    Friend WithEvents txt_TC003 As TextBox
    Friend WithEvents txt_TC004 As TextBox
    Friend WithEvents txt_TC005 As TextBox
    Friend WithEvents txt_TC008 As TextBox
    Friend WithEvents txt_createDate As TextBox
    Friend WithEvents txt_TC012 As TextBox
    Friend WithEvents txt_TC001 As TextBox
    Friend WithEvents CREATORDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CREATE_DATE As DataGridViewTextBoxColumn
    Friend WithEvents TC012DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TC001DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TC002DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TC003DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TC004DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TC005DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TC008DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btn_search_orderType As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_TD002 As TextBox
    Friend WithEvents txt_TD003 As TextBox
    Friend WithEvents txt_TD004 As TextBox
    Friend WithEvents txt_TD008 As TextBox
    Friend WithEvents txt_TD013 As TextBox
    Friend WithEvents btn_search_BLCOPTD As Button
End Class

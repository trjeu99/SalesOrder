<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Excluded_items
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Excluded_items))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.prodCode = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CREATEDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CREATORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXPRODBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SOTDataSet = New Excluded_Product.SOTDataSet()
        Me.txt_createDate = New System.Windows.Forms.TextBox()
        Me.txt_creator = New System.Windows.Forms.TextBox()
        Me.txt_prodCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_prodCode = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.remarks = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMARKSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_createDate_remarks = New System.Windows.Forms.TextBox()
        Me.txt_creator_remarks = New System.Windows.Forms.TextBox()
        Me.txt_remarks = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_remarks = New System.Windows.Forms.Label()
        Me.btn_search_remarks = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.EXPRODTableAdapter = New Excluded_Product.SOTDataSetTableAdapters.EXPRODTableAdapter()
        Me.REMARKSTableAdapter = New Excluded_Product.SOTDataSetTableAdapters.REMARKSTableAdapter()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.prodCode.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXPRODBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SOTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.remarks.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REMARKSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_delete, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_update, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_add, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.72261!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.27739!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label8, 4)
        Me.Label8.Location = New System.Drawing.Point(3, 429)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(666, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Copyright © TECH-LINK SILICONES (VN) LTD | Software support: support@mandigi.vn |" &
    " Mandigi Co., Ltd"
        '
        'TabControl1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TabControl1, 4)
        Me.TabControl1.Controls.Add(Me.prodCode)
        Me.TabControl1.Controls.Add(Me.remarks)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(794, 377)
        Me.TabControl1.TabIndex = 0
        '
        'prodCode
        '
        Me.prodCode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.prodCode.Controls.Add(Me.TableLayoutPanel2)
        Me.prodCode.Location = New System.Drawing.Point(4, 27)
        Me.prodCode.Name = "prodCode"
        Me.prodCode.Padding = New System.Windows.Forms.Padding(3)
        Me.prodCode.Size = New System.Drawing.Size(786, 346)
        Me.prodCode.TabIndex = 0
        Me.prodCode.Text = "PRODUCT CODE"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 459.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DataGridView1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_createDate, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_creator, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_prodCode, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_prodCode, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_search, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(780, 340)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CREATEDATEDataGridViewTextBoxColumn, Me.CREATORDataGridViewTextBoxColumn, Me.PRODCODEDataGridViewTextBoxColumn})
        Me.TableLayoutPanel2.SetColumnSpan(Me.DataGridView1, 4)
        Me.DataGridView1.DataSource = Me.EXPRODBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.DeepSkyBlue
        Me.DataGridView1.Location = New System.Drawing.Point(3, 58)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(774, 279)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.TabStop = False
        '
        'CREATEDATEDataGridViewTextBoxColumn
        '
        Me.CREATEDATEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CREATEDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATEDATE"
        DataGridViewCellStyle3.Format = "dd/MM/yyyy HH:mm:ss"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.CREATEDATEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CREATEDATEDataGridViewTextBoxColumn.FillWeight = 148.0!
        Me.CREATEDATEDataGridViewTextBoxColumn.HeaderText = "CREATE DATE"
        Me.CREATEDATEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CREATEDATEDataGridViewTextBoxColumn.Name = "CREATEDATEDataGridViewTextBoxColumn"
        Me.CREATEDATEDataGridViewTextBoxColumn.Width = 148
        '
        'CREATORDataGridViewTextBoxColumn
        '
        Me.CREATORDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CREATORDataGridViewTextBoxColumn.DataPropertyName = "CREATOR"
        Me.CREATORDataGridViewTextBoxColumn.FillWeight = 118.0!
        Me.CREATORDataGridViewTextBoxColumn.HeaderText = "CREATOR"
        Me.CREATORDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CREATORDataGridViewTextBoxColumn.Name = "CREATORDataGridViewTextBoxColumn"
        Me.CREATORDataGridViewTextBoxColumn.Width = 118
        '
        'PRODCODEDataGridViewTextBoxColumn
        '
        Me.PRODCODEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PRODCODEDataGridViewTextBoxColumn.DataPropertyName = "PRODCODE"
        Me.PRODCODEDataGridViewTextBoxColumn.FillWeight = 32.42976!
        Me.PRODCODEDataGridViewTextBoxColumn.HeaderText = "PRODUCT CODE"
        Me.PRODCODEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PRODCODEDataGridViewTextBoxColumn.Name = "PRODCODEDataGridViewTextBoxColumn"
        '
        'EXPRODBindingSource
        '
        Me.EXPRODBindingSource.DataMember = "EXPROD"
        Me.EXPRODBindingSource.DataSource = Me.SOTDataSet
        '
        'SOTDataSet
        '
        Me.SOTDataSet.DataSetName = "SOTDataSet"
        Me.SOTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_createDate
        '
        Me.txt_createDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_createDate.Location = New System.Drawing.Point(60, 32)
        Me.txt_createDate.Name = "txt_createDate"
        Me.txt_createDate.ReadOnly = True
        Me.txt_createDate.Size = New System.Drawing.Size(142, 24)
        Me.txt_createDate.TabIndex = 2
        '
        'txt_creator
        '
        Me.txt_creator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_creator.Location = New System.Drawing.Point(208, 32)
        Me.txt_creator.Name = "txt_creator"
        Me.txt_creator.ReadOnly = True
        Me.txt_creator.Size = New System.Drawing.Size(110, 24)
        Me.txt_creator.TabIndex = 3
        '
        'txt_prodCode
        '
        Me.txt_prodCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_prodCode.Location = New System.Drawing.Point(324, 32)
        Me.txt_prodCode.Name = "txt_prodCode"
        Me.txt_prodCode.Size = New System.Drawing.Size(453, 24)
        Me.txt_prodCode.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(60, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CREATE DATE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(208, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "CREATOR"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_prodCode
        '
        Me.lbl_prodCode.AutoSize = True
        Me.lbl_prodCode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_prodCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_prodCode.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbl_prodCode.Location = New System.Drawing.Point(324, 0)
        Me.lbl_prodCode.Name = "lbl_prodCode"
        Me.lbl_prodCode.Size = New System.Drawing.Size(453, 29)
        Me.lbl_prodCode.TabIndex = 7
        Me.lbl_prodCode.Text = "PRODUCT CODE (*)"
        Me.lbl_prodCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.White
        Me.btn_search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_search.Image = Global.Excluded_Product.My.Resources.Resources.search1
        Me.btn_search.Location = New System.Drawing.Point(3, 3)
        Me.btn_search.Name = "btn_search"
        Me.TableLayoutPanel2.SetRowSpan(Me.btn_search, 2)
        Me.btn_search.Size = New System.Drawing.Size(51, 49)
        Me.btn_search.TabIndex = 8
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'remarks
        '
        Me.remarks.BackColor = System.Drawing.Color.WhiteSmoke
        Me.remarks.Controls.Add(Me.TableLayoutPanel3)
        Me.remarks.Location = New System.Drawing.Point(4, 27)
        Me.remarks.Name = "remarks"
        Me.remarks.Padding = New System.Windows.Forms.Padding(3)
        Me.remarks.Size = New System.Drawing.Size(786, 346)
        Me.remarks.TabIndex = 1
        Me.remarks.Text = "REMARKS"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 459.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.DataGridView2, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_createDate_remarks, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_creator_remarks, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_remarks, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_remarks, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_search_remarks, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(780, 340)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TableLayoutPanel3.SetColumnSpan(Me.DataGridView2, 4)
        Me.DataGridView2.DataSource = Me.REMARKSBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.Color.DeepSkyBlue
        Me.DataGridView2.Location = New System.Drawing.Point(3, 58)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.RowTemplate.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.ShowCellErrors = False
        Me.DataGridView2.ShowCellToolTips = False
        Me.DataGridView2.ShowEditingIcon = False
        Me.DataGridView2.ShowRowErrors = False
        Me.DataGridView2.Size = New System.Drawing.Size(774, 279)
        Me.DataGridView2.TabIndex = 1
        Me.DataGridView2.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CREATEDATE"
        DataGridViewCellStyle8.Format = "dd/MM/yyyy HH:mm:ss"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.FillWeight = 148.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "CREATE DATE"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 148
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CREATOR"
        Me.DataGridViewTextBoxColumn2.FillWeight = 118.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "CREATOR"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 118
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "REMARKS"
        Me.DataGridViewTextBoxColumn3.HeaderText = "REMARKS"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'REMARKSBindingSource
        '
        Me.REMARKSBindingSource.DataMember = "REMARKS"
        Me.REMARKSBindingSource.DataSource = Me.SOTDataSet
        '
        'txt_createDate_remarks
        '
        Me.txt_createDate_remarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_createDate_remarks.Location = New System.Drawing.Point(60, 32)
        Me.txt_createDate_remarks.Name = "txt_createDate_remarks"
        Me.txt_createDate_remarks.ReadOnly = True
        Me.txt_createDate_remarks.Size = New System.Drawing.Size(142, 24)
        Me.txt_createDate_remarks.TabIndex = 2
        '
        'txt_creator_remarks
        '
        Me.txt_creator_remarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_creator_remarks.Location = New System.Drawing.Point(208, 32)
        Me.txt_creator_remarks.Name = "txt_creator_remarks"
        Me.txt_creator_remarks.ReadOnly = True
        Me.txt_creator_remarks.Size = New System.Drawing.Size(110, 24)
        Me.txt_creator_remarks.TabIndex = 3
        '
        'txt_remarks
        '
        Me.txt_remarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_remarks.Location = New System.Drawing.Point(324, 32)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(453, 24)
        Me.txt_remarks.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(60, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CREATE DATE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(208, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 29)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "CREATOR"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_remarks
        '
        Me.lbl_remarks.AutoSize = True
        Me.lbl_remarks.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_remarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_remarks.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_remarks.Location = New System.Drawing.Point(324, 0)
        Me.lbl_remarks.Name = "lbl_remarks"
        Me.lbl_remarks.Size = New System.Drawing.Size(453, 29)
        Me.lbl_remarks.TabIndex = 7
        Me.lbl_remarks.Text = "REMARKS (*)"
        Me.lbl_remarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_search_remarks
        '
        Me.btn_search_remarks.BackColor = System.Drawing.Color.White
        Me.btn_search_remarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_search_remarks.Image = Global.Excluded_Product.My.Resources.Resources.search1
        Me.btn_search_remarks.Location = New System.Drawing.Point(3, 3)
        Me.btn_search_remarks.Name = "btn_search_remarks"
        Me.TableLayoutPanel3.SetRowSpan(Me.btn_search_remarks, 2)
        Me.btn_search_remarks.Size = New System.Drawing.Size(51, 49)
        Me.btn_search_remarks.TabIndex = 8
        Me.btn_search_remarks.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(704, 3)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(93, 40)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(603, 3)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(94, 40)
        Me.btn_update.TabIndex = 2
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(488, 46)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "TECHLINK SOLICONES (VIETNAM) LTD"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Location = New System.Drawing.Point(497, 3)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(100, 40)
        Me.btn_add.TabIndex = 11
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'EXPRODTableAdapter
        '
        Me.EXPRODTableAdapter.ClearBeforeFill = True
        '
        'REMARKSTableAdapter
        '
        Me.REMARKSTableAdapter.ClearBeforeFill = True
        '
        'Excluded_items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Excluded_items"
        Me.Text = "Excluded Product Items and Remarks"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.prodCode.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXPRODBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SOTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.remarks.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REMARKSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents prodCode As TabPage
    Friend WithEvents remarks As TabPage
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents SOTDataSet As SOTDataSet
    Friend WithEvents EXPRODBindingSource As BindingSource
    Friend WithEvents EXPRODTableAdapter As SOTDataSetTableAdapters.EXPRODTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_createDate As TextBox
    Friend WithEvents txt_creator As TextBox
    Friend WithEvents txt_prodCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_prodCode As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents CREATEDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CREATORDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRODCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btn_search As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txt_createDate_remarks As TextBox
    Friend WithEvents txt_creator_remarks As TextBox
    Friend WithEvents txt_remarks As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_remarks As Label
    Friend WithEvents btn_search_remarks As Button
    Friend WithEvents REMARKSBindingSource As BindingSource
    Friend WithEvents REMARKSTableAdapter As SOTDataSetTableAdapters.REMARKSTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class

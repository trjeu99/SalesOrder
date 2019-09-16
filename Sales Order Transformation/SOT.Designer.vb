<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SOT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SOT))
        Me.tab_control = New System.Windows.Forms.TabControl()
        Me.tab_mutiable = New System.Windows.Forms.TabPage()
        Me.src_connection = New System.Windows.Forms.GroupBox()
        Me.src_btn_test = New System.Windows.Forms.Button()
        Me.txt_src_db = New System.Windows.Forms.TextBox()
        Me.txt_src_pw = New System.Windows.Forms.TextBox()
        Me.txt_src_usrname = New System.Windows.Forms.TextBox()
        Me.txt_src_port = New System.Windows.Forms.TextBox()
        Me.txt_src_hostname = New System.Windows.Forms.TextBox()
        Me.src_db = New System.Windows.Forms.Label()
        Me.src_pw = New System.Windows.Forms.Label()
        Me.src_usrname = New System.Windows.Forms.Label()
        Me.src_port = New System.Windows.Forms.Label()
        Me.src_hostname = New System.Windows.Forms.Label()
        Me.tab_workflow = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tar_btn_test = New System.Windows.Forms.Button()
        Me.txt_tar_db = New System.Windows.Forms.TextBox()
        Me.txt_tar_pw = New System.Windows.Forms.TextBox()
        Me.txt_tar_usrname = New System.Windows.Forms.TextBox()
        Me.txt_tar_port = New System.Windows.Forms.TextBox()
        Me.txt_tar_hostname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tab_usr_settings = New System.Windows.Forms.TabPage()
        Me.btn_email_test = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_recipients = New System.Windows.Forms.RichTextBox()
        Me.txt_sender_pw = New System.Windows.Forms.TextBox()
        Me.txt_sender = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tab_schedule = New System.Windows.Forms.TabPage()
        Me.txt_spt = New System.Windows.Forms.MaskedTextBox()
        Me.txt_int_min = New System.Windows.Forms.MaskedTextBox()
        Me.txt_int_hrs = New System.Windows.Forms.MaskedTextBox()
        Me.txt_int_day = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.grp_process_sts = New System.Windows.Forms.GroupBox()
        Me.lbl_next_trigger = New System.Windows.Forms.Label()
        Me.lbl_data_trans = New System.Windows.Forms.Label()
        Me.prb_next_trigger = New System.Windows.Forms.ProgressBar()
        Me.prb_data_trans = New System.Windows.Forms.ProgressBar()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_eventlogs = New System.Windows.Forms.GroupBox()
        Me.txt_elogs = New System.Windows.Forms.RichTextBox()
        Me.tmr_schedule = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_next_trigger = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BW = New System.ComponentModel.BackgroundWorker()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.rightMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuItemShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItemExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.tab_control.SuspendLayout()
        Me.tab_mutiable.SuspendLayout()
        Me.src_connection.SuspendLayout()
        Me.tab_workflow.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tab_usr_settings.SuspendLayout()
        Me.tab_schedule.SuspendLayout()
        Me.grp_process_sts.SuspendLayout()
        Me.lbl_eventlogs.SuspendLayout()
        Me.rightMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_control
        '
        Me.tab_control.Controls.Add(Me.tab_mutiable)
        Me.tab_control.Controls.Add(Me.tab_workflow)
        Me.tab_control.Controls.Add(Me.tab_usr_settings)
        Me.tab_control.Controls.Add(Me.tab_schedule)
        Me.tab_control.Location = New System.Drawing.Point(2, 0)
        Me.tab_control.Name = "tab_control"
        Me.tab_control.SelectedIndex = 0
        Me.tab_control.Size = New System.Drawing.Size(357, 282)
        Me.tab_control.TabIndex = 0
        '
        'tab_mutiable
        '
        Me.tab_mutiable.Controls.Add(Me.src_connection)
        Me.tab_mutiable.Location = New System.Drawing.Point(4, 25)
        Me.tab_mutiable.Name = "tab_mutiable"
        Me.tab_mutiable.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_mutiable.Size = New System.Drawing.Size(349, 253)
        Me.tab_mutiable.TabIndex = 0
        Me.tab_mutiable.Text = "Multiable"
        Me.tab_mutiable.UseVisualStyleBackColor = True
        '
        'src_connection
        '
        Me.src_connection.Controls.Add(Me.src_btn_test)
        Me.src_connection.Controls.Add(Me.txt_src_db)
        Me.src_connection.Controls.Add(Me.txt_src_pw)
        Me.src_connection.Controls.Add(Me.txt_src_usrname)
        Me.src_connection.Controls.Add(Me.txt_src_port)
        Me.src_connection.Controls.Add(Me.txt_src_hostname)
        Me.src_connection.Controls.Add(Me.src_db)
        Me.src_connection.Controls.Add(Me.src_pw)
        Me.src_connection.Controls.Add(Me.src_usrname)
        Me.src_connection.Controls.Add(Me.src_port)
        Me.src_connection.Controls.Add(Me.src_hostname)
        Me.src_connection.Location = New System.Drawing.Point(16, 14)
        Me.src_connection.Name = "src_connection"
        Me.src_connection.Size = New System.Drawing.Size(314, 229)
        Me.src_connection.TabIndex = 5
        Me.src_connection.TabStop = False
        Me.src_connection.Text = "Connection"
        '
        'src_btn_test
        '
        Me.src_btn_test.Location = New System.Drawing.Point(161, 171)
        Me.src_btn_test.Name = "src_btn_test"
        Me.src_btn_test.Size = New System.Drawing.Size(131, 34)
        Me.src_btn_test.TabIndex = 9
        Me.src_btn_test.Text = "Test Connection"
        Me.src_btn_test.UseVisualStyleBackColor = True
        '
        'txt_src_db
        '
        Me.txt_src_db.Location = New System.Drawing.Point(105, 143)
        Me.txt_src_db.Name = "txt_src_db"
        Me.txt_src_db.Size = New System.Drawing.Size(187, 22)
        Me.txt_src_db.TabIndex = 9
        '
        'txt_src_pw
        '
        Me.txt_src_pw.Location = New System.Drawing.Point(105, 115)
        Me.txt_src_pw.Name = "txt_src_pw"
        Me.txt_src_pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_src_pw.Size = New System.Drawing.Size(187, 22)
        Me.txt_src_pw.TabIndex = 8
        '
        'txt_src_usrname
        '
        Me.txt_src_usrname.Location = New System.Drawing.Point(105, 89)
        Me.txt_src_usrname.Name = "txt_src_usrname"
        Me.txt_src_usrname.Size = New System.Drawing.Size(187, 22)
        Me.txt_src_usrname.TabIndex = 7
        '
        'txt_src_port
        '
        Me.txt_src_port.Location = New System.Drawing.Point(105, 63)
        Me.txt_src_port.Name = "txt_src_port"
        Me.txt_src_port.Size = New System.Drawing.Size(187, 22)
        Me.txt_src_port.TabIndex = 6
        '
        'txt_src_hostname
        '
        Me.txt_src_hostname.Location = New System.Drawing.Point(105, 37)
        Me.txt_src_hostname.Name = "txt_src_hostname"
        Me.txt_src_hostname.Size = New System.Drawing.Size(187, 22)
        Me.txt_src_hostname.TabIndex = 5
        '
        'src_db
        '
        Me.src_db.AutoSize = True
        Me.src_db.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.src_db.Location = New System.Drawing.Point(26, 144)
        Me.src_db.Name = "src_db"
        Me.src_db.Size = New System.Drawing.Size(73, 17)
        Me.src_db.TabIndex = 4
        Me.src_db.Text = "Database:"
        '
        'src_pw
        '
        Me.src_pw.AutoSize = True
        Me.src_pw.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.src_pw.Location = New System.Drawing.Point(26, 118)
        Me.src_pw.Name = "src_pw"
        Me.src_pw.Size = New System.Drawing.Size(73, 17)
        Me.src_pw.TabIndex = 3
        Me.src_pw.Text = "Password:"
        '
        'src_usrname
        '
        Me.src_usrname.AutoSize = True
        Me.src_usrname.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.src_usrname.Location = New System.Drawing.Point(22, 92)
        Me.src_usrname.Name = "src_usrname"
        Me.src_usrname.Size = New System.Drawing.Size(77, 17)
        Me.src_usrname.TabIndex = 2
        Me.src_usrname.Text = "Username:"
        '
        'src_port
        '
        Me.src_port.AutoSize = True
        Me.src_port.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.src_port.Location = New System.Drawing.Point(61, 66)
        Me.src_port.Name = "src_port"
        Me.src_port.Size = New System.Drawing.Size(38, 17)
        Me.src_port.TabIndex = 1
        Me.src_port.Text = "Port:"
        '
        'src_hostname
        '
        Me.src_hostname.AutoSize = True
        Me.src_hostname.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.src_hostname.Location = New System.Drawing.Point(23, 40)
        Me.src_hostname.Name = "src_hostname"
        Me.src_hostname.Size = New System.Drawing.Size(76, 17)
        Me.src_hostname.TabIndex = 0
        Me.src_hostname.Text = "Hostname:"
        '
        'tab_workflow
        '
        Me.tab_workflow.Controls.Add(Me.GroupBox1)
        Me.tab_workflow.Location = New System.Drawing.Point(4, 25)
        Me.tab_workflow.Name = "tab_workflow"
        Me.tab_workflow.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_workflow.Size = New System.Drawing.Size(349, 253)
        Me.tab_workflow.TabIndex = 1
        Me.tab_workflow.Text = "Workflow"
        Me.tab_workflow.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tar_btn_test)
        Me.GroupBox1.Controls.Add(Me.txt_tar_db)
        Me.GroupBox1.Controls.Add(Me.txt_tar_pw)
        Me.GroupBox1.Controls.Add(Me.txt_tar_usrname)
        Me.GroupBox1.Controls.Add(Me.txt_tar_port)
        Me.GroupBox1.Controls.Add(Me.txt_tar_hostname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 229)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection"
        '
        'tar_btn_test
        '
        Me.tar_btn_test.Location = New System.Drawing.Point(161, 171)
        Me.tar_btn_test.Name = "tar_btn_test"
        Me.tar_btn_test.Size = New System.Drawing.Size(131, 34)
        Me.tar_btn_test.TabIndex = 9
        Me.tar_btn_test.Text = "Test Connection"
        Me.tar_btn_test.UseVisualStyleBackColor = True
        '
        'txt_tar_db
        '
        Me.txt_tar_db.Location = New System.Drawing.Point(105, 143)
        Me.txt_tar_db.Name = "txt_tar_db"
        Me.txt_tar_db.Size = New System.Drawing.Size(187, 22)
        Me.txt_tar_db.TabIndex = 9
        '
        'txt_tar_pw
        '
        Me.txt_tar_pw.Location = New System.Drawing.Point(105, 115)
        Me.txt_tar_pw.Name = "txt_tar_pw"
        Me.txt_tar_pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_tar_pw.Size = New System.Drawing.Size(187, 22)
        Me.txt_tar_pw.TabIndex = 8
        '
        'txt_tar_usrname
        '
        Me.txt_tar_usrname.Location = New System.Drawing.Point(105, 89)
        Me.txt_tar_usrname.Name = "txt_tar_usrname"
        Me.txt_tar_usrname.Size = New System.Drawing.Size(187, 22)
        Me.txt_tar_usrname.TabIndex = 7
        '
        'txt_tar_port
        '
        Me.txt_tar_port.Location = New System.Drawing.Point(105, 63)
        Me.txt_tar_port.Name = "txt_tar_port"
        Me.txt_tar_port.Size = New System.Drawing.Size(187, 22)
        Me.txt_tar_port.TabIndex = 6
        '
        'txt_tar_hostname
        '
        Me.txt_tar_hostname.Location = New System.Drawing.Point(105, 37)
        Me.txt_tar_hostname.Name = "txt_tar_hostname"
        Me.txt_tar_hostname.Size = New System.Drawing.Size(187, 22)
        Me.txt_tar_hostname.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Database:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Port:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Hostname:"
        '
        'tab_usr_settings
        '
        Me.tab_usr_settings.Controls.Add(Me.btn_email_test)
        Me.tab_usr_settings.Controls.Add(Me.Label12)
        Me.tab_usr_settings.Controls.Add(Me.txt_recipients)
        Me.tab_usr_settings.Controls.Add(Me.txt_sender_pw)
        Me.tab_usr_settings.Controls.Add(Me.txt_sender)
        Me.tab_usr_settings.Controls.Add(Me.Label10)
        Me.tab_usr_settings.Controls.Add(Me.Label11)
        Me.tab_usr_settings.Location = New System.Drawing.Point(4, 25)
        Me.tab_usr_settings.Name = "tab_usr_settings"
        Me.tab_usr_settings.Size = New System.Drawing.Size(349, 253)
        Me.tab_usr_settings.TabIndex = 2
        Me.tab_usr_settings.Text = "User Settings"
        Me.tab_usr_settings.UseVisualStyleBackColor = True
        '
        'btn_email_test
        '
        Me.btn_email_test.Location = New System.Drawing.Point(261, 39)
        Me.btn_email_test.Name = "btn_email_test"
        Me.btn_email_test.Size = New System.Drawing.Size(75, 26)
        Me.btn_email_test.TabIndex = 15
        Me.btn_email_test.Text = "Test"
        Me.btn_email_test.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(312, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "List of recipient: (Please type one email per line)"
        '
        'txt_recipients
        '
        Me.txt_recipients.Location = New System.Drawing.Point(10, 92)
        Me.txt_recipients.Name = "txt_recipients"
        Me.txt_recipients.Size = New System.Drawing.Size(326, 151)
        Me.txt_recipients.TabIndex = 13
        Me.txt_recipients.Text = ""
        '
        'txt_sender_pw
        '
        Me.txt_sender_pw.Location = New System.Drawing.Point(117, 41)
        Me.txt_sender_pw.Name = "txt_sender_pw"
        Me.txt_sender_pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_sender_pw.Size = New System.Drawing.Size(138, 22)
        Me.txt_sender_pw.TabIndex = 12
        '
        'txt_sender
        '
        Me.txt_sender.Location = New System.Drawing.Point(117, 14)
        Me.txt_sender.Name = "txt_sender"
        Me.txt_sender.Size = New System.Drawing.Size(219, 22)
        Me.txt_sender.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(42, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Password:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 17)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Email sender:"
        '
        'tab_schedule
        '
        Me.tab_schedule.Controls.Add(Me.btn_edit)
        Me.tab_schedule.Controls.Add(Me.txt_spt)
        Me.tab_schedule.Controls.Add(Me.txt_int_min)
        Me.tab_schedule.Controls.Add(Me.txt_int_hrs)
        Me.tab_schedule.Controls.Add(Me.txt_int_day)
        Me.tab_schedule.Controls.Add(Me.Label15)
        Me.tab_schedule.Controls.Add(Me.Label14)
        Me.tab_schedule.Controls.Add(Me.Label13)
        Me.tab_schedule.Controls.Add(Me.btn_stop)
        Me.tab_schedule.Controls.Add(Me.grp_process_sts)
        Me.tab_schedule.Controls.Add(Me.btn_start)
        Me.tab_schedule.Controls.Add(Me.Label7)
        Me.tab_schedule.Controls.Add(Me.Label6)
        Me.tab_schedule.Location = New System.Drawing.Point(4, 25)
        Me.tab_schedule.Name = "tab_schedule"
        Me.tab_schedule.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_schedule.Size = New System.Drawing.Size(349, 253)
        Me.tab_schedule.TabIndex = 3
        Me.tab_schedule.Text = "Schedule"
        Me.tab_schedule.UseVisualStyleBackColor = True
        '
        'txt_spt
        '
        Me.txt_spt.Location = New System.Drawing.Point(95, 14)
        Me.txt_spt.Mask = "0000-00-00 00:00:00.000"
        Me.txt_spt.Name = "txt_spt"
        Me.txt_spt.Size = New System.Drawing.Size(236, 22)
        Me.txt_spt.TabIndex = 15
        '
        'txt_int_min
        '
        Me.txt_int_min.Location = New System.Drawing.Point(243, 47)
        Me.txt_int_min.Mask = "00"
        Me.txt_int_min.Name = "txt_int_min"
        Me.txt_int_min.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_int_min.Size = New System.Drawing.Size(26, 22)
        Me.txt_int_min.TabIndex = 14
        Me.txt_int_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_int_min.ValidatingType = GetType(Integer)
        '
        'txt_int_hrs
        '
        Me.txt_int_hrs.Location = New System.Drawing.Point(166, 47)
        Me.txt_int_hrs.Mask = "00"
        Me.txt_int_hrs.Name = "txt_int_hrs"
        Me.txt_int_hrs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_int_hrs.Size = New System.Drawing.Size(26, 22)
        Me.txt_int_hrs.TabIndex = 13
        Me.txt_int_hrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_int_hrs.ValidatingType = GetType(Integer)
        '
        'txt_int_day
        '
        Me.txt_int_day.Location = New System.Drawing.Point(95, 47)
        Me.txt_int_day.Mask = "00"
        Me.txt_int_day.Name = "txt_int_day"
        Me.txt_int_day.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_int_day.Size = New System.Drawing.Size(26, 22)
        Me.txt_int_day.TabIndex = 1
        Me.txt_int_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_int_day.ValidatingType = GetType(Integer)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(127, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 17)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Day"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(275, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 17)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Minute"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(198, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 17)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Hour"
        '
        'btn_stop
        '
        Me.btn_stop.Location = New System.Drawing.Point(222, 85)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(109, 29)
        Me.btn_stop.TabIndex = 6
        Me.btn_stop.Text = "Stop"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'grp_process_sts
        '
        Me.grp_process_sts.Controls.Add(Me.lbl_next_trigger)
        Me.grp_process_sts.Controls.Add(Me.lbl_data_trans)
        Me.grp_process_sts.Controls.Add(Me.prb_next_trigger)
        Me.grp_process_sts.Controls.Add(Me.prb_data_trans)
        Me.grp_process_sts.Location = New System.Drawing.Point(3, 122)
        Me.grp_process_sts.Name = "grp_process_sts"
        Me.grp_process_sts.Size = New System.Drawing.Size(342, 113)
        Me.grp_process_sts.TabIndex = 5
        Me.grp_process_sts.TabStop = False
        Me.grp_process_sts.Text = "Process status"
        '
        'lbl_next_trigger
        '
        Me.lbl_next_trigger.AutoSize = True
        Me.lbl_next_trigger.Location = New System.Drawing.Point(6, 68)
        Me.lbl_next_trigger.Name = "lbl_next_trigger"
        Me.lbl_next_trigger.Size = New System.Drawing.Size(85, 17)
        Me.lbl_next_trigger.TabIndex = 7
        Me.lbl_next_trigger.Text = "Next trigger:"
        '
        'lbl_data_trans
        '
        Me.lbl_data_trans.AutoSize = True
        Me.lbl_data_trans.Location = New System.Drawing.Point(13, 38)
        Me.lbl_data_trans.Name = "lbl_data_trans"
        Me.lbl_data_trans.Size = New System.Drawing.Size(78, 17)
        Me.lbl_data_trans.TabIndex = 6
        Me.lbl_data_trans.Text = "Data trans:"
        '
        'prb_next_trigger
        '
        Me.prb_next_trigger.Location = New System.Drawing.Point(92, 65)
        Me.prb_next_trigger.Name = "prb_next_trigger"
        Me.prb_next_trigger.Size = New System.Drawing.Size(236, 23)
        Me.prb_next_trigger.Step = 1
        Me.prb_next_trigger.TabIndex = 1
        '
        'prb_data_trans
        '
        Me.prb_data_trans.Location = New System.Drawing.Point(92, 35)
        Me.prb_data_trans.MarqueeAnimationSpeed = 1000
        Me.prb_data_trans.Name = "prb_data_trans"
        Me.prb_data_trans.Size = New System.Drawing.Size(236, 23)
        Me.prb_data_trans.TabIndex = 0
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(95, 85)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(109, 29)
        Me.btn_start.TabIndex = 4
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Interval:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Start point:"
        '
        'lbl_eventlogs
        '
        Me.lbl_eventlogs.Controls.Add(Me.txt_elogs)
        Me.lbl_eventlogs.Location = New System.Drawing.Point(359, 0)
        Me.lbl_eventlogs.Name = "lbl_eventlogs"
        Me.lbl_eventlogs.Size = New System.Drawing.Size(570, 282)
        Me.lbl_eventlogs.TabIndex = 7
        Me.lbl_eventlogs.TabStop = False
        Me.lbl_eventlogs.Text = "Event Logs"
        '
        'txt_elogs
        '
        Me.txt_elogs.HideSelection = False
        Me.txt_elogs.Location = New System.Drawing.Point(6, 21)
        Me.txt_elogs.Name = "txt_elogs"
        Me.txt_elogs.ReadOnly = True
        Me.txt_elogs.Size = New System.Drawing.Size(558, 247)
        Me.txt_elogs.TabIndex = 0
        Me.txt_elogs.Text = ""
        '
        'tmr_schedule
        '
        '
        'tmr_next_trigger
        '
        Me.tmr_next_trigger.Interval = 1000
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(666, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Copyright © TECH-LINK SILICONES (VN) LTD | Software support: support@mandigi.vn |" &
    " Mandigi Co., Ltd"
        '
        'BW
        '
        Me.BW.WorkerReportsProgress = True
        Me.BW.WorkerSupportsCancellation = True
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.rightMenu
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "Sales Orders Transformation"
        Me.NotifyIcon.Visible = True
        '
        'rightMenu
        '
        Me.rightMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.rightMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemShow, Me.ToolStripSeparator1, Me.MenuItemExit})
        Me.rightMenu.Name = "ContextMenuStrip"
        Me.rightMenu.Size = New System.Drawing.Size(115, 58)
        '
        'MenuItemShow
        '
        Me.MenuItemShow.Name = "MenuItemShow"
        Me.MenuItemShow.Size = New System.Drawing.Size(114, 24)
        Me.MenuItemShow.Text = "Show"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(111, 6)
        '
        'MenuItemExit
        '
        Me.MenuItemExit.Name = "MenuItemExit"
        Me.MenuItemExit.Size = New System.Drawing.Size(114, 24)
        Me.MenuItemExit.Text = "Exit"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(12, 85)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(65, 29)
        Me.btn_edit.TabIndex = 16
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'SOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(931, 307)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_eventlogs)
        Me.Controls.Add(Me.tab_control)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SOT"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Order Transformation"
        Me.tab_control.ResumeLayout(False)
        Me.tab_mutiable.ResumeLayout(False)
        Me.src_connection.ResumeLayout(False)
        Me.src_connection.PerformLayout()
        Me.tab_workflow.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tab_usr_settings.ResumeLayout(False)
        Me.tab_usr_settings.PerformLayout()
        Me.tab_schedule.ResumeLayout(False)
        Me.tab_schedule.PerformLayout()
        Me.grp_process_sts.ResumeLayout(False)
        Me.grp_process_sts.PerformLayout()
        Me.lbl_eventlogs.ResumeLayout(False)
        Me.rightMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tab_control As TabControl
    Friend WithEvents tab_mutiable As TabPage
    Friend WithEvents src_hostname As Label
    Friend WithEvents tab_workflow As TabPage
    Friend WithEvents tab_usr_settings As TabPage
    Friend WithEvents src_port As Label
    Friend WithEvents src_connection As GroupBox
    Friend WithEvents src_db As Label
    Friend WithEvents src_pw As Label
    Friend WithEvents src_usrname As Label
    Friend WithEvents txt_src_hostname As TextBox
    Friend WithEvents txt_src_db As TextBox
    Friend WithEvents txt_src_pw As TextBox
    Friend WithEvents txt_src_port As TextBox
    Friend WithEvents txt_src_usrname As TextBox
    Friend WithEvents src_btn_test As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tar_btn_test As Button
    Friend WithEvents txt_tar_db As TextBox
    Friend WithEvents txt_tar_pw As TextBox
    Friend WithEvents txt_tar_usrname As TextBox
    Friend WithEvents txt_tar_port As TextBox
    Friend WithEvents txt_tar_hostname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tab_schedule As TabPage
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_start As Button
    Friend WithEvents grp_process_sts As GroupBox
    Friend WithEvents lbl_next_trigger As Label
    Friend WithEvents lbl_data_trans As Label
    Friend WithEvents prb_next_trigger As ProgressBar
    Friend WithEvents prb_data_trans As ProgressBar
    Friend WithEvents txt_sender_pw As TextBox
    Friend WithEvents txt_sender As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_eventlogs As GroupBox
    Friend WithEvents txt_elogs As RichTextBox
    Friend WithEvents btn_email_test As Button
    Friend WithEvents txt_recipients As RichTextBox
    Friend WithEvents btn_stop As Button
    Friend WithEvents tmr_schedule As Timer
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_int_min As MaskedTextBox
    Friend WithEvents txt_int_hrs As MaskedTextBox
    Friend WithEvents txt_int_day As MaskedTextBox
    Friend WithEvents tmr_next_trigger As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents rightMenu As ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents MenuItemShow As ToolStripMenuItem
    Friend WithEvents MenuItemExit As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txt_spt As MaskedTextBox
    Friend WithEvents btn_edit As Button
End Class

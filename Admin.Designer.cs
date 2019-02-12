namespace Курсовой_проект
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.actionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dekanatDataSetlog = new Курсовой_проект.dekanatDataSetlog();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.errorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentUserDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dekanatDataSeterr = new Курсовой_проект.dekanatDataSeterr();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passhexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winAccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dekanatDataSetusers = new Курсовой_проект.dekanatDataSetusers();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.usersTableAdapter1 = new Курсовой_проект.dekanatDataSetusersTableAdapters.UsersTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.logTableAdapter = new Курсовой_проект.dekanatDataSetlogTableAdapters.LogTableAdapter();
            this.dekanatDataSetlogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorLogTableAdapter = new Курсовой_проект.dekanatDataSeterrTableAdapters.ErrorLogTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dekanatDataSetus = new Курсовой_проект.dekanatDataSetus();
            this.usersTableAdapter = new Курсовой_проект.dekanatDataSetusTableAdapters.UsersTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatDataSetlog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatDataSeterr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatDataSetusers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatDataSetlogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatDataSetus)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1158, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Logs:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actionIDDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.currentUserDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(600, 300);
            this.dataGridView1.TabIndex = 6;
            // 
            // actionIDDataGridViewTextBoxColumn
            // 
            this.actionIDDataGridViewTextBoxColumn.DataPropertyName = "ActionID";
            this.actionIDDataGridViewTextBoxColumn.HeaderText = "ActionID";
            this.actionIDDataGridViewTextBoxColumn.Name = "actionIDDataGridViewTextBoxColumn";
            this.actionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.actionIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 120;
            // 
            // currentUserDataGridViewTextBoxColumn
            // 
            this.currentUserDataGridViewTextBoxColumn.DataPropertyName = "CurrentUser";
            this.currentUserDataGridViewTextBoxColumn.HeaderText = "CurrentUser";
            this.currentUserDataGridViewTextBoxColumn.Name = "currentUserDataGridViewTextBoxColumn";
            this.currentUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentUserDataGridViewTextBoxColumn.Width = 110;
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            this.actionDataGridViewTextBoxColumn.ReadOnly = true;
            this.actionDataGridViewTextBoxColumn.Width = 250;
            // 
            // logBindingSource
            // 
            this.logBindingSource.DataMember = "Log";
            this.logBindingSource.DataSource = this.dekanatDataSetlog;
            // 
            // dekanatDataSetlog
            // 
            this.dekanatDataSetlog.DataSetName = "dekanatDataSetlog";
            this.dekanatDataSetlog.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.errorIDDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn1,
            this.currentUserDataGridViewTextBoxColumn1,
            this.errorLogDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.errorLogBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(652, 102);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(600, 300);
            this.dataGridView2.TabIndex = 7;
            // 
            // errorIDDataGridViewTextBoxColumn
            // 
            this.errorIDDataGridViewTextBoxColumn.DataPropertyName = "ErrorID";
            this.errorIDDataGridViewTextBoxColumn.HeaderText = "ErrorID";
            this.errorIDDataGridViewTextBoxColumn.Name = "errorIDDataGridViewTextBoxColumn";
            this.errorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.errorIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // timeDataGridViewTextBoxColumn1
            // 
            this.timeDataGridViewTextBoxColumn1.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn1.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn1.Name = "timeDataGridViewTextBoxColumn1";
            this.timeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn1.Width = 120;
            // 
            // currentUserDataGridViewTextBoxColumn1
            // 
            this.currentUserDataGridViewTextBoxColumn1.DataPropertyName = "CurrentUser";
            this.currentUserDataGridViewTextBoxColumn1.HeaderText = "CurrentUser";
            this.currentUserDataGridViewTextBoxColumn1.Name = "currentUserDataGridViewTextBoxColumn1";
            this.currentUserDataGridViewTextBoxColumn1.ReadOnly = true;
            this.currentUserDataGridViewTextBoxColumn1.Width = 110;
            // 
            // errorLogDataGridViewTextBoxColumn
            // 
            this.errorLogDataGridViewTextBoxColumn.DataPropertyName = "ErrorLog";
            this.errorLogDataGridViewTextBoxColumn.HeaderText = "ErrorLog";
            this.errorLogDataGridViewTextBoxColumn.Name = "errorLogDataGridViewTextBoxColumn";
            this.errorLogDataGridViewTextBoxColumn.ReadOnly = true;
            this.errorLogDataGridViewTextBoxColumn.Width = 250;
            // 
            // errorLogBindingSource
            // 
            this.errorLogBindingSource.DataMember = "ErrorLog";
            this.errorLogBindingSource.DataSource = this.dekanatDataSeterr;
            // 
            // dekanatDataSeterr
            // 
            this.dekanatDataSeterr.DataSetName = "dekanatDataSeterr";
            this.dekanatDataSeterr.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1186, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Errors:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(590, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Users:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.passhexDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.Email,
            this.studentnameDataGridViewTextBoxColumn,
            this.studentgroupDataGridViewTextBoxColumn,
            this.usersGroupDataGridViewTextBoxColumn,
            this.lastLoginDataGridViewTextBoxColumn,
            this.registrationDataGridViewTextBoxColumn,
            this.winAccDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.usersBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(12, 439);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1240, 230);
            this.dataGridView3.TabIndex = 10;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.Width = 140;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "Pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "Pass";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.Width = 140;
            // 
            // passhexDataGridViewTextBoxColumn
            // 
            this.passhexDataGridViewTextBoxColumn.DataPropertyName = "Passhex";
            this.passhexDataGridViewTextBoxColumn.HeaderText = "Passhex";
            this.passhexDataGridViewTextBoxColumn.Name = "passhexDataGridViewTextBoxColumn";
            this.passhexDataGridViewTextBoxColumn.Width = 50;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 120;
            // 
            // studentnameDataGridViewTextBoxColumn
            // 
            this.studentnameDataGridViewTextBoxColumn.DataPropertyName = "Student_name";
            this.studentnameDataGridViewTextBoxColumn.HeaderText = "Student_name";
            this.studentnameDataGridViewTextBoxColumn.Name = "studentnameDataGridViewTextBoxColumn";
            // 
            // studentgroupDataGridViewTextBoxColumn
            // 
            this.studentgroupDataGridViewTextBoxColumn.DataPropertyName = "Student_group";
            this.studentgroupDataGridViewTextBoxColumn.HeaderText = "Student_group";
            this.studentgroupDataGridViewTextBoxColumn.Name = "studentgroupDataGridViewTextBoxColumn";
            this.studentgroupDataGridViewTextBoxColumn.Width = 90;
            // 
            // usersGroupDataGridViewTextBoxColumn
            // 
            this.usersGroupDataGridViewTextBoxColumn.DataPropertyName = "UsersGroup";
            this.usersGroupDataGridViewTextBoxColumn.HeaderText = "UsersGroup";
            this.usersGroupDataGridViewTextBoxColumn.Name = "usersGroupDataGridViewTextBoxColumn";
            this.usersGroupDataGridViewTextBoxColumn.Width = 80;
            // 
            // lastLoginDataGridViewTextBoxColumn
            // 
            this.lastLoginDataGridViewTextBoxColumn.DataPropertyName = "LastLogin";
            this.lastLoginDataGridViewTextBoxColumn.HeaderText = "LastLogin";
            this.lastLoginDataGridViewTextBoxColumn.Name = "lastLoginDataGridViewTextBoxColumn";
            this.lastLoginDataGridViewTextBoxColumn.Width = 150;
            // 
            // registrationDataGridViewTextBoxColumn
            // 
            this.registrationDataGridViewTextBoxColumn.DataPropertyName = "Registration";
            this.registrationDataGridViewTextBoxColumn.HeaderText = "Registration";
            this.registrationDataGridViewTextBoxColumn.Name = "registrationDataGridViewTextBoxColumn";
            this.registrationDataGridViewTextBoxColumn.Width = 120;
            // 
            // winAccDataGridViewTextBoxColumn
            // 
            this.winAccDataGridViewTextBoxColumn.DataPropertyName = "WinAcc";
            this.winAccDataGridViewTextBoxColumn.HeaderText = "WinAcc";
            this.winAccDataGridViewTextBoxColumn.Name = "winAccDataGridViewTextBoxColumn";
            this.winAccDataGridViewTextBoxColumn.Width = 70;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.dekanatDataSetusers;
            // 
            // dekanatDataSetusers
            // 
            this.dekanatDataSetusers.DataSetName = "dekanatDataSetusers";
            this.dekanatDataSetusers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.ForeColor = System.Drawing.Color.Red;
            this.radioButton1.Location = new System.Drawing.Point(503, 73);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(109, 28);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Вне сети";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.ForeColor = System.Drawing.Color.Lime;
            this.radioButton2.Location = new System.Drawing.Point(652, 73);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 28);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "В сети";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(499, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "База данных:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(531, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Открыть в браузере...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1047, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "Сохранить изменения";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // logTableAdapter
            // 
            this.logTableAdapter.ClearBeforeFill = true;
            // 
            // dekanatDataSetlogBindingSource
            // 
            this.dekanatDataSetlogBindingSource.DataSource = this.dekanatDataSetlog;
            this.dekanatDataSetlogBindingSource.Position = 0;
            // 
            // errorLogTableAdapter
            // 
            this.errorLogTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dekanatDataSetus;
            // 
            // dekanatDataSetus
            // 
            this.dekanatDataSetus.DataSetName = "dekanatDataSetus";
            this.dekanatDataSetus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(652, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 30);
            this.button4.TabIndex = 16;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(1081, 73);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 26);
            this.button6.TabIndex = 18;
            this.button6.Text = "Очистить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(74, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 26);
            this.button5.TabIndex = 17;
            this.button5.Text = "Очистить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(690, 410);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(236, 26);
            this.button7.TabIndex = 19;
            this.button7.Text = "Пользователь добавлен..";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "label6";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatDataSetlog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatDataSeterr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatDataSetusers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatDataSetlogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dekanatDataSetus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dekanatDataSetlog dekanatDataSetlog;
        private System.Windows.Forms.BindingSource logBindingSource;
        private dekanatDataSetlogTableAdapters.LogTableAdapter logTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource dekanatDataSetlogBindingSource;
        private dekanatDataSeterr dekanatDataSeterr;
        private System.Windows.Forms.BindingSource errorLogBindingSource;
        private dekanatDataSeterrTableAdapters.ErrorLogTableAdapter errorLogTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private dekanatDataSetus dekanatDataSetus;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private dekanatDataSetusTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentUserDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorLogDataGridViewTextBoxColumn;
        private dekanatDataSetusers dekanatDataSetusers;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private dekanatDataSetusersTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passhexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winAccDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label6;
    }
}
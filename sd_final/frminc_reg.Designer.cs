namespace sd_final
{
    partial class frminc_reg
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.gbtop = new System.Windows.Forms.GroupBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvusers = new System.Windows.Forms.DataGridView();
            this.dgvinc = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uinfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simptoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.close_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.res_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbbot = new System.Windows.Forms.GroupBox();
            this.dgvhistory = new System.Windows.Forms.DataGridView();
            this.coluser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btn_report = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbtop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinc)).BeginInit();
            this.gbbot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_report);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 31);
            this.panel1.TabIndex = 0;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(84, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "Закрыть";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(3, 4);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 23);
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "Новый";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // gbtop
            // 
            this.gbtop.Controls.Add(this.splitter2);
            this.gbtop.Controls.Add(this.groupBox1);
            this.gbtop.Controls.Add(this.dgvinc);
            this.gbtop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbtop.Location = new System.Drawing.Point(0, 31);
            this.gbtop.Name = "gbtop";
            this.gbtop.Size = new System.Drawing.Size(684, 521);
            this.gbtop.TabIndex = 2;
            this.gbtop.TabStop = false;
            this.gbtop.Text = "Инциденты";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(533, 16);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 502);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvusers);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(533, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 502);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Специалисты";
            // 
            // dgvusers
            // 
            this.dgvusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusers.ColumnHeadersVisible = false;
            this.dgvusers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvusers.Location = new System.Drawing.Point(3, 16);
            this.dgvusers.Name = "dgvusers";
            this.dgvusers.Size = new System.Drawing.Size(142, 483);
            this.dgvusers.TabIndex = 0;
            // 
            // dgvinc
            // 
            this.dgvinc.AllowUserToAddRows = false;
            this.dgvinc.AllowUserToDeleteRows = false;
            this.dgvinc.AllowUserToOrderColumns = true;
            this.dgvinc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.status,
            this.reg_date,
            this.uinfo,
            this.simptoms,
            this.Cat,
            this.close_date,
            this.res_date,
            this.problem,
            this.prior});
            this.dgvinc.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvinc.Location = new System.Drawing.Point(3, 16);
            this.dgvinc.MultiSelect = false;
            this.dgvinc.Name = "dgvinc";
            this.dgvinc.Size = new System.Drawing.Size(530, 502);
            this.dgvinc.TabIndex = 2;
            this.dgvinc.SelectionChanged += new System.EventHandler(this.dgvinc_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Статус";
            this.status.Name = "status";
            // 
            // reg_date
            // 
            this.reg_date.DataPropertyName = "reg_date";
            this.reg_date.HeaderText = "Дата регистрации";
            this.reg_date.Name = "reg_date";
            // 
            // uinfo
            // 
            this.uinfo.DataPropertyName = "uinfo";
            this.uinfo.HeaderText = "информация о пользоветеле";
            this.uinfo.Name = "uinfo";
            // 
            // simptoms
            // 
            this.simptoms.DataPropertyName = "simptoms";
            this.simptoms.HeaderText = "Симптомы";
            this.simptoms.Name = "simptoms";
            // 
            // Cat
            // 
            this.Cat.DataPropertyName = "cat";
            this.Cat.HeaderText = "Категория";
            this.Cat.Name = "Cat";
            // 
            // close_date
            // 
            this.close_date.DataPropertyName = "close_date";
            this.close_date.HeaderText = "Дата закрытия";
            this.close_date.Name = "close_date";
            // 
            // res_date
            // 
            this.res_date.DataPropertyName = "res_date";
            this.res_date.HeaderText = "дата разрешения";
            this.res_date.Name = "res_date";
            // 
            // problem
            // 
            this.problem.DataPropertyName = "problem";
            this.problem.HeaderText = "Проблема";
            this.problem.Name = "problem";
            // 
            // prior
            // 
            this.prior.DataPropertyName = "prior";
            this.prior.HeaderText = "приоритет";
            this.prior.Name = "prior";
            // 
            // gbbot
            // 
            this.gbbot.Controls.Add(this.dgvhistory);
            this.gbbot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbbot.Location = new System.Drawing.Point(0, 371);
            this.gbbot.Name = "gbbot";
            this.gbbot.Size = new System.Drawing.Size(684, 181);
            this.gbbot.TabIndex = 3;
            this.gbbot.TabStop = false;
            this.gbbot.Text = "История";
            // 
            // dgvhistory
            // 
            this.dgvhistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coluser,
            this.date,
            this.action,
            this.text});
            this.dgvhistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvhistory.Location = new System.Drawing.Point(3, 16);
            this.dgvhistory.Name = "dgvhistory";
            this.dgvhistory.Size = new System.Drawing.Size(678, 162);
            this.dgvhistory.TabIndex = 0;
            // 
            // coluser
            // 
            this.coluser.DataPropertyName = "fio";
            this.coluser.HeaderText = "пользователь";
            this.coluser.Name = "coluser";
            this.coluser.Width = 90;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            // 
            // action
            // 
            this.action.DataPropertyName = "action";
            this.action.HeaderText = "Действие";
            this.action.Name = "action";
            // 
            // text
            // 
            this.text.DataPropertyName = "a_descr";
            this.text.HeaderText = "Описание действия";
            this.text.Name = "text";
            this.text.Width = 300;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 368);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(684, 3);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(603, 3);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(75, 23);
            this.btn_report.TabIndex = 2;
            this.btn_report.Text = "KPI";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Visible = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // frminc_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 552);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.gbbot);
            this.Controls.Add(this.gbtop);
            this.Controls.Add(this.panel1);
            this.Name = "frminc_reg";
            this.Text = "Инциденты";
            this.Load += new System.EventHandler(this.frminc_reg_Load);
            this.panel1.ResumeLayout(false);
            this.gbtop.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinc)).EndInit();
            this.gbbot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.GroupBox gbtop;
        private System.Windows.Forms.DataGridView dgvinc;
        private System.Windows.Forms.GroupBox gbbot;
        private System.Windows.Forms.DataGridView dgvhistory;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvusers;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn uinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn simptoms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn close_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn res_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn problem;
        private System.Windows.Forms.DataGridViewTextBoxColumn prior;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluser;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.Button btn_report;
    }
}
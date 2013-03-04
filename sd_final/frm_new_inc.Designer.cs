namespace sd_final
{
    partial class frm_new_inc
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_cat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bnt_reg_inc = new System.Windows.Forms.Button();
            this.tb_uinfo = new System.Windows.Forms.TextBox();
            this.tb_simptoms = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_user = new System.Windows.Forms.ComboBox();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.dgusers = new System.Windows.Forms.DataGridView();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgusers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "информация о заявителе";
            // 
            // cb_cat
            // 
            this.cb_cat.FormattingEnabled = true;
            this.cb_cat.Location = new System.Drawing.Point(232, 263);
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(413, 21);
            this.cb_cat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "симптомы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Категория";
            // 
            // bnt_reg_inc
            // 
            this.bnt_reg_inc.Location = new System.Drawing.Point(12, 440);
            this.bnt_reg_inc.Name = "bnt_reg_inc";
            this.bnt_reg_inc.Size = new System.Drawing.Size(640, 23);
            this.bnt_reg_inc.TabIndex = 8;
            this.bnt_reg_inc.Text = "Зарегистрировать инцидент";
            this.bnt_reg_inc.UseVisualStyleBackColor = true;
            this.bnt_reg_inc.Click += new System.EventHandler(this.bnt_reg_inc_Click);
            // 
            // tb_uinfo
            // 
            this.tb_uinfo.Location = new System.Drawing.Point(232, 12);
            this.tb_uinfo.Multiline = true;
            this.tb_uinfo.Name = "tb_uinfo";
            this.tb_uinfo.Size = new System.Drawing.Size(413, 116);
            this.tb_uinfo.TabIndex = 9;
            // 
            // tb_simptoms
            // 
            this.tb_simptoms.Location = new System.Drawing.Point(232, 139);
            this.tb_simptoms.Multiline = true;
            this.tb_simptoms.Name = "tb_simptoms";
            this.tb_simptoms.Size = new System.Drawing.Size(413, 109);
            this.tb_simptoms.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_user);
            this.groupBox1.Controls.Add(this.btn_add_user);
            this.groupBox1.Controls.Add(this.dgusers);
            this.groupBox1.Location = new System.Drawing.Point(15, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 124);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пользователи";
            // 
            // cb_user
            // 
            this.cb_user.FormattingEnabled = true;
            this.cb_user.Location = new System.Drawing.Point(6, 19);
            this.cb_user.Name = "cb_user";
            this.cb_user.Size = new System.Drawing.Size(205, 21);
            this.cb_user.TabIndex = 14;
            // 
            // btn_add_user
            // 
            this.btn_add_user.Location = new System.Drawing.Point(6, 46);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(205, 72);
            this.btn_add_user.TabIndex = 13;
            this.btn_add_user.Text = "Добавить пользователя";
            this.btn_add_user.UseVisualStyleBackColor = true;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // dgusers
            // 
            this.dgusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgusers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fio});
            this.dgusers.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgusers.Location = new System.Drawing.Point(217, 16);
            this.dgusers.Name = "dgusers";
            this.dgusers.Size = new System.Drawing.Size(410, 105);
            this.dgusers.TabIndex = 12;
            // 
            // fio
            // 
            this.fio.DataPropertyName = "fio";
            this.fio.HeaderText = "Ответственные специалисты";
            this.fio.Name = "fio";
            this.fio.Width = 300;
            // 
            // frm_new_inc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_simptoms);
            this.Controls.Add(this.tb_uinfo);
            this.Controls.Add(this.bnt_reg_inc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_cat);
            this.Controls.Add(this.label1);
            this.Name = "frm_new_inc";
            this.Text = "Регистрация инцидента";
            this.Load += new System.EventHandler(this.frm_new_inc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgusers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_cat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnt_reg_inc;
        private System.Windows.Forms.TextBox tb_uinfo;
        private System.Windows.Forms.TextBox tb_simptoms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_user;
        private System.Windows.Forms.Button btn_add_user;
        private System.Windows.Forms.DataGridView dgusers;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
    }
}
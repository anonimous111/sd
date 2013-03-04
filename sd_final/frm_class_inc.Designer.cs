namespace sd_final
{
    partial class frm_class_inc
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
            this.dgvusers = new System.Windows.Forms.DataGridView();
            this.tb_prior = new System.Windows.Forms.TextBox();
            this.cb_problem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_des = new System.Windows.Forms.TextBox();
            this.btn_class = new System.Windows.Forms.Button();
            this.btn_add_2user = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_user = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvusers
            // 
            this.dgvusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvusers.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvusers.Location = new System.Drawing.Point(491, 0);
            this.dgvusers.Name = "dgvusers";
            this.dgvusers.Size = new System.Drawing.Size(240, 520);
            this.dgvusers.TabIndex = 0;
            this.dgvusers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusers_CellContentClick_1);
            // 
            // tb_prior
            // 
            this.tb_prior.Location = new System.Drawing.Point(119, 32);
            this.tb_prior.Name = "tb_prior";
            this.tb_prior.Size = new System.Drawing.Size(333, 20);
            this.tb_prior.TabIndex = 1;
            // 
            // cb_problem
            // 
            this.cb_problem.FormattingEnabled = true;
            this.cb_problem.Location = new System.Drawing.Point(119, 70);
            this.cb_problem.Name = "cb_problem";
            this.cb_problem.Size = new System.Drawing.Size(333, 21);
            this.cb_problem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Приоритет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Проблема";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Решение";
            // 
            // tb_des
            // 
            this.tb_des.Location = new System.Drawing.Point(13, 152);
            this.tb_des.Multiline = true;
            this.tb_des.Name = "tb_des";
            this.tb_des.Size = new System.Drawing.Size(439, 232);
            this.tb_des.TabIndex = 6;
            // 
            // btn_class
            // 
            this.btn_class.Location = new System.Drawing.Point(12, 405);
            this.btn_class.Name = "btn_class";
            this.btn_class.Size = new System.Drawing.Size(439, 23);
            this.btn_class.TabIndex = 7;
            this.btn_class.Text = "Классифицировать";
            this.btn_class.UseVisualStyleBackColor = true;
            this.btn_class.Click += new System.EventHandler(this.btn_class_Click);
            // 
            // btn_add_2user
            // 
            this.btn_add_2user.Location = new System.Drawing.Point(13, 475);
            this.btn_add_2user.Name = "btn_add_2user";
            this.btn_add_2user.Size = new System.Drawing.Size(439, 23);
            this.btn_add_2user.TabIndex = 8;
            this.btn_add_2user.Text = "Назначить специалиста 2 уровня";
            this.btn_add_2user.UseVisualStyleBackColor = true;
            this.btn_add_2user.Click += new System.EventHandler(this.btn_add_2user_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Специалист 2 уровня";
            // 
            // cb_user
            // 
            this.cb_user.FormattingEnabled = true;
            this.cb_user.Location = new System.Drawing.Point(197, 439);
            this.cb_user.Name = "cb_user";
            this.cb_user.Size = new System.Drawing.Size(254, 21);
            this.cb_user.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "fio";
            this.Column1.HeaderText = "Сторудники";
            this.Column1.Name = "Column1";
            // 
            // frm_class_inc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 520);
            this.Controls.Add(this.cb_user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_add_2user);
            this.Controls.Add(this.btn_class);
            this.Controls.Add(this.tb_des);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_problem);
            this.Controls.Add(this.tb_prior);
            this.Controls.Add(this.dgvusers);
            this.Name = "frm_class_inc";
            this.Text = "Классификация и первичная оценка";
            this.Load += new System.EventHandler(this.frm_class_inc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvusers;
        private System.Windows.Forms.TextBox tb_prior;
        private System.Windows.Forms.ComboBox cb_problem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_des;
        private System.Windows.Forms.Button btn_class;
        private System.Windows.Forms.Button btn_add_2user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
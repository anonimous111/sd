namespace sd_final
{
    partial class frm_kpi
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
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.la1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lacount = new System.Windows.Forms.Label();
            this.latime = new System.Windows.Forms.Label();
            this.lapercent = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(43, 35);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(200, 20);
            this.dtp_start.TabIndex = 0;
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(333, 35);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(200, 20);
            this.dtp_end.TabIndex = 1;
            // 
            // la1
            // 
            this.la1.AutoSize = true;
            this.la1.Location = new System.Drawing.Point(40, 9);
            this.la1.Name = "la1";
            this.la1.Size = new System.Drawing.Size(44, 13);
            this.la1.TabIndex = 2;
            this.la1.Text = "Начало";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Конец";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество инцидентов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Среднее время на разрешение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "% закрытых инцидентов на 1 уровне поддержки";
            // 
            // lacount
            // 
            this.lacount.AutoSize = true;
            this.lacount.Location = new System.Drawing.Point(300, 82);
            this.lacount.Name = "lacount";
            this.lacount.Size = new System.Drawing.Size(13, 13);
            this.lacount.TabIndex = 7;
            this.lacount.Text = "0";
            // 
            // latime
            // 
            this.latime.AutoSize = true;
            this.latime.Location = new System.Drawing.Point(300, 111);
            this.latime.Name = "latime";
            this.latime.Size = new System.Drawing.Size(13, 13);
            this.latime.TabIndex = 8;
            this.latime.Text = "0";
            // 
            // lapercent
            // 
            this.lapercent.AutoSize = true;
            this.lapercent.Location = new System.Drawing.Point(300, 135);
            this.lapercent.Name = "lapercent";
            this.lapercent.Size = new System.Drawing.Size(13, 13);
            this.lapercent.TabIndex = 9;
            this.lapercent.Text = "0";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(43, 165);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(503, 23);
            this.btn_calc.TabIndex = 10;
            this.btn_calc.Text = "Сформировать";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // frm_kpi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 217);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.lapercent);
            this.Controls.Add(this.latime);
            this.Controls.Add(this.lacount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.la1);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Name = "frm_kpi";
            this.Text = "KPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label la1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lacount;
        private System.Windows.Forms.Label latime;
        private System.Windows.Forms.Label lapercent;
        private System.Windows.Forms.Button btn_calc;
    }
}
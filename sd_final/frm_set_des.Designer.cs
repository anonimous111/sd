namespace sd_final
{
    partial class frm_set_des
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
            this.btndes = new System.Windows.Forms.Button();
            this.tb_desinfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btndes
            // 
            this.btndes.Location = new System.Drawing.Point(0, 330);
            this.btndes.Name = "btndes";
            this.btndes.Size = new System.Drawing.Size(561, 23);
            this.btndes.TabIndex = 1;
            this.btndes.Text = "Разрешить";
            this.btndes.UseVisualStyleBackColor = true;
            this.btndes.Click += new System.EventHandler(this.btndes_Click);
            // 
            // tb_desinfo
            // 
            this.tb_desinfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_desinfo.Location = new System.Drawing.Point(0, 0);
            this.tb_desinfo.Multiline = true;
            this.tb_desinfo.Name = "tb_desinfo";
            this.tb_desinfo.Size = new System.Drawing.Size(561, 315);
            this.tb_desinfo.TabIndex = 2;
            // 
            // frm_set_des
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 449);
            this.Controls.Add(this.tb_desinfo);
            this.Controls.Add(this.btndes);
            this.Name = "frm_set_des";
            this.Text = "Разрешение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndes;
        private System.Windows.Forms.TextBox tb_desinfo;
    }
}
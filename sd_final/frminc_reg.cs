using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sd_final
{
    public partial class frminc_reg : BaseIncForm
    {
        private frm_new_inc new_inc_form;
        private frm_kpi _frm_kpi;

        public frminc_reg()
        {
            InitializeComponent();
        }

        #region abstract BaseIncForm
        public override void Users_to_grid(IQueryable<Object> ds) 
        {
            dgvusers.DataSource = ds;
        }
        public override void History_to_grid(IQueryable<Object> ds)
        {
            dgvhistory.DataSource = ds;
        }
        public override void Refresh_incs()
        {
            var dsinc = from q in _controller.Model.sd_incs
                        select new
                        {
                            q.id,
                            status = q.sd_status.name,
                            q.reg_date,
                            q.uinfo,
                            q.simptoms,
                            cat = q.sd_cat.name,
                            q.res_date,
                            q.close_date,
                            problem = q.sd_problem.name,
                            q.prior
                        };
            dgvinc.DataSource = dsinc;
        }

        #endregion

        public long inc_id { get { return Convert.ToInt64(dgvinc.CurrentRow.Cells["id"].Value); } }

        private void btnnew_Click(object sender, EventArgs e)
        {
            new_inc_form = new frm_new_inc(this,_controller);
            new_inc_form.Show();
        }

        private void frminc_reg_Load(object sender, EventArgs e)
        {
            Refresh_incs();
            if (Current_User.priv == 4) 
            {
                btnclose.Visible = false;
                btnnew.Visible = false;
                btn_report.Visible = true;
            }
        }

        private void refresh_detai_grid()
        {
            try
            {
                Refresh_users(inc_id);
                Refresh_history(inc_id);
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }


        private void dgvinc_SelectionChanged(object sender, EventArgs e)
        {
            refresh_detai_grid();
            string status_temp;
            if(Current_User.priv!=4)
            {
                try
                {
                    status_temp = (dgvinc.CurrentRow.Cells["status"].Value == null) ? "" : dgvinc.CurrentRow.Cells["status"].Value.ToString();
                }
                catch
                {
                    status_temp = "";
                }            

                if (status_temp == "Разрешен") { btnclose.Visible = true; }
                else{btnclose.Visible=false;}
            }
            //MessageBox.Show("a");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрыть инцидент?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
            {
                _controller.Close_inc(inc_id);
            };
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            _frm_kpi = new frm_kpi(_controller);
            _frm_kpi.Show();
        }

    }
}

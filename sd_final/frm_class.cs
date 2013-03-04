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
    public partial class frm_class : BaseIncForm
    {
        public long inc_id { get { return Convert.ToInt64(dgvinc.CurrentRow.Cells["id"].Value); } }

        public frm_class()
        {
            InitializeComponent();
        }

        public override void Refresh_incs()
        {
            var dsinc = (from q in frmlogin.context.sd_users_on_incs
                         where q.sd_user_id == Current_User.id
                        select new
                        {
                            //q.sd_inc.sd_inc
                            q.sd_inc.id,
                            status = q.sd_inc.sd_status.name,
                            q.sd_inc.reg_date,
                            q.sd_inc.uinfo,
                            q.sd_inc.simptoms,
                            cat = q.sd_inc.sd_cat.name,
                            q.sd_inc.res_date,
                            q.sd_inc.close_date,
                            problem = q.sd_inc.sd_problem.name,
                            q.sd_inc.prior
                        }).Distinct();
           dgvinc.DataSource = dsinc;
        }

        private void refresh_detai_grid()
        {
            // dgvinc.id;
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


        private void btnnew_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgvinc.CurrentRow.Cells["id"].Value.ToString());
            frm_class_inc class_inc = new frm_class_inc(Convert.ToInt64(dgvinc.CurrentRow.Cells["id"].Value),_controller);            

            class_inc.Show();
        }

        private void dgvinc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_class_Load(object sender, EventArgs e)
        {
            Refresh_incs();
            btnclass.Visible = (Current_User.priv == 2) ? true : false;
            bool tmp = (Current_User.priv == 3) ? true : false;
            btnclass.Visible = btnclass.Visible || tmp;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {

        }

        private void dgvinc_SelectionChanged(object sender, EventArgs e)
        {
            refresh_detai_grid();
        }

        private void btn_des_Click(object sender, EventArgs e)
        {
            frm_set_des set_des = new frm_set_des(Convert.ToInt64(dgvinc.CurrentRow.Cells["id"].Value),_controller);
            set_des.Show();
        }

        public override void Users_to_grid(IQueryable<Object> ds)
        {
            dgvusers.DataSource = ds;
        }
        public override void History_to_grid(IQueryable<Object> ds)
        {
            dgvhistory.DataSource = ds;
        }

    }
}

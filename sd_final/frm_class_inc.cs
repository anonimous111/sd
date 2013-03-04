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
    public partial class frm_class_inc : Form
    {
        private long _inc_id;
        private sd_inc _sd_inc;
        private IClassController _controller;
        public frm_class_inc(long inc_id, IClassController controller)
        {
            InitializeComponent();
            this._inc_id = inc_id;
            _controller = controller;
            _sd_inc = _controller.Get_inc_by_id(_inc_id);

            _sd_inc.des = (_sd_inc.des == null) ? "" : _sd_inc.des;
            _sd_inc.prior = (_sd_inc.prior == null) ? 0 : _sd_inc.prior;
            _sd_inc.sd_problem_id = (_sd_inc.sd_problem_id == null) ? 0 : _sd_inc.sd_problem_id;
            this.tb_des.Text = _sd_inc.des.ToString();
            this.tb_prior.Text = _sd_inc.prior.ToString();

            // комбо пользователей
            cb_user.DataSource = _controller.Sd_Class_incident_user_list();
            cb_user.ValueMember = "id";
            cb_user.DisplayMember = "fio";

            // комбо пользователей
            cb_problem.DataSource = _controller.Sd_problem_list();
            cb_problem.ValueMember = "id";
            cb_problem.DisplayMember = "name";
            cb_problem.SelectedValue = this._sd_inc.sd_problem_id;
        }

        private void btn_class_Click(object sender, EventArgs e)
        {
            _controller.class_incident(_inc_id, Convert.ToInt64(tb_prior.Text),
                                        Convert.ToInt64(cb_problem.SelectedValue), tb_des.Text);

        }

        private void refresh_user_list()
        {  
            dgvusers.DataSource =_controller.users_on_inc(_inc_id);
        }

        private void btn_add_2user_Click(object sender, EventArgs e)
        {
            _controller.add_user(_inc_id, Convert.ToInt64(cb_user.SelectedValue));
            refresh_user_list();
        }

        private void frm_class_inc_Load(object sender, EventArgs e)
        {
            if (Current_User.priv == 3)
            {
                this.Text = "Расследование и диагностика";
                label1.Visible = false;
                tb_prior.Visible = false;
                btn_class.Text = "Отравить решение";
            }
            refresh_user_list();

        }

        private void dgvusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvusers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

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
    public partial class frm_new_inc : Form
    {
        private sd_inc inc=new sd_inc();
        private IViewInc _parent;
        private IAddIncController _controller;
        private List<long> _uids=new List<long>();
        //private sd_problem pr = new sd_problem();
        //private sd_users_on_inc uoi;

        public string uinfo { get { return tb_uinfo.Text; } set { tb_uinfo.Text = value; } }
        public string simptoms { get { return tb_simptoms.Text; } set { tb_simptoms.Text = value; } }
        public long cat 
        { 
            get { return Convert.ToInt64(cb_cat.SelectedValue); } 
            set { cb_cat.SelectedValue = value; } 
        }
        public List<long> uids { get { return _uids; } set { _uids=value;} }

        public bool Is_valid_uinfo()
        {
            return uinfo.Length > 0;
            //return false;
        }

        public bool Is_valid_simptoms()
        {
            return simptoms.Length > 0;
        }

        public bool Is_valid_uids()
        {
            return uids.Count>0;
        }

        public bool Can_register_incident()
        {
            return Is_valid_uinfo() && Is_valid_simptoms() && Is_valid_uids(); 
        }

        public frm_new_inc(IViewInc parent,IAddIncController controller)
        {
            InitializeComponent();
            _parent = parent;
            _controller = controller;
        }

        private void bnt_reg_inc_Click(object sender, EventArgs e)
        {
            if (Can_register_incident())
            { _controller.add_inc(uinfo, simptoms, cat, uids); }
            this.Close();
        }

        private void frm_new_inc_Load(object sender, EventArgs e)
        {
            //комбо категорий
            cb_cat.DataSource = _controller.Sd_cat_list();
            cb_cat.ValueMember = "id";
            cb_cat.DisplayMember = "name";

            // комбо пользователей
            cb_user.DataSource = _controller.Sd_reg_incident_user_list();
            cb_user.ValueMember = "id";
            cb_user.DisplayMember = "fio";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            uids.Add(Convert.ToInt64(cb_user.SelectedValue));            
            dgusers.Rows.Add((cb_user.SelectedItem as sd_user).fio );          
        }

    }
}

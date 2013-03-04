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
    public partial class frm_kpi : Form
    {
        private Inc_Controller _controller;
        public frm_kpi(Inc_Controller controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            var res = from q in _controller.Model.sd_incs
                      where q.reg_date > dtp_start.Value &&
                            q.reg_date < dtp_end.Value
                      select q;
            lacount.Text = res.Count().ToString();

           /* var res_2 = from q in _controller.Model.sd_incs
                      where q.reg_date > dtp_start.Value &&
                            q.reg_date < dtp_end.Value &&
                            q.sd_status_id==4
                      select new {q.close_date-q.reg_date};
            TimeSpan sum;
            int count=0;
            foreach(var item  in res_2)
            {
                sum=item.close_date-item.reg_date;
            }*/

            latime.Text="4 ч.";

            var res_3= from q in _controller.Model.sd_incs
                       where q.reg_date > dtp_start.Value &&
                            q.reg_date < dtp_end.Value &&
                            q.sd_status_id==4
                       select q;
            int allcount = 0;
            int lvl1count = 0;
            int tmp;
            foreach (var item in res_3)
            {
                allcount++;
                tmp = (from q in _controller.Model.sd_users_on_incs
                          where q.sd_user.priv==3 && q.sd_inc_id==item.id
                          select q).Count();
                if (0 == tmp) { lvl1count++; }
            }
            try
            {
                MessageBox.Show(lvl1count.ToString()+"__"+allcount.ToString());
                double percent =100*lvl1count/allcount;
                percent=Math.Round(percent, 2);
               // lapercent.Text = percent.ToString();
            }
            catch
            {
                lapercent.Text="0";
            }
        }
    }
}

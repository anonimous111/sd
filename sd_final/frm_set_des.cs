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
    public partial class frm_set_des : Form
    {
        private long _inc_id;
        private ISetDesController _controller;

         public string des {
             get { return tb_desinfo.Text; } 
            set{tb_desinfo.Text=value;}
        }

        public frm_set_des(long inc_id,ISetDesController controller)
        {
            InitializeComponent();
            _controller = controller;
            _inc_id = inc_id;
            //определяется инцидент
            var inc = _controller.Get_inc_by_id(_inc_id);

            inc.desinfo = (inc.desinfo == null) ? "" : inc.desinfo;
            tb_desinfo.Text = inc.desinfo;
        }

        public bool can_set_des()
        {
            return des.Length > 0;
        }

       

        private void btndes_Click(object sender, EventArgs e)
        {
            if (can_set_des())
            {
                _controller.set_des(_inc_id, tb_desinfo.Text);
            }

        }
    }
}

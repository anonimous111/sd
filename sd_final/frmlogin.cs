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
    public partial class frmlogin : Form
    {
        public static DataClasses1DataContext context = new DataClasses1DataContext();
        public static frminc_reg regform;
        public static frm_class classform;
        public frmlogin()
        {
            InitializeComponent();

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
          /*  Current_User.Auth("reg","reg");
            Current_User.Auth("1", "1");
            Current_User.Auth("2", "2");
            Current_User.Auth("man", "man");

            //Current_User.Auth("reg", "reg");
           // Current_User.Auth("2", "2");

            regform = new frminc_reg();
            classform = new frm_class();
            
            regform.Show();*/
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Current_User.Auth(tb_login.Text,tb_pas.Text);
            if (Current_User.priv == 4 || Current_User.priv == 1) 
            { 
                regform = new frminc_reg();
                this.Hide();
                regform.Show();
            }
            else
            {
                classform = new frm_class();
                this.Hide();
                classform.Show();
            }
        }
    }
}

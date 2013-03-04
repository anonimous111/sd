using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sd_final
{
    public abstract class BaseIncForm : Form, IViewInc
    {
        protected Inc_Controller _controller;

        public BaseIncForm()
        {
            _controller = new Inc_Controller(this);
        }
        public abstract void History_to_grid(IQueryable<Object> ds);
        public abstract void Users_to_grid(IQueryable<Object> ds);
        public abstract void Refresh_incs();
        public void Refresh_history(long inc_id)
        {
            var ds_history = from q in _controller.Model.sd_histories
                             where q.sd_inc_id == inc_id
                             select new
                             {
                                 date = q.date,
                                 fio = q.sd_user.fio ?? "",
                                 action = q.action ?? "",
                                 a_descr = q.a_descr ?? ""
                             };
            History_to_grid(ds_history);
        }

        public void Refresh_users(long inc_id)
        {
            var ds_users = from q in _controller.Model.sd_users_on_incs
                           where q.sd_inc_id == inc_id
                           select new { fio = q.sd_user.fio ?? "" };
            Users_to_grid(ds_users);
        }
    }
}

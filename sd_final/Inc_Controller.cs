using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sd_final
{
    public class Inc_Controller:IAddIncController,ISetDesController,IClassController
    {
        private DataClasses1DataContext _model ;
        private IViewInc _view;
        private sd_inc _sd_inc;

        public DataClasses1DataContext Model { get { return _model; } }

        public Inc_Controller(IViewInc view)
        {
            _model = DB_Context.context;
            _view = view;
        }

        public void Close_inc(long inc_id)
        {            
            find_inc(inc_id);
            cur_inc.sd_status_id = 4;
            
            sd_history new_h = new sd_history();
            new_h.action = "Закрытие";
            new_h.date = DateTime.Now;
            new_h.sd_user_id = Current_User.id;
            cur_inc.sd_histories.Add(new_h);
            _model.SubmitChanges();
            _view.Refresh_incs();
        }

        private sd_inc cur_inc {get{return _sd_inc;}set{_sd_inc=value;}}

        private void find_inc(long inc_id)
        {
            sd_inc search_inc = (from q in _model.sd_incs
                                  where q.id == inc_id
                                  select q).SingleOrDefault();
            cur_inc = search_inc;
        }

        public bool Add_inc(string uinfo, string simptoms, long cat, IList<long> ulist)
        {
            return false;
        }

        public IQueryable<sd_cat> Sd_cat_list()
        {
            return from p in frmlogin.context.sd_cats select p;
        }

        public IQueryable<sd_user> Sd_reg_incident_user_list()
        {
            return from q in frmlogin.context.sd_users where q.priv == 2 select q;
        }

        public IQueryable<sd_user> Sd_Class_incident_user_list()
        {
            return from q in frmlogin.context.sd_users where q.priv == 3 select q;
        }

        public IQueryable<sd_problem> Sd_problem_list()
        {
            return from q in frmlogin.context.sd_problems select q;
        }

        public void add_inc(string uinfo, string simptoms, long cat, IList<long> uids)
        {
            sd_inc inc = new sd_inc();
            inc.reg_date = DateTime.Now;
            inc.uinfo = uinfo;
            inc.simptoms = simptoms;
            inc.sd_cat_id = cat;
            inc.sd_status_id = 1;

            sd_history new_h = new sd_history();
            new_h.action = "регистрация";
            new_h.date = DateTime.Now;
            new_h.sd_user_id = Current_User.id;
            inc.sd_histories.Add(new_h);

            foreach(var item in uids)
            {
                sd_users_on_inc new_u=new sd_users_on_inc();
                new_u.sd_user_id = item;
                new_u.sd_user = _model.sd_users.FirstOrDefault(r => r.id == new_u.sd_user_id);
                inc.sd_users_on_incs.Add(new_u);

                new_h = new sd_history();
                new_h.action="назначен специалист";
                new_h.date = DateTime.Now;
                new_h.sd_user_id = Current_User.id;
                new_h.a_descr = new_u.sd_user.fio;
                inc.sd_histories.Add(new_h);
            }
            _model.sd_incs.InsertOnSubmit(inc);
            _model.SubmitChanges();
            _view.Refresh_incs();                
        }

        public void set_des(long inc_id,string des)
        {
            find_inc(inc_id);
            cur_inc.desinfo = des;
            cur_inc.sd_status_id = 3;
            cur_inc.res_date = DateTime.Now;

            sd_history new_h = new sd_history();
            new_h.sd_inc_id = cur_inc.id;
            new_h.sd_user_id = Current_User.id;
            new_h.action = "Разрешение";
            new_h.a_descr = this._sd_inc.desinfo;
            new_h.date = DateTime.Now;
            cur_inc.sd_histories.Add(new_h);
            _model.SubmitChanges();
            _view.Refresh_incs();
        }

        public sd_inc Get_inc_by_id(long inc_id)
        {
            return (from q in _model.sd_incs
                            where q.id == inc_id
                            select q).SingleOrDefault();
        }

        public void class_incident(long inc_id,long prior, long problem, string des)
        {
            find_inc(inc_id);
            cur_inc.prior = prior;
            cur_inc.sd_problem_id = problem;
            cur_inc.des = des;
            cur_inc.sd_status_id = 2;
            cur_inc.sd_problem=(from q in _model.sd_problems where q.id==problem select q).SingleOrDefault();

            sd_history new_h = new sd_history();
            new_h.sd_inc_id = inc_id;
            new_h.sd_user_id = Current_User.id;
            new_h.action="Классификация";
            new_h.a_descr="Приоритет:"+prior.ToString()+" Проблема"+cur_inc.sd_problem.name+" Решение:"+des;
            new_h.date = DateTime.Now;
            cur_inc.sd_histories.Add(new_h);
            _model.SubmitChanges();
            _view.Refresh_incs();
        }

        public void add_user(long inc_id, long uid)
        {
            find_inc(inc_id);
            sd_users_on_inc new_u = new sd_users_on_inc();
            new_u.sd_user_id = uid;
            new_u.sd_user = _model.sd_users.FirstOrDefault(r => r.id == new_u.sd_user_id);
            cur_inc.sd_users_on_incs.Add(new_u);

            sd_history new_h = new sd_history();
            new_h.action = "назначен специалист 2 уровня";
            new_h.date = DateTime.Now;
            new_h.sd_user_id = Current_User.id;
            new_h.a_descr = new_u.sd_user.fio;
            cur_inc.sd_histories.Add(new_h);

            _model.SubmitChanges();
        }

        public IQueryable<Object> users_on_inc(long inc_id)
        {
            return from q in _model.sd_users_on_incs
                   where q.sd_inc_id == inc_id
                   select new { q.sd_user.fio };
        }
    }
}

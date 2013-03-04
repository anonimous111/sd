using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sd_final
{
    public interface IViewInc
    {
        void Refresh_incs();
    }

    public interface IAddIncController
    {
        IQueryable<sd_cat> Sd_cat_list();
        IQueryable<sd_user> Sd_reg_incident_user_list();
        void add_inc(string uinfo,string simptoms,long cat, IList<long> uids);
    }

    public interface ISetDesController
    {
        void set_des(long inc_id,string des);
        sd_inc Get_inc_by_id(long inc_id);
    }

    public interface IClassController    
    {
        sd_inc Get_inc_by_id(long inc_id);
        IQueryable<sd_user> Sd_Class_incident_user_list();
        IQueryable<sd_problem> Sd_problem_list();
        void class_incident(long inc_id,long prior,long problem,string des);
        void add_user(long inc_id, long uid);
        IQueryable<Object> users_on_inc(long inc_id);
    }
}

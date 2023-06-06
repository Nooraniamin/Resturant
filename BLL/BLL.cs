using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class bll_Student
    {
        public void saveStudent(string _sId, string _sName,string address)
        {
            DAL.DAL dalObj = new DAL.DAL();
            dalObj.OpenConnection();
            dalObj.LoadSpParameters("st_insertCustomer", _sId, _sName,address);
            dalObj.ExecuteQuery();
            dalObj.UnLoadSpParameters();
            dalObj.CloseConnection();

        }
        public void update(Int64 id, string _sId, string _sName, string address)
        {
            DAL.DAL dalObj = new DAL.DAL();
            dalObj.OpenConnection();
            dalObj.LoadSpParameters("st_updatecustomers", id, _sId, _sName,address);
            dalObj.ExecuteQuery();
            dalObj.UnLoadSpParameters();
            dalObj.CloseConnection();

        }
        public void delete(Int64 id)
        {
            DAL.DAL dalObj = new DAL.DAL();
            dalObj.OpenConnection();
            dalObj.LoadSpParameters("st_deletecustomer", id);
            dalObj.ExecuteQuery();
            dalObj.UnLoadSpParameters();
            dalObj.CloseConnection();

        }
    }
}

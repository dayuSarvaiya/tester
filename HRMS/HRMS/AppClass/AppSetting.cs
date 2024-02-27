using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.AppClass
{
    public class AppSetting
    {
        private DateTime _PasswordChangeDate = DateTime.Now.AddYears(-2);
        [Browsable(false)]
        public DateTime PasswordChangeDate
        {
            get { return _PasswordChangeDate; }
            set { _PasswordChangeDate = value; }
        }

        private const string CatDatabase = "Database Connection";
        private string _ConnectionString = "Data Source=192.168.2.6,49111;Initial Catalog=HC&PMS;User id=Dhruv;Password=Sa@1234";
        [Description("DataBase connection string"), Category(CatDatabase)]
        public string ConnectionString
        {
            get { return _ConnectionString; }
            set { _ConnectionString = value; }
        }
    }
}
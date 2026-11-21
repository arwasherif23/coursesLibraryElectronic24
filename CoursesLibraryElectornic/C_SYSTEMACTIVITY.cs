using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CoursesLibraryElectornic
{
    public class C_SYSTEMACTIVITY : ProMng, OpreationProject
    {
        private string _ID_Activity;
        private string _Activity;
        private DateTime _ActivityDate;
        private string _ID_User;

        public string ID_Activity
        {
            get
            {
                return _ID_Activity;
            }

            set
            {
                _ID_Activity = value;
            }
        }

        public string Activity
        {
            get => default;
            set
            {
            }
        }

        public System.DateTime ActivityDate
        {
            get => default;
            set
            {
            }
        }

        public string ID_User
        {
            get => default;
            set
            {
            }
        }

        public string AddData()
        {
            throw new NotImplementedException();
        }

        public string DeleteData()
        {
            throw new NotImplementedException();
        }

        public DataTable SearshData()
        {
            throw new NotImplementedException();
        }

        public string UpdateData()
        {
            throw new NotImplementedException();
        }
    }
}
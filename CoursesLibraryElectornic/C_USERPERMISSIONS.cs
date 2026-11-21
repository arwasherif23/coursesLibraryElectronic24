using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CoursesLibraryElectornic
{
    public class C_USERPERMISSIONS : ProMng, OpreationProject
    {
        private string _ID_User;
        private string _ID_Prem;

        public string ID_User
        {
            get
            {
                return _ID_User;
            } 

            set
            {
                _ID_User = value;
            }
        }

        public string ID_Prem
        {
            get => default;
            set
            {
            }
        }

        public C_SYSTEMPREMISSION C_SYSTEMPREMISSION
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
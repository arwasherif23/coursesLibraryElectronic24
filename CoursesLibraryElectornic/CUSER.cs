using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CoursesLibraryElectornic
{
    public class C_USER : ProMng, OpreationProject
    {
        private string _User_ID;
        private string _First_Name;
        private string _Last_Nme;
        private string _Email;
        private string _Password_Hash;
        private string _Phone;
        private string _Role;
        private System.DateTime _Created_At;
        private bool _Is_Active;
        private System.DateTime? _Last_Login;

        public string User_ID
        {
            get
            {
                return _User_ID;
            }

            set
            {
                _User_ID = value;
            }
        }

        public string First_Name
        {
            get => default;
            set
            {
            }
        }

        public string Last_Nme
        {
            get => default;
            set
            {
            }
        }

        public string Email
        {
            get => default;
            set
            {
            }
        }

        public string Password_Hash
        {
            get => default;
            set
            {
            }
        }

        public string Phone
        {
            get => default;
            set
            {
            }
        }

        public string Role
        {
            get => default;
            set
            {
            }
        }

        public System.DateTime Created_At
        {
            get => default;
            set
            {
            }
        }

        public bool Is_Active
        {
            get => default;
            set
            {
            }
        }

        public System.DateTime? Last_Login
        {
            get => default;
            set
            {
            }
        }

        public C_SUBMISSION C_SUBMISSION
        {
            get => default;
            set
            {
            }
        }

        public C_ENROLLMENTS C_ENROLLMENTS
        {
            get => default;
            set
            {
            }
        }

        public C_SYSTEMACTIVITY C_SYSTEMACTIVITY
        {
            get => default;
            set
            {
            }
        }

        public C_RESULTS C_RESULTS
        {
            get => default;
            set
            {
            }
        }

        public C_USERPERMISSIONS C_USERPERMISSIONS
        {
            get => default;
            set
            {
            }
        }

        public C_ENROLLMENTS C_ENROLLMENTS1
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
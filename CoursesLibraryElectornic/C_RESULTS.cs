using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CoursesLibraryElectornic
{
    public class C_RESULTS : ProMng, OpreationProject
    {
        private string _ID_Results;
        private string _ID_Quiz;
        private string _ID_User;
        private decimal _Score;
        private System.DateTime _Result_Date;
        private string _Status;
        private int _Attempt_No;
        private int _Time_Taken_Min;
        private decimal _Percentaga;

        public string ID_Results
        {
            get
            {
                return _ID_Results;
            }
            set
            {
                _ID_Results = value;
            }
        }

        public string ID_Quiz
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

        public decimal Score
        {
            get => default;
            set
            {
            }
        }

        public System.DateTime Result_Date
        {
            get => default;
            set
            {
            }
        }

        public string Status
        {
            get => default;
            set
            {
            }
        }

        public int Attempt_No
        {
            get => default;
            set
            {
            }
        }

        public int Time_Taken_Min
        {
            get => default;
            set
            {
            }
        }

        public decimal Percentaga
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
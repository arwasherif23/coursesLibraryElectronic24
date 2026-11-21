using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CoursesLibraryElectornic
{
    public class C_ENROLLMENTS : ProMng, OpreationProject
    {
        private string _ID_Enrollment;
        private string _ID_User;
        private string _ID_Training;
        private System.DateTime _Enrollment_Date;
        private string _Status;
        private decimal _Completion_Pct;
        private System.DateTime? _Completion_Date;

        public string ID_Enrollment
        {
            get
            {
                return _ID_Enrollment;
            } 
           
            set
            {
                _ID_Enrollment = value;
            }
        }

        public string ID_User
        {
            get => default;
            set
            {
            }
        }

        public string ID_Training
        {
            get => default;
            set
            {
            }
        }

        public System.DateTime Enrollment_Date
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

        public decimal Completion_Pct
        {
            get => default;
            set
            {
            }
        }

        public System.DateTime? Completion_Date
        {
            get => default;
            set
            {
            }
        }

        public string AddData()
        {
            string s = "insert into ENROLLMENTS values ( '"
              + ID_Enrollment + "','" + ID_User + "','" + ID_Training +
              "','" + Enrollment_Date + "','" + Status + "','" +
              Completion_Pct + "','" + Completion_Date + "')"  ;


            string msg = RunInsDelUpd(s);
            if (msg == "OK")
                return "Add succeeded";
            else
                return msg;
        }

        public string DeleteData()
        {
            string s = "Update ENROLLMENTS set  ( '"

              ;


            string msg = RunInsDelUpd(s);
            if (msg == "OK")
                return "Delete succeeded";
            else
                return msg;
        }

        public DataTable SearshData()
        {
            throw new NotImplementedException();
        }

        public string UpdateData()
        {
            string s = "Update ENROLLMENTS set  ( '"

              ;


            string msg = RunInsDelUpd(s);
            if (msg == "OK")
                return "Update succeeded";
            else
                return msg;
        }
    }
}
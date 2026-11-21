using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CoursesLibraryElectornic
{
    public class C_TACKS : ProMng, OpreationProject
    {
        private string _ID_Tacks;
        private string _ID_Courses;
        private string _Tack_Name;
        private string _Description;
        private System.DateTime _Deadline;
        private decimal _Max_Score;
        private string _Attachment_URL;
        private bool _Allow_Resubmit;
        private System.DateTime _Created_At;

        public string ID_Tacks
        {
            get
            {
                return _ID_Tacks;
            }

            set
            {
                _ID_Tacks = value;
            }
        }

        public string ID_Courses
        {
            get => default;
            set
            {
            }
        }

        public string Tack_Name
        {
            get => default;
            set
            {
            }
        }

        public string Description
        {
            get => default;
            set
            {
            }
        }

        public DateTime Deadline
        {
            get => default;
            set
            {
            }
        }

        public decimal Max_Score
        {
            get => default;
            set
            {
            }
        }

        public string Attachment_URL
        {
            get => default;
            set
            {
            }
        }

        public bool Allow_Resubmit
        {
            get => default;
            set
            {
            }
        }

        public DateTime Created_At
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